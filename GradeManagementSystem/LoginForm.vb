Imports MySql.Data.MySqlClient

Public Class loginForm
    Public connector As New DatabaseConnector
    Private adminForm As New AdminForm
    Private registerForm As New RegisterForm
    Private studentForm As New StudentForm
    Private professorForm As New ProfessorForm
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim accountType = accountTypeLogin.Text

        If (accountType.Equals("Admin")) Then
            If (accountExist(accountType)) Then
                MessageBox.Show("Logged in!")
                Me.Visible = False
                adminForm.Visible = True
                Return
            End If
        ElseIf (accountType.Equals("Student")) Then
            If (accountExist(accountType)) Then
                MessageBox.Show("Logged in!")
                Me.Visible = False
                studentForm.Visible = True
                Return
            End If

        ElseIf (accountType.Equals("Professor")) Then
            If (accountExist(accountType)) Then
                MessageBox.Show("Logged in!")
                Me.Visible = False
                professorForm.Visible = True
                Return
            End If

        End If

        MessageBox.Show("Wrong username or password.")
    End Sub

    Public Function accountExist(accountType As String) As Boolean
        If (accountType.Equals("Admin")) Then
            Try
                connector.connect.Open()
                connector.query = "SELECT COUNT(*) FROM admin_account WHERE aid = ?id AND uname = ?username AND type = ?type AND pass = ?password;"
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.command.Parameters.AddWithValue("?id", accountIDLogin.Text)
                connector.command.Parameters.AddWithValue("?username", usernameLogin.Text)
                connector.command.Parameters.AddWithValue("?type", accountTypeLogin.Text)
                connector.command.Parameters.AddWithValue("?password", passwordLogin.Text)
                Dim count As Integer = Convert.ToInt32(connector.command.ExecuteScalar())
                If (count > 0) Then
                    connector.connect.Close()
                    connector.command.Parameters.Clear()
                    Return True
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database Error")
                Return False
            End Try
            connector.connect.Close()
            Return False

        ElseIf (accountType.Equals("Student")) Then
            Try
                connector.connect.Open()
                connector.query = "SELECT COUNT(*) FROM student_account WHERE sid = ?id AND uname = ?username AND type = ?type AND pass = ?password;"
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.command.Parameters.AddWithValue("?id", accountIDLogin.Text)
                connector.command.Parameters.AddWithValue("?username", usernameLogin.Text)
                connector.command.Parameters.AddWithValue("?type", accountTypeLogin.Text)
                connector.command.Parameters.AddWithValue("?password", passwordLogin.Text)
                Dim count As Integer = Convert.ToInt32(connector.command.ExecuteScalar())
                If (count > 0) Then
                    connector.connect.Close()
                    connector.command.Parameters.Clear()
                    Return True
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database Error")
                Return False
            End Try
            connector.connect.Close()
            Return False

        ElseIf (accountType.Equals("Professor")) Then
            Try
                connector.connect.Open()
                connector.query = "SELECT COUNT(*) FROM professor_account WHERE pid = ?id AND uname = ?username AND type = ?type AND pass = ?password;"
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.command.Parameters.AddWithValue("?id", accountIDLogin.Text)
                connector.command.Parameters.AddWithValue("?username", usernameLogin.Text)
                connector.command.Parameters.AddWithValue("?type", accountTypeLogin.Text)
                connector.command.Parameters.AddWithValue("?password", passwordLogin.Text)
                Dim count As Integer = Convert.ToInt32(connector.command.ExecuteScalar())
                If (count > 0) Then
                    connector.connect.Close()
                    connector.command.Parameters.Clear()
                    Return True
                End If
            Catch ex As MySqlException
                MessageBox.Show("Database Error")
                Return False
            End Try
            connector.connect.Close()
            connector.command.Parameters.Clear()
            Return False
        End If

        Return False
    End Function

    Private Sub forgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotPasswordLogin.LinkClicked
        Dim email = InputBox("Enter your email")
        If (emailExists(email)) Then
            Dim password = InputBox("Enter new password")
            changePassword(password, email)
        Else
            MessageBox.Show("Email does not exist!")
        End If

    End Sub

    Public Function emailExists(email As String) As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) FROM login_info WHERE email = ?email"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.Parameters.Clear()
            connector.command.Parameters.AddWithValue("?email", email)
            Dim count = Convert.ToInt32(connector.command.ExecuteScalar())
            If (count > 0) Then
                connector.connect.Close()
                Return True
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error")
            Return False
        End Try
        connector.connect.Close()
        Return False
    End Function

    Public Sub changePassword(password As String, email As String)
        Try
            connector.connect.Open()
            connector.query = "UPDATE login_info SET password = '" & password & "' WHERE email = '" & email & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("password changed succesfully!")
        Catch ex As MySqlException
            MessageBox.Show("Database Error")
        End Try
        connector.connect.Close()
    End Sub

    Private Sub registerButton_Click(sender As Object, e As EventArgs) Handles registerButton.Click
        registerForm.Visible = True
    End Sub
End Class
