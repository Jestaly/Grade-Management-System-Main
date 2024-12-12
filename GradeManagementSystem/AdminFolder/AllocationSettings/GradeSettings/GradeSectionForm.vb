Imports MySql.Data.MySqlClient
Public Class GradeSectionForm
    Private connector As New DatabaseConnector
    Private addGradeWeightForm As New AddGradeWeightForm
    Private modifyGradeWeightForm As New ModifyGradeWeightForm
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
                    addGradeWeightForm.deptComboBox.Items.Add(departmentName)
                End If
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub GradeSectionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makeAGWFChild()
        makeMGWFChild()
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

    Private Sub makeAGWFChild()
        addGradeWeightForm.TopLevel = False
        addGradeWeightForm.Parent = Me
        CenterAGWF()
        addGradeWeightForm.BringToFront()
    End Sub

    Private Sub CenterAGWF()
        Dim x As Integer = (Me.ClientSize.Width - addGradeWeightForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addGradeWeightForm.Height) \ 2
        addGradeWeightForm.Location = New Point(x, y)
    End Sub

    Private Sub makeMGWFChild()
        modifyGradeWeightForm.TopLevel = False
        modifyGradeWeightForm.Parent = Me
        CenterMGWF()
        modifyGradeWeightForm.BringToFront()
    End Sub

    Private Sub CenterMGWF()
        Dim x As Integer = (Me.ClientSize.Width - modifyGradeWeightForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - modifyGradeWeightForm.Height) \ 2
        modifyGradeWeightForm.Location = New Point(x, y)
    End Sub

    Private Sub reloadbttn_Click(sender As Object, e As EventArgs) Handles reloadbttn.Click
        Try
            connector.dataTable.Clear()
            connector.connect.Open()
            connector.query = "SELECT percentage.dept_id, department.dept_name AS Department,p_attendance AS Attendance,p_quiz AS Quiz,p_project AS Project,p_exam AS Exam FROM percentage LEFT JOIN department ON percentage.dept_id = department.dept_id;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            gradeWeightDataView.DataSource = connector.dataTable
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub addgradebttn_Click(sender As Object, e As EventArgs) Handles addgradebttn.Click
        loadDepartment()
        addGradeWeightForm.Visible = True
    End Sub

    Private Sub modifybttn_Click(sender As Object, e As EventArgs) Handles modifybttn.Click
        modifyGradeWeightForm.Visible = True
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub
End Class