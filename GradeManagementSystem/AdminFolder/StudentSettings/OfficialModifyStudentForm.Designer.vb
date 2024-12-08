<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyStudentForm
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
        sectionComboBox = New ComboBox()
        yearComboBox = New ComboBox()
        programComboBox = New ComboBox()
        modifyStudentButton = New Button()
        Label8 = New Label()
        emailTextBox = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lastnameTextBox = New TextBox()
        Label2 = New Label()
        middlenameTextBox = New TextBox()
        Label1 = New Label()
        firstnameTextBox = New TextBox()
        sidTextBox = New TextBox()
        Label10 = New Label()
        backButton = New Button()
        Label7 = New Label()
        Button2 = New Button()
        birthDate = New DateTimePicker()
        SuspendLayout()
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(371, 292)
        sectionComboBox.Margin = New Padding(4, 4, 4, 4)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(106, 36)
        sectionComboBox.TabIndex = 41
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(260, 292)
        yearComboBox.Margin = New Padding(4, 4, 4, 4)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(88, 36)
        yearComboBox.TabIndex = 40
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(42, 292)
        programComboBox.Margin = New Padding(4, 4, 4, 4)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(188, 36)
        programComboBox.TabIndex = 39
        ' 
        ' modifyStudentButton
        ' 
        modifyStudentButton.BackColor = Color.DarkSeaGreen
        modifyStudentButton.FlatStyle = FlatStyle.Popup
        modifyStudentButton.Location = New Point(44, 495)
        modifyStudentButton.Margin = New Padding(4, 4, 4, 4)
        modifyStudentButton.Name = "modifyStudentButton"
        modifyStudentButton.Size = New Size(156, 40)
        modifyStudentButton.TabIndex = 38
        modifyStudentButton.Text = "Modify Student"
        modifyStudentButton.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(44, 365)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 28)
        Label8.TabIndex = 36
        Label8.Text = "Email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        emailTextBox.Location = New Point(44, 395)
        emailTextBox.Margin = New Padding(4, 4, 4, 4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(254, 31)
        emailTextBox.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(369, 264)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 28)
        Label6.TabIndex = 33
        Label6.Text = "Section"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(258, 265)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 28)
        Label5.TabIndex = 32
        Label5.Text = "Year"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(40, 265)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 28)
        Label4.TabIndex = 31
        Label4.Text = "Program"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(276, 177)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 30
        Label3.Text = "Last Name"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        lastnameTextBox.Location = New Point(276, 204)
        lastnameTextBox.Margin = New Padding(4, 4, 4, 4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(202, 31)
        lastnameTextBox.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(42, 178)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 28
        Label2.Text = "Middle Name"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        middlenameTextBox.Location = New Point(42, 204)
        middlenameTextBox.Margin = New Padding(4, 4, 4, 4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(188, 31)
        middlenameTextBox.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(36, 98)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 28)
        Label1.TabIndex = 26
        Label1.Text = "First Name"
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        firstnameTextBox.Location = New Point(42, 130)
        firstnameTextBox.Margin = New Padding(4, 4, 4, 4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(435, 31)
        firstnameTextBox.TabIndex = 25
        ' 
        ' sidTextBox
        ' 
        sidTextBox.Enabled = False
        sidTextBox.Location = New Point(132, 29)
        sidTextBox.Margin = New Padding(4, 4, 4, 4)
        sidTextBox.Name = "sidTextBox"
        sidTextBox.Size = New Size(131, 31)
        sidTextBox.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(34, 29)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 29)
        Label10.TabIndex = 45
        Label10.Text = "Student ID:"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Location = New Point(383, 495)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 40)
        backButton.TabIndex = 47
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(317, 363)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 28)
        Label7.TabIndex = 48
        Label7.Text = "Birthdate"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSeaGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(286, 495)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 40)
        Button2.TabIndex = 49
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' birthDate
        ' 
        birthDate.CustomFormat = "yyyy-MM-dd"
        birthDate.Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        birthDate.Format = DateTimePickerFormat.Custom
        birthDate.Location = New Point(317, 394)
        birthDate.Margin = New Padding(4, 4, 4, 4)
        birthDate.Name = "birthDate"
        birthDate.Size = New Size(160, 31)
        birthDate.TabIndex = 50
        ' 
        ' OfficialModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(526, 589)
        Controls.Add(birthDate)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(backButton)
        Controls.Add(Label10)
        Controls.Add(sidTextBox)
        Controls.Add(sectionComboBox)
        Controls.Add(yearComboBox)
        Controls.Add(programComboBox)
        Controls.Add(modifyStudentButton)
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
        Font = New Font("Sitka Banner Semibold", 9.5F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "OfficialModifyStudentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents sectionComboBox As ComboBox
    Friend WithEvents yearComboBox As ComboBox
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents modifyStudentButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents sidTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents birthDate As DateTimePicker
End Class
