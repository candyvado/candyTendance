<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminlogin))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.forgotPasswordLabel = New System.Windows.Forms.LinkLabel()
        Me.loginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.emailAddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.loginPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.loginPasswordToggle = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginPasswordToggle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(495, 48)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(83, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Admin Login"
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
        Me.close_btn.Location = New System.Drawing.Point(456, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'forgotPasswordLabel
        '
        Me.forgotPasswordLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.forgotPasswordLabel.AutoSize = True
        Me.forgotPasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.forgotPasswordLabel.LinkColor = System.Drawing.Color.Gray
        Me.forgotPasswordLabel.Location = New System.Drawing.Point(300, 245)
        Me.forgotPasswordLabel.Name = "forgotPasswordLabel"
        Me.forgotPasswordLabel.Size = New System.Drawing.Size(143, 21)
        Me.forgotPasswordLabel.TabIndex = 10
        Me.forgotPasswordLabel.TabStop = True
        Me.forgotPasswordLabel.Text = "Forgot Password?"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.White
        Me.loginBtn.BorderRadius = 5
        Me.loginBtn.CheckedState.Parent = Me.loginBtn
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.CustomImages.Parent = Me.loginBtn
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginBtn.HoverState.Parent = Me.loginBtn
        Me.loginBtn.Location = New System.Drawing.Point(27, 245)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.ShadowDecoration.Parent = Me.loginBtn
        Me.loginBtn.Size = New System.Drawing.Size(121, 40)
        Me.loginBtn.TabIndex = 8
        Me.loginBtn.Text = "LOGIN"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 5
        Me.Guna2GroupBox1.Controls.Add(Me.loginPasswordToggle)
        Me.Guna2GroupBox1.Controls.Add(Me.forgotPasswordLabel)
        Me.Guna2GroupBox1.Controls.Add(Me.loginBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.emailAddressTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.loginPasswordTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(20, 55)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(456, 310)
        Me.Guna2GroupBox1.TabIndex = 4
        Me.Guna2GroupBox1.Text = "Administrative Login"
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
        Me.emailAddressTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.emailAddressTxt.ForeColor = System.Drawing.Color.Black
        Me.emailAddressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.emailAddressTxt.HoverState.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Location = New System.Drawing.Point(27, 78)
        Me.emailAddressTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.emailAddressTxt.Name = "emailAddressTxt"
        Me.emailAddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTxt.PlaceholderText = "ENTER EMAIL ADDRESS"
        Me.emailAddressTxt.SelectedText = ""
        Me.emailAddressTxt.ShadowDecoration.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Size = New System.Drawing.Size(416, 41)
        Me.emailAddressTxt.TabIndex = 7
        '
        'loginPasswordTxt
        '
        Me.loginPasswordTxt.BorderRadius = 5
        Me.loginPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loginPasswordTxt.DefaultText = ""
        Me.loginPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.loginPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.loginPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loginPasswordTxt.DisabledState.Parent = Me.loginPasswordTxt
        Me.loginPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.loginPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginPasswordTxt.FocusedState.Parent = Me.loginPasswordTxt
        Me.loginPasswordTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.loginPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.loginPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginPasswordTxt.HoverState.Parent = Me.loginPasswordTxt
        Me.loginPasswordTxt.Location = New System.Drawing.Point(27, 168)
        Me.loginPasswordTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.loginPasswordTxt.Name = "loginPasswordTxt"
        Me.loginPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.loginPasswordTxt.PlaceholderText = "ENTER PASSWORD"
        Me.loginPasswordTxt.SelectedText = ""
        Me.loginPasswordTxt.ShadowDecoration.Parent = Me.loginPasswordTxt
        Me.loginPasswordTxt.Size = New System.Drawing.Size(416, 41)
        Me.loginPasswordTxt.TabIndex = 6
        Me.loginPasswordTxt.UseSystemPasswordChar = True
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(34, 149)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(70, 17)
        Me.Guna2HtmlLabel3.TabIndex = 4
        Me.Guna2HtmlLabel3.Text = "PASSWORD"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(34, 58)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(95, 17)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "EMAIL ADDRESS"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'loginPasswordToggle
        '
        Me.loginPasswordToggle.BackColor = System.Drawing.Color.White
        Me.loginPasswordToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginPasswordToggle.Image = Global.WindowsApplication2.My.Resources.Resources.eyehide
        Me.loginPasswordToggle.Location = New System.Drawing.Point(405, 176)
        Me.loginPasswordToggle.Name = "loginPasswordToggle"
        Me.loginPasswordToggle.ShadowDecoration.Parent = Me.loginPasswordToggle
        Me.loginPasswordToggle.Size = New System.Drawing.Size(26, 26)
        Me.loginPasswordToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginPasswordToggle.TabIndex = 12
        Me.loginPasswordToggle.TabStop = False
        '
        'adminlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 383)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminlogin"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginPasswordToggle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents forgotPasswordLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents emailAddressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents loginPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents loginPasswordToggle As Guna.UI2.WinForms.Guna2PictureBox
End Class
