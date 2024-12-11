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
End Class