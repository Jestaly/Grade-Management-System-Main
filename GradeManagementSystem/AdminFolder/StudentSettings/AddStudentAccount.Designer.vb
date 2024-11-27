<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudentAccount
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
        firstnameTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        middlenameTextBox = New TextBox()
        Label3 = New Label()
        lastnameTextBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        emailTextBox = New TextBox()
        addStudentButton = New Button()
        Button2 = New Button()
        programComboBox = New ComboBox()
        yearComboBox = New ComboBox()
        sectionComboBox = New ComboBox()
        studentIDTextBox = New MaskedTextBox()
        Label10 = New Label()
        birthCalendar = New MonthCalendar()
        Label7 = New Label()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(38, 69)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 1
        Label1.Text = "first"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(169, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 3
        Label2.Text = "middle"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(169, 69)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(300, 46)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 5
        Label3.Text = "last"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(300, 69)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(38, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 7
        Label4.Text = "program"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(169, 97)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 9
        Label5.Text = "year"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(300, 97)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 11
        Label6.Text = "section"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(38, 155)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 15
        Label8.Text = "email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(38, 178)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(210, 27)
        emailTextBox.TabIndex = 14
        ' 
        ' addStudentButton
        ' 
        addStudentButton.Location = New Point(38, 220)
        addStudentButton.Name = "addStudentButton"
        addStudentButton.Size = New Size(125, 29)
        addStudentButton.TabIndex = 18
        addStudentButton.Text = "Add Student"
        addStudentButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(38, 255)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 29)
        Button2.TabIndex = 19
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(38, 120)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(125, 28)
        programComboBox.TabIndex = 20
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(169, 120)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(125, 28)
        yearComboBox.TabIndex = 21
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(300, 120)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(125, 28)
        sectionComboBox.TabIndex = 22
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Enabled = False
        studentIDTextBox.Location = New Point(123, 15)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(125, 27)
        studentIDTextBox.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(38, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 20)
        Label10.TabIndex = 26
        Label10.Text = "Student ID"
        ' 
        ' birthCalendar
        ' 
        birthCalendar.Location = New Point(175, 225)
        birthCalendar.Name = "birthCalendar"
        birthCalendar.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(274, 196)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 20)
        Label7.TabIndex = 28
        Label7.Text = "birthdate"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(38, 290)
        backButton.Name = "backButton"
        backButton.Size = New Size(125, 29)
        backButton.TabIndex = 29
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddStudentAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(468, 457)
        Controls.Add(backButton)
        Controls.Add(Label7)
        Controls.Add(birthCalendar)
        Controls.Add(Label10)
        Controls.Add(studentIDTextBox)
        Controls.Add(sectionComboBox)
        Controls.Add(yearComboBox)
        Controls.Add(programComboBox)
        Controls.Add(Button2)
        Controls.Add(addStudentButton)
        Controls.Add(Label8)
        Controls.Add(emailTextBox)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lastnameTextBox)
        Controls.Add(Label2)
        Controls.Add(middlenameTextBox)
        Controls.Add(Label1)
        Controls.Add(firstnameTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddStudentAccount"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents addStudentButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents yearComboBox As ComboBox
    Friend WithEvents sectionComboBox As ComboBox
    Friend WithEvents studentIDTextBox As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents birthCalendar As MonthCalendar
    Friend WithEvents Label7 As Label
    Friend WithEvents backButton As Button
End Class
