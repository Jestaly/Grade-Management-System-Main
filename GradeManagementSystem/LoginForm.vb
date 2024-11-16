Imports MySql.Data.MySqlClient

Public Class loginForm
    Public connector As New DatabaseConnector
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If (accountExist()) Then
            MessageBox.Show("Logged in!")
            Return
        End If
        MessageBox.Show("Account doesn't exists!")
    End Sub

    Public Function accountExist() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) FROM login_info WHERE uname = ?username AND password = ?password;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.Parameters.Clear()
            connector.command.Parameters.AddWithValue("?username", usernameTextBox.Text)
            connector.command.Parameters.AddWithValue("?password", passwordTextBox.Text)
            Dim count As Integer = Convert.ToInt32(connector.command.ExecuteScalar())
            If (count > 0) Then
                connector.connect.Close()
                Return True
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        Return False

    End Function
End Class
