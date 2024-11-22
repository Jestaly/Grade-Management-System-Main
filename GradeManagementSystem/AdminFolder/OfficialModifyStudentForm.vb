Imports MySql.Data.MySqlClient
Public Class OfficialModifyStudentForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub modifyStudentButton_Click(sender As Object, e As EventArgs) Handles modifyStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE student_info SET fname = '" & firstnameTextBox.Text & "', mname = '" & middlenameTextBox.Text & "', lname = '" & lastnameTextBox.Text & "', program = '" & programComboBox.Text & "', year = " & yearComboBox.Text & ", section = '" & sectionComboBox.Text & "', department = '" & departmentComboBox.Text & "', email = '" & emailTextBox.Text & "', status = '" & statusComboBox.Text & "' WHERE sid = " & sidTextBox.Text & ";"
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

End Class