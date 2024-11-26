Imports MySql.Data.MySqlClient

Public Class CourseSectionForm
    Private connector As New DatabaseConnector
    Private addCourseForm As New AddCourseForm
    Private modifyCourseForm As New ModifyCourseForm
    Private Sub CourseSectionForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
        ManageProgramAdmin.Visible = True
    End Sub

    Private Sub addCourseButton_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click
        Dim cCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM course_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            cCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addCourseForm.courseIDLabel.Text = "C" & "-" & getZeros(cCount) & (cCount + 1)
        addCourseForm.Visible = True
    End Sub

    Private Function getZeros(cCount As Integer) As String
        Dim zeros As String = "000"
        Select Case cCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub modifyCourseButton_Click(sender As Object, e As EventArgs) Handles modifyCourseButton.Click
        modifyCourseForm.Visible = True
    End Sub
End Class