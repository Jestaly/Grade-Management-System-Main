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
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(97, 81)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 29)
        Label1.TabIndex = 0
        Label1.Text = "Program ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(68, 128)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(141, 29)
        Label2.TabIndex = 1
        Label2.Text = "Program Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(97, 176)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 29)
        Label3.TabIndex = 2
        Label3.Text = "Date Added:"
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkSeaGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.ForeColor = Color.Black
        modifyButton.Location = New Point(69, 385)
        modifyButton.Margin = New Padding(4, 5, 4, 5)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(160, 42)
        modifyButton.TabIndex = 3
        modifyButton.Text = "Modify Program"
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' yearAddedTextBox
        ' 
        yearAddedTextBox.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        yearAddedTextBox.Location = New Point(212, 180)
        yearAddedTextBox.Margin = New Padding(4, 5, 4, 5)
        yearAddedTextBox.Name = "yearAddedTextBox"
        yearAddedTextBox.Size = New Size(155, 33)
        yearAddedTextBox.TabIndex = 4
        ' 
        ' programnameTextBox
        ' 
        programnameTextBox.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        programnameTextBox.Location = New Point(212, 131)
        programnameTextBox.Margin = New Padding(4, 5, 4, 5)
        programnameTextBox.Name = "programnameTextBox"
        programnameTextBox.Size = New Size(210, 33)
        programnameTextBox.TabIndex = 5
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        programIDTextBox.Location = New Point(212, 83)
        programIDTextBox.Margin = New Padding(4, 5, 4, 5)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(155, 33)
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
        sectionBox.Location = New Point(214, 275)
        sectionBox.Margin = New Padding(4, 6, 4, 6)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(95, 33)
        sectionBox.TabIndex = 12
        sectionBox.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(121, 272)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 29)
        Label4.TabIndex = 11
        Label4.Text = "Sections:"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.ForeColor = Color.Black
        backButton.Location = New Point(304, 385)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(118, 42)
        backButton.TabIndex = 18
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(212, 227)
        departmentComboBox.Margin = New Padding(4, 5, 4, 5)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(214, 37)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(93, 222)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 29)
        Label5.TabIndex = 20
        Label5.Text = "Department:"
        ' 
        ' OfficialModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(504, 496)
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
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
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
