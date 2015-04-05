<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time_Registration
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbMultipleEntry = New System.Windows.Forms.CheckBox()
        Me.txtProjectName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.comboProjectName = New System.Windows.Forms.ComboBox()
        Me.projectDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtInputHours = New System.Windows.Forms.TextBox()
        Me.txtReportDescription = New System.Windows.Forms.TextBox()
        Me.txtWorkCategory = New System.Windows.Forms.Label()
        Me.comboCategory = New System.Windows.Forms.ComboBox()
        Me.txtFilter = New System.Windows.Forms.Label()
        Me.comboFilter = New System.Windows.Forms.ComboBox()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.txtWarningHoursInput = New System.Windows.Forms.Label()
        Me.projectDateEndPicker = New System.Windows.Forms.DateTimePicker()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHolidayBank = New System.Windows.Forms.Label()
        Me.dgvEntry = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMultipleEntry
        '
        Me.cbMultipleEntry.AutoSize = True
        Me.cbMultipleEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMultipleEntry.Location = New System.Drawing.Point(388, 284)
        Me.cbMultipleEntry.Name = "cbMultipleEntry"
        Me.cbMultipleEntry.Size = New System.Drawing.Size(155, 24)
        Me.cbMultipleEntry.TabIndex = 8
        Me.cbMultipleEntry.Text = "Multiple Day Entry"
        Me.cbMultipleEntry.UseVisualStyleBackColor = True
        '
        'txtProjectName
        '
        Me.txtProjectName.AutoSize = True
        Me.txtProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectName.Location = New System.Drawing.Point(19, 287)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(129, 24)
        Me.txtProjectName.TabIndex = 12
        Me.txtProjectName.Text = "Project Name:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(19, 325)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 24)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date:"
        '
        'txtHours
        '
        Me.txtHours.AutoSize = True
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(19, 410)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(66, 24)
        Me.txtHours.TabIndex = 14
        Me.txtHours.Text = "Hours:"
        '
        'txtDescription
        '
        Me.txtDescription.AutoSize = True
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(19, 370)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(109, 24)
        Me.txtDescription.TabIndex = 15
        Me.txtDescription.Text = "Description:"
        '
        'comboProjectName
        '
        Me.comboProjectName.FormattingEnabled = True
        Me.comboProjectName.Location = New System.Drawing.Point(161, 287)
        Me.comboProjectName.Name = "comboProjectName"
        Me.comboProjectName.Size = New System.Drawing.Size(200, 21)
        Me.comboProjectName.TabIndex = 16
        '
        'projectDatePicker
        '
        Me.projectDatePicker.Location = New System.Drawing.Point(161, 325)
        Me.projectDatePicker.Name = "projectDatePicker"
        Me.projectDatePicker.Size = New System.Drawing.Size(200, 20)
        Me.projectDatePicker.TabIndex = 17
        '
        'txtInputHours
        '
        Me.txtInputHours.Location = New System.Drawing.Point(161, 410)
        Me.txtInputHours.Name = "txtInputHours"
        Me.txtInputHours.Size = New System.Drawing.Size(200, 20)
        Me.txtInputHours.TabIndex = 18
        '
        'txtReportDescription
        '
        Me.txtReportDescription.Location = New System.Drawing.Point(161, 370)
        Me.txtReportDescription.Name = "txtReportDescription"
        Me.txtReportDescription.Size = New System.Drawing.Size(567, 20)
        Me.txtReportDescription.TabIndex = 19
        '
        'txtWorkCategory
        '
        Me.txtWorkCategory.AutoSize = True
        Me.txtWorkCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWorkCategory.Location = New System.Drawing.Point(372, 406)
        Me.txtWorkCategory.Name = "txtWorkCategory"
        Me.txtWorkCategory.Size = New System.Drawing.Size(144, 24)
        Me.txtWorkCategory.TabIndex = 20
        Me.txtWorkCategory.Text = "Work Category: "
        '
        'comboCategory
        '
        Me.comboCategory.FormattingEnabled = True
        Me.comboCategory.Location = New System.Drawing.Point(528, 406)
        Me.comboCategory.Name = "comboCategory"
        Me.comboCategory.Size = New System.Drawing.Size(200, 21)
        Me.comboCategory.TabIndex = 21
        '
        'txtFilter
        '
        Me.txtFilter.AutoSize = True
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(19, 8)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(91, 24)
        Me.txtFilter.TabIndex = 22
        Me.txtFilter.Text = "Filter by : "
        '
        'comboFilter
        '
        Me.comboFilter.FormattingEnabled = True
        Me.comboFilter.Location = New System.Drawing.Point(109, 11)
        Me.comboFilter.Name = "comboFilter"
        Me.comboFilter.Size = New System.Drawing.Size(211, 21)
        Me.comboFilter.TabIndex = 24
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.Location = New System.Drawing.Point(12, 458)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(80, 35)
        Me.btnAddEntry.TabIndex = 25
        Me.btnAddEntry.Text = "Register Hours"
        Me.btnAddEntry.UseVisualStyleBackColor = True
        '
        'txtWarningHoursInput
        '
        Me.txtWarningHoursInput.AutoSize = True
        Me.txtWarningHoursInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarningHoursInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtWarningHoursInput.Location = New System.Drawing.Point(626, 284)
        Me.txtWarningHoursInput.Name = "txtWarningHoursInput"
        Me.txtWarningHoursInput.Size = New System.Drawing.Size(251, 20)
        Me.txtWarningHoursInput.TabIndex = 26
        Me.txtWarningHoursInput.Text = """Hours"" may only accept numbers!"
        Me.txtWarningHoursInput.Visible = False
        '
        'projectDateEndPicker
        '
        Me.projectDateEndPicker.Location = New System.Drawing.Point(445, 321)
        Me.projectDateEndPicker.Name = "projectDateEndPicker"
        Me.projectDateEndPicker.Size = New System.Drawing.Size(200, 20)
        Me.projectDateEndPicker.TabIndex = 27
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(372, 321)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(55, 24)
        Me.lblEndDate.TabIndex = 28
        Me.lblEndDate.Text = "End :"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(808, 458)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 35)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblHolidayBank
        '
        Me.lblHolidayBank.AutoSize = True
        Me.lblHolidayBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayBank.Location = New System.Drawing.Point(366, 9)
        Me.lblHolidayBank.Name = "lblHolidayBank"
        Me.lblHolidayBank.Size = New System.Drawing.Size(150, 20)
        Me.lblHolidayBank.TabIndex = 30
        Me.lblHolidayBank.Text = "Time Registration"
        '
        'dgvEntry
        '
        Me.dgvEntry.AllowUserToAddRows = False
        Me.dgvEntry.AllowUserToDeleteRows = False
        Me.dgvEntry.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvEntry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEntry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEntry.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEntry.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntry.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEntry.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEntry.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvEntry.Location = New System.Drawing.Point(12, 38)
        Me.dgvEntry.Name = "dgvEntry"
        Me.dgvEntry.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntry.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEntry.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvEntry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntry.Size = New System.Drawing.Size(876, 227)
        Me.dgvEntry.TabIndex = 31
        '
        'Time_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.dgvEntry)
        Me.Controls.Add(Me.lblHolidayBank)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.projectDateEndPicker)
        Me.Controls.Add(Me.txtWarningHoursInput)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Controls.Add(Me.comboFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.comboCategory)
        Me.Controls.Add(Me.txtWorkCategory)
        Me.Controls.Add(Me.txtReportDescription)
        Me.Controls.Add(Me.txtInputHours)
        Me.Controls.Add(Me.projectDatePicker)
        Me.Controls.Add(Me.comboProjectName)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.cbMultipleEntry)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Time_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time_Registration"
        CType(Me.dgvEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbMultipleEntry As System.Windows.Forms.CheckBox
    Friend WithEvents txtProjectName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.Label
    Friend WithEvents comboProjectName As System.Windows.Forms.ComboBox
    Friend WithEvents projectDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInputHours As System.Windows.Forms.TextBox
    Friend WithEvents txtReportDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkCategory As System.Windows.Forms.Label
    Friend WithEvents comboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As System.Windows.Forms.Label
    Friend WithEvents comboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents txtWarningHoursInput As System.Windows.Forms.Label
    Friend WithEvents projectDateEndPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblHolidayBank As System.Windows.Forms.Label
    Friend WithEvents dgvEntry As System.Windows.Forms.DataGridView
End Class
