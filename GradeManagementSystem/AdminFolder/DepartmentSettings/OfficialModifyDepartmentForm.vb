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
        Dim deptID As String = departmentIDLabel.Text
        deptID = deptID.Replace("-", "")
        Return deptID
    End Function

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub
End Class