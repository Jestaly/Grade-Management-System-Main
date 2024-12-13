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
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("program_name").ToString IsNot Nothing And connector.reader("program_name").ToString.Equals(programComboBox.Text) Then
                    programID = connector.reader("program_id").ToString
                    connector.reader.Close()
                    Return programID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        connector.reader.Close()
        Return programID
    End Function

    Private Sub modifyStudentButton_Click(sender As Object, e As EventArgs) Handles modifyStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE student SET lname = '" & lastnameTextBox.Text & "', fname = '" & firstnameTextBox.Text & "', mname = '" & middlenameTextBox.Text & "', birthdate = '" & birthDate.Text & "', program_id = '" & getProgramID() & "', year = " & yearComboBox.Text & ", section = '" & sectionComboBox.Text & "', email = '" & emailTextBox.Text & "'  WHERE id = " & sidTextBox.Text & ";"
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

    Private Sub programComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        sectionComboBox.Items.Clear
        Dim selectedProgram = programComboBox.Text
        Dim numOfSection As Integer
        Try
            connector.connect.Open
            connector.query = "SELECT program_name,sections FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If selectedProgram.Equals(connector.reader("program_name").ToString) Then
                    numOfSection = Integer.Parse(connector.reader("sections").ToString)
                    Exit While
                End If
            End While
            connector.connect.Close
        Catch ex As MySqlException
            connector.connect.Close
            MessageBox.Show("Database Error")
        End Try

        Dim section = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}

        For i = 0 To numOfSection - 1
            sectionComboBox.Items.Add(section(i))
        Next
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub
End Class