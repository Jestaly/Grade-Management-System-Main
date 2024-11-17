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
        usernameTextBox = New TextBox()
        passwordTextBox = New MaskedTextBox()
        Label1 = New Label()
        Label2 = New Label()
        forgotPassword = New LinkLabel()
        loginButton = New Button()
        accountType = New Label()
        ComboBox1 = New ComboBox()
        accountID = New Label()
        TextBox1 = New TextBox()
        registerButton = New Button()
        SuspendLayout()
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(112, 155)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(177, 27)
        usernameTextBox.TabIndex = 0
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(112, 266)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(177, 27)
        passwordTextBox.TabIndex = 1
        passwordTextBox.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(112, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(112, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.Location = New Point(171, 296)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(118, 20)
        forgotPassword.TabIndex = 4
        forgotPassword.TabStop = True
        forgotPassword.Text = "Forgot Password"
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
        ' accountType
        ' 
        accountType.AutoSize = True
        accountType.Location = New Point(112, 185)
        accountType.Name = "accountType"
        accountType.Size = New Size(98, 20)
        accountType.TabIndex = 7
        accountType.Text = "Account Type"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Student", "Professor", "Admin"})
        ComboBox1.Location = New Point(113, 208)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(176, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' accountID
        ' 
        accountID.AutoSize = True
        accountID.Location = New Point(112, 79)
        accountID.Name = "accountID"
        accountID.Size = New Size(82, 20)
        accountID.TabIndex = 10
        accountID.Text = "Account ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(112, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(177, 27)
        TextBox1.TabIndex = 9
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
        Controls.Add(accountID)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(accountType)
        Controls.Add(loginButton)
        Controls.Add(forgotPassword)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameTextBox)
        Name = "loginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents forgotPassword As LinkLabel
    Friend WithEvents loginButton As Button
    Friend WithEvents accountType As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents accountID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents registerButton As Button

End Class
