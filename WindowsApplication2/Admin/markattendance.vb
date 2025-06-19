Imports MySql.Data.MySqlClient
Imports System.IO
Imports DPFP
Imports DPFP.Capture

Public Class markAttendance
    Implements DPFP.Capture.EventHandler

    Dim command As MySqlCommand
    Dim query As String
    Private lastAttendanceDate As Date = Date.MinValue
    Private lastResetTime As String = "--:--:--"
    Private WithEvents Capturer As DPFP.Capture.Capture
    Private Template As DPFP.Template
    Private Verificator As New DPFP.Verification.Verification()

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub markAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()

        SetupLabels()
        LoadAttendanceListView()
        lastResetLabel.Text = "Last Reset Time: --:--:--"
        'CheckDailyReset()

        Capturer = New DPFP.Capture.Capture()
        If Capturer IsNot Nothing Then
            Capturer.EventHandler = Me
            Try
                Capturer.StartCapture()
                markAttendanceStatusLabel.Text = "Scanner ready. Awaiting finger..."
            Catch ex As Exception
                MessageBox.Show("Unable to start capture: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Cannot initialize fingerprint scanner.")
        End If
    End Sub

    Private Sub SetupLabels()
        time_label.ForeColor = Color.Maroon
        time_label.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        time_label.AutoSize = True

        date_label.Font = New Font("Microsoft Tai Le", 9, FontStyle.Regular)
        date_label.ForeColor = Color.Black
        date_label.AutoSize = True
    End Sub

    Private Sub CheckDailyReset()
        Dim currentDate As Date = DateTime.Now.Date

        If lastAttendanceDate <> currentDate Then
            markAttendanceRecordList.Items.Clear()
            lastAttendanceDate = currentDate
            lastResetTime = DateTime.Now.ToString("hh:mm:ss tt")
            lastResetLabel.Text = "Last Reset Time: " & lastResetTime
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_label.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_label.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
        'CheckDailyReset()
    End Sub

    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Dim features = ExtractFeatures(Sample)
        If features Is Nothing Then
            markAttendanceStatusLabel.Text = "Poor quality fingerprint. Try again."
            Exit Sub
        End If

        Dim connection = functions.connection
        Try
            connection.Open()
            query = "SELECT s.studentId, s.fullName, s.emailAddress, s.passport, s.statusId, f.fingerPrintTemplate FROM student_tab s JOIN student_fingerprint_tab f ON s.studentId = f.studentId"
            command = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim templateBytes() As Byte = CType(reader("fingerPrintTemplate"), Byte())
                Dim studentTemplate As New DPFP.Template(New MemoryStream(templateBytes))
                Dim result As New DPFP.Verification.Verification.Result()

                Verificator.Verify(features, studentTemplate, result)

                If result.Verified Then
                    If reader("statusId").ToString() <> "1" Then
                        markAttendanceStatusLabel.Text = "Student is not active. Contact admin."
                        Exit Sub
                    End If

                    Dim fullName = reader("fullName").ToString()
                    Dim emailAddress = reader("emailAddress").ToString()
                    Dim studentId = reader("studentId").ToString()
                    Dim imageBytes() As Byte = CType(reader("passport"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)

                    fullNameTxt.Text = fullName
                    emailAddressTxt.Text = emailAddress
                    markAttendanceProfilePic.Image = Image.FromStream(imageStream)
                    markAttendanceTimeSlot.Text = DetermineTimeSlot(studentId)
                    markAttendanceStatusLabel.Text = "Attendance successful."

                    SaveAttendance(studentId, fullName, emailAddress, markAttendanceTimeSlot.Text)
                    UpdateListView(fullName, emailAddress, markAttendanceTimeSlot.Text, "Success")

                    Dim resetTimer As New Timer()
                    AddHandler resetTimer.Tick, Sub()
                                                    fullNameTxt.Text = ""
                                                    emailAddressTxt.Text = ""
                                                    markAttendanceProfilePic.Image = Nothing
                                                    markAttendanceTimeSlot.Text = "--"
                                                    markAttendanceStatusLabel.Text = "Click scan to mark attendance"
                                                    resetTimer.Stop()
                                                End Sub
                    resetTimer.Interval = 5000
                    resetTimer.Start()
                    Exit Sub
                End If
            End While

            markAttendanceStatusLabel.Text = "No matching fingerprint found."
        Catch ex As Exception
            MessageBox.Show("Error verifying fingerprint: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Function ExtractFeatures(ByVal sample As DPFP.Sample) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = Nothing
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Verification, feedback, features)
        Return If(feedback = DPFP.Capture.CaptureFeedback.Good, features, Nothing)
    End Function

    Private Function DetermineTimeSlot(ByVal studentId As String) As String
        Dim today = DateTime.Now.Date
        Dim connection = functions.connection
        connection.Open()
        Dim checkQuery As New MySqlCommand("SELECT COUNT(*) FROM attendance_tab WHERE studentId=@studentId AND attendanceDate=@date", connection)
        checkQuery.Parameters.AddWithValue("@studentId", studentId)
        checkQuery.Parameters.AddWithValue("@date", today)
        Dim alreadyCheckedIn = Convert.ToInt32(checkQuery.ExecuteScalar()) > 0
        connection.Close()
        If Not alreadyCheckedIn Then
            Return "Check-In"
        Else
            Return "Check-Out"
        End If
    End Function

    Private Sub SaveAttendance(ByVal studentId As String, ByVal fullName As String, ByVal emailAddress As String, ByVal action As String)
        Dim connection = functions.connection
        Try
            connection.Open()
            Dim nowTime = DateTime.Now.ToString("HH:mm:ss")
            Dim todayDate = DateTime.Now.ToString("yyyy-MM-dd")

            If action = "Check-In" Then
                query = "INSERT INTO attendance_tab(studentId, fullName, emailAddress, attendanceDate, checkInTime, statusId, clockStatus, createdTime) VALUES(@studentId, @fullName, @emailAddress, @attendanceDate, @checkInTime, 1, 'Success', NOW())"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@fullName", fullName)
                command.Parameters.AddWithValue("@emailAddress", emailAddress)
                command.Parameters.AddWithValue("@attendanceDate", todayDate)
                command.Parameters.AddWithValue("@checkInTime", nowTime)
                command.ExecuteNonQuery()
            Else
                query = "UPDATE attendance_tab SET checkOutTime=@outTime, updatedTime=NOW() WHERE studentId=@studentId AND attendanceDate=@date"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@outTime", nowTime)
                command.Parameters.AddWithValue("@date", todayDate)
                command.ExecuteNonQuery()
            End If
            LoadAttendanceListView()
        Catch ex As Exception
            MessageBox.Show("Save attendance error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadAttendanceListView()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim query As String = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab WHERE attendanceDate = CURDATE() ORDER BY createdTime DESC"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            markAttendanceRecordList.Items.Clear()
            Dim sn As Integer = 1

            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem(sn.ToString())

                listItem.SubItems.Add(row("studentId").ToString())
                listItem.SubItems.Add(row("fullName").ToString())
                listItem.SubItems.Add(row("emailAddress").ToString())
                listItem.SubItems.Add(row("attendanceDate").ToString())
                listItem.SubItems.Add(row("checkInTime").ToString())
                listItem.SubItems.Add(row("checkOutTime").ToString())
                listItem.SubItems.Add(row("clockStatus").ToString())

                markAttendanceRecordList.Items.Add(listItem)
                sn += 1
            Next

        Catch ex As Exception
            MsgBox("Error loading attendance: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateListView(ByVal fullName As String, ByVal emailAddress As String, ByVal action As String, ByVal status As String)
        Dim item As New ListViewItem(fullName)
        item.SubItems.Add(emailAddress)
        item.SubItems.Add(action)
        item.SubItems.Add(DateTime.Now.ToString("hh:mm:ss tt"))
        item.SubItems.Add(status)
        markAttendanceRecordList.Items.Add(item)
    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        markAttendanceStatusLabel.Text = "Finger removed from scanner."
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        markAttendanceStatusLabel.Text = "Finger placed on scanner."
    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        markAttendanceStatusLabel.Text = "Fingerprint reader connected."
    End Sub

    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        Try
            markAttendanceStatusLabel.Text = "Fingerprint reader disconnected."
        Catch ex As Exception
            MessageBox.Show("Disconnection error: " & ex.Message)
        End Try
    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            markAttendanceStatusLabel.Text = "Good fingerprint sample."
        Else
            markAttendanceStatusLabel.Text = "Bad fingerprint sample. Try again."
        End If
    End Sub
End Class
