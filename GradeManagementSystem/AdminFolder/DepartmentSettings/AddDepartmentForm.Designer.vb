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
        Label = New Label()
        departmentNameTextBox = New TextBox()
        departmentHeadTextBox = New TextBox()
        clearButton = New Button()
        addDepartmentButton = New Button()
        backButton = New Button()
        departmentIDTextBox = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(49, 157)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 29)
        Label3.TabIndex = 14
        Label3.Text = "Department Head:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(44, 110)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 29)
        Label2.TabIndex = 13
        Label2.Text = "Department Name:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(68, 69)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(138, 29)
        Label.TabIndex = 12
        Label.Text = "Department ID:"
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Location = New Point(196, 114)
        departmentNameTextBox.Margin = New Padding(4, 4, 4, 4)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(228, 30)
        departmentNameTextBox.TabIndex = 11
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Location = New Point(196, 158)
        departmentHeadTextBox.Margin = New Padding(4, 4, 4, 4)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(228, 30)
        departmentHeadTextBox.TabIndex = 10
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.Location = New Point(259, 263)
        clearButton.Margin = New Padding(4, 4, 4, 4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(75, 37)
        clearButton.TabIndex = 9
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' addDepartmentButton
        ' 
        addDepartmentButton.BackColor = Color.DarkSeaGreen
        addDepartmentButton.FlatStyle = FlatStyle.Popup
        addDepartmentButton.Font = New Font("Sitka Banner", 9F)
        addDepartmentButton.Location = New Point(46, 263)
        addDepartmentButton.Margin = New Padding(4, 4, 4, 4)
        addDepartmentButton.Name = "addDepartmentButton"
        addDepartmentButton.Size = New Size(145, 37)
        addDepartmentButton.TabIndex = 8
        addDepartmentButton.Text = "Add Department"
        addDepartmentButton.UseVisualStyleBackColor = False
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.Location = New Point(341, 263)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(83, 37)
        backButton.TabIndex = 15
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' departmentIDTextBox
        ' 
        departmentIDTextBox.Enabled = False
        departmentIDTextBox.Location = New Point(196, 73)
        departmentIDTextBox.Margin = New Padding(4, 4, 4, 4)
        departmentIDTextBox.Mask = "L-000"
        departmentIDTextBox.Name = "departmentIDTextBox"
        departmentIDTextBox.PromptChar = "X"c
        departmentIDTextBox.Size = New Size(104, 30)
        departmentIDTextBox.TabIndex = 16
        ' 
        ' AddDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(484, 353)
        Controls.Add(departmentIDTextBox)
        Controls.Add(backButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(addDepartmentButton)
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "AddDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddDepartmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents addDepartmentButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents departmentIDTextBox As MaskedTextBox
End Class
