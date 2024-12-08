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
        Label5 = New Label()
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
        classSeshComboBox = New ComboBox()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(640, 171)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 29)
        Label5.TabIndex = 23
        Label5.Text = "End Time"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 8F)
        backButton.Location = New Point(684, 291)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(74, 42)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' courseComboBox
        ' 
        courseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(115, 198)
        courseComboBox.Margin = New Padding(4, 4, 4, 4)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(305, 33)
        courseComboBox.TabIndex = 18
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(115, 144)
        professorComboBox.Margin = New Padding(4, 4, 4, 4)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(305, 33)
        professorComboBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 8F)
        clearButton.Location = New Point(580, 291)
        clearButton.Margin = New Padding(4, 4, 4, 4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(87, 42)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Location = New Point(115, 98)
        classIDTextBox.Margin = New Padding(4, 4, 4, 4)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(305, 31)
        classIDTextBox.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(44, 201)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 29)
        Label3.TabIndex = 14
        Label3.Text = "Course:"
        ' 
        ' createClassButton
        ' 
        createClassButton.BackColor = Color.DarkSeaGreen
        createClassButton.FlatStyle = FlatStyle.Popup
        createClassButton.Font = New Font("Sitka Banner", 8F)
        createClassButton.Location = New Point(115, 291)
        createClassButton.Margin = New Padding(4, 4, 4, 4)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(125, 42)
        createClassButton.TabIndex = 13
        createClassButton.Text = "Create Class"
        createClassButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(24, 144)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 29)
        Label2.TabIndex = 12
        Label2.Text = "Professor:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(37, 101)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 29)
        Label1.TabIndex = 11
        Label1.Text = "Class ID:"
        ' 
        ' startTimePicker
        ' 
        startTimePicker.Format = DateTimePickerFormat.Time
        startTimePicker.Location = New Point(474, 200)
        startTimePicker.Margin = New Padding(4, 4, 4, 4)
        startTimePicker.Name = "startTimePicker"
        startTimePicker.ShowUpDown = True
        startTimePicker.Size = New Size(138, 31)
        startTimePicker.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(499, 171)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 29)
        Label4.TabIndex = 21
        Label4.Text = "Start Time"
        ' 
        ' endTimePicker
        ' 
        endTimePicker.Format = DateTimePickerFormat.Time
        endTimePicker.Location = New Point(620, 201)
        endTimePicker.Margin = New Padding(4, 4, 4, 4)
        endTimePicker.Name = "endTimePicker"
        endTimePicker.ShowUpDown = True
        endTimePicker.Size = New Size(138, 31)
        endTimePicker.TabIndex = 22
        ' 
        ' classSeshComboBox
        ' 
        classSeshComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classSeshComboBox.FormattingEnabled = True
        classSeshComboBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        classSeshComboBox.Location = New Point(465, 117)
        classSeshComboBox.Margin = New Padding(4, 4, 4, 4)
        classSeshComboBox.Name = "classSeshComboBox"
        classSeshComboBox.Size = New Size(302, 33)
        classSeshComboBox.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(465, 88)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(119, 29)
        Label7.TabIndex = 26
        Label7.Text = "Class Session"
        ' 
        ' CreateClassForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(814, 375)
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
        Controls.Add(createClassButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
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
    Friend WithEvents classSeshComboBox As ComboBox
    Friend WithEvents Label7 As Label
End Class
