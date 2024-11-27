<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyDepartmentForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label3 = New Label()
        Label2 = New Label()
        departmentIDLabel = New Label()
        departmentNameTextBox = New TextBox()
        departmentHeadTextBox = New TextBox()
        clearButton = New Button()
        modifyDepartmentButton = New Button()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 21
        Label3.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 20
        Label2.Text = "Department Name"
        ' 
        ' departmentIDLabel
        ' 
        departmentIDLabel.AutoSize = True
        departmentIDLabel.Location = New Point(34, 8)
        departmentIDLabel.Name = "departmentIDLabel"
        departmentIDLabel.Size = New Size(50, 20)
        departmentIDLabel.TabIndex = 19
        departmentIDLabel.Text = "D-000"
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Location = New Point(160, 41)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(172, 27)
        departmentNameTextBox.TabIndex = 18
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Location = New Point(160, 93)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(172, 27)
        departmentHeadTextBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(34, 171)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(153, 29)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' modifyDepartmentButton
        ' 
        modifyDepartmentButton.Location = New Point(34, 136)
        modifyDepartmentButton.Name = "modifyDepartmentButton"
        modifyDepartmentButton.Size = New Size(153, 29)
        modifyDepartmentButton.TabIndex = 15
        modifyDepartmentButton.Text = "Modify Department"
        modifyDepartmentButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(247, 171)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 22
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' OfficialModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(371, 215)
        Controls.Add(backButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(departmentIDLabel)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(modifyDepartmentButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "OfficialModifyDepartmentForm"
        Text = "OfficialModifyDepartmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents departmentIDLabel As Label
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents modifyDepartmentButton As Button
    Friend WithEvents backButton As Button
End Class
