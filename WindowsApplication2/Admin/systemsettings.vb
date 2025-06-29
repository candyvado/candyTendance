Public Class systemSettings

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub resetPasswordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetPasswordBtn.Click
        overlay.Close()
        overlay.Show()
        setChangePassword.Show()
    End Sub
End Class