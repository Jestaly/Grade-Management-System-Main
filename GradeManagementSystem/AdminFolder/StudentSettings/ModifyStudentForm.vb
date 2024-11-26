Imports MySql.Data.MySqlClient

Public Class ModifyStudentForm
    Private connector As New DatabaseConnector
    Private officialModifyStudentForm As New OfficialModifyStudentForm


    Private Sub ModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        officialModifyStudentForm.programComboBox.Items.Clear()
        If (studentExists()) Then
            loadProgram()
            connectToOMSF()
        End If
    End Sub

    Private Sub loadProgram()
        Try
            connector.connect.Open()
            connector.query = "SELECT program_name FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim programName As String = connector.reader("program_name").ToString()
                If Not String.IsNullOrEmpty(programName) Then
                    officialModifyStudentForm.programComboBox.Items.Add(programName)
                End If
            End While
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
            connector.connect.Close()
            getStudentData(rowIndex)
            officialModifyStudentForm.Visible = True
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
        officialModifyStudentForm.emailTextBox.Text = ManageStudentAdmin.dataView(8, rowIndex).Value.ToString
        getSectionData()
        officialModifyStudentForm.sectionComboBox.Text = ManageStudentAdmin.dataView(7, rowIndex).Value.ToString
    End Sub

    Private Sub getSectionData()
        Dim selectedProgram As String = officialModifyStudentForm.programComboBox.Text
        Dim numOfSection As Integer
        Try
            connector.connect.Open()
            officialModifyStudentForm.sectionComboBox.Items.Clear()
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
            officialModifyStudentForm.sectionComboBox.Items.Add(section(i))
        Next
    End Sub
    Private Function getStudentID() As Integer
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