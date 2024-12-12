Imports System.Runtime.InteropServices

Public Class NewAdminDashboard

    Dim home1 As Image = My.Resources.home1
    Dim home2 As Image = My.Resources.home2
    Dim stud1 As Image = My.Resources.stud1
    Dim stud2 As Image = My.Resources.stud2
    Dim prog1 As Image = My.Resources.prog1
    Dim prog2 As Image = My.Resources.prog2
    Dim prof1 As Image = My.Resources.prof1
    Dim prof2 As Image = My.Resources.prof2
    Dim allo1 As Image = My.Resources.allocation1
    Dim allo2 As Image = My.Resources.allocation2
    Dim dep As Image = My.Resources.department1
    Dim dep2 As Image = My.Resources.department2
    Dim profile As Image = My.Resources.profile2
    Dim profile2 As Image = My.Resources.profile
    Dim settings As Image = My.Resources.settings
    Dim settings2 As Image = My.Resources.settings2
    Dim exit1 As Image = My.Resources.exit1
    Dim exit2 As Image = My.Resources.exit2
    Dim putanginamored As String = "mirabel kalbo"



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
        exitIcon2.Hide()
        HomeIcon2.Hide()
        StudIcon2.Hide()
        ProfIcon2.Hide()
        ProgIcon2.Hide()
        DepIcon2.Hide()
        AlloIcon2.Hide()
        ProfileIcon2.Hide()
        SettingsIcon2.Hide()
        exitIcon2.Hide()

    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.Size = New Size(1261, 1000)
        panel.TopLevel = False

        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub
    '-----------------------------------BTN----------------------------------'

    Private Sub dashboardbttn_Click(sender As Object, e As EventArgs) Handles dashboardbttn.Click

        Dim dashboard As New NewOfficialDashboard()
        switchPanel(dashboard)
        NewOfficialDashboard.ResetState()
    End Sub

    Private Sub profilebttn_Click(sender As Object, e As EventArgs) Handles profilebttn.Click
        switchPanel(AdminProfile)
        ProfileIcon2.Show()
    End Sub
    '-----------------------------------ICON-----------------------------------'
    Private Sub HomeIcon_MouseEnter(sender As Object, e As EventArgs) Handles HomeIcon.MouseEnter
        HomeIcon2.Show()
    End Sub

    Private Sub StudentIcon_MouseEnter(sender As Object, e As EventArgs) Handles StudIcon2.MouseEnter
        StudIcon2.Show()
    End Sub

    Private Sub profIcon_MouseEnter(sender As Object, e As EventArgs) Handles ProfIcon.MouseEnter
        ProfIcon2.Show()
    End Sub
    Private Sub ProgIcon_MouseEnter(sender As Object, e As EventArgs) Handles ProgIcon.MouseEnter
        ProgIcon2.Show()
    End Sub

    Private Sub depIcon_MouseEnter(sender As Object, e As EventArgs) Handles DepIcon2.MouseEnter
        DepIcon2.Show()
    End Sub

    Private Sub alloIcon_MouseEnter(sender As Object, e As EventArgs) Handles AlloIcon.MouseEnter
        AlloIcon2.Show()
    End Sub
    Private Sub profileIcon_MouseEnter(sender As Object, e As EventArgs) Handles ProfileIcon2.MouseEnter
        ProfileIcon2.Show()
    End Sub

    Private Sub settingsIcon_MouseEnter(sender As Object, e As EventArgs) Handles SettingsIcon.MouseEnter
        SettingsIcon2.Show()
    End Sub
    Private Sub exitIcon_MouseEnter(sender As Object, e As EventArgs) Handles ExitIcon.MouseEnter
        exitIcon2.Show()
    End Sub
    '----------------------------ICON LEAVE------------------------------;
    Private Sub HomeIcon_MouseLeave(sender As Object, e As EventArgs) Handles HomeIcon.MouseLeave
        HomeIcon2.Hide()
    End Sub

    Private Sub StudentIcon_MouseLeave(sender As Object, e As EventArgs) Handles StudIcon2.MouseLeave
        StudIcon2.Hide()
    End Sub

    Private Sub profIcon_MouseLeave(sender As Object, e As EventArgs) Handles ProfIcon.MouseLeave
        ProfIcon2.Hide()
    End Sub
    Private Sub ProgIcon_MouseLeave(sender As Object, e As EventArgs) Handles ProgIcon.MouseLeave
        ProgIcon2.Hide()
    End Sub

    Private Sub depIcon_MouseLeave(sender As Object, e As EventArgs) Handles DepIcon2.MouseLeave
        DepIcon2.Hide()
    End Sub
    Private Sub alloIcon_MouseLeave(sender As Object, e As EventArgs) Handles AlloIcon.MouseLeave
        AlloIcon2.Hide()
    End Sub
    Private Sub profileIcon_MouseLeave(sender As Object, e As EventArgs) Handles ProfileIcon2.MouseLeave
        ProfileIcon2.Hide()
    End Sub

    Private Sub settingsIcon_MouseLeave(sender As Object, e As EventArgs) Handles SettingsIcon.MouseLeave
        SettingsIcon2.Hide()
    End Sub
    Private Sub ExitIcon_MouseLeave(sender As Object, e As EventArgs) Handles ExitIcon.MouseLeave
        exitIcon2.Hide()
    End Sub
    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click

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
