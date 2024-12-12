Imports MySql.Data.MySqlClient

Public Class ModifyProgramForm
    Private connector As New DatabaseConnector
    Private officialModifyProgramForm As New OfficialModifyProgramForm
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        loadDepartment
        If programExists() Then
            Visible = False
            makeOMPFChild
            officialModifyProgramForm.Visible = True
        End If
    End Sub

    Private Sub ModifyProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
    Private Sub loadDepartment()
        Try
            officialModifyProgramForm.departmentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT dept_name FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim departmentName As String = connector.reader("dept_name").ToString()
                If Not String.IsNullOrEmpty(departmentName) Then
                    officialModifyProgramForm.departmentComboBox.Items.Add(departmentName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function programExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT program.program_id AS ID,program.program_name AS Program,department.dept_name AS Department,program.sections AS Sections,program.year_added AS 'Date created' FROM program LEFT JOIN department ON program.dept_id = department.dept_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("ID").ToString.Equals(trimmedProgID) Then
                    officialModifyProgramForm.programIDTextBox.Text = connector.reader("ID").ToString
                    officialModifyProgramForm.programnameTextBox.Text = connector.reader("Program").ToString
                    officialModifyProgramForm.departmentComboBox.Text = connector.reader("Department").ToString
                    officialModifyProgramForm.sectionBox.Text = connector.reader("Sections").ToString
                    officialModifyProgramForm.yearAddedTextBox.Text = connector.reader("Date created").ToString
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
        MessageBox.Show("Program not Found.")
        Return False
    End Function

    Private Function trimmedProgID() As String
        Dim progID = programIDTextBox.Text.Replace("-", "")
        Return progID
    End Function
    Private Sub makeOMPFChild()
        officialModifyProgramForm.TopLevel = False
        officialModifyProgramForm.Parent = Me.Parent
        CenterOMPF()
        officialModifyProgramForm.BringToFront()
    End Sub

    Private Sub CenterOMPF()
        Dim x As Integer = (Me.Parent.Width - officialModifyProgramForm.Width) \ 2
        Dim y As Integer = (Me.Parent.Height - officialModifyProgramForm.Height) \ 2
        officialModifyProgramForm.Location = New Point(x, y)
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub

    Private Sub ModifyProgramForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class