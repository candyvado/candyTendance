Imports MySql.Data.MySqlClient
Public Class adminfinishresetpassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim passwordVisible As Boolean = False

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles adminfinishresetpass.Paint

    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Hide()
        overlay.Hide()
        main.Show()
    End Sub

    Private Sub finishPasswordToggle_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finishPasswordToggle.Click
        If passwordVisible Then

            createPasswordTxt.UseSystemPasswordChar = True
            finishPasswordToggle.Image = My.Resources.eyehide
            passwordVisible = False
        Else

            createPasswordTxt.UseSystemPasswordChar = False
            finishPasswordToggle.Image = My.Resources.eyeopen
            passwordVisible = True
        End If
    End Sub
    Private Sub confirmFinishPasswordToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmFinishPasswordToggle.Click
        If passwordVisible Then
            confirmPasswordTxt.UseSystemPasswordChar = True
            confirmFinishPasswordToggle.Image = My.Resources.eyehide
            passwordVisible = False
        Else

            confirmPasswordTxt.UseSystemPasswordChar = False
            confirmFinishPasswordToggle.Image = My.Resources.eyeopen
            passwordVisible = True
        End If
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveBtn.Click
        If otpTxt.Text = "" Or createPasswordTxt.Text = "" Or confirmPasswordTxt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If createPasswordTxt.Text = confirmPasswordTxt.Text Then
                Try
                    Dim connection = functions.connection

                    connection.Open()
                    command = New MySqlCommand("SELECT otp FROM staff_tab WHERE otp=@otp AND staffId=@staffId", connection)
                    command.Parameters.AddWithValue("@staffId", adminresetpassword.staffId)
                    command.Parameters.AddWithValue("@otp", otpTxt.Text)
                    reader = command.ExecuteReader

                    If reader.HasRows Then
                        connection.close()
                        connection.open()
                        command = New MySqlCommand("UPDATE staff_tab SET password=@password WHERE staffId=@staffId", connection)
                        command.Parameters.AddWithValue("@staffId", adminresetpassword.staffId)
                        command.Parameters.AddWithValue("@password", createPasswordTxt.Text)
                        reader = command.ExecuteReader
                        connection.Close()
                        MessageBox.Show("SUCCESS! Password changed Successfully", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        overlay.Close()
                        adminlogin.Show()
                    Else
                        MessageBox.Show("ERROR! OTP not valid", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MessageBox.Show("ERROR! New Password And Confirm Password Do Not Match", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub otpTxt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles otpTxt.KeyPress
        functions.numCheck(e)
    End Sub


    Private Sub adminfinishresetpassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        passwordLabel.Text = "Dear" & " " & adminresetpassword.fullName & "," & " " & "an OTP has been sent to your registered Email Address" & Environment.NewLine & "(" & adminresetpassword.emailAddress & ")"
    End Sub
End Class