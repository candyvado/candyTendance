Imports MySql.Data.MySqlClient
Imports System.IO

Public Class attendanceRecordForm
    Dim connection As MySqlConnection = functions.connection

    Private Sub attendanceRecordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        attendanceDatePicker.Format = DateTimePickerFormat.Custom
        attendanceDatePicker.CustomFormat = "yyyy-MM-dd"
        attendanceDatePicker.Value = DateTime.Today
        LoadAllAttendanceRecords()
    End Sub

    Private Sub closeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
        adminportal.Show()
    End Sub

    Private Sub searchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBtn.Click
        Dim nameFilter As String = attendanceSearchTxt.Text.Trim()
        Dim selectedDate As String = attendanceDatePicker.Value.ToString("yyyy-MM-dd")
        LoadFilteredRecords(nameFilter, selectedDate)
    End Sub

    Private Sub refreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshBtn.Click
        attendanceSearchTxt.Text = ""
        attendanceDatePicker.Value = DateTime.Today
        LoadAllAttendanceRecords()
    End Sub

    Private Sub LoadAllAttendanceRecords()
        Try
            Dim query As String = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab ORDER BY attendanceDate DESC, checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem(sn.ToString())
                listItem.SubItems.Add(row("studentId").ToString())
                listItem.SubItems.Add(row("fullName").ToString())
                listItem.SubItems.Add(row("emailAddress").ToString())
                listItem.SubItems.Add(row("attendanceDate").ToString())
                listItem.SubItems.Add(row("checkInTime").ToString())
                listItem.SubItems.Add(row("checkOutTime").ToString())
                listItem.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(listItem)
                sn += 1
            Next
        Catch ex As Exception
            MsgBox("Error loading records: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadFilteredRecords(ByVal name As String, ByVal dateVal As String)
        Try
            Dim query As String = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab WHERE fullName LIKE @fullName AND attendanceDate = @date ORDER BY checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@fullName", "%" & name & "%")
            command.Parameters.AddWithValue("@date", dateVal)

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("fullName").ToString())
                item.SubItems.Add(row("emailAddress").ToString())
                item.SubItems.Add(row("attendanceDate").ToString())
                item.SubItems.Add(row("checkInTime").ToString())
                item.SubItems.Add(row("checkOutTime").ToString())
                item.SubItems.Add(row("clockStatus").ToString())
                attendanceListView.Items.Add(item)
                sn += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub
End Class
