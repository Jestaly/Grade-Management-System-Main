<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGradeWeightForm
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
        quizTextBox = New TextBox()
        attTextBox = New TextBox()
        projectTextBox = New TextBox()
        examTextBox = New TextBox()
        deptComboBox = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        addPercentageButton = New Button()
        clearButton = New Button()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' quizTextBox
        ' 
        quizTextBox.Location = New Point(157, 72)
        quizTextBox.Name = "quizTextBox"
        quizTextBox.Size = New Size(125, 27)
        quizTextBox.TabIndex = 0
        ' 
        ' attTextBox
        ' 
        attTextBox.Location = New Point(157, 39)
        attTextBox.Name = "attTextBox"
        attTextBox.Size = New Size(125, 27)
        attTextBox.TabIndex = 1
        ' 
        ' projectTextBox
        ' 
        projectTextBox.Location = New Point(157, 105)
        projectTextBox.Name = "projectTextBox"
        projectTextBox.Size = New Size(125, 27)
        projectTextBox.TabIndex = 2
        ' 
        ' examTextBox
        ' 
        examTextBox.Location = New Point(157, 138)
        examTextBox.Name = "examTextBox"
        examTextBox.Size = New Size(125, 27)
        examTextBox.TabIndex = 3
        ' 
        ' deptComboBox
        ' 
        deptComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        deptComboBox.FormattingEnabled = True
        deptComboBox.Location = New Point(157, 171)
        deptComboBox.Name = "deptComboBox"
        deptComboBox.Size = New Size(125, 28)
        deptComboBox.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 5
        Label1.Text = "Attendance"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(112, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 6
        Label2.Text = "Quiz"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 7
        Label3.Text = "Project"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(106, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 20)
        Label4.TabIndex = 8
        Label4.Text = "Exam"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(66, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 9
        Label5.Text = "Department"
        ' 
        ' addPercentageButton
        ' 
        addPercentageButton.Location = New Point(52, 220)
        addPercentageButton.Name = "addPercentageButton"
        addPercentageButton.Size = New Size(139, 29)
        addPercentageButton.TabIndex = 10
        addPercentageButton.Text = "Add Percentages"
        addPercentageButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(197, 220)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(139, 29)
        clearButton.TabIndex = 11
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(334, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 12
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(440, 275)
        Controls.Add(backButton)
        Controls.Add(clearButton)
        Controls.Add(addPercentageButton)
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
        Name = "AddGradeWeightForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddGradeWeightForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents quizTextBox As TextBox
    Friend WithEvents attTextBox As TextBox
    Friend WithEvents projectTextBox As TextBox
    Friend WithEvents examTextBox As TextBox
    Friend WithEvents deptComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addPercentageButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backButton As Button
End Class
