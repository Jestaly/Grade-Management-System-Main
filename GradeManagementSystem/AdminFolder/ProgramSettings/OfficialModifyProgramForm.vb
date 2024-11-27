﻿Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class OfficialModifyProgramForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Function getDepartmentID() As String
        Dim selectedDept As String = departmentComboBox.Text
        Dim deptID As String = ""
        Try
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("dept_name").ToString IsNot Nothing And connector.reader("dept_name").ToString.Equals(selectedDept) Then
                    deptID = connector.reader("dept_id").ToString
                    connector.reader.Close()
                    Return deptID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return deptID
    End Function

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE program SET program_name = '" & programnameTextBox.Text & "', year_added = '" & yearAddedTextBox.Text & "', sections = " & sectionBox.Text & ", dept_id = '" & getDepartmentID() & "' WHERE program_id = '" & trimmedProgID() & "';"
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