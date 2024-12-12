Imports MySql.Data.MySqlClient
Public Class AllocationManagerAdminvb
    Private connector As New DatabaseConnector
    Private gradeSectionForm As New GradeSectionForm
    Private enrollStudentForm As New EnrollStudentForm
    Private modifyEnrollStudentForm As New ModifyEnrollStudentForm
    Private classSectionForm As New ClassSectionForm
    Private Sub AllocationManagerAdminvb_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub gradeSectionButton_Click(sender As Object, e As EventArgs) Handles gradeSectionButton.Click
        Me.Visible = False
        gradeSectionForm.Visible = True
    End Sub

    Private Function getZeros(numCount As Integer) As String
        Dim zeros As String = "000"
        Select Case numCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub AllocationManagerAdminvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeESFChild()
        makeMESFChild()
    End Sub

    Private Sub makeESFChild()
        enrollStudentForm.TopLevel = False
        enrollStudentForm.Parent = Me
        CenterESF()
        enrollStudentForm.BringToFront()
    End Sub

    Private Sub CenterESF()
        Dim x As Integer = (Me.ClientSize.Width - enrollStudentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - enrollStudentForm.Height) \ 2
        enrollStudentForm.Location = New Point(x, y)
    End Sub

    Private Sub makeMESFChild()
        modifyEnrollStudentForm.TopLevel = False
        modifyEnrollStudentForm.Parent = Me
        CenterMESF()
        modifyEnrollStudentForm.BringToFront()
    End Sub

    Private Sub CenterMESF()
        Dim x As Integer = (Me.ClientSize.Width - modifyEnrollStudentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyEnrollStudentForm.Height) \ 2
        modifyEnrollStudentForm.Location = New Point(x, y)
    End Sub
    Private Sub enrollStudentButton_Click(sender As Object, e As EventArgs) Handles enrollStudentButton.Click
        Dim eCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM enrollment_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                eCount = Integer.Parse(connector.reader("count").ToString())
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        enrollStudentForm.enrollmentIDTextBox.Text = "E" & getZeros(eCount) & (eCount + 1)
        loadStudent()
        loadClass()
        enrollStudentForm.Visible = True
    End Sub

    Private Sub loadStudent()
        Try
            enrollStudentForm.studentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS Student FROM student;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim studentName As String = connector.reader("Student").ToString()
                If Not String.IsNullOrEmpty(studentName) Then
                    enrollStudentForm.studentComboBox.Items.Add(studentName)
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

    Private Sub loadClass()
        Try
            enrollStudentForm.classComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT class_id FROM class;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim classID As String = connector.reader("class_id").ToString()
                If Not String.IsNullOrEmpty(classID) Then
                    Dim tempID As String = ""
                    For i As Integer = 0 To classID.Length - 1
                        If (i = 2) Then
                            tempID &= "-"
                        End If
                        tempID &= classID.Chars(i)
                    Next
                    classID = tempID
                    enrollStudentForm.classComboBox.Items.Add(classID)
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

    Private Sub modifyEnrollButton_Click(sender As Object, e As EventArgs) Handles modifyEnrollButton.Click
        modifyEnrollStudentForm.Visible = True
    End Sub

    Private Sub classSectionButton_Click(sender As Object, e As EventArgs) Handles classSectionButton.Click
        Me.Visible = False
        classSectionForm.Visible = True
    End Sub

    Private Sub reloadbttn_Click(sender As Object, e As EventArgs) Handles reloadbttn.Click
        Try
            connector.dataTable.Clear()
            connector.query = "Select enrollment_id, CONCAT(student.fname,' ',student.mname,' ',student.lname) AS Student, CONCAT(professor.fname,' ',professor.mname,' ',professor.lname) AS Professor, course.course_name AS Course,course.units AS Units FROM enrollment LEFT JOIN student ON enrollment.student_id = student.id LEFT JOIN class ON enrollment.class_id = class.class_id LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            enrollDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
End Class