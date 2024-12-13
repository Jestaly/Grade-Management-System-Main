Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ModifyEnrollStudentForm
    Private connector As New DatabaseConnector
    Private officialModifyEnrollStudentForm As New OfficialModifyEnrollStudentFormvb
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        loadStudent()
        loadClass()

        If enrollmentExists() Then
            Visible = False
            makeOMESFChild()
            officialModifyEnrollStudentForm.Visible = True
        End If
    End Sub

    Private Sub loadStudent()
        Try
            officialModifyEnrollStudentForm.studentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS 'Student name' FROM student;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim studentName As String = connector.reader("Student name").ToString()
                If Not String.IsNullOrEmpty(studentName) Then
                    officialModifyEnrollStudentForm.studentComboBox.Items.Add(studentName)
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

    Private Sub loadClass()
        Try
            officialModifyEnrollStudentForm.classComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT class_id FROM class;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim classID As String = connector.reader("class_id").ToString()
                If Not String.IsNullOrEmpty(classID) Then
                    officialModifyEnrollStudentForm.classComboBox.Items.Add(classID)
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

    Private Function enrollmentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = " SELECT enrollment_id, CONCAT(fname,' ',mname,' ',lname) AS Student, enrollment_date, class_id FROM enrollment LEFT JOIN student ON enrollment.student_id = student.id"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("enrollment_id").ToString.Equals(trimmedEnrollmentID) Then
                    officialModifyEnrollStudentForm.enrollmentIDTextBox.Text = connector.reader("enrollment_id").ToString
                    officialModifyEnrollStudentForm.studentComboBox.Text = connector.reader("Student").ToString
                    officialModifyEnrollStudentForm.enrollmentDate.Text = connector.reader("enrollment_date").ToString
                    officialModifyEnrollStudentForm.classComboBox.Text = connector.reader("class_id").ToString
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
        MessageBox.Show("Enrollment not Found.")
        Return False
    End Function

    Private Function trimmedEnrollmentID() As String
        Dim enrollmentID = enrollmentIDTextBox.Text.Replace("-", "")
        Return enrollmentID
    End Function

    Private Sub makeOMESFChild()
        officialModifyEnrollStudentForm.TopLevel = False
        officialModifyEnrollStudentForm.Parent = Me.Parent
        CenterOMESF()
        officialModifyEnrollStudentForm.BringToFront()
    End Sub

    Private Sub CenterOMESF()
        Dim x As Integer = (Me.Parent.Width - officialModifyEnrollStudentForm.Width) \ 2
        Dim y As Integer = (Me.Parent.Height - officialModifyEnrollStudentForm.Height) \ 2
        officialModifyEnrollStudentForm.Location = New Point(x, y)
    End Sub

    Private Sub ModifyEnrollStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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