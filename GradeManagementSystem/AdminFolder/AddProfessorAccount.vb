Imports MySql.Data.MySqlClient

Public Class AddProfessorAccount
    Private connector As New DatabaseConnector
    Private Sub addProfessorButton_Click(sender As Object, e As EventArgs) Handles addProfessorButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO faculty VALUES ('" & getProfID() & "','" & lastnameTextBox.Text & "','" & firstnameTextBox.Text & "','" & middlenameTextBox.Text & "','" & emailTextBox.Text & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getProfID() As String
        Dim profID = professorIDLabel.Text.Replace("-", "")
        Return profID
    End Function

    Private Sub AddProfessorAccount_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
End Class