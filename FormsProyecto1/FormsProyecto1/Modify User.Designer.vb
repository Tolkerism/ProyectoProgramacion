<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify_User
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
        Me.cbSelectUser = New System.Windows.Forms.ComboBox()
        Me.lblUserSelection = New System.Windows.Forms.Label()
        Me.lblModifyUsername = New System.Windows.Forms.Label()
        Me.lblModifyUserPassword = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.txtModifyUserName = New System.Windows.Forms.TextBox()
        Me.txtModifyUserPassword = New System.Windows.Forms.TextBox()
        Me.lblModifyFirstName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModifyFirstName = New System.Windows.Forms.TextBox()
        Me.txtModifyLastName = New System.Windows.Forms.TextBox()
        Me.cbUserRol = New System.Windows.Forms.ComboBox()
        Me.txtUserRol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbSelectUser
        '
        Me.cbSelectUser.FormattingEnabled = True
        Me.cbSelectUser.Location = New System.Drawing.Point(157, 37)
        Me.cbSelectUser.Name = "cbSelectUser"
        Me.cbSelectUser.Size = New System.Drawing.Size(121, 21)
        Me.cbSelectUser.TabIndex = 0
        '
        'lblUserSelection
        '
        Me.lblUserSelection.AutoSize = True
        Me.lblUserSelection.Location = New System.Drawing.Point(48, 40)
        Me.lblUserSelection.Name = "lblUserSelection"
        Me.lblUserSelection.Size = New System.Drawing.Size(65, 13)
        Me.lblUserSelection.TabIndex = 1
        Me.lblUserSelection.Text = "Select User:"
        '
        'lblModifyUsername
        '
        Me.lblModifyUsername.AutoSize = True
        Me.lblModifyUsername.Location = New System.Drawing.Point(48, 83)
        Me.lblModifyUsername.Name = "lblModifyUsername"
        Me.lblModifyUsername.Size = New System.Drawing.Size(60, 13)
        Me.lblModifyUsername.TabIndex = 3
        Me.lblModifyUsername.Text = "UserName:"
        '
        'lblModifyUserPassword
        '
        Me.lblModifyUserPassword.AutoSize = True
        Me.lblModifyUserPassword.Location = New System.Drawing.Point(48, 122)
        Me.lblModifyUserPassword.Name = "lblModifyUserPassword"
        Me.lblModifyUserPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblModifyUserPassword.TabIndex = 4
        Me.lblModifyUserPassword.Text = "Password:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(112, 285)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(114, 23)
        Me.btnSaveChanges.TabIndex = 5
        Me.btnSaveChanges.Text = "Save changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'txtModifyUserName
        '
        Me.txtModifyUserName.Location = New System.Drawing.Point(157, 80)
        Me.txtModifyUserName.Name = "txtModifyUserName"
        Me.txtModifyUserName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyUserName.TabIndex = 6
        '
        'txtModifyUserPassword
        '
        Me.txtModifyUserPassword.Location = New System.Drawing.Point(157, 119)
        Me.txtModifyUserPassword.Name = "txtModifyUserPassword"
        Me.txtModifyUserPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyUserPassword.TabIndex = 7
        '
        'lblModifyFirstName
        '
        Me.lblModifyFirstName.AutoSize = True
        Me.lblModifyFirstName.Location = New System.Drawing.Point(48, 160)
        Me.lblModifyFirstName.Name = "lblModifyFirstName"
        Me.lblModifyFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblModifyFirstName.TabIndex = 9
        Me.lblModifyFirstName.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Last Name:"
        '
        'txtModifyFirstName
        '
        Me.txtModifyFirstName.Location = New System.Drawing.Point(157, 157)
        Me.txtModifyFirstName.Name = "txtModifyFirstName"
        Me.txtModifyFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyFirstName.TabIndex = 11
        '
        'txtModifyLastName
        '
        Me.txtModifyLastName.Location = New System.Drawing.Point(157, 195)
        Me.txtModifyLastName.Name = "txtModifyLastName"
        Me.txtModifyLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyLastName.TabIndex = 12
        '
        'cbUserRol
        '
        Me.cbUserRol.FormattingEnabled = True
        Me.cbUserRol.Location = New System.Drawing.Point(157, 232)
        Me.cbUserRol.Name = "cbUserRol"
        Me.cbUserRol.Size = New System.Drawing.Size(121, 21)
        Me.cbUserRol.TabIndex = 13
        '
        'txtUserRol
        '
        Me.txtUserRol.AutoSize = True
        Me.txtUserRol.Location = New System.Drawing.Point(48, 235)
        Me.txtUserRol.Name = "txtUserRol"
        Me.txtUserRol.Size = New System.Drawing.Size(51, 13)
        Me.txtUserRol.TabIndex = 14
        Me.txtUserRol.Text = "User Rol:"
        '
        'Modify_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(340, 337)
        Me.Controls.Add(Me.txtUserRol)
        Me.Controls.Add(Me.cbUserRol)
        Me.Controls.Add(Me.txtModifyLastName)
        Me.Controls.Add(Me.txtModifyFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblModifyFirstName)
        Me.Controls.Add(Me.txtModifyUserPassword)
        Me.Controls.Add(Me.txtModifyUserName)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lblModifyUserPassword)
        Me.Controls.Add(Me.lblModifyUsername)
        Me.Controls.Add(Me.lblUserSelection)
        Me.Controls.Add(Me.cbSelectUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modify_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify_User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSelectUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserSelection As System.Windows.Forms.Label
    Friend WithEvents lblModifyUsername As System.Windows.Forms.Label
    Friend WithEvents lblModifyUserPassword As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents txtModifyUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtModifyUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblModifyFirstName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModifyFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtModifyLastName As System.Windows.Forms.TextBox
    Friend WithEvents cbUserRol As System.Windows.Forms.ComboBox
    Friend WithEvents txtUserRol As System.Windows.Forms.Label
End Class
