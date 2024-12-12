Public Class NewOfficialDashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.TodayDate = DateTime.Today
        MonthCalendar1.SelectionStart = DateTime.Today
        MonthCalendar1.SelectionEnd = DateTime.Today
        MonthCalendar1.ShowTodayCircle = False
        MakePictureBoxRounded(PictureBox18, 20)
    End Sub
    Public Sub MakePictureBoxRounded(pictureBox As PictureBox, cornerRadius As Integer)
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, pictureBox.Width, pictureBox.Height)
        Dim diameter As Integer = cornerRadius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        pictureBox.Region = New Region(path)
    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim cornerRadius = 20
        Dim rect As New Rectangle(0, 0, Panel13.Width - 1, Panel13.Height - 1)
        Dim path As New Drawing2D.GraphicsPath
        Dim diameter = cornerRadius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        Panel13.Region = New Region(path)

    End Sub
    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim cornerRadius = 20
        Dim rect As New Rectangle(0, 0, Panel12.Width - 1, Panel12.Height - 1)
        Dim path As New Drawing2D.GraphicsPath
        Dim diameter = cornerRadius * 2

        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)
        path.CloseFigure()
        Panel12.Region = New Region(path)

    End Sub
    Public Sub ResetState()
        Panel1.Visible = False
        Panel1.Controls.Clear()
    End Sub
    Sub switchPanel(ByVal panel As Form)
        If panel.Controls.Count > 0 Then
            panel.Controls.RemoveAt(0)
        End If
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub searchstudentbttn_Click(sender As Object, e As EventArgs) Handles searchstudentbttn.Click
        Panel1.Visible = True
        switchPanel(searchstudent)

    End Sub

    Private Sub searchprofessorbttn_Click(sender As Object, e As EventArgs) Handles searchprofessorbttn.Click
        Panel1.Visible = True
        switchPanel(searchprofessor)
    End Sub

    Private Sub searchadministratorbttn_Click(sender As Object, e As EventArgs) Handles searchadministratorbttn.Click
        Panel1.Visible = True
        switchPanel(searchadmin)
    End Sub

    Private Sub searchprogrambttn_Click(sender As Object, e As EventArgs) Handles searchprogrambttn.Click
        Panel1.Visible = True
        switchPanel(searchprogram)
    End Sub

    Private Sub searchdepartmentbttn_Click(sender As Object, e As EventArgs) Handles searchdepartmentbttn.Click
        Panel1.Visible = True
        switchPanel(searchdepartment)
    End Sub

    Private Sub searchcoursesbttn_Click(sender As Object, e As EventArgs) Handles searchcoursesbttn.Click
        Panel1.Visible = True
        switchPanel(searchcourses)
    End Sub
    Private Sub generatsummarybttn_Click(sender As Object, e As EventArgs) Handles generatsummarybttn.Click
        Panel1.Visible = True
        switchPanel(generateSummary)
    End Sub
End Class