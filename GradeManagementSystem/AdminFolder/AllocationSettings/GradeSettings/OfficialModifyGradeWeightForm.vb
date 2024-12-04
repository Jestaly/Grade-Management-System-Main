Imports MySql.Data.MySqlClient
Public Class OfficialModifyGradeWeightForm
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub modifyPercentageButton_Click(sender As Object, e As EventArgs) Handles modifyPercentageButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE percentage SET p_attendance = " & getAttendance() & ", p_quiz = " & getQuiz() & ", p_project = " & getProject() & ", p_exam = " & getExam() & " WHERE dept_id = '" & getDepartmentID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Modified Successfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Me.Visible = False
    End Sub

    Private Function getAttendance() As Integer
        Dim attendance As Integer = attTextBox.Text
        Return attendance
    End Function

    Private Function getQuiz() As Integer
        Dim quiz As Integer = quizTextBox.Text
        Return quiz
    End Function

    Private Function getProject() As Integer
        Dim project As Integer = projectTextBox.Text
        Return project
    End Function

    Private Function getExam() As Integer
        Dim exam As Integer = examTextBox.Text
        Return exam
    End Function

    Private Function getDepartmentID() As String
        Dim selectedDept As String = deptComboBox.Text
        Dim deptID As String = ""
        Try
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("dept_name").ToString IsNot Nothing And connector.reader("dept_name").ToString.Equals(selectedDept) Then
                    deptID = connector.reader("dept_id").ToString
                    connector.reader.Close()
                    Return deptID
                End If
            End While
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return deptID
    End Function

End Class