Imports MySql.Data.MySqlClient
Imports System.IO

Public Class attendanceRecordForm
    Dim connection As MySqlConnection = functions.connection

    Private Sub attendanceRecordForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        attendanceDatePicker.Format = DateTimePickerFormat.Custom
        attendanceDatePicker.CustomFormat = "dddd dd, MMMM yyyy"
        attendanceDatePicker.Value = DateTime.Today

        attendanceSearchTxt.Text = String.Empty
        LoadAttendanceForDate(DateTime.Today)
    End Sub

    Private Sub closeBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closeBtn.Click
        Me.Close()
        overlay.Close()
        adminportal.Show()
    End Sub

    Private Sub refreshBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles refreshBtn.Click
        attendanceSearchTxt.Text = String.Empty
        attendanceDatePicker.Value = DateTime.Today
        LoadAttendanceForDate(DateTime.Today)
    End Sub

    Private Sub searchBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles searchBtn.Click
        Dim emailAddressFilter As String = attendanceSearchTxt.Text.Trim()
        Dim selectedDate As Date = attendanceDatePicker.Value.Date

        If String.IsNullOrEmpty(emailAddressFilter) Then
            ' If no email entered, just load all for selected date
            LoadAttendanceForDate(selectedDate)
        Else
            ' Load filtered by email and date
            LoadAttendanceFiltered(emailAddressFilter, selectedDate)
        End If
    End Sub

    ' Load attendance for a specific date
    Private Sub LoadAttendanceForDate(ByVal dateValue As Date)
        Try
            Dim dt As New DataTable
            Dim query As String = "SELECT studentId, statusId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus " & _
                                  "FROM attendance_tab WHERE attendanceDate = @date ORDER BY checkInTime DESC"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@date", dateValue.ToString("yyyy-MM-dd"))
            Dim adapter As New MySqlDataAdapter(command)
            adapter.Fill(dt)

            attendanceListView.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In dt.Rows
                Dim item As New ListViewItem(sn.ToString())
                item.SubItems.Add(row("studentId").ToString())
                item.SubItems.Add(row("statusId").ToString())
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
            MessageBox.Show("Error loading records: " & ex.Message)
        End Try
    End Sub

    ' Load attendance filtered by email and date
    Private Sub LoadAttendanceFiltered(ByVal emailAddress As String, ByVal dateVal As String)
        Try
            Dim query As String
            Dim command As MySqlCommand

            If String.IsNullOrWhiteSpace(emailAddress) Then
                ' No email entered, search by date only
                query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab WHERE attendanceDate = @date ORDER BY checkInTime DESC"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@date", dateVal)
            Else
                ' Email entered, search by email and date
                query = "SELECT studentId, fullName, emailAddress, attendanceDate, checkInTime, checkOutTime, clockStatus FROM attendance_tab WHERE emailAddress LIKE @emailAddress AND attendanceDate = @date ORDER BY checkInTime DESC"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@emailAddress", "%" & emailAddress & "%")
                command.Parameters.AddWithValue("@date", dateVal)
            End If

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
