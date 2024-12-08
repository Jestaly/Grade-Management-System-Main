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
        addProgramButton.BackColor = Color.DarkSeaGreen
        addProgramButton.FlatStyle = FlatStyle.Popup
        addProgramButton.Font = New Font("Sitka Banner", 9F)
        addProgramButton.Location = New Point(40, 327)
        addProgramButton.Margin = New Padding(4)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(130, 37)
        addProgramButton.TabIndex = 0
        addProgramButton.Text = "Add Program"
        addProgramButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkSeaGreen
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Sitka Banner", 9F)
        Button2.Location = New Point(235, 327)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 37)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' dateAddedTextBox
        ' 
        dateAddedTextBox.Location = New Point(172, 144)
        dateAddedTextBox.Margin = New Padding(4)
        dateAddedTextBox.Name = "dateAddedTextBox"
        dateAddedTextBox.Size = New Size(218, 30)
        dateAddedTextBox.TabIndex = 3
        ' 
        ' programNameTextBox
        ' 
        programNameTextBox.Location = New Point(172, 100)
        programNameTextBox.Margin = New Padding(4)
        programNameTextBox.Name = "programNameTextBox"
        programNameTextBox.Size = New Size(218, 30)
        programNameTextBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(35, 100)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 29)
        Label2.TabIndex = 6
        Label2.Text = "Program Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(66, 143)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 29)
        Label3.TabIndex = 7
        Label3.Text = "Date Added:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(63, 62)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(112, 29)
        Label.TabIndex = 5
        Label.Text = "Program ID:"
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
        sectionBox.Location = New Point(172, 232)
        sectionBox.Margin = New Padding(4)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(86, 30)
        sectionBox.TabIndex = 10
        sectionBox.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(85, 232)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 29)
        Label1.TabIndex = 9
        Label1.Text = "Sections:"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.Location = New Point(328, 327)
        backButton.Margin = New Padding(4)
        backButton.Name = "backButton"
        backButton.Size = New Size(83, 37)
        backButton.TabIndex = 17
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(58, 186)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 29)
        Label4.TabIndex = 18
        Label4.Text = "Department:"
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(171, 186)
        departmentComboBox.Margin = New Padding(4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(218, 34)
        departmentComboBox.TabIndex = 19
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Location = New Point(172, 60)
        programIDTextBox.Margin = New Padding(4)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(99, 30)
        programIDTextBox.TabIndex = 20
        ' 
        ' AddProgramForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(452, 417)
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
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
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
