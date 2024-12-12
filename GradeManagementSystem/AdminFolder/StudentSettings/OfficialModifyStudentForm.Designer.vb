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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyStudentForm))
        modifyStudentButton = New Button()
        Button2 = New Button()
        Label11 = New Label()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        birthDate = New DateTimePicker()
        Label7 = New Label()
        Label10 = New Label()
        SIDTextBox = New MaskedTextBox()
        sectionComboBox = New ComboBox()
        yearComboBox = New ComboBox()
        programComboBox = New ComboBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        lastnameTextBox = New TextBox()
        Label2 = New Label()
        middlenameTextBox = New TextBox()
        Label1 = New Label()
        firstnameTextBox = New TextBox()
        backbttn = New PictureBox()
        Label8 = New Label()
        emailTextBox = New TextBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' modifyStudentButton
        ' 
        modifyStudentButton.BackColor = Color.DarkGreen
        modifyStudentButton.FlatStyle = FlatStyle.Popup
        modifyStudentButton.ForeColor = Color.White
        modifyStudentButton.Location = New Point(623, 341)
        modifyStudentButton.Margin = New Padding(4, 3, 4, 3)
        modifyStudentButton.Name = "modifyStudentButton"
        modifyStudentButton.Size = New Size(102, 35)
        modifyStudentButton.TabIndex = 38
        modifyStudentButton.Text = "Modify"
        modifyStudentButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.White
        Button2.Location = New Point(748, 341)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 35)
        Button2.TabIndex = 49
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(338, 34)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(229, 25)
        Label11.TabIndex = 51
        Label11.Text = "M O D I F Y   S T U D E N T"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Female", "Male"})
        ComboBox1.Location = New Point(46, 201)
        ComboBox1.Margin = New Padding(4, 3, 4, 3)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(170, 33)
        ComboBox1.TabIndex = 69
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(46, 178)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 25)
        Label9.TabIndex = 68
        Label9.Text = "Gender"
        ' 
        ' birthDate
        ' 
        birthDate.CustomFormat = "yyyy-MM-dd"
        birthDate.Font = New Font("Segoe UI", 9F)
        birthDate.Format = DateTimePickerFormat.Custom
        birthDate.Location = New Point(253, 203)
        birthDate.Margin = New Padding(4, 3, 4, 3)
        birthDate.Name = "birthDate"
        birthDate.Size = New Size(170, 31)
        birthDate.TabIndex = 67
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(250, 183)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 25)
        Label7.TabIndex = 66
        Label7.Text = "Birthdate"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(48, 83)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 25)
        Label10.TabIndex = 65
        Label10.Text = "SID:"
        ' 
        ' SIDTextBox
        ' 
        SIDTextBox.Enabled = False
        SIDTextBox.Font = New Font("Segoe UI", 9F)
        SIDTextBox.Location = New Point(102, 80)
        SIDTextBox.Margin = New Padding(4, 3, 4, 3)
        SIDTextBox.Mask = "0-00-00000"
        SIDTextBox.Name = "SIDTextBox"
        SIDTextBox.PromptChar = "X"c
        SIDTextBox.Size = New Size(179, 31)
        SIDTextBox.TabIndex = 64
        SIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.Font = New Font("Segoe UI", 10F)
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(687, 258)
        sectionComboBox.Margin = New Padding(4, 3, 4, 3)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(170, 36)
        sectionComboBox.TabIndex = 63
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.Font = New Font("Segoe UI", 10F)
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(509, 258)
        yearComboBox.Margin = New Padding(4, 3, 4, 3)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(170, 36)
        yearComboBox.TabIndex = 62
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.Font = New Font("Segoe UI", 10F)
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(46, 258)
        programComboBox.Margin = New Padding(4, 3, 4, 3)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(444, 36)
        programComboBox.TabIndex = 61
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(687, 238)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 25)
        Label6.TabIndex = 60
        Label6.Text = "Section"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(510, 236)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 25)
        Label5.TabIndex = 59
        Label5.Text = "Year"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(46, 237)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 25)
        Label4.TabIndex = 58
        Label4.Text = "Program"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(638, 119)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 57
        Label3.Text = "Last Name"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Segoe UI", 11F)
        lastnameTextBox.Location = New Point(608, 140)
        lastnameTextBox.Margin = New Padding(4, 3, 4, 3)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(249, 37)
        lastnameTextBox.TabIndex = 56
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(395, 117)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 55
        Label2.Text = "Middle Name"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Segoe UI", 11F)
        middlenameTextBox.Location = New Point(396, 140)
        middlenameTextBox.Margin = New Padding(4, 3, 4, 3)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(204, 37)
        middlenameTextBox.TabIndex = 54
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(45, 119)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 53
        Label1.Text = "First Name"
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Segoe UI", 11F)
        firstnameTextBox.Location = New Point(45, 140)
        firstnameTextBox.Margin = New Padding(4, 3, 4, 3)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(340, 37)
        firstnameTextBox.TabIndex = 52
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(7, 5)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 32)
        backbttn.TabIndex = 70
        backbttn.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(48, 297)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 25)
        Label8.TabIndex = 72
        Label8.Text = "Email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Segoe UI", 10F)
        emailTextBox.Location = New Point(48, 320)
        emailTextBox.Margin = New Padding(4, 3, 4, 3)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(445, 34)
        emailTextBox.TabIndex = 71
        ' 
        ' OfficialModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(899, 409)
        Controls.Add(Label8)
        Controls.Add(emailTextBox)
        Controls.Add(backbttn)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(birthDate)
        Controls.Add(Label7)
        Controls.Add(Label10)
        Controls.Add(SIDTextBox)
        Controls.Add(sectionComboBox)
        Controls.Add(yearComboBox)
        Controls.Add(programComboBox)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lastnameTextBox)
        Controls.Add(Label2)
        Controls.Add(middlenameTextBox)
        Controls.Add(Label1)
        Controls.Add(firstnameTextBox)
        Controls.Add(Label11)
        Controls.Add(Button2)
        Controls.Add(modifyStudentButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "OfficialModifyStudentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyStudentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents modifyStudentButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents birthDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SIDTextBox As MaskedTextBox
    Friend WithEvents sectionComboBox As ComboBox
    Friend WithEvents yearComboBox As ComboBox
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
End Class
