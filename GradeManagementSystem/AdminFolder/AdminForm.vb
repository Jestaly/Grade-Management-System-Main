Public Class AdminForm
    Private manageStudentAdmin As New ManageStudentAdmin
    Private manageProfessorAdmin As New ManageProfessorAdmin
    Private manageProgramAdmin As New ManageProgramAdmin
    Private manageDepartmentAdmin As New ManageDepartmentAdmin
    Private allocationManagerAdmin As New AllocationManagerAdminvb
    Private Sub manageStudentButton_Click(sender As Object, e As EventArgs) Handles manageStudentButton.Click
        manageStudentAdmin.Visible = True
    End Sub

    'Private Sub AdminForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    'e.Cancel = True
    'Me.Visible = False
    'End Sub

    Private Sub manageProfessor_Click(sender As Object, e As EventArgs) Handles manageProfessor.Click
        manageProfessorAdmin.Visible = True
    End Sub

    Private Sub manageProgramButton_Click(sender As Object, e As EventArgs) Handles manageProgramButton.Click
        manageProgramAdmin.Visible = True
    End Sub

    Private Sub manageDepartmentButton_Click(sender As Object, e As EventArgs) Handles manageDepartmentButton.Click
        manageDepartmentAdmin.Visible = True
    End Sub

    Private Sub dashboardButton_Click(sender As Object, e As EventArgs) Handles dashboardButton.Click
        AdminDashboard.Show()
        Hide()
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        End
    End Sub

    Private Sub allocationManager_Click(sender As Object, e As EventArgs) Handles allocationManager.Click
        allocationManagerAdmin.Visible = True
    End Sub
End Class