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
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(277, 20)
        backButton.Name = "backButton"
        backButton.Size = New Size(100, 29)
        backButton.TabIndex = 28
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(129, 122)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(151, 28)
        studentComboBox.TabIndex = 27
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(129, 86)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(151, 28)
        classComboBox.TabIndex = 26
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(207, 198)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(85, 29)
        clearButton.TabIndex = 25
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Location = New Point(129, 27)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(100, 27)
        enrollmentIDTextBox.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 23
        Label3.Text = "Student"
        ' 
        ' enrollButton
        ' 
        enrollButton.Location = New Point(116, 198)
        enrollButton.Name = "enrollButton"
        enrollButton.Size = New Size(85, 29)
        enrollButton.TabIndex = 22
        enrollButton.Text = "Enroll"
        enrollButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(81, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 21
        Label2.Text = "Class"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 20
        Label1.Text = "Enrollment ID"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(129, 156)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(151, 27)
        enrollmentDate.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 20)
        Label4.TabIndex = 30
        Label4.Text = "Enrollment Date"
        ' 
        ' EnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(396, 251)
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
        FormBorderStyle = FormBorderStyle.None
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
End Class
