<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setAttendanceTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(setAttendanceTime))
        Me.saveTimeDateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.close_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.back_btn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.closingTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.resumptionTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'saveTimeDateBtn
        '
        Me.saveTimeDateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.saveTimeDateBtn.BorderColor = System.Drawing.Color.Transparent
        Me.saveTimeDateBtn.BorderRadius = 5
        Me.saveTimeDateBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.saveTimeDateBtn.CheckedState.Parent = Me.saveTimeDateBtn
        Me.saveTimeDateBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveTimeDateBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.saveTimeDateBtn.CustomImages.Parent = Me.saveTimeDateBtn
        Me.saveTimeDateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveTimeDateBtn.ForeColor = System.Drawing.Color.White
        Me.saveTimeDateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saveTimeDateBtn.HoverState.Parent = Me.saveTimeDateBtn
        Me.saveTimeDateBtn.Location = New System.Drawing.Point(17, 180)
        Me.saveTimeDateBtn.Name = "saveTimeDateBtn"
        Me.saveTimeDateBtn.ShadowDecoration.Parent = Me.saveTimeDateBtn
        Me.saveTimeDateBtn.Size = New System.Drawing.Size(120, 46)
        Me.saveTimeDateBtn.TabIndex = 61
        Me.saveTimeDateBtn.Text = "SAVE"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(129, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "SYSTEM SETTINGS"
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
        Me.close_btn.Location = New System.Drawing.Point(418, 4)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.ShadowDecoration.Parent = Me.close_btn
        Me.close_btn.Size = New System.Drawing.Size(36, 40)
        Me.close_btn.TabIndex = 0
        Me.close_btn.Text = "X"
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(457, 48)
        Me.Guna2Panel1.TabIndex = 54
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon8
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.back_btn)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2GroupBox1.Controls.Add(Me.closingTimePicker)
        Me.Guna2GroupBox1.Controls.Add(Me.resumptionTimePicker)
        Me.Guna2GroupBox1.Controls.Add(Me.saveTimeDateBtn)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(28, 64)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(407, 243)
        Me.Guna2GroupBox1.TabIndex = 63
        Me.Guna2GroupBox1.Text = "Attendance Time"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.BorderColor = System.Drawing.Color.Transparent
        Me.back_btn.BorderRadius = 5
        Me.back_btn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.back_btn.CheckedState.Parent = Me.back_btn
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.back_btn.CustomImages.Parent = Me.back_btn
        Me.back_btn.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.HoverState.FillColor = System.Drawing.Color.Maroon
        Me.back_btn.HoverState.Parent = Me.back_btn
        Me.back_btn.Location = New System.Drawing.Point(270, 180)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.ShadowDecoration.Parent = Me.back_btn
        Me.back_btn.Size = New System.Drawing.Size(120, 46)
        Me.back_btn.TabIndex = 67
        Me.back_btn.Text = "BACK"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(17, 126)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(117, 23)
        Me.Guna2HtmlLabel3.TabIndex = 66
        Me.Guna2HtmlLabel3.Text = "CLOSING TIME:"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(13, 66)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(153, 23)
        Me.Guna2HtmlLabel2.TabIndex = 65
        Me.Guna2HtmlLabel2.Text = "RESUMPTION TIME:"
        '
        'closingTimePicker
        '
        Me.closingTimePicker.CheckedState.Parent = Me.closingTimePicker
        Me.closingTimePicker.FillColor = System.Drawing.Color.Silver
        Me.closingTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.closingTimePicker.HoverState.Parent = Me.closingTimePicker
        Me.closingTimePicker.Location = New System.Drawing.Point(176, 117)
        Me.closingTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.closingTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.closingTimePicker.Name = "closingTimePicker"
        Me.closingTimePicker.ShadowDecoration.Parent = Me.closingTimePicker
        Me.closingTimePicker.Size = New System.Drawing.Size(214, 40)
        Me.closingTimePicker.TabIndex = 64
        Me.closingTimePicker.Value = New Date(2025, 6, 14, 13, 28, 13, 765)
        '
        'resumptionTimePicker
        '
        Me.resumptionTimePicker.CheckedState.Parent = Me.resumptionTimePicker
        Me.resumptionTimePicker.FillColor = System.Drawing.Color.Silver
        Me.resumptionTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.resumptionTimePicker.HoverState.Parent = Me.resumptionTimePicker
        Me.resumptionTimePicker.Location = New System.Drawing.Point(176, 54)
        Me.resumptionTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.resumptionTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.resumptionTimePicker.Name = "resumptionTimePicker"
        Me.resumptionTimePicker.ShadowDecoration.Parent = Me.resumptionTimePicker
        Me.resumptionTimePicker.Size = New System.Drawing.Size(214, 40)
        Me.resumptionTimePicker.TabIndex = 63
        Me.resumptionTimePicker.Value = New Date(2025, 6, 14, 13, 28, 13, 765)
        '
        'setAttendanceTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 336)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "setAttendanceTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Attendance Time"
        Me.TopMost = True
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents saveTimeDateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents close_btn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents closingTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents resumptionTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents back_btn As Guna.UI2.WinForms.Guna2Button
End Class
