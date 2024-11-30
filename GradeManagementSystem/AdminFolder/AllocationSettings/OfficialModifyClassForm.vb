Imports MySql.Data.MySqlClient

Public Class OfficialModifyClassForm
    Private connector As New DatabaseConnector
    Private Sub createClassButton_Click(sender As Object, e As EventArgs) Handles modifyClassButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE class SET professor_id = '" & getProfessorID() & "', course_id = '" & getCourseID() & "' WHERE class_id = '" & trimmedClassID() & "';"
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

    Private Function getProfessorID() As String
        Dim selectedProf As String = professorComboBox.Text
        Dim profID As String = ""
        Try
            connector.query = "SELECT id AS ID, CONCAT(fname,' ',mname,' ',lname) AS Professor FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("Professor").ToString IsNot Nothing And connector.reader("Professor").ToString.Equals(selectedProf) Then
                    profID = connector.reader("ID").ToString
                    connector.reader.Close()
                    Return profID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return profID
    End Function

    Private Function getCourseID() As String
        Dim selectedCourse As String = courseComboBox.Text
        Dim courseID As String = ""
        Try
            connector.query = "SELECT course_id AS 'Course ID', course_name AS Course FROM course;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("Course").ToString IsNot Nothing And connector.reader("Course").ToString.Equals(selectedCourse) Then
                    courseID = connector.reader("Course ID").ToString
                    connector.reader.Close()
                    Return courseID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return courseID
    End Function

    Private Function trimmedClassID() As String
        Dim classID As String = classIDTextBox.Text
        classID = classID.Replace("-", "")
        Return classID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class