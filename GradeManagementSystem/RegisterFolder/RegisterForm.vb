﻿Public Class RegisterForm
    Private Sub RegisterForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
        LoginForm.Visible = True
    End Sub
End Class