Imports MySql.Data.MySqlClient

Public Class OfficialModifyCourseForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub modifyCourseButton_Click(sender As Object, e As EventArgs) Handles modifyCourseButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE course SET course_name = '" & courseNameTextBox.Text & "', units = " & unitTextBox.Text & " WHERE course_id = '" & trimmedCourseID() & "';"
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

    Private Function trimmedCourseID() As String
        Dim courseID As String = courseIDTextBox.Text
        courseID = courseID.Replace("-", "")
        Return courseID
    End Function
End Class