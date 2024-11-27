Imports MySql.Data.MySqlClient

Public Class ModifyProgramForm
    Private connector As New DatabaseConnector
    Private officialModifyProgramForm As New OfficialModifyProgramForm
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (programExists()) Then
            connectToOMPRF()
        End If
    End Sub

    Private Sub ModifyProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
    Private Function programExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageProgramAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageProgramAdmin.dataView.Rows
                If (row.Cells("program_id").Value IsNot Nothing AndAlso row.Cells("program_id").Value.ToString.Equals(trimmedProgID())) Then
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
        MessageBox.Show("Program not Found.")
        Return False
    End Function
    Private Sub connectToOMPRF()
        Dim rowIndex As Integer = -1
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageProgramAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageProgramAdmin.dataView.Rows
                If (row.Cells("program_id").Value IsNot Nothing AndAlso row.Cells("program_id").Value.ToString.Equals(trimmedProgID())) Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next
            getProgramData(rowIndex)
            Me.Visible = False
            makeOMPFChild()
            officialModifyProgramForm.Visible = True
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub getProgramData(rowIndex As Integer)
        officialModifyProgramForm.programIDTextBox.Text = ManageProgramAdmin.dataView(0, rowIndex).Value
        officialModifyProgramForm.programnameTextBox.Text = ManageProgramAdmin.dataView(1, rowIndex).Value
        officialModifyProgramForm.yearAddedTextBox.Text = ManageProgramAdmin.dataView(2, rowIndex).Value
        officialModifyProgramForm.sectionBox.Text = ManageProgramAdmin.dataView(3, rowIndex).Value
    End Sub

    Private Function trimmedProgID() As String
        Dim progID = programIDTextBox.Text.Replace("-", "")
        Return progID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
    Private Sub makeOMPFChild()
        officialModifyProgramForm.TopLevel = False
        officialModifyProgramForm.Parent = Me.Parent
        CenterOMPF()
        officialModifyProgramForm.BringToFront()
    End Sub

    Private Sub CenterOMPF()
        Dim x As Integer = (Me.Parent.Width - officialModifyProgramForm.Width) \ 2
        Dim y As Integer = (Me.Parent.Height - officialModifyProgramForm.Height) \ 2
        officialModifyProgramForm.Location = New Point(x, y)
    End Sub
End Class