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
        Label = New Label()
        departmentNameTextBox = New TextBox()
        departmentHeadTextBox = New TextBox()
        clearButton = New Button()
        modifyDepartmentButton = New Button()
        backButton = New Button()
        deptIDTextBox = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(46, 151)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 29)
        Label3.TabIndex = 21
        Label3.Text = "Department Head:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(41, 107)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 29)
        Label2.TabIndex = 20
        Label2.Text = "Department Name:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.BackColor = SystemColors.Control
        Label.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(70, 69)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(138, 29)
        Label.TabIndex = 19
        Label.Text = "Department ID:"
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Location = New Point(208, 111)
        departmentNameTextBox.Margin = New Padding(4, 5, 4, 5)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(214, 33)
        departmentNameTextBox.TabIndex = 18
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Location = New Point(208, 155)
        departmentHeadTextBox.Margin = New Padding(4, 5, 4, 5)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(214, 33)
        departmentHeadTextBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.ForeColor = Color.Black
        clearButton.Location = New Point(254, 237)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(85, 42)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' modifyDepartmentButton
        ' 
        modifyDepartmentButton.BackColor = Color.DarkSeaGreen
        modifyDepartmentButton.FlatStyle = FlatStyle.Popup
        modifyDepartmentButton.Font = New Font("Sitka Banner", 9F)
        modifyDepartmentButton.ForeColor = Color.Black
        modifyDepartmentButton.Location = New Point(41, 236)
        modifyDepartmentButton.Margin = New Padding(4, 5, 4, 5)
        modifyDepartmentButton.Name = "modifyDepartmentButton"
        modifyDepartmentButton.Size = New Size(182, 45)
        modifyDepartmentButton.TabIndex = 15
        modifyDepartmentButton.Text = "Modify Department"
        modifyDepartmentButton.UseVisualStyleBackColor = False
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.ForeColor = Color.Black
        backButton.Location = New Point(347, 237)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(92, 42)
        backButton.TabIndex = 22
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' deptIDTextBox
        ' 
        deptIDTextBox.Enabled = False
        deptIDTextBox.Location = New Point(208, 69)
        deptIDTextBox.Margin = New Padding(4, 5, 4, 5)
        deptIDTextBox.Mask = "L-000"
        deptIDTextBox.Name = "deptIDTextBox"
        deptIDTextBox.PromptChar = "X"c
        deptIDTextBox.Size = New Size(155, 33)
        deptIDTextBox.TabIndex = 23
        ' 
        ' OfficialModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(484, 353)
        Controls.Add(deptIDTextBox)
        Controls.Add(backButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(modifyDepartmentButton)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyDepartmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents modifyDepartmentButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents deptIDTextBox As MaskedTextBox
End Class
