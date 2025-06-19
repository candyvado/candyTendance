Public Class main

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim close_validation = MessageBox.Show("Are you sure you want to Exit", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Close()
            index.Close()
        End If
    End Sub

    Private Sub admin_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_btn.Click
        Me.Close()
        adminlogin.Show()
    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class