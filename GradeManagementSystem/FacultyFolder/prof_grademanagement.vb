Public Class prof_grademanagement
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)


        Dim g As Graphics = e.Graphics

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Dim radius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()


        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub

    Private Sub prof_grademanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Gerald2_Click(sender As Object, e As EventArgs)

    End Sub
End Class