<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyGradeWeightForm
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
        backButton = New Button()
        clearButton = New Button()
        modifyPercentageButton = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        deptComboBox = New ComboBox()
        examTextBox = New TextBox()
        projectTextBox = New TextBox()
        attTextBox = New TextBox()
        quizTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(331, 14)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 25
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(194, 222)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(139, 29)
        clearButton.TabIndex = 24
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' modifyPercentageButton
        ' 
        modifyPercentageButton.Location = New Point(49, 222)
        modifyPercentageButton.Name = "modifyPercentageButton"
        modifyPercentageButton.Size = New Size(139, 29)
        modifyPercentageButton.TabIndex = 23
        modifyPercentageButton.Text = "Modify Percentages"
        modifyPercentageButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 22
        Label5.Text = "Department"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(103, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 21
        Label4.Text = "Exam"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(93, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 20
        Label3.Text = "Project"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(109, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 19
        Label2.Text = "Quiz"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 18
        Label1.Text = "Attendance"
        ' 
        ' deptComboBox
        ' 
        deptComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        deptComboBox.FormattingEnabled = True
        deptComboBox.Location = New Point(154, 173)
        deptComboBox.Name = "deptComboBox"
        deptComboBox.Size = New Size(125, 28)
        deptComboBox.TabIndex = 17
        ' 
        ' examTextBox
        ' 
        examTextBox.Location = New Point(154, 140)
        examTextBox.Name = "examTextBox"
        examTextBox.Size = New Size(125, 27)
        examTextBox.TabIndex = 16
        ' 
        ' projectTextBox
        ' 
        projectTextBox.Location = New Point(154, 107)
        projectTextBox.Name = "projectTextBox"
        projectTextBox.Size = New Size(125, 27)
        projectTextBox.TabIndex = 15
        ' 
        ' attTextBox
        ' 
        attTextBox.Location = New Point(154, 41)
        attTextBox.Name = "attTextBox"
        attTextBox.Size = New Size(125, 27)
        attTextBox.TabIndex = 14
        ' 
        ' quizTextBox
        ' 
        quizTextBox.Location = New Point(154, 74)
        quizTextBox.Name = "quizTextBox"
        quizTextBox.Size = New Size(125, 27)
        quizTextBox.TabIndex = 13
        ' 
        ' OfficialModifyGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(439, 301)
        Controls.Add(backButton)
        Controls.Add(clearButton)
        Controls.Add(modifyPercentageButton)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(deptComboBox)
        Controls.Add(examTextBox)
        Controls.Add(projectTextBox)
        Controls.Add(attTextBox)
        Controls.Add(quizTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "OfficialModifyGradeWeightForm"
        Text = "OfficialModifyGradeWeightForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents modifyPercentageButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents deptComboBox As ComboBox
    Friend WithEvents examTextBox As TextBox
    Friend WithEvents projectTextBox As TextBox
    Friend WithEvents attTextBox As TextBox
    Friend WithEvents quizTextBox As TextBox
End Class
