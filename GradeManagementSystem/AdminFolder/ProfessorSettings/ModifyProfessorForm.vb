Imports MySql.Data.MySqlClient

Public Class ModifyProfessorForm
    Private connector As New DatabaseConnector
    Private officialModifyProfessorForm As New OfficialModifyProfessorForm

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (professorExists()) Then
            Me.Visible = False
            makeOMPFFChild()
            officialModifyProfessorForm.Visible = True
        End If
    End Sub

    Private Function professorExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("id").ToString.Equals(trimmedProfID) Then
                    officialModifyProfessorForm.profIDTextBox.Text = connector.reader("id").ToString
                    officialModifyProfessorForm.lastnameTextBox.Text = connector.reader("lname").ToString
                    officialModifyProfessorForm.firstnameTextBox.Text = connector.reader("fname").ToString
                    officialModifyProfessorForm.middlenameTextBox.Text = connector.reader("mname").ToString
                    officialModifyProfessorForm.emailTextBox.Text = connector.reader("email").ToString
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
        MessageBox.Show("Professor not Found.")
        Return False
    End Function

    Private Function trimmedProfID() As String
        Dim profID = profIDTextBox.Text.Replace("-", "")
        Return profID
    End Function

    Private Sub ModifyProfessorForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
    Private Sub makeOMPFFChild()
        officialModifyProfessorForm.TopLevel = False
        officialModifyProfessorForm.Parent = Me.Parent
        CenterOMPFF()
        officialModifyProfessorForm.BringToFront()
    End Sub

    Private Sub CenterOMPFF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyProfessorForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyProfessorForm.Height) \ 2
        officialModifyProfessorForm.Location = New Point(x, y)
    End Sub
End Class
