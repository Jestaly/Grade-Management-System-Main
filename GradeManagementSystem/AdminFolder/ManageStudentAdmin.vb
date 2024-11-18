Public Class ManageStudentAdmin
    Dim addStudentForm As New AddStudentForm
    Private Sub addStudent_Click(sender As Object, e As EventArgs) Handles addStudent.Click
        addStudentForm.Visible = True
    End Sub

    Private Sub ManageStudentAdmin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub


End Class