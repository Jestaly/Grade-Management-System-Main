Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class AddStudentAccount
    Private connector As New DatabaseConnector
    Private mail As New Mail
    Private Sub AddStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Function getStudID() As String
        Dim studID = SIDTextBox.Text.Replace("-", "")
        Return studID
    End Function

    Private Function getProgramID() As String
        Dim programID As String = ""
        Try
            connector.query = "SELECT * FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageProgramAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageProgramAdmin.dataView.Rows
                If (row.Cells("program_name").Value IsNot Nothing AndAlso row.Cells("program_name").Value.ToString.Equals(programComboBox.Text)) Then
                    programID = row.Cells("program_id").Value.ToString
                    Return programID
                End If
            Next
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return programID
    End Function
    Private Function getEmail() As String
        Dim email As String = emailTextBox.Text.Trim
        Return email
    End Function

    Private Function getPassCode() As String
        Dim passCode As String = mail.mailMe(getEmail)
        Return passCode
    End Function

    Private Sub addStudentButton_Click(sender As Object, e As EventArgs) Handles addStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO student VALUES ('" & getStudID() & "','" & lastnameTextBox.Text & "','" & firstnameTextBox.Text & "','" & middlenameTextBox.Text & "','" & birthDate.Text & "','" & getProgramID() & "'," & yearComboBox.Text & ",'" & sectionComboBox.Text & "','" & getPassCode() & "','" & getEmail() & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO student_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
            MessageBox.Show("Student Added!")
        Catch ex As MySqlException
            connector.connect.Close()
            'problem
            MessageBox.Show("Database Error")
        End Try

        firstnameTextBox.Clear()
        middlenameTextBox.Clear()
        lastnameTextBox.Clear()
        programComboBox.SelectedIndex = -1
        yearComboBox.SelectedIndex = -1
        sectionComboBox.SelectedIndex = -1
        emailTextBox.Clear()

        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        firstnameTextBox.Clear()
        middlenameTextBox.Clear()
        lastnameTextBox.Clear()
        programComboBox.SelectedIndex = -1
        yearComboBox.SelectedIndex = -1
        sectionComboBox.SelectedIndex = -1
        emailTextBox.Clear()
    End Sub


    Private Sub programComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles programComboBox.SelectedIndexChanged
        sectionComboBox.Items.Clear()
        Dim selectedProgram As String = programComboBox.Text
        Dim numOfSection As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT program_name,sections FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If selectedProgram.Equals(connector.reader("program_name").ToString) Then
                    numOfSection = Integer.Parse(connector.reader("sections").ToString())
                    Exit While
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try

        Dim section() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}

        For i As Integer = 0 To numOfSection - 1
            sectionComboBox.Items.Add(section(i))
        Next
    End Sub

    Private Sub AddStudentAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub firstnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles firstnameTextBox.TextChanged

    End Sub
End Class