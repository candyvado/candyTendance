Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminlogin
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Dim passwordVisible As Boolean = False

    Public loginStaffId, loginRoleId, loginStatusId As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        If emailAddressTxt.Text = "" Or loginPasswordTxt.Text = "" Then
            MessageBox.Show("ERROR! All fields are required!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.validateEmail(emailAddressTxt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Dim connection = functions.connection

            Try
                connection.Open()
                command = New MySqlCommand("SELECT * FROM staff_tab WHERE emailAddress=@emailAddress AND password=@password", connection)
                command.Parameters.AddWithValue("@emailAddress", emailAddressTxt.Text)
                command.Parameters.AddWithValue("@password", loginPasswordTxt.Text)
                reader = command.ExecuteReader
                reader.Read()

                If reader.HasRows Then
                    loginStaffId = reader("staffId")
                    loginStatusId = reader("statusId")
                    loginRoleId = reader("roleId")
                    connection.Close()

                    If loginRoleId < 3 Then
                        MessageBox.Show("ERROR! This User is not authorized to login", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        If loginStatusId = 1 Then
                            connection.Open()
                            command = New MySqlCommand("UPDATE staff_tab SET lastLogin = NOW() WHERE staffId=@staffId", connection)
                            command.Parameters.AddWithValue("@staffId", loginStaffId)
                            reader = command.ExecuteReader
                            connection.Close()

                            Dim result = functions.getStaffProfile(loginStaffId)
                            Dim arrimage() As Byte = result.item3
                            adminportal.staffFullNameLabelTxt.Text = result.item1.ToString
                            adminportal.lastLoginLabelTxt.Text = "Last Login Date: " & result.item2.ToString
                            Dim mstream = New MemoryStream(arrimage)
                            adminportal.passporrt.Image = Image.FromStream(mstream)

                            MessageBox.Show("WELCOME! Login Successfull!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            functions.goToAdminPortal()
                        Else
                            MessageBox.Show("ERROR! Account has been Suspended", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Else
                    MessageBox.Show("ERROR! Invalid login Details!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub forgot_password_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgotPasswordLabel.LinkClicked
        Me.Hide()
        overlay.Hide()
        adminResetPassword.Show()
    End Sub

    Private Sub loginPasswordToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginPasswordToggle.Click
        If passwordVisible Then
            loginPasswordTxt.UseSystemPasswordChar = True
            loginPasswordToggle.Image = My.Resources.eyehide
            passwordVisible = False
        Else

            loginPasswordTxt.UseSystemPasswordChar = False
            loginPasswordToggle.Image = My.Resources.eyeopen
            passwordVisible = True
        End If
    End Sub

    Private Sub adminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class