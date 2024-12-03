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
        Dim Label5 As Label
        backButton = New Button()
        courseComboBox = New ComboBox()
        professorComboBox = New ComboBox()
        clearButton = New Button()
        classIDTextBox = New MaskedTextBox()
        Label3 = New Label()
        createClassButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        startTimePicker = New DateTimePicker()
        Label4 = New Label()
        endTimePicker = New DateTimePicker()
        Label6 = New Label()
        classSeshComboBox = New ComboBox()
        Label7 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(344, 18)
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
        courseComboBox.Location = New Point(92, 115)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(151, 28)
        courseComboBox.TabIndex = 18
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(92, 79)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(151, 28)
        professorComboBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(92, 192)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(100, 29)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Location = New Point(75, 24)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(100, 27)
        classIDTextBox.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(32, 115)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 14
        Label3.Text = "Course"
        ' 
        ' createClassButton
        ' 
        createClassButton.Location = New Point(92, 157)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(100, 29)
        createClassButton.TabIndex = 13
        createClassButton.Text = "Create Class"
        createClassButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 12
        Label2.Text = "Professor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 11
        Label1.Text = "Class ID"
        ' 
        ' startTimePicker
        ' 
        startTimePicker.Format = DateTimePickerFormat.Time
        startTimePicker.Location = New Point(266, 115)
        startTimePicker.Name = "startTimePicker"
        startTimePicker.ShowUpDown = True
        startTimePicker.Size = New Size(111, 27)
        startTimePicker.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(266, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 21
        Label4.Text = "Start Time"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(397, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 23
        Label5.Text = "End Time"
        ' 
        ' endTimePicker
        ' 
        endTimePicker.Format = DateTimePickerFormat.Time
        endTimePicker.Location = New Point(397, 116)
        endTimePicker.Name = "endTimePicker"
        endTimePicker.ShowUpDown = True
        endTimePicker.Size = New Size(111, 27)
        endTimePicker.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(380, 119)
        Label6.Name = "Label6"
        Label6.Size = New Size(15, 20)
        Label6.TabIndex = 24
        Label6.Text = "-"
        ' 
        ' classSeshComboBox
        ' 
        classSeshComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classSeshComboBox.FormattingEnabled = True
        classSeshComboBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        classSeshComboBox.Location = New Point(266, 179)
        classSeshComboBox.Name = "classSeshComboBox"
        classSeshComboBox.Size = New Size(111, 28)
        classSeshComboBox.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(266, 156)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 20)
        Label7.TabIndex = 26
        Label7.Text = "Class Session"
        ' 
        ' CreateClassForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(564, 250)
        Controls.Add(Label7)
        Controls.Add(classSeshComboBox)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(endTimePicker)
        Controls.Add(Label4)
        Controls.Add(startTimePicker)
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
    Friend WithEvents startTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents endTimePicker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents classSeshComboBox As ComboBox
    Friend WithEvents Label7 As Label
End Class
