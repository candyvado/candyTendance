Public Class setResetPassword

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
        adminportal.Show()
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        Me.Close()
        overlay.Show()
        systemSettings.Show()
    End Sub

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        overlay.Close()
        overlay.Show()
        setChangePassword.Show()
    End Sub
End Class