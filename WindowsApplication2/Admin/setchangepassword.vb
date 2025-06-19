Imports MySql.Data.MySqlClient
Public Class setChangePassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Dim passwordVisible As Boolean = False
    Public loginStaffId As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Show()
    End Sub


    Private Sub oldPasswordToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oldPasswordToggle.Click
        If passwordVisible Then
            ' 🔒 Hide password
            oldPasswordTxt.UseSystemPasswordChar = True
            oldPasswordToggle.Image = My.Resources.eyehide
            ' Replace with your hidden eye image
            passwordVisible = False
        Else
            ' 👁️ Show password
            oldPasswordTxt.UseSystemPasswordChar = False
            oldPasswordToggle.Image = My.Resources.eyeopen ' Replace with your open eye image
            passwordVisible = True
        End If
    End Sub

    Private Sub newPasswordToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newPasswordToggle.Click
        If passwordVisible Then
            ' 🔒 Hide password
            newPasswordTxt.UseSystemPasswordChar = True
            newPasswordToggle.Image = My.Resources.eyehide
            ' Replace with your hidden eye image
            passwordVisible = False
        Else
            ' 👁️ Show password
            newPasswordTxt.UseSystemPasswordChar = False
            newPasswordToggle.Image = My.Resources.eyeopen
            ' Replace with your open eye image
            passwordVisible = True
        End If
    End Sub

    Private Sub confirmPasswordToggle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirmPasswordToggle.Click
        If passwordVisible Then
            ' 🔒 Hide password
            confirmPasswordTxt.UseSystemPasswordChar = True
            confirmPasswordToggle.Image = My.Resources.eyehide
            ' Replace with your hidden eye image
            passwordVisible = False
        Else
            ' 👁️ Show password
            confirmPasswordTxt.UseSystemPasswordChar = False
            confirmPasswordToggle.Image = My.Resources.eyeopen
            ' Replace with your open eye image
            passwordVisible = True
        End If
    End Sub


    Private Sub changePasswordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changePasswordBtn.Click
        If oldPasswordTxt.Text = "" Or newPasswordTxt.Text = "" Or confirmPasswordTxt.Text = "" Then
            MessageBox.Show("ERROR! All fields are Required!", "AfooTECH Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection = functions.connection
            Dim result = functions.getStaffProfile(adminlogin.loginStaffId)
            Dim old_password = result.item6.ToString

            If old_password = oldPasswordTxt.Text Then
                If newPasswordTxt.Text = confirmPasswordTxt.Text Then
                    connection.open()
                    query = "UPDATE staff_tab SET password=@password WHERE staffId=@staffId"
                    command = New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@password", newPasswordTxt.Text)
                    command.Parameters.AddWithValue("@staffId", adminlogin.loginStaffId)
                    reader = command.ExecuteReader
                    connection.Close()
                    MessageBox.Show("SUCCESS! Password has been updated successfully", "AfooTECH Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    overlay.Close()
                Else
                    MessageBox.Show("ERROR! New Password don't match with Confirmed Password!", "AfooTECH Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("ERROR! Old Password is Incorrect", "AfooTECH Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class