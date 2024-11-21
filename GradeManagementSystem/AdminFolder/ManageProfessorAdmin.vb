Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ManageProfessorAdmin
    Private connector As New DatabaseConnector
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT * FROM faculty;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub addProfessorButton_Click(sender As Object, e As EventArgs) Handles addProfessorButton.Click

    End Sub
End Class