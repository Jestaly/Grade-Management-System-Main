Imports MySql.Data.MySqlClient

Public Class OfficialModifyDepartmentForm
    Private connector As New DatabaseConnector
    Private Sub modifyDepartmentButton_Click(sender As Object, e As EventArgs) Handles modifyDepartmentButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE department SET dept_name = '" & departmentNameTextBox.Text & "', dept_head = '" & departmentHeadTextBox.Text & "' WHERE dept_id = '" & trimmedDeptID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Modified Successfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Visible = False
    End Sub

    Private Function trimmedDeptID() As String
        Dim deptID As String = deptIDTextBox.Text
        deptID = deptID.Replace("-", "")
        Return deptID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs)
        Visible = False
    End Sub

    Private Sub OfficialModifyDepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class