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
        professorIDLabel = New Label()
        backButton = New Button()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(21, 135)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 1
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(21, 76)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 2
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(152, 73)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(21, 188)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(256, 27)
        emailTextBox.TabIndex = 4
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.Location = New Point(19, 230)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(114, 29)
        addProfessorButton.TabIndex = 5
        addProfessorButton.Text = "Add Professor"
        addProfessorButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(139, 232)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(114, 29)
        clearButton.TabIndex = 6
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 7
        Label1.Text = "first"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(152, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 8
        Label2.Text = "middle"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 9
        Label3.Text = "last"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(21, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 10
        Label4.Text = "email"
        ' 
        ' professorIDLabel
        ' 
        professorIDLabel.AutoSize = True
        professorIDLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        professorIDLabel.Location = New Point(19, 19)
        professorIDLabel.Name = "professorIDLabel"
        professorIDLabel.Size = New Size(96, 23)
        professorIDLabel.TabIndex = 11
        professorIDLabel.Text = "0-00-00000"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(194, 13)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 16
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(152, 134)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(125, 28)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(152, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 20
        Label5.Text = "Department"
        ' 
        ' AddProfessorAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(311, 301)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(backButton)
        Controls.Add(professorIDLabel)
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
    Friend WithEvents professorIDLabel As Label
    Friend WithEvents backButton As Button
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
End Class
