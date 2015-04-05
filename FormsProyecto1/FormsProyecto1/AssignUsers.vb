Imports System.Data.SqlClient

Public Class AssignUsers

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)



    End Sub

    Dim strConexion As String = "Data Source=localhost;Integrated Security=True"
    Dim projectName As String = " "


    Dim dataTableProjects As New DataTable
    Dim connection As New SqlConnection(strConexion)
    Dim proyectName As String = ""
    Dim idProject As Integer = 0
    Dim coursesGridView As List(Of User)
    Private Sub AssignUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connection.Open()
        Dim cmdSelectCourses As New SqlCommand("select * from project", connection)
        Dim counter As Integer = 1

        Dim dataProject = New Dictionary(Of String, String)()
        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()




        Do While reader.HasRows
            Do While reader.Read()

                dataProject(Convert.ToString(counter)) = reader.GetString(1)
                counter += 1
            Loop
            reader.NextResult()
        Loop

        If dataProject.Count = 0 Then

            dataProject("0") = " There are no projects available right now "
        End If

        comboProject.DataSource = New BindingSource(dataProject, Nothing)
        comboProject.DisplayMember = "Value"
        comboProject.ValueMember = "Key"



        Dim cmdSelectProjects As New SqlCommand("select * from [User]", connection)
        counter = 1
        Dim dataUser = New Dictionary(Of String, String)()
        Dim dataProjects = New Dictionary(Of String, String)()


        connection.Close()
        connection.Open()
        reader = cmdSelectProjects.ExecuteReader()





        Do While reader.HasRows
            Do While reader.Read()

                dataUser(Convert.ToString(counter)) = reader.GetString(1)

                counter += 1
            Loop
            reader.NextResult()
        Loop




        connection.Close()







        Me.dgv.DataSource = vbNull
        fillDataGridView()





        comboUser.DataSource = New BindingSource(dataUser, Nothing)
        comboUser.DisplayMember = "Value"
        comboUser.ValueMember = "Key"











    End Sub

    Public Function listOfCourses() As List(Of User)
        'From CoursesTable, obtains all the rows
        Dim cmdSelectCourses As New SqlCommand("select * from [User], user_project , project where [User].user_id = User_Project.user_id and Project.id_project = User_Project.id_project and Project.id_project = '" & idProject & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
        Dim coursesList As New List(Of User)

        Dim courses As New User



        Do While reader.HasRows
            Do While reader.Read()
                courses = New User
                courses.name_Of_User = reader.GetString(4)


                'courses.Professor
                coursesList.Add(courses)
            Loop
            reader.NextResult()
        Loop

        listOfCourses = coursesList
        connection.Close()
    End Function

    Public Function createDataTable() As DataTable

        dataTableProjects = New DataTable
        dataTableProjects.Columns.Add("Name")
        '   dataTableProjects.Columns.Add("Name")



        createDataTable = dataTableProjects

    End Function
    Public Sub fillDataGridView()

        projectName = comboProject.GetItemText(comboProject.SelectedItem)
        Dim cmdSelectCourses As New SqlCommand("select id_project from Project where project_name = '" & projectName & "'", connection)

        connection.Close()
        connection.Open()


        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()


        reader.Read()
        '   Do While reader.HasRows
        'Do While reader.Read()

        ' username = reader.GetString(3)
        ' password = reader.GetString(4)\

        If reader.HasRows Then

            idProject = reader.GetInt32(0)

        Else

            idProject = 0
        End If

        connection.Close()



        dataTableProjects = createDataTable()

        coursesGridView = listOfCourses()





        Dim row As DataRow

        For i = 0 To coursesGridView.Count - 1 Step 1

            row = dataTableProjects.NewRow
            row("Name") = coursesGridView(i).name_Of_User


            dataTableProjects.Rows.Add(row)

        Next



        Me.dgv.DataSource = dataTableProjects

    End Sub
    Private Sub btn_assign_Click(sender As Object, e As EventArgs) Handles btn_assign.Click


        If checkValues() Then





            'MsgBox(comboUser.GetItemText(comboUser.SelectedItem))

            connection.Open()
            Dim cmdSelectCourses As New SqlCommand("select * from [User] where user_name = '" & comboUser.GetItemText(comboUser.SelectedItem) & "'", connection)




            Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            reader.Read()

            '  MsgBox(reader.GetInt32(0))

            Dim userIds As Integer = reader.GetInt32(0)
            connection.Close()



            If checkUserAlreadyExists() Then




                MsgBox(" The currently selected user is already participating in this project ")



            Else
                Dim cmdInsert As New SqlCommand
                cmdInsert = New SqlCommand("insert into User_Project(user_id,id_project,hours)" & _
                                               "values(@user_id,@id_project,@hours)", connection)

                With cmdInsert

                    .Parameters.AddWithValue("@user_id", userIds)
                    .Parameters.AddWithValue("@id_project", idProject)
                    .Parameters.AddWithValue("@hours", txtHours.Text)



                End With


                connection.Open()
                cmdInsert.ExecuteNonQuery()
                connection.Close()
                MsgBox("New User added to the project ")


            End If




            '  Dim cmdSelectUserCheck = New SqlCommand("select * from [User], user_project , project where '" & userIds & "' = User_Project.user_id and Project.id_project = User_Project.id_project and Project.id_project = '" & idProject & "'", connection)
            '   connection.Open()

            '   Dim readerCheck As SqlDataReader = cmdSelectCourses.ExecuteReader()
            '   reader.Read()
            '
            '   If readerCheck.HasRows Then

            'MsgBox()

            ' End If




            ' connection.Open()
            '  MsgBox(comboUser.GetItemText(comboUser.SelectedItem))
            '' Dim cmdSelectUser As New SqlCommand("insert * from [User] where name = '" & comboUser.GetItemText(comboUser.SelectedItem) & "'", connection)

            '  Dim userReader As SqlDataReader = cmdSelectUser.ExecuteReader()
            ' userReader.Read()
            '
            'MsgBox(userReader.GetInt32(0))

            '        Dim specificUserId As String = userReader.GetInt32(0)



            '        connection.Close()
            '      connection.Open()
            '       Dim cmdSelectCourses As New SqlCommand("select * from project where project_name = '" & comboProject.GetItemText(comboProject.SelectedItem) & "'", connection)


            '     Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
            '    reader.Read()

            'Dim userIds As String = reader.GetString(4)

            'connection.Close()
            'If (userIds.Contains(specificUserId)) Then

            'MsgBox(" USUARIO YA PERTENECE AL PROYECTO ")

            'Else

            ' userIds += ("," & Convert.ToString(specificUserId))
            '  D() 'im cmdInsert As New SqlCommand
            '  cmdInsert = New SqlCommand("UPDATE project SET project_participants ='" & userIds & "'  WHERE project_name ='" & comboProject.GetItemText(comboProject.SelectedItem) & "'; ", connection)

            '    connection.Open()
            '   cmdInsert.ExecuteNonQuery()
            '   connection.Close()
            '   MsgBox("USER SUCCESFULLY ADDED!")



            '   End If
            refreshTable()

        End If

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click

        connection.Open()

        '   MsgBox(comboUser.GetItemText(comboUser.SelectedItem))
        Dim cmdSelectUser As New SqlCommand("select * from [User] where user_name = '" & comboUser.GetItemText(comboUser.SelectedItem) & "'", connection)

        Dim userReader As SqlDataReader = cmdSelectUser.ExecuteReader()
        userReader.Read()



        Dim specificUserId As String = userReader.GetInt32(0)



        connection.Close()


        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("Delete From User_Project WHERE id_project ='" & idProject & "' and user_id = '" & specificUserId & "' ", connection)

        connection.Open()
        If 0 < cmdInsert.ExecuteNonQuery() Then

            MsgBox("USER WAS REMOVED SUCCESFULLY!")
        Else
            MsgBox(" THIS USER IS NOT CURRENTLY ASSIGNED TO THE SELECTED PROJECT! ")





        End If

        connection.Close()
        refreshTable()


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub comboProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProject.SelectedIndexChanged




        refreshTable()



    End Sub

    Public Sub refreshTable()



        Me.dgv.DataSource = vbNull
        fillDataGridView()



    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Function checkUserAlreadyExists() As Boolean

        For index = 0 To coursesGridView.Count - 1


            If coursesGridView.ElementAt(index).name_Of_User = comboUser.GetItemText(comboUser.SelectedItem) Then


                Return True
            End If
        Next
        Return False
    End Function

    Private Function checkValues() As Boolean







        If txtHours.TextLength = 0 Then
            MsgBox(" please put a value for hours! ")
            Return False
        End If



        Dim totalHours As Integer
        connection.Dispose()
        connection = New SqlConnection(strConexion)
        connection.Open()

        '   MsgBox(comboUser.GetItemText(comboUser.SelectedItem))

        'Dim cmdSelectUser As New SqlCommand("select hours from [User],User_Project where [User].user_name = '" & comboUser.GetItemText(comboUser.SelectedItem) & "' and [User].user_id = user_project.user_id", connection)


        Dim selector As New SqlCommand("select * from [User],User_Project where [User].user_name = '" & comboUser.GetItemText(comboUser.SelectedItem) & "' and [User].user_id = User_Project.user_id", connection)



        Dim newReader As SqlDataReader = selector.ExecuteReader()





        While (newReader.Read())


            MsgBox(newReader.GetValue(2))
            MsgBox(newReader.GetValue(3))
            MsgBox(newReader.GetValue(10))
            '  MsgBox(" El total de hours es " & totalHours)

            totalHours += newReader.GetValue(10)
            MsgBox(" TOTAL POST SUMA  " & totalHours)



        End While





        connection.Close()


        If (totalHours + Convert.ToInt32(txtHours.Text)) > 160 Then

            MsgBox(" The current user cannot accept more than 160 total work hours divided between all project. This user's current work load in hours sums up to " & totalHours)
            Return False

        End If





        Return True
    End Function

    Private Sub txtInputHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHours.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True


            Else
                ' Invalidate()




            End If



        End If
    End Sub

End Class