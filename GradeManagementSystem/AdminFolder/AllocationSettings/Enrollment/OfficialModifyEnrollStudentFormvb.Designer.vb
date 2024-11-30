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
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 20)
        Label4.TabIndex = 41
        Label4.Text = "Enrollment Date"
        ' 
        ' enrollmentDate
        ' 
        enrollmentDate.CustomFormat = "yyyy-MM-dd"
        enrollmentDate.Format = DateTimePickerFormat.Custom
        enrollmentDate.Location = New Point(126, 150)
        enrollmentDate.Name = "enrollmentDate"
        enrollmentDate.Size = New Size(151, 27)
        enrollmentDate.TabIndex = 40
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(274, 14)
        backButton.Name = "backButton"
        backButton.Size = New Size(100, 29)
        backButton.TabIndex = 39
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' studentComboBox
        ' 
        studentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        studentComboBox.FormattingEnabled = True
        studentComboBox.Location = New Point(126, 116)
        studentComboBox.Name = "studentComboBox"
        studentComboBox.Size = New Size(151, 28)
        studentComboBox.TabIndex = 38
        ' 
        ' classComboBox
        ' 
        classComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        classComboBox.FormattingEnabled = True
        classComboBox.Location = New Point(126, 80)
        classComboBox.Name = "classComboBox"
        classComboBox.Size = New Size(151, 28)
        classComboBox.TabIndex = 37
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(202, 195)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(147, 29)
        clearButton.TabIndex = 36
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.Enabled = False
        enrollmentIDTextBox.Location = New Point(126, 21)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(100, 27)
        enrollmentIDTextBox.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(60, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 34
        Label3.Text = "Student"
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.Location = New Point(49, 195)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(147, 29)
        modifyEnrollButton.TabIndex = 33
        modifyEnrollButton.Text = "Modify Enrollment"
        modifyEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 32
        Label2.Text = "Class"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 31
        Label1.Text = "Enrollment ID"
        ' 
        ' OfficialModifyEnrollStudentFormvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(389, 245)
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
        FormBorderStyle = FormBorderStyle.None
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
End Class
