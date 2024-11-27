Imports MySql.Data.MySqlClient
Public Class AddCourseForm
    Private connector As New DatabaseConnector
    Private Sub AddCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub addCourseButton_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO course VALUES ('" & getCourseID() & "','" & courseNameTextBox.Text & "'," & unitTextBox.Text & ");"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO course_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getCourseID() As String
        Dim courseID = courseIDLabel.Text.Replace("-", "")
        Return courseID
    End Function
End Class