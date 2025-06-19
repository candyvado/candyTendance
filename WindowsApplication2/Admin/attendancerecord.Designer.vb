<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendanceRecordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(attendanceRecordForm))
        Me.attendanceListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.searchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.attendanceDatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.attendanceSearchTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.closeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.full_name_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.user_record_history = New System.Windows.Forms.ListView()
        Me.refreshBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'attendanceListView
        '
        Me.attendanceListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.attendanceListView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceListView.FullRowSelect = True
        Me.attendanceListView.GridLines = True
        Me.attendanceListView.Location = New System.Drawing.Point(16, 121)
        Me.attendanceListView.Name = "attendanceListView"
        Me.attendanceListView.Size = New System.Drawing.Size(578, 388)
        Me.attendanceListView.TabIndex = 29
        Me.attendanceListView.UseCompatibleStateImageBehavior = False
        Me.attendanceListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "S/N"
        Me.ColumnHeader2.Width = 50
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STUDENT_ID"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FULL NAME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EMAIL ADDRESS"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "GENDER"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "PHONE NUMBER"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "HOME ADDRESS"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PASSPORT"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "COURSE"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "DATE"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CHECK IN"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "CHECK OUT"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Controls.Add(Me.searchBtn)
        Me.Guna2Panel2.Controls.Add(Me.attendanceDatePicker)
        Me.Guna2Panel2.Controls.Add(Me.attendanceSearchTxt)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(610, 53)
        Me.Guna2Panel2.TabIndex = 28
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.Color.Transparent
        Me.searchBtn.BorderColor = System.Drawing.Color.Transparent
        Me.searchBtn.BorderRadius = 5
        Me.searchBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.searchBtn.CheckedState.Parent = Me.searchBtn
        Me.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.searchBtn.CustomImages.Parent = Me.searchBtn
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.Color.White
        Me.searchBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchBtn.HoverState.Parent = Me.searchBtn
        Me.searchBtn.Location = New System.Drawing.Point(477, 7)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.ShadowDecoration.Parent = Me.searchBtn
        Me.searchBtn.Size = New System.Drawing.Size(117, 38)
        Me.searchBtn.TabIndex = 23
        Me.searchBtn.Text = "SEARCH"
        '
        'attendanceDatePicker
        '
        Me.attendanceDatePicker.BorderRadius = 5
        Me.attendanceDatePicker.CheckedState.Parent = Me.attendanceDatePicker
        Me.attendanceDatePicker.FillColor = System.Drawing.Color.White
        Me.attendanceDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.attendanceDatePicker.HoverState.Parent = Me.attendanceDatePicker
        Me.attendanceDatePicker.Location = New System.Drawing.Point(233, 7)
        Me.attendanceDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.attendanceDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.attendanceDatePicker.Name = "attendanceDatePicker"
        Me.attendanceDatePicker.ShadowDecoration.Parent = Me.attendanceDatePicker
        Me.attendanceDatePicker.Size = New System.Drawing.Size(202, 38)
        Me.attendanceDatePicker.TabIndex = 22
        Me.attendanceDatePicker.Value = New Date(2025, 6, 14, 10, 35, 33, 497)
        '
        'attendanceSearchTxt
        '
        Me.attendanceSearchTxt.BorderRadius = 5
        Me.attendanceSearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.attendanceSearchTxt.DefaultText = ""
        Me.attendanceSearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.attendanceSearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.attendanceSearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.attendanceSearchTxt.DisabledState.Parent = Me.attendanceSearchTxt
        Me.attendanceSearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.attendanceSearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSearchTxt.FocusedState.Parent = Me.attendanceSearchTxt
        Me.attendanceSearchTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.attendanceSearchTxt.ForeColor = System.Drawing.Color.Black
        Me.attendanceSearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.attendanceSearchTxt.HoverState.Parent = Me.attendanceSearchTxt
        Me.attendanceSearchTxt.Location = New System.Drawing.Point(15, 7)
        Me.attendanceSearchTxt.Name = "attendanceSearchTxt"
        Me.attendanceSearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.attendanceSearchTxt.PlaceholderText = "Type Full Name"
        Me.attendanceSearchTxt.SelectedText = ""
        Me.attendanceSearchTxt.ShadowDecoration.Parent = Me.attendanceSearchTxt
        Me.attendanceSearchTxt.Size = New System.Drawing.Size(202, 38)
        Me.attendanceSearchTxt.TabIndex = 21
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(44, 16)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(124, 17)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Attendance Record"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.closeBtn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(610, 48)
        Me.Guna2Panel1.TabIndex = 27
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.Image = Global.WindowsApplication2.My.Resources.Resources.icon5
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(38, 43)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
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
        Me.closeBtn.Location = New System.Drawing.Point(571, 4)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.ShadowDecoration.Parent = Me.closeBtn
        Me.closeBtn.Size = New System.Drawing.Size(36, 40)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        '
        'full_name_txt
        '
        Me.full_name_txt.BorderRadius = 5
        Me.full_name_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.full_name_txt.DefaultText = ""
        Me.full_name_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.full_name_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.full_name_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.DisabledState.Parent = Me.full_name_txt
        Me.full_name_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.full_name_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.FocusedState.Parent = Me.full_name_txt
        Me.full_name_txt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_name_txt.ForeColor = System.Drawing.Color.Black
        Me.full_name_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.full_name_txt.HoverState.Parent = Me.full_name_txt
        Me.full_name_txt.Location = New System.Drawing.Point(15, 7)
        Me.full_name_txt.Name = "full_name_txt"
        Me.full_name_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.full_name_txt.PlaceholderText = "Type Full Name"
        Me.full_name_txt.SelectedText = ""
        Me.full_name_txt.ShadowDecoration.Parent = Me.full_name_txt
        Me.full_name_txt.Size = New System.Drawing.Size(202, 38)
        Me.full_name_txt.TabIndex = 21
        '
        'user_record_history
        '
        Me.user_record_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_record_history.FullRowSelect = True
        Me.user_record_history.GridLines = True
        Me.user_record_history.Location = New System.Drawing.Point(16, 121)
        Me.user_record_history.Name = "user_record_history"
        Me.user_record_history.Size = New System.Drawing.Size(578, 433)
        Me.user_record_history.TabIndex = 29
        Me.user_record_history.UseCompatibleStateImageBehavior = False
        Me.user_record_history.View = System.Windows.Forms.View.Details
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.refreshBtn.BorderColor = System.Drawing.Color.Transparent
        Me.refreshBtn.BorderRadius = 5
        Me.refreshBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.refreshBtn.CheckedState.Parent = Me.refreshBtn
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.CustomBorderColor = System.Drawing.Color.Transparent
        Me.refreshBtn.CustomImages.Parent = Me.refreshBtn
        Me.refreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.White
        Me.refreshBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.refreshBtn.HoverState.Parent = Me.refreshBtn
        Me.refreshBtn.Location = New System.Drawing.Point(15, 518)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.ShadowDecoration.Parent = Me.refreshBtn
        Me.refreshBtn.Size = New System.Drawing.Size(117, 38)
        Me.refreshBtn.TabIndex = 24
        Me.refreshBtn.Text = "REFRESH"
        '
        'attendanceRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 569)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.attendanceListView)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "attendanceRecordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Record"
        Me.TopMost = True
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents attendanceListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents attendanceDatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents attendanceSearchTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents searchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents full_name_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents user_record_history As System.Windows.Forms.ListView
    Friend WithEvents refreshBtn As Guna.UI2.WinForms.Guna2Button
End Class
