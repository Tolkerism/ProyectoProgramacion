Imports System.Data.SqlClient

Public Class Time_Registration
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
    ' Dim strConexion As String = "Data Source=(LocalDB)\v11.0;Initial Catalog=Courses;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)
    Dim noProjects As Boolean = False
    Dim dataTableProjects As New DataTable
    Dim coursesGridView As List(Of Entry)
    Dim listOfProjectIds As List(Of Int32)
    Dim listOfCategoryId As List(Of Int32)
    Dim firstTimeCreate As Boolean = True

    Private Sub Time_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        projectDateEndPicker.MaxDate = projectDatePicker.Value
        listOfCategoryId = New List(Of Int32)
        listOfProjectIds = New List(Of Int32)



        '/////////////////////////////^^^^^^^   INSTANTIANCIATION  ^^^^^^^/////////////////////////////

        connection.Open()
        Dim cmdSelectCourses As New SqlCommand("select * from WorkCategory", connection)


        Dim data = New Dictionary(Of String, String)()
        Dim reader As SqlDataReader = cmdSelectCourses.ExecuteReader()
        Dim coursesList As New List(Of Category)

        Dim courses As New Category




        Do While reader.HasRows
            Do While reader.Read()

                data(Convert.ToString(reader.GetInt32(0))) = reader.GetString(1)
                listOfCategoryId.Add(reader.GetInt32(0))

            Loop
            reader.NextResult()
        Loop


        connection.Close()






        comboCategory.DataSource = New BindingSource(data, Nothing)
        comboCategory.DisplayMember = "Value"
        comboCategory.ValueMember = "Key"
        '////////////////////////////////////////////// ^^^^^^^ CATEGORIES ^^^^^^^^^^^^^^^//////////////////////////





        connection.Open()
        Dim cmdSelectProjects As New SqlCommand("select project_name,project.id_project from project,user_project where user_project.user_id = '" & currentGlobalId & "' and user_project.id_project = project.id_project ", connection)


        Dim dataProjects = New Dictionary(Of String, String)()
        Dim projectReader As SqlDataReader = cmdSelectProjects.ExecuteReader()
       
        Dim counter As Int32 = 0



        Do While projectReader.HasRows
            Do While projectReader.Read()


                listOfProjectIds.Add(projectReader.GetInt32(1))



                dataProjects(Convert.ToString(counter)) = projectReader.GetString(0)
                counter += 1

            Loop
            projectReader.NextResult()

        Loop


        connection.Close()


        If dataProjects.Count = 0 Then
            noProjects = True
            dataProjects("0") = " You have no projects"
        End If



        comboProjectName.DataSource = New BindingSource(dataProjects, Nothing)
        comboProjectName.DisplayMember = "Value"
        comboProjectName.ValueMember = "Key"


        ' MsgBox(listOfProjectIds.Count)

        lblEndDate.Visible = False
        projectDateEndPicker.Visible = False



        fillDataGridView()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click


        MsgBox(projectDatePicker.Value.ToString)
        MsgBox(projectDateEndPicker.Value.ToString)


        If (Not validateInputs()) Then

            ' MsgBox(" The current Id is already in use, please try another Id ")
        ElseIf (Not cbMultipleEntry.Checked) Then

            Dim cmdInsert As New SqlCommand
            cmdInsert = New SqlCommand("insert into Report_Category(user_id,id_category,id_project,hours,date,report)" & _
                                       "values(@user_id,@id_category,@id_project,@hours,@date,@report)", connection)

            With cmdInsert

                .Parameters.AddWithValue("@user_id", currentGlobalId)
                .Parameters.AddWithValue("@id_category", listOfCategoryId.ElementAt(comboCategory.SelectedIndex))
                .Parameters.AddWithValue("@id_project", listOfProjectIds.ElementAt(comboProjectName.SelectedIndex))
                .Parameters.AddWithValue("@hours", Convert.ToInt32(txtInputHours.Text))
                .Parameters.AddWithValue("@date", projectDatePicker.Value)
                .Parameters.AddWithValue("@report", txtReportDescription.Text)


            End With



            connection.Open()
            cmdInsert.ExecuteNonQuery()
            connection.Close()
            MsgBox("New Entry added!")
            refreshTable()



        ElseIf (projectDateEndPicker.Value.CompareTo(projectDatePicker.Value) <= 0 Or projectDatePicker.Value.CompareTo(Date.Now) > 0) Then '//////////////////////// TUVO QUE HABER SIDO UN MULTIPLE DAY ENTRY.

            ' MsgBox(projectDateEndPicker.Value.CompareTo(projectDatePicker.Value))
            MsgBox(" The End date must not be before the STARTING date and the Start date must be prior to today!")



        Else
            Dim totalDayAmount As Int32 = projectDateEndPicker.Value.Subtract(projectDatePicker.Value).Days
            MsgBox("The total reports to be added are " & totalDayAmount)



            For index = 0 To totalDayAmount


                Dim cmdInsert As New SqlCommand
                cmdInsert = New SqlCommand("insert into Report_Category(user_id,id_category,id_project,hours,date,report)" & _
                                           "values(@user_id,@id_category,@id_project,@hours,@date,@report)", connection)

                With cmdInsert

                    .Parameters.AddWithValue("@user_id", currentGlobalId)
                    .Parameters.AddWithValue("@id_category", listOfCategoryId.ElementAt(comboCategory.SelectedIndex))
                    .Parameters.AddWithValue("@id_project", listOfProjectIds.ElementAt(comboProjectName.SelectedIndex))
                    .Parameters.AddWithValue("@hours", Convert.ToInt32(txtInputHours.Text))
                    .Parameters.AddWithValue("@date", projectDatePicker.Value.AddDays(index))
                    .Parameters.AddWithValue("@report", txtReportDescription.Text)


                End With



                connection.Open()
                cmdInsert.ExecuteNonQuery()
                connection.Close()
                MsgBox("New Entry added!")
                refreshTable()
            Next







        End If


    End Sub

    Private Function validateInputs() As Boolean
        If noProjects Then
            MsgBox(" You're not currently assigned to any project! ")
            Return False
        ElseIf ((txtInputHours.Text.Length = 0)) Then
            MsgBox(" You must enter the amount of hours worked!")
            Return False

        ElseIf (Convert.ToInt32(txtInputHours.Text) > 24) Then

            MsgBox(" Total work time cannot exceed 24 hours! ")
            Return False

        ElseIf (txtReportDescription.Text.Length <= 10) Then

            MsgBox(" Report descriptions must be at least 10 characters long! ")
            Return False



        End If

        Return True
    End Function

    Private Sub txtInputHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInputHours.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                txtWarningHoursInput.Visible = True

            Else
                Invalidate()
                txtWarningHoursInput.Visible = False



            End If



        End If
    End Sub

    Private Sub cbMultipleEntry_CheckedChanged(sender As Object, e As EventArgs) Handles cbMultipleEntry.CheckedChanged


        If (cbMultipleEntry.Checked) Then

            projectDateEndPicker.Visible = True
            lblEndDate.Visible = True
            lblDate.Text = "Start:"
            Invalidate()



        Else

            lblDate.Text = "Date:"
            projectDateEndPicker.Visible = False
            lblEndDate.Visible = False
            Invalidate()



        End If

    End Sub

    Public Function listOfCourses() As List(Of Entry)
        'From CoursesTable, obtains all the rows

        ' Dim cmdSelectProjects As New SqlCommand("select * from project, user_project, [User] where user_project.user_id  = '" & currentGlobalId & "'and project.id_project = user_project.id_project and [User].user_id =  user_project.user_id and user_project.isActive = '1' ", connection)


        Dim cmdSelectProjects As SqlCommand
        If currentGlobalRole = 2 Or currentGlobalRole = 1 Then

            cmdSelectProjects = New SqlCommand("select * from report_category,project,user_project,WorkCategory  where  user_project.id_project = project.id_project and report_category.user_id = user_project.user_id", connection)

        Else
             cmdSelectProjects = New SqlCommand("select * from report_category,project,user_project,WorkCategory  where user_project.user_id = '" & currentGlobalId & "' and user_project.id_project = project.id_project and report_category.user_id = '" & currentGlobalId & "'", connection)


        End If
       connection.Open()

        Dim reader As SqlDataReader = cmdSelectProjects.ExecuteReader()




        Dim coursesList As New List(Of Entry)
        Dim courses As New Entry

        Do While reader.HasRows
            Do While reader.Read()
                courses = New Entry
                courses.getName = reader.GetString(8)
                courses.getDescription = reader.GetValue(2)
                courses.getHours = reader.GetValue(5)
                courses.getDate = reader.GetValue(6)
                courses.getCategory = reader.GetValue(17)
                courses.getId = reader.GetValue(1)

                coursesList.Add(courses)
            Loop
            reader.NextResult()
        Loop

        listOfCourses = coursesList
        connection.Close()
    End Function

    Public Function createDataTable() As DataTable

        dataTableProjects = New DataTable
        dataTableProjects.Columns.Add("Date")
        dataTableProjects.Columns.Add("Name")
        dataTableProjects.Columns.Add("Description")
        dataTableProjects.Columns.Add("Work Category")
        dataTableProjects.Columns.Add("Hours")






        createDataTable = dataTableProjects

    End Function
    Public Sub fillDataGridView()






        dataTableProjects = createDataTable()

        coursesGridView = listOfCourses()




        Dim row As DataRow

        For i = 0 To coursesGridView.Count - 1 Step 1


            row = dataTableProjects.NewRow
            row("Name") = coursesGridView(i).getName
            row("Hours") = coursesGridView(i).getHours
            row("Description") = coursesGridView(i).getDescription
            row("Work Category") = coursesGridView(i).getCategory
            row("Date") = coursesGridView(i).getDate




            dataTableProjects.Rows.Add(row)


            ' dgvEntry.Columns.Add(btn)


        Next



        Me.dgvEntry.DataSource = dataTableProjects

        If firstTimeCreate Then



            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "Edit"
            btnEdit.Name = "btnEdit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True

            dgvEntry.Columns.Add(btnEdit)


            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = "Delete"
            btnDelete.Name = "btnDelete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True

            dgvEntry.Columns.Add(btnDelete)
            firstTimeCreate = False

        Else

            dgvEntry.Columns.RemoveAt(0)
            dgvEntry.Columns.RemoveAt(0)


            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = "Edit"
            btnEdit.Name = "btnEdit"
            btnEdit.Text = "Edit"
            btnEdit.UseColumnTextForButtonValue = True

            dgvEntry.Columns.Add(btnEdit)


            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = "Delete"
            btnDelete.Name = "btnDelete"
            btnDelete.Text = "Delete"
            btnDelete.UseColumnTextForButtonValue = True

            dgvEntry.Columns.Add(btnDelete)


        End If
    End Sub

    Private Sub dataGridView1_CellClick(ByVal sender As Object, _
       ByVal e As DataGridViewCellEventArgs)

        '    MsgBox(e.RowIndex)
        ' Ignore clicks that are not on button cells.  

        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then


            editEntry(e.RowIndex)
            '     MsgBox("edit")

        End If

        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then

            deleteEntry(e.RowIndex)
            '  MsgBox("delete")

        End If
        ' Retrieve the Employee object from the "Assigned To" cell. 
        '   Dim assignedTo As Employee = TryCast(dataGridView1.Rows(e.RowIndex) _
        '        .Cells("Assigned To").Value, Employee)

        ' Request status through the Employee object if present.  
        '   If assignedTo IsNot Nothing Then
        '   assignedTo.RequestStatus(taskID)
        '     Else
        '  MessageBox.Show(String.Format( _
        ''       "Task {0} is unassigned.", taskID), "Status Request")
        '  End If
        '


    End Sub

    Private Sub deleteEntry(p1 As Integer)

        '  MsgBox(coursesGridView(p1).getId)
        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("delete from Report_Category where '" & coursesGridView(p1).getId & "' = id_report", connection)



        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("Entry deleted.")

        refreshTable()
    End Sub


    Public Sub refreshTable()

        dgvEntry.DataSource = vbNull
        fillDataGridView()

    End Sub

    Private Sub editEntry(p1 As Integer)
        '    MsgBox(coursesGridView(p1).getId)

        Dim editBox As New EditEntry()
        editBox.txtDescription.Text = coursesGridView(p1).getDescription
        editBox.txtHours.Text = coursesGridView(p1).getHours
        editBox.dtpDate.Value = coursesGridView(p1).getDate

        editBox.StartPosition = FormStartPosition.CenterParent

        If editBox.ShowDialog() = 1 Then

            '   MsgBox(editBox.txtDescription.Text & editBox.txtHours.Text)
            Dim cmdUpdate As New SqlCommand
            cmdUpdate = New SqlCommand("update Report_Category set report = '" & editBox.txtDescription.Text & "',hours = '" & editBox.txtHours.Text & "',date = '" & editBox.dtpDate.Value & "' where '" & coursesGridView(p1).getId & "' = id_report", connection)

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