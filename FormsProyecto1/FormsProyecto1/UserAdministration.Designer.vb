<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAdministration
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblUserAdministration = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.comboFilter = New System.Windows.Forms.ComboBox()
        Me.txtFilter = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(876, 357)
        Me.DataGridView1.TabIndex = 0
        '
        'lblUserAdministration
        '
        Me.lblUserAdministration.AutoSize = True
        Me.lblUserAdministration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserAdministration.Location = New System.Drawing.Point(357, 9)
        Me.lblUserAdministration.Name = "lblUserAdministration"
        Me.lblUserAdministration.Size = New System.Drawing.Size(167, 20)
        Me.lblUserAdministration.TabIndex = 31
        Me.lblUserAdministration.Text = "User Administration"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(808, 458)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 35)
        Me.btnBack.TabIndex = 32
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(12, 458)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(80, 35)
        Me.btnCreateUser.TabIndex = 33
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'comboFilter
        '
        Me.comboFilter.FormattingEnabled = True
        Me.comboFilter.Location = New System.Drawing.Point(113, 38)
        Me.comboFilter.Name = "comboFilter"
        Me.comboFilter.Size = New System.Drawing.Size(211, 21)
        Me.comboFilter.TabIndex = 35
        '
        'txtFilter
        '
        Me.txtFilter.AutoSize = True
        Me.txtFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.Location = New System.Drawing.Point(25, 35)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(91, 24)
        Me.txtFilter.TabIndex = 34
        Me.txtFilter.Text = "Filter by : "
        '
        'UserAdministration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.comboFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblUserAdministration)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserAdministration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAdministration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblUserAdministration As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents comboFilter As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilter As System.Windows.Forms.Label
End Class
