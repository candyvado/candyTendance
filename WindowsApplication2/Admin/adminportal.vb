Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class adminportal
    Public loginStaffId As String ' Staff ID of the logged-in user

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

        ' Set the background color with transparency
        Guna2Panel4.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel2.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel3.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel5.BackColor = Color.FromArgb(200, 255, 255, 255)
        Guna2Panel6.BackColor = Color.FromArgb(200, 255, 255, 255)

        ' Start the timer
        Timer1.Interval = 1000 ' Set the timer interval to 1 second
        Timer1.Start()

        ' Set up the labels
        SetupLabels()

        Dim result = functions.getStaffProfile(adminlogin.loginStaffId)
        Dim arrimage() As Byte = result.item3
        staffFullNameLabelTxt.Text = result.item1.ToString
        lastLoginLabelTxt.Text = "Last Login Date:" & " " & result.item2.ToString
        Dim mstream = New MemoryStream(arrimage)
        passporrt.Image = Image.FromStream(mstream)

        'Dim allCounts = functions.allCounts()
        'totalAdminLabel.Text = allCounts.item1.ToString
        'totalStudentLabel.Text = allCounts.item2.ToString
        'attendanceMarked.Text = "₦" & allCounts.item5.ToString
        'totalRecord.Text = "₦" & allCounts.item4.ToString
    End Sub

    ' Set label properties
    Private Sub SetupLabels()
        ' Set up time label properties
        time_label.ForeColor = Color.Maroon
        time_label.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        time_label.AutoSize = True  ' Set AutoSize to True
        time_label.Height = 20      ' Adjust the height if necessary

        ' Set up date label properties
        date_label.Font = New Font("Microsoft Tai Le", 9, FontStyle.Regular)
        date_label.ForeColor = Color.Black
        date_label.AutoSize = True  ' Set AutoSize to True
        date_label.Height = 30      ' Adjust the height if necessary
    End Sub
    Private Sub viewAdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewAdminBtn.Click
        overlay.Show()
        adminRecord.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' Update time and date every second
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
End Class