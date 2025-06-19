Imports MySql.Data.MySqlClient
Public Class setResetFingerprint
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        systemSettings.Show()
    End Sub

    Private Sub setResetFingerprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadStudentsIntoComboBox()
    End Sub

    Public Sub LoadStudentsIntoComboBox()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "SELECT studentId, fullName FROM student_tab WHERE statusId = 1"
            Dim command As New MySqlCommand(query, connection)
            DT.Load(command.ExecuteReader())
            connection.Close()

            ' Add the default SELECT STUDENT row
            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("studentId") = 0
            defaultRow("fullName") = "SELECT STUDENT"
            DT.Rows.InsertAt(defaultRow, 0)

            ' Bind data to combobox
            selectStudentComboBox.DataSource = DT
            selectStudentComboBox.DisplayMember = "fullName"
            selectStudentComboBox.ValueMember = "studentId"

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub




    Private Sub resetFingerBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetFingerBtn.Click
        If selectStudentComboBox.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a student to reset their fingerprint.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedText As String = selectStudentComboBox.SelectedItem.ToString()
        Dim studentId As String = selectedText.Split("-"c).Last().Trim()

        Try
            Dim connection = functions.connection
            connection.Open()
            Dim deleteQuery = "DELETE FROM student_fingerprint_tab WHERE studentId = @studentId"
            Dim command As New MySqlCommand(deleteQuery, connection)
            command.Parameters.AddWithValue("@studentId", studentId)

            Dim rowsAffected = command.ExecuteNonQuery()
            connection.Close()

            If rowsAffected > 0 Then
                MessageBox.Show("Fingerprint reset successfully for selected student.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No fingerprint found for selected student.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error resetting fingerprint: " & ex.Message)
        End Try
    End Sub
End Class