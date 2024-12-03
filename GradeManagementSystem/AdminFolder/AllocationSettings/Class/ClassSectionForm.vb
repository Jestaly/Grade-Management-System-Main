Imports MySql.Data.MySqlClient

Public Class ClassSectionForm
    Private connector As New DatabaseConnector
    Private createClassForm As New CreateClassForm
    Private modifyClassForm As New ModifyClassForm
    Private Sub createClassButton_Click(sender As Object, e As EventArgs) Handles createClassButton.Click
        Dim clCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM class_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            clCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        createClassForm.classIDTextBox.Text = "CL" & getZeros(clCount) & (clCount + 1)
        loadCourse()
        loadProfessor()
        createClassForm.Visible = True
    End Sub

    Private Sub loadCourse()
        Try
            createClassForm.courseComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT course_name AS 'course' FROM course;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim courseName As String = connector.reader("course").ToString()
                If Not String.IsNullOrEmpty(courseName) Then
                    createClassForm.courseComboBox.Items.Add(courseName)
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
            createClassForm.professorComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS 'Professor name' FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim professorName As String = connector.reader("Professor name").ToString()
                If Not String.IsNullOrEmpty(professorName) Then
                    CreateClassForm.professorComboBox.Items.Add(professorName)
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

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT class.class_id,CONCAT(professor.fname,' ',professor.mname,' ', professor.lname) AS 'Professor', course.course_name, CONCAT(DATE_FORMAT(time_start, '%H:%i'),time_history.start_abbreviation,'-',DATE_FORMAT(time_end, '%H:%i'),time_history.end_abbreviation) AS 'Class Period', day AS Day FROM class LEFT JOIN professor ON class.professor_id = professor.id LEFT JOIN course ON class.course_id = course.course_id LEFT JOIN time_history ON class.class_id = time_history.class_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            classDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub modifyClassButton_Click(sender As Object, e As EventArgs) Handles modifyClassButton.Click
        modifyClassForm.Visible = True
    End Sub

    Private Sub ClassSectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeCCLFChild()
        makeMCLFChild()
    End Sub

    Private Sub makeCCLFChild()
        createClassForm.TopLevel = False
        createClassForm.Parent = Me
        CenterCCLF()
        createClassForm.BringToFront()
    End Sub

    Private Sub CenterCCLF()
        Dim x As Integer = (Me.ClientSize.Width - createClassForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - createClassForm.Height) \ 2
        createClassForm.Location = New Point(x, y)
    End Sub

    Private Sub makeMCLFChild()
        modifyClassForm.TopLevel = False
        modifyClassForm.Parent = Me
        CenterMCLF()
        modifyClassForm.BringToFront()
    End Sub

    Private Sub CenterMCLF()
        Dim x As Integer = (Me.ClientSize.Width - modifyClassForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyClassForm.Height) \ 2
        modifyClassForm.Location = New Point(x, y)
    End Sub

    Private Sub enrollmentSectionButton_Click(sender As Object, e As EventArgs) Handles enrollmentSectionButton.Click
        Me.Visible = False
        AllocationManagerAdminvb.Visible = True
    End Sub
End Class