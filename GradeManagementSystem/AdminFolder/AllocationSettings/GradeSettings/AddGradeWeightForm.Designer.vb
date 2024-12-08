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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        addPercentageButton = New Button()
        clearButton = New Button()
        backButton = New Button()
        deptComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' quizTextBox
        ' 
        quizTextBox.Location = New Point(164, 126)
        quizTextBox.Margin = New Padding(4)
        quizTextBox.Name = "quizTextBox"
        quizTextBox.Size = New Size(155, 31)
        quizTextBox.TabIndex = 0
        ' 
        ' attTextBox
        ' 
        attTextBox.Location = New Point(165, 87)
        attTextBox.Margin = New Padding(4)
        attTextBox.Name = "attTextBox"
        attTextBox.Size = New Size(155, 31)
        attTextBox.TabIndex = 1
        ' 
        ' projectTextBox
        ' 
        projectTextBox.Location = New Point(486, 89)
        projectTextBox.Margin = New Padding(4)
        projectTextBox.Name = "projectTextBox"
        projectTextBox.Size = New Size(155, 31)
        projectTextBox.TabIndex = 2
        ' 
        ' examTextBox
        ' 
        examTextBox.Location = New Point(486, 128)
        examTextBox.Margin = New Padding(4)
        examTextBox.Name = "examTextBox"
        examTextBox.Size = New Size(155, 31)
        examTextBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(54, 86)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 29)
        Label1.TabIndex = 5
        Label1.Text = "Attendance:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(108, 125)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 29)
        Label2.TabIndex = 6
        Label2.Text = "Quiz:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(413, 87)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 29)
        Label3.TabIndex = 7
        Label3.Text = "Project:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(424, 126)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 29)
        Label4.TabIndex = 8
        Label4.Text = "Exam:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(50, 35)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 29)
        Label5.TabIndex = 9
        Label5.Text = "Department:"
        ' 
        ' addPercentageButton
        ' 
        addPercentageButton.BackColor = Color.DarkSeaGreen
        addPercentageButton.FlatStyle = FlatStyle.Popup
        addPercentageButton.Font = New Font("Sitka Banner", 9F)
        addPercentageButton.Location = New Point(108, 211)
        addPercentageButton.Margin = New Padding(4)
        addPercentageButton.Name = "addPercentageButton"
        addPercentageButton.Size = New Size(172, 36)
        addPercentageButton.TabIndex = 10
        addPercentageButton.Text = "Add Percentages"
        addPercentageButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.Location = New Point(424, 211)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(94, 36)
        clearButton.TabIndex = 11
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.Location = New Point(526, 211)
        backButton.Margin = New Padding(4)
        backButton.Name = "backButton"
        backButton.Size = New Size(86, 36)
        backButton.TabIndex = 12
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' deptComboBox
        ' 
        deptComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        deptComboBox.FormattingEnabled = True
        deptComboBox.Location = New Point(164, 35)
        deptComboBox.Margin = New Padding(4)
        deptComboBox.Name = "deptComboBox"
        deptComboBox.Size = New Size(477, 33)
        deptComboBox.TabIndex = 4
        ' 
        ' AddGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(724, 298)
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
        Margin = New Padding(4)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addPercentageButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents deptComboBox As ComboBox
End Class
