Imports System.Security.Permissions
Imports MySql.Data.MySqlClient

Public Class OfficialModifyProgramForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyProgramForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Function getDepartmentID() As String
        Dim selectedDept As String = departmentComboBox.Text
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

    Private Sub modifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE program SET program_name = '" & programnameTextBox.Text & "', year_added = '" & yearAddedTextBox.Text & "', sections = " & sectionBox.Text & ", dept_id = '" & getDepartmentID() & "' WHERE program_id = '" & trimmedProgID() & "';"
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

    Private Function trimmedProgID() As String
        Dim progID As String = programIDTextBox.Text
        progID = progID.Replace("-", "")
        Return progID
    End Function
    Private Sub OfficialModifyProgramForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Visible = False
    End Sub
End Class