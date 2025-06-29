<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class markAttendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(markAttendance))
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.admin_profile_pic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.startScanBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.markAttendanceStatusLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.markAttendanceTimeSlot = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.emailAddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.fullNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.markAttendanceProfilePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.markAttendanceTimeslotLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.date_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.time_label = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.markAttendanceRecordList = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lastResetLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lastResetLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.admin_profile_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.markAttendanceProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 4
        Me.Guna2GroupBox3.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox3.Controls.Add(Me.startScanBtn)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(12, 467)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(314, 238)
        Me.Guna2GroupBox3.TabIndex = 18
        Me.Guna2GroupBox3.Text = "Sign IN and OUT? Place your finger on the scanner  "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.admin_profile_pic)
        Me.Panel2.Location = New System.Drawing.Point(21, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 183)
        Me.Panel2.TabIndex = 5
        '
        'admin_profile_pic
        '
        Me.admin_profile_pic.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.admin_profile_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admin_profile_pic.BorderRadius = 5
        Me.admin_profile_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.admin_profile_pic.Image = Global.WindowsApplication2.My.Resources.Resources.istockphoto_519825403_612x612
        Me.admin_profile_pic.Location = New System.Drawing.Point(22, 11)
        Me.admin_profile_pic.Name = "admin_profile_pic"
        Me.admin_profile_pic.ShadowDecoration.Parent = Me.admin_profile_pic
        Me.admin_profile_pic.Size = New System.Drawing.Size(222, 158)
        Me.admin_profile_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.admin_profile_pic.TabIndex = 0
        Me.admin_profile_pic.TabStop = False
        '
        'startScanBtn
        '
        Me.startScanBtn.BackColor = System.Drawing.SystemColors.Control
        Me.startScanBtn.BorderColor = System.Drawing.Color.Transparent
        Me.startScanBtn.BorderRadius = 5
        Me.startScanBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.startScanBtn.CheckedState.Parent = Me.startScanBtn
        Me.startScanBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startScanBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.startScanBtn.CustomImages.Parent = Me.startScanBtn
        Me.startScanBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startScanBtn.ForeColor = System.Drawing.Color.White
        Me.startScanBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startScanBtn.HoverState.Parent = Me.startScanBtn
        Me.startScanBtn.Location = New System.Drawing.Point(29, 257)
        Me.startScanBtn.Name = "startScanBtn"
        Me.startScanBtn.ShadowDecoration.Parent = Me.startScanBtn
        Me.startScanBtn.Size = New System.Drawing.Size(240, 42)
        Me.startScanBtn.TabIndex = 20
        Me.startScanBtn.Text = "START SCANNING"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.markAttendanceStatusLabel)
        Me.Guna2GroupBox1.Controls.Add(Me.markAttendanceTimeSlot)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox1.Controls.Add(Me.emailAddressTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.fullNameTxt)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(489, 172)
        Me.Guna2GroupBox1.TabIndex = 19
        Me.Guna2GroupBox1.Text = "Student Information"
        '
        'markAttendanceStatusLabel
        '
        Me.markAttendanceStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.markAttendanceStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.markAttendanceStatusLabel.ForeColor = System.Drawing.Color.Black
        Me.markAttendanceStatusLabel.Location = New System.Drawing.Point(299, 143)
        Me.markAttendanceStatusLabel.Name = "markAttendanceStatusLabel"
        Me.markAttendanceStatusLabel.Size = New System.Drawing.Size(35, 15)
        Me.markAttendanceStatusLabel.TabIndex = 33
        Me.markAttendanceStatusLabel.Text = "Status"
        '
        'markAttendanceTimeSlot
        '
        Me.markAttendanceTimeSlot.BackColor = System.Drawing.Color.Transparent
        Me.markAttendanceTimeSlot.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.markAttendanceTimeSlot.ForeColor = System.Drawing.Color.Black
        Me.markAttendanceTimeSlot.Location = New System.Drawing.Point(299, 83)
        Me.markAttendanceTimeSlot.Name = "markAttendanceTimeSlot"
        Me.markAttendanceTimeSlot.Size = New System.Drawing.Size(31, 15)
        Me.markAttendanceTimeSlot.TabIndex = 32
        Me.markAttendanceTimeSlot.Text = "-------"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(299, 120)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(38, 15)
        Me.Guna2HtmlLabel7.TabIndex = 31
        Me.Guna2HtmlLabel7.Text = "Status:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 103)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(76, 15)
        Me.Guna2HtmlLabel2.TabIndex = 25
        Me.Guna2HtmlLabel2.Text = "Email Address"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(13, 43)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(53, 15)
        Me.Guna2HtmlLabel4.TabIndex = 23
        Me.Guna2HtmlLabel4.Text = "FullName"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(299, 60)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(54, 15)
        Me.Guna2HtmlLabel6.TabIndex = 29
        Me.Guna2HtmlLabel6.Text = "Time Slot:"
        '
        'emailAddressTxt
        '
        Me.emailAddressTxt.AcceptsReturn = True
        Me.emailAddressTxt.BorderRadius = 5
        Me.emailAddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailAddressTxt.DefaultText = ""
        Me.emailAddressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.emailAddressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.emailAddressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailAddressTxt.DisabledState.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.emailAddressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailAddressTxt.FocusedState.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAddressTxt.ForeColor = System.Drawing.Color.Black
        Me.emailAddressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailAddressTxt.HoverState.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Location = New System.Drawing.Point(13, 120)
        Me.emailAddressTxt.Name = "emailAddressTxt"
        Me.emailAddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTxt.PlaceholderText = "EMAIL ADDRESS"
        Me.emailAddressTxt.SelectedText = ""
        Me.emailAddressTxt.ShadowDecoration.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Size = New System.Drawing.Size(271, 38)
        Me.emailAddressTxt.TabIndex = 21
        '
        'fullNameTxt
        '
        Me.fullNameTxt.BorderRadius = 5
        Me.fullNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fullNameTxt.DefaultText = ""
        Me.fullNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fullNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fullNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullNameTxt.DisabledState.Parent = Me.fullNameTxt
        Me.fullNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fullNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullNameTxt.FocusedState.Parent = Me.fullNameTxt
        Me.fullNameTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullNameTxt.ForeColor = System.Drawing.Color.Black
        Me.fullNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fullNameTxt.HoverState.Parent = Me.fullNameTxt
        Me.fullNameTxt.Location = New System.Drawing.Point(11, 60)
        Me.fullNameTxt.Name = "fullNameTxt"
        Me.fullNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullNameTxt.PlaceholderText = "FULLNAME"
        Me.fullNameTxt.SelectedText = ""
        Me.fullNameTxt.ShadowDecoration.Parent = Me.fullNameTxt
        Me.fullNameTxt.Size = New System.Drawing.Size(271, 38)
        Me.fullNameTxt.TabIndex = 20
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 4
        Me.Guna2GroupBox2.Controls.Add(Me.markAttendanceProfilePic)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(529, 467)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(232, 238)
        Me.Guna2GroupBox2.TabIndex = 20
        Me.Guna2GroupBox2.Text = "Profile Picture"
        '
        'markAttendanceProfilePic
        '
        Me.markAttendanceProfilePic.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.markAttendanceProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.markAttendanceProfilePic.BorderRadius = 5
        Me.markAttendanceProfilePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.markAttendanceProfilePic.Image = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity1
        Me.markAttendanceProfilePic.Location = New System.Drawing.Point(16, 49)
        Me.markAttendanceProfilePic.Name = "markAttendanceProfilePic"
        Me.markAttendanceProfilePic.ShadowDecoration.Parent = Me.markAttendanceProfilePic
        Me.markAttendanceProfilePic.Size = New System.Drawing.Size(202, 178)
        Me.markAttendanceProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.markAttendanceProfilePic.TabIndex = 1
        Me.markAttendanceProfilePic.TabStop = False
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(771, 48)
        Me.Guna2Panel1.TabIndex = 22
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(47, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(110, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Mark Attendance"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox2.Image = Global.WindowsApplication2.My.Resources.Resources.icon1
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(1, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 0
        Me.Guna2PictureBox2.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.close_btn.Animated = True
        Me.close_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.close_btn.BorderRadius = 19
        Me.close_btn.CheckedState.Parent = Me.close_btn
        Me.close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_btn.CustomImages.Parent = Me.close_btn
        Me.close_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.close_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_btn.ForeColor = System.Drawing.Color.White
        Me.close_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.close_btn.HoverState.Parent = Me.close_btn
        Me.close_btn.Location = New System.Drawing.Point(730, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel3.Controls.Add(Me.markAttendanceTimeslotLabel)
        Me.Guna2Panel3.Controls.Add(Me.date_label)
        Me.Guna2Panel3.Controls.Add(Me.time_label)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(21, 55)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(205, 97)
        Me.Guna2Panel3.TabIndex = 23
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(11, 54)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(33, 18)
        Me.Guna2HtmlLabel3.TabIndex = 6
        Me.Guna2HtmlLabel3.Text = " Date:"
        '
        'markAttendanceTimeslotLabel
        '
        Me.markAttendanceTimeslotLabel.BackColor = System.Drawing.Color.Transparent
        Me.markAttendanceTimeslotLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markAttendanceTimeslotLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.markAttendanceTimeslotLabel.Location = New System.Drawing.Point(11, 22)
        Me.markAttendanceTimeslotLabel.Name = "markAttendanceTimeslotLabel"
        Me.markAttendanceTimeslotLabel.Size = New System.Drawing.Size(34, 18)
        Me.markAttendanceTimeslotLabel.TabIndex = 5
        Me.markAttendanceTimeslotLabel.Text = " Time:"
        '
        'date_label
        '
        Me.date_label.BackColor = System.Drawing.Color.Transparent
        Me.date_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_label.Location = New System.Drawing.Point(55, 52)
        Me.date_label.Name = "date_label"
        Me.date_label.Size = New System.Drawing.Size(84, 17)
        Me.date_label.TabIndex = 4
        Me.date_label.Text = "Current Date"
        '
        'time_label
        '
        Me.time_label.BackColor = System.Drawing.Color.Transparent
        Me.time_label.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_label.ForeColor = System.Drawing.Color.Maroon
        Me.time_label.Location = New System.Drawing.Point(55, 22)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(77, 18)
        Me.time_label.TabIndex = 3
        Me.time_label.Text = "Current Time"
        '
        'Timer1
        '
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderRadius = 4
        Me.Guna2GroupBox4.Controls.Add(Me.Guna2Panel3)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(518, 53)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.Parent = Me.Guna2GroupBox4
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(242, 171)
        Me.Guna2GroupBox4.TabIndex = 21
        Me.Guna2GroupBox4.Text = "Current Tme And Date"
        '
        'markAttendanceRecordList
        '
        Me.markAttendanceRecordList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7})
        Me.markAttendanceRecordList.FullRowSelect = True
        Me.markAttendanceRecordList.GridLines = True
        Me.markAttendanceRecordList.Location = New System.Drawing.Point(12, 229)
        Me.markAttendanceRecordList.Name = "markAttendanceRecordList"
        Me.markAttendanceRecordList.Size = New System.Drawing.Size(748, 231)
        Me.markAttendanceRecordList.TabIndex = 27
        Me.markAttendanceRecordList.UseCompatibleStateImageBehavior = False
        Me.markAttendanceRecordList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "S/N"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "FULLNAME"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATE"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DAY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TIME-IN"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TIME-OUT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'lastResetLabel1
        '
        Me.lastResetLabel1.BackColor = System.Drawing.Color.Transparent
        Me.lastResetLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lastResetLabel1.ForeColor = System.Drawing.Color.Black
        Me.lastResetLabel1.Location = New System.Drawing.Point(351, 467)
        Me.lastResetLabel1.Name = "lastResetLabel1"
        Me.lastResetLabel1.Size = New System.Drawing.Size(89, 15)
        Me.lastResetLabel1.TabIndex = 30
        Me.lastResetLabel1.Text = "Table Last Reset:"
        '
        'lastResetLabel
        '
        Me.lastResetLabel.BackColor = System.Drawing.Color.Transparent
        Me.lastResetLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lastResetLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lastResetLabel.Location = New System.Drawing.Point(351, 488)
        Me.lastResetLabel.Name = "lastResetLabel"
        Me.lastResetLabel.Size = New System.Drawing.Size(119, 15)
        Me.lastResetLabel.TabIndex = 31
        Me.lastResetLabel.Text = "Last Reset Time: --:--:--"
        '
        'markAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 717)
        Me.Controls.Add(Me.lastResetLabel)
        Me.Controls.Add(Me.lastResetLabel1)
        Me.Controls.Add(Me.markAttendanceRecordList)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "markAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mark Attendance"
        Me.TopMost = True
        Me.Guna2GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.admin_profile_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        CType(Me.markAttendanceProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents admin_profile_pic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents startScanBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents markAttendanceProfilePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents markAttendanceTimeslotLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents date_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents time_label As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents emailAddressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fullNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents markAttendanceStatusLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents markAttendanceTimeSlot As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents markAttendanceRecordList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lastResetLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lastResetLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
