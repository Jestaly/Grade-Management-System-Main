Imports System.Drawing.Drawing2D
Public Class Dashboard
    Dim targetWidth As Integer
    Dim stepSize As Integer = 40

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grademanagebttn_Click(sender As Object, e As EventArgs) Handles grademanagebttn.Click
        activitylog2.Visible = False
        switchPanel(gradingsheet)
        grademanagement2.Visible = True
        coursemanage2.Visible = False
        dashboard2.Visible = False
        profile2.Visible = False
        targetWidth = 12
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If notificationpanel.Width > targetWidth Then
            notificationpanel.Width -= stepSize
        Else
            Timer1.Stop()
        End If
    End Sub



    Private Sub coursemanagebttn_Click(sender As Object, e As EventArgs) Handles coursemanagebttn.Click
        activitylog2.Visible = False
        profile.Visible = False
        grademanagement2.Visible = False
        coursemanage2.Visible = True
        dashboard2.Visible = False
        profile2.Visible = False
        notificationpanel.Visible = True
        notificationpanel.Size = New Size(397, 821)
        switchPanel(coursemanagement)

    End Sub

    Private Sub profilebttn_Click(sender As Object, e As EventArgs) Handles profilebttn.Click
        activitylog2.Visible = False
        switchPanel(profile)
        grademanagement2.Visible = False
        coursemanage2.Visible = False
        dashboard2.Visible = False
        profile2.Visible = True
        notificationpanel.Visible = True
        notificationpanel.Size = New Size(397, 821)
    End Sub

    Private Sub dashboardbttn_Click(sender As Object, e As EventArgs) Handles dashboardbttn.Click
        profile.Visible = False
        notificationpanel.Visible = True
        grademanagement2.Visible = False
        coursemanage2.Visible = False
        dashboard2.Visible = True
        profile2.Visible = False
        switchPanel(home)
        notificationpanel.Visible = True
        notificationpanel.Size = New Size(397, 821)
        activitylog2.Visible = False
    End Sub


    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub logout2_Click(sender As Object, e As EventArgs) Handles logout2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub activitylog_Click(sender As Object, e As EventArgs) Handles activitylog.Click
        activitylog2.Visible = True
        grademanagement2.Visible = False
        coursemanage2.Visible = False
        dashboard2.Visible = False
        profile2.Visible = False

        notificationpanel.Visible = True
        notificationpanel.Size = New Size(397, 821)
    End Sub

End Class
