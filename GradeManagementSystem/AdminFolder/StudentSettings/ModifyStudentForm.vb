Imports MySql.Data.MySqlClient

Public Class ModifyStudentForm
    Private connector As New DatabaseConnector
    Private officialModifyStudentForm As New OfficialModifyStudentForm


    Private Sub ModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs)
        officialModifyStudentForm.programComboBox.Items.Clear()
        officialModifyStudentForm.sectionComboBox.Items.Clear()
        loadProgram()

        If studentExists() Then
            Visible = False
            makeOMSFChild()
            officialModifyStudentForm.Visible = True
        End If
    End Sub

    Private Sub loadProgram()
        Try
            connector.connect.Open()
            connector.query = "SELECT program_name FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim programName As String = connector.reader("program_name").ToString()
                If Not String.IsNullOrEmpty(programName) Then
                    officialModifyStudentForm.programComboBox.Items.Add(programName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function studentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section,student.email FROM student LEFT JOIN program ON student.program_id = program.program_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("id").ToString.Equals(trimmedStudID) Then
                    officialModifyStudentForm.sidTextBox.Text = connector.reader("id").ToString
                    officialModifyStudentForm.lastnameTextBox.Text = connector.reader("lname").ToString
                    officialModifyStudentForm.firstnameTextBox.Text = connector.reader("fname").ToString
                    officialModifyStudentForm.middlenameTextBox.Text = connector.reader("mname").ToString
                    officialModifyStudentForm.birthDate.Text = connector.reader("birthdate").ToString
                    officialModifyStudentForm.programComboBox.Text = connector.reader("program_name").ToString
                    officialModifyStudentForm.yearComboBox.Text = connector.reader("year").ToString
                    officialModifyStudentForm.emailTextBox.Text = connector.reader("email").ToString
                    connector.reader.Close()

                    getSectionData()

                    connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section,student.email FROM student LEFT JOIN program ON student.program_id = program.program_id;"
                    connector.command.CommandText = connector.query
                    connector.reader = connector.command.ExecuteReader
                    While connector.reader.Read
                        If connector.reader("id").ToString.Equals(trimmedStudID) Then
                            officialModifyStudentForm.sectionComboBox.Text = connector.reader("section").ToString
                            Exit While
                        End If
                    End While

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
        MessageBox.Show("Student not Found.")
        Return False
    End Function

    Private Sub getSectionData()
        officialModifyStudentForm.sectionComboBox.Items.Clear()
        Dim selectedProgram As String = officialModifyStudentForm.programComboBox.Text
        Dim numOfSection As Integer
        Try
            connector.query = "SELECT program_name,sections FROM program;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If selectedProgram.Equals(connector.reader("program_name").ToString) Then
                    numOfSection = Integer.Parse(connector.reader("sections").ToString())
                    Exit While
                End If
            End While

        Catch ex As MySqlException
            connector.connect.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try

        Dim section() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
        For i As Integer = 0 To numOfSection - 1
            officialModifyStudentForm.sectionComboBox.Items.Add(section(i))
        Next
        connector.reader.Close()
    End Sub

    Private Function getStudentID() As Integer
        Dim getID = Integer.Parse(studentIDTextBox.Text)
        Return getID
    End Function

    Private Function trimmedStudID() As String
        Dim studID = studentIDTextBox.Text.Replace("-", "")
        Return studID
    End Function
    Private Sub makeOMSFChild()
        officialModifyStudentForm.TopLevel = False
        officialModifyStudentForm.Parent = Me.Parent
        CenterOMSF()
        officialModifyStudentForm.BringToFront()
    End Sub

    Private Sub CenterOMSF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyStudentForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyStudentForm.Height) \ 2
        officialModifyStudentForm.Location = New Point(x, y)
    End Sub

    Private Sub ModifyStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub
End Class