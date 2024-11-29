Imports MySql.Data.MySqlClient
Public Class AllocationManagerAdminvb
    Private connector As New DatabaseConnector
    Private gradeSectionForm As New GradeSectionForm
    Private Sub AllocationManagerAdminvb_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub gradeSectionButton_Click(sender As Object, e As EventArgs) Handles gradeSectionButton.Click
        Me.Visible = False
        gradeSectionForm.Visible = True
    End Sub
End Class