Imports MySql.Data.MySqlClient

Public Class CourseSectionForm
    Private connector As New DatabaseConnector
    Private addCourseForm As New AddCourseForm
    Private modifyCourseForm As New ModifyCourseForm
    Private Sub CourseSectionForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
    Private Function getZeros(cCount As Integer) As String
        Dim zeros As String = "000"
        Select Case cCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub CourseSectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeACFChild()
        makeMCFChild()
    End Sub
    Private Sub makeACFChild()
        addCourseForm.TopLevel = False
        addCourseForm.Parent = Me
        CenterACF()
        addCourseForm.BringToFront()
    End Sub

    Private Sub CenterACF()
        Dim x As Integer = (Me.ClientSize.Width - addCourseForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addCourseForm.Height) \ 2
        addCourseForm.Location = New Point(x, y)
    End Sub
    Private Sub makeMCFChild()
        modifyCourseForm.TopLevel = False
        modifyCourseForm.Parent = Me
        CenterMCF()
        modifyCourseForm.BringToFront()
    End Sub

    Private Sub CenterMCF()
        Dim x As Integer = (Me.ClientSize.Width - modifyCourseForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyCourseForm.Height) \ 2
        modifyCourseForm.Location = New Point(x, y)
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
        ManageProgramAdmin.Visible = True
    End Sub

    Private Sub addcoursebttn_Click(sender As Object, e As EventArgs) Handles addcoursebttn.Click
        Dim cCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM course_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                cCount = Integer.Parse(connector.reader("count").ToString())
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addCourseForm.courseIDTextBox.Text = "C" & "-" & getZeros(cCount) & (cCount + 1)
        addCourseForm.Visible = True
    End Sub

    Private Sub modifybttn_Click(sender As Object, e As EventArgs) Handles modifybttn.Click
        modifyCourseForm.Visible = True
    End Sub

    Private Sub reloadbttn_Click(sender As Object, e As EventArgs) Handles reloadbttn.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT * FROM course;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            dataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
End Class