<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        accountIDLabel = New Label()
        accountIDTextBoxRegister = New TextBox()
        accountTypeRegister = New ComboBox()
        accountType = New Label()
        Label2 = New Label()
        Label1 = New Label()
        passwordTextBoxRegister = New MaskedTextBox()
        usernameTextBoxRegister = New TextBox()
        Label3 = New Label()
        confirmPasswordRegister = New MaskedTextBox()
        enterRegisterButton = New Button()
        SuspendLayout()
        ' 
        ' accountIDLabel
        ' 
        accountIDLabel.AutoSize = True
        accountIDLabel.Location = New Point(100, 66)
        accountIDLabel.Name = "accountIDLabel"
        accountIDLabel.Size = New Size(82, 20)
        accountIDLabel.TabIndex = 18
        accountIDLabel.Text = "Account ID"
        ' 
        ' accountIDTextBoxRegister
        ' 
        accountIDTextBoxRegister.Location = New Point(100, 89)
        accountIDTextBoxRegister.Name = "accountIDTextBoxRegister"
        accountIDTextBoxRegister.Size = New Size(177, 27)
        accountIDTextBoxRegister.TabIndex = 17
        ' 
        ' accountTypeRegister
        ' 
        accountTypeRegister.DropDownStyle = ComboBoxStyle.DropDownList
        accountTypeRegister.FormattingEnabled = True
        accountTypeRegister.Items.AddRange(New Object() {"Student", "Professor", "Admin"})
        accountTypeRegister.Location = New Point(101, 309)
        accountTypeRegister.Name = "accountTypeRegister"
        accountTypeRegister.Size = New Size(176, 28)
        accountTypeRegister.TabIndex = 16
        ' 
        ' accountType
        ' 
        accountType.AutoSize = True
        accountType.Location = New Point(100, 286)
        accountType.Name = "accountType"
        accountType.Size = New Size(98, 20)
        accountType.TabIndex = 15
        accountType.Text = "Account Type"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 20)
        Label2.TabIndex = 14
        Label2.Text = "New Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 13
        Label1.Text = "New Username"
        ' 
        ' passwordTextBoxRegister
        ' 
        passwordTextBoxRegister.Location = New Point(100, 198)
        passwordTextBoxRegister.Name = "passwordTextBoxRegister"
        passwordTextBoxRegister.Size = New Size(177, 27)
        passwordTextBoxRegister.TabIndex = 12
        passwordTextBoxRegister.UseSystemPasswordChar = True
        ' 
        ' usernameTextBoxRegister
        ' 
        usernameTextBoxRegister.Location = New Point(100, 142)
        usernameTextBoxRegister.Name = "usernameTextBoxRegister"
        usernameTextBoxRegister.Size = New Size(177, 27)
        usernameTextBoxRegister.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(100, 231)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 20)
        Label3.TabIndex = 20
        Label3.Text = "Confirm Password"
        ' 
        ' confirmPasswordRegister
        ' 
        confirmPasswordRegister.Location = New Point(100, 254)
        confirmPasswordRegister.Name = "confirmPasswordRegister"
        confirmPasswordRegister.Size = New Size(177, 27)
        confirmPasswordRegister.TabIndex = 19
        confirmPasswordRegister.UseSystemPasswordChar = True
        ' 
        ' enterRegisterButton
        ' 
        enterRegisterButton.Location = New Point(133, 354)
        enterRegisterButton.Name = "enterRegisterButton"
        enterRegisterButton.Size = New Size(94, 29)
        enterRegisterButton.TabIndex = 21
        enterRegisterButton.Text = "Register"
        enterRegisterButton.UseVisualStyleBackColor = True
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(412, 450)
        Controls.Add(enterRegisterButton)
        Controls.Add(Label3)
        Controls.Add(confirmPasswordRegister)
        Controls.Add(accountIDLabel)
        Controls.Add(accountIDTextBoxRegister)
        Controls.Add(accountTypeRegister)
        Controls.Add(accountType)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(passwordTextBoxRegister)
        Controls.Add(usernameTextBoxRegister)
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents accountIDLabel As Label
    Friend WithEvents accountIDTextBoxRegister As TextBox
    Friend WithEvents accountTypeRegister As ComboBox
    Friend WithEvents accountType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordTextBoxRegister As MaskedTextBox
    Friend WithEvents usernameTextBoxRegister As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents confirmPasswordRegister As MaskedTextBox
    Friend WithEvents enterRegisterButton As Button
End Class
