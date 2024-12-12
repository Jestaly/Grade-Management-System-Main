Imports MySql.Data.MySqlClient

Public Class ModifyDepartmentForm
    Private connector As New DatabaseConnector
    Private officialModifyDepartmentForm As New OfficialModifyDepartmentForm

    Private Sub ModifyDepartmentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (departmentExists()) Then
            Me.Visible = False
            makeOMDFChild()
            officialModifyDepartmentForm.Visible = True
        End If
    End Sub
    Private Function departmentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If connector.reader("dept_id").ToString.Equals(trimmedDeptID) Then
                    officialModifyDepartmentForm.deptIDTextBox.Text = connector.reader("dept_id").ToString
                    officialModifyDepartmentForm.departmentHeadTextBox.Text = connector.reader("dept_head").ToString
                    officialModifyDepartmentForm.departmentNameTextBox.Text = connector.reader("dept_name").ToString
                    connector.connect.Close()
                    connector.reader.Close()
                    Return True
                End If
            End While
        Catch ex As MySqlException
            connector.reader.Close()
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.reader.Close()
        connector.connect.Close()
        MessageBox.Show("Department not Found.")
        Return False
    End Function

    Private Function trimmedDeptID() As String
        Dim deptID = departmentIDTextBox.Text.Replace("-", "")
        Return deptID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs)
        Visible = False
    End Sub
    Private Sub makeOMDFChild()
        officialModifyDepartmentForm.TopLevel = False
        officialModifyDepartmentForm.Parent = Me.Parent
        CenterOMDF()
        officialModifyDepartmentForm.BringToFront()
    End Sub

    Private Sub CenterOMDF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - officialModifyDepartmentForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - officialModifyDepartmentForm.Height) \ 2
        officialModifyDepartmentForm.Location = New Point(x, y)
    End Sub

    Private Sub ModifyDepartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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