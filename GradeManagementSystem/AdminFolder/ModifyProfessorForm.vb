Imports MySql.Data.MySqlClient

Public Class ModifyProfessorForm
    Private connector As New DatabaseConnector

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim rowIndex As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM faculty;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageProfessorAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageProfessorAdmin.dataView.Rows
                If (row.Cells("id").Value IsNot Nothing AndAlso row.Cells("id").Value.ToString.Equals(trimmedProfID())) Then
                    rowIndex = row.Index
                Else
                    rowIndex = -1
                End If
            Next

            getProfessorData(rowIndex)
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub getProfessorData(rowIndex As Integer)


    End Sub

    Private Function trimmedProfID() As String
        Dim profID = profIDTextBox.Text.Replace("-", "")
        Return profID
    End Function

    Private Sub ModifyProfessorForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
End Class
