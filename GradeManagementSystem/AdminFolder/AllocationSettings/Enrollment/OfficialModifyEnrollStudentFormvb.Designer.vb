<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyEnrollStudentFormvb
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
        Label4 = New Label()
        enrollmentDate = New DateTimePicker()
        backButton = New Button()
        studentComboBox = New ComboBox()
        classComboBox = New ComboBox()
        clearButton = New Button()
        enrollmentIDTextBox = New MaskedTextBox()
        Label3 = New Label()
        modifyEnrollButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        showProfessorTextBox = New TextBox()
        showCourseTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(11, 193)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 29)
        Label4.TabIndex = 41
        Label4.Text = "Enrollment Date:"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(170, 193)
        enrollmentDate.Margin = New Padding(4, 5, 4, 5)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(188, 33)
        enrollmentDate.TabIndex = 40
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.ForeColor = Color.Black
        backButton.Location = New Point(635, 283)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(76, 42)
        backButton.TabIndex = 39
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(170, 143)
        studentComboBox.Margin = New Padding(4, 5, 4, 5)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(188, 37)
        studentComboBox.TabIndex = 38
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(170, 96)
        classComboBox.Margin = New Padding(4, 5, 4, 5)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(188, 37)
        classComboBox.TabIndex = 37
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.ForeColor = Color.Black
        clearButton.Location = New Point(540, 283)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(87, 42)
        clearButton.TabIndex = 36
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Location = New Point(171, 53)
        enrollmentIDTextBox.Margin = New Padding(4, 5, 4, 5)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(187, 33)
        enrollmentIDTextBox.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(73, 143)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 29)
        Label3.TabIndex = 34
        Label3.Text = "Student:"
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.BackColor = Color.DarkSeaGreen
        modifyEnrollButton.FlatStyle = FlatStyle.Popup
        modifyEnrollButton.Font = New Font("Sitka Banner", 9F)
        modifyEnrollButton.ForeColor = Color.Black
        modifyEnrollButton.Location = New Point(171, 283)
        modifyEnrollButton.Margin = New Padding(4, 5, 4, 5)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(166, 42)
        modifyEnrollButton.TabIndex = 33
        modifyEnrollButton.Text = "Modify Enrollment"
        modifyEnrollButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(96, 95)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 29)
        Label2.TabIndex = 32
        Label2.Text = "Class:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(21, 53)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 29)
        Label1.TabIndex = 31
        Label1.Text = "Enrollment ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(391, 151)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 29)
        Label6.TabIndex = 45
        Label6.Text = "Course"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(385, 57)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 29)
        Label5.TabIndex = 44
        Label5.Text = "Professor"
        ' 
        ' showProfessorTextBox
        ' 
        showProfessorTextBox.Enabled = False
        showProfessorTextBox.Location = New Point(385, 96)
        showProfessorTextBox.Margin = New Padding(4, 5, 4, 5)
        showProfessorTextBox.Name = "showProfessorTextBox"
        showProfessorTextBox.Size = New Size(326, 33)
        showProfessorTextBox.TabIndex = 43
        ' 
        ' showCourseTextBox
        ' 
        showCourseTextBox.Enabled = False
        showCourseTextBox.Location = New Point(391, 189)
        showCourseTextBox.Margin = New Padding(4, 5, 4, 5)
        showCourseTextBox.Name = "showCourseTextBox"
        showCourseTextBox.Size = New Size(320, 33)
        showCourseTextBox.TabIndex = 42
        ' 
        ' OfficialModifyEnrollStudentFormvb
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(753, 369)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(showProfessorTextBox)
        Controls.Add(showCourseTextBox)
        Controls.Add(Label4)
        Controls.Add(enrollmentDate)
        Controls.Add(backButton)
        Controls.Add(studentComboBox)
        Controls.Add(classComboBox)
        Controls.Add(clearButton)
        Controls.Add(enrollmentIDTextBox)
        Controls.Add(Label3)
        Controls.Add(modifyEnrollButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyEnrollStudentFormvb"
        Text = "OfficialModifyEnrollStudentFormvb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents enrollmentDate As DateTimePicker
    Friend WithEvents backButton As Button
    Friend WithEvents studentComboBox As ComboBox
    Friend WithEvents classComboBox As ComboBox
    Friend WithEvents clearButton As Button
    Friend WithEvents enrollmentIDTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents modifyEnrollButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents showProfessorTextBox As TextBox
    Friend WithEvents showCourseTextBox As TextBox
End Class
