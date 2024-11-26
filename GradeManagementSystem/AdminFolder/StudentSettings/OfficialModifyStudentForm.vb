Imports MySql.Data.MySqlClient
Public Class OfficialModifyStudentForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        programComboBox.Items.Clear()
        e.Cancel = True
        Me.Visible = False
    End Sub

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

    Private Function birthDate() As String
        Dim birthday As String = birthCalendar.SelectionStart.Year.ToString & "-" & birthCalendar.SelectionStart.Month.ToString & "-" & birthCalendar.SelectionStart.Day.ToString
        Return birthday
    End Function

    Private Sub modifyStudentButton_Click(sender As Object, e As EventArgs) Handles modifyStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE student SET lname = '" & lastnameTextBox.Text & "', fname = '" & firstnameTextBox.Text & "', mname = '" & middlenameTextBox.Text & "', birthdate = '" & birthDate() & "', program_id = '" & getProgramID() & "', year = " & yearComboBox.Text & ", section = '" & sectionComboBox.Text & "', email = '" & emailTextBox.Text & "'  WHERE id = " & sidTextBox.Text & ";"
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

    Private Sub OfficialModifyStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class