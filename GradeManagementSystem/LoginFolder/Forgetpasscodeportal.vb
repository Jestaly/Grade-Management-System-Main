Public Class Forgetpasscodeportal
    Private Sub emailaddress_TextChanged(sender As Object, e As EventArgs) Handles emailaddress.TextChanged

    End Sub

    Private Sub resetpasscodebttn_Click_1(sender As Object, e As EventArgs) Handles resetpasscodebttn.Click

    End Sub


    Private Sub backtologinclick_Click(sender As Object, e As EventArgs) Handles backtologinclick.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

End Class