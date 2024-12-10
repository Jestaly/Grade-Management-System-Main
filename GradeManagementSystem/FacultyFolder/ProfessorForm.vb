Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ProfessorForm
    Private connector As New DatabaseConnector
    Private addItemForm As New AddItemForm
    Private term As String = "Midterm"

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        refreshForm()
        refreshProjCol()
        refreshScores()
    End Sub

    Public Sub refreshForm()
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT enrollment.student_id AS 'Student ID', CONCAT(student.lname,' ',student.fname,' ',student.lname) AS 'Student Name' from enrollment LEFT JOIN student ON enrollment.student_id = student.id  WHERE enrollment.class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            studentInfoDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private classCode As String = classID
    Private Sub refreshProjCol()
        Dim colCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Project' FROM item WHERE item_type = 'Project' AND class_id = '" & classChooseBox.Text & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                colCount = Integer.Parse(connector.reader("Number of Project").ToString)
            End While

            For j As Integer = 0 To colCount - 1
                If (projectDataView.Columns.Count > 0) Then
                    projectDataView.Columns.RemoveAt(0)
                End If
            Next

            For i As Integer = 0 To colCount - 1
                projectDataView.Columns.Add("project" & (i + 1), "P" & (i + 1))
            Next
            connector.reader.Close()
            connector.connect.Close()
            refreshProjRows()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub refreshProjRows()
        Dim studentCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Student' FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Student").ToString.Equals("")) Then
                    studentCount = Integer.Parse(connector.reader("Number of Student").ToString)
                End If
            End While
            projectDataView.Rows.Clear()
            For i As Integer = 1 To studentCount
                projectDataView.Rows.Add()
            Next
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getRowNum() As Integer
        Dim rowCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(enrollment_id) AS enrollment_id FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("enrollment_id").ToString.Equals("")) Then
                    rowCount = Integer.Parse(connector.reader("enrollment_id").ToString)
                    connector.connect.Close()
                    connector.reader.Close()
                    Return rowCount
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return rowCount
    End Function

    Private Function getColumnNum() As Integer
        Dim colCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS 'Number of Project' FROM item WHERE item_type = 'Project' AND class_id = '" & classChooseBox.Text & "' AND term = '" & term & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("Number of Project").ToString.Equals("")) Then
                    colCount = Integer.Parse(connector.reader("Number of Project").ToString)
                    connector.connect.Close()
                    connector.reader.Close()
                    Return colCount
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return colCount
    End Function

    'stopped here
    Private Sub refreshScores()
        Try
            connector.connect.Open()
            connector.query = "SELECT "
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try

        For i As Integer = 0 To getColumnNum() - 1
            For j As Integer = 0 To getRowNum() - 1
                projectDataView.Rows(j).Cells(i).Value = 0
            Next
        Next
    End Sub

    Public classID As String
    Private Sub loadData(selectedClass As String)
        classID = selectedClass
        Try
            connector.connect.Open()
            connector.query = "SELECT CONCAT(professor.fname,' ',professor.mname,' ',professor.lname) AS Professor, course.course_name AS Course, CONCAT(DATE_FORMAT(time_start, '%H:%i'),time_history.start_abbreviation,'-',DATE_FORMAT(time_end,'%H:%i'),time_history.end_abbreviation) AS 'Time Period', day AS 'Day' FROM class  LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id LEFT JOIN time_history ON class.class_id = time_history.class_id WHERE class.class_id = '" & selectedClass & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                courseTextBox.Text = connector.reader("Course").ToString
                timeTextBox.Text = connector.reader("Time Period").ToString
                dayTextBox.Text = connector.reader("Day").ToString
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub addItemButton_Click(sender As Object, e As EventArgs) Handles addItemButton.Click
        addItemForm.Visible = True
    End Sub

    Private Sub makeAIFChild()
        addItemForm.TopLevel = False
        addItemForm.Parent = Me
        CenterAIF()
        addItemForm.BringToFront()
    End Sub

    Private Sub CenterAIF()
        Dim x As Integer = (Me.ClientSize.Width - addItemForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addItemForm.Height) \ 2
        addItemForm.Location = New Point(x, y)
    End Sub

    Private Sub ProfessorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeDVS()
        makeAIFChild()
    End Sub

    Private Sub initializeDVS()
        projectDataView.AllowUserToAddRows = False
        studentInfoDataView.AllowUserToAddRows = False
        attendanceDataView.AllowUserToAddRows = False
        quizDataView.AllowUserToAddRows = False
        examDataView.AllowUserToAddRows = False
        gradeDataView.AllowUserToAddRows = False
        equivalentDataView.AllowUserToAddRows = False
        remarkDataView.AllowUserToAddRows = False
    End Sub

    Private Sub allDataView_Scroll(sender As Object, e As ScrollEventArgs) Handles remarkDataView.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            equivalentDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            gradeDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            examDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            projectDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            quizDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            attendanceDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
            studentInfoDataView.FirstDisplayedScrollingRowIndex = remarkDataView.FirstDisplayedScrollingRowIndex
        End If
    End Sub

    Private Sub classChooseBox_SelectedItemChanged(sender As Object, e As EventArgs) Handles classChooseBox.SelectedIndexChanged
        '--------------CAUTION ON RUNNING CODE HERE----------------
        'MIGHT INTERCHANGE ALL DATA IN GRADING TABLES FROM DATABASE
        Dim selectedClass As String = classChooseBox.Text
        loadData(selectedClass)
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Visible = False
        LoginForm.Visible = True
    End Sub

    Private Sub midtermButton_Click(sender As Object, e As EventArgs) Handles midtermButton.Click
        term = "Midterm"
        refreshForm()
    End Sub

    Private Sub finalButton_Click(sender As Object, e As EventArgs) Handles finalButton.Click
        term = "Final"
        refreshForm()
    End Sub

    Public Function getTerm() As String
        Return term
    End Function

End Class