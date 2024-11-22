Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class ManageProfessorAdmin
    Private connector As New DatabaseConnector
    Private addProfessorAccount As New AddProfessorAccount
    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
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
        Try
            connector.connect.Open()
            connector.query = "SELECT count FROM pcount_history WHERE count "
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            Dim pCount As Integer = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Dim profSubString = Integer.Parse(addProfessorAccount.professorIDLabel.Text.Substring(5, 5))
        MessageBox.Show(profSubString)

        addProfessorAccount.professorIDLabel.Text = getProfNum() & "-" & getProfYear() & "-" & getZeros(profSubString) & (profSubString + 1)
        addProfessorAccount.Visible = True
    End Sub

    Private Function getProfNum() As String
        Dim idInt As Integer
        idInt = 2
        Dim profNum As String = idInt

        Return profNum
    End Function
    Private Function getProfYear() As Integer
        Dim profYear As String = DateAndTime.Now.Year
        profYear = profYear.Chars(2) & profYear.Chars(3)

        Return profYear
    End Function
    Private Function getZeros(profSubString As Integer) As String
        Dim zeros As String = "00000"
        Select Case profSubString.ToString.Length
            Case 1
                zeros = "0000"
            Case 2
                zeros = "000"
            Case 3
                zeros = "00"
            Case 4
                zeros = "0"
            Case 5
                zeros = ""
        End Select
        Return zeros
    End Function
End Class