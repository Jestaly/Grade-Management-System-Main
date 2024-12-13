﻿Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class CreateClassForm
    Private connector As New DatabaseConnector

    Private Sub setTimeAbb()
        Dim startTimeAbb As String = startTimePicker.Text.Chars(8) & startTimePicker.Text.Chars(9)
        Dim endTimeAbb As String = endTimePicker.Text.Chars(8) & endTimePicker.Text.Chars(9)
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO time_history VALUES ('" & getClassID() & "','" & startTimeAbb & "','" & endTimeAbb & "');"
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

    Private Sub createClassButton_Click(sender As Object, e As EventArgs) Handles createClassButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO class VALUES ('" & getClassID() & "','" & getProfessorID() & "','" & getCourseID() & "','" & getStartTime() & "','" & getEndTime() & "','" & classSeshComboBox.Text & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO class_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            setTimeAbb()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getClassID() As String
        Dim classID = classIDTextBox.Text.Replace("-", "")
        Return classID
    End Function

    Private Function getProfessorID() As String
        Dim selectedProf As String = professorComboBox.Text
        Dim profID As String = ""
        Try
            connector.query = "SELECT id AS ID, CONCAT(fname,' ',mname,' ',lname) AS 'Professor name' FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("Professor name").ToString IsNot Nothing And connector.reader("Professor name").ToString.Equals(selectedProf) Then
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

    Private Sub CreateClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), 270, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.AddLine(0, Me.Height - 40, 0, 40)
        p.CloseFigure()
        Me.Region = New Region(p)
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub

End Class