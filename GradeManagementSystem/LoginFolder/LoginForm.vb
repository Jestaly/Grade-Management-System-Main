Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public connector As New DatabaseConnector
    Private studentForm As New StudentForm
    Public professorForm As New ProfessorForm
    Public Property CornerRadius As Integer = 60
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90) ' Bottom-left corner
        path.CloseAllFigures()
        Me.Region = New Region(path)
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub

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
                        connector.connect.Close()
                        Me.Visible = False
                        studentForm.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "2") Then
                        connector.connect.Close()
                        loadClass()
                        getProfName()
                        Me.Visible = False
                        professorForm.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "3") Then
                        connector.connect.Close()
                        Me.Visible = False
                        AdminDashboard.Visible = True
                        Return
                    End If
                End If
            Next
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        accountIDLogin.BackColor = Color.FromArgb(255, 128, 128)
        passwordLogin.BackColor = Color.FromArgb(255, 128, 128)
        Panel1.BackColor = Color.FromArgb(255, 128, 128)
        Panel2.BackColor = Color.FromArgb(255, 128, 128)

        MessageBox.Show("Wrong ID or password.")
    End Sub

    Public Sub loadClass()
        Dim classID As String = ""
        Try
            professorForm.classChooseBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT class_id AS 'Class ID' FROM class WHERE class.professor_id = '" & trimmedID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("Class ID").ToString IsNot Nothing) Then
                    classID = connector.reader("Class ID").ToString
                    professorForm.classChooseBox.Items.Add(classID)
                End If
                professorForm.classChooseBox.SelectedIndex = 0
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Public Sub getProfName()
        Try
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS Professor FROM professor WHERE id = '" & trimmedID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            Dim profName As String = connector.command.ExecuteScalar
            professorForm.profTextBox.Text = profName
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Public Function getProfID() As String
        Return accountIDLogin.Text
    End Function
    Private Sub registerAdmin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Visible = False
        registerForm.Visible = True
    End Sub

    Private Sub forgotpasscodeportal_Click(sender As Object, e As EventArgs) Handles forgotpasscodeportal.Click
        Forgetpasscodeportal.Show()
        Me.Hide()
    End Sub

    Private Sub exitbttn_Click(sender As Object, e As EventArgs) Handles exitbttn.Click
        End
    End Sub

    Private Sub accountIDLogin_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles accountIDLogin.MaskInputRejected

    End Sub
End Class
