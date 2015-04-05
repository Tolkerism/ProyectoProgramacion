Imports System.Data.SqlClient

Public Class UserProfile
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
    Dim userName As String = ""
    Dim idProject As Integer = 0
    Dim coursesGridView As List(Of Project)
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        fillDataGridView()



        lblUserName.Text = userName
        getBasicInformation()

    End Sub

    Public Function listOfCourses() As List(Of Project)
        'From CoursesTable, obtains all the rows
        Dim cmdSelectProjects As New SqlCommand("select project_name from project, user_project, [User] where user_project.user_id  = '" & currentGlobalId & "'and project.id_project = user_project.id_project and [User].user_id =  user_project.user_id and user_project.isActive = '1' ", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectProjects.ExecuteReader()




        Dim coursesList As New List(Of Project)
        Dim courses As New Project

        Do While reader.HasRows
            Do While reader.Read()
                courses = New Project
                courses.getName = reader.GetString(0)


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






        dataTableProjects = createDataTable()

        coursesGridView = listOfCourses()





        Dim row As DataRow

        For i = 0 To coursesGridView.Count - 1 Step 1

            row = dataTableProjects.NewRow
            row("Name") = coursesGridView(i).getName



            dataTableProjects.Rows.Add(row)

        Next



        Me.dgvCurrentProjects.DataSource = dataTableProjects

    End Sub

    Private Sub getBasicInformation()
        Dim cmdSelectProjects As New SqlCommand("select  user_name from  [User] where [User].user_id  = '" & currentGlobalId & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectProjects.ExecuteReader()
        reader.Read()
        userName = reader.GetString(0)
        connection.Close()


        lblUserName.Text = userName

    End Sub

    Private Sub btnUserProfileBack_Click(sender As Object, e As EventArgs) Handles btnUserProfileBack.Click


        Me.Close()
    End Sub
End Class