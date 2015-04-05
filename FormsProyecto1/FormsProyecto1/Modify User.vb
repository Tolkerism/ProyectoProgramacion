

Imports System.Data.SqlClient
Public Class Modify_User

    Dim strConexion As String = "Data Source=localhost;Integrated Security=True"
    'Dim strConexion As String = "Data Source=(LocalDB)\v11.0;Initial Catalog=Clessidra;Integrated Security=True"
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
    Private Sub fillCbUserType()



        If currentGlobalRole = 2 Then

            connection.Open()
            Dim cmdSelectCourses As New SqlCommand("select role_name from Role", connection)
            Dim data = New Dictionary(Of String, String)()
            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            Dim coursesList As New List(Of Category)
            Dim courses As New Category
            Dim counter As Integer = 0

            Do While reader.HasRows
                Do While reader.Read()

                    data(Convert.ToString((counter))) = reader.GetString(0)
                    counter += 1
                Loop

                reader.NextResult()

            Loop
            connection.Close()
            cbUserRol.DataSource = New BindingSource(data, Nothing)
            cbUserRol.DisplayMember = "Value"
            cbUserRol.ValueMember = "Key"
        Else

            connection.Open()
            Dim cmdSelectCourses As New SqlCommand("select role_name from Role where Role.role_name <> 'Root' ", connection)
            Dim data = New Dictionary(Of String, String)()
            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            Dim coursesList As New List(Of Category)
            Dim courses As New Category
            Dim counter As Integer = 0

            Do While reader.HasRows
                Do While reader.Read()

                    data(Convert.ToString((counter))) = reader.GetString(0)
                    counter += 1
                Loop

                reader.NextResult()

            Loop

            connection.Close()
            cbUserRol.DataSource = New BindingSource(data, Nothing)
            cbUserRol.DisplayMember = "Value"
            cbUserRol.ValueMember = "Key"



        End If
    End Sub

    Private Sub fillCbSelectUser()
        connection.Open()
        Dim cmdSelectCourses As New SqlCommand("select user_name from [User]", connection)
        Dim data = New Dictionary(Of String, String)()
        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
        Dim coursesList As New List(Of Category)
        Dim courses As New Category
        Dim counter As Integer = 0

        Do While reader.HasRows
            Do While reader.Read()

                data(Convert.ToString((counter))) = reader.GetString(0)
                counter += 1
            Loop

            reader.NextResult()

        Loop
        connection.Close()
        cbSelectUser.DataSource = New BindingSource(data, Nothing)
        cbSelectUser.DisplayMember = "Value"
        cbSelectUser.ValueMember = "Key"

    End Sub
    Private Sub Modify_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCbSelectUser()
        fillCbUserType()


    End Sub

  

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        Dim cmdInsert As New SqlCommand
        Dim selectedRole As Integer
        Dim bridge As Integer
        Dim selectedUserRol As String = Convert.ToString(cbUserRol.SelectedItem)

        If selectedUserRol = "[2, Root]" Then
            selectedRole = 2
        ElseIf selectedUserRol = "[1, Admin]" Then
            selectedRole = 1
        Else
            selectedRole = 0
        End If

        If selectedRole = 2 Then
            bridge = selectedRole
            currentGlobalRole = 1
            connection.Open()
            Dim cmdSelectCourses As New SqlCommand("select user_name from [User] WHERE [User].id_role = 2", connection)
            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            reader.Read()
            Dim UsernameOfFather As String = reader.GetString(0)

            cmdInsert = New SqlCommand("UPDATE [User] SET id_role = '1'  WHERE user_name = '" & UsernameOfFather & "' ", connection)
            connection.Close()

            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()

            cmdInsert = New SqlCommand("UPDATE [User] SET id_role = " & bridge & "  WHERE user_name = '" & cbSelectUser.Text & "' ", connection)
            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()
            MsgBox("update done")



        End If

        If selectedRole = 1 Then
            connection.Open()
            cmdInsert = New SqlCommand("UPDATE [User] SET id_role = '1'  WHERE user_name = '" & cbSelectUser.Text & "' AND [User].id_role = 0 ", connection)

            Dim cmdSelectCourses As New SqlCommand("select id_role from [User] WHERE [User].user_name = '" & cbSelectUser.Text & "'", connection)
            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            reader.Read()

            If reader.GetInt32(0) = 0 Then
                connection.Close()
                connection.Open()
                cmdInsert.ExecuteNonQuery()
                connection.Close()
                MsgBox("update done")
            Else
                connection.Close()
                MsgBox("You can't do that opperation", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If
        End If


        If selectedRole = 0 Then

            cmdInsert = New SqlCommand("UPDATE [User] SET id_role = 0  WHERE user_name = '" & cbSelectUser.Text & "' AND [User].id_role <> 2 ", connection)

            connection.Open()

            Dim cmdSelectCourses As New SqlCommand("select id_role from [User] WHERE [User].user_name = '" & cbSelectUser.Text & "'", connection)
            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            reader.Read()

            If reader.GetInt32(0) = 1 Or reader.GetInt32(0) = 0 Then
                connection.Close()
                connection.Open()
                cmdInsert.ExecuteNonQuery()
                connection.Close()
                MsgBox("update done")
            Else
                connection.Close()
                MsgBox("You can't do that opperation", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            End If

            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()
            MsgBox("update done")


        End If



    End Sub

 
End Class

