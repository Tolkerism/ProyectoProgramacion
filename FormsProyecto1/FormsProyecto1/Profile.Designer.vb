<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.btnUserProfileBack = New System.Windows.Forms.Button()
        Me.lblEnterpriseCharge = New System.Windows.Forms.Label()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.lblCurrentProjects = New System.Windows.Forms.Label()
        Me.dgvCurrentProjects = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCurrentProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(395, 317)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 16)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "UserName"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(395, 414)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(71, 16)
        Me.lblUserEmail.TabIndex = 1
        Me.lblUserEmail.Text = "UserEmail"
        Me.lblUserEmail.Visible = False
        '
        'btnUserProfileBack
        '
        Me.btnUserProfileBack.Location = New System.Drawing.Point(805, 459)
        Me.btnUserProfileBack.Name = "btnUserProfileBack"
        Me.btnUserProfileBack.Size = New System.Drawing.Size(83, 34)
        Me.btnUserProfileBack.TabIndex = 2
        Me.btnUserProfileBack.Text = "Back"
        Me.btnUserProfileBack.UseVisualStyleBackColor = True
        '
        'lblEnterpriseCharge
        '
        Me.lblEnterpriseCharge.AutoSize = True
        Me.lblEnterpriseCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterpriseCharge.Location = New System.Drawing.Point(378, 365)
        Me.lblEnterpriseCharge.Name = "lblEnterpriseCharge"
        Me.lblEnterpriseCharge.Size = New System.Drawing.Size(113, 16)
        Me.lblEnterpriseCharge.TabIndex = 5
        Me.lblEnterpriseCharge.Text = "EnterpriseCharge"
        Me.lblEnterpriseCharge.Visible = False
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Location = New System.Drawing.Point(12, 459)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(126, 34)
        Me.btnSendMessage.TabIndex = 6
        Me.btnSendMessage.Text = "Send a message"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'lblCurrentProjects
        '
        Me.lblCurrentProjects.AutoSize = True
        Me.lblCurrentProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblCurrentProjects.Location = New System.Drawing.Point(377, 32)
        Me.lblCurrentProjects.Name = "lblCurrentProjects"
        Me.lblCurrentProjects.Size = New System.Drawing.Size(144, 24)
        Me.lblCurrentProjects.TabIndex = 8
        Me.lblCurrentProjects.Text = "Current Projects"
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
        Me.dgvCurrentProjects.Location = New System.Drawing.Point(0, 59)
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
        Me.dgvCurrentProjects.Size = New System.Drawing.Size(876, 227)
        Me.dgvCurrentProjects.TabIndex = 9
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.dgvCurrentProjects)
        Me.Controls.Add(Me.lblCurrentProjects)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.lblEnterpriseCharge)
        Me.Controls.Add(Me.btnUserProfileBack)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.dgvCurrentProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents btnUserProfileBack As System.Windows.Forms.Button
    Friend WithEvents lblEnterpriseCharge As System.Windows.Forms.Label
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents lblCurrentProjects As System.Windows.Forms.Label
    Friend WithEvents dgvCurrentProjects As System.Windows.Forms.DataGridView
End Class
