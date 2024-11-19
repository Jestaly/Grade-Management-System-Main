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
        End If
    End Sub

    Private Sub connectToOMSF()
        Try
            Dim row As Integer
            row = getStudentData() - 1
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT * FROM student_info;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageStudentAdmin.dataView.DataSource = connector.dataTable

            officialModifyStudentForm.firstnameTextBox.Text = ManageStudentAdmin.dataView(1, row).Value
            officialModifyStudentForm.middlenameTextBox.Text = ManageStudentAdmin.dataView(2, row).Value
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("this form is visible")
            officialModifyStudentForm.Visible = True
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("End of Records")
        End Try
        connector.connect.Close()
        connector.command.Parameters.Clear()
    End Sub

    Public Function getStudentData() As Integer
        Dim getID = Integer.Parse(studentIDTextBox.Text)
        Return getID
    End Function

    Private Function studentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) FROM student_info WHERE sid = ?sid;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.Parameters.AddWithValue("?sid", studentIDTextBox.Text)
            Dim Count = Convert.ToInt32(connector.command.ExecuteScalar())
            If (Count > 0) Then
                connector.connect.Close()
                connector.command.Parameters.Clear()
                Return True
            End If
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        connector.command.Parameters.Clear()
        MessageBox.Show("Student not found.")
        Return False
    End Function

End Class