<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        usernameLogin = New TextBox()
        passwordLogin = New MaskedTextBox()
        usrnameLabel = New Label()
        passwordLabel = New Label()
        forgotPasswordLogin = New LinkLabel()
        loginButton = New Button()
        accountTypeLabel = New Label()
        accountTypeLogin = New ComboBox()
        accountIDLabel = New Label()
        accountIDLogin = New TextBox()
        registerButton = New Button()
        SuspendLayout()
        ' 
        ' usernameLogin
        ' 
        usernameLogin.Location = New Point(112, 155)
        usernameLogin.Name = "usernameLogin"
        usernameLogin.Size = New Size(177, 27)
        usernameLogin.TabIndex = 0
        ' 
        ' passwordLogin
        ' 
        passwordLogin.Location = New Point(112, 266)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.Size = New Size(177, 27)
        passwordLogin.TabIndex = 1
        passwordLogin.UseSystemPasswordChar = True
        ' 
        ' usrnameLabel
        ' 
        usrnameLabel.AutoSize = True
        usrnameLabel.Location = New Point(112, 132)
        usrnameLabel.Name = "usrnameLabel"
        usrnameLabel.Size = New Size(75, 20)
        usrnameLabel.TabIndex = 2
        usrnameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(112, 243)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 3
        passwordLabel.Text = "Password"
        ' 
        ' forgotPasswordLogin
        ' 
        forgotPasswordLogin.AutoSize = True
        forgotPasswordLogin.Location = New Point(171, 296)
        forgotPasswordLogin.Name = "forgotPasswordLogin"
        forgotPasswordLogin.Size = New Size(118, 20)
        forgotPasswordLogin.TabIndex = 4
        forgotPasswordLogin.TabStop = True
        forgotPasswordLogin.Text = "Forgot Password"
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(113, 345)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(82, 29)
        loginButton.TabIndex = 5
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' accountTypeLabel
        ' 
        accountTypeLabel.AutoSize = True
        accountTypeLabel.Location = New Point(112, 185)
        accountTypeLabel.Name = "accountTypeLabel"
        accountTypeLabel.Size = New Size(98, 20)
        accountTypeLabel.TabIndex = 7
        accountTypeLabel.Text = "Account Type"
        ' 
        ' accountTypeLogin
        ' 
        accountTypeLogin.DropDownStyle = ComboBoxStyle.DropDownList
        accountTypeLogin.FormattingEnabled = True
        accountTypeLogin.Items.AddRange(New Object() {"Student", "Professor", "Admin"})
        accountTypeLogin.Location = New Point(113, 208)
        accountTypeLogin.Name = "accountTypeLogin"
        accountTypeLogin.Size = New Size(176, 28)
        accountTypeLogin.TabIndex = 8
        ' 
        ' accountIDLabel
        ' 
        accountIDLabel.AutoSize = True
        accountIDLabel.Location = New Point(112, 79)
        accountIDLabel.Name = "accountIDLabel"
        accountIDLabel.Size = New Size(82, 20)
        accountIDLabel.TabIndex = 10
        accountIDLabel.Text = "Account ID"
        ' 
        ' accountIDLogin
        ' 
        accountIDLogin.Location = New Point(112, 102)
        accountIDLogin.Name = "accountIDLogin"
        accountIDLogin.Size = New Size(177, 27)
        accountIDLogin.TabIndex = 9
        ' 
        ' registerButton
        ' 
        registerButton.Location = New Point(211, 345)
        registerButton.Name = "registerButton"
        registerButton.Size = New Size(78, 29)
        registerButton.TabIndex = 11
        registerButton.Text = "Register"
        registerButton.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 450)
        Controls.Add(registerButton)
        Controls.Add(accountIDLabel)
        Controls.Add(accountIDLogin)
        Controls.Add(accountTypeLogin)
        Controls.Add(accountTypeLabel)
        Controls.Add(loginButton)
        Controls.Add(forgotPasswordLogin)
        Controls.Add(passwordLabel)
        Controls.Add(usrnameLabel)
        Controls.Add(passwordLogin)
        Controls.Add(usernameLogin)
        Name = "loginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameLogin As TextBox
    Friend WithEvents passwordLogin As MaskedTextBox
    Friend WithEvents usrnameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents forgotPasswordLogin As LinkLabel
    Friend WithEvents loginButton As Button
    Friend WithEvents accountTypeLabel As Label
    Friend WithEvents accountTypeLogin As ComboBox
    Friend WithEvents accountIDLabel As Label
    Friend WithEvents accountIDLogin As TextBox
    Friend WithEvents registerButton As Button

End Class
