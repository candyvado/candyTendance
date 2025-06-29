<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminRecord
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminRecord))
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.captureBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.adminProfilePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.staffStatusIdComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.profileId = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.fetchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.staffRoleIdComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.totalAdminCountLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.viewAdminRecordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.fullNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.saveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.phoneNumberTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.emailAddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.adminProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 4
        Me.Guna2GroupBox3.Controls.Add(Me.captureBtn)
        Me.Guna2GroupBox3.Controls.Add(Me.adminProfilePic)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(400, 239)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(215, 256)
        Me.Guna2GroupBox3.TabIndex = 23
        Me.Guna2GroupBox3.Text = "Passport"
        '
        'captureBtn
        '
        Me.captureBtn.BackColor = System.Drawing.SystemColors.Control
        Me.captureBtn.BorderColor = System.Drawing.Color.Transparent
        Me.captureBtn.BorderRadius = 5
        Me.captureBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.captureBtn.CheckedState.Parent = Me.captureBtn
        Me.captureBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.captureBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.captureBtn.CustomImages.Parent = Me.captureBtn
        Me.captureBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captureBtn.ForeColor = System.Drawing.Color.White
        Me.captureBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.captureBtn.HoverState.Parent = Me.captureBtn
        Me.captureBtn.Location = New System.Drawing.Point(17, 204)
        Me.captureBtn.Name = "captureBtn"
        Me.captureBtn.ShadowDecoration.Parent = Me.captureBtn
        Me.captureBtn.Size = New System.Drawing.Size(176, 42)
        Me.captureBtn.TabIndex = 4
        Me.captureBtn.Text = "CAPTURE"
        '
        'adminProfilePic
        '
        Me.adminProfilePic.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.Car_Wash
        Me.adminProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminProfilePic.BorderRadius = 5
        Me.adminProfilePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.adminProfilePic.Image = Global.WindowsApplication2.My.Resources.Resources.Car_Wash
        Me.adminProfilePic.Location = New System.Drawing.Point(21, 48)
        Me.adminProfilePic.Name = "adminProfilePic"
        Me.adminProfilePic.ShadowDecoration.Parent = Me.adminProfilePic
        Me.adminProfilePic.Size = New System.Drawing.Size(172, 148)
        Me.adminProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.adminProfilePic.TabIndex = 0
        Me.adminProfilePic.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(47, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Admin Record"
        '
        'staffStatusIdComboBox
        '
        Me.staffStatusIdComboBox.BackColor = System.Drawing.Color.Transparent
        Me.staffStatusIdComboBox.BorderRadius = 5
        Me.staffStatusIdComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.staffStatusIdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.staffStatusIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.staffStatusIdComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.staffStatusIdComboBox.FocusedState.Parent = Me.staffStatusIdComboBox
        Me.staffStatusIdComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffStatusIdComboBox.ForeColor = System.Drawing.Color.Black
        Me.staffStatusIdComboBox.FormattingEnabled = True
        Me.staffStatusIdComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.staffStatusIdComboBox.HoverState.Parent = Me.staffStatusIdComboBox
        Me.staffStatusIdComboBox.ItemHeight = 30
        Me.staffStatusIdComboBox.ItemsAppearance.Parent = Me.staffStatusIdComboBox
        Me.staffStatusIdComboBox.Location = New System.Drawing.Point(14, 318)
        Me.staffStatusIdComboBox.Name = "staffStatusIdComboBox"
        Me.staffStatusIdComboBox.ShadowDecoration.Parent = Me.staffStatusIdComboBox
        Me.staffStatusIdComboBox.Size = New System.Drawing.Size(351, 36)
        Me.staffStatusIdComboBox.TabIndex = 19
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(15, 301)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(62, 15)
        Me.Guna2HtmlLabel7.TabIndex = 20
        Me.Guna2HtmlLabel7.Text = "Staff Status "
        '
        'profileId
        '
        Me.profileId.BackColor = System.Drawing.Color.Transparent
        Me.profileId.BorderRadius = 5
        Me.profileId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profileId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.profileId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.profileId.FocusedColor = System.Drawing.Color.Empty
        Me.profileId.FocusedState.Parent = Me.profileId
        Me.profileId.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profileId.ForeColor = System.Drawing.Color.Black
        Me.profileId.FormattingEnabled = True
        Me.profileId.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.profileId.HoverState.Parent = Me.profileId
        Me.profileId.ItemHeight = 30
        Me.profileId.ItemsAppearance.Parent = Me.profileId
        Me.profileId.Location = New System.Drawing.Point(17, 50)
        Me.profileId.Name = "profileId"
        Me.profileId.ShadowDecoration.Parent = Me.profileId
        Me.profileId.Size = New System.Drawing.Size(568, 36)
        Me.profileId.TabIndex = 8
        '
        'closeBtn
        '
        Me.closeBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBtn.Animated = True
        Me.closeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.closeBtn.BorderRadius = 19
        Me.closeBtn.CheckedState.Parent = Me.closeBtn
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.CustomImages.Parent = Me.closeBtn
        Me.closeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.Color.White
        Me.closeBtn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.closeBtn.HoverState.Parent = Me.closeBtn
        Me.closeBtn.Location = New System.Drawing.Point(587, 4)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(36, 40)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'fetchBtn
        '
        Me.fetchBtn.BackColor = System.Drawing.SystemColors.Control
        Me.fetchBtn.BorderColor = System.Drawing.Color.Transparent
        Me.fetchBtn.BorderRadius = 5
        Me.fetchBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.fetchBtn.CheckedState.Parent = Me.fetchBtn
        Me.fetchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fetchBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.fetchBtn.CustomImages.Parent = Me.fetchBtn
        Me.fetchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fetchBtn.ForeColor = System.Drawing.Color.White
        Me.fetchBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fetchBtn.HoverState.Parent = Me.fetchBtn
        Me.fetchBtn.Location = New System.Drawing.Point(481, 92)
        Me.fetchBtn.Name = "fetchBtn"
        Me.fetchBtn.ShadowDecoration.Parent = Me.fetchBtn
        Me.fetchBtn.Size = New System.Drawing.Size(102, 33)
        Me.fetchBtn.TabIndex = 10
        Me.fetchBtn.Text = "FETCH"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(15, 242)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(53, 15)
        Me.Guna2HtmlLabel6.TabIndex = 14
        Me.Guna2HtmlLabel6.Text = "Staff Role "
        '
        'staffRoleIdComboBox
        '
        Me.staffRoleIdComboBox.BackColor = System.Drawing.Color.Transparent
        Me.staffRoleIdComboBox.BorderRadius = 5
        Me.staffRoleIdComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.staffRoleIdComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.staffRoleIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.staffRoleIdComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.staffRoleIdComboBox.FocusedState.Parent = Me.staffRoleIdComboBox
        Me.staffRoleIdComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffRoleIdComboBox.ForeColor = System.Drawing.Color.Black
        Me.staffRoleIdComboBox.FormattingEnabled = True
        Me.staffRoleIdComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.staffRoleIdComboBox.HoverState.Parent = Me.staffRoleIdComboBox
        Me.staffRoleIdComboBox.ItemHeight = 30
        Me.staffRoleIdComboBox.ItemsAppearance.Parent = Me.staffRoleIdComboBox
        Me.staffRoleIdComboBox.Location = New System.Drawing.Point(14, 259)
        Me.staffRoleIdComboBox.Name = "staffRoleIdComboBox"
        Me.staffRoleIdComboBox.ShadowDecoration.Parent = Me.staffRoleIdComboBox
        Me.staffRoleIdComboBox.Size = New System.Drawing.Size(351, 36)
        Me.staffRoleIdComboBox.TabIndex = 13
        '
        'totalAdminCountLabel
        '
        Me.totalAdminCountLabel.BackColor = System.Drawing.Color.Transparent
        Me.totalAdminCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAdminCountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.totalAdminCountLabel.Location = New System.Drawing.Point(556, 13)
        Me.totalAdminCountLabel.Name = "totalAdminCountLabel"
        Me.totalAdminCountLabel.Size = New System.Drawing.Size(11, 17)
        Me.totalAdminCountLabel.TabIndex = 7
        Me.totalAdminCountLabel.Text = "0"
        '
        'viewAdminRecordBtn
        '
        Me.viewAdminRecordBtn.BackColor = System.Drawing.Color.Silver
        Me.viewAdminRecordBtn.BorderColor = System.Drawing.Color.Transparent
        Me.viewAdminRecordBtn.BorderRadius = 5
        Me.viewAdminRecordBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.viewAdminRecordBtn.CheckedState.Parent = Me.viewAdminRecordBtn
        Me.viewAdminRecordBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.viewAdminRecordBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.viewAdminRecordBtn.CustomImages.Parent = Me.viewAdminRecordBtn
        Me.viewAdminRecordBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewAdminRecordBtn.ForeColor = System.Drawing.Color.White
        Me.viewAdminRecordBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.viewAdminRecordBtn.HoverState.Parent = Me.viewAdminRecordBtn
        Me.viewAdminRecordBtn.Location = New System.Drawing.Point(11, 6)
        Me.viewAdminRecordBtn.Name = "viewAdminRecordBtn"
        Me.viewAdminRecordBtn.ShadowDecoration.Parent = Me.viewAdminRecordBtn
        Me.viewAdminRecordBtn.Size = New System.Drawing.Size(120, 30)
        Me.viewAdminRecordBtn.TabIndex = 4
        Me.viewAdminRecordBtn.Text = "VIEW RECORD"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Controls.Add(Me.totalAdminCountLabel)
        Me.Guna2Panel2.Controls.Add(Me.viewAdminRecordBtn)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Location = New System.Drawing.Point(1, 48)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(628, 43)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(15, 120)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(76, 15)
        Me.Guna2HtmlLabel5.TabIndex = 11
        Me.Guna2HtmlLabel5.Text = "Email Address"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(15, 181)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(83, 15)
        Me.Guna2HtmlLabel3.TabIndex = 10
        Me.Guna2HtmlLabel3.Text = "Phone Number"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.closeBtn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(628, 48)
        Me.Guna2Panel1.TabIndex = 19
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon1
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.SystemColors.Control
        Me.clearBtn.BorderColor = System.Drawing.Color.Transparent
        Me.clearBtn.BorderRadius = 5
        Me.clearBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.clearBtn.CheckedState.Parent = Me.clearBtn
        Me.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.clearBtn.CustomImages.Parent = Me.clearBtn
        Me.clearBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.White
        Me.clearBtn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.clearBtn.HoverState.Parent = Me.clearBtn
        Me.clearBtn.Location = New System.Drawing.Point(24, 58)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.ShadowDecoration.Parent = Me.clearBtn
        Me.clearBtn.Size = New System.Drawing.Size(172, 40)
        Me.clearBtn.TabIndex = 15
        Me.clearBtn.Text = "CLEAR"
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
        Me.fullNameTxt.Location = New System.Drawing.Point(15, 75)
        Me.fullNameTxt.Name = "fullNameTxt"
        Me.fullNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullNameTxt.PlaceholderText = "FULLNAME"
        Me.fullNameTxt.SelectedText = ""
        Me.fullNameTxt.ShadowDecoration.Parent = Me.fullNameTxt
        Me.fullNameTxt.Size = New System.Drawing.Size(351, 38)
        Me.fullNameTxt.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearBtn)
        Me.GroupBox1.Controls.Add(Me.saveBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(397, 501)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 107)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.SystemColors.Control
        Me.saveBtn.BorderColor = System.Drawing.Color.Transparent
        Me.saveBtn.BorderRadius = 5
        Me.saveBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.saveBtn.CheckedState.Parent = Me.saveBtn
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.saveBtn.CustomImages.Parent = Me.saveBtn
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveBtn.HoverState.Parent = Me.saveBtn
        Me.saveBtn.Location = New System.Drawing.Point(24, 13)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.ShadowDecoration.Parent = Me.saveBtn
        Me.saveBtn.Size = New System.Drawing.Size(172, 40)
        Me.saveBtn.TabIndex = 14
        Me.saveBtn.Text = "SAVE"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(15, 58)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(53, 15)
        Me.Guna2HtmlLabel4.TabIndex = 9
        Me.Guna2HtmlLabel4.Text = "FullName"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderRadius = 4
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2GroupBox2.Controls.Add(Me.staffStatusIdComboBox)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2GroupBox2.Controls.Add(Me.staffRoleIdComboBox)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2GroupBox2.Controls.Add(Me.phoneNumberTxt)
        Me.Guna2GroupBox2.Controls.Add(Me.emailAddressTxt)
        Me.Guna2GroupBox2.Controls.Add(Me.fullNameTxt)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(10, 239)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(380, 369)
        Me.Guna2GroupBox2.TabIndex = 22
        Me.Guna2GroupBox2.Text = "Staff Information"
        '
        'phoneNumberTxt
        '
        Me.phoneNumberTxt.BorderRadius = 5
        Me.phoneNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phoneNumberTxt.DefaultText = ""
        Me.phoneNumberTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.phoneNumberTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.phoneNumberTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNumberTxt.DisabledState.Parent = Me.phoneNumberTxt
        Me.phoneNumberTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.phoneNumberTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phoneNumberTxt.FocusedState.Parent = Me.phoneNumberTxt
        Me.phoneNumberTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNumberTxt.ForeColor = System.Drawing.Color.Black
        Me.phoneNumberTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.phoneNumberTxt.HoverState.Parent = Me.phoneNumberTxt
        Me.phoneNumberTxt.Location = New System.Drawing.Point(15, 198)
        Me.phoneNumberTxt.Name = "phoneNumberTxt"
        Me.phoneNumberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.phoneNumberTxt.PlaceholderText = "PHONE NUMBER"
        Me.phoneNumberTxt.SelectedText = ""
        Me.phoneNumberTxt.ShadowDecoration.Parent = Me.phoneNumberTxt
        Me.phoneNumberTxt.Size = New System.Drawing.Size(351, 38)
        Me.phoneNumberTxt.TabIndex = 8
        '
        'emailAddressTxt
        '
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
        Me.emailAddressTxt.Location = New System.Drawing.Point(15, 137)
        Me.emailAddressTxt.Name = "emailAddressTxt"
        Me.emailAddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTxt.PlaceholderText = "EMAIL ADDRESS"
        Me.emailAddressTxt.SelectedText = ""
        Me.emailAddressTxt.ShadowDecoration.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Size = New System.Drawing.Size(351, 38)
        Me.emailAddressTxt.TabIndex = 7
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 4
        Me.Guna2GroupBox1.Controls.Add(Me.fetchBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.profileId)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(8, 101)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(609, 132)
        Me.Guna2GroupBox1.TabIndex = 21
        Me.Guna2GroupBox1.Text = "PROFILE ID"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(446, 12)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(90, 17)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "TOTAL STAFF"
        '
        'adminRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 618)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminrecord"
        Me.TopMost = True
        Me.Guna2GroupBox3.ResumeLayout(False)
        CType(Me.adminProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents captureBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adminProfilePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents staffStatusIdComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents profileId As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fetchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents staffRoleIdComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents totalAdminCountLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents viewAdminRecordBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents fullNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents saveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents phoneNumberTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents emailAddressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
