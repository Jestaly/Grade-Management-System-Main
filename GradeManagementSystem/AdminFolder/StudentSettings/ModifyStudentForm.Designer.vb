﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyStudentForm
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
        StudentIDLabel = New Label()
        searchButton = New Button()
        studentIDTextBox = New MaskedTextBox()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' StudentIDLabel
        ' 
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StudentIDLabel.Location = New Point(112, 56)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New Size(121, 31)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID"
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(112, 162)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(137, 59)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentIDTextBox.Location = New Point(37, 90)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(287, 51)
        studentIDTextBox.TabIndex = 3
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(243, 21)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' ModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(365, 245)
        Controls.Add(backButton)
        Controls.Add(studentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(StudentIDLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModifyStudentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StudentIDLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents studentIDTextBox As MaskedTextBox
    Friend WithEvents backButton As Button
End Class
