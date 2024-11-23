Public Class AdminForm
    Private manageStudentAdmin As New ManageStudentAdmin
    Private manageProfessorAdmin As New ManageProfessorAdmin
    Private manageProgramAdmin As New ManageProgramAdmin
    Private Sub manageStudentButton_Click(sender As Object, e As EventArgs) Handles manageStudentButton.Click
        Me.Visible = False
        manageStudentAdmin.Visible = True
    End Sub

    Private Sub AdminForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub manageProfessor_Click(sender As Object, e As EventArgs) Handles manageProfessor.Click
        Me.Visible = False
        manageProfessorAdmin.Visible = True
    End Sub

    Private Sub manageProgramButton_Click(sender As Object, e As EventArgs) Handles manageProgramButton.Click
        manageProgramAdmin.Visible = True
        Me.Visible = False
    End Sub
End Class