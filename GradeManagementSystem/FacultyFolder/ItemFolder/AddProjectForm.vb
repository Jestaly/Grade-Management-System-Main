Imports System.Security.Permissions
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class AddProjectForm
    Private connector As New DatabaseConnector

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub AddProjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function getNumProject() As Integer
        Dim classID As String = LoginForm.professorForm.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(item_type) AS num_of_project FROM item WHERE class_id = '" & classID & "' AND item_type = 'Project' AND term = '" & ProfessorForm.getTerm & "' ORDER BY item_type;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("num_of_project").ToString.Equals("")) Then
                    Return 0
                End If
                Dim numOfProject As Integer = Integer.Parse(connector.reader("num_of_project").ToString)
                connector.connect.Close()
                connector.reader.Close()
                Return numOfProject
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return 0
    End Function

    Private Sub maxScoreButton_Click(sender As Object, e As EventArgs) Handles maxScoreButton.Click
        Dim itemID As String = getItemID()
        Dim maxScore As Integer = Integer.Parse(maxScoreTextBox.Text)
        Dim itemName = "Project " & (getNumProject() + 1)
        Dim classID As String = LoginForm.professorForm.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO item VALUES('" & itemID & "','" & itemName & "','Project'," & maxScore & ",'" & ProfessorForm.getTerm & "','" & classID & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO item_count_history VALUES();"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
            setScores(itemID, classID)
            Me.Visible = False
            MessageBox.Show("Added Successfully!")
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        ProfessorForm.refreshForm()
    End Sub

    Private Sub setScores(itemID As String, classID As String)
        Dim enrollID(getEnrollSize(classID) - 1) As String
        Try
            connector.connect.Open()
            connector.query = "SELECT enrollment_id FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            Dim i As Integer
            While connector.reader.Read
                If (Not connector.reader("enrollment_id").ToString.Equals("")) Then
                    enrollID(i) = connector.reader("enrollment_id").ToString
                    i += 1
                End If
            End While
            connector.reader.Close()
            For j As Integer = 0 To enrollID.Length - 1
                If (Not enrollID(j).Equals("")) Then
                    connector.query = "INSERT INTO score_record VALUES ('" & enrollID(j) & "','" & itemID & "', 0);"
                    connector.command.CommandText = connector.query
                    connector.command.ExecuteNonQuery()
                End If
            Next
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Function getEnrollSize(classID As String) As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(enrollment_id) AS enrollment_id FROM enrollment WHERE class_id = '" & classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                Dim classIDCount As Integer = Integer.Parse(connector.reader("enrollment_id").ToString)
                connector.reader.Close()
                connector.connect.Close()
                Return classIDCount
            End While
            connector.reader.Close()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Return 0
    End Function

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