Imports MySql.Data.MySqlClient

Public Class ModifyStudentForm
    Private connector As New DatabaseConnector
    Private officialModifyStudentForm As New OfficialModifyStudentForm
    Private manageStudentAdmin As New ManageStudentAdmin

    Private Sub ModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub getStudentData()
        Dim getID = Integer.Parse(studentIDTextBox.Text)
        officialModifyStudentForm.firstnameTextBox.Text = manageStudentAdmin.dataView(1, getID).Value
        officialModifyStudentForm.middlenameTextBox.Text = manageStudentAdmin.dataView(2, getID).Value
        officialModifyStudentForm.lastnameTextBox.Text = ""
        officialModifyStudentForm.programComboBox.Text = ""
        officialModifyStudentForm.yearComboBox.Text = ""
        officialModifyStudentForm.sectionComboBox.Text = ""
        officialModifyStudentForm.departmentComboBox.Text = ""
        officialModifyStudentForm.emailTextBox.Text = ""
        officialModifyStudentForm.statusComboBox.Text = ""

    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If (studentExists()) Then
            getStudentData()
            officialModifyStudentForm.Visible = True
        End If
    End Sub
    Private Function studentExists() As Boolean
        Try
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) FROM student_info WHERE sid = ?sid;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.Parameters.AddWithValue("?sid", studentIDTextBox.Text)
            Dim Count = Convert.ToInt32(connector.command.ExecuteScalar())
            If (Count > 0) Then
                connector.connect.Close()
                connector.command.Parameters.Clear()
                Return True
            End If
        Catch ex As MySqlException
            connector.connect.Close()
            connector.command.Parameters.Clear()
            MessageBox.Show("Database Error")
            Return False
        End Try
        connector.connect.Close()
        connector.command.Parameters.Clear()
        MessageBox.Show("Student not found.")
        Return False
    End Function
End Class