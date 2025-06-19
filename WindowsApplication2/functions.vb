Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D

Module functions
    Dim reader As MySqlDataReader
    Dim command As MySqlCommand
    Dim query As String
    Public loginStudentId As String

    Function connection()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=afootechattendancedb")
        Return conn
    End Function

    Public Function ApplyBlur(ByVal image As Image, ByVal blurAmount As Integer) As Image
        Dim blurredImage As New Bitmap(image.Width, image.Height)
        Using g As Graphics = Graphics.FromImage(blurredImage)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.InterpolationMode = InterpolationMode.High
            g.PixelOffsetMode = PixelOffsetMode.HighQuality
            Dim blurRect As New Rectangle(0, 0, image.Width, image.Height)
            g.DrawImage(image, blurRect, blurRect, GraphicsUnit.Pixel)
        End Using
        Return blurredImage
    End Function

    Function countId(ByVal counterId As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("UPDATE counter_tab SET counterValue=counterValue+1 WHERE counterId=@counterId", connection)
        command.Parameters.AddWithValue("@counterId", counterId)
        reader = command.ExecuteReader
        connection.Close()

        connection.Open()
        command = New MySqlCommand("SELECT counterValue FROM counter_tab WHERE counterId=@counterId", connection)
        command.Parameters.AddWithValue("@counterId", counterId)
        reader = command.ExecuteReader
        reader.Read()
        Dim counterValue = reader("counterValue")
        connection.Close()
        Return counterValue
    End Function

    Function selectPassport(ByVal passport)
        'select passport
        Dim fd As New OpenFileDialog
        fd.Filter = "Choose image(*.gif;*.bmp;*.wmf;*.JPEG;*.PNG;*.GIF;*.JPG;)|*.jpeg;*.png;*.gif;*.jpg;*.gif;*.bmp;*.wmf;"
        If fd.ShowDialog = DialogResult.OK Then
            passport.Image = Image.FromFile(fd.FileName)
        End If
        fd = Nothing
        Return passport
    End Function

    Public Function validateEmail(ByVal emailAddress As String) As Boolean
        Dim email As New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function emailCheck(ByVal emailAddress As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE emailAddress=@emailAddress", connection)
        command.Parameters.AddWithValue("@emailAddress", emailAddress)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Public Function vetEmail() As Boolean

        Try
            Dim connection = functions.connection
            Dim userCount As Integer

            connection.Open()
            command = New MySqlCommand("SELECT * FROM staff_tab WHERE emailAddress=@emailAddress", connection)
            command.Parameters.AddWithValue("@emailAddress", adminRecord.emailAddressTxt.Text)
            userCount = Convert.ToInt32(command.ExecuteScalar())
            connection.Close()

            If (userCount > 0) Then
                MessageBox.Show("Email Address already exists. Please enter a new one.", "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Check Email Failed: " & ex.Message, "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    Function studentEmailCheck(ByVal emailAddress As String)
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT * FROM student_tab WHERE emailAddress=@emailAddress", connection)
        command.Parameters.AddWithValue("@emailAddress", emailAddress)
        reader = command.ExecuteReader
        reader.Read()
        Return reader
        connection.Close()
    End Function

    Function updateEmailCheck(ByVal emailAddress As String)
        Dim connection = functions.connection
        Dim staffId = adminRecord.profileId.SelectedValue
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE emailAddress=@emailAddress AND staffId!=@staffId", connection)
        command.Parameters.AddWithValue("@emailAddress", emailAddress)
        command.Parameters.AddWithValue("@staffId", staffId)
        reader = command.ExecuteReader
        Return reader
        connection.Close()
    End Function

    Public Sub goToAdminPortal()
        'overlay.Close()
        'index.Hide()
        adminlogin.Hide()
        adminlogin.emailAddressTxt.Text = Nothing
        adminlogin.loginPasswordTxt.Text = Nothing
        adminportal.Show()
    End Sub

    Public Sub clearFunction()
        adminRecord.fullNameTxt.Text = Nothing
        adminRecord.emailAddressTxt.Text = Nothing
        adminrecord.phoneNumberTxt.Text = Nothing
        adminRecord.profileId.Text = "SELECT STAFF....."
        adminRecord.staffRoleIdComboBox.Text = "SELECT ROLE"
        adminRecord.staffStatusIdComboBox.Text = "SELECT STATUS"
        adminrecord.adminProfilePic.Image = Nothing

        regStudent.fullNameTxt.Text = Nothing
        regStudent.emailAddressTxt.Text = Nothing
        regStudent.phoneNumberTxt.Text = Nothing
        regStudent.studentProfilePic.Image = Nothing
        regStudent.studentProfileId.Text = "SELECT STUDENT....."
        regStudent.studentGenderIdComboBox.Text = "SELECT GENDER"
        regStudent.studentStatusIdComboBox.Text = "SELECT STATUS"
        regStudent.studentProgrammeIdComboBox.Text = "SELECT PROGRAMME"

        regstudentfingerprint.selectFingerComboBox.Text = "SELECT FINGER"
        regstudentfingerprint.emailAddressTxt.Text = Nothing
        regStudentfingerprint.studentProfilePic.Image = Nothing
        regstudentfingerprint.studentFingerPrintTemplate.Image = Nothing

        regstudentfingerprint.scanProgressBar.Value = 0
        regstudentfingerprint.enrollStatusLabel.Text = "Click Enroll Button To Begin"


    End Sub

    Function getStaffProfile(ByVal staffId As String)
        Dim connection = functions.connection
        connection.Open()
        command = New MySqlCommand("SELECT * FROM staff_tab WHERE staffId=@staffId", connection)
        command.Parameters.AddWithValue("@staffId", staffId)
        reader = command.ExecuteReader
        reader.Read()

        Dim fullName = reader("fullName")
        Dim lastLogin = reader("lastLogin")
        Dim arrimage() As Byte = reader("passport")
        connection.close()
        Return Tuple.Create(fullName, lastLogin, arrimage)
    End Function

    Function getStudentProfile(ByVal studentId As String)
        Dim connection = functions.connection
        connection.Open()

        Dim command As New MySqlCommand("SELECT * FROM student_tab WHERE studentId = @studentId", connection)
        command.Parameters.AddWithValue("@studentId", studentId)

        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()

            Dim fullName As String = reader("fullName").ToString()
            Dim emailAddress As String = reader("emailAddress").ToString()
            Dim phoneNumber As String = reader("phoneNumber").ToString()
            Dim gender As String = reader("gender").ToString()
            Dim programme As String = reader("programme").ToString()
            Dim statusId As String = reader("statusId").ToString()
            Dim roleId As String = reader("RoleId").ToString()
            Dim arrimage() As Byte = reader("passport")

            Return Tuple.Create(fullName, emailAddress, phoneNumber, gender, programme, roleId, statusId, arrimage)
        Else
            Throw New Exception("Student profile not found.")
        End If
    End Function

    Public Sub getStaffID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.* FROM staff_tab a WHERE a.roleId > 1", connection)
        command.Parameters.AddWithValue("@loginRoleId", adminlogin.loginRoleId)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("staffId") = ""
        defaultRow("roleId") = 0
        defaultRow("statusId") = 0
        defaultRow("fullName") = "SELECT STAFF....."
        defaultRow("emailAddress") = ""
        defaultRow("phoneNumber") = ""
        defaultRow("password") = ""
        defaultRow("createdTime") = Now.ToString
        defaultRow("updatedTime") = Now.ToString
        defaultRow("otp") = 0
        DT.Rows.InsertAt(defaultRow, 0)

        adminRecord.profileId.DataSource = DT
        adminRecord.profileId.DisplayMember = "fullName"
        adminRecord.profileId.ValueMember = "staffId"
    End Sub
Public Sub getStudentID()
        Dim DT As New DataTable
        Dim connection = functions.connection

        connection.Open()
        command = New MySqlCommand("SELECT a.*, b.statusName, c.genderName, d.programmeName, e.roleName FROM student_tab a, setup_status_tab b, setup_gender_tab c, setup_programme_tab d, setup_role_tab e WHERE a.statusId = b.statusId AND a.genderId = c.genderId AND a.programmeId = d.programmeId AND a.roleId = e.roleId;", connection)
        DT.Load(command.ExecuteReader)
        connection.Close()

        Dim defaultRow As DataRow = DT.NewRow()
        defaultRow("studentId") = ""
        defaultRow("staffId") = ""
        defaultRow("roleId") = 0
        defaultRow("statusId") = 0
        defaultRow("genderId") = 0
        defaultRow("programmeId") = 0
        defaultRow("fullName") = "SELECT STUDENT....."
        defaultRow("staffFullName") = ""
        defaultRow("emailAddress") = ""
        defaultRow("phoneNumber") = ""
        defaultRow("createdTime") = Now.ToString
        defaultRow("updatedTime") = Now.ToString
        defaultRow("roleName") = ""
        defaultRow("statusName") = ""
        defaultRow("genderName") = ""
        defaultRow("programmeName") = ""
        DT.Rows.InsertAt(defaultRow, 0)

        regStudent.studentProfileId.DataSource = DT
        regStudent.studentProfileId.DisplayMember = "fullName"
        regStudent.studentProfileId.ValueMember = "studentId"
    End Sub

    'to fetch role 
    Public Sub getRole()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_role_tab WHERE roleId IN (2,3);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("roleId") = 0
            defaultRow("roleName") = "SELECT ROLE"
            DT.Rows.InsertAt(defaultRow, 0)

            adminRecord.staffRoleIdComboBox.DataSource = DT
            adminRecord.staffRoleIdComboBox.DisplayMember = "roleName"
            adminRecord.staffRoleIdComboBox.ValueMember = "roleId"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading roles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch status
    Public Sub getStatus()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_status_tab WHERE statusId IN (1,2,3);", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("statusId") = 0
            defaultRow("statusName") = "SELECT STATUS"
            DT.Rows.InsertAt(defaultRow, 0)

            adminRecord.staffStatusIdComboBox.DataSource = DT
            adminRecord.staffStatusIdComboBox.DisplayMember = "statusName"
            adminRecord.staffStatusIdComboBox.ValueMember = "statusId"


            regStudent.studentStatusIdComboBox.DataSource = DT
            regStudent.studentStatusIdComboBox.DisplayMember = "statusName"
            regStudent.studentStatusIdComboBox.ValueMember = "statusId"


        Catch ex As Exception
            MessageBox.Show("An error occurred while loading status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch gender
    Public Sub getGender()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_gender_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("genderId") = 0
            defaultRow("genderName") = "SELECT GENDER"
            DT.Rows.InsertAt(defaultRow, 0)

            regStudent.studentGenderIdComboBox.DataSource = DT
            regStudent.studentGenderIdComboBox.DisplayMember = "genderName"
            regStudent.studentGenderIdComboBox.ValueMember = "genderId"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading gender: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to fetch programme
    Public Sub getProgramme()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_programme_tab;", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("programmeId") = 0
            defaultRow("programmeName") = "SELECT PROGRAMME"
            DT.Rows.InsertAt(defaultRow, 0)

            regStudent.studentProgrammeIdComboBox.DataSource = DT
            regStudent.studentProgrammeIdComboBox.DisplayMember = "programmeName"
            regStudent.studentProgrammeIdComboBox.ValueMember = "programmeId"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading programme: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'to load fingers option
    Public Sub loadFingerOptions()
        Try
            Dim DT As New DataTable
            Dim connection = functions.connection
            connection.Open()
            command = New MySqlCommand("SELECT * FROM setup_fingers_tab", connection)
            DT.Load(command.ExecuteReader)
            connection.Close()

            Dim defaultRow As DataRow = DT.NewRow()
            defaultRow("fingerId") = 0
            defaultRow("fingerLabel") = "SELECT FINGER"
            DT.Rows.InsertAt(defaultRow, 0)

            regstudentfingerprint.selectFingerComboBox.DataSource = DT
            regstudentfingerprint.selectFingerComboBox.DisplayMember = "fingerLabel"
            regstudentfingerprint.selectFingerComboBox.ValueMember = "fingerId"
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading finger: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Function passportSave(ByVal passportBox)
        Dim arrimage() As Byte
        Dim msstream As New System.IO.MemoryStream()
        passportBox.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrimage = msstream.GetBuffer()
        Dim filesize As UInt32
        filesize = msstream.Length
        msstream.Close()

        Return arrimage
    End Function

    Public Sub revertOriginalPassport(ByVal passporrtControl)
        Dim connection = functions.connection()
        Dim command As New MySqlCommand("SELECT passport FROM staff_tab WHERE staffId = @staffId", connection)
        command.Parameters.AddWithValue("@staffId", adminlogin.loginStaffId)

        connection.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            Dim originalImage As Byte() = CType(reader("passport"), Byte())
            Dim ms As New IO.MemoryStream(originalImage)
            passporrtControl.Image = Image.FromStream(ms)

        End If
        connection.Close()
    End Sub

    Public Sub staffRegistration()
        If adminlogin.loginRoleId > 1 Then
            Try
                Dim passport = functions.passportSave(adminRecord.adminProfilePic)
                Dim staffId = "STF" & Now.ToString("yyyyMMddss") & functions.countId("STF")

                Dim connection = functions.connection
                connection.open()

                query = "INSERT INTO staff_tab (`staffId`, `roleId`, `statusId`, `fullName`, `emailAddress`, `phoneNumber`, `passport`, `password`, `createdTime`) VALUES (@staffId, @roleId, @statusId, @fullName, @emailAddress, @phoneNumber, @passport, @password, NOW())"
                Dim Command As New MySqlCommand(query, connection)
                Command.Parameters.AddWithValue("@staffId", staffId)
                Command.Parameters.AddWithValue("@roleId", adminRecord.staffRoleIdComboBox.SelectedValue)
                Command.Parameters.AddWithValue("@statusId", adminRecord.staffStatusIdComboBox.SelectedValue)
                Command.Parameters.AddWithValue("@fullName", adminRecord.fullNameTxt.Text.ToUpper())
                Command.Parameters.AddWithValue("@emailAddress", adminRecord.emailAddressTxt.Text)
                Command.Parameters.AddWithValue("@phoneNumber", adminRecord.phoneNumberTxt.Text)
                Command.Parameters.AddWithValue("@passport", passport)
                Command.Parameters.AddWithValue("@password", staffId)

                reader = Command.ExecuteReader
                connection.Close()

                MessageBox.Show("WELCOME! Staff Registration Successfully Saved", "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                functions.clearFunction()
                functions.getStaffID()
                functions.staffRecord()

            Catch ex As Exception

                MessageBox.Show("Staff Registration failed: " & ex.Message, "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub staffRecord()
        Dim loginRoleId = adminlogin.loginRoleId
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT a.*, b.statusName, c.roleName FROM staff_tab a, setup_status_tab b, setup_role_tab c WHERE a.statusId = b.statusId AND a.roleId = c.roleId AND a.roleId > 1;", connection)
            'command.Parameters.AddWithValue("@loginRoleId", loginRoleId)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            viewadminrecord.staffRecordList.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem((sn.ToString))
                listItem.SubItems.Add(row("staffId").ToString())
                listItem.SubItems.Add(row("fullName").ToString())
                listItem.SubItems.Add(row("emailAddress").ToString())
                listItem.SubItems.Add(row("phoneNumber").ToString())
                listItem.SubItems.Add(row("roleName").ToString())
                listItem.SubItems.Add(row("statusName").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("createdTime").ToString())
                listItem.SubItems.Add(row("updatedTime").ToString())
                listItem.SubItems.Add(row("lastLogin").ToString())

                viewadminrecord.staffRecordList.Items.Add(listItem)
                sn = sn + 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub UpdateStaff()
        If adminlogin.loginRoleId > 1 Then
            Try
                Dim passport = functions.passportSave(adminRecord.adminProfilePic)
                Dim connection = functions.connection

                connection.open()
                query = "UPDATE staff_tab SET fullName=@fullName, roleId=@roleId, statusId=@statusId, emailAddress=@emailAddress, phoneNumber=@phoneNumber, passport=@passport WHERE staffId=@staffId"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@staffId", adminRecord.profileId.SelectedValue)
                command.Parameters.AddWithValue("@roleId", adminRecord.staffRoleIdComboBox.SelectedValue)
                command.Parameters.AddWithValue("@statusId", adminRecord.staffStatusIdComboBox.SelectedValue)
                command.Parameters.AddWithValue("@fullName", adminRecord.fullNameTxt.Text.ToUpper)
                command.Parameters.AddWithValue("@emailAddress", adminRecord.emailAddressTxt.Text)
                command.Parameters.AddWithValue("@phoneNumber", adminRecord.phoneNumberTxt.Text)
                command.Parameters.AddWithValue("@passport", passport)

                reader = command.ExecuteReader
                connection.Close()

                MessageBox.Show("SUCCESS! Staff Updated Successfully", "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
                functions.getStaffID()
                functions.staffRecord()

            Catch ex As Exception
                MessageBox.Show("Staff update Unsuccessful: " & ex.Message, "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub studentRegistration()
        Try
            Dim result = functions.getStaffProfile(adminlogin.loginStaffId)

            Dim staffFullName = result.item1.ToString
            Dim staffId = adminlogin.loginStaffId

            Dim studentId = "STD" & Now.ToString("yyyyMMddss") & functions.countId("STD")

            Dim passport = functions.passportSave(regStudent.studentProfilePic)
            Dim connection = functions.connection

            connection.open()
            query = "INSERT INTO `student_tab`(`studentId`, `roleId`, `statusId`, `genderId`, `staffId`, `staffFullName`, `fullName`, `emailAddress`, `phoneNumber`, `passport`, `programmeId`, `createdTime`) VALUES(@studentId, @roleId, @statusId, @genderId, @staffId, @staffFullName, @fullName, @emailAddress, @phoneNumber, @passport, @programmeId, NOW())"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", studentId)
            command.Parameters.AddWithValue("@genderId", regStudent.studentGenderIdComboBox.SelectedValue)
            command.Parameters.AddWithValue("@staffId", staffId)
            command.Parameters.AddWithValue("@statusId", regStudent.studentStatusIdComboBox.SelectedValue)
            command.Parameters.AddWithValue("@roleId", 1)
            command.Parameters.AddWithValue("@staffFullName", staffFullName)
            command.Parameters.AddWithValue("@fullName", regStudent.fullNameTxt.Text.ToUpper)
            command.Parameters.AddWithValue("@emailAddress", regStudent.emailAddressTxt.Text)
            command.Parameters.AddWithValue("@phoneNumber", regStudent.phoneNumberTxt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@programmeId", regStudent.studentProgrammeIdComboBox.SelectedValue)


            reader = command.ExecuteReader
            connection.Close()

            'connection.open()
            'query = "INSERT INTO `account_tab`(`account_id`, `customer_id`, `account_balance`, `loan_balance`, `created_time`) VALUES(@account_id, @customer_id, 00.0, 00.0, NOW())"
            'command = New MySqlCommand(query, connection)
            'command.Parameters.AddWithValue("@account_id", account_id)
            'command.Parameters.AddWithValue("@customer_id", customer_id)
            'reader = command.ExecuteReader
            'onnection.Close()

            MessageBox.Show("SUCCESS! Student Registration Successfully Saved", "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.clearFunction()
            functions.getStudentID()
            functions.studentRecord()

        Catch ex As Exception
            MessageBox.Show("Student Registration failed: " & ex.Message, "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub UpdateStudent()
        Try
            Dim passport = functions.passportSave(regStudent.studentProfilePic)
            Dim connection = functions.connection

            connection.open()
            query = "UPDATE student_tab SET fullName=@fullName, genderId=@genderId, statusId=@statusid, programmeId=@programmeId, emailAddress=@emailAddress, phoneNumber=@phoneNumber, passport=@passport WHERE studentId=@studentId"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@studentId", regStudent.studentProfileId.SelectedValue)
            command.Parameters.AddWithValue("@genderId", regStudent.studentGenderIdComboBox.SelectedValue)
            command.Parameters.AddWithValue("@statusId", regStudent.studentStatusIdComboBox.SelectedValue)
            command.Parameters.AddWithValue("@fullName", regStudent.fullNameTxt.Text.ToUpper)
            command.Parameters.AddWithValue("@emailAddress", regStudent.emailAddressTxt.Text)
            command.Parameters.AddWithValue("@phoneNumber", regStudent.phoneNumberTxt.Text)
            command.Parameters.AddWithValue("@passport", passport)
            command.Parameters.AddWithValue("@programmeId", regStudent.studentProgrammeIdComboBox.SelectedValue)
            reader = command.ExecuteReader
            connection.Close()

            MessageBox.Show("SUCCESS! Student Updated Successfully", "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            functions.getStudentID()
            functions.studentRecord()

        Catch ex As Exception
            MessageBox.Show("Student update Unsuccessful: " & ex.Message, "AfoTECH Attendance Management System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub studentRecord()
        Try
            Dim connection As MySql.Data.MySqlClient.MySqlConnection = functions.connection
            Dim command As New MySqlCommand("SELECT CONCAT(a.staffId, ' / ', a.staffFullName) AS registeredBy, a.*, b.statusName, c.genderName, d.programmeName FROM student_tab a, setup_status_tab b, setup_gender_tab c, setup_programme_tab d WHERE a.statusId = b.statusId AND a.genderId = c.genderId AND a.programmeId = d.programmeId;", connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            studentRecords.studentRecordList.Items.Clear()
            Dim sn As Integer = 1
            For Each row As DataRow In table.Rows
                Dim listItem As New ListViewItem(sn.ToString())
                listItem.SubItems.Add(row("studentId").ToString())
                listItem.SubItems.Add(row("fullName").ToString())
                listItem.SubItems.Add(row("emailAddress").ToString())
                listItem.SubItems.Add(row("phoneNumber").ToString())
                listItem.SubItems.Add(row("passport").ToString())
                listItem.SubItems.Add(row("registeredBy").ToString())
                listItem.SubItems.Add(row("createdTime").ToString())
                listItem.SubItems.Add(row("updatedTime").ToString())
                listItem.SubItems.Add(row("genderName").ToString())
                listItem.SubItems.Add(row("statusName").ToString())
                listItem.SubItems.Add(row("programmeName").ToString())

                studentRecords.studentRecordList.Items.Add(listItem)
                sn += 1
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function alphaCheck(ByVal e)
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("This field allows only Letters!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

    Function numCheck(ByVal e)
        If Not Char.IsDigit(e.KeyChar) AndAlso
         Not Char.IsWhiteSpace(e.KeyChar) AndAlso
         Not Char.IsControl(e.KeyChar) AndAlso
         e.KeyChar <> "+"c AndAlso
         e.KeyChar <> "-"c AndAlso
         e.KeyChar <> "("c AndAlso
         e.KeyChar <> ")"c Then
            e.Handled = True
            MessageBox.Show("This field allows only numbers(+, -, (, ))!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return e
    End Function

End Module
