Imports MySql.Data.MySqlClient
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing
Public Class adminRecord
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Dim videoDevices As FilterInfoCollection
    Dim videoSource As VideoCaptureDevice
    Dim capturedImage As Bitmap


    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
            videoSource.SignalToStop()
            videoSource.WaitForStop()
        End If
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub viewAdminRecordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAdminRecordBtn.Click
        Me.Close()
        overlay.Show()
        viewadminrecord.Show()
    End Sub

    Private Sub adminRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        functions.getStaffID()
        functions.getRole()
        functions.getStatus()
        Dim result = functions.allCounts
        totalAdminCountLabel.Text = allCounts.item1.ToString
    End Sub
    Private Sub Video_NewFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Dim img = CType(eventArgs.Frame.Clone(), Bitmap)
        img.RotateFlip(RotateFlipType.RotateNoneFlipX)
        adminProfilePic.Image = img
    End Sub
    Private Sub adminProfilePic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminProfilePic.Click
        videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        If videoDevices.Count = 0 Then
            MessageBox.Show("No webcam detected.")
            Return
        End If

        videoSource = New VideoCaptureDevice(videoDevices(0).MonikerString)
        AddHandler videoSource.NewFrame, AddressOf Video_NewFrame
        videoSource.Start()
    End Sub

    Private Sub fetchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fetchBtn.Click
        If profileId.Text = "SELECT STAFF....." Then
            MessageBox.Show("SELECT A STAFF TO CONTINUE!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim connection = functions.connection
                connection.Open()
                query = "SELECT a.*, b.roleName, c.statusName FROM staff_tab a, setup_role_tab b, setup_status_tab c WHERE a.statusId=c.statusId AND a.roleId=b.roleId AND staffId=@staffId;"
                Dim Command = New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@staffId", profileId.SelectedValue)
                reader = Command.ExecuteReader
                reader.Read()

                Dim arrimage() As Byte

                fullNameTxt.Text = reader("fullName")
                emailAddressTxt.Text = reader("emailAddress")
                phoneNumberTxt.Text = reader("phoneNumber")
                staffRoleIdComboBox.Text = (reader("roleName"))
                staffRoleIdComboBox.SelectedValue = reader("roleId")
                staffStatusIdComboBox.Text = (reader("statusName"))
                staffStatusIdComboBox.SelectedValue = reader("statusId")
                arrimage = reader("passport")

                Dim mstream = New MemoryStream(arrimage)
                adminProfilePic.Image = Image.FromStream(mstream)
                connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub clearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBtn.Click
        functions.clearFunction()
    End Sub

    Private Sub fullNameTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fullNameTxt.KeyPress
        functions.alphaCheck(e)
    End Sub

    Private Sub phoneNumberTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phoneNumberTxt.KeyPress
        functions.numCheck(e)
    End Sub

    Private Sub captureBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles captureBtn.Click
        If adminProfilePic.Image IsNot Nothing Then
            ' STOP the webcam to freeze the image
            If videoSource IsNot Nothing AndAlso videoSource.IsRunning Then
                videoSource.SignalToStop()
                videoSource.WaitForStop()
            End If

            ' Define folder and filename
            Dim folderPath As String = "C:\capturedimages"
            If Not IO.Directory.Exists(folderPath) Then
                IO.Directory.CreateDirectory(folderPath)
            End If
            Dim fileName As String = "capture_" & Now.ToString("yyyyMMdd_HHmmss") & ".jpg"
            Dim savePath As String = IO.Path.Combine(folderPath, fileName)

            ' Save the image
            Using bmp As New Bitmap(adminProfilePic.Image)
                bmp.Save(savePath, Imaging.ImageFormat.Jpeg)
            End Using

            MessageBox.Show("Image captured and saved to: " & savePath)
        Else

            MessageBox.Show("No image found to save.")
        End If
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

        ElseIf adminProfilePic.Image Is Nothing Then
            MessageBox.Show("Please Select a Passport to Continue!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            If (profileId.Text = "SELECT STAFF.....") Then
                response = MessageBox.Show("Are You Sure You Want to Save?", "AfooTECH Attendance Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = vbYes Then
                    If Not functions.vetEmail() Then
                        functions.staffRegistration()
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

                    functions.UpdateStaff()
                End If
            End If
        End If

        Dim updatedCounts = functions.allCounts()
        totalAdminCountLabel.Text = updatedCounts.Item1.ToString
        adminportal.totalAdminLabel.Text = updatedCounts.Item1.ToString()
    End Sub

End Class