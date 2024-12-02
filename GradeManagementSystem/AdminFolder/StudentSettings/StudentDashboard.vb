Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class StudentDashboard
    Inherits Form
    Public Property CornerRadius As Integer = 30
    Public Property UserChoice As DialogResult = DialogResult.Cancel
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90) ' Bottom-left corner
        path.CloseAllFigures()
        Me.Region = New Region(path)
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim cornerRadius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Panel2.ClientSize.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Panel2.ClientSize.Width - cornerRadius, Panel2.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Panel2.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner

        path.CloseAllFigures()
        Panel2.Region = New Region(path)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim cornerRadius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Panel1.ClientSize.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Panel1.ClientSize.Width - cornerRadius, Panel1.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Panel1.ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90) ' Bottom-left corner

        path.CloseAllFigures()
        Panel1.Region = New Region(path)

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub

    Private Sub setting_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        settings.Visible = True
        studinfo.Visible = False
        courseinfo.Visible = False
        acadper.Visible = False
    End Sub

    Private Sub course_Click(sender As Object, e As EventArgs) Handles course.Click
        courseinfo.Visible = True
        studinfo.Visible = False
        acadper.Visible = False
        settings.Visible = False
    End Sub

    Private Sub studentinfo_Click(sender As Object, e As EventArgs) Handles studentinfo.Click
        studinfo.Visible = True
        acadper.Visible = False
        settings.Visible = False
        courseinfo.Visible = False
    End Sub

    Private Sub academicper_Click(sender As Object, e As EventArgs) Handles academicper.Click
        acadper.Visible = True
        studinfo.Visible = False
        courseinfo.Visible = False
        settings.Visible = False
    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub



End Class