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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyEnrollStudentFormvb))
        Label4 = New Label()
        enrollmentDate = New DateTimePicker()
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
        Label7 = New Label()
        backbttn = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(23, 208)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(152, 25)
        Label4.TabIndex = 41
        Label4.Text = "Enrollment Date:"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(178, 206)
        enrollmentDate.Margin = New Padding(4, 5, 4, 5)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(188, 34)
        enrollmentDate.TabIndex = 40
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.Font = New Font("Segoe UI", 10F)
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(179, 164)
        studentComboBox.Margin = New Padding(4, 5, 4, 5)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(188, 36)
        studentComboBox.TabIndex = 38
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.Font = New Font("Segoe UI", 10F)
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(179, 127)
        classComboBox.Margin = New Padding(4, 5, 4, 5)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(188, 36)
        classComboBox.TabIndex = 37
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Segoe UI", 9F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(392, 283)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(124, 42)
        clearButton.TabIndex = 36
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Font = New Font("Segoe UI", 10F)
        enrollmentIDTextBox.Location = New Point(179, 91)
        enrollmentIDTextBox.Margin = New Padding(4, 5, 4, 5)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(187, 34)
        enrollmentIDTextBox.TabIndex = 35
        enrollmentIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(92, 169)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 34
        Label3.Text = "Student:"
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.BackColor = Color.DarkGreen
        modifyEnrollButton.FlatStyle = FlatStyle.Popup
        modifyEnrollButton.Font = New Font("Segoe UI", 9F)
        modifyEnrollButton.ForeColor = Color.White
        modifyEnrollButton.Location = New Point(243, 283)
        modifyEnrollButton.Margin = New Padding(4, 5, 4, 5)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(124, 42)
        modifyEnrollButton.TabIndex = 33
        modifyEnrollButton.Text = "Modify"
        modifyEnrollButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(117, 133)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 25)
        Label2.TabIndex = 32
        Label2.Text = "Class:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(43, 96)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 31
        Label1.Text = "Enrollment ID:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(392, 174)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 25)
        Label6.TabIndex = 45
        Label6.Text = "Course"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(386, 97)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 25)
        Label5.TabIndex = 44
        Label5.Text = "Professor"
        ' 
        ' showProfessorTextBox
        ' 
        showProfessorTextBox.Enabled = False
        showProfessorTextBox.Font = New Font("Segoe UI", 10F)
        showProfessorTextBox.Location = New Point(386, 124)
        showProfessorTextBox.Margin = New Padding(4, 5, 4, 5)
        showProfessorTextBox.Name = "showProfessorTextBox"
        showProfessorTextBox.Size = New Size(326, 34)
        showProfessorTextBox.TabIndex = 43
        ' 
        ' showCourseTextBox
        ' 
        showCourseTextBox.Enabled = False
        showCourseTextBox.Font = New Font("Segoe UI", 10F)
        showCourseTextBox.Location = New Point(392, 199)
        showCourseTextBox.Margin = New Padding(4, 5, 4, 5)
        showCourseTextBox.Name = "showCourseTextBox"
        showCourseTextBox.Size = New Size(320, 34)
        showCourseTextBox.TabIndex = 42
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label7.Location = New Point(161, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(382, 22)
        Label7.TabIndex = 46
        Label7.Text = "M O D I F Y   E N R O L L  S T U D E N T"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(11, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 47
        backbttn.TabStop = False
        ' 
        ' OfficialModifyEnrollStudentFormvb
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(753, 369)
        Controls.Add(backbttn)
        Controls.Add(Label7)
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
        Controls.Add(modifyEnrollButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyEnrollStudentFormvb"
        Text = "OfficialModifyEnrollStudentFormvb"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents enrollmentDate As DateTimePicker
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
    Friend WithEvents Label7 As Label
    Friend WithEvents backbttn As PictureBox
End Class
