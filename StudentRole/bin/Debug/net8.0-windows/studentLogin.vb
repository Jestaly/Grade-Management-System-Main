Public Class studentLogin
    Public connect = New DBConnector()
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        connect.connectToDB
        Dim username = usernameTextBox.Text
        Dim password = passwordTextBox.Text
        MessageBox.Show(password)

    End Sub

End Class
