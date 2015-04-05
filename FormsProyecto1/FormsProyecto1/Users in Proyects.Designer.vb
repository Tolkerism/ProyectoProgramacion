<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users_in_Proyects
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
        Me.lblProyectSelection = New System.Windows.Forms.Label()
        Me.lblUserInProyectSelection = New System.Windows.Forms.Label()
        Me.btnAddUserToProyect = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToProyectAdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbProyectInProyectSelection = New System.Windows.Forms.ComboBox()
        Me.cbUserInProyectSelection = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProyectSelection
        '
        Me.lblProyectSelection.AutoSize = True
        Me.lblProyectSelection.Location = New System.Drawing.Point(66, 72)
        Me.lblProyectSelection.Name = "lblProyectSelection"
        Me.lblProyectSelection.Size = New System.Drawing.Size(46, 13)
        Me.lblProyectSelection.TabIndex = 0
        Me.lblProyectSelection.Text = "Proyect:"
        '
        'lblUserInProyectSelection
        '
        Me.lblUserInProyectSelection.AutoSize = True
        Me.lblUserInProyectSelection.Location = New System.Drawing.Point(66, 124)
        Me.lblUserInProyectSelection.Name = "lblUserInProyectSelection"
        Me.lblUserInProyectSelection.Size = New System.Drawing.Size(32, 13)
        Me.lblUserInProyectSelection.TabIndex = 1
        Me.lblUserInProyectSelection.Text = "User:"
        '
        'btnAddUserToProyect
        '
        Me.btnAddUserToProyect.Location = New System.Drawing.Point(112, 192)
        Me.btnAddUserToProyect.Name = "btnAddUserToProyect"
        Me.btnAddUserToProyect.Size = New System.Drawing.Size(119, 45)
        Me.btnAddUserToProyect.TabIndex = 2
        Me.btnAddUserToProyect.Text = "Add User to Proyect"
        Me.btnAddUserToProyect.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(345, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToProyectAdministrationToolStripMenuItem, Me.GoToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'GoToProyectAdministrationToolStripMenuItem
        '
        Me.GoToProyectAdministrationToolStripMenuItem.Name = "GoToProyectAdministrationToolStripMenuItem"
        Me.GoToProyectAdministrationToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.GoToProyectAdministrationToolStripMenuItem.Text = "Go to Proyect Administration"
        '
        'GoToMainMenuToolStripMenuItem
        '
        Me.GoToMainMenuToolStripMenuItem.Name = "GoToMainMenuToolStripMenuItem"
        Me.GoToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(228, 22)
        Me.GoToMainMenuToolStripMenuItem.Text = "Go to Main Menu"
        '
        'cbProyectInProyectSelection
        '
        Me.cbProyectInProyectSelection.FormattingEnabled = True
        Me.cbProyectInProyectSelection.Location = New System.Drawing.Point(151, 72)
        Me.cbProyectInProyectSelection.Name = "cbProyectInProyectSelection"
        Me.cbProyectInProyectSelection.Size = New System.Drawing.Size(121, 21)
        Me.cbProyectInProyectSelection.TabIndex = 4
        '
        'cbUserInProyectSelection
        '
        Me.cbUserInProyectSelection.FormattingEnabled = True
        Me.cbUserInProyectSelection.Location = New System.Drawing.Point(151, 124)
        Me.cbUserInProyectSelection.Name = "cbUserInProyectSelection"
        Me.cbUserInProyectSelection.Size = New System.Drawing.Size(121, 21)
        Me.cbUserInProyectSelection.TabIndex = 5
        '
        'Users_in_Proyects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(345, 298)
        Me.Controls.Add(Me.cbUserInProyectSelection)
        Me.Controls.Add(Me.cbProyectInProyectSelection)
        Me.Controls.Add(Me.btnAddUserToProyect)
        Me.Controls.Add(Me.lblUserInProyectSelection)
        Me.Controls.Add(Me.lblProyectSelection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Users_in_Proyects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users_in_Proyects"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProyectSelection As System.Windows.Forms.Label
    Friend WithEvents lblUserInProyectSelection As System.Windows.Forms.Label
    Friend WithEvents btnAddUserToProyect As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToProyectAdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbProyectInProyectSelection As System.Windows.Forms.ComboBox
    Friend WithEvents cbUserInProyectSelection As System.Windows.Forms.ComboBox
End Class
