Imports MySql.Data.MySqlClient

Public Class ModifyCourseForm
    Private connector As New DatabaseConnector
    Private officialModifyCourseForm As New OfficialModifyCourseForm
    Private Sub ModifyCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (courseExists()) Then
            Me.Visible = False
            makeOMCFChild()
            officialModifyCourseForm.Visible = True
        End If
    End Sub

    Private Function courseExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM course;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("course_id").ToString.Equals(trimmedCourseID) Then
                    officialModifyCourseForm.courseIDTextBox.Text = connector.reader("course_id").ToString
                    officialModifyCourseForm.courseNameTextBox.Text = connector.reader("course_name").ToString
                    officialModifyCourseForm.unitTextBox.Text = connector.reader("units").ToString
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
        MessageBox.Show("Course not Found.")
        Return False
    End Function

    Private Function trimmedCourseID() As String
        Dim courseID = courseIDTextBox.Text.Replace("-", "")
        Return courseID
    End Function

    Private Sub makeOMCFChild()
        officialModifyCourseForm.TopLevel = False
        officialModifyCourseForm.Parent = Me.Parent
        CenterOMCF()
        officialModifyCourseForm.BringToFront()
    End Sub

    Private Sub CenterOMCF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyCourseForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyCourseForm.Height) \ 2
        officialModifyCourseForm.Location = New Point(x, y)
    End Sub
End Class