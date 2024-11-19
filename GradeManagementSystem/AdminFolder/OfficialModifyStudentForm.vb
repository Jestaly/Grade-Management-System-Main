Imports MySql.Data.MySqlClient
Public Class OfficialModifyStudentForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub OfficialModifyStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class