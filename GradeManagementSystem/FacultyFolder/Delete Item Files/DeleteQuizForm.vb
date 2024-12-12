Imports MySql.Data.MySqlClient

Public Class DeleteQuizForm
    Private connector As New DatabaseConnector

    Private Sub deleteQuizButton_Click(sender As Object, e As EventArgs) Handles deleteQuizButton.Click
        Dim classID = LoginForgot.gradingSheet.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "DELETE FROM item WHERE item_name = '" & chooseQuizBox.Text & "' AND item_type = 'Quiz' AND term = '" & GradingSheet.getTerm & "' AND class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class