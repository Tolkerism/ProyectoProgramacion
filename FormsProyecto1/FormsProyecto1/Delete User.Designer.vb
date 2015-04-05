<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_User
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToUserAdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelectUserToDelete = New System.Windows.Forms.Label()
        Me.cbDeleteUser = New System.Windows.Forms.ComboBox()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToUserAdministrationToolStripMenuItem, Me.ReturnToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReturnToUserAdministrationToolStripMenuItem
        '
        Me.ReturnToUserAdministrationToolStripMenuItem.Name = "ReturnToUserAdministrationToolStripMenuItem"
        Me.ReturnToUserAdministrationToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReturnToUserAdministrationToolStripMenuItem.Text = "Return to User Administration"
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to Main Menu"
        '
        'lblSelectUserToDelete
        '
        Me.lblSelectUserToDelete.AutoSize = True
        Me.lblSelectUserToDelete.Location = New System.Drawing.Point(35, 53)
        Me.lblSelectUserToDelete.Name = "lblSelectUserToDelete"
        Me.lblSelectUserToDelete.Size = New System.Drawing.Size(65, 13)
        Me.lblSelectUserToDelete.TabIndex = 1
        Me.lblSelectUserToDelete.Text = "Select User:"
        '
        'cbDeleteUser
        '
        Me.cbDeleteUser.FormattingEnabled = True
        Me.cbDeleteUser.Location = New System.Drawing.Point(138, 53)
        Me.cbDeleteUser.Name = "cbDeleteUser"
        Me.cbDeleteUser.Size = New System.Drawing.Size(121, 21)
        Me.cbDeleteUser.TabIndex = 2
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(87, 147)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(90, 51)
        Me.btnDeleteUser.TabIndex = 3
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'Delete_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.cbDeleteUser)
        Me.Controls.Add(Me.lblSelectUserToDelete)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Delete_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete_User"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToUserAdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSelectUserToDelete As System.Windows.Forms.Label
    Friend WithEvents cbDeleteUser As System.Windows.Forms.ComboBox
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
End Class
