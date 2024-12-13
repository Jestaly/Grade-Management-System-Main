Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ModifyClassForm
    Private connector As New DatabaseConnector
    Private officialModifyClassForm As New OfficialModifyClassForm
    Private Sub ModifyClassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        loadProfessor()
        loadCourse()

        If classExists() Then
            Visible = False
            makeOMCLFChild()
            officialModifyClassForm.Visible = True
        End If
    End Sub

    Private Sub loadCourse()
        Try
            officialModifyClassForm.courseComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT course_name AS 'course' FROM course;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim courseName As String = connector.reader("course").ToString()
                If Not String.IsNullOrEmpty(courseName) Then
                    officialModifyClassForm.courseComboBox.Items.Add(courseName)
                End If
            End While
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Sub loadProfessor()
        Try
            officialModifyClassForm.professorComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS 'Professor name' FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim professorName As String = connector.reader("Professor name").ToString()
                If Not String.IsNullOrEmpty(professorName) Then
                    officialModifyClassForm.professorComboBox.Items.Add(professorName)
                End If
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getPMAbb() As String
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM time_history;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("class_id").Equals(trimmedClassID)) Then
                    Dim endAbb As String = connector.reader("end_abbreviation").ToString
                    connector.reader.Close()
                    connector.connect.Close()
                    Return endAbb
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return ""
    End Function

    Private Function getAMAbb() As String
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM time_history;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("class_id").Equals(trimmedClassID)) Then
                    Dim startAbb As String = connector.reader("start_abbreviation").ToString
                    connector.reader.Close()
                    connector.connect.Close()
                    Return startAbb
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error")
        End Try
        Return ""
    End Function
    Private Function classExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT class.class_id,CONCAT(professor.fname,' ',professor.mname,' ', professor.lname) AS 'Professor', course.course_name AS Course, time_start, time_end, day AS Day FROM class LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id LEFT JOIN time_history ON class.class_id = time_history.class_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("class_id").ToString.Equals(trimmedClassID) Then
                    officialModifyClassForm.classIDTextBox.Text = connector.reader("class_id").ToString
                    officialModifyClassForm.professorComboBox.Text = connector.reader("Professor").ToString
                    officialModifyClassForm.courseComboBox.Text = connector.reader("Course").ToString
                    officialModifyClassForm.classSeshComboBox.Text = connector.reader("Day").ToString
                    officialModifyClassForm.startTimePicker.Text = connector.reader("time_start").ToString
                    officialModifyClassForm.endTimePicker.Text = connector.reader("time_end").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    'officialModifyClassForm.startTimePicker.Text &= getAMAbb()
                    'officialModifyClassForm.endTimePicker.Text &= getPMAbb()
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
        MessageBox.Show("Class not Found.")
        Return False
    End Function

    Private Function trimmedClassID() As String
        Dim classID = classIDTextBox.Text.Replace("-", "")
        Return classID
    End Function

    Private Sub makeOMCLFChild()
        officialModifyClassForm.TopLevel = False
        officialModifyClassForm.Parent = Me.Parent
        CenterOMCLF()
        officialModifyClassForm.BringToFront()
    End Sub

    Private Sub CenterOMCLF()
        Dim x As Integer = (Me.Parent.Width - officialModifyClassForm.Width) \ 2
        Dim y As Integer = (Me.Parent.Height - officialModifyClassForm.Height) \ 2
        officialModifyClassForm.Location = New Point(x, y)
    End Sub
    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub
End Class