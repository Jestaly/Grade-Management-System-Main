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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudentAccount))
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
        SIDTextBox = New MaskedTextBox()
        Label10 = New Label()
        Label7 = New Label()
        birthDate = New DateTimePicker()
        backbttn = New PictureBox()
        Label9 = New Label()
        ComboBox1 = New ComboBox()
        Label11 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Segoe UI", 11F)
        firstnameTextBox.Location = New Point(42, 163)
        firstnameTextBox.Margin = New Padding(4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(340, 37)
        firstnameTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(42, 139)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 1
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(392, 137)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 3
        Label2.Text = "Middle Name"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Segoe UI", 11F)
        middlenameTextBox.Location = New Point(393, 163)
        middlenameTextBox.Margin = New Padding(4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(204, 37)
        middlenameTextBox.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(635, 139)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 5
        Label3.Text = "Last Name"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Segoe UI", 11F)
        lastnameTextBox.Location = New Point(605, 163)
        lastnameTextBox.Margin = New Padding(4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(249, 37)
        lastnameTextBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(43, 271)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 25)
        Label4.TabIndex = 7
        Label4.Text = "Program"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(507, 270)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 25)
        Label5.TabIndex = 9
        Label5.Text = "Year"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(684, 272)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 25)
        Label6.TabIndex = 11
        Label6.Text = "Section"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(42, 340)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 25)
        Label8.TabIndex = 15
        Label8.Text = "Email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Segoe UI", 10F)
        emailTextBox.Location = New Point(42, 365)
        emailTextBox.Margin = New Padding(4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(445, 34)
        emailTextBox.TabIndex = 14
        ' 
        ' addStudentButton
        ' 
        addStudentButton.BackColor = Color.DarkGreen
        addStudentButton.FlatStyle = FlatStyle.Popup
        addStudentButton.ForeColor = Color.White
        addStudentButton.Location = New Point(605, 384)
        addStudentButton.Margin = New Padding(4)
        addStudentButton.Name = "addStudentButton"
        addStudentButton.Size = New Size(100, 38)
        addStudentButton.TabIndex = 18
        addStudentButton.Text = "Add"
        addStudentButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.White
        Button2.Location = New Point(723, 384)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(97, 38)
        Button2.TabIndex = 19
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.Font = New Font("Segoe UI", 10F)
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(43, 295)
        programComboBox.Margin = New Padding(4)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(444, 36)
        programComboBox.TabIndex = 20
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.Font = New Font("Segoe UI", 10F)
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(506, 295)
        yearComboBox.Margin = New Padding(4)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(170, 36)
        yearComboBox.TabIndex = 21
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.Font = New Font("Segoe UI", 10F)
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(684, 295)
        sectionComboBox.Margin = New Padding(4)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(170, 36)
        sectionComboBox.TabIndex = 22
        ' 
        ' SIDTextBox
        ' 
        SIDTextBox.Enabled = False
        SIDTextBox.Font = New Font("Segoe UI", 9F)
        SIDTextBox.Location = New Point(99, 95)
        SIDTextBox.Margin = New Padding(4)
        SIDTextBox.Mask = "0-00-00000"
        SIDTextBox.Name = "SIDTextBox"
        SIDTextBox.PromptChar = "X"c
        SIDTextBox.Size = New Size(179, 31)
        SIDTextBox.TabIndex = 25
        SIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(45, 98)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(44, 25)
        Label10.TabIndex = 26
        Label10.Text = "SID:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(247, 210)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 25)
        Label7.TabIndex = 28
        Label7.Text = "Birthdate"
        ' 
        ' birthDate
        ' 
        birthDate.CustomFormat = "yyyy-MM-dd"
        birthDate.Font = New Font("Segoe UI", 9F)
        birthDate.Format = DateTimePickerFormat.Custom
        birthDate.Location = New Point(250, 234)
        birthDate.Margin = New Padding(4)
        birthDate.Name = "birthDate"
        birthDate.Size = New Size(170, 31)
        birthDate.TabIndex = 31
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(13, 13)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 36)
        backbttn.TabIndex = 32
        backbttn.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(43, 206)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 25)
        Label9.TabIndex = 33
        Label9.Text = "Gender"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Female", "Male"})
        ComboBox1.Location = New Point(43, 231)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(170, 33)
        ComboBox1.TabIndex = 34
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(357, 33)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(179, 25)
        Label11.TabIndex = 35
        Label11.Text = "A D D  S T U D E N T"
        ' 
        ' AddStudentAccount
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(899, 459)
        Controls.Add(Label11)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(backbttn)
        Controls.Add(birthDate)
        Controls.Add(Label7)
        Controls.Add(Label10)
        Controls.Add(SIDTextBox)
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
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AddStudentAccount"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddStudentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents addStudentButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label11 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents lastnameTextBox As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Private WithEvents yearComboBox As ComboBox
    Private WithEvents sectionComboBox As ComboBox
    Private WithEvents Label10 As Label
    Private WithEvents Label7 As Label
    Private WithEvents birthDate As DateTimePicker
    Private WithEvents Label9 As Label
    Friend WithEvents SIDTextBox As MaskedTextBox
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
