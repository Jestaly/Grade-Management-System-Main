Imports MySql.Data.MySqlClient
Public Class ModifyGradeWeightForm
    Private connector As New DatabaseConnector
    Private officialModifyGradeWeightForm As New OfficialModifyGradeWeightForm
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        loadDepartment()
        If (departmentExists()) Then
            Me.Visible = False
            makeOMGWFChild()
            officialModifyGradeWeightForm.Visible = True
        End If
    End Sub

    Private Sub loadDepartment()
        Try
            AddProgramForm.departmentComboBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT dept_name FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader()
            While connector.reader.Read()
                Dim departmentName As String = connector.reader("dept_name").ToString()
                If Not String.IsNullOrEmpty(departmentName) Then
                    officialModifyGradeWeightForm.deptComboBox.Items.Add(departmentName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function departmentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT percentage.dept_id, department.dept_name AS Department,p_attendance AS Attendance,p_quiz AS Quiz,p_project AS Project,p_exam AS Exam FROM percentage LEFT JOIN department ON percentage.dept_id = department.dept_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("dept_id").ToString.Equals(trimmedDeptID) Then
                    officialModifyGradeWeightForm.attTextBox.Text = connector.reader("Attendance").ToString
                    officialModifyGradeWeightForm.quizTextBox.Text = connector.reader("Quiz").ToString
                    officialModifyGradeWeightForm.projectTextBox.Text = connector.reader("Project").ToString
                    officialModifyGradeWeightForm.examTextBox.Text = connector.reader("Exam").ToString
                    officialModifyGradeWeightForm.deptComboBox.Text = connector.reader("Department").ToString
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
        MessageBox.Show("Grade Weight Record not Found.")
        Return False
    End Function

    Private Function trimmedDeptID() As String
        Dim deptID = deptIDTextBox.Text.Replace("-", "")
        Return deptID
    End Function

    Private Sub makeOMGWFChild()
        officialModifyGradeWeightForm.TopLevel = False
        officialModifyGradeWeightForm.Parent = Me.Parent
        CenterOMGWF()
        officialModifyGradeWeightForm.BringToFront()
    End Sub

    Private Sub CenterOMGWF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyGradeWeightForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyGradeWeightForm.Height) \ 2
        officialModifyGradeWeightForm.Location = New Point(x, y)
    End Sub
End Class