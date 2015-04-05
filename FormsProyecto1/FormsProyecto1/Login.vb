Imports System.Data.SqlClient

Public Class Login

    Dim strConexion As String = "Data Source=localhost;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)



    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        testLogin()

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub tbSecurity_KeyPress(sender As System.Object, e As System.EventArgs) Handles txtPassword.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            testLogin()

        End If

    End Sub

    Public Sub testLogin()





        Dim cmdSelectCourses As New SqlCommand("select * from [User] where user_name = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()


        reader.Read()
        '   Do While reader.HasRows
        'Do While reader.Read()

        ' username = reader.GetString(3)
        ' password = reader.GetString(4)

        If (reader.HasRows) Then


            Dim goToMenu As MainMenu = New MainMenu()
            goToMenu.userType = reader.GetInt32(7)



            goToMenu.Show()
            Me.Hide()

        Else

            MsgBox(" BAD USERNAME OR PASSWORD! ")




        End If






        '    Loop
        '    reader.NextResult()
        '   Loop



        connection.Close()
    End Sub
End Class