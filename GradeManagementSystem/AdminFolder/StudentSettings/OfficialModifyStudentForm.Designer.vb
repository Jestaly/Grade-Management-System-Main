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
        birthCalendar = New MonthCalendar()
        backButton = New Button()
        Label7 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(155, 121)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(125, 28)
        sectionComboBox.TabIndex = 41
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(24, 121)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(125, 28)
        yearComboBox.TabIndex = 40
        ' 
        ' programComboBox
        ' 
        programComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(286, 121)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(125, 28)
        programComboBox.TabIndex = 39
        ' 
        ' modifyStudentButton
        ' 
        modifyStudentButton.Location = New Point(24, 226)
        modifyStudentButton.Name = "modifyStudentButton"
        modifyStudentButton.Size = New Size(125, 29)
        modifyStudentButton.TabIndex = 38
        modifyStudentButton.Text = "Modify Student"
        modifyStudentButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(24, 153)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 36
        Label8.Text = "email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(24, 176)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(211, 27)
        emailTextBox.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(155, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 33
        Label6.Text = "section"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 98)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 32
        Label5.Text = "year"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(286, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 31
        Label4.Text = "program"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(286, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 30
        Label3.Text = "last"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(286, 72)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(155, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 28
        Label2.Text = "middle"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(155, 72)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 26
        Label1.Text = "first"
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(24, 72)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 25
        ' 
        ' sidTextBox
        ' 
        sidTextBox.Enabled = False
        sidTextBox.Location = New Point(66, 12)
        sidTextBox.Name = "sidTextBox"
        sidTextBox.Size = New Size(80, 27)
        sidTextBox.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(28, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 20)
        Label10.TabIndex = 45
        Label10.Text = "SID"
        ' 
        ' birthCalendar
        ' 
        birthCalendar.Location = New Point(170, 226)
        birthCalendar.Name = "birthCalendar"
        birthCalendar.TabIndex = 46
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(24, 296)
        backButton.Name = "backButton"
        backButton.Size = New Size(122, 29)
        backButton.TabIndex = 47
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(271, 197)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 20)
        Label7.TabIndex = 48
        Label7.Text = "birthdate"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(24, 261)
        Button2.Name = "Button2"
        Button2.Size = New Size(125, 29)
        Button2.TabIndex = 49
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' OfficialModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(468, 457)
        Controls.Add(Button2)
        Controls.Add(Label7)
        Controls.Add(backButton)
        Controls.Add(birthCalendar)
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
        FormBorderStyle = FormBorderStyle.None
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
    Friend WithEvents birthCalendar As MonthCalendar
    Friend WithEvents backButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
End Class
