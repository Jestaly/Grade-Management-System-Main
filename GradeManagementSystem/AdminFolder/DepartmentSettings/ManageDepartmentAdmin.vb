Imports MySql.Data.MySqlClient

Public Class ManageDepartmentAdmin
    Private connector As New DatabaseConnector
    Private addDepartmentForm As New AddDepartmentForm
    Private modifyDepartmentForm As New ModifyDepartmentForm
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub addDepartment_Click(sender As Object, e As EventArgs) Handles addDepartment.Click
        Dim dCount As Integer = 0
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM dept_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            dCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addDepartmentForm.departmentIDLabel.Text = "D" & "-" & getZeros(dCount) & (dCount + 1)
        addDepartmentForm.Visible = True
    End Sub

    Private Function getZeros(dCount As Integer) As String
        Dim zeros As String = "000"
        Select Case dCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        modifyDepartmentForm.Visible = True
    End Sub
End Class