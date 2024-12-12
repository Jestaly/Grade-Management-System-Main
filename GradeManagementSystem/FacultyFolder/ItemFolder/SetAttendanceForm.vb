Imports System.Security.Permissions
Imports MySql.Data.MySqlClient
Public Class SetAttendanceForm
    Private connector As New DatabaseConnector
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub numDaysButton_Click(sender As Object, e As EventArgs) Handles numDaysButton.Click
        Dim classID As String = LoginForgot.gradingSheet.classChooseBox.Text
        Dim itemID As String = getItemID()
        Dim itemName As String = "A1"
        Dim days As Integer = Integer.Parse(numDaysTextBox.Text)
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO item VALUES('" & getItemID() & "','" & itemName & "','Attendance'," & Days & ",'" & GradingSheet.getTerm & "','" & classID & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            GradingSheet.attendanceButton.Enabled = False
            Me.Visible = False
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        fillAttendanceDays(days)
    End Sub

    'to be fixed -- query wrong
    Private Sub fillAttendanceDays(days As Integer)
        Dim classID As String = LoginForgot.gradingSheet.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(enrollment.student_id) AS Student FROM enrollment LEFT JOIN student ON enrollment.student_id = student.id  WHERE enrollment.class_id = '" & classID & "' LEFT JOIN item WHERE item.term = '" & GradingSheet.getTerm & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer
            While connector.reader.Read
                GradingSheet.attendanceDataView.Rows(i).Cells(0).Value = Days
                i += 1
            End While
            GradingSheet.attendanceButton.Enabled = False
            Me.Visible = False
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getItemID() As String
        Dim iCount As Integer = 0
        Dim itemID As String = ""
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM item_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (Not connector.reader("count").ToString.Equals("")) Then
                    iCount = Integer.Parse(connector.reader("count").ToString) + 1
                End If
            End While
            itemID = "item" & getZeros(iCount) & (iCount)
            connector.connect.Close()
            connector.reader.Close()
            Return itemID
        Catch ex As MySqlException
            connector.connect.Close()
            connector.reader.Close()
            MessageBox.Show("Database Error")
        End Try
        Return itemID
    End Function

    Private Function getZeros(iCount As Integer) As String
        Dim zeros As String = "000"
        Select Case iCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function
End Class