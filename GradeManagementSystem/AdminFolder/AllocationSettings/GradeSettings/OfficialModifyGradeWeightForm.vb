Imports MySql.Data.MySqlClient
Public Class OfficialModifyGradeWeightForm
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub modifyPercentageButton_Click(sender As Object, e As EventArgs) Handles modifyPercentageButton.Click

    End Sub
End Class