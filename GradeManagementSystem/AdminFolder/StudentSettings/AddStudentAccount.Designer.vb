﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Label7 = New Label()
        Label8 = New Label()
        emailTextBox = New TextBox()
        addStudentButton = New Button()
        Button2 = New Button()
        programComboBox = New ComboBox()
        yearComboBox = New ComboBox()
        sectionComboBox = New ComboBox()
        departmentComboBox = New ComboBox()
        studentIDTextBox = New MaskedTextBox()
        Label10 = New Label()
        birthCalendar = New MonthCalendar()
        SuspendLayout()
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(50, 114)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(50, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 1
        Label1.Text = "first"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(181, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 3
        Label2.Text = "middle"
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(181, 114)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(312, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 5
        Label3.Text = "last"
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(312, 114)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(443, 91)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 7
        Label4.Text = "program"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(50, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 9
        Label5.Text = "year"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(181, 165)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 11
        Label6.Text = "section"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(312, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 20)
        Label7.TabIndex = 13
        Label7.Text = "department"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(50, 243)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 15
        Label8.Text = "email"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(50, 266)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(256, 27)
        emailTextBox.TabIndex = 14
        ' 
        ' addStudentButton
        ' 
        addStudentButton.Location = New Point(50, 333)
        addStudentButton.Name = "addStudentButton"
        addStudentButton.Size = New Size(125, 29)
        addStudentButton.TabIndex = 18
        addStudentButton.Text = "Add Student"
        addStudentButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(50, 368)
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
        programComboBox.Location = New Point(443, 114)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(125, 28)
        programComboBox.TabIndex = 20
        ' 
        ' yearComboBox
        ' 
        yearComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        yearComboBox.FormattingEnabled = True
        yearComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        yearComboBox.Location = New Point(50, 188)
        yearComboBox.Name = "yearComboBox"
        yearComboBox.Size = New Size(125, 28)
        yearComboBox.TabIndex = 21
        ' 
        ' sectionComboBox
        ' 
        sectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        sectionComboBox.FormattingEnabled = True
        sectionComboBox.Location = New Point(181, 188)
        sectionComboBox.Name = "sectionComboBox"
        sectionComboBox.Size = New Size(125, 28)
        sectionComboBox.TabIndex = 22
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Items.AddRange(New Object() {"CCS"})
        departmentComboBox.Location = New Point(312, 188)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(125, 28)
        departmentComboBox.TabIndex = 23
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Enabled = False
        studentIDTextBox.Location = New Point(135, 37)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(125, 27)
        studentIDTextBox.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(50, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 20)
        Label10.TabIndex = 26
        Label10.Text = "Student ID"
        ' 
        ' birthCalendar
        ' 
        birthCalendar.Location = New Point(465, 165)
        birthCalendar.Name = "birthCalendar"
        birthCalendar.TabIndex = 27
        ' 
        ' AddStudentAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 450)
        Controls.Add(birthCalendar)
        Controls.Add(Label10)
        Controls.Add(studentIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(sectionComboBox)
        Controls.Add(yearComboBox)
        Controls.Add(programComboBox)
        Controls.Add(Button2)
        Controls.Add(addStudentButton)
        Controls.Add(Label8)
        Controls.Add(emailTextBox)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(lastnameTextBox)
        Controls.Add(Label2)
        Controls.Add(middlenameTextBox)
        Controls.Add(Label1)
        Controls.Add(firstnameTextBox)
        Name = "AddStudentAccount"
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents addStudentButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents yearComboBox As ComboBox
    Friend WithEvents sectionComboBox As ComboBox
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents studentIDTextBox As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents birthCalendar As MonthCalendar
End Class
