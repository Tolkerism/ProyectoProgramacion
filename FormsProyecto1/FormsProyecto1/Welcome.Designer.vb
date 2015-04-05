<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblUserNameWelcome = New System.Windows.Forms.Label()
        Me.btnThanks = New System.Windows.Forms.Button()
        Me.btnBadLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(62, 69)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(338, 31)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "¡Welcome to the System!"
        '
        'lblUserNameWelcome
        '
        Me.lblUserNameWelcome.AutoSize = True
        Me.lblUserNameWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNameWelcome.Location = New System.Drawing.Point(149, 141)
        Me.lblUserNameWelcome.Name = "lblUserNameWelcome"
        Me.lblUserNameWelcome.Size = New System.Drawing.Size(172, 20)
        Me.lblUserNameWelcome.TabIndex = 1
        Me.lblUserNameWelcome.Text = "(Nombre de usuario)"
        '
        'btnThanks
        '
        Me.btnThanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThanks.Location = New System.Drawing.Point(198, 199)
        Me.btnThanks.Name = "btnThanks"
        Me.btnThanks.Size = New System.Drawing.Size(75, 23)
        Me.btnThanks.TabIndex = 2
        Me.btnThanks.Text = "¡Thanks!"
        Me.btnThanks.UseVisualStyleBackColor = True
        '
        'btnBadLogin
        '
        Me.btnBadLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBadLogin.Location = New System.Drawing.Point(178, 255)
        Me.btnBadLogin.Name = "btnBadLogin"
        Me.btnBadLogin.Size = New System.Drawing.Size(109, 23)
        Me.btnBadLogin.TabIndex = 3
        Me.btnBadLogin.Text = "That's not me..."
        Me.btnBadLogin.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(469, 313)
        Me.Controls.Add(Me.btnBadLogin)
        Me.Controls.Add(Me.btnThanks)
        Me.Controls.Add(Me.lblUserNameWelcome)
        Me.Controls.Add(Me.lblWelcome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblUserNameWelcome As System.Windows.Forms.Label
    Friend WithEvents btnThanks As System.Windows.Forms.Button
    Friend WithEvents btnBadLogin As System.Windows.Forms.Button
End Class
