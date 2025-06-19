<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regstudentfingerprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(regstudentfingerprint))
        Me.Guna2GroupBox4 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.enrollStatusLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fingerCaptureBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.studentFingerPrintTemplate = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox3 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.studentProfilePic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.total_customer_count_label_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.emailAddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.clearBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.startEnrollBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.scanProgressBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.selectFingerComboBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.studentFingerPrintTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox3.SuspendLayout()
        CType(Me.studentProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox4
        '
        Me.Guna2GroupBox4.BorderRadius = 4
        Me.Guna2GroupBox4.Controls.Add(Me.enrollStatusLabel)
        Me.Guna2GroupBox4.Controls.Add(Me.Label6)
        Me.Guna2GroupBox4.Controls.Add(Me.fingerCaptureBtn)
        Me.Guna2GroupBox4.Controls.Add(Me.Panel2)
        Me.Guna2GroupBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox4.Location = New System.Drawing.Point(22, 222)
        Me.Guna2GroupBox4.Name = "Guna2GroupBox4"
        Me.Guna2GroupBox4.ShadowDecoration.Parent = Me.Guna2GroupBox4
        Me.Guna2GroupBox4.Size = New System.Drawing.Size(340, 339)
        Me.Guna2GroupBox4.TabIndex = 32
        Me.Guna2GroupBox4.Text = "To Register Place Your Finger On The Scanner"
        '
        'enrollStatusLabel
        '
        Me.enrollStatusLabel.AutoSize = True
        Me.enrollStatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.enrollStatusLabel.Location = New System.Drawing.Point(131, 313)
        Me.enrollStatusLabel.Name = "enrollStatusLabel"
        Me.enrollStatusLabel.Size = New System.Drawing.Size(160, 15)
        Me.enrollStatusLabel.TabIndex = 17
        Me.enrollStatusLabel.Text = "Click Enroll Button To Begin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Status:"
        '
        'fingerCaptureBtn
        '
        Me.fingerCaptureBtn.BackColor = System.Drawing.SystemColors.Control
        Me.fingerCaptureBtn.BorderColor = System.Drawing.Color.Transparent
        Me.fingerCaptureBtn.BorderRadius = 5
        Me.fingerCaptureBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.fingerCaptureBtn.CheckedState.Parent = Me.fingerCaptureBtn
        Me.fingerCaptureBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fingerCaptureBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.fingerCaptureBtn.CustomImages.Parent = Me.fingerCaptureBtn
        Me.fingerCaptureBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fingerCaptureBtn.ForeColor = System.Drawing.Color.White
        Me.fingerCaptureBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fingerCaptureBtn.HoverState.Parent = Me.fingerCaptureBtn
        Me.fingerCaptureBtn.Location = New System.Drawing.Point(14, 286)
        Me.fingerCaptureBtn.Name = "fingerCaptureBtn"
        Me.fingerCaptureBtn.ShadowDecoration.Parent = Me.fingerCaptureBtn
        Me.fingerCaptureBtn.Size = New System.Drawing.Size(108, 42)
        Me.fingerCaptureBtn.TabIndex = 5
        Me.fingerCaptureBtn.Text = "CAPTURE"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.studentFingerPrintTemplate)
        Me.Panel2.Location = New System.Drawing.Point(14, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(305, 218)
        Me.Panel2.TabIndex = 5
        '
        'studentFingerPrintTemplate
        '
        Me.studentFingerPrintTemplate.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.istockphoto_519825403_612x612
        Me.studentFingerPrintTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentFingerPrintTemplate.BorderRadius = 5
        Me.studentFingerPrintTemplate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentFingerPrintTemplate.Image = Global.WindowsApplication2.My.Resources.Resources.istockphoto_519825403_612x612
        Me.studentFingerPrintTemplate.Location = New System.Drawing.Point(21, 18)
        Me.studentFingerPrintTemplate.Name = "studentFingerPrintTemplate"
        Me.studentFingerPrintTemplate.ShadowDecoration.Parent = Me.studentFingerPrintTemplate
        Me.studentFingerPrintTemplate.Size = New System.Drawing.Size(262, 181)
        Me.studentFingerPrintTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentFingerPrintTemplate.TabIndex = 0
        Me.studentFingerPrintTemplate.TabStop = False
        '
        'Guna2GroupBox3
        '
        Me.Guna2GroupBox3.BorderRadius = 4
        Me.Guna2GroupBox3.Controls.Add(Me.studentProfilePic)
        Me.Guna2GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox3.Location = New System.Drawing.Point(466, 221)
        Me.Guna2GroupBox3.Name = "Guna2GroupBox3"
        Me.Guna2GroupBox3.ShadowDecoration.Parent = Me.Guna2GroupBox3
        Me.Guna2GroupBox3.Size = New System.Drawing.Size(275, 271)
        Me.Guna2GroupBox3.TabIndex = 31
        Me.Guna2GroupBox3.Text = "Passport"
        '
        'studentProfilePic
        '
        Me.studentProfilePic.BackgroundImage = Global.WindowsApplication2.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Places_user_identity_128
        Me.studentProfilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.studentProfilePic.BorderRadius = 5
        Me.studentProfilePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentProfilePic.Location = New System.Drawing.Point(22, 49)
        Me.studentProfilePic.Name = "studentProfilePic"
        Me.studentProfilePic.ShadowDecoration.Parent = Me.studentProfilePic
        Me.studentProfilePic.Size = New System.Drawing.Size(232, 207)
        Me.studentProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentProfilePic.TabIndex = 0
        Me.studentProfilePic.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Controls.Add(Me.total_customer_count_label_txt)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(763, 43)
        Me.Guna2Panel2.TabIndex = 34
        '
        'total_customer_count_label_txt
        '
        Me.total_customer_count_label_txt.BackColor = System.Drawing.Color.Transparent
        Me.total_customer_count_label_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_customer_count_label_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.total_customer_count_label_txt.Location = New System.Drawing.Point(709, 13)
        Me.total_customer_count_label_txt.Name = "total_customer_count_label_txt"
        Me.total_customer_count_label_txt.Size = New System.Drawing.Size(11, 17)
        Me.total_customer_count_label_txt.TabIndex = 7
        Me.total_customer_count_label_txt.Text = "0"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(589, 15)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(106, 15)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "TOTAL STUDENT"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(762, 48)
        Me.Guna2Panel1.TabIndex = 33
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(44, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(236, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "REGISTER STUDENT FINGERPRINT"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon4
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
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
        Me.close_btn.Location = New System.Drawing.Point(719, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(392, 110)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(76, 15)
        Me.Guna2HtmlLabel5.TabIndex = 38
        Me.Guna2HtmlLabel5.Text = "Email Address"
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
        Me.emailAddressTxt.Location = New System.Drawing.Point(390, 127)
        Me.emailAddressTxt.Name = "emailAddressTxt"
        Me.emailAddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTxt.PlaceholderText = "EMAIL ADDRESS"
        Me.emailAddressTxt.SelectedText = ""
        Me.emailAddressTxt.ShadowDecoration.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Size = New System.Drawing.Size(351, 36)
        Me.emailAddressTxt.TabIndex = 36
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
        Me.clearBtn.Location = New System.Drawing.Point(626, 171)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.ShadowDecoration.Parent = Me.clearBtn
        Me.clearBtn.Size = New System.Drawing.Size(112, 40)
        Me.clearBtn.TabIndex = 42
        Me.clearBtn.Text = "CLEAR"
        '
        'startEnrollBtn
        '
        Me.startEnrollBtn.BackColor = System.Drawing.SystemColors.Control
        Me.startEnrollBtn.BorderColor = System.Drawing.Color.Transparent
        Me.startEnrollBtn.BorderRadius = 5
        Me.startEnrollBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.startEnrollBtn.CheckedState.Parent = Me.startEnrollBtn
        Me.startEnrollBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.startEnrollBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.startEnrollBtn.CustomImages.Parent = Me.startEnrollBtn
        Me.startEnrollBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startEnrollBtn.ForeColor = System.Drawing.Color.White
        Me.startEnrollBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.startEnrollBtn.HoverState.Parent = Me.startEnrollBtn
        Me.startEnrollBtn.Location = New System.Drawing.Point(22, 171)
        Me.startEnrollBtn.Name = "startEnrollBtn"
        Me.startEnrollBtn.ShadowDecoration.Parent = Me.startEnrollBtn
        Me.startEnrollBtn.Size = New System.Drawing.Size(158, 40)
        Me.startEnrollBtn.TabIndex = 41
        Me.startEnrollBtn.Text = "START ENROLLMENT"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.scanProgressBar)
        Me.Guna2Panel3.Location = New System.Drawing.Point(466, 499)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(275, 62)
        Me.Guna2Panel3.TabIndex = 43
        '
        'scanProgressBar
        '
        Me.scanProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.scanProgressBar.Location = New System.Drawing.Point(21, 9)
        Me.scanProgressBar.Name = "scanProgressBar"
        Me.scanProgressBar.ShadowDecoration.Parent = Me.scanProgressBar
        Me.scanProgressBar.Size = New System.Drawing.Size(233, 45)
        Me.scanProgressBar.TabIndex = 46
        Me.scanProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'selectFingerComboBox
        '
        Me.selectFingerComboBox.BackColor = System.Drawing.Color.Transparent
        Me.selectFingerComboBox.BorderRadius = 5
        Me.selectFingerComboBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectFingerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.selectFingerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectFingerComboBox.FocusedColor = System.Drawing.Color.Empty
        Me.selectFingerComboBox.FocusedState.Parent = Me.selectFingerComboBox
        Me.selectFingerComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectFingerComboBox.ForeColor = System.Drawing.Color.Black
        Me.selectFingerComboBox.FormattingEnabled = True
        Me.selectFingerComboBox.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.selectFingerComboBox.HoverState.Parent = Me.selectFingerComboBox
        Me.selectFingerComboBox.ItemHeight = 30
        Me.selectFingerComboBox.ItemsAppearance.Parent = Me.selectFingerComboBox
        Me.selectFingerComboBox.Location = New System.Drawing.Point(22, 127)
        Me.selectFingerComboBox.Name = "selectFingerComboBox"
        Me.selectFingerComboBox.ShadowDecoration.Parent = Me.selectFingerComboBox
        Me.selectFingerComboBox.Size = New System.Drawing.Size(340, 36)
        Me.selectFingerComboBox.TabIndex = 44
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(24, 110)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(74, 15)
        Me.Guna2HtmlLabel3.TabIndex = 45
        Me.Guna2HtmlLabel3.Text = "Select Fingers"
        '
        'regstudentfingerprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 579)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.selectFingerComboBox)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.startEnrollBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.emailAddressTxt)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox4)
        Me.Controls.Add(Me.Guna2GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "regstudentfingerprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Student Fingerprint"
        Me.TopMost = True
        Me.Guna2GroupBox4.ResumeLayout(False)
        Me.Guna2GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.studentFingerPrintTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox3.ResumeLayout(False)
        CType(Me.studentProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2GroupBox4 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents enrollStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fingerCaptureBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents studentFingerPrintTemplate As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GroupBox3 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents studentProfilePic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents total_customer_count_label_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents emailAddressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents startEnrollBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents scanProgressBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents selectFingerComboBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
