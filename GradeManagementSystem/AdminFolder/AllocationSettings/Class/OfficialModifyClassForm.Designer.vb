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
        Label5 = New Label()
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
        endTimePicker = New DateTimePicker()
        Label4 = New Label()
        startTimePicker = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(662, 160)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 29)
        Label5.TabIndex = 32
        Label5.Text = "End Time"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner Semibold", 8F, FontStyle.Bold)
        backButton.ForeColor = Color.Black
        backButton.Location = New Point(700, 302)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(81, 39)
        backButton.TabIndex = 28
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' courseComboBox
        ' 
        courseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(128, 195)
        courseComboBox.Margin = New Padding(4, 5, 4, 5)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(296, 37)
        courseComboBox.TabIndex = 27
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(128, 144)
        professorComboBox.Margin = New Padding(4, 5, 4, 5)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(296, 37)
        professorComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner Semibold", 8F, FontStyle.Bold)
        clearButton.ForeColor = Color.Black
        clearButton.Location = New Point(608, 302)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(84, 39)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Location = New Point(129, 96)
        classIDTextBox.Margin = New Padding(4, 5, 4, 5)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(296, 33)
        classIDTextBox.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(49, 195)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 29)
        Label3.TabIndex = 23
        Label3.Text = "Course:"
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.BackColor = Color.DarkSeaGreen
        modifyClassButton.FlatStyle = FlatStyle.Popup
        modifyClassButton.Font = New Font("Sitka Banner Semibold", 8F, FontStyle.Bold)
        modifyClassButton.ForeColor = Color.Black
        modifyClassButton.Location = New Point(49, 302)
        modifyClassButton.Margin = New Padding(4, 5, 4, 5)
        modifyClassButton.Name = "modifyClassButton"
        modifyClassButton.Size = New Size(127, 39)
        modifyClassButton.TabIndex = 22
        modifyClassButton.Text = "Modify Class"
        modifyClassButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(33, 147)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 29)
        Label2.TabIndex = 21
        Label2.Text = "Professor:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(45, 96)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 29)
        Label1.TabIndex = 20
        Label1.Text = "Class ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(468, 109)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 29)
        Label7.TabIndex = 35
        Label7.Text = "Class Session:"
        ' 
        ' classSeshComboBox
        ' 
        classSeshComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classSeshComboBox.FormattingEnabled = True
        classSeshComboBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        classSeshComboBox.Location = New Point(594, 104)
        classSeshComboBox.Margin = New Padding(4, 5, 4, 5)
        classSeshComboBox.Name = "classSeshComboBox"
        classSeshComboBox.Size = New Size(187, 37)
        classSeshComboBox.TabIndex = 34
        ' 
        ' endTimePicker
        ' 
        endTimePicker.Format = DateTimePickerFormat.Time
        endTimePicker.Location = New Point(643, 194)
        endTimePicker.Margin = New Padding(4, 5, 4, 5)
        endTimePicker.Name = "endTimePicker"
        endTimePicker.ShowUpDown = True
        endTimePicker.Size = New Size(138, 33)
        endTimePicker.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(519, 160)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 29)
        Label4.TabIndex = 30
        Label4.Text = "Start Time"
        ' 
        ' startTimePicker
        ' 
        startTimePicker.Format = DateTimePickerFormat.Time
        startTimePicker.Location = New Point(495, 194)
        startTimePicker.Margin = New Padding(4, 5, 4, 5)
        startTimePicker.Name = "startTimePicker"
        startTimePicker.ShowUpDown = True
        startTimePicker.Size = New Size(138, 33)
        startTimePicker.TabIndex = 29
        ' 
        ' OfficialModifyClassForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(838, 375)
        Controls.Add(Label7)
        Controls.Add(classSeshComboBox)
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
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
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
    Friend WithEvents endTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents startTimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
