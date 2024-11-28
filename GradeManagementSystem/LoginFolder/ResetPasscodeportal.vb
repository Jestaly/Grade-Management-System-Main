Public Class ResetPasscodeportal
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