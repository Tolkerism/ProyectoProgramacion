Imports System.Data.SqlClient

Public Class Create_User
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub

    Public userType As Integer = 0
    Dim strConexion As String = "Data Source=localhost;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)
    Public Sub insertUsers()
        Dim itsActive As Integer
        Dim roleOfNewUser As Integer
        Dim entryDateOfNewUser As Date = DateValue(Now)

        If cbAdmin.Checked = True Then
            roleOfNewUser = 1
        Else
            roleOfNewUser = 0
        End If
        If cbActiveUser.Checked = True Then
            itsActive = 1
        Else
            itsActive = 0
        End If
        Dim lastNameOfNewUser As String = txtUserName.Text
        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("insert into [User](user_name,last_name,is_active,password,name,id_role,entry_date)" & _
                                   "values(@txtUserName,@lastNameOfNewUser,@itsActive,@txtUserPassword,@txtFirstName,@roleOfNewUser,@entryDateOfNewUser)", connection)

        With cmdInsert
            'date
            .Parameters.AddWithValue("@txtUserName", txtUserName.Text)
            .Parameters.AddWithValue("@lastNameOfNewUser", lastNameOfNewUser)
            .Parameters.AddWithValue("@itsActive", itsActive)
            .Parameters.AddWithValue("@txtUserPassword", txtUserPassword.Text)
            .Parameters.AddWithValue("@txtFirstName", txtFirstName.Text)
            .Parameters.AddWithValue("@roleOfNewUser", roleOfNewUser)
            .Parameters.AddWithValue("@entryDateOfNewUser", entryDateOfNewUser)

        End With

        Dim cmdSelectCourses As New SqlCommand("select * from [User] where user_name = '" & txtUserName.Text & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()

        reader.Read()

        If (Not (reader.HasRows())) Then

            If (txtUserName.Text.Length <= 7 And txtUserName.Text.Length > 1) Then
                connection.Close()
                connection.Open()
                cmdInsert.ExecuteNonQuery()
                connection.Close()
                MsgBox("The data of the user has been succesfully added")


            Else
                MsgBox("The Username must be at least 2 letters short and 7 letters max. ", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical)
                connection.Close()
            End If
        Else
            connection.Close()
            MsgBox("The current username is already taken, please select another ", MsgBoxStyle.OkOnly & MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Create_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        insertUsers()
    End Sub


End Class