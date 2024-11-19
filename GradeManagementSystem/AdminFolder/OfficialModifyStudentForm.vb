Imports MySql.Data.MySqlClient
Public Class OfficialModifyStudentForm
    Private connector As New DatabaseConnector
    Public row As Integer
    Private Sub OfficialModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub OfficialModifyStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If (Me.Visible) Then
                connector.connect.Open()
                connector.dataTable.Clear()
                connector.query = "SELECT * FROM student_info;"
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.dataAdapter.SelectCommand = connector.command
                connector.dataAdapter.Fill(connector.dataTable)
                ManageStudentAdmin.dataView.DataSource = connector.dataTable

                firstnameTextBox.Text = ManageStudentAdmin.dataView(1, row).Value
                middlenameTextBox.Text = ManageStudentAdmin.dataView(2, row).Value
                connector.connect.Close()
                connector.command.Parameters.Clear()
                MessageBox.Show("this form is visible")
            End If
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("End of Records")
        End Try
        connector.connect.Close()
        connector.command.Parameters.Clear()
    End Sub
End Class