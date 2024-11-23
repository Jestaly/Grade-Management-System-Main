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
        SuspendLayout()
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Enabled = False
        profIDTextBox.Location = New Point(85, 29)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "X"c
        profIDTextBox.Size = New Size(125, 27)
        profIDTextBox.TabIndex = 0
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Location = New Point(68, 108)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(125, 27)
        firstnameTextBox.TabIndex = 1
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Location = New Point(307, 108)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(125, 27)
        middlenameTextBox.TabIndex = 2
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Location = New Point(67, 178)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(125, 27)
        lastnameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Location = New Point(307, 178)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(125, 27)
        emailTextBox.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 5
        Label1.Text = "Prof ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 20)
        Label2.TabIndex = 6
        Label2.Text = "First"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(245, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 20)
        Label3.TabIndex = 7
        Label3.Text = "Middle"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 20)
        Label4.TabIndex = 8
        Label4.Text = "Last"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(255, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 20)
        Label5.TabIndex = 9
        Label5.Text = "Email"
        ' 
        ' modifyButton
        ' 
        modifyButton.Location = New Point(57, 259)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(135, 29)
        modifyButton.TabIndex = 10
        modifyButton.Text = "Modify Professor"
        modifyButton.UseVisualStyleBackColor = True
        ' 
        ' clearButton
        ' 
        clearButton.Location = New Point(57, 303)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(135, 29)
        clearButton.TabIndex = 11
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = True
        ' 
        ' OfficialModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 392)
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
        Name = "OfficialModifyProfessorForm"
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
End Class
