<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateClassForm
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
        backButton = New Button()
        courseComboBox = New ComboBox()
        professorComboBox = New ComboBox()
        clearButton = New Button()
        classIDTextBox = New MaskedTextBox()
        Label3 = New Label()
        createClassButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(271, 29)
        backButton.Name = "backButton"
        backButton.Size = New Size(100, 29)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' courseComboBox
        ' 
        courseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(99, 119)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(151, 28)
        courseComboBox.TabIndex = 18
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(99, 83)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(151, 28)
        professorComboBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(99, 196)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(100, 29)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Location = New Point(82, 30)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(100, 27)
        classIDTextBox.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 14
        Label3.Text = "Course"
        ' 
        ' createClassButton
        ' 
        createClassButton.Location = New Point(99, 161)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(100, 29)
        createClassButton.TabIndex = 13
        createClassButton.Text = "Create Class"
        createClassButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 12
        Label2.Text = "Professor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 11
        Label1.Text = "Class ID"
        ' 
        ' CreateClassForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(396, 250)
        Controls.Add(backButton)
        Controls.Add(courseComboBox)
        Controls.Add(professorComboBox)
        Controls.Add(clearButton)
        Controls.Add(classIDTextBox)
        Controls.Add(Label3)
        Controls.Add(createClassButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "CreateClassForm"
        Text = "CreateClassForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents courseComboBox As ComboBox
    Friend WithEvents professorComboBox As ComboBox
    Friend WithEvents clearButton As Button
    Friend WithEvents classIDTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents createClassButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
