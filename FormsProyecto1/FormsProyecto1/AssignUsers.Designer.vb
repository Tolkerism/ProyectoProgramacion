<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignUsers
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
        Me.comboProject = New System.Windows.Forms.ComboBox()
        Me.txt_project = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.Label()
        Me.comboUser = New System.Windows.Forms.ComboBox()
        Me.btn_assign = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lblCurrentActiveUsers = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboProject
        '
        Me.comboProject.FormattingEnabled = True
        Me.comboProject.Location = New System.Drawing.Point(128, 330)
        Me.comboProject.Name = "comboProject"
        Me.comboProject.Size = New System.Drawing.Size(179, 21)
        Me.comboProject.TabIndex = 0
        '
        'txt_project
        '
        Me.txt_project.AutoSize = True
        Me.txt_project.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_project.Location = New System.Drawing.Point(49, 327)
        Me.txt_project.Name = "txt_project"
        Me.txt_project.Size = New System.Drawing.Size(73, 24)
        Me.txt_project.TabIndex = 1
        Me.txt_project.Text = "Project:"
        '
        'txt_user
        '
        Me.txt_user.AutoSize = True
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_user.Location = New System.Drawing.Point(346, 327)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(54, 24)
        Me.txt_user.TabIndex = 2
        Me.txt_user.Text = "User:"
        '
        'comboUser
        '
        Me.comboUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.comboUser.FormattingEnabled = True
        Me.comboUser.Location = New System.Drawing.Point(406, 330)
        Me.comboUser.Name = "comboUser"
        Me.comboUser.Size = New System.Drawing.Size(179, 24)
        Me.comboUser.Sorted = True
        Me.comboUser.TabIndex = 3
        '
        'btn_assign
        '
        Me.btn_assign.Location = New System.Drawing.Point(12, 459)
        Me.btn_assign.Name = "btn_assign"
        Me.btn_assign.Size = New System.Drawing.Size(83, 34)
        Me.btn_assign.TabIndex = 4
        Me.btn_assign.Text = "Assign"
        Me.btn_assign.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(439, 459)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(83, 34)
        Me.btn_remove.TabIndex = 5
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(805, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 34)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv.Location = New System.Drawing.Point(12, 32)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(876, 273)
        Me.dgv.TabIndex = 7
        '
        'lblCurrentActiveUsers
        '
        Me.lblCurrentActiveUsers.AutoSize = True
        Me.lblCurrentActiveUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentActiveUsers.Location = New System.Drawing.Point(388, 9)
        Me.lblCurrentActiveUsers.Name = "lblCurrentActiveUsers"
        Me.lblCurrentActiveUsers.Size = New System.Drawing.Size(175, 20)
        Me.lblCurrentActiveUsers.TabIndex = 8
        Me.lblCurrentActiveUsers.Text = "Current Active Users"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(615, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hours:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(687, 330)
        Me.txtHours.Multiline = True
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(179, 22)
        Me.txtHours.TabIndex = 10
        '
        'AssignUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentActiveUsers)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.btn_assign)
        Me.Controls.Add(Me.comboUser)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.txt_project)
        Me.Controls.Add(Me.comboProject)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AssignUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AssignUsers"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboProject As System.Windows.Forms.ComboBox
    Friend WithEvents txt_project As System.Windows.Forms.Label
    Friend WithEvents txt_user As System.Windows.Forms.Label
    Friend WithEvents comboUser As System.Windows.Forms.ComboBox
    Friend WithEvents btn_assign As System.Windows.Forms.Button
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents lblCurrentActiveUsers As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
End Class
