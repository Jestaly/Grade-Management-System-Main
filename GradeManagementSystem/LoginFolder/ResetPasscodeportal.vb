Public Class ResetPasscodeportal
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

    Private Sub digitcode_errormessage_Click(sender As Object, e As EventArgs) Handles digitcode_errormessage.Click

    End Sub

    Private Sub newpassword_errormessage_Click(sender As Object, e As EventArgs) Handles newpassword_errormessage.Click

    End Sub

    Private Sub resetpasscodebttn_Click(sender As Object, e As EventArgs) Handles resetpasscodebttn.Click

    End Sub
    Private Sub digitcodetxt_TextChanged(sender As Object, e As EventArgs) Handles digitcodetxt.TextChanged

    End Sub

    Private Sub newpasswordtxt_TextChanged(sender As Object, e As EventArgs) Handles newpasswordtxt.TextChanged

    End Sub

    Private Sub confirmnewpasswordtxt_TextChanged(sender As Object, e As EventArgs) Handles confirmnewpasswordtxt.TextChanged

    End Sub

    Private Sub confirmnewpasscode_errormessage_Click(sender As Object, e As EventArgs) Handles confirmnewpasscode_errormessage.Click

    End Sub
    Private Sub tryagainclick_Click(sender As Object, e As EventArgs) Handles tryagainclick.Click
        Forgetpasscodeportal.Show()
        Me.Hide()
    End Sub

End Class