<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyProfessorForm
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
        profIDTextBox = New MaskedTextBox()
        firstnameTextBox = New TextBox()
        middlenameTextBox = New TextBox()
        lastnameTextBox = New TextBox()
        emailTextBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        modifyButton = New Button()
        clearButton = New Button()
        backButton = New Button()
        departmentComboBox = New ComboBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Enabled = False
        profIDTextBox.Location = New Point(178, 66)
        profIDTextBox.Margin = New Padding(4)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "X"c
        profIDTextBox.Size = New Size(155, 33)
        profIDTextBox.TabIndex = 0
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Sitka Banner", 10F)
        firstnameTextBox.Location = New Point(64, 155)
        firstnameTextBox.Margin = New Padding(4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(397, 33)
        firstnameTextBox.TabIndex = 1
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Sitka Banner", 10F)
        middlenameTextBox.Location = New Point(64, 223)
        middlenameTextBox.Margin = New Padding(4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(186, 33)
        middlenameTextBox.TabIndex = 2
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Sitka Banner", 10F)
        lastnameTextBox.Location = New Point(276, 223)
        lastnameTextBox.Margin = New Padding(4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(185, 33)
        lastnameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Sitka Banner", 10F)
        emailTextBox.Location = New Point(65, 367)
        emailTextBox.Margin = New Padding(4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(399, 33)
        emailTextBox.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(64, 66)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 29)
        Label1.TabIndex = 5
        Label1.Text = "Professor ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(64, 120)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 29)
        Label2.TabIndex = 6
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(64, 194)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 29)
        Label3.TabIndex = 7
        Label3.Text = "Middle Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(276, 194)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 29)
        Label4.TabIndex = 8
        Label4.Text = "Last Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(65, 334)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 29)
        Label5.TabIndex = 9
        Label5.Text = "Email"
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkSeaGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.Location = New Point(64, 468)
        modifyButton.Margin = New Padding(4)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(169, 41)
        modifyButton.TabIndex = 10
        modifyButton.Text = "Modify Professor"
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Location = New Point(285, 468)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(85, 40)
        clearButton.TabIndex = 11
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Location = New Point(378, 469)
        backButton.Margin = New Padding(4)
        backButton.Name = "backButton"
        backButton.Size = New Size(86, 40)
        backButton.TabIndex = 17
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Sitka Banner", 10F)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(65, 291)
        departmentComboBox.Margin = New Padding(4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(399, 37)
        departmentComboBox.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(65, 257)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 29)
        Label6.TabIndex = 22
        Label6.Text = "Department"
        ' 
        ' OfficialModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(526, 577)
        Controls.Add(departmentComboBox)
        Controls.Add(Label6)
        Controls.Add(backButton)
        Controls.Add(clearButton)
        Controls.Add(modifyButton)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(emailTextBox)
        Controls.Add(lastnameTextBox)
        Controls.Add(middlenameTextBox)
        Controls.Add(firstnameTextBox)
        Controls.Add(profIDTextBox)
        Font = New Font("Sitka Banner", 10F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "OfficialModifyProfessorForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyProfessorForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents profIDTextBox As MaskedTextBox
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents modifyButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label6 As Label
End Class
