<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgramForm
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
        addProgramButton = New Button()
        Button2 = New Button()
        dateAddedTextBox = New TextBox()
        programNameTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label = New Label()
        sectionBox = New DomainUpDown()
        Label1 = New Label()
        backButton = New Button()
        Label4 = New Label()
        departmentComboBox = New ComboBox()
        programIDTextBox = New MaskedTextBox()
        SuspendLayout()
        ' 
        ' addProgramButton
        ' 
        addProgramButton.Location = New Point(54, 207)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(109, 29)
        addProgramButton.TabIndex = 0
        addProgramButton.Text = "Add Program"
        addProgramButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(169, 207)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 29)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' dateAddedTextBox
        ' 
        dateAddedTextBox.Location = New Point(154, 101)
        dateAddedTextBox.Name = "dateAddedTextBox"
        dateAddedTextBox.Size = New Size(172, 27)
        dateAddedTextBox.TabIndex = 3
        ' 
        ' programNameTextBox
        ' 
        programNameTextBox.Location = New Point(154, 68)
        programNameTextBox.Name = "programNameTextBox"
        programNameTextBox.Size = New Size(172, 27)
        programNameTextBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 6
        Label2.Text = "Program Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 7
        Label3.Text = "Date Added"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Location = New Point(22, 33)
        Label.Name = "Label"
        Label.Size = New Size(85, 20)
        Label.TabIndex = 5
        Label.Text = "Program ID"
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
        sectionBox.Location = New Point(154, 169)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(76, 27)
        sectionBox.TabIndex = 10
        sectionBox.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 9
        Label1.Text = "Sections"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(278, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 17
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 18
        Label4.Text = "Department"
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(154, 135)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(172, 28)
        departmentComboBox.TabIndex = 19
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Location = New Point(113, 30)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(89, 27)
        programIDTextBox.TabIndex = 20
        ' 
        ' AddProgramForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(394, 262)
        Controls.Add(programIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(Label4)
        Controls.Add(backButton)
        Controls.Add(sectionBox)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(programNameTextBox)
        Controls.Add(dateAddedTextBox)
        Controls.Add(Button2)
        Controls.Add(addProgramButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddProgramForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addProgramButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dateAddedTextBox As TextBox
    Friend WithEvents programNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents sectionBox As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents programIDTextBox As MaskedTextBox
End Class
