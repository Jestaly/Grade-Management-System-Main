Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ModifyStudentForm
    Private connector As New DatabaseConnector
    Private officialModifyStudentForm As New OfficialModifyStudentForm


    Private Sub ModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (studentExists()) Then
            connectToOMSF()
            loadProgram()
        End If
    End Sub

    Private Sub loadProgram()
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT * FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageProgramAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageProgramAdmin.dataView.Rows
                Dim programName As String = row.Cells("program_name").Value
                If (programName Is Nothing) Then
                    Exit For
                End If
                officialModifyStudentForm.programComboBox.Items.Add(programName)
            Next
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub connectToOMSF()
        Dim rowIndex As Integer = -1
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section,student.email FROM student LEFT JOIN program ON student.program_id = program.program_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageStudentAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageStudentAdmin.dataView.Rows
                If (row.Cells("id").Value IsNot Nothing AndAlso row.Cells("id").Value.ToString.Equals(trimmedStudID())) Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next
            getStudentData(rowIndex)
            officialModifyStudentForm.Visible = True
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub getStudentData(rowIndex As Integer)
        officialModifyStudentForm.sidTextBox.Text = ManageStudentAdmin.dataView(0, rowIndex).Value.ToString
        officialModifyStudentForm.lastnameTextBox.Text = ManageStudentAdmin.dataView(1, rowIndex).Value.ToString
        officialModifyStudentForm.firstnameTextBox.Text = ManageStudentAdmin.dataView(2, rowIndex).Value.ToString
        officialModifyStudentForm.middlenameTextBox.Text = ManageStudentAdmin.dataView(3, rowIndex).Value.ToString
        officialModifyStudentForm.birthCalendar.SetDate(ManageStudentAdmin.dataView(4, rowIndex).Value)
        officialModifyStudentForm.programComboBox.Text = ManageStudentAdmin.dataView(5, rowIndex).Value.ToString
        officialModifyStudentForm.yearComboBox.Text = ManageStudentAdmin.dataView(6, rowIndex).Value.ToString
        officialModifyStudentForm.sectionComboBox.Text = ManageStudentAdmin.dataView(7, rowIndex).Value.ToString
        officialModifyStudentForm.emailTextBox.Text = ManageStudentAdmin.dataView(8, rowIndex).Value.ToString
    End Sub

    Public Function getStudentID() As Integer
        Dim getID = Integer.Parse(studentIDTextBox.Text)
        Return getID
    End Function

    Private Function trimmedStudID() As String
        Dim studID = studentIDTextBox.Text.Replace("-", "")
        Return studID
    End Function

    Private Function studentExists() As Boolean
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section FROM student LEFT JOIN program ON student.program_id = program.program_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageStudentAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageStudentAdmin.dataView.Rows
                If (row.Cells("id").Value IsNot Nothing AndAlso row.Cells("id").Value.ToString.Equals(trimmedStudID())) Then
                    connector.connect.Close()
                    Return True
                End If
            Next
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        MessageBox.Show("Student not Found.")
        Return False
    End Function

End Class