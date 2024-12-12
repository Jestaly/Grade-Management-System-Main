Imports MySql.Data.MySqlClient

Public Class ModifyProfessorForm
    Private connector As New DatabaseConnector
    Private officialModifyProfessorForm As New OfficialModifyProfessorForm
    Private Sub loadDepartment()
        Try
            OfficialModifyProgramForm.departmentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT dept_name FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim departmentName As String = connector.reader("dept_name").ToString()
                If Not String.IsNullOrEmpty(departmentName) Then
                    officialModifyProfessorForm.departmentComboBox.Items.Add(departmentName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function professorExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT professor.id,professor.lname,professor.fname,professor.mname,department.dept_name AS department,professor.email FROM professor LEFT JOIN department ON professor.dept_id = department.dept_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("id").ToString.Equals(trimmedProfID) Then
                    officialModifyProfessorForm.profIDTextBox.Text = connector.reader("id").ToString
                    officialModifyProfessorForm.lastnameTextBox.Text = connector.reader("lname").ToString
                    officialModifyProfessorForm.firstnameTextBox.Text = connector.reader("fname").ToString
                    officialModifyProfessorForm.middlenameTextBox.Text = connector.reader("mname").ToString
                    officialModifyProfessorForm.departmentComboBox.Text = connector.reader("department").ToString
                    officialModifyProfessorForm.emailTextBox.Text = connector.reader("email").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return True
                End If
            End While
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.reader.Close()
        connector.connect.Close()
        MessageBox.Show("Professor not Found.")
        Return False
    End Function

    Private Function trimmedProfID() As String
        Dim profID = profIDTextBox.Text.Replace("-", "")
        Return profID
    End Function

    Private Sub ModifyProfessorForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs)
        Visible = False
    End Sub
    Private Sub makeOMPFFChild()
        officialModifyProfessorForm.TopLevel = False
        officialModifyProfessorForm.Parent = Me.Parent
        CenterOMPFF()
        officialModifyProfessorForm.BringToFront()
    End Sub

    Private Sub CenterOMPFF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyProfessorForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyProfessorForm.Height) \ 2
        officialModifyProfessorForm.Location = New Point(x, y)
    End Sub

    Private Sub ModifyProfessorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), 270, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.AddLine(0, Me.Height - 40, 0, 40)
        p.CloseFigure()
        Me.Region = New Region(p)
    End Sub

    Private Sub searchb_Click(sender As Object, e As EventArgs) Handles searchb.Click
        loadDepartment()

        If professorExists() Then
            Visible = False
            makeOMPFFChild()
            officialModifyProfessorForm.Visible = True
        End If
    End Sub
End Class
