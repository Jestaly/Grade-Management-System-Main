Imports MySql.Data.MySqlClient

Public Class OfficialModifyProfessorForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyProfessorForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE faculty SET lname = '" & lastnameTextBox.Text & "', fname = '" & firstnameTextBox.Text & "', mname = '" & middlenameTextBox.Text & "', email = '" & emailTextBox.Text & "' WHERE id = " & trimmedProfID() & ";"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Modified Successfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Me.Visible = False
    End Sub

    Private Function trimmedProfID() As String
        Dim profID As String = profIDTextBox.Text
        profID = profID.Replace("-", "")
        Return profID
    End Function
End Class