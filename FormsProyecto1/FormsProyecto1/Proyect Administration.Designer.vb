<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txt_project_name
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
        Me.btnCreateProyect = New System.Windows.Forms.Button()
        Me.lblNameOfProyect = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_budget = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.btnUsersInProyects = New System.Windows.Forms.Button()
        Me.dtp_due_date = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvCurrentProjects = New System.Windows.Forms.DataGridView()
        Me.lblCurrentProjects = New System.Windows.Forms.Label()
        CType(Me.dgvCurrentProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreateProyect
        '
        Me.btnCreateProyect.Location = New System.Drawing.Point(12, 458)
        Me.btnCreateProyect.Name = "btnCreateProyect"
        Me.btnCreateProyect.Size = New System.Drawing.Size(80, 35)
        Me.btnCreateProyect.TabIndex = 0
        Me.btnCreateProyect.Text = "Create Proyect"
        Me.btnCreateProyect.UseVisualStyleBackColor = True
        '
        'lblNameOfProyect
        '
        Me.lblNameOfProyect.AutoSize = True
        Me.lblNameOfProyect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfProyect.Location = New System.Drawing.Point(31, 320)
        Me.lblNameOfProyect.Name = "lblNameOfProyect"
        Me.lblNameOfProyect.Size = New System.Drawing.Size(129, 24)
        Me.lblNameOfProyect.TabIndex = 1
        Me.lblNameOfProyect.Text = "Project Name:"
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBudget.Location = New System.Drawing.Point(85, 379)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(75, 24)
        Me.lblBudget.TabIndex = 2
        Me.lblBudget.Text = "Budget:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(626, 320)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(226, 24)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Allow work during weekends"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(195, 323)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(227, 20)
        Me.txt_name.TabIndex = 4
        '
        'txt_budget
        '
        Me.txt_budget.Location = New System.Drawing.Point(195, 382)
        Me.txt_budget.Name = "txt_budget"
        Me.txt_budget.Size = New System.Drawing.Size(227, 20)
        Me.txt_budget.TabIndex = 5
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(514, 377)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(93, 24)
        Me.lblDueDate.TabIndex = 7
        Me.lblDueDate.Text = "Due Date:"
        '
        'btnUsersInProyects
        '
        Me.btnUsersInProyects.Location = New System.Drawing.Point(415, 458)
        Me.btnUsersInProyects.Name = "btnUsersInProyects"
        Me.btnUsersInProyects.Size = New System.Drawing.Size(80, 35)
        Me.btnUsersInProyects.TabIndex = 8
        Me.btnUsersInProyects.Text = "Add Users to Proyects"
        Me.btnUsersInProyects.UseVisualStyleBackColor = True
        '
        'dtp_due_date
        '
        Me.dtp_due_date.Location = New System.Drawing.Point(626, 381)
        Me.dtp_due_date.Name = "dtp_due_date"
        Me.dtp_due_date.Size = New System.Drawing.Size(227, 20)
        Me.dtp_due_date.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(808, 458)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 35)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvCurrentProjects
        '
        Me.dgvCurrentProjects.AllowUserToAddRows = False
        Me.dgvCurrentProjects.AllowUserToDeleteRows = False
        Me.dgvCurrentProjects.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvCurrentProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCurrentProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCurrentProjects.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCurrentProjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCurrentProjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCurrentProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCurrentProjects.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCurrentProjects.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCurrentProjects.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvCurrentProjects.Location = New System.Drawing.Point(12, 49)
        Me.dgvCurrentProjects.Name = "dgvCurrentProjects"
        Me.dgvCurrentProjects.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCurrentProjects.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCurrentProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvCurrentProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCurrentProjects.Size = New System.Drawing.Size(876, 251)
        Me.dgvCurrentProjects.TabIndex = 12
        '
        'lblCurrentProjects
        '
        Me.lblCurrentProjects.AutoSize = True
        Me.lblCurrentProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCurrentProjects.Location = New System.Drawing.Point(370, 9)
        Me.lblCurrentProjects.Name = "lblCurrentProjects"
        Me.lblCurrentProjects.Size = New System.Drawing.Size(144, 24)
        Me.lblCurrentProjects.TabIndex = 13
        Me.lblCurrentProjects.Text = "Current Projects"
        '
        'txt_project_name
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lblCurrentProjects)
        Me.Controls.Add(Me.dgvCurrentProjects)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dtp_due_date)
        Me.Controls.Add(Me.btnUsersInProyects)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.txt_budget)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.lblNameOfProyect)
        Me.Controls.Add(Me.btnCreateProyect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "txt_project_name"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyect_Administration"
        CType(Me.dgvCurrentProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateProyect As System.Windows.Forms.Button
    Friend WithEvents lblNameOfProyect As System.Windows.Forms.Label
    Friend WithEvents lblBudget As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_budget As System.Windows.Forms.TextBox
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents btnUsersInProyects As System.Windows.Forms.Button
    Friend WithEvents dtp_due_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvCurrentProjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblCurrentProjects As System.Windows.Forms.Label
End Class
