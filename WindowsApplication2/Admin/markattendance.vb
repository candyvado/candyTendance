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

    Private Sub markAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
        SetupLabels()
        SafeLoadAttendanceListView()
        lastResetLabel.Text = "Last Reset Time: --:--:--"
        'CheckDailyReset()

        Capturer = New DPFP.Capture.Capture()
        If Capturer IsNot Nothing Then
            Capturer.EventHandler = Me
            Try
                Capturer.StartCapture()
                SafeUpdateLabel(markAttendanceStatusLabel, "Scanner ready. Awaiting finger...", Color.DarkOrange)
            Catch ex As Exception
                MessageBox.Show("Unable to start capture: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Cannot initialize fingerprint scanner.")
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_label.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_label.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
        'CheckDailyReset()
    End Sub

    'Private Sub CheckDailyReset()
    'Dim currentDate As Date = DateTime.Now.Date

    'If lastAttendanceDate <> currentDate Then
    'markAttendanceRecordList.Items.Clear()
    'lastAttendanceDate = currentDate
    'lastResetTime = DateTime.Now.ToString("hh:mm:ss tt")
    'lastResetLabel.Text = "Last Reset Time: " & lastResetTime
    'End If
    'End Sub

    'SAFE UI UPDATERS
    Private Sub SafeUpdateLabel(ByVal label As Control, ByVal text As String, ByVal color As Color)
        If label.InvokeRequired Then
            label.Invoke(Sub()
                             label.Text = text
                             label.ForeColor = color
                         End Sub)
        Else
            label.Text = text
            label.ForeColor = color
        End If
    End Sub

    Private Sub SafeUpdateTextBox(ByVal textbox As Object, ByVal text As String)
        If textbox.InvokeRequired Then
            textbox.Invoke(Sub()
                               Try
                                   textbox.Text = text
                               Catch ex As Exception
                                   MessageBox.Show("Textbox error: " & ex.Message)
                               End Try
                           End Sub)
        Else
            Try
                textbox.Text = text
            Catch ex As Exception
                MessageBox.Show("Textbox error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub SafeUpdateImage(ByVal picBox As Object, ByVal bmp As Image)
        If picBox.InvokeRequired Then
            picBox.Invoke(Sub() picBox.Image = bmp)
        Else
            picBox.Image = bmp
        End If
    End Sub


    Private Sub SafeUpdateTimeSlot(ByVal text As String)
        If markAttendanceTimeSlot.InvokeRequired Then
            markAttendanceTimeSlot.Invoke(Sub() markAttendanceTimeSlot.Text = text)
        Else
            markAttendanceTimeSlot.Text = text
        End If
    End Sub

    Private Sub SafeUpdateListView(ByVal fullName As String, ByVal emailAddress As String, ByVal timeSlot As String, ByVal status As String)
        If markAttendanceRecordList.InvokeRequired Then
            'markAttendanceRecordList.Invoke(Sub() AddListViewItem(fullName, emailAddress, timeSlot, status))
            'Else
            'AddListViewItem(fullName, emailAddress, timeSlot, status)
        End If
    End Sub

    Private Sub AddListViewItem(ByVal fullName As String, ByVal emailAddress As String, ByVal timeSlot As String, ByVal status As String)
        Dim item As New ListViewItem(fullName)
        item.SubItems.Add(emailAddress)
        item.SubItems.Add(timeSlot)
        item.SubItems.Add(DateTime.Now.ToString("hh:mm:ss tt"))
        item.SubItems.Add(status)
        markAttendanceRecordList.Items.Add(item)
    End Sub

    Private Sub SafeLoadAttendanceListView()
        If markAttendanceRecordList.InvokeRequired Then
            markAttendanceRecordList.Invoke(Sub() LoadAttendanceListView())
        Else
            LoadAttendanceListView()
        End If
    End Sub

    'EVENT HANDLERS
    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Dim features = ExtractFeatures(Sample)
        If features Is Nothing Then
            SafeUpdateLabel(markAttendanceStatusLabel, "Poor quality fingerprint. Try again.", Color.Red)
            Exit Sub
        End If

        Dim connection = functions.connection
        Try
            connection.Open()
            query = "SELECT s.studentId, s.fullName, s.emailAddress, s.passport, s.statusId, f.fingerPrintTemplate FROM student_tab s JOIN fingerprints_tab f ON s.studentId = f.studentId"
            command = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim templateBytes() As Byte = CType(reader("fingerPrintTemplate"), Byte())
                Dim studentTemplate As New DPFP.Template(New MemoryStream(templateBytes))
                Dim result As New DPFP.Verification.Verification.Result()

                Verificator.Verify(features, studentTemplate, result)

                If result.Verified Then
                    If reader("statusId").ToString() <> "1" Then
                        SafeUpdateLabel(markAttendanceStatusLabel, "Student is not active. Contact admin.", Color.Red)
                        Exit Sub
                    End If

                    Dim fullName = reader("fullName").ToString()
                    Dim emailAddress = reader("emailAddress").ToString()
                    Dim studentId = reader("studentId").ToString()
                    Dim imageBytes() As Byte = CType(reader("passport"), Byte())
                    Dim imageStream As New MemoryStream(imageBytes)

                    SafeUpdateTextBox(CType(fullNameTxt, Object), fullName)
                    SafeUpdateTextBox(CType(emailAddressTxt, Object), emailAddress)
                    SafeUpdateImage(markAttendanceProfilePic, Image.FromStream(imageStream))

                    Dim timeSlot = DetermineTimeSlot(studentId)

                    If timeSlot = "Already Checked Out" Then
                        ' Do not show name/email/image 
                        SafeUpdateTextBox(fullNameTxt, "")
                        SafeUpdateTextBox(emailAddressTxt, "")
                        SafeUpdateImage(markAttendanceProfilePic, Nothing)
                        SafeUpdateTimeSlot("-------")

                        SafeUpdateLabel(markAttendanceStatusLabel, "You have already checked out today.", Color.Red)

                        'clear status after 3 seconds
                        Dim resetTimer As New Timer()
                        AddHandler resetTimer.Tick, Sub()
                                                        SafeUpdateLabel(markAttendanceStatusLabel, "Scan finger to mark attendance", Color.Gray)
                                                        resetTimer.Stop()
                                                    End Sub
                        resetTimer.Interval = 3000
                        resetTimer.Start()

                        Exit Sub
                    End If

                    'Check-In or Check-Out update and display info
                    SafeUpdateTextBox(fullNameTxt, fullName)
                    SafeUpdateTextBox(emailAddressTxt, emailAddress)
                    SafeUpdateImage(markAttendanceProfilePic, Image.FromStream(imageStream))
                    SafeUpdateTimeSlot(timeSlot)

                    If markAttendanceTimeSlot.InvokeRequired Then
                        markAttendanceTimeSlot.Invoke(Sub()
                                                          If timeSlot = "Check-In" Then
                                                              markAttendanceTimeSlot.ForeColor = Color.Green
                                                          Else
                                                              markAttendanceTimeSlot.ForeColor = Color.Maroon
                                                          End If
                                                      End Sub)
                    Else
                        If timeSlot = "Check-In" Then
                            markAttendanceTimeSlot.ForeColor = Color.Green
                        Else
                            markAttendanceTimeSlot.ForeColor = Color.Maroon
                        End If
                    End If

                    SafeUpdateLabel(markAttendanceStatusLabel, "Attendance successful.", Color.Green)
                    SaveAttendance(studentId, fullName, emailAddress, timeSlot)
                    SafeUpdateListView(fullName, emailAddress, timeSlot, "Success")

                    Dim successTimer As New Timer()
                    AddHandler successTimer.Tick, Sub()
                                                      SafeUpdateTextBox(fullNameTxt, "")
                                                      SafeUpdateTextBox(emailAddressTxt, "")
                                                      SafeUpdateImage(markAttendanceProfilePic, Nothing)
                                                      SafeUpdateTimeSlot("-------")
                                                      SafeUpdateLabel(markAttendanceStatusLabel, "Scan finger to mark attendance", Color.Gray)
                                                      successTimer.Stop()
                                                  End Sub
                    successTimer.Interval = 5000
                    successTimer.Start()

                    Exit Sub
                End If
            End While

            SafeUpdateLabel(markAttendanceStatusLabel, "No matching fingerprint found.", Color.Red)
        Catch ex As Exception
            MessageBox.Show("Error verifying fingerprint: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'OTHER METHODS
    Private Sub SaveAttendance(ByVal studentId As String, ByVal fullName As String, ByVal emailAddress As String, ByVal action As String)
        Dim connection = functions.connection
        Try
            connection.Open()
            Dim nowTime = DateTime.Now.ToString("HH:mm:ss")
            Dim todayDate = DateTime.Now.ToString("yyyy-MM-dd")
            functions.countId("ATTEND")

            If action = "Check-In" Then
                query = "INSERT INTO attendance_tab(studentId, fullName, emailAddress, attendanceDate, checkInTime, statusId, clockStatus, createdTime) VALUES(@studentId, @fullName, @emailAddress, @attendanceDate, @checkInTime, 1, 'Success', NOW())"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@fullName", fullName)
                command.Parameters.AddWithValue("@emailAddress", emailAddress)
                command.Parameters.AddWithValue("@attendanceDate", todayDate)
                command.Parameters.AddWithValue("@checkInTime", nowTime)
                command.ExecuteNonQuery()
            Else
                query = "UPDATE attendance_tab SET checkOutTime=@outTime, updatedTime=NOW() WHERE studentId=@studentId AND attendanceDate=@date"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentId", studentId)
                command.Parameters.AddWithValue("@outTime", nowTime)
                command.Parameters.AddWithValue("@date", todayDate)
                command.ExecuteNonQuery()
            End If

            SafeLoadAttendanceListView()
            Dim updatedCounts = functions.allCounts()
            If adminportal.InvokeRequired Then
                adminportal.Invoke(Sub()
                                       adminportal.totalRecordLabel.Text = updatedCounts.Item4.ToString()
                                       adminportal.totalRecordLabel.Refresh()
                                   End Sub)
            Else
                adminportal.totalRecordLabel.Text = updatedCounts.Item4.ToString()
                adminportal.totalRecordLabel.Refresh()
            End If


        Catch ex As Exception
            MessageBox.Show("Save attendance error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Function DetermineTimeSlot(ByVal studentId As String) As String
        Dim today = DateTime.Now.Date
        Dim connection = functions.connection
        connection.Open()

        Dim query = "SELECT checkInTime, checkOutTime FROM attendance_tab WHERE studentId=@studentId AND attendanceDate=@date"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@studentId", studentId)
        command.Parameters.AddWithValue("@date", today)
        Dim reader = command.ExecuteReader()

        If reader.Read() Then
            Dim checkInTime = reader("checkInTime").ToString()
            Dim checkOutTime = reader("checkOutTime").ToString()

            If checkInTime <> "" AndAlso checkOutTime <> "" Then
                connection.Close()
                Return "Already Checked Out"

            ElseIf checkInTime <> "" Then
                connection.Close()
                Return "Check-Out"
            End If
        End If

        connection.Close()
        Return "Check-In"

    End Function

    Private Function ExtractFeatures(ByVal sample As DPFP.Sample) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = Nothing
        Dim features As DPFP.FeatureSet = New DPFP.FeatureSet()

        extractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Verification, feedback, features)
        If feedback = DPFP.Capture.CaptureFeedback.Good Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Private Sub LoadAttendanceListView()
        Try
            Dim connection As MySqlConnection = functions.connection
            Dim query As String = "SELECT fullName, attendanceDate, checkInTime, checkOutTime FROM attendance_tab WHERE attendanceDate = CURDATE() ORDER BY createdTime DESC"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            markAttendanceRecordList.Items.Clear()
            Dim sn As Integer = 1

            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem(sn.ToString())
                listItem.SubItems.Add(row("fullName").ToString())
                listItem.SubItems.Add(Convert.ToDateTime(row("attendanceDate")).ToString("yyyy-MM-dd"))
                listItem.SubItems.Add(Convert.ToDateTime(row("attendanceDate")).ToString("dddd"))
                listItem.SubItems.Add(row("checkInTime").ToString())
                listItem.SubItems.Add(row("checkOutTime").ToString())

                Dim checkIn = row("checkInTime").ToString()
                Dim checkOut = row("checkOutTime").ToString()

                If checkIn <> "" And checkOut = "" Then
                    listItem.BackColor = Color.LightGreen
                ElseIf checkIn <> "" And checkOut <> "" Then
                    listItem.BackColor = Color.LightBlue
                Else
                    listItem.BackColor = Color.LightCoral
                End If

                markAttendanceRecordList.Items.Add(listItem)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Error loading attendance: " & ex.Message)
        End Try
    End Sub
    'EVENT HELPERS
    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        SafeUpdateLabel(markAttendanceStatusLabel, "Finger removed from scanner.", Color.DarkOrange)
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        SafeUpdateLabel(markAttendanceStatusLabel, "Finger placed on scanner.", Color.DarkOrange)
    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        SafeUpdateLabel(markAttendanceStatusLabel, "Fingerprint reader connected.", Color.Green)
    End Sub

    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        SafeUpdateLabel(markAttendanceStatusLabel, "Fingerprint reader disconnected.", Color.Red)
    End Sub

    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            SafeUpdateLabel(markAttendanceStatusLabel, "Good fingerprint sample.", Color.Green)
        Else
            SafeUpdateLabel(markAttendanceStatusLabel, "Bad fingerprint sample. Try again.", Color.Red)
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

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()

        Try
            If Capturer IsNot Nothing Then
                Capturer.StopCapture()
                Capturer.Dispose()
                Capturer = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error stopping capturer: " & ex.Message)
        End Try
    End Sub
End Class
