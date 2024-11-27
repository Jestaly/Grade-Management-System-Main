Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class ManageStudentAdmin
    Private addStudentForm As New AddStudentAccount
    Private modifyStudentForm As New ModifyStudentForm
    Private connector As New DatabaseConnector
    Private Sub addStudent_Click(sender As Object, e As EventArgs) Handles addStudent.Click
        Dim sCount As Integer
        Try
            addStudentForm.programComboBox.Items.Clear()
            loadProgram()
            connector.connect.Open()
            connector.query = "SELECT * FROM student_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            sCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addStudentForm.studentIDTextBox.Text = getStudNum() & "-" & getStudYear() & "-" & getZeros(sCount) & (sCount + 1)
        addStudentForm.Visible = True
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
                    addStudentForm.programComboBox.Items.Add(programName)
                End If
            End While
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getStudNum() As String
        Dim idInt As Integer
        idInt = 1
        Dim studNum As String = idInt
        Return studNum
    End Function

    Private Function getStudYear() As Integer
        Dim studYear As String = DateAndTime.Now.Year
        studYear = studYear.Chars(2) & studYear.Chars(3)
        Return studYear
    End Function

    Private Function getZeros(sCount As Integer) As String
        Dim zeros As String = "00000"
        Select Case sCount.ToString.Length
            Case 1
                zeros = "0000"
            Case 2
                zeros = "000"
            Case 3
                zeros = "00"
            Case 4
                zeros = "0"
            Case 5
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub ManageStudentAdmin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT student.id,student.lname,student.fname,student.mname,student.birthdate,program.program_name,student.year,student.section,student.email FROM student LEFT JOIN program ON student.program_id = program.program_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.connect.Close()
            connector.command.Parameters.Clear()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub modifyStudent_Click(sender As Object, e As EventArgs) Handles modifyStudent.Click
        modifyStudentForm.Visible = True
    End Sub

    Private Sub searchStudent_Click(sender As Object, e As EventArgs) Handles searchStudent.Click
        Try
            Dim studentDetail = searchStudentField.Text
            connector.connect.Open()
            connector.dataTable.Clear()
            connector.query = "SELECT * FROM student_info WHERE CONCAT(fname,' ',mname,' ',lname) = ?fullname OR CONCAT(fname,' ',mname) = ?fullname OR CONCAT(fname,' ',lname) = ?fullname;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.Parameters.AddWithValue("?fullname", studentDetail)
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.connect.Close()
            connector.command.Parameters.Clear()
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub ManageStudentAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeASFChild()
        makeMSFChild()
    End Sub

    Private Sub makeASFChild()
        addStudentForm.TopLevel = False
        addStudentForm.Parent = Me
        CenterASF()
        addStudentForm.BringToFront()
    End Sub

    Private Sub CenterASF()
        Dim x As Integer = (Me.ClientSize.Width - addStudentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addStudentForm.Height) \ 2
        addStudentForm.Location = New Point(x, y)
    End Sub
    Private Sub makeMSFChild()
        modifyStudentForm.TopLevel = False
        modifyStudentForm.Parent = Me
        CenterMSF()
        modifyStudentForm.BringToFront()
    End Sub

    Private Sub CenterMSF()
        Dim x As Integer = (Me.ClientSize.Width - modifyStudentForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyStudentForm.Height) \ 2
        modifyStudentForm.Location = New Point(x, y)
    End Sub
End Class