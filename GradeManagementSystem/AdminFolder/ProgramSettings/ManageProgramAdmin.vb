Imports MySql.Data.MySqlClient

Public Class ManageProgramAdmin
    Private connector As New DatabaseConnector
    Private courseSectionForm As New CourseSectionForm
    Private addProgramForm As New AddProgramForm
    Private modifyProgramForm As New ModifyProgramForm
    Private Sub ManageProgramAdmin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT * FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub courseSectionButton_Click(sender As Object, e As EventArgs) Handles courseSectionButton.Click
        courseSectionForm.Visible = True
        Me.Visible = False
    End Sub

    Private Sub addProgramButton_Click(sender As Object, e As EventArgs) Handles addProgramButton.Click
        Dim pCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM prog_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            pCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addProgramForm.programIDLabel.Text = "P" & "-" & getZeros(pCount) & (pCount + 1)
        addProgramForm.Visible = True
    End Sub

    Private Function getZeros(pCount As Integer) As String
        Dim zeros As String = "000"
        Select Case pCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub modifyProgramButton_Click(sender As Object, e As EventArgs) Handles modifyProgramButton.Click
        modifyProgramForm.Visible = True
    End Sub

End Class