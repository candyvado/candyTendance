Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminportal

    Dim command As MySqlCommand
    Dim query As String
    Public loginStaffId As String

    Private Sub admin_log_out_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admin_log_out_btn.Click
        Dim close_validation = MessageBox.Show("Are you sure you want to LOG OUT", "Exit Admin Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If close_validation = vbYes Then
            Me.Hide()
            adminlogin.Show()
        End If
    End Sub

    Private Sub adminportal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        index.Close()

    End Sub

    Private Sub adminportal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Guna2Panel4.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel2.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel5.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel6.BackColor = Color.FromArgb(200, 255, 255, 255)


        Timer1.Interval = 1000
        Timer1.Start()


        SetupLabels()
        LoadAttendanceBarChart()
        'LoadEnrollmentChart()
        LoadMonthlyAttendancePie()
        'LoadLineChart()

        Dim result = functions.getStaffProfile(adminlogin.loginStaffId)
        Dim arrimage() As Byte = result.item3
        staffFullNameLabelTxt.Text = result.item1.ToString
        lastLoginLabelTxt.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        passporrt.Image = Image.FromStream(mstream)

        Try
            Dim allCounts = functions.allCounts()
            totalAdminLabel.Text = allCounts.Item1.ToString()
            totalStudentLabel.Text = allCounts.Item2.ToString()
            totalEnrollmentLabel.Text = allCounts.Item3.ToString()
            totalRecordLabel.Text = allCounts.Item4.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading counts: " & ex.Message)
        End Try

    End Sub

    Private Sub SetupLabels()

        time_label.ForeColor = Color.Maroon
        time_label.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        time_label.AutoSize = True
        time_label.Height = 20

        date_label.Font = New Font("Microsoft Tai Le", 9, FontStyle.Regular)
        date_label.ForeColor = Color.Black
        date_label.AutoSize = True
        date_label.Height = 30
    End Sub
    Private Sub viewAdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAdminBtn.Click
        overlay.Show()
        adminRecord.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        time_label.Text = DateTime.Now.ToString("hh:mm:ss tt")
        date_label.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")
    End Sub
    Private Sub enrollFingerPrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enrollFingerPrintBtn.Click
        overlay.Show()
        regstudentfingerprint.Show()
    End Sub

    Private Sub markAttendanceBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles markAttendanceBtn.Click
        overlay.Show()
        markAttendance.Show()
    End Sub

    Private Sub viewStudentBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewStudentBtn.Click
        overlay.Show()
        regStudent.Show()
    End Sub

    Private Sub attendanceRecordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attendanceRecordBtn.Click
        overlay.Show()
        attendanceRecordForm.Show()
    End Sub

    Private Sub settingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.Click
        overlay.Show()
        systemSettings.Show()
    End Sub

    Private Sub UpdatePassportInDatabase(ByVal staffId As String, ByVal passport As Byte())
        Try

            Dim connection = functions.connection
            connection.Open()

            Dim query As String = "UPDATE staff_tab SET passport = @passport, updatedTime = @updatedTime WHERE staffId = @staffId"
            Dim Command = New MySqlCommand(query, connection)

            Command.Parameters.AddWithValue("@passport", passport)
            Command.Parameters.AddWithValue("@updatedTime", DateTime.Now)
            Command.Parameters.AddWithValue("@staffId", adminlogin.loginStaffId)

            Dim rowsAffected As Integer = Command.ExecuteNonQuery()


            If rowsAffected > 0 Then
                MessageBox.Show("Picture updated successfully!")
            Else
                MessageBox.Show("Error: Picture could not be updated.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub passporrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passporrt.Click

        Dim tempPassport = functions.selectPassport(passporrt)

        If tempPassport.Image IsNot Nothing Then

            Dim result As DialogResult = MessageBox.Show("Do you want to save this new picture?", "Confirm Update", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                Dim updatedImage As Byte() = functions.passportSave(tempPassport)
                Dim ValidStaffId As String = adminlogin.loginStaffId
                UpdatePassportInDatabase(ValidStaffId, updatedImage)
            Else

                functions.revertOriginalPassport(passporrt)
            End If
        End If
    End Sub

    Private Sub LoadAttendanceBarChart()
        Try
            Dim connection = functions.connection
            connection.Open()

            ' Get last 7 days attendance
            query = "SELECT attendanceDate, COUNT(*) AS checkInCount FROM attendance_tab WHERE attendanceDate >= DATE_SUB(CURDATE(), INTERVAL 6 DAY) GROUP BY attendanceDate ORDER BY attendanceDate ASC"

            command = New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Clear old chart data
            attendanceBarChart.Series.Clear()
            attendanceBarChart.ChartAreas.Clear()
            attendanceBarChart.Titles.Clear()

            ' Chart Area
            Dim chartArea As New DataVisualization.Charting.ChartArea("ChartArea1")
            chartArea.AxisX.Title = "Date"
            chartArea.AxisY.Title = "Number of Check-ins"
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray
            attendanceBarChart.ChartAreas.Add(chartArea)

            ' Bar Series
            Dim series As New DataVisualization.Charting.Series("Daily Check-ins")
            series.ChartType = DataVisualization.Charting.SeriesChartType.Column
            series.Color = Color.CornflowerBlue
            series.IsValueShownAsLabel = True
            series.LabelForeColor = Color.Gray
            series.Font = New Font("Segoe UI", 9, FontStyle.Bold)

            ' Loop through all rows
            While reader.Read()
                Dim dateLabel As String = Convert.ToDateTime(reader("attendanceDate")).ToString("ddd dd MMM") ' e.g., Mon 24 Jun
                Dim count As Integer = Convert.ToInt32(reader("checkInCount"))
                series.Points.AddXY(dateLabel, count)
            End While

            attendanceBarChart.Series.Add(series)

            ' Title
            Dim chartTitle As New DataVisualization.Charting.Title("Last 7 Days Attendance")
            chartTitle.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            attendanceBarChart.Titles.Add(chartTitle)

            ' Styling X axis
            attendanceBarChart.ChartAreas(0).AxisX.Interval = 1
            attendanceBarChart.ChartAreas(0).AxisX.LabelStyle.Angle = -45
            attendanceBarChart.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Segoe UI", 8, FontStyle.Regular)

            reader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading bar chart: " & ex.Message)
        End Try
    End Sub

     Private Sub LoadMonthlyAttendancePie()
        Try
            Dim connection = functions.connection
            connection.Open()

            Dim query = "SELECT SUM(CASE WHEN checkInTime IS NOT NULL THEN 1 ELSE 0 END) AS totalCheckIns, SUM(CASE WHEN checkOutTime IS NOT NULL THEN 1 ELSE 0 END) AS totalCheckOuts FROM attendance_tab WHERE MONTH(attendanceDate) = MONTH(CURDATE()) AND YEAR(attendanceDate) = YEAR(CURDATE())"

            command = New MySqlCommand(query, connection)
            Dim reader = command.ExecuteReader()

            If reader.Read() Then
                Dim totalCheckIns As Integer = If(IsDBNull(reader("totalCheckIns")), 0, Convert.ToInt32(reader("totalCheckIns")))
                Dim totalCheckOuts As Integer = If(IsDBNull(reader("totalCheckOuts")), 0, Convert.ToInt32(reader("totalCheckOuts")))

                monthlyAttendancePieChart.Series.Clear()
                monthlyAttendancePieChart.Titles.Clear()

                Dim series = monthlyAttendancePieChart.Series.Add("Attendance Activity")
                series.ChartType = DataVisualization.Charting.SeriesChartType.Pie
                series("PieLabelStyle") = "Outside"
                series.IsValueShownAsLabel = True

                series.Points.AddXY("Check-Ins", totalCheckIns)
                series.Points.AddXY("Check-Outs", totalCheckOuts)

                series.Points(0).Color = Color.CornflowerBlue
                series.Points(1).Color = Color.LightGray

                Dim title As New DataVisualization.Charting.Title("Monthly Check-Ins vs Check-Outs")
                title.Font = New Font("Segoe UI", 12, FontStyle.Bold)
                monthlyAttendancePieChart.Titles.Add(title)
            End If

            reader.Close()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading attendance pie chart: " & ex.Message)
        End Try
    End Sub

    Sub LoadLineChart()
        Dim connection = functions.connection
        Dim query As String = "SELECT attendanceDate, COUNT(*) AS checkInCount FROM attendance_tab WHERE attendanceDate >= DATE_SUB(CURDATE(), INTERVAL 6 DAY) GROUP BY attendanceDate ORDER BY attendanceDate ASC"
        Dim cmd As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)

        With attendanceBarChart
            .Series.Clear()
            .ChartAreas(0).AxisX.Interval = 1
            .ChartAreas(0).AxisX.Title = "Date"
            .ChartAreas(0).AxisY.Title = "Check-Ins"
            .Series.Add("Daily Check-Ins")
            .Series("Daily Check-Ins").ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Series("Daily Check-Ins").Color = Color.SteelBlue
            .Series("Daily Check-Ins").BorderWidth = 3

            For Each row As DataRow In table.Rows
                .Series("Daily Check-Ins").Points.AddXY(Convert.ToDateTime(row("attendanceDate")).ToString("MMM dd"), Convert.ToInt32(row("checkInCount")))
            Next
        End With
    End Sub



End Class