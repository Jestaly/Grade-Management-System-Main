﻿Imports MySql.Data.MySqlClient

Public Class OfficialModifyEnrollStudentFormvb
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub modifyEnrollButton_Click(sender As Object, e As EventArgs) Handles modifyEnrollButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE enrollment SET student_id = '" & getStudentID() & "', enrollment_date = '" & enrollmentDate.Text & "', class_id = '" & trimmedClassID() & "' WHERE enrollment_id = '" & trimmedEnrollmentID() & "';"
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

    Private Function getStudentID() As String
        Dim selectedStudent As String = studentComboBox.Text
        Dim studentID As String = ""
        Try
            connector.query = "SELECT id AS ID, CONCAT(fname,' ',mname,' ',lname) AS Student FROM student;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("Student").ToString IsNot Nothing And connector.reader("Student").ToString.Equals(selectedStudent) Then
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

    Private Function trimmedClassID() As String
        Dim classID As String = classComboBox.Text
        classID = classID.Replace("-", "")
        Return classID
    End Function

    Private Function trimmedEnrollmentID() As String
        Dim enrollmentID As String = enrollmentIDTextBox.Text
        enrollmentID = enrollmentID.Replace("-", "")
        Return enrollmentID
    End Function

    Private Sub classComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classComboBox.SelectedIndexChanged
        Dim selectedClass As String = trimmedClassID()
        Try
            connector.connect.Open()
            connector.query = "SELECT class_id,CONCAT(professor.fname,' ',professor.mname,' ',professor.lname) AS Professor, course.course_name AS Course FROM class LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read()
                If (connector.reader("class_id").ToString IsNot Nothing And connector.reader("class_id").ToString.Equals(selectedClass)) Then
                    showProfessorTextBox.Text = connector.reader("Professor").ToString
                    showCourseTextBox.Text = connector.reader("Course").ToString
                    Exit While
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
End Class