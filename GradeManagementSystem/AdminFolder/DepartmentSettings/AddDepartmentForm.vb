﻿Public Class AddDepartmentForm
    Private connector As New DatabaseConnector
    Private Sub AddDepartmentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False

    End Sub

    Private Sub addDepartmentButton_Click(sender As Object, e As EventArgs) Handles addDepartmentButton.Click




    End Sub
End Class