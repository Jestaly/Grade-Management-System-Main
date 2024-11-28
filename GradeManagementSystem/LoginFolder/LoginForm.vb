Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public connector As New DatabaseConnector
    Private adminForm As New AdminForm
    Private registerForm As New RegisterForm
    Private studentForm As New StudentForm
    Private professorForm As New ProfessorForm

    Private Function trimmedID() As String
        Dim id As String = accountIDLogin.Text.Replace("-", "")
        Return id
    End Function
    Private Function password() As String
        Dim pass As String = passwordLogin.Text
        Return pass
    End Function
    Private Sub enterbttn_Click(sender As Object, e As EventArgs) Handles enterbttn.Click
        Try
            connector.connect.Open()
            connector.query = "SELECT student.id AS id, student.password AS password FROM student UNION SELECT professor.id AS id, professor.password AS password FROM professor UNION SELECT admin.id AS id, admin.password AS password FROM admin;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.command.ExecuteNonQuery()
            For Each row As DataGridViewRow In dataView.Rows
                If ((row.Cells("id").Value IsNot Nothing AndAlso row.Cells("id").Value.ToString.Equals(trimmedID())) And row.Cells("password").Value IsNot Nothing AndAlso row.Cells("password").Value.ToString.Equals(password())) Then
                    If (trimmedID().Chars(0) = "1") Then
                        Me.Visible = False
                        studentForm.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "2") Then
                        Me.Visible = False
                        professorForm.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "3") Then
                        Me.Visible = False
                        adminForm.Visible = True
                        Return
                    End If
                End If
            Next
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        MessageBox.Show("Wrong ID or password.")
    End Sub
    Private Sub registerAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registerAdmin.LinkClicked
        Me.Visible = False
        registerForm.Visible = True
    End Sub

    Private Sub forgotpasscodeportal_Click(sender As Object, e As EventArgs) Handles forgotpasscodeportal.Click
        Forgetpasscodeportal.Show()
        Me.Hide()
    End Sub

    Private Sub exitbttn_Click(sender As Object, e As EventArgs) Handles exitbttn.Click
        Application.Exit()
    End Sub


End Class
