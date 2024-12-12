Public Class NewOfficialDashboard

    Dim students As Image = My.Resources.students1
    Dim students2 As Image = My.Resources.students2
    Dim professors As Image = My.Resources.professors1
    Dim professors2 As Image = My.Resources.professors2
    Dim administrator As Image = My.Resources.administrators1
    Dim administrator2 As Image = My.Resources.administrators2
    Dim programs As Image = My.Resources.programs1
    Dim programs2 As Image = My.Resources.programs2
    Dim departments As Image = My.Resources.departments1
    Dim departments2 As Image = My.Resources.departments2
    Dim courses As Image = My.Resources.courses1
    Dim courses2 As Image = My.Resources.courses2
    Dim plpbanner As Image = My.Resources.PLP_BANNER












    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.TodayDate = DateTime.Today
        MonthCalendar1.SelectionStart = DateTime.Today
        MonthCalendar1.SelectionEnd = DateTime.Today
        MonthCalendar1.ShowTodayCircle = False
        MakePictureBoxRounded(PictureBox18, 20)
        StudBox2.Hide()
        ProfBox2.Hide()
        AdminBox2.Hide()
        ProgBox2.Hide()
        DepBox2.Hide()
        CourseBox2.Hide()

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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles ProfBox.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles StudBox.MouseEnter

    End Sub

    Private Sub StudBox_MouseEnter(sender As Object, e As EventArgs) Handles StudBox.MouseEnter
        StudBox2.Show()
    End Sub
    Private Sub ProgBox_MouseEnter(sender As Object, e As EventArgs) Handles ProgBox.MouseEnter
        ProgBox2.Show()
    End Sub
    Private Sub ProfBox_MouseEnter(sender As Object, e As EventArgs) Handles ProfBox.MouseEnter
        ProfBox2.Show()
    End Sub
    Private Sub DepBox_MouseEnter(sender As Object, e As EventArgs) Handles DepBox.MouseEnter
        DepBox2.Show()
    End Sub
    Private Sub AdminBox_MouseEnter(sender As Object, e As EventArgs) Handles AdminBox.MouseEnter
        AdminBox2.Show()
    End Sub
    Private Sub CourseBox_MouseEnter(sender As Object, e As EventArgs) Handles CourseBox.MouseEnter
        CourseBox2.Show()
    End Sub
    Private Sub StudBox_MouseLeave(sender As Object, e As EventArgs) Handles StudBox.MouseLeave
        StudBox2.Hide()
    End Sub
    Private Sub ProgBox_MouseLeave(sender As Object, e As EventArgs) Handles ProgBox.MouseLeave
        ProgBox2.Hide()
    End Sub
    Private Sub ProfBox_MouseLeave(sender As Object, e As EventArgs) Handles ProfBox.MouseLeave
        ProfBox2.Hide()
    End Sub
    Private Sub DepBox_MouseLeave(sender As Object, e As EventArgs) Handles DepBox.MouseLeave
        DepBox2.Hide()
    End Sub
    Private Sub AdminBox_MouseLeave(sender As Object, e As EventArgs) Handles AdminBox.MouseLeave
        AdminBox2.Hide()
    End Sub
    Private Sub CourseBox_MouseLeave(sender As Object, e As EventArgs) Handles CourseBox.MouseLeave
        CourseBox2.Hide()
    End Sub
End Class