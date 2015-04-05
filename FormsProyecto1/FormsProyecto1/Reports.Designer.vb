<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnGenerateReportPDF = New System.Windows.Forms.Button()
        Me.mcStartReport = New System.Windows.Forms.MonthCalendar()
        Me.mcFinishReport = New System.Windows.Forms.MonthCalendar()
        Me.chMultiDay = New System.Windows.Forms.CheckBox()
        Me.btnGenerateReportExcel = New System.Windows.Forms.Button()
        Me.lblSelectedUserReport = New System.Windows.Forms.Label()
        Me.cbSelectedUserReports = New System.Windows.Forms.ComboBox()
        Me.lblSelectedProyect = New System.Windows.Forms.Label()
        Me.cbSelectedProyectReport = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(566, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'btnGenerateReportPDF
        '
        Me.btnGenerateReportPDF.Location = New System.Drawing.Point(97, 326)
        Me.btnGenerateReportPDF.Name = "btnGenerateReportPDF"
        Me.btnGenerateReportPDF.Size = New System.Drawing.Size(149, 48)
        Me.btnGenerateReportPDF.TabIndex = 1
        Me.btnGenerateReportPDF.Text = "Generate Report PDF"
        Me.btnGenerateReportPDF.UseVisualStyleBackColor = True
        '
        'mcStartReport
        '
        Me.mcStartReport.Location = New System.Drawing.Point(59, 137)
        Me.mcStartReport.Name = "mcStartReport"
        Me.mcStartReport.TabIndex = 2
        '
        'mcFinishReport
        '
        Me.mcFinishReport.Location = New System.Drawing.Point(304, 137)
        Me.mcFinishReport.Name = "mcFinishReport"
        Me.mcFinishReport.TabIndex = 3
        '
        'chMultiDay
        '
        Me.chMultiDay.AutoSize = True
        Me.chMultiDay.Location = New System.Drawing.Point(353, 96)
        Me.chMultiDay.Name = "chMultiDay"
        Me.chMultiDay.Size = New System.Drawing.Size(89, 17)
        Me.chMultiDay.TabIndex = 4
        Me.chMultiDay.Text = "Multiple Days"
        Me.chMultiDay.UseVisualStyleBackColor = True
        '
        'btnGenerateReportExcel
        '
        Me.btnGenerateReportExcel.Location = New System.Drawing.Point(344, 326)
        Me.btnGenerateReportExcel.Name = "btnGenerateReportExcel"
        Me.btnGenerateReportExcel.Size = New System.Drawing.Size(149, 48)
        Me.btnGenerateReportExcel.TabIndex = 5
        Me.btnGenerateReportExcel.Text = "Generate Report Excel"
        Me.btnGenerateReportExcel.UseVisualStyleBackColor = True
        '
        'lblSelectedUserReport
        '
        Me.lblSelectedUserReport.AutoSize = True
        Me.lblSelectedUserReport.Location = New System.Drawing.Point(56, 60)
        Me.lblSelectedUserReport.Name = "lblSelectedUserReport"
        Me.lblSelectedUserReport.Size = New System.Drawing.Size(32, 13)
        Me.lblSelectedUserReport.TabIndex = 6
        Me.lblSelectedUserReport.Text = "User:"
        '
        'cbSelectedUserReports
        '
        Me.cbSelectedUserReports.FormattingEnabled = True
        Me.cbSelectedUserReports.Location = New System.Drawing.Point(97, 57)
        Me.cbSelectedUserReports.Name = "cbSelectedUserReports"
        Me.cbSelectedUserReports.Size = New System.Drawing.Size(189, 21)
        Me.cbSelectedUserReports.TabIndex = 7
        '
        'lblSelectedProyect
        '
        Me.lblSelectedProyect.AutoSize = True
        Me.lblSelectedProyect.Location = New System.Drawing.Point(301, 57)
        Me.lblSelectedProyect.Name = "lblSelectedProyect"
        Me.lblSelectedProyect.Size = New System.Drawing.Size(46, 13)
        Me.lblSelectedProyect.TabIndex = 8
        Me.lblSelectedProyect.Text = "Proyect:"
        '
        'cbSelectedProyectReport
        '
        Me.cbSelectedProyectReport.FormattingEnabled = True
        Me.cbSelectedProyectReport.Location = New System.Drawing.Point(353, 54)
        Me.cbSelectedProyectReport.Name = "cbSelectedProyectReport"
        Me.cbSelectedProyectReport.Size = New System.Drawing.Size(178, 21)
        Me.cbSelectedProyectReport.TabIndex = 9
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(566, 422)
        Me.Controls.Add(Me.cbSelectedProyectReport)
        Me.Controls.Add(Me.lblSelectedProyect)
        Me.Controls.Add(Me.cbSelectedUserReports)
        Me.Controls.Add(Me.lblSelectedUserReport)
        Me.Controls.Add(Me.btnGenerateReportExcel)
        Me.Controls.Add(Me.chMultiDay)
        Me.Controls.Add(Me.mcFinishReport)
        Me.Controls.Add(Me.mcStartReport)
        Me.Controls.Add(Me.btnGenerateReportPDF)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnGenerateReportPDF As System.Windows.Forms.Button
    Friend WithEvents mcStartReport As System.Windows.Forms.MonthCalendar
    Friend WithEvents mcFinishReport As System.Windows.Forms.MonthCalendar
    Friend WithEvents chMultiDay As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerateReportExcel As System.Windows.Forms.Button
    Friend WithEvents lblSelectedUserReport As System.Windows.Forms.Label
    Friend WithEvents cbSelectedUserReports As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectedProyect As System.Windows.Forms.Label
    Friend WithEvents cbSelectedProyectReport As System.Windows.Forms.ComboBox
End Class
