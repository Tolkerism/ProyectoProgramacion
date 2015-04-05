<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestHolidays
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
        Me.lblHolidayRequestUser = New System.Windows.Forms.Label()
        Me.btnHolidayBack = New System.Windows.Forms.Button()
        Me.btnRequestHolidays = New System.Windows.Forms.Button()
        Me.txtHolidayRequestUser = New System.Windows.Forms.TextBox()
        Me.lblStartDayHolidays = New System.Windows.Forms.Label()
        Me.lblFinishDayHolidays = New System.Windows.Forms.Label()
        Me.lblHolidayAvailable = New System.Windows.Forms.Label()
        Me.txtAvailableDays = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpStartHoliday = New System.Windows.Forms.DateTimePicker()
        Me.dtpFinishHoliday = New System.Windows.Forms.DateTimePicker()
        Me.lblHolidayBank = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHolidayRequestUser
        '
        Me.lblHolidayRequestUser.AutoSize = True
        Me.lblHolidayRequestUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayRequestUser.Location = New System.Drawing.Point(304, 321)
        Me.lblHolidayRequestUser.Name = "lblHolidayRequestUser"
        Me.lblHolidayRequestUser.Size = New System.Drawing.Size(54, 24)
        Me.lblHolidayRequestUser.TabIndex = 0
        Me.lblHolidayRequestUser.Text = "User:"
        '
        'btnHolidayBack
        '
        Me.btnHolidayBack.Location = New System.Drawing.Point(808, 458)
        Me.btnHolidayBack.Name = "btnHolidayBack"
        Me.btnHolidayBack.Size = New System.Drawing.Size(80, 35)
        Me.btnHolidayBack.TabIndex = 1
        Me.btnHolidayBack.Text = "Back"
        Me.btnHolidayBack.UseVisualStyleBackColor = True
        '
        'btnRequestHolidays
        '
        Me.btnRequestHolidays.Location = New System.Drawing.Point(12, 458)
        Me.btnRequestHolidays.Name = "btnRequestHolidays"
        Me.btnRequestHolidays.Size = New System.Drawing.Size(80, 35)
        Me.btnRequestHolidays.TabIndex = 2
        Me.btnRequestHolidays.Text = "Request"
        Me.btnRequestHolidays.UseVisualStyleBackColor = True
        '
        'txtHolidayRequestUser
        '
        Me.txtHolidayRequestUser.Location = New System.Drawing.Point(501, 321)
        Me.txtHolidayRequestUser.Name = "txtHolidayRequestUser"
        Me.txtHolidayRequestUser.Size = New System.Drawing.Size(196, 20)
        Me.txtHolidayRequestUser.TabIndex = 3
        '
        'lblStartDayHolidays
        '
        Me.lblStartDayHolidays.AutoSize = True
        Me.lblStartDayHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDayHolidays.Location = New System.Drawing.Point(262, 123)
        Me.lblStartDayHolidays.Name = "lblStartDayHolidays"
        Me.lblStartDayHolidays.Size = New System.Drawing.Size(51, 24)
        Me.lblStartDayHolidays.TabIndex = 6
        Me.lblStartDayHolidays.Text = "Start:"
        '
        'lblFinishDayHolidays
        '
        Me.lblFinishDayHolidays.AutoSize = True
        Me.lblFinishDayHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinishDayHolidays.Location = New System.Drawing.Point(616, 123)
        Me.lblFinishDayHolidays.Name = "lblFinishDayHolidays"
        Me.lblFinishDayHolidays.Size = New System.Drawing.Size(66, 24)
        Me.lblFinishDayHolidays.TabIndex = 7
        Me.lblFinishDayHolidays.Text = "Finish:"
        '
        'lblHolidayAvailable
        '
        Me.lblHolidayAvailable.AutoSize = True
        Me.lblHolidayAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayAvailable.Location = New System.Drawing.Point(262, 375)
        Me.lblHolidayAvailable.Name = "lblHolidayAvailable"
        Me.lblHolidayAvailable.Size = New System.Drawing.Size(135, 24)
        Me.lblHolidayAvailable.TabIndex = 8
        Me.lblHolidayAvailable.Text = "Available days:"
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.Location = New System.Drawing.Point(501, 379)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.ReadOnly = True
        Me.txtAvailableDays.Size = New System.Drawing.Size(196, 20)
        Me.txtAvailableDays.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(900, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to Main Menu"
        '
        'dtpStartHoliday
        '
        Me.dtpStartHoliday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartHoliday.Location = New System.Drawing.Point(179, 200)
        Me.dtpStartHoliday.Name = "dtpStartHoliday"
        Me.dtpStartHoliday.Size = New System.Drawing.Size(200, 26)
        Me.dtpStartHoliday.TabIndex = 12
        '
        'dtpFinishHoliday
        '
        Me.dtpFinishHoliday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFinishHoliday.Location = New System.Drawing.Point(553, 200)
        Me.dtpFinishHoliday.Name = "dtpFinishHoliday"
        Me.dtpFinishHoliday.Size = New System.Drawing.Size(200, 26)
        Me.dtpFinishHoliday.TabIndex = 13
        '
        'lblHolidayBank
        '
        Me.lblHolidayBank.AutoSize = True
        Me.lblHolidayBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayBank.Location = New System.Drawing.Point(383, 38)
        Me.lblHolidayBank.Name = "lblHolidayBank"
        Me.lblHolidayBank.Size = New System.Drawing.Size(141, 20)
        Me.lblHolidayBank.TabIndex = 14
        Me.lblHolidayBank.Text = "Request Holiday"
        '
        'RequestHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lblHolidayBank)
        Me.Controls.Add(Me.dtpFinishHoliday)
        Me.Controls.Add(Me.dtpStartHoliday)
        Me.Controls.Add(Me.txtAvailableDays)
        Me.Controls.Add(Me.lblHolidayAvailable)
        Me.Controls.Add(Me.lblFinishDayHolidays)
        Me.Controls.Add(Me.lblStartDayHolidays)
        Me.Controls.Add(Me.txtHolidayRequestUser)
        Me.Controls.Add(Me.btnRequestHolidays)
        Me.Controls.Add(Me.btnHolidayBack)
        Me.Controls.Add(Me.lblHolidayRequestUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RequestHolidays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHolidayRequestUser As System.Windows.Forms.Label
    Friend WithEvents btnHolidayBack As System.Windows.Forms.Button
    Friend WithEvents btnRequestHolidays As System.Windows.Forms.Button
    Friend WithEvents txtHolidayRequestUser As System.Windows.Forms.TextBox
    Friend WithEvents lblStartDayHolidays As System.Windows.Forms.Label
    Friend WithEvents lblFinishDayHolidays As System.Windows.Forms.Label
    Friend WithEvents lblHolidayAvailable As System.Windows.Forms.Label
    Friend WithEvents txtAvailableDays As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpStartHoliday As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFinishHoliday As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHolidayBank As System.Windows.Forms.Label
End Class
