<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankHoliday
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
        Me.cbxBankUser = New System.Windows.Forms.ComboBox()
        Me.lblBankUser = New System.Windows.Forms.Label()
        Me.lblBankHoliday = New System.Windows.Forms.Label()
        Me.txtBankHoliday = New System.Windows.Forms.TextBox()
        Me.btnBankBack = New System.Windows.Forms.Button()
        Me.btnBankMessage = New System.Windows.Forms.Button()
        Me.lblHolidayBank = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbxBankUser
        '
        Me.cbxBankUser.FormattingEnabled = True
        Me.cbxBankUser.Location = New System.Drawing.Point(353, 126)
        Me.cbxBankUser.Name = "cbxBankUser"
        Me.cbxBankUser.Size = New System.Drawing.Size(282, 21)
        Me.cbxBankUser.TabIndex = 0
        '
        'lblBankUser
        '
        Me.lblBankUser.AutoSize = True
        Me.lblBankUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankUser.Location = New System.Drawing.Point(211, 121)
        Me.lblBankUser.Name = "lblBankUser"
        Me.lblBankUser.Size = New System.Drawing.Size(54, 24)
        Me.lblBankUser.TabIndex = 1
        Me.lblBankUser.Text = "User:"
        '
        'lblBankHoliday
        '
        Me.lblBankHoliday.AutoSize = True
        Me.lblBankHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBankHoliday.Location = New System.Drawing.Point(178, 279)
        Me.lblBankHoliday.Name = "lblBankHoliday"
        Me.lblBankHoliday.Size = New System.Drawing.Size(87, 24)
        Me.lblBankHoliday.TabIndex = 2
        Me.lblBankHoliday.Text = "Holidays:"
        '
        'txtBankHoliday
        '
        Me.txtBankHoliday.Location = New System.Drawing.Point(353, 284)
        Me.txtBankHoliday.Multiline = True
        Me.txtBankHoliday.Name = "txtBankHoliday"
        Me.txtBankHoliday.ReadOnly = True
        Me.txtBankHoliday.Size = New System.Drawing.Size(282, 21)
        Me.txtBankHoliday.TabIndex = 3
        '
        'btnBankBack
        '
        Me.btnBankBack.Location = New System.Drawing.Point(804, 460)
        Me.btnBankBack.Name = "btnBankBack"
        Me.btnBankBack.Size = New System.Drawing.Size(84, 33)
        Me.btnBankBack.TabIndex = 4
        Me.btnBankBack.Text = "Back"
        Me.btnBankBack.UseVisualStyleBackColor = True
        '
        'btnBankMessage
        '
        Me.btnBankMessage.Location = New System.Drawing.Point(12, 460)
        Me.btnBankMessage.Name = "btnBankMessage"
        Me.btnBankMessage.Size = New System.Drawing.Size(98, 33)
        Me.btnBankMessage.TabIndex = 5
        Me.btnBankMessage.Text = "Send Message"
        Me.btnBankMessage.UseVisualStyleBackColor = True
        '
        'lblHolidayBank
        '
        Me.lblHolidayBank.AutoSize = True
        Me.lblHolidayBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayBank.Location = New System.Drawing.Point(388, 29)
        Me.lblHolidayBank.Name = "lblHolidayBank"
        Me.lblHolidayBank.Size = New System.Drawing.Size(106, 20)
        Me.lblHolidayBank.TabIndex = 6
        Me.lblHolidayBank.Text = "Bankholiday"
        '
        'BankHoliday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lblHolidayBank)
        Me.Controls.Add(Me.btnBankMessage)
        Me.Controls.Add(Me.btnBankBack)
        Me.Controls.Add(Me.txtBankHoliday)
        Me.Controls.Add(Me.lblBankHoliday)
        Me.Controls.Add(Me.lblBankUser)
        Me.Controls.Add(Me.cbxBankUser)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BankHoliday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holiday Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxBankUser As System.Windows.Forms.ComboBox
    Friend WithEvents lblBankUser As System.Windows.Forms.Label
    Friend WithEvents lblBankHoliday As System.Windows.Forms.Label
    Friend WithEvents txtBankHoliday As System.Windows.Forms.TextBox
    Friend WithEvents btnBankBack As System.Windows.Forms.Button
    Friend WithEvents btnBankMessage As System.Windows.Forms.Button
    Friend WithEvents lblHolidayBank As System.Windows.Forms.Label

End Class
