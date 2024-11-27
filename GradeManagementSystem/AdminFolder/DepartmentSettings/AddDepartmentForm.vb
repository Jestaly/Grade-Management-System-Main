Imports MySql.Data.MySqlClient

Public Class AddDepartmentForm
    Private connector As New DatabaseConnector
    Private Sub AddDepartmentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub addDepartmentButton_Click(sender As Object, e As EventArgs) Handles addDepartmentButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO department VALUES ('" & getDepartmentID() & "','" & departmentHeadTextBox.Text & "','" & departmentNameTextBox.Text & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO dept_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            connector.command.Parameters.Clear()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getDepartmentID() As String
        Dim programID = departmentIDLabel.Text.Replace("-", "")
        Return programID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class