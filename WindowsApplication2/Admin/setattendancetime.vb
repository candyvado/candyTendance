Imports MySql.Data.MySqlClient
Public Class setAttendanceTime
    Dim connection As MySqlConnection = functions.connection

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        Me.Close()
        systemSettings.Show()
    End Sub

    Private Sub close_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_btn.Click
        Me.Close()
        overlay.Close()
    End Sub

    Private Sub setAttendanceTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Setup resumption time picker
        resumptionTimePicker.Format = DateTimePickerFormat.Time
        resumptionTimePicker.ShowUpDown = True
        resumptionTimePicker.Value = DateTime.Today.AddHours(9) ' default 9:00 AM

        ' Setup closing time picker
        closingTimePicker.Format = DateTimePickerFormat.Time
        closingTimePicker.ShowUpDown = True
        closingTimePicker.Value = DateTime.Today.AddHours(17) ' default 5:00 PM

        LoadSavedTimes()
    End Sub

    Private Sub LoadSavedTimes()
        Try
            connection.Open()
            Dim query As String = "SELECT resumptionTime, closingTime FROM system_settings_tab ORDER BY sn DESC LIMIT 1"
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                resumptionTimePicker.Value = DateTime.Today.Add(reader.GetTimeSpan("resumptionTime"))
                closingTimePicker.Value = DateTime.Today.Add(reader.GetTimeSpan("closingTime"))
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Failed to load times: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub saveTimeDateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveTimeDateBtn.Click
        Dim resumptionTime As String = resumptionTimePicker.Value.ToString("HH:mm:ss")
        Dim closingTime As String = closingTimePicker.Value.ToString("HH:mm:ss")

        If TimeSpan.Parse(resumptionTime) >= TimeSpan.Parse(closingTime) Then
            MessageBox.Show("Resumption time must be earlier than closing time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "INSERT INTO system_settings_tab (resumptionTime, closingTime) VALUES (@resumptionTime, @closingTime)"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@resumptionTime", resumptionTime)
            command.Parameters.AddWithValue("@closingTime", closingTime)
            command.ExecuteNonQuery()
            MessageBox.Show("Attendance time saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Failed to save attendance time: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
End Class