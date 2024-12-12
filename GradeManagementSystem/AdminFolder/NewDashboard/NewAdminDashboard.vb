Imports System.Runtime.InteropServices

Public Class NewAdminDashboard

    <DllImport("user32.dll")>
    Private Shared Function SetWindowRgn(hWnd As IntPtr, hRgn As IntPtr, bRedraw As Boolean) As Integer
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
    End Function
    Private Sub NewAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cornerRadius As Integer = 30
        Dim hRgn As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, cornerRadius, cornerRadius)
        SetWindowRgn(Me.Handle, hRgn, True)
        switchPanel(NewOfficialDashboard)
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub dashboardbttn_Click(sender As Object, e As EventArgs) Handles dashboardbttn.Click

        Dim dashboard As New NewOfficialDashboard()
        switchPanel(dashboard)
        NewOfficialDashboard.ResetState()
    End Sub

    Private Sub profilebttn_Click(sender As Object, e As EventArgs) Handles profilebttn.Click
        switchPanel(AdminProfile)
    End Sub

    Private Sub studentregistrybttn_Click(sender As Object, e As EventArgs) Handles studentregistrybttn.Click
        switchPanel(ManageStudentAdmin)
    End Sub

    Private Sub professorregistrybttn_Click(sender As Object, e As EventArgs) Handles professorregistrybttn.Click
        switchPanel(ManageProfessorAdmin)
    End Sub

    Private Sub programmanagementbttn_Click(sender As Object, e As EventArgs) Handles programmanagementbttn.Click
        switchPanel(ManageProgramAdmin)
    End Sub

    Private Sub departmentmanagementbttn_Click(sender As Object, e As EventArgs) Handles departmentmanagementbttn.Click
        switchPanel(ManageDepartmentAdmin)
    End Sub

    Private Sub allocationmanagerbttn_Click(sender As Object, e As EventArgs) Handles allocationmanagerbttn.Click
        switchPanel(AllocationManagerAdminvb)
    End Sub

    Private Sub settingsbttn_Click(sender As Object, e As EventArgs) Handles settingsbttn.Click

    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
