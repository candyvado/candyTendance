Public Class systemSettings

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub attendanceTimeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attendanceTimeBtn.Click
        Me.Hide()
        overlay.Show()
        setAttendanceTime.Show()

    End Sub

    Private Sub resetFingerprintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetFingerprintBtn.Click
        Me.Hide()
        overlay.Show()
        setResetFingerprint.Show()
    End Sub

    Private Sub resetPasswordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetPasswordBtn.Click
        Me.Hide()
        overlay.Show()
        setResetPassword.Show()
    End Sub
End Class