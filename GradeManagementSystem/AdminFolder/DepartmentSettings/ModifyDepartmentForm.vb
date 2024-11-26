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
            connectToOMDF()
        End If
    End Sub

    Private Function departmentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageDepartmentAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageDepartmentAdmin.dataView.Rows
                If (row.Cells("dept_id").Value IsNot Nothing AndAlso row.Cells("dept_id").Value.ToString.Equals(trimmedDeptID())) Then
                    connector.connect.Close()
                    Return True
                End If
            Next
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        MessageBox.Show("Department not Found.")
        Return False
    End Function
    Private Sub connectToOMDF()
        Dim rowIndex As Integer = -1
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM department;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(connector.dataTable)
            ManageDepartmentAdmin.dataView.DataSource = connector.dataTable
            For Each row As DataGridViewRow In ManageDepartmentAdmin.dataView.Rows
                If (row.Cells("dept_id").Value IsNot Nothing AndAlso row.Cells("dept_id").Value.ToString.Equals(trimmedDeptID())) Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next
            getDepartmentData(rowIndex)
            officialModifyDepartmentForm.Visible = True
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub getDepartmentData(rowIndex As Integer)
        officialModifyDepartmentForm.departmentIDLabel.Text = ManageDepartmentAdmin.dataView(0, rowIndex).Value
        officialModifyDepartmentForm.departmentHeadTextBox.Text = ManageDepartmentAdmin.dataView(1, rowIndex).Value
        officialModifyDepartmentForm.departmentNameTextBox.Text = ManageDepartmentAdmin.dataView(2, rowIndex).Value
    End Sub

    Private Function trimmedDeptID() As String
        Dim deptID = departmentIDTextBox.Text.Replace("-", "")
        Return deptID
    End Function
End Class