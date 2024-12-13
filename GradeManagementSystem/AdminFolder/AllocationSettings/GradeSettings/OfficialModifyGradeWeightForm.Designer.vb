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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyGradeWeightForm))
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
        Label6 = New Label()
        backbttn = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(383, 220)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(131, 39)
        clearButton.TabIndex = 24
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' modifyPercentageButton
        ' 
        modifyPercentageButton.BackColor = Color.DarkGreen
        modifyPercentageButton.FlatStyle = FlatStyle.Popup
        modifyPercentageButton.ForeColor = Color.White
        modifyPercentageButton.Location = New Point(228, 220)
        modifyPercentageButton.Margin = New Padding(4)
        modifyPercentageButton.Name = "modifyPercentageButton"
        modifyPercentageButton.Size = New Size(132, 36)
        modifyPercentageButton.TabIndex = 23
        modifyPercentageButton.Text = "Modify Percentages"
        modifyPercentageButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(55, 77)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 28)
        Label5.TabIndex = 22
        Label5.Text = "Department:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(383, 151)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 28)
        Label4.TabIndex = 21
        Label4.Text = "Exam:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(368, 118)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 28)
        Label3.TabIndex = 20
        Label3.Text = "Project:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(124, 151)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 28)
        Label2.TabIndex = 19
        Label2.Text = "Quiz:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(61, 121)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 28)
        Label1.TabIndex = 18
        Label1.Text = "Attendance:"
        ' 
        ' deptComboBox
        ' 
        deptComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        deptComboBox.Enabled = False
        deptComboBox.FormattingEnabled = True
        deptComboBox.Location = New Point(190, 77)
        deptComboBox.Margin = New Padding(4)
        deptComboBox.Name = "deptComboBox"
        deptComboBox.Size = New Size(416, 33)
        deptComboBox.TabIndex = 17
        ' 
        ' examTextBox
        ' 
        examTextBox.Location = New Point(451, 154)
        examTextBox.Margin = New Padding(4)
        examTextBox.Name = "examTextBox"
        examTextBox.Size = New Size(155, 31)
        examTextBox.TabIndex = 16
        ' 
        ' projectTextBox
        ' 
        projectTextBox.Location = New Point(451, 115)
        projectTextBox.Margin = New Padding(4)
        projectTextBox.Name = "projectTextBox"
        projectTextBox.Size = New Size(155, 31)
        projectTextBox.TabIndex = 15
        ' 
        ' attTextBox
        ' 
        attTextBox.Location = New Point(190, 118)
        attTextBox.Margin = New Padding(4)
        attTextBox.Name = "attTextBox"
        attTextBox.Size = New Size(155, 31)
        attTextBox.TabIndex = 14
        ' 
        ' quizTextBox
        ' 
        quizTextBox.Location = New Point(190, 154)
        quizTextBox.Margin = New Padding(4)
        quizTextBox.Name = "quizTextBox"
        quizTextBox.Size = New Size(155, 31)
        quizTextBox.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(203, 17)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(342, 28)
        Label6.TabIndex = 50
        Label6.Text = "M O D I F Y  G R A D E  WE I G H T "
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 14)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 51
        backbttn.TabStop = False
        ' 
        ' OfficialModifyGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(724, 298)
        Controls.Add(backbttn)
        Controls.Add(Label6)
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
        Margin = New Padding(4)
        Name = "OfficialModifyGradeWeightForm"
        Text = "OfficialModifyGradeWeightForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents Label6 As Label
    Friend WithEvents backbttn As PictureBox
End Class
