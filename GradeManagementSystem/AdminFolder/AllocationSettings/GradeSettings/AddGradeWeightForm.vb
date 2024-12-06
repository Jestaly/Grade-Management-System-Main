Imports MySql.Data.MySqlClient

Public Class AddGradeWeightForm
    Private connector As New DatabaseConnector
    Private Sub addPercentageButton_Click(sender As Object, e As EventArgs) Handles addPercentageButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO percentage VALUES (" & getAttendance() & "," & getQuiz() & "," & getProject() & "," & getExam() & ",'" & getDepartmentID() & "');"
            connector.command.Connection = connector.connect
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

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class