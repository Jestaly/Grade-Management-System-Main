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
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(item_type) AS num_of_project FROM item WHERE class_id = '" & ProfessorForm.getClass & "' AND item_type = 'Project' AND term = '" & ProfessorForm.getTerm & "' ORDER BY item_type;"
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

        MessageBox.Show(ProfessorForm.classChooseBox.SelectedValue.ToString)
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO item VALUES('" & itemID & "','" & itemName & "','Project'," & maxScore & ",'" & ProfessorForm.getTerm & "','" & ProfessorForm.getClass & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            MessageBox.Show("EXECUTED")
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO item_count_history VALUES();"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        ProfessorForm.refreshForm()
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
                    iCount = Integer.Parse(connector.reader("count").ToString)
                End If
            End While
            itemID = "item" & getZeros(iCount) & (iCount + 1)
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