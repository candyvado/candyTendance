Imports MySql.Data.MySqlClient
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing
Public Class regStudent
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Dim videoDevices As FilterInfoCollection
    Dim videoSource As VideoCaptureDevice
    Dim capturedImage As Bitmap

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub regStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getStudentID()
        'functions.getStudentRole()
        functions.getStatus()
        functions.getProgramme()
        functions.getGender()

        'Dim result = functions.allCounts
        'total_staff_count_label_txt.Text = allCounts.item1.ToString
    End Sub

    Private Sub viewRecBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewRecBtn.Click
        Me.Hide()
        overlay.Show()
        studentRecords.Show()
    End Sub

    Private Sub Video_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Dim img = CType(eventArgs.Frame.Clone(), Bitmap)
        img.RotateFlip(RotateFlipType.RotateNoneFlipX)
        studentProfilePic.Image = img
    End Sub

    Private Sub captureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles captureBtn.Click
        If studentProfilePic.Image IsNot Nothing Then
            ' STOP the webcam to freeze the image
            If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
                videoSource.SignalToStop()
                videoSource.WaitForStop()
            End If

            ' Define folder and filename
            Dim folderPath As String = "C:\Users\Michael\Documents\Visual Studio 2010\Projects\AfooTECH_Attendance_Management_System\WindowsApplication2\capturedimages"
            If Not IO.Directory.Exists(folderPath) Then
                IO.Directory.CreateDirectory(folderPath)
            End If
            Dim fileName As String = "capture_" & Now.ToString("yyyyMMdd_HHmmss") & ".jpg"
            Dim savePath As String = IO.Path.Combine(folderPath, fileName)

            ' Save the image
            Using bmp As New Bitmap(studentProfilePic.Image)
                bmp.Save(savePath, Imaging.ImageFormat.Jpeg)
            End Using

            MessageBox.Show("Image captured and saved to: " & savePath)
        Else

            MessageBox.Show("No image found to save.")
        End If
    End Sub

    Private Sub studentProfilePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentProfilePic.Click
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count = 0 Then
            MessageBox.Show("No webcam detected.")
            Return
        End If

        videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf Video_NewFrame
        videoSource.Start()
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        Dim response As DialogResult

        If fullNameTxt.Text = "" Or emailAddressTxt.Text = "" Or phoneNumberTxt.Text = "" Then
            MessageBox.Show("All Fields are Required!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf validateEmail(emailAddressTxt.Text) = False Then
            MessageBox.Show("Please Enter a valid Email Address to Continue!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            emailAddressTxt.Text = ""
            emailAddressTxt.Focus()
            Exit Sub

        ElseIf phoneNumberTxt.TextLength < 10 Then
            MessageBox.Show("Please Enter a valid Phone Number to Continue!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            phoneNumberTxt.Text = ""
            phoneNumberTxt.Focus()
            Exit Sub

        ElseIf studentProfilePic.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If (studentProfileId.Text = "SELECT STUDENT.....") Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "AfooTECH Attendance Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If Not functions.vetEmail() Then
                        functions.studentRegistration()
                    End If
                End If

            Else
                response = MessageBox.Show("Are You Sure You Want to update?", "AfooTECH Attendance Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    Dim reader = updateEmailCheck(emailAddressTxt.Text)
                    If reader.HasRows Then
                        MessageBox.Show("This Email Address Already Exists!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        reader.Close()
                        functions.connection.Close()
                        Exit Sub
                    End If

                    reader.Close()
                    functions.connection.Close()

                    functions.UpdateStudent()
                End If
            End If
        End If

        'Dim updatedCounts = functions.allCounts()
        'total_student_count_label_txt.Text = updatedCounts.Item1.ToString
    End Sub

    Private Sub fetch_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetch_btn.Click
        If studentProfileId.Text = "SELECT STUDENT....." Then
            MessageBox.Show("SELECT A STUDENT TO CONTINUE!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT a.*, b.roleName, c.statusName, d.programmeName, e.genderName FROM student_tab a, setup_role_tab b, setup_status_tab c, setup_programme_tab d, setup_gender_tab e WHERE a.statusId = c.statusId AND a.roleId = b.roleId AND a.programmeId = d.programmeId AND a.genderId = e.genderId AND a.studentId = @studentId;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@studentId", studentProfileId.SelectedValue)
                reader = Command.ExecuteReader

                If reader.Read() Then
                    Dim arrimage() As Byte

                    fullNameTxt.Text = reader("fullName")
                    emailAddressTxt.Text = reader("emailAddress")
                    phoneNumberTxt.Text = reader("phoneNumber")
                    studentStatusIdComboBox.Text = reader("statusName")
                    studentStatusIdComboBox.SelectedValue = reader("statusId")
                    studentGenderIdComboBox.Text = reader("genderName")
                    studentGenderIdComboBox.SelectedValue = reader("genderId")
                    studentProgrammeIdComboBox.Text = reader("programmeName")
                    studentProgrammeIdComboBox.SelectedValue = reader("programmeId")
                    arrimage = reader("passport")

                    Dim mstream = New MemoryStream(arrimage)
                    studentProfilePic.Image = Image.FromStream(mstream)
                Else
                    MessageBox.Show("STUDENT RECORD NOT FOUND!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub fullNameTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullNameTxt.KeyPress
        functions.alphaCheck(e)
    End Sub

    Private Sub phoneNumberTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneNumberTxt.KeyPress
        functions.numCheck(e)
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        functions.clearFunction()
    End Sub

End Class