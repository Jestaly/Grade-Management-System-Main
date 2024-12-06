Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ProfessorForm
    Private connector As New DatabaseConnector
    Private addItemForm As New AddItemForm
    Private term As String = "Midterm"

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        refreshForm()
    End Sub

    Public Sub refreshForm()
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT enrollment.student_id AS 'Student ID', CONCAT(student.lname,' ',student.fname,' ',student.lname) AS 'Student Name' from enrollment LEFT JOIN student ON enrollment.student_id = student.id  WHERE enrollment.class_id = 'CL001';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            studentInfoDataView.DataSource = connector.dataTable
            connector.connect.Close()
            connector.command.Parameters.Clear()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub loadData(selectedClass As String)
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
        makeAIFChild()
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

    Private Sub classChooseBox_SelectedItemChanged(sender As Object, e As EventArgs) Handles classChooseBox.SelectedItemChanged
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

    Public Function getClass() As String
        Return classChooseBox.Text
    End Function
End Class