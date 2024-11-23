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
        SuspendLayout()
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(315, 120)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 1
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(53, 120)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 2
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(184, 120)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(53, 186)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(125, 27)
        emailTextBox.TabIndex = 4
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.Location = New Point(54, 243)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(114, 29)
        addProfessorButton.TabIndex = 5
        addProfessorButton.Text = "Add Professor"
        addProfessorButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(53, 278)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(114, 29)
        clearButton.TabIndex = 6
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(53, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 20)
        Label1.TabIndex = 7
        Label1.Text = "first"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(184, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 8
        Label2.Text = "middle"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(315, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 9
        Label3.Text = "last"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(53, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 10
        Label4.Text = "email"
        ' 
        ' professorIDLabel
        ' 
        professorIDLabel.AutoSize = True
        professorIDLabel.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        professorIDLabel.Location = New Point(50, 46)
        professorIDLabel.Name = "professorIDLabel"
        professorIDLabel.Size = New Size(96, 23)
        professorIDLabel.TabIndex = 11
        professorIDLabel.Text = "0-00-00000"
        ' 
        ' AddProfessorAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 381)
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
        Name = "AddProfessorAccount"
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
End Class
