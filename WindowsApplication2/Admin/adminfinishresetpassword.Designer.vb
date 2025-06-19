<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminfinishresetpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminfinishresetpassword))
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.saveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.adminfinishresetpass = New Guna.UI2.WinForms.Guna2Panel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.confirmPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.createPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.otpTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.confirmFinishPasswordToggle = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.finishPasswordToggle = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.adminfinishresetpass.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.confirmFinishPasswordToggle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finishPasswordToggle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.White
        Me.passwordLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.passwordLabel.ForeColor = System.Drawing.Color.Black
        Me.passwordLabel.Location = New System.Drawing.Point(31, 58)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(24, 19)
        Me.passwordLabel.TabIndex = 18
        Me.passwordLabel.Text = "OTP"
        Me.passwordLabel.UseCompatibleTextRendering = True
        '
        'saveBtn
        '
        Me.saveBtn.Animated = True
        Me.saveBtn.BorderRadius = 5
        Me.saveBtn.CheckedState.Parent = Me.saveBtn
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.CustomImages.Parent = Me.saveBtn
        Me.saveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.saveBtn.ForeColor = System.Drawing.Color.White
        Me.saveBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveBtn.HoverState.Parent = Me.saveBtn
        Me.saveBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.saveBtn.Location = New System.Drawing.Point(302, 324)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.ShadowDecoration.Parent = Me.saveBtn
        Me.saveBtn.Size = New System.Drawing.Size(142, 44)
        Me.saveBtn.TabIndex = 13
        Me.saveBtn.Text = "SAVE"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 20)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(193, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Admin Finish Reset Password"
        '
        'adminfinishresetpass
        '
        Me.adminfinishresetpass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adminfinishresetpass.Controls.Add(Me.Guna2HtmlLabel1)
        Me.adminfinishresetpass.Controls.Add(Me.Guna2PictureBox1)
        Me.adminfinishresetpass.Controls.Add(Me.close_btn)
        Me.adminfinishresetpass.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.adminfinishresetpass.Location = New System.Drawing.Point(0, 1)
        Me.adminfinishresetpass.Name = "adminfinishresetpass"
        Me.adminfinishresetpass.ShadowDecoration.Parent = Me.adminfinishresetpass
        Me.adminfinishresetpass.Size = New System.Drawing.Size(498, 44)
        Me.adminfinishresetpass.TabIndex = 7
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
        Me.close_btn.Location = New System.Drawing.Point(456, 3)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 36)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CONFIRM PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "CREATE NEW PASSWORD"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.confirmFinishPasswordToggle)
        Me.Guna2GroupBox1.Controls.Add(Me.finishPasswordToggle)
        Me.Guna2GroupBox1.Controls.Add(Me.confirmPasswordTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.createPasswordTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.otpTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.passwordLabel)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.saveBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(477, 383)
        Me.Guna2GroupBox1.TabIndex = 8
        Me.Guna2GroupBox1.Text = "Admin Login"
        '
        'confirmPasswordTxt
        '
        Me.confirmPasswordTxt.BorderRadius = 5
        Me.confirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmPasswordTxt.DefaultText = ""
        Me.confirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmPasswordTxt.DisabledState.Parent = Me.confirmPasswordTxt
        Me.confirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmPasswordTxt.FocusedState.Parent = Me.confirmPasswordTxt
        Me.confirmPasswordTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.confirmPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.confirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmPasswordTxt.HoverState.Parent = Me.confirmPasswordTxt
        Me.confirmPasswordTxt.Location = New System.Drawing.Point(28, 268)
        Me.confirmPasswordTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.confirmPasswordTxt.Name = "confirmPasswordTxt"
        Me.confirmPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmPasswordTxt.PlaceholderText = "CONFIRM PASSWORD"
        Me.confirmPasswordTxt.SelectedText = ""
        Me.confirmPasswordTxt.ShadowDecoration.Parent = Me.confirmPasswordTxt
        Me.confirmPasswordTxt.Size = New System.Drawing.Size(416, 41)
        Me.confirmPasswordTxt.TabIndex = 21
        Me.confirmPasswordTxt.UseSystemPasswordChar = True
        '
        'createPasswordTxt
        '
        Me.createPasswordTxt.BorderRadius = 5
        Me.createPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.createPasswordTxt.DefaultText = ""
        Me.createPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.createPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.createPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.createPasswordTxt.DisabledState.Parent = Me.createPasswordTxt
        Me.createPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.createPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createPasswordTxt.FocusedState.Parent = Me.createPasswordTxt
        Me.createPasswordTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.createPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.createPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.createPasswordTxt.HoverState.Parent = Me.createPasswordTxt
        Me.createPasswordTxt.Location = New System.Drawing.Point(28, 192)
        Me.createPasswordTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.createPasswordTxt.Name = "createPasswordTxt"
        Me.createPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.createPasswordTxt.PlaceholderText = "ENTER NEW PASSWORD"
        Me.createPasswordTxt.SelectedText = ""
        Me.createPasswordTxt.ShadowDecoration.Parent = Me.createPasswordTxt
        Me.createPasswordTxt.Size = New System.Drawing.Size(416, 41)
        Me.createPasswordTxt.TabIndex = 20
        Me.createPasswordTxt.UseSystemPasswordChar = True
        '
        'otpTxt
        '
        Me.otpTxt.BorderRadius = 5
        Me.otpTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.otpTxt.DefaultText = ""
        Me.otpTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.otpTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.otpTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otpTxt.DisabledState.Parent = Me.otpTxt
        Me.otpTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.otpTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otpTxt.FocusedState.Parent = Me.otpTxt
        Me.otpTxt.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.otpTxt.ForeColor = System.Drawing.Color.Black
        Me.otpTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.otpTxt.HoverState.Parent = Me.otpTxt
        Me.otpTxt.Location = New System.Drawing.Point(28, 116)
        Me.otpTxt.Margin = New System.Windows.Forms.Padding(5)
        Me.otpTxt.Name = "otpTxt"
        Me.otpTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.otpTxt.PlaceholderText = "ENTER OTP"
        Me.otpTxt.SelectedText = ""
        Me.otpTxt.ShadowDecoration.Parent = Me.otpTxt
        Me.otpTxt.Size = New System.Drawing.Size(416, 41)
        Me.otpTxt.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ENTER OTP"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon2
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 39)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'confirmFinishPasswordToggle
        '
        Me.confirmFinishPasswordToggle.BackColor = System.Drawing.Color.White
        Me.confirmFinishPasswordToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmFinishPasswordToggle.Image = Global.WindowsApplication2.My.Resources.Resources.hide
        Me.confirmFinishPasswordToggle.Location = New System.Drawing.Point(405, 276)
        Me.confirmFinishPasswordToggle.Name = "confirmFinishPasswordToggle"
        Me.confirmFinishPasswordToggle.ShadowDecoration.Parent = Me.confirmFinishPasswordToggle
        Me.confirmFinishPasswordToggle.Size = New System.Drawing.Size(26, 26)
        Me.confirmFinishPasswordToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.confirmFinishPasswordToggle.TabIndex = 25
        Me.confirmFinishPasswordToggle.TabStop = False
        '
        'finishPasswordToggle
        '
        Me.finishPasswordToggle.BackColor = System.Drawing.Color.White
        Me.finishPasswordToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.finishPasswordToggle.Image = Global.WindowsApplication2.My.Resources.Resources.hide1
        Me.finishPasswordToggle.Location = New System.Drawing.Point(405, 200)
        Me.finishPasswordToggle.Name = "finishPasswordToggle"
        Me.finishPasswordToggle.ShadowDecoration.Parent = Me.finishPasswordToggle
        Me.finishPasswordToggle.Size = New System.Drawing.Size(26, 26)
        Me.finishPasswordToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.finishPasswordToggle.TabIndex = 24
        Me.finishPasswordToggle.TabStop = False
        '
        'adminfinishresetpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 452)
        Me.Controls.Add(Me.adminfinishresetpass)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adminfinishresetpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminresetpassword"
        Me.adminfinishresetpass.ResumeLayout(False)
        Me.adminfinishresetpass.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.confirmFinishPasswordToggle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finishPasswordToggle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents passwordLabel As System.Windows.Forms.Label
    Friend WithEvents saveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents adminfinishresetpass As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents confirmPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents createPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents otpTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents confirmFinishPasswordToggle As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents finishPasswordToggle As Guna.UI2.WinForms.Guna2PictureBox
End Class
