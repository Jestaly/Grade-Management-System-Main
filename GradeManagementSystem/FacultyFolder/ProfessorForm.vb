Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ProfessorForm
    Private connector As New DatabaseConnector

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section,student.email FROM student LEFT JOIN program ON student.program_id = program.program_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            studentInfoDataView.DataSource = connector.dataTable
            attendanceData.DataSource = connector.dataTable
            quizDataView.DataSource = connector.dataTable
            connector.connect.Close()
            connector.command.Parameters.Clear()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    'Private Sub dataGridView3_Scroll(sender As Object, e As ScrollEventArgs) Handles dataGridView3.Scroll
    'If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
    '       dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView3.FirstDisplayedScrollingRowIndex
    '      dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView3.FirstDisplayedScrollingRowIndex
    'End If
    'End Sub
End Class