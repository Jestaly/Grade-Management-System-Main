Imports MySql.Data.MySqlClient

Public Class EnrollStudentForm
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub enrollButton_Click(sender As Object, e As EventArgs) Handles enrollButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO enrollment VALUES ('" & getEnrollmentID() & "','" & getStudentID() & "','" & enrollmentDate.Text & "','" & getClassID() & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO enrollment_count_history VALUES ();"
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

    Private Function getEnrollmentID() As String
        Dim enrollmentID = enrollmentIDTextBox.Text.Replace("-", "")
        Return enrollmentID
    End Function

    Private Function getClassID() As String
        Dim classID = classComboBox.Text.Replace("-", "")
        Return classID
    End Function

    Private Function getStudentID() As String
        Dim selectedStudent As String = studentComboBox.Text
        Dim studentID As String = ""
        Try
            connector.query = "SELECT id AS ID, CONCAT(fname,' ',mname,' ',lname) AS 'Student name' FROM student;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("Student name").ToString IsNot Nothing And connector.reader("Student name").ToString.Equals(selectedStudent) Then
                    studentID = connector.reader("ID").ToString
                    connector.reader.Close()
                    Return studentID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return studentID
    End Function

End Class