Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Public Class RequestHolidays
    'Dias libres disponibles ingresados por el admin (lo empiezo en 5 para comprobar)
    Dim cmdSelectCourses As New SqlCommand("select Available_Holidays from Holiday_Bank", connection)
    Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
    Public availableHolidays As Integer = reader.GetInt32(0)

    '  Dim strConexion As String = "Data Source=localhost;Initial Catalog=Courses;Integrated Security=True"
    Dim strConexion As String = "Data Source=localhost;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)

    Dim message As New MailMessage

    Dim smtp As New SmtpClient

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub

    Private Sub sendEmail()

        message.From = New MailAddress("pepitofox@outlook.com")

        message.To.Add("pepitofox@outlook.com")

        message.Body = "la prueba a funcionado"

        message.Subject = "prueba"

        message.Priority = MailPriority.Normal

        smtp.EnableSsl = True

        smtp.Port = "587"

        smtp.Host = "smtp.outlook.com"

        'smtp.Credentials = New Net.NetworkCredential("pepitofox@outlook.com", TextBox.Text)

        smtp.Send(message)

    End Sub

    Public Sub sendMessage()

        Dim Message As New System.Net.Mail.MailMessage()
        Dim SMTP As New System.Net.Mail.SmtpClient

        'CONFIGURACIÓN DEL STMP
        '----------------------------------------------------'("cuenta de correo", "contraseña")
        SMTP.Credentials = New System.Net.NetworkCredential("pepitofox@outlook.com", "luxofox13")
        SMTP.Host = "smtp.outlook.com"
        SMTP.Port = 587
        SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        Message.[To].Add("luxofox93@gmail.com") ' Aqui va el email del admin o admins
        '----------------------------------------------"Quien lo envía","Nombre de quien lo envía"
        Message.From = New System.Net.Mail.MailAddress("pepitofox@outlook.com", "pepito", System.Text.Encoding.UTF8) 'Quien envía el e-mail
        Message.Subject = "Holiday Request" 'Motivo o Asunto del e-mail
        Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        Message.Body = "I would like to go for Holidays on the specified days. Starting: " & dtpStartHoliday.Value & " To " & dtpFinishHoliday.Value & "" 'contenido del mail
        Message.BodyEncoding = System.Text.Encoding.UTF8
        Message.Priority = System.Net.Mail.MailPriority.Normal
        Message.IsBodyHtml = False

        'ENVIO
        Try
            SMTP.Send(Message)
            MessageBox.Show("Mensaje enviado correctamente", "Exito!", MessageBoxButtons.OK)
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
        End Try
    End Sub







    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If availableHolidays >= 14 Then
            MsgBox("You have been working for a whole year, you should take vacations", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub btnRequestHolidays_Click(sender As Object, e As EventArgs) Handles btnRequestHolidays.Click

        'acumulador de las vacaciones disponibles del usuario
        Dim vacationDays As Integer

        'boton para solicitar dias libres.
        dtpStartHoliday.MinDate = Today
        vacationDays = DateDiff(DateInterval.Day, dtpStartHoliday.Value, dtpFinishHoliday.Value) + 1
        If vacationDays <= availableHolidays Then
            'conect open, enviar solicitud de dias libres en las fechas marcadas. close conection.
            'sendMessage()
            'sendEmail()
            MsgBox("Su solicitud a sido enviada")
        Else
            MsgBox("El numero de dias elegidos es superior a los dias disponibles.")
        End If



    End Sub

    Private Sub ReturnToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToMainMenuToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dtpStartHoliday_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartHoliday.ValueChanged

    End Sub
End Class