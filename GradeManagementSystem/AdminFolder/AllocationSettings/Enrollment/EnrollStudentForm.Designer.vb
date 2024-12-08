<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnrollStudentForm
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
        studentComboBox = New ComboBox()
        classComboBox = New ComboBox()
        clearButton = New Button()
        enrollmentIDTextBox = New MaskedTextBox()
        Label3 = New Label()
        enrollButton = New Button()
        Label2 = New Label()
        Label1 = New Label()
        enrollmentDate = New DateTimePicker()
        Label4 = New Label()
        showCourseTextBox = New TextBox()
        showProfessorTextBox = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.Location = New Point(629, 289)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(98, 42)
        backButton.TabIndex = 28
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.Font = New Font("Sitka Banner", 10F)
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(180, 152)
        studentComboBox.Margin = New Padding(4, 5, 4, 5)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(188, 37)
        studentComboBox.TabIndex = 27
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.Font = New Font("Sitka Banner", 10F)
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(180, 97)
        classComboBox.Margin = New Padding(4, 5, 4, 5)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(188, 37)
        classComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.Location = New Point(500, 289)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(106, 42)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Font = New Font("Sitka Banner", 10F)
        enrollmentIDTextBox.Location = New Point(181, 46)
        enrollmentIDTextBox.Margin = New Padding(4, 5, 4, 5)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(124, 33)
        enrollmentIDTextBox.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(98, 158)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 29)
        Label3.TabIndex = 23
        Label3.Text = "Student:"
        ' 
        ' enrollButton
        ' 
        enrollButton.BackColor = Color.DarkSeaGreen
        enrollButton.FlatStyle = FlatStyle.Popup
        enrollButton.Font = New Font("Sitka Banner", 9F)
        enrollButton.Location = New Point(207, 289)
        enrollButton.Margin = New Padding(4, 5, 4, 5)
        enrollButton.Name = "enrollButton"
        enrollButton.Size = New Size(133, 42)
        enrollButton.TabIndex = 22
        enrollButton.Text = "Enroll"
        enrollButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(120, 101)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 29)
        Label2.TabIndex = 21
        Label2.Text = "Class:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(48, 48)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 29)
        Label1.TabIndex = 20
        Label1.Text = "Enrollment ID:"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Font = New Font("Sitka Banner", 10F)
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(180, 206)
        enrollmentDate.Margin = New Padding(4, 5, 4, 5)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(188, 33)
        enrollmentDate.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(29, 208)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 29)
        Label4.TabIndex = 30
        Label4.Text = "Enrollment Date:"
        ' 
        ' showCourseTextBox
        ' 
        showCourseTextBox.Enabled = False
        showCourseTextBox.Font = New Font("Sitka Banner", 10F)
        showCourseTextBox.Location = New Point(408, 197)
        showCourseTextBox.Margin = New Padding(4, 5, 4, 5)
        showCourseTextBox.Name = "showCourseTextBox"
        showCourseTextBox.Size = New Size(363, 33)
        showCourseTextBox.TabIndex = 31
        ' 
        ' showProfessorTextBox
        ' 
        showProfessorTextBox.Enabled = False
        showProfessorTextBox.Font = New Font("Sitka Banner", 10F)
        showProfessorTextBox.Location = New Point(408, 108)
        showProfessorTextBox.Margin = New Padding(4, 5, 4, 5)
        showProfessorTextBox.Name = "showProfessorTextBox"
        showProfessorTextBox.Size = New Size(363, 33)
        showProfessorTextBox.TabIndex = 32
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(408, 74)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 29)
        Label5.TabIndex = 33
        Label5.Text = "Professor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(408, 164)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 29)
        Label6.TabIndex = 34
        Label6.Text = "Course"
        ' 
        ' EnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(823, 380)
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
        Controls.Add(enrollButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Banner", 10F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "EnrollStudentForm"
        Text = "EnrollStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents studentComboBox As ComboBox
    Friend WithEvents classComboBox As ComboBox
    Friend WithEvents clearButton As Button
    Friend WithEvents enrollmentIDTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents enrollButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents enrollmentDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents showCourseTextBox As TextBox
    Friend WithEvents showProfessorTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
