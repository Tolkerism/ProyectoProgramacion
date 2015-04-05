<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_User
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
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.cbActiveUser = New System.Windows.Forms.CheckBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserPassword = New System.Windows.Forms.TextBox()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.cbAdmin = New System.Windows.Forms.CheckBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastNameOfNewUser = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblCreateUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(155, 100)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(105, 24)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "UserName:"
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserPassword.Location = New System.Drawing.Point(163, 163)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(97, 24)
        Me.lblUserPassword.TabIndex = 1
        Me.lblUserPassword.Text = "Password:"
        '
        'cbActiveUser
        '
        Me.cbActiveUser.AutoSize = True
        Me.cbActiveUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActiveUser.Location = New System.Drawing.Point(484, 417)
        Me.cbActiveUser.Name = "cbActiveUser"
        Me.cbActiveUser.Size = New System.Drawing.Size(109, 24)
        Me.cbActiveUser.TabIndex = 2
        Me.cbActiveUser.Text = "Active User"
        Me.cbActiveUser.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(311, 105)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(282, 20)
        Me.txtUserName.TabIndex = 4
        '
        'txtUserPassword
        '
        Me.txtUserPassword.Location = New System.Drawing.Point(311, 168)
        Me.txtUserPassword.Multiline = True
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(282, 21)
        Me.txtUserPassword.TabIndex = 5
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(12, 460)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(84, 33)
        Me.btnCreateUser.TabIndex = 6
        Me.btnCreateUser.Text = "Create User"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(154, 230)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(106, 24)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(156, 296)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(104, 24)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(198, 359)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 24)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'cbAdmin
        '
        Me.cbAdmin.AutoSize = True
        Me.cbAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdmin.Location = New System.Drawing.Point(311, 417)
        Me.cbAdmin.Name = "cbAdmin"
        Me.cbAdmin.Size = New System.Drawing.Size(73, 24)
        Me.cbAdmin.TabIndex = 10
        Me.cbAdmin.Text = "Admin"
        Me.cbAdmin.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(311, 235)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(282, 21)
        Me.txtFirstName.TabIndex = 11
        '
        'txtLastNameOfNewUser
        '
        Me.txtLastNameOfNewUser.Location = New System.Drawing.Point(311, 301)
        Me.txtLastNameOfNewUser.Multiline = True
        Me.txtLastNameOfNewUser.Name = "txtLastNameOfNewUser"
        Me.txtLastNameOfNewUser.Size = New System.Drawing.Size(282, 21)
        Me.txtLastNameOfNewUser.TabIndex = 12
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(311, 364)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(282, 21)
        Me.txtEmail.TabIndex = 13
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(804, 460)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 33)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblCreateUser
        '
        Me.lblCreateUser.AutoSize = True
        Me.lblCreateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateUser.Location = New System.Drawing.Point(364, 40)
        Me.lblCreateUser.Name = "lblCreateUser"
        Me.lblCreateUser.Size = New System.Drawing.Size(106, 20)
        Me.lblCreateUser.TabIndex = 15
        Me.lblCreateUser.Text = "Create User"
        '
        'Create_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lblCreateUser)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastNameOfNewUser)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.cbAdmin)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.cbActiveUser)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Create_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create_User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents cbActiveUser As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnCreateUser As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents cbAdmin As System.Windows.Forms.CheckBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNameOfNewUser As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblCreateUser As System.Windows.Forms.Label
End Class
