Imports MySql.Data.MySqlClient

Public Class EnrollStudentForm
    Private connector As New DatabaseConnector
    Private Sub enrollButton_Click(sender As Object, e As EventArgs) Handles enrollButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO enrollment VALUES ('" & getEnrollmentID() & "','" & getStudentID() & "','" & enrollmentDate.Text & "','" & getClassID() & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO enrollment_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getEnrollmentID() As String
        Dim enrollmentID = enrollmentIDTextBox.Text.Replace("-", "")
        Return enrollmentID
    End Function

    Private Function getClassID() As String
        Dim classID = classComboBox.Text.Replace("-", "")
        Return classID
    End Function

    Private Function getStudentID() As String
        Dim selectedStudent As String = studentComboBox.Text
        Dim studentID As String = ""
        Try
            connector.query = "SELECT id AS ID, CONCAT(fname,' ',mname,' ',lname) AS 'Student name' FROM student;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read()
                If connector.reader("Student name").ToString IsNot Nothing And connector.reader("Student name").ToString.Equals(selectedStudent) Then
                    studentID = connector.reader("ID").ToString
                    connector.reader.Close()
                    Return studentID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return studentID
    End Function

    Private Sub classComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles classComboBox.SelectedIndexChanged
        Dim selectedClass As String = getClassID()
        Try
            connector.connect.Open()
            connector.query = "SELECT class_id,CONCAT(professor.fname,' ',professor.mname,' ',professor.lname) AS Professor, course.course_name AS Course FROM class LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read()
                If (connector.reader("class_id").ToString IsNot Nothing And connector.reader("class_id").ToString.Equals(selectedClass)) Then
                    showProfessorTextBox.Text = connector.reader("Professor").ToString
                    showCourseTextBox.Text = connector.reader("Course").ToString
                    Exit While
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub EnrollStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        showProfessorTextBox.Clear()
        showCourseTextBox.Clear()
        Me.Visible = False
    End Sub
End Class