Public Class AdminForm
    Private manageStudentAdmin As New ManageStudentAdmin
    Private Sub manageStudentButton_Click(sender As Object, e As EventArgs) Handles manageStudentButton.Click
        Me.Visible = False
        manageStudentAdmin.Visible = True
    End Sub

    Private Sub AdminForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

End Class