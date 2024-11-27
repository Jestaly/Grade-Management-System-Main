Public Class ModifyCourseForm
    Private officialModifyCourseForm As New OfficialModifyCourseForm
    Private Sub ModifyCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

    End Sub

    Private Sub makeOMCFChild()
        officialModifyCourseForm.TopLevel = False
        officialModifyCourseForm.Parent = Me
        CenterOMCF()
        officialModifyCourseForm.BringToFront()
    End Sub

    Private Sub CenterOMCF()
        Dim x As Integer = (Me.ClientSize.Width - officialModifyCourseForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - officialModifyCourseForm.Height) \ 2
        officialModifyCourseForm.Location = New Point(x, y)
    End Sub
End Class