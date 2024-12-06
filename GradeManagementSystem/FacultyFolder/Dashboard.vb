Imports System.Drawing.Drawing2D

Public Class Dashboard

    Private WithEvents slideTimer As New Timer()
    Private slideSpeed As Integer = 10
    Private isGrademanagementSliding As Boolean = False
    Private isNotificationPanelSliding As Boolean = False
    Private grademanagementStartWidth As Integer = 1074
    Private grademanagementEndWidth As Integer = 1491
    Private notificationPanelStartWidth As Integer = 414
    Private notificationPanelEndWidth As Integer = 10
    Private notificationPanelStartPos As Integer
    Private notificationPanelEndPos As Integer

    Private isExpanded As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        datetime.Text = Date.Now.ToString("dddd, MMMM d, yyyy")
    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        slideTimer.Interval = 15
        slideTimer.Start()

        grademanagement.Width = grademanagementStartWidth
        grademanagement.Height = 821
        notificationPanelStartPos = Me.Width
        notificationPanelEndPos = Me.Width - notificationPanelEndWidth

        notificationpanel.Left = notificationPanelStartPos
        notificationpanel.Width = notificationPanelStartWidth
    End Sub

    Private Sub adjustbttn_Click(sender As Object, e As EventArgs) Handles adjustbttn.Click
        If Not isGrademanagementSliding And Not isNotificationPanelSliding Then
            If isExpanded Then
                isGrademanagementSliding = True
                isNotificationPanelSliding = True
            Else
                isGrademanagementSliding = True
                isNotificationPanelSliding = True
            End If
            isExpanded = Not isExpanded
        End If
    End Sub
    Private Sub slideTimer_Tick(sender As Object, e As EventArgs) Handles slideTimer.Tick

        If isGrademanagementSliding Then
            If isExpanded Then

                If grademanagement.Width < grademanagementEndWidth Then
                    grademanagement.Width += slideSpeed
                Else
                    grademanagement.Width = grademanagementEndWidth
                    isGrademanagementSliding = False
                End If
            Else

                If grademanagement.Width > grademanagementStartWidth Then
                    grademanagement.Width -= slideSpeed
                Else
                    grademanagement.Width = grademanagementStartWidth
                    isGrademanagementSliding = False
                End If
            End If
        End If

        If isNotificationPanelSliding Then
            If isExpanded Then

                If notificationpanel.Left > notificationPanelEndPos Then
                    notificationpanel.Left -= slideSpeed
                Else
                    notificationpanel.Left = notificationPanelEndPos
                End If

                If notificationpanel.Width > notificationPanelEndWidth Then
                    notificationpanel.Width -= slideSpeed
                Else
                    notificationpanel.Width = notificationPanelEndWidth
                    isNotificationPanelSliding = False
                End If
            Else
                If notificationpanel.Left < notificationPanelStartPos Then
                    notificationpanel.Left += slideSpeed
                Else
                    notificationpanel.Left = notificationPanelStartPos
                End If
                If notificationpanel.Width < notificationPanelStartWidth Then
                    notificationpanel.Width += slideSpeed
                Else
                    notificationpanel.Width = notificationPanelStartWidth
                    isNotificationPanelSliding = False
                End If
            End If
        End If
    End Sub

    Private Sub grademanagebttn_Click(sender As Object, e As EventArgs) Handles grademanagebttn.Click
        grademanagement2.Visible = True
        grademanagement.Visible = True
        coursemanage2.Visible = False
        dashboard2.Visible = False
        profile2.Visible = False
    End Sub

    Private Sub coursemanagebttn_Click(sender As Object, e As EventArgs) Handles coursemanagebttn.Click
        grademanagement.Visible = False
        grademanagement2.Visible = False
        coursemanage2.Visible = True
        dashboard2.Visible = False
        profile2.Visible = False
    End Sub

    Private Sub profilebttn_Click(sender As Object, e As EventArgs) Handles profilebttn.Click
        grademanagement.Visible = False
        grademanagement2.Visible = False
        coursemanage2.Visible = False
        dashboard2.Visible = False
        profile2.Visible = True
    End Sub

    Private Sub dashboardbttn_Click(sender As Object, e As EventArgs) Handles dashboardbttn.Click
        notificationpanel.Visible = True
        grademanagement2.Visible = False
        coursemanage2.Visible = False
        dashboard2.Visible = True
        profile2.Visible = False
        grademanagement.Visible = False
    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class
