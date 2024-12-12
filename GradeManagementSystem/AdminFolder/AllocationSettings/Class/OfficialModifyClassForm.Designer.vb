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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyClassForm))
        Label5 = New Label()
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
        backbttn = New PictureBox()
        Label6 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(629, 143)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 28)
        Label5.TabIndex = 32
        Label5.Text = "End Time"
        ' 
        ' courseComboBox
        ' 
        courseComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        courseComboBox.Font = New Font("Segoe UI", 10F)
        courseComboBox.FormattingEnabled = True
        courseComboBox.Location = New Point(141, 180)
        courseComboBox.Margin = New Padding(4, 5, 4, 5)
        courseComboBox.Name = "courseComboBox"
        courseComboBox.Size = New Size(296, 36)
        courseComboBox.TabIndex = 27
        ' 
        ' professorComboBox
        ' 
        professorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        professorComboBox.Font = New Font("Segoe UI", 10F)
        professorComboBox.FormattingEnabled = True
        professorComboBox.Location = New Point(141, 140)
        professorComboBox.Margin = New Padding(4, 5, 4, 5)
        professorComboBox.Name = "professorComboBox"
        professorComboBox.Size = New Size(296, 36)
        professorComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Segoe UI", 8F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(436, 265)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(131, 39)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' classIDTextBox
        ' 
        classIDTextBox.Enabled = False
        classIDTextBox.Font = New Font("Segoe UI", 10F)
        classIDTextBox.Location = New Point(141, 102)
        classIDTextBox.Margin = New Padding(4, 5, 4, 5)
        classIDTextBox.Mask = "LL-000"
        classIDTextBox.Name = "classIDTextBox"
        classIDTextBox.PromptChar = "X"c
        classIDTextBox.Size = New Size(296, 34)
        classIDTextBox.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(58, 183)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 28)
        Label3.TabIndex = 23
        Label3.Text = "Course:"
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.BackColor = Color.DarkGreen
        modifyClassButton.FlatStyle = FlatStyle.Popup
        modifyClassButton.Font = New Font("Segoe UI", 8F)
        modifyClassButton.ForeColor = Color.White
        modifyClassButton.Location = New Point(282, 265)
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
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(34, 143)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 28)
        Label2.TabIndex = 21
        Label2.Text = "Professor:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(50, 105)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 28)
        Label1.TabIndex = 20
        Label1.Text = "Class ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(462, 105)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 28)
        Label7.TabIndex = 35
        Label7.Text = "Class Session:"
        ' 
        ' classSeshComboBox
        ' 
        classSeshComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classSeshComboBox.Font = New Font("Segoe UI", 10F)
        classSeshComboBox.FormattingEnabled = True
        classSeshComboBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        classSeshComboBox.Location = New Point(594, 100)
        classSeshComboBox.Margin = New Padding(4, 5, 4, 5)
        classSeshComboBox.Name = "classSeshComboBox"
        classSeshComboBox.Size = New Size(187, 36)
        classSeshComboBox.TabIndex = 34
        ' 
        ' endTimePicker
        ' 
        endTimePicker.Font = New Font("Segoe UI", 9F)
        endTimePicker.Format = DateTimePickerFormat.Custom
        endTimePicker.Location = New Point(632, 174)
        endTimePicker.Margin = New Padding(4, 5, 4, 5)
        endTimePicker.Name = "endTimePicker"
        endTimePicker.ShowUpDown = True
        endTimePicker.Size = New Size(138, 31)
        endTimePicker.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(462, 143)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 28)
        Label4.TabIndex = 30
        Label4.Text = "Start Time"
        ' 
        ' startTimePicker
        ' 
        startTimePicker.Font = New Font("Segoe UI", 9F)
        startTimePicker.Format = DateTimePickerFormat.Custom
        startTimePicker.Location = New Point(462, 175)
        startTimePicker.Margin = New Padding(4, 5, 4, 5)
        startTimePicker.Name = "startTimePicker"
        startTimePicker.ShowUpDown = True
        startTimePicker.Size = New Size(138, 31)
        startTimePicker.TabIndex = 29
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 54
        backbttn.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(293, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 22)
        Label6.TabIndex = 55
        Label6.Text = "M O D I F Y   C L A S S"
        ' 
        ' OfficialModifyClassForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(838, 347)
        Controls.Add(Label6)
        Controls.Add(backbttn)
        Controls.Add(classSeshComboBox)
        Controls.Add(Label5)
        Controls.Add(endTimePicker)
        Controls.Add(Label4)
        Controls.Add(startTimePicker)
        Controls.Add(courseComboBox)
        Controls.Add(professorComboBox)
        Controls.Add(clearButton)
        Controls.Add(classIDTextBox)
        Controls.Add(Label3)
        Controls.Add(modifyClassButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label7)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyClassForm"
        Text = "ModifyClassForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label6 As Label
End Class
