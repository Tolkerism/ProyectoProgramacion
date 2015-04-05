Imports System.Data.SqlClient

Public Class txt_project_name

    Private _mainMenu As MainMenu

    Public Sub New(ByRef mainMenu As MainMenu)

        'Call to MyBase.New must be the very first in a constructor.
        MyBase.New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _mainMenu = mainMenu

    End Sub

    'Set the color red to Borders
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
    Dim connection As New SqlConnection(strConexion)

    Dim dataTableProjects As New DataTable
    Dim userName As String = ""
    Dim idProject As Integer = 0
    Dim coursesGridView As List(Of Project)


    Private Sub Proyect_Administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        fillDataGridView()
    End Sub

    Private Sub btnCreateProyect_Click(sender As Object, e As EventArgs) Handles btnCreateProyect.Click

        Dim name As String = txt_name.Text
        Dim budget As Integer = txt_budget.Text
        Dim dueDate As Date = dtp_due_date.Value.Date



        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("insert into project(project_name,project_time,project_budget)" & _
                                   "values(@project_name,@project_time,@project_budget)", connection)

        With cmdInsert

            .Parameters.AddWithValue("@project_name", name)
            .Parameters.AddWithValue("@project_time", dueDate)
            .Parameters.AddWithValue("@project_budget", budget)


        End With

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("The new " & name & " project has been succesfully added!")






        Me.dgvCurrentProjects.DataSource = vbNull
        fillDataGridView()

    End Sub

    Private Sub mcDueDate_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub btnUsersInProyects_Click(sender As Object, e As EventArgs) Handles btnUsersInProyects.Click


        Dim AU As New AssignUsers()
        AU.Show()



    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' MainMenu.Show()
        Me.Close()

    End Sub

    Public Function listOfCourses() As List(Of Project)
        'From CoursesTable, obtains all the rows
        ' Dim cmdSelectProjects As New SqlCommand("select * from project, user_project, [User] where user_project.user_id  = '" & currentGlobalId & "'and project.id_project = user_project.id_project and [User].user_id =  user_project.user_id and user_project.isActive = '1' ", connection)

        Dim cmdSelectProjects As New SqlCommand("select * from project ", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectProjects.ExecuteReader()




        Dim coursesList As New List(Of Project)
        Dim courses As New Project

        Do While reader.HasRows
            Do While reader.Read()
                courses = New Project
                courses.getName = reader.GetString(1)
                courses.getBudget = reader.GetValue(3)
                courses.getDate = reader.GetValue(2)



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
        dataTableProjects.Columns.Add("Budget")
        dataTableProjects.Columns.Add("Time")



        createDataTable = dataTableProjects

    End Function
    Public Sub fillDataGridView()






        dataTableProjects = createDataTable()

        coursesGridView = listOfCourses()





        Dim row As DataRow

        For i = 0 To coursesGridView.Count - 1 Step 1

            row = dataTableProjects.NewRow
            row("Name") = coursesGridView(i).getName
            row("Budget") = coursesGridView(i).getBudget
            row("Time") = coursesGridView(i).getDate



            dataTableProjects.Rows.Add(row)

        Next



        Me.dgvCurrentProjects.DataSource = dataTableProjects

    End Sub

End Class