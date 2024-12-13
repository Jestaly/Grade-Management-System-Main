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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EnrollStudentForm))
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
        backbttn = New PictureBox()
        Label7 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.Font = New Font("Segoe UI", 10F)
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(210, 179)
        studentComboBox.Margin = New Padding(4, 5, 4, 5)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(206, 36)
        studentComboBox.TabIndex = 27
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.Font = New Font("Segoe UI", 10F)
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(209, 139)
        classComboBox.Margin = New Padding(4, 5, 4, 5)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(206, 36)
        classComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Segoe UI", 9F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(581, 281)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(146, 41)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Font = New Font("Segoe UI", 10F)
        enrollmentIDTextBox.Location = New Point(210, 102)
        enrollmentIDTextBox.Margin = New Padding(4, 5, 4, 5)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(205, 34)
        enrollmentIDTextBox.TabIndex = 24
        enrollmentIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(117, 180)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 23
        Label3.Text = "Student:"
        ' 
        ' enrollButton
        ' 
        enrollButton.BackColor = Color.DarkGreen
        enrollButton.FlatStyle = FlatStyle.Popup
        enrollButton.Font = New Font("Segoe UI", 9F)
        enrollButton.ForeColor = Color.White
        enrollButton.Location = New Point(426, 281)
        enrollButton.Margin = New Padding(4, 5, 4, 5)
        enrollButton.Name = "enrollButton"
        enrollButton.Size = New Size(146, 41)
        enrollButton.TabIndex = 22
        enrollButton.Text = "Enroll"
        enrollButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(143, 139)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 25)
        Label2.TabIndex = 21
        Label2.Text = "Class:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(68, 105)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 20
        Label1.Text = "Enrollment ID:"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Font = New Font("Segoe UI", 10F)
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(210, 220)
        enrollmentDate.Margin = New Padding(4, 5, 4, 5)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(206, 34)
        enrollmentDate.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(46, 223)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 30
        Label4.Text = "Enrollment Date:"
        ' 
        ' showCourseTextBox
        ' 
        showCourseTextBox.Enabled = False
        showCourseTextBox.Font = New Font("Sitka Banner", 10F)
        showCourseTextBox.Location = New Point(449, 198)
        showCourseTextBox.Margin = New Padding(4, 5, 4, 5)
        showCourseTextBox.Name = "showCourseTextBox"
        showCourseTextBox.Size = New Size(278, 33)
        showCourseTextBox.TabIndex = 31
        ' 
        ' showProfessorTextBox
        ' 
        showProfessorTextBox.Enabled = False
        showProfessorTextBox.Font = New Font("Sitka Banner", 10F)
        showProfessorTextBox.Location = New Point(449, 127)
        showProfessorTextBox.Margin = New Padding(4, 5, 4, 5)
        showProfessorTextBox.Name = "showProfessorTextBox"
        showProfessorTextBox.Size = New Size(278, 33)
        showProfessorTextBox.TabIndex = 32
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(449, 102)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 25)
        Label5.TabIndex = 33
        Label5.Text = "Professor"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(449, 173)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 25)
        Label6.TabIndex = 34
        Label6.Text = "Course"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(13, 13)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 35
        backbttn.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(253, 40)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(266, 22)
        Label7.TabIndex = 36
        Label7.Text = "E N R O L L   S T U D E N T"
        ' 
        ' EnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(788, 357)
        Controls.Add(Label7)
        Controls.Add(backbttn)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(showProfessorTextBox)
        Controls.Add(showCourseTextBox)
        Controls.Add(Label4)
        Controls.Add(enrollmentDate)
        Controls.Add(studentComboBox)
        Controls.Add(classComboBox)
        Controls.Add(clearButton)
        Controls.Add(enrollmentIDTextBox)
        Controls.Add(Label3)
        Controls.Add(enrollButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "EnrollStudentForm"
        Text = "EnrollStudentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label7 As Label
End Class
