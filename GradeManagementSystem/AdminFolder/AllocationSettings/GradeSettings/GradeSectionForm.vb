Imports MySql.Data.MySqlClient
Public Class GradeSectionForm
    Private connector As New DatabaseConnector
    Private addGradeWeightForm As New AddGradeWeightForm
    Private modifyGradeWeightForm As New ModifyGradeWeightForm
    Private Sub addGradeWeightButton_Click(sender As Object, e As EventArgs) Handles addGradeWeightButton.Click
        loadDepartment()
        addGradeWeightForm.Visible = True
    End Sub

    Private Sub loadDepartment()
        Try
            AddProgramForm.departmentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT dept_name FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim departmentName As String = connector.reader("dept_name").ToString()
                If Not String.IsNullOrEmpty(departmentName) Then
                    addGradeWeightForm.deptComboBox.Items.Add(departmentName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT p_attendance AS Attendance,p_quiz AS Quiz,p_project AS Project,p_exam AS Exam,department.dept_name AS Department FROM percentage LEFT JOIN department ON percentage.dept_id = department.dept_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            gradeWeightDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub modifyGradeWeightButton_Click(sender As Object, e As EventArgs) Handles modifyGradeWeightButton.Click
        modifyGradeWeightForm.Visible = True
    End Sub
End Class