Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class adminresetpassword
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public staffId, fullName, emailAddress As String
    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        main.Show()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        adminlogin.Show()
    End Sub

    Private Sub proceedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceedBtn.Click
        If emailAddressTxt.Text = "" Then
            MessageBox.Show("Error! Input your Email Address to Continue!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf functions.validateEmail(emailAddressTxt.Text) = False Then
            MessageBox.Show("Invalid Email Address", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            Try
                reader = functions.emailCheck(emailAddressTxt.Text)
                If reader.HasRows Then
                    staffId = reader("staffId")
                    Dim statusId = reader("statusId")
                    fullName = reader("fullName")
                    emailAddress = reader("emailAddress")

                    If statusId = 1 Then
                        Dim otp As String = New Random().Next(100000, 999999).ToString()

                        Dim connection = functions.connection

                        connection.Open()
                        command = New MySqlCommand("UPDATE staff_tab SET otp=@otp WHERE staffId=@staffId", connection)
                        command.Parameters.AddWithValue("@staffId", staffId)
                        command.Parameters.AddWithValue("@otp", otp)
                        reader = command.ExecuteReader
                        connection.Close()

                        Me.Hide()
                        overlay.Show()
                        adminfinishresetpassword.Show()

                    Else
                        MessageBox.Show("ERROR! Account has been Suspended", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Email Address do not exit!", "AfooTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class