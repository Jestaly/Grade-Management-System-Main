<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentLogin
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
        forgotPassword = New LinkLabel()
        loginButton = New Button()
        usernameLabel = New Label()
        passwordLabel = New Label()
        loginLabel = New Label()
        passwordTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(125, 139)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(192, 27)
        usernameTextBox.TabIndex = 0
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.Location = New Point(125, 242)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(125, 20)
        forgotPassword.TabIndex = 2
        forgotPassword.TabStop = True
        forgotPassword.Text = "Forgot Password?"
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(164, 282)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(94, 29)
        loginButton.TabIndex = 3
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(125, 116)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(75, 20)
        usernameLabel.TabIndex = 4
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(125, 189)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 5
        passwordLabel.Text = "Password"
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginLabel.Location = New Point(104, 40)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(229, 46)
        loginLabel.TabIndex = 6
        loginLabel.Text = "Student Login"
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(125, 212)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(192, 27)
        passwordTextBox.TabIndex = 7
        passwordTextBox.UseSystemPasswordChar = True
        ' 
        ' studentLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(469, 450)
        Controls.Add(passwordTextBox)
        Controls.Add(loginLabel)
        Controls.Add(passwordLabel)
        Controls.Add(usernameLabel)
        Controls.Add(loginButton)
        Controls.Add(forgotPassword)
        Controls.Add(usernameTextBox)
        Name = "studentLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents forgotPassword As LinkLabel
    Friend WithEvents loginButton As Button
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents loginLabel As Label
    Friend WithEvents passwordTextBox As TextBox

End Class
