Imports MySql.Data.MySqlClient

Public Class AddProfessorAccount
    Private connector As New DatabaseConnector
    Private Sub addProfessorButton_Click(sender As Object, e As EventArgs) Handles addProfessorButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO professor(id,lname,fname,mname,email,dept_id) VALUES ('" & getProfID() & "','" & lastnameTextBox.Text & "','" & firstnameTextBox.Text & "','" & middlenameTextBox.Text & "','" & emailTextBox.Text & "','" & getDepartmentID() & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO prof_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
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
    Private Function getProfID() As String
        Dim profID = professorIDLabel.Text.Replace("-", "")
        Return profID
    End Function

    Private Sub AddProfessorAccount_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class