Imports System.Data.SqlClient

Public Class Category_Management
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

    Dim coursesGridView As List(Of Category)
    Dim firstTimeCreate As Boolean = True
    Dim dataTableCourses As New DataTable

    Private Sub Category_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Me.dgvCategory.DataSource = vbNull
        fillDataGridView()


    End Sub

    Public Function createDataTable() As DataTable

        dataTableCourses = New DataTable
        dataTableCourses.Columns.Add("Name")
    

        createDataTable = dataTableCourses

    End Function

    Public Sub fillDataGridView()

        dataTableCourses = createDataTable()

        coursesGridView = listOfCourses()

        Dim row As DataRow

        For i = 0 To coursesGridView.Count - 1 Step 1

            row = dataTableCourses.NewRow
            row("Name") = coursesGridView(i).getName()

            dataTableCourses.Rows.Add(row)
        Next

        Me.dgvCategory.DataSource = dataTableCourses

        If firstTimeCreate Then



            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "Edit"
            btnEdit.Name = "btnEdit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True

            dgvCategory.Columns.Add(btnEdit)


            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = "Delete"
            btnDelete.Name = "btnDelete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True

            dgvCategory.Columns.Add(btnDelete)
            firstTimeCreate = False

        Else

            dgvCategory.Columns.RemoveAt(0)
            dgvCategory.Columns.RemoveAt(0)


            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "Edit"
            btnEdit.Name = "btnEdit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True

            dgvCategory.Columns.Add(btnEdit)


            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = "Delete"
            btnDelete.Name = "btnDelete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True

            dgvCategory.Columns.Add(btnDelete)


        End If

    End Sub

    Public Function listOfCourses() As List(Of Category)
        'From CoursesTable, obtains all the rows
        Dim cmdSelectCourses As New SqlCommand("select * from WorkCategory where  active <> 0", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
        Dim coursesList As New List(Of Category)

        Dim courses As New Category



        Do While reader.HasRows
            Do While reader.Read()
                courses = New Category
                courses.getId = reader.GetInt32(0)
                courses.getName = reader.GetString(1)
                courses.getActive = reader.GetValue(2)
                'courses.Professor
                coursesList.Add(courses)
            Loop
            reader.NextResult()
        Loop

        listOfCourses = coursesList
        connection.Close()
    End Function

    Public Function askCourseInputs() As Category

        Dim coursesName As String
        Dim idCourses As String
  

        Dim course As New Category
        idCourses = InputBox("Please write the new Id: ")
        coursesName = InputBox("Please write the new Category name: ")
  
        'coursesProfessor = InputBox("Ingrese el : ")
        Dim cmdSelectCourses As New SqlCommand("select * from WorkCategory where id_category = '" & idCourses & "'", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()

        reader.Read()

        If (Not reader.HasRows()) Then

            If (idCourses = "" Or Not IsNumeric(idCourses)) Then
                course.getId = 0
            Else
                course.getId = idCourses
            End If

            course.getName = coursesName

        Else
            course.getId = 0
            course.getName = ""

        End If
        connection.Close()

        'Here we create the object


        'return course
        askCourseInputs = course

    End Function

    Public Sub insert(ByVal course As Category)



            Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("insert into WorkCategory(category_name,active)" & _
                                       "values(@name,@active)", connection)

            With cmdInsert

            ' .Parameters.AddWithValue("@id", course.getId)
                .Parameters.AddWithValue("@name", course.getName)
                .Parameters.AddWithValue("@active", 1)

            End With



            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()
            MsgBox("New CATEGORY ADDED")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        insert(askCourseInputs())
        refreshTable()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim deleteInput As String = InputBox(" Please write which Category you wish to delete")
        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("DELETE FROM WorkCategory WHERE Category_Name='" & deleteInput & "'; ", connection)

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("CATEGORY DELETED!")

        refreshTable()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim updateInput As String = InputBox(" Please write down the new Category Name!")
        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("UPDATE WorkCategory SET category_name='" & updateInput & "'  WHERE id_Category='" & dgvCategory.CurrentRow.Index + 1 & "'; ", connection)

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("CATEGORY UPDATED!")

        refreshTable()


    End Sub



    Public Sub refreshTable()



        Me.dgvCategory.DataSource = vbNull
        fillDataGridView()



    End Sub


  

    Private Sub dataGridView1_CellClick(ByVal sender As Object, _
      ByVal e As DataGridViewCellEventArgs)

        '    MsgBox(e.RowIndex)
        ' Ignore clicks that are not on button cells.  

        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then


            editEntry(e.RowIndex)
            '     MsgBox("edit")

        End If

        If e.ColumnIndex = 2 And e.RowIndex >= 0 Then

            deleteEntry(e.RowIndex)
            '  MsgBox("delete")

        End If
    End Sub

    Private Sub deleteEntry(p1 As Integer)

        '  MsgBox(coursesGridView(p1).getId)
        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("update WorkCategory set active = '0' where '" & coursesGridView(p1).getId & "' = id_Category", connection)
        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("Entry deleted.")

        refreshTable()


    End Sub


    Private Sub editEntry(p1 As Integer)
           Dim editBox As New EditCategory()
        editBox.txtName.Text = coursesGridView(p1).getName

        editBox.isActive.Checked = (coursesGridView(p1).getActive = 1)

        editBox.StartPosition = FormStartPosition.CenterParent

        If editBox.ShowDialog() = 1 Then

            '   MsgBox(editBox.txtDescription.Text & editBox.txtHours.Text)
            Dim active As Integer

            If editBox.isActive.Checked Then
                active = 1
            Else

                active = 0

            End If



            Dim cmdUpdate As New SqlCommand
            cmdUpdate = New SqlCommand("update WorkCategory set category_name = '" & editBox.txtName.Text & "', active = '" & active & "' where '" & coursesGridView(p1).getId & "' = id_category", connection)

            connection.Open()
            cmdUpdate.ExecuteNonQuery()
            connection.Close()


            MsgBox("Entry Edited!")
            refreshTable()


        Else

            MsgBox("Edit canceled! ")
        End If
    End Sub

End Class