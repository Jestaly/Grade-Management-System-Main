Imports MySql.Data.MySqlClient

Public Class ManageDepartmentAdmin
    Private connector As New DatabaseConnector
    Private addDepartmentForm As New AddDepartmentForm
    Private modifyDepartmentForm As New ModifyDepartmentForm
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
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
        addDepartmentForm.Visible = True
    End Sub

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        modifyDepartmentForm.Visible = True
    End Sub
End Class