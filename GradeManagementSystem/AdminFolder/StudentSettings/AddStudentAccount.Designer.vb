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
        Label7 = New Label()
        backButton = New Button()
        birthDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Sitka Banner", 9.5F)
        firstnameTextBox.Location = New Point(43, 109)
        firstnameTextBox.Margin = New Padding(4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(430, 31)
        firstnameTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(43, 80)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 26)
        Label1.TabIndex = 1
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(43, 144)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 26)
        Label2.TabIndex = 3
        Label2.Text = "Middle Name"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Sitka Banner", 9.5F)
        middlenameTextBox.Location = New Point(43, 173)
        middlenameTextBox.Margin = New Padding(4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(192, 31)
        middlenameTextBox.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(278, 144)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 26)
        Label3.TabIndex = 5
        Label3.Text = "Last Name"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Sitka Banner", 9.5F)
        lastnameTextBox.Location = New Point(278, 173)
        lastnameTextBox.Margin = New Padding(4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(195, 31)
        lastnameTextBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(43, 235)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 26)
        Label4.TabIndex = 7
        Label4.Text = "Program"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(191, 235)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 26)
        Label5.TabIndex = 9
        Label5.Text = "Year"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(338, 235)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 26)
        Label6.TabIndex = 11
        Label6.Text = "Section"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(43, 324)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 26)
        Label8.TabIndex = 15
        Label8.Text = "Email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Sitka Banner", 9.5F)
        emailTextBox.Location = New Point(43, 353)
        emailTextBox.Margin = New Padding(4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(236, 31)
        emailTextBox.TabIndex = 14
        ' 
        ' addStudentButton
        ' 
        addStudentButton.BackColor = Color.DarkSeaGreen
        addStudentButton.FlatStyle = FlatStyle.Popup
        addStudentButton.Location = New Point(50, 440)
        addStudentButton.Margin = New Padding(4)
        addStudentButton.Name = "addStudentButton"
        addStudentButton.Size = New Size(140, 37)
        addStudentButton.TabIndex = 18
        addStudentButton.Text = "Add Student"
        addStudentButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSeaGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(269, 444)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 35)
        Button2.TabIndex = 19
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.Font = New Font("Sitka Banner", 9.5F)
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(43, 265)
        programComboBox.Margin = New Padding(4)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(140, 36)
        programComboBox.TabIndex = 20
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.Font = New Font("Sitka Banner", 9.5F)
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(191, 265)
        yearComboBox.Margin = New Padding(4)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(140, 36)
        yearComboBox.TabIndex = 21
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.Font = New Font("Sitka Banner", 9.5F)
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(338, 265)
        sectionComboBox.Margin = New Padding(4)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(140, 36)
        sectionComboBox.TabIndex = 22
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Enabled = False
        studentIDTextBox.Font = New Font("Sitka Banner", 10F)
        studentIDTextBox.Location = New Point(137, 23)
        studentIDTextBox.Margin = New Padding(4)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(140, 33)
        studentIDTextBox.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(37, 26)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 29)
        Label10.TabIndex = 26
        Label10.Text = "Student ID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Banner Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(334, 324)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 26)
        Label7.TabIndex = 28
        Label7.Text = "Birthdate"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Location = New Point(379, 444)
        backButton.Margin = New Padding(4)
        backButton.Name = "backButton"
        backButton.Size = New Size(99, 37)
        backButton.TabIndex = 29
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' birthDate
        ' 
        birthDate.CustomFormat = "yyyy-MM-dd"
        birthDate.Font = New Font("Sitka Banner", 9.5F)
        birthDate.Format = DateTimePickerFormat.Custom
        birthDate.Location = New Point(337, 351)
        birthDate.Margin = New Padding(4)
        birthDate.Name = "birthDate"
        birthDate.Size = New Size(140, 31)
        birthDate.TabIndex = 31
        ' 
        ' AddStudentAccount
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(526, 526)
        Controls.Add(birthDate)
        Controls.Add(backButton)
        Controls.Add(Label7)
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
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents birthDate As DateTimePicker
End Class
