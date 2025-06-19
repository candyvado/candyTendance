Imports MySql.Data.MySqlClient
Imports System.IO
Imports DPFP
Imports DPFP.Capture
Imports DPFP.Processing
Imports DPFP.Gui

Public Class regstudentfingerprint
    Implements DPFP.Capture.EventHandler

    Private WithEvents capturer As DPFP.Capture.Capture
    Private capturedTemplate As DPFP.Template
    Private enroller As DPFP.Processing.Enrollment
    Private studentIdHidden As String
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub regstudentfingerprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.loadFingerOptions()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        regStudent.Show()
    End Sub

    Private Sub emailAddressTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailAddressTxt.TextChanged
        Try
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT studentId, passport FROM student_tab WHERE emailAddress=@email", connection)
            command.Parameters.AddWithValue("@email", emailAddressTxt.Text)
            reader = command.ExecuteReader()

            If reader.Read() Then
                Dim arrImage() As Byte = CType(reader("passport"), Byte())
                Dim mstream = New MemoryStream(arrImage)
                studentProfilePic.Image = Image.FromStream(mstream)

                Dim studentIdHidden As String
                studentIdHidden = reader("studentId").ToString()

            Else
                studentProfilePic.Image = Nothing
                studentIdHidden = ""
            End If
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub startEnrollBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startEnrollBtn.Click

        If emailAddressTxt.Text = "" Then
            MessageBox.Show("Please enter the student email address to enroll.", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            enrollStatusLabel.Text = "Click Enroll Button To Begin"
            Exit Sub
        End If


        If selectFingerComboBox.Text = "SELECT FINGER" Or selectFingerComboBox.Text = "" Then
            MessageBox.Show("Please select the student's finger to enroll.", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            enrollStatusLabel.Text = "Click Enroll Button To Begin"
            Exit Sub
        End If

        enrollStatusLabel.Text = "Enrollment started. Ready to scan..."
        scanProgressBar.Value = 0

        'enrollStatusLabel.Text = "Starting enrollment..."
        'scanProgressBar.Value = 0

        'capturer = New DPFP.Capture.Capture()
        'If capturer Is Nothing Then
        'enrollStatusLabel.Text = "Fingerprint device not found."
        'Return
        'End If

        'capturer.EventHandler = Me
        'enroller = New DPFP.Processing.Enrollment()

        'Try
        'capturer.StartCapture()
        'enrollStatusLabel.Text = "Scan your finger..."
        'Catch ex As Exception
        'enrollStatusLabel.Text = "Error starting capture: " & ex.Message
        'End Try


        Try
            capturer = New DPFP.Capture.Capture()
            If capturer Is Nothing Then
                enrollStatusLabel.Text = "Fingerprint reader not detected."
                Return
            End If

            capturer.EventHandler = Me
            enrollStatusLabel.Text = "Enrollment started. Ready to scan..."
            scanProgressBar.Value = 0
        Catch ex As Exception
            MessageBox.Show("Error initializing capture: " & ex.Message)
        End Try
    End Sub


    Public Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        Dim bitmap As Bitmap = ConvertSampleToBitmap(Sample)
        studentFingerPrintTemplate.Image = bitmap
        scanProgressBar.Value = 100

        Dim features = ConvertSampleToFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment)
        If features IsNot Nothing Then
            enroller.AddFeatures(features)

            If enroller.TemplateStatus = DPFP.Processing.Enrollment.Status.Ready Then
                capturedTemplate = enroller.Template
                enrollStatusLabel.Text = "Finger Captured successfully."

                SaveFingerprintToDB()
                capturer.StopCapture()
            Else
                enrollStatusLabel.Text = "Keep scanning the same finger..."
            End If
        Else
            enrollStatusLabel.Text = "Poor quality. Try again."
        End If
    End Sub

    Public Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        enrollStatusLabel.Text = "Finger placed on scanner."
    End Sub

    Public Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        enrollStatusLabel.Text = "Finger removed."
    End Sub

    Public Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        enrollStatusLabel.Text = "Fingerprint reader connected."
    End Sub
    Public Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        Try
            enrollStatusLabel.Text = "Fingerprint reader disconnected."
        Catch ex As Exception
            MessageBox.Show("Reader disconnect event error: " & ex.Message)
        End Try
    End Sub


    Public Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Quality As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If Quality = DPFP.Capture.CaptureFeedback.Good Then
            enrollStatusLabel.Text = "Good quality sample."
        Else
            enrollStatusLabel.Text = "Poor quality sample."
        End If
    End Sub

    Private Function ConvertSampleToBitmap(ByVal sample As DPFP.Sample) As Bitmap
        Dim converter As New DPFP.Capture.SampleConversion()
        Dim bitmap As Bitmap = Nothing
        converter.ConvertToPicture(sample, bitmap)
        Return bitmap
    End Function

    Private Function ConvertSampleToFeatures(ByVal sample As DPFP.Sample, ByVal purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()
        Dim feedback As DPFP.Capture.CaptureFeedback = Nothing
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(sample, purpose, feedback, features)
        If feedback = DPFP.Capture.CaptureFeedback.Good Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Private Sub SaveFingerprintToDB()
        If capturedTemplate Is Nothing Then
            MessageBox.Show("No fingerprint captured to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(studentIdHidden) OrElse selectFingerComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Ensure student and finger are selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim connection = functions.connection
            connection.Open()

            ' Check if fingerprint already exists for this student and finger
            query = "SELECT COUNT(*) FROM fingerprints_tab WHERE studentId = @studentId AND fingerId = @fingerId"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", studentIdHidden)
            command.Parameters.AddWithValue("@fingerId", selectFingerComboBox.SelectedValue)
            Dim exists As Integer = Convert.ToInt32(command.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("Fingerprint for this finger already exists for the student.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                connection.Close()
                Return
            End If

            ' Save fingerprint
            Dim templateStream As New MemoryStream()
            capturedTemplate.Serialize(templateStream)

            query = "INSERT INTO fingerprints_tab (studentId, fingerId, fingerprintTemplate, createdTime) VALUES (@studentId, @fingerId, @fingerprintTemplate, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@fingerprintTemplate", templateStream.ToArray())
            command.ExecuteNonQuery()

            connection.Close()
            MessageBox.Show("Fingerprint saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving fingerprint: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        emailAddressTxt.Text = ""
        studentProfilePic.Image = Nothing
        studentFingerPrintTemplate.Image = Nothing
        scanProgressBar.Value = 0
        enrollStatusLabel.Text = "Click Enroll Button To Begin"
        selectFingerComboBox.SelectedIndex = -1
    End Sub

    Private Sub fingerCaptureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fingerCaptureBtn.Click
        If capturer Is Nothing Then
            capturer = New DPFP.Capture.Capture()
            'AddHandler capturer.OnComplete, AddressOf OnComplete
            'AddHandler capturer.OnFingerTouch, AddressOf OnFingerTouch
            'AddHandler capturer.OnFingerGone, AddressOf OnFingerGone
            'AddHandler capturer.OnReaderConnect, AddressOf OnReaderConnect
            'AddHandler capturer.OnReaderDisconnect, AddressOf OnReaderDisconnect
            'AddHandler capturer.OnSampleQuality, AddressOf OnSampleQuality
        End If

        Try
            capturer.StartCapture()
            enrollStatusLabel.Text = "Scan your finger..."
        Catch ex As Exception
            enrollStatusLabel.Text = "Error: " & ex.Message
        End Try
    End Sub
End Class
