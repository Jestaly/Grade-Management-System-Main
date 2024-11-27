Imports MySql.Data.MySqlClient

Public Class OfficialModifyProgramForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE program SET program_name = '" & programnameTextBox.Text & "', year_added = '" & yearAddedTextBox.Text & "', sections = " & sectionBox.Text & " WHERE program_id = '" & trimmedProgID() & "';"
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
    Private Function trimmedProgID() As String
        Dim progID As String = programIDTextBox.Text
        progID = progID.Replace("-", "")
        Return progID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class