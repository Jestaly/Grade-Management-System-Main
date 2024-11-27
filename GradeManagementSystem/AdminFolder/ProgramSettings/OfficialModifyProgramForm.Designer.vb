<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyProgramForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        modifyButton = New Button()
        yearAddedTextBox = New TextBox()
        programnameTextBox = New TextBox()
        programIDTextBox = New MaskedTextBox()
        sectionBox = New DomainUpDown()
        Label4 = New Label()
        backButton = New Button()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 0
        Label1.Text = "Program ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(2, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 1
        Label2.Text = "Program Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 2
        Label3.Text = "Date Added"
        ' 
        ' modifyButton
        ' 
        modifyButton.Location = New Point(23, 170)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(128, 29)
        modifyButton.TabIndex = 3
        modifyButton.Text = "Modify Program"
        modifyButton.UseVisualStyleBackColor = True
        ' 
        ' yearAddedTextBox
        ' 
        yearAddedTextBox.Location = New Point(118, 70)
        yearAddedTextBox.Name = "yearAddedTextBox"
        yearAddedTextBox.Size = New Size(125, 27)
        yearAddedTextBox.TabIndex = 4
        ' 
        ' programnameTextBox
        ' 
        programnameTextBox.Location = New Point(118, 37)
        programnameTextBox.Name = "programnameTextBox"
        programnameTextBox.Size = New Size(169, 27)
        programnameTextBox.TabIndex = 5
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Location = New Point(118, 4)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(125, 27)
        programIDTextBox.TabIndex = 6
        ' 
        ' sectionBox
        ' 
        sectionBox.BorderStyle = BorderStyle.FixedSingle
        sectionBox.Items.Add("1")
        sectionBox.Items.Add("2")
        sectionBox.Items.Add("3")
        sectionBox.Items.Add("4")
        sectionBox.Items.Add("5")
        sectionBox.Items.Add("6")
        sectionBox.Items.Add("7")
        sectionBox.Items.Add("8")
        sectionBox.Items.Add("9")
        sectionBox.Items.Add("10")
        sectionBox.Location = New Point(115, 136)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(76, 27)
        sectionBox.TabIndex = 12
        sectionBox.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 11
        Label4.Text = "Sections"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(235, 165)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 18
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(115, 103)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(172, 28)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 105)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 20
        Label5.Text = "Department"
        ' 
        ' OfficialModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(353, 211)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(backButton)
        Controls.Add(sectionBox)
        Controls.Add(Label4)
        Controls.Add(programIDTextBox)
        Controls.Add(programnameTextBox)
        Controls.Add(yearAddedTextBox)
        Controls.Add(modifyButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "OfficialModifyProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyProgramForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents modifyButton As Button
    Friend WithEvents yearAddedTextBox As TextBox
    Friend WithEvents programnameTextBox As TextBox
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents sectionBox As DomainUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
End Class
