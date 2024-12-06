Public Class Forgetpasscodeportal

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

    Private Sub emailaddress_TextChanged(sender As Object, e As EventArgs) Handles emailaddress.TextChanged
    End Sub

    Private Sub resetpasscodebttn_Click_1(sender As Object, e As EventArgs) Handles resetpasscodebttn.Click
    End Sub

    Private Sub backtologinclick_Click(sender As Object, e As EventArgs) Handles backtologinclick.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub backtologinicon_Click(sender As Object, e As EventArgs) Handles backtologinicon.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
