Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ProfessorForm
    Private connector As New DatabaseConnector
    Private addItemForm As New AddItemForm

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
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

End Class