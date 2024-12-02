Imports MySql.Data.MySqlClient

Public Class AddProgramForm
    Private connector As New DatabaseConnector
    Private Sub addProgramButton_Click(sender As Object, e As EventArgs) Handles addProgramButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO program VALUES ('" & getProgramID() & "','" & programNameTextBox.Text & "','" & dateAddedTextBox.Text & "'," & sectionBox.Text & ", '" & getDepartmentID() & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO prog_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            connector.command.Parameters.Clear()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
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

    Private Function getProgramID() As String
        Dim programID = programIDTextBox.Text.Replace("-", "")
        Return programID
    End Function

    Private Sub AddProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class