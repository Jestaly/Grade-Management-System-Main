Imports MySql.Data.MySqlClient

Public Class ManageProgramAdmin
    Private connector As New DatabaseConnector
    Private courseSectionForm As New CourseSectionForm
    Private addProgramForm As New AddProgramForm
    Private modifyProgramForm As New ModifyProgramForm
    Private Sub ManageProgramAdmin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT program.program_id AS ID,program.program_name AS Program,department.dept_name AS Department,program.sections AS Sections,program.year_added AS 'Date created' FROM program LEFT JOIN department ON program.dept_id = department.dept_id;"
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

    Private Sub courseSectionButton_Click(sender As Object, e As EventArgs) Handles courseSectionButton.Click
        courseSectionForm.Visible = True
        Me.Visible = False
    End Sub

    Private Sub addProgramButton_Click(sender As Object, e As EventArgs) Handles addProgramButton.Click
        Dim pCount As Integer
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM prog_count_history ORDER BY count DESC LIMIT 1;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            pCount = connector.command.ExecuteScalar
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        addProgramForm.programIDLabel.Text = "P" & "-" & getZeros(pCount) & (pCount + 1)
        addProgramForm.Visible = True
    End Sub

    Private Function getZeros(pCount As Integer) As String
        Dim zeros As String = "000"
        Select Case pCount.ToString.Length
            Case 1
                zeros = "00"
            Case 2
                zeros = "0"
            Case 3
                zeros = ""
        End Select
        Return zeros
    End Function

    Private Sub modifyProgramButton_Click(sender As Object, e As EventArgs) Handles modifyProgramButton.Click
        modifyProgramForm.Visible = True
    End Sub

    Private Sub ManageProgramAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeAPFChild()
        makeMPFChild()
    End Sub

    Private Sub makeAPFChild()
        addProgramForm.TopLevel = False
        addProgramForm.Parent = Me
        CenterAPF()
        addProgramForm.BringToFront()
    End Sub

    Private Sub CenterAPF()
        Dim x As Integer = (Me.ClientSize.Width - addProgramForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addProgramForm.Height) \ 2
        addProgramForm.Location = New Point(x, y)
    End Sub

    Private Sub makeMPFChild()
        modifyProgramForm.TopLevel = False
        modifyProgramForm.Parent = Me
        CenterMPF()
        modifyProgramForm.BringToFront()
    End Sub

    Private Sub CenterMPF()
        Dim x As Integer = (Me.Width - modifyProgramForm.Width) \ 2
        Dim y As Integer = (Me.Height - modifyProgramForm.Height) \ 2
        modifyProgramForm.Location = New Point(x, y)
    End Sub
End Class