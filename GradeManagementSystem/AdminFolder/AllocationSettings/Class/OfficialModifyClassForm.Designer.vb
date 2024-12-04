<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyClassForm
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
        modifyClassButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        classSeshComboBox = New ComboBox()
        Label6 = New Label()
        endTimePicker = New DateTimePicker()
        Label4 = New Label()
        startTimePicker = New DateTimePicker()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(432, 23)
        backButton.Name = "backButton"
        backButton.Size = New Size(100, 29)
        backButton.TabIndex = 28
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' courseComboBox
        ' 
        courseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(100, 118)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(151, 28)
        courseComboBox.TabIndex = 27
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(100, 82)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(151, 28)
        professorComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(100, 195)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(111, 29)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Location = New Point(83, 29)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(100, 27)
        classIDTextBox.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 23
        Label3.Text = "Course"
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.Location = New Point(100, 160)
        modifyClassButton.Name = "modifyClassButton"
        modifyClassButton.Size = New Size(111, 29)
        modifyClassButton.TabIndex = 22
        modifyClassButton.Text = "Modify Class"
        modifyClassButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 21
        Label2.Text = "Professor"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 20)
        Label1.TabIndex = 20
        Label1.Text = "Class ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(281, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(95, 20)
        Label7.TabIndex = 35
        Label7.Text = "Class Session"
        ' 
        ' classSeshComboBox
        ' 
        classSeshComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classSeshComboBox.FormattingEnabled = True
        classSeshComboBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        classSeshComboBox.Location = New Point(281, 174)
        classSeshComboBox.Name = "classSeshComboBox"
        classSeshComboBox.Size = New Size(111, 28)
        classSeshComboBox.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(395, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(15, 20)
        Label6.TabIndex = 33
        Label6.Text = "-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(412, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 32
        Label5.Text = "End Time"
        ' 
        ' endTimePicker
        ' 
        endTimePicker.Format = DateTimePickerFormat.Time
        endTimePicker.Location = New Point(412, 111)
        endTimePicker.Name = "endTimePicker"
        endTimePicker.ShowUpDown = True
        endTimePicker.Size = New Size(111, 27)
        endTimePicker.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(281, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 30
        Label4.Text = "Start Time"
        ' 
        ' startTimePicker
        ' 
        startTimePicker.Format = DateTimePickerFormat.Time
        startTimePicker.Location = New Point(281, 110)
        startTimePicker.Name = "startTimePicker"
        startTimePicker.ShowUpDown = True
        startTimePicker.Size = New Size(111, 27)
        startTimePicker.TabIndex = 29
        ' 
        ' OfficialModifyClassForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(560, 250)
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
        Controls.Add(modifyClassButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OfficialModifyClassForm"
        Text = "ModifyClassForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents courseComboBox As ComboBox
    Friend WithEvents professorComboBox As ComboBox
    Friend WithEvents clearButton As Button
    Friend WithEvents classIDTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents modifyClassButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents classSeshComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents endTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents startTimePicker As DateTimePicker
End Class
