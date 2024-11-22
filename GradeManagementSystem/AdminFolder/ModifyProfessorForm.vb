Imports MySql.Data.MySqlClient

Public Class ModifyProfessorForm
    Private connector As New DatabaseConnector
    Private officialModifyProfessorForm As New OfficialModifyProfessorForm

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (professorExists()) Then
            connectToOMPF()
        End If
    End Sub

    Private Sub connectToOMPF()
        Dim rowIndex As Integer = -1
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
                    Exit For
                End If
            Next
            getProfessorData(rowIndex)
            officialModifyProfessorForm.Visible = True
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function professorExists() As Boolean
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
                    connector.connect.Close()
                    Return True
                End If
            Next
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        MessageBox.Show("Professor not Found.")
        Return False
    End Function

    Private Sub getProfessorData(rowIndex As Integer)
        officialModifyProfessorForm.profIDTextBox.Text = ManageProfessorAdmin.dataView(0, rowIndex).Value
        officialModifyProfessorForm.lastnameTextBox.Text = ManageProfessorAdmin.dataView(1, rowIndex).Value
        officialModifyProfessorForm.firstnameTextBox.Text = ManageProfessorAdmin.dataView(2, rowIndex).Value
        officialModifyProfessorForm.middlenameTextBox.Text = ManageProfessorAdmin.dataView(3, rowIndex).Value
        officialModifyProfessorForm.emailTextBox.Text = ManageProfessorAdmin.dataView(4, rowIndex).Value
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
