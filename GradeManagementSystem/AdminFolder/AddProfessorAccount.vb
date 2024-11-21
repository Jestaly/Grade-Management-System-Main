Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class AddProfessorAccount
    Private connector As New DatabaseConnector
    Private Sub addProfessorButton_Click(sender As Object, e As EventArgs) Handles addProfessorButton.Click
        professorIDLabel.Text = idIncrementer()

        Try
            connector.connect.Open()
            connector.query = "INSERT INTO faculty VALUES ()"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function idIncrementer() As String
        Dim idInt As Integer
        'Try
        'connector.connect.Open()

        'connector.connect.Close()
        'Catch ex As MySqlException
        'connector.connect.Close()
        'MessageBox.Show("Database Error at idIncrementer")
        'End Try

        idInt += 20000000
        Dim year As String = DateAndTime.Now.Year
        Dim idYearStr = year.Substring(2, 4)
        Dim idYearInt = Integer.Parse(idYearStr)
        idYearInt = idYearInt * 100000




        Return ""
    End Function
End Class