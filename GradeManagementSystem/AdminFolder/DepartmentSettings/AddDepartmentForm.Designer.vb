<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartmentForm
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
        addDepartmentButton = New Button()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 20)
        Label3.TabIndex = 14
        Label3.Text = "Department Head"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(58, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 20)
        Label2.TabIndex = 13
        Label2.Text = "Department Name"
        ' 
        ' departmentIDLabel
        ' 
        departmentIDLabel.AutoSize = True
        departmentIDLabel.Location = New Point(79, 30)
        departmentIDLabel.Name = "departmentIDLabel"
        departmentIDLabel.Size = New Size(50, 20)
        departmentIDLabel.TabIndex = 12
        departmentIDLabel.Text = "D-000"
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Location = New Point(197, 98)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(172, 27)
        departmentNameTextBox.TabIndex = 11
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Location = New Point(197, 150)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(172, 27)
        departmentHeadTextBox.TabIndex = 10
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(79, 270)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(129, 29)
        clearButton.TabIndex = 9
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' addDepartmentButton
        ' 
        addDepartmentButton.Location = New Point(79, 235)
        addDepartmentButton.Name = "addDepartmentButton"
        addDepartmentButton.Size = New Size(129, 29)
        addDepartmentButton.TabIndex = 8
        addDepartmentButton.Text = "Add Department"
        addDepartmentButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(275, 21)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 15
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(407, 309)
        Controls.Add(backButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(departmentIDLabel)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(addDepartmentButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddDepartmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents departmentIDLabel As Label
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents addDepartmentButton As Button
    Friend WithEvents backButton As Button
End Class
