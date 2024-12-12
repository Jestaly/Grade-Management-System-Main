Public Class AddItemForm
    Private addQuizForm As New AddQuizForm
    Private addProjectForm As New AddProjectForm
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub addQuizButton_Click(sender As Object, e As EventArgs) Handles addQuizButton.Click
        Me.Visible = False
        addQuizForm.Visible = True
    End Sub

    Private Sub addProjectButton_Click(sender As Object, e As EventArgs) Handles addProjectButton.Click
        Me.Visible = False
        addProjectForm.Visible = True
    End Sub

    Private Sub makeAPFChild()
        addProjectForm.TopLevel = False
        addProjectForm.Parent = Me.Parent
        CenterAPF()
        addProjectForm.BringToFront()
    End Sub

    Private Sub CenterAPF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - addProjectForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - addProjectForm.Height) \ 2
        addProjectForm.Location = New Point(x, y)
    End Sub

    Private Sub makeAQFChild()
        addQuizForm.TopLevel = False
        addQuizForm.Parent = Me.Parent
        CenterAQF()
        addQuizForm.BringToFront()
    End Sub

    Private Sub CenterAQF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - addQuizForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - addQuizForm.Height) \ 2
        addQuizForm.Location = New Point(x, y)
    End Sub

    Private Sub AddItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeAPFChild()
        makeAQFChild()
    End Sub
End Class