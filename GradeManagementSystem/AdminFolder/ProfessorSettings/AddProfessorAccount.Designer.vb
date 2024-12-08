<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfessorAccount
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
        lastnameTextBox = New TextBox()
        firstnameTextBox = New TextBox()
        middlenameTextBox = New TextBox()
        emailTextBox = New TextBox()
        addProfessorButton = New Button()
        clearButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        backButton = New Button()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        professorIDTextBox = New MaskedTextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Segoe UI", 10F)
        lastnameTextBox.Location = New Point(292, 225)
        lastnameTextBox.Margin = New Padding(4, 4, 4, 4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(187, 34)
        lastnameTextBox.TabIndex = 1
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Segoe UI", 10F)
        firstnameTextBox.Location = New Point(52, 156)
        firstnameTextBox.Margin = New Padding(4, 4, 4, 4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(430, 34)
        firstnameTextBox.TabIndex = 2
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Segoe UI", 10F)
        middlenameTextBox.Location = New Point(52, 225)
        middlenameTextBox.Margin = New Padding(4, 4, 4, 4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(208, 34)
        middlenameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Segoe UI", 10F)
        emailTextBox.Location = New Point(52, 364)
        emailTextBox.Margin = New Padding(4, 4, 4, 4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(430, 34)
        emailTextBox.TabIndex = 4
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.BackColor = Color.DarkSeaGreen
        addProfessorButton.FlatStyle = FlatStyle.Popup
        addProfessorButton.Font = New Font("Sitka Banner", 9F)
        addProfessorButton.Location = New Point(59, 474)
        addProfessorButton.Margin = New Padding(4, 4, 4, 4)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(142, 36)
        addProfessorButton.TabIndex = 5
        addProfessorButton.Text = "Add Professor"
        addProfessorButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkSeaGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.Location = New Point(278, 474)
        clearButton.Margin = New Padding(4, 4, 4, 4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(89, 36)
        clearButton.TabIndex = 6
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(52, 127)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 29)
        Label1.TabIndex = 7
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(52, 196)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 29)
        Label2.TabIndex = 8
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(292, 196)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 29)
        Label3.TabIndex = 9
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(49, 335)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 29)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkSeaGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.Location = New Point(379, 474)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(95, 36)
        backButton.TabIndex = 16
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Segoe UI", 10F)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(52, 295)
        departmentComboBox.Margin = New Padding(4, 4, 4, 4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(430, 36)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(52, 266)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(109, 29)
        Label5.TabIndex = 20
        Label5.Text = "Department"
        ' 
        ' professorIDTextBox
        ' 
        professorIDTextBox.Enabled = False
        professorIDTextBox.Font = New Font("Segoe UI", 10F)
        professorIDTextBox.Location = New Point(167, 61)
        professorIDTextBox.Margin = New Padding(4, 4, 4, 4)
        professorIDTextBox.Mask = "0-00-00000"
        professorIDTextBox.Name = "professorIDTextBox"
        professorIDTextBox.PromptChar = "X"c
        professorIDTextBox.Size = New Size(155, 34)
        professorIDTextBox.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(49, 64)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 29)
        Label6.TabIndex = 23
        Label6.Text = "Professor ID:"
        ' 
        ' AddProfessorAccount
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(526, 577)
        Controls.Add(Label6)
        Controls.Add(professorIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(backButton)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(clearButton)
        Controls.Add(addProfessorButton)
        Controls.Add(emailTextBox)
        Controls.Add(middlenameTextBox)
        Controls.Add(firstnameTextBox)
        Controls.Add(lastnameTextBox)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "AddProfessorAccount"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddProfessorAccount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents addProfessorButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents professorIDTextBox As MaskedTextBox
    Friend WithEvents Label6 As Label
End Class
