Imports MySql.Data.MySqlClient

Public Class ModifyProgramForm
    Private connector As New DatabaseConnector
    Private officialModifyProgramForm As New OfficialModifyProgramForm
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (programExists()) Then
            Me.Visible = False
            makeOMPFChild()
            officialModifyProgramForm.Visible = True
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
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("program_id").ToString.Equals(trimmedProgID) Then
                    officialModifyProgramForm.programIDTextBox.Text = connector.reader("program_id").ToString
                    officialModifyProgramForm.programnameTextBox.Text = connector.reader("program_name").ToString
                    officialModifyProgramForm.yearAddedTextBox.Text = connector.reader("year_added").ToString
                    officialModifyProgramForm.sectionBox.Text = connector.reader("sections").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return True
                End If
            End While
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.reader.Close()
        connector.connect.Close()
        MessageBox.Show("Program not Found.")
        Return False
    End Function

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