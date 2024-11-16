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
        SuspendLayout()
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(103, 111)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.Size = New Size(177, 27)
        usernameTextBox.TabIndex = 0
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(103, 181)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.Size = New Size(177, 27)
        passwordTextBox.TabIndex = 1
        passwordTextBox.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(103, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 2
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(103, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' forgotPassword
        ' 
        forgotPassword.AutoSize = True
        forgotPassword.Location = New Point(162, 211)
        forgotPassword.Name = "forgotPassword"
        forgotPassword.Size = New Size(118, 20)
        forgotPassword.TabIndex = 4
        forgotPassword.TabStop = True
        forgotPassword.Text = "Forgot Password"
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(131, 256)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(94, 29)
        loginButton.TabIndex = 5
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 450)
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

End Class
