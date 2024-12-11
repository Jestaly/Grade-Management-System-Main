Imports System.Runtime.InteropServices

Public Class NewAdminDashboard

    <DllImport("user32.dll")>
    Private Shared Function SetWindowRgn(hWnd As IntPtr, hRgn As IntPtr, bRedraw As Boolean) As Integer
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function CreateRoundRectRgn(nLeftRect As Integer, nTopRect As Integer, nRightRect As Integer, nBottomRect As Integer, nWidthEllipse As Integer, nHeightEllipse As Integer) As IntPtr
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cornerRadius As Integer = 30
        Dim hRgn As IntPtr = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, cornerRadius, cornerRadius)
        SetWindowRgn(Me.Handle, hRgn, True)
    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Application.Exit()
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub dashboardbttn_Click(sender As Object, e As EventArgs) Handles dashboardbttn.Click
        switchPanel(NewOfficialDashboard)
    End Sub

    Private Sub profilebttn_Click(sender As Object, e As EventArgs) Handles profilebttn.Click
        switchPanel(AdminProfile)
    End Sub
End Class
