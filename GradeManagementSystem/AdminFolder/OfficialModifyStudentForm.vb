Public Class OfficialModifyStudentForm
    'Private modifyStudentForm As New ModifyStudentForm
    'Private manageStudentAdmin As New ManageStudentAdmin
    Private Sub OfficialModifyStudentForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub OfficialModifyStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Me.Visible = True) Then
            ' firstnameTextBox.Text = manageStudentAdmin.dataView(1, modifyStudentForm.getStudentData()).Value.ToString
            'middlenameTextBox.Text = manageStudentAdmin.dataView(2, modifyStudentForm.getStudentData()).Value.ToString
            lastnameTextBox.Text = ""
            programComboBox.Text = ""
            yearComboBox.Text = ""
            sectionComboBox.Text = ""
            departmentComboBox.Text = ""
            emailTextBox.Text = ""
            statusComboBox.Text = ""
        End If
    End Sub
End Class