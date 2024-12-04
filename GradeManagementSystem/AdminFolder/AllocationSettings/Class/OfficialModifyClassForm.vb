Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class OfficialModifyClassForm
    Private connector As New DatabaseConnector
    Private Sub modifyClassButton_Click(sender As Object, e As EventArgs) Handles modifyClassButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE class SET professor_id = '" & getProfessorID() & "', course_id = '" & getCourseID() & "', time_start = '" & getStartTime() & "', time_end = '" & getEndTime() & "', day = '" & classSeshComboBox.Text & "' WHERE class_id = '" & trimmedClassID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Modified Successfully!")
            connector.connect.Close()
            setTimeAbb()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Me.Visible = False
    End Sub

    Private Sub setTimeAbb()
        Dim startTimeAbb As String = startTimePicker.Text.Chars(8) & startTimePicker.Text.Chars(9)
        Dim endTimeAbb As String = endTimePicker.Text.Chars(8) & endTimePicker.Text.Chars(9)
        Try
            connector.connect.Open()
            connector.query = "UPDATE time_history SET start_abbreviation = '" & startTimeAbb & "', end_abbreviation = '" & endTimeAbb & "' WHERE class_id = '" & trimmedClassID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getStartTime() As String
        Dim startTime As String = startTimePicker.Text
        startTime = startTime.Replace("pm", "").Replace("am", "").Trim
        Return startTime
    End Function
    Private Function getEndTime() As String
        Dim endTime As String = endTimePicker.Text
        endTime = endTime.Replace("pm", "").Replace("am", "").Trim
        Return endTime
    End Function

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