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
        Me.btnGenerateReportPDF = New System.Windows.Forms.Button()
        Me.mcStartReport = New System.Windows.Forms.MonthCalendar()
        Me.mcFinishReport = New System.Windows.Forms.MonthCalendar()
        Me.chMultiDay = New System.Windows.Forms.CheckBox()
        Me.btnGenerateReportExcel = New System.Windows.Forms.Button()
        Me.lblSelectedUserReport = New System.Windows.Forms.Label()
        Me.cbSelectedUserReports = New System.Windows.Forms.ComboBox()
        Me.lblSelectedProyect = New System.Windows.Forms.Label()
        Me.cbSelectedProyectReport = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerateReportPDF
        '
        Me.btnGenerateReportPDF.Location = New System.Drawing.Point(12, 458)
        Me.btnGenerateReportPDF.Name = "btnGenerateReportPDF"
        Me.btnGenerateReportPDF.Size = New System.Drawing.Size(80, 35)
        Me.btnGenerateReportPDF.TabIndex = 1
        Me.btnGenerateReportPDF.Text = "Generate Report PDF"
        Me.btnGenerateReportPDF.UseVisualStyleBackColor = True
        '
        'mcStartReport
        '
        Me.mcStartReport.Location = New System.Drawing.Point(161, 199)
        Me.mcStartReport.Name = "mcStartReport"
        Me.mcStartReport.TabIndex = 2
        '
        'mcFinishReport
        '
        Me.mcFinishReport.Location = New System.Drawing.Point(534, 199)
        Me.mcFinishReport.Name = "mcFinishReport"
        Me.mcFinishReport.TabIndex = 3
        '
        'chMultiDay
        '
        Me.chMultiDay.AutoSize = True
        Me.chMultiDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMultiDay.Location = New System.Drawing.Point(400, 199)
        Me.chMultiDay.Name = "chMultiDay"
        Me.chMultiDay.Size = New System.Drawing.Size(122, 24)
        Me.chMultiDay.TabIndex = 4
        Me.chMultiDay.Text = "Multiple Days"
        Me.chMultiDay.UseVisualStyleBackColor = True
        '
        'btnGenerateReportExcel
        '
        Me.btnGenerateReportExcel.Location = New System.Drawing.Point(400, 458)
        Me.btnGenerateReportExcel.Name = "btnGenerateReportExcel"
        Me.btnGenerateReportExcel.Size = New System.Drawing.Size(80, 35)
        Me.btnGenerateReportExcel.TabIndex = 5
        Me.btnGenerateReportExcel.Text = "Generate Report Excel"
        Me.btnGenerateReportExcel.UseVisualStyleBackColor = True
        '
        'lblSelectedUserReport
        '
        Me.lblSelectedUserReport.AutoSize = True
        Me.lblSelectedUserReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedUserReport.Location = New System.Drawing.Point(52, 62)
        Me.lblSelectedUserReport.Name = "lblSelectedUserReport"
        Me.lblSelectedUserReport.Size = New System.Drawing.Size(54, 24)
        Me.lblSelectedUserReport.TabIndex = 6
        Me.lblSelectedUserReport.Text = "User:"
        '
        'cbSelectedUserReports
        '
        Me.cbSelectedUserReports.FormattingEnabled = True
        Me.cbSelectedUserReports.Location = New System.Drawing.Point(112, 65)
        Me.cbSelectedUserReports.Name = "cbSelectedUserReports"
        Me.cbSelectedUserReports.Size = New System.Drawing.Size(227, 21)
        Me.cbSelectedUserReports.TabIndex = 7
        '
        'lblSelectedProyect
        '
        Me.lblSelectedProyect.AutoSize = True
        Me.lblSelectedProyect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedProyect.Location = New System.Drawing.Point(509, 60)
        Me.lblSelectedProyect.Name = "lblSelectedProyect"
        Me.lblSelectedProyect.Size = New System.Drawing.Size(78, 24)
        Me.lblSelectedProyect.TabIndex = 8
        Me.lblSelectedProyect.Text = "Proyect:"
        '
        'cbSelectedProyectReport
        '
        Me.cbSelectedProyectReport.FormattingEnabled = True
        Me.cbSelectedProyectReport.Location = New System.Drawing.Point(593, 62)
        Me.cbSelectedProyectReport.Name = "cbSelectedProyectReport"
        Me.cbSelectedProyectReport.Size = New System.Drawing.Size(227, 21)
        Me.cbSelectedProyectReport.TabIndex = 9
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(808, 458)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 35)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblReports.Location = New System.Drawing.Point(405, 9)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(75, 24)
        Me.lblReports.TabIndex = 14
        Me.lblReports.Text = "Reports"
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.lblReports)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbSelectedProyectReport)
        Me.Controls.Add(Me.lblSelectedProyect)
        Me.Controls.Add(Me.cbSelectedUserReports)
        Me.Controls.Add(Me.lblSelectedUserReport)
        Me.Controls.Add(Me.btnGenerateReportExcel)
        Me.Controls.Add(Me.chMultiDay)
        Me.Controls.Add(Me.mcFinishReport)
        Me.Controls.Add(Me.mcStartReport)
        Me.Controls.Add(Me.btnGenerateReportPDF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerateReportPDF As System.Windows.Forms.Button
    Friend WithEvents mcStartReport As System.Windows.Forms.MonthCalendar
    Friend WithEvents mcFinishReport As System.Windows.Forms.MonthCalendar
    Friend WithEvents chMultiDay As System.Windows.Forms.CheckBox
    Friend WithEvents btnGenerateReportExcel As System.Windows.Forms.Button
    Friend WithEvents lblSelectedUserReport As System.Windows.Forms.Label
    Friend WithEvents cbSelectedUserReports As System.Windows.Forms.ComboBox
    Friend WithEvents lblSelectedProyect As System.Windows.Forms.Label
    Friend WithEvents cbSelectedProyectReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblReports As System.Windows.Forms.Label
End Class
