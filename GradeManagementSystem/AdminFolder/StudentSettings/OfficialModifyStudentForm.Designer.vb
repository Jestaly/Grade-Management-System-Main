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
        SuspendLayout()
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        sectionComboBox.Location = New Point(190, 161)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(125, 28)
        sectionComboBox.TabIndex = 41
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(59, 161)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(125, 28)
        yearComboBox.TabIndex = 40
        ' 
        ' programComboBox
        ' 
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(452, 87)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(125, 28)
        programComboBox.TabIndex = 39
        ' 
        ' modifyStudentButton
        ' 
        modifyStudentButton.Location = New Point(59, 306)
        modifyStudentButton.Name = "modifyStudentButton"
        modifyStudentButton.Size = New Size(125, 29)
        modifyStudentButton.TabIndex = 38
        modifyStudentButton.Text = "Modify Student"
        modifyStudentButton.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(59, 216)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 36
        Label8.Text = "email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(59, 239)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(256, 27)
        emailTextBox.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(190, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 33
        Label6.Text = "section"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 32
        Label5.Text = "year"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(452, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 31
        Label4.Text = "program"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(321, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 30
        Label3.Text = "last"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(321, 87)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 29
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(190, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 28
        Label2.Text = "middle"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(190, 87)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 26
        Label1.Text = "first"
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(59, 87)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 25
        ' 
        ' sidTextBox
        ' 
        sidTextBox.Enabled = False
        sidTextBox.Location = New Point(97, 23)
        sidTextBox.Name = "sidTextBox"
        sidTextBox.Size = New Size(80, 27)
        sidTextBox.TabIndex = 44
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(59, 26)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 20)
        Label10.TabIndex = 45
        Label10.Text = "SID"
        ' 
        ' birthCalendar
        ' 
        birthCalendar.Location = New Point(458, 138)
        birthCalendar.Name = "birthCalendar"
        birthCalendar.TabIndex = 46
        ' 
        ' OfficialModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(759, 399)
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
        Name = "OfficialModifyStudentForm"
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
End Class
