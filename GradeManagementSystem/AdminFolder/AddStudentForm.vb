Imports MySql.Data.MySqlClient

Public Class AddStudentForm
    Private connector As DatabaseConnector
    Private Sub AddStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub addStudentButton_Click(sender As Object, e As EventArgs) Handles addStudentButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO student_info(fname,mname,lname,program,year,section,department,email,status) VALUES ('" & firstnameTextBox.Text & "','" & middlenameTextBox.Text & "','" & lastnameTextBox.Text & "','" & programComboBox.Text & "'," & yearComboBox.Text & ",'" & sectionComboBox.Text & "','" & departmentComboBox.Text & "','" & emailTextBox.Text & "','" & statusComboBox.Text & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Student Added!")
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
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

    Private Sub AddStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class