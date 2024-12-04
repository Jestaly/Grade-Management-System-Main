Public Class AddItemForm
    Private addQuizForm As New AddQuizForm
    Private addProjectForm As New AddProjectForm
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub addQuizButton_Click(sender As Object, e As EventArgs) Handles addQuizButton.Click
        addQuizForm.Visible = True
    End Sub

    Private Sub addProjectButton_Click(sender As Object, e As EventArgs) Handles addProjectButton.Click
        addProjectForm.Visible = True
    End Sub
End Class