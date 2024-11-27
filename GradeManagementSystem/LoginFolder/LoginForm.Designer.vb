<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        passwordLogin = New MaskedTextBox()
        passwordLabel = New Label()
        forgotPasswordLogin = New LinkLabel()
        loginButton = New Button()
        accountIDLabel = New Label()
        dataView = New DataGridView()
        accountIDLogin = New MaskedTextBox()
        registerAdmin = New LinkLabel()
        Label1 = New Label()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' passwordLogin
        ' 
        passwordLogin.Location = New Point(112, 183)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.Size = New Size(177, 27)
        passwordLogin.TabIndex = 1
        passwordLogin.UseSystemPasswordChar = True
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(112, 160)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 3
        passwordLabel.Text = "Password"
        ' 
        ' forgotPasswordLogin
        ' 
        forgotPasswordLogin.AutoSize = True
        forgotPasswordLogin.LinkColor = Color.Gray
        forgotPasswordLogin.Location = New Point(171, 213)
        forgotPasswordLogin.Name = "forgotPasswordLogin"
        forgotPasswordLogin.Size = New Size(118, 20)
        forgotPasswordLogin.TabIndex = 4
        forgotPasswordLogin.TabStop = True
        forgotPasswordLogin.Text = "Forgot Password"
        ' 
        ' loginButton
        ' 
        loginButton.Location = New Point(156, 263)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(82, 29)
        loginButton.TabIndex = 5
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' accountIDLabel
        ' 
        accountIDLabel.AutoSize = True
        accountIDLabel.Location = New Point(112, 102)
        accountIDLabel.Name = "accountIDLabel"
        accountIDLabel.Size = New Size(82, 20)
        accountIDLabel.TabIndex = 10
        accountIDLabel.Text = "Account ID"
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(408, 442)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(10, 10)
        dataView.TabIndex = 12
        dataView.Visible = False
        ' 
        ' accountIDLogin
        ' 
        accountIDLogin.Location = New Point(113, 125)
        accountIDLogin.Mask = "0-00-00000"
        accountIDLogin.Name = "accountIDLogin"
        accountIDLogin.PromptChar = "X"c
        accountIDLogin.Size = New Size(176, 27)
        accountIDLogin.TabIndex = 13
        ' 
        ' registerAdmin
        ' 
        registerAdmin.AutoSize = True
        registerAdmin.Location = New Point(112, 340)
        registerAdmin.Name = "registerAdmin"
        registerAdmin.Size = New Size(172, 20)
        registerAdmin.TabIndex = 14
        registerAdmin.TabStop = True
        registerAdmin.Text = "Sign up as Administrator"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(181, 307)
        Label1.Name = "Label1"
        Label1.Size = New Size(23, 20)
        Label1.TabIndex = 15
        Label1.Text = "or"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 450)
        Controls.Add(Label1)
        Controls.Add(registerAdmin)
        Controls.Add(accountIDLogin)
        Controls.Add(dataView)
        Controls.Add(accountIDLabel)
        Controls.Add(loginButton)
        Controls.Add(forgotPasswordLogin)
        Controls.Add(passwordLabel)
        Controls.Add(passwordLogin)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents passwordLogin As MaskedTextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents forgotPasswordLogin As LinkLabel
    Friend WithEvents loginButton As Button
    Friend WithEvents accountIDLabel As Label
    Friend WithEvents dataView As DataGridView
    Friend WithEvents accountIDLogin As MaskedTextBox
    Friend WithEvents registerAdmin As LinkLabel
    Friend WithEvents Label1 As Label

End Class
