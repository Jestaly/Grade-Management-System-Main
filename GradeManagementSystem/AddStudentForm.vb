﻿Imports System.Runtime.CompilerServices

Public Class AddStudentForm
    Private Sub AddStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
End Class