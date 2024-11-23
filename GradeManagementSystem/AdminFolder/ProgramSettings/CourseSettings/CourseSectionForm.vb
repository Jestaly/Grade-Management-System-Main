Public Class CourseSectionForm
    Private connector As New DatabaseConnector
    Private Sub CourseSectionForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
        ManageProgramAdmin.Visible = True
    End Sub
End Class