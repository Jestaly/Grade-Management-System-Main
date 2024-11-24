Imports MySql.Data.MySqlClient

Public Class AddStudentAccount
    Private connector As New DatabaseConnector
    Private Sub AddStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Function getStudID() As String
        Dim studID = studentIDTextBox.Text.Replace("-", "")
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
    Private Function birthDate() As String
        Dim birthday As String = birthCalendar.SelectionStart.Year.ToString & "-" & birthCalendar.SelectionStart.Month.ToString & "-" & birthCalendar.SelectionStart.Day.ToString
        Return birthday
    End Function

    Private Sub addStudentButton_Click(sender As Object, e As EventArgs) Handles addStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO student VALUES ('" & getStudID() & "','" & lastnameTextBox.Text & "','" & firstnameTextBox.Text & "','" & middlenameTextBox.Text & "','" & birthDate() & "','" & getProgramID() & "'," & yearComboBox.Text & ",'" & sectionComboBox.Text & "','" & "password" & "','" & emailTextBox.Text & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO student_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Student Added!")
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Erro")
        End Try

        firstnameTextBox.Clear()
        middlenameTextBox.Clear()
        lastnameTextBox.Clear()
        programComboBox.SelectedIndex = -1
        yearComboBox.SelectedIndex = -1
        sectionComboBox.SelectedIndex = -1
        departmentComboBox.SelectedIndex = -1
        emailTextBox.Clear()
        statusComboBox.SelectedIndex = -1

        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        firstnameTextBox.Clear()
        middlenameTextBox.Clear()
        lastnameTextBox.Clear()
        programComboBox.SelectedIndex = -1
        yearComboBox.SelectedIndex = -1
        sectionComboBox.SelectedIndex = -1
        departmentComboBox.SelectedIndex = -1
        emailTextBox.Clear()
        statusComboBox.SelectedIndex = -1
    End Sub

End Class