<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setResetPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setResetPassword))
        Me.backBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.emailAddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.proceed_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backBtn
        '
        Me.backBtn.Animated = True
        Me.backBtn.BorderRadius = 5
        Me.backBtn.CheckedState.Parent = Me.backBtn
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.CustomImages.Parent = Me.backBtn
        Me.backBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.backBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.backBtn.HoverState.Parent = Me.backBtn
        Me.backBtn.ImageSize = New System.Drawing.Size(15, 15)
        Me.backBtn.Location = New System.Drawing.Point(9, 132)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.ShadowDecoration.Parent = Me.backBtn
        Me.backBtn.Size = New System.Drawing.Size(106, 37)
        Me.backBtn.TabIndex = 8
        Me.backBtn.Text = "BACK"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.emailAddressTxt)
        Me.Guna2GroupBox1.Controls.Add(Me.proceed_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.backBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(428, 212)
        Me.Guna2GroupBox1.TabIndex = 13
        Me.Guna2GroupBox1.Text = "Admin"
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
        Me.emailAddressTxt.Location = New System.Drawing.Point(9, 74)
        Me.emailAddressTxt.Name = "emailAddressTxt"
        Me.emailAddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailAddressTxt.PlaceholderText = "ENTER EMAIL ADDRESS"
        Me.emailAddressTxt.SelectedText = ""
        Me.emailAddressTxt.ShadowDecoration.Parent = Me.emailAddressTxt
        Me.emailAddressTxt.Size = New System.Drawing.Size(405, 38)
        Me.emailAddressTxt.TabIndex = 10
        '
        'proceed_btn
        '
        Me.proceed_btn.Animated = True
        Me.proceed_btn.BorderRadius = 5
        Me.proceed_btn.CheckedState.Parent = Me.proceed_btn
        Me.proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.proceed_btn.CustomImages.Parent = Me.proceed_btn
        Me.proceed_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.proceed_btn.ForeColor = System.Drawing.Color.White
        Me.proceed_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.proceed_btn.HoverState.Parent = Me.proceed_btn
        Me.proceed_btn.ImageSize = New System.Drawing.Size(15, 15)
        Me.proceed_btn.Location = New System.Drawing.Point(308, 132)
        Me.proceed_btn.Name = "proceed_btn"
        Me.proceed_btn.ShadowDecoration.Parent = Me.proceed_btn
        Me.proceed_btn.Size = New System.Drawing.Size(106, 37)
        Me.proceed_btn.TabIndex = 9
        Me.proceed_btn.Text = "PROCEED"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "EMAIL ADDRESS"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(46, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(106, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Reset Password"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.close_btn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(452, 48)
        Me.Guna2Panel1.TabIndex = 12
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon9
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 3)
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
        Me.close_btn.Location = New System.Drawing.Point(411, 3)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
        '
        'setResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 289)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setResetPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Reset Password"
        Me.TopMost = True
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents backBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents proceed_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents emailAddressTxt As Guna.UI2.WinForms.Guna2TextBox
End Class
