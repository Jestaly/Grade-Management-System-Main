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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        passwordLogin = New MaskedTextBox()
        dataView = New DataGridView()
        accountIDLogin = New MaskedTextBox()
        registerAdmin = New LinkLabel()
        PictureBox9 = New PictureBox()
        forgotpasscodeportal = New Label()
        exitbttn = New PictureBox()
        PictureBox1 = New PictureBox()
        enterbttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(exitbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(enterbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' passwordLogin
        ' 
        passwordLogin.Font = New Font("Tahoma", 11F)
        passwordLogin.ForeColor = Color.DarkGreen
        passwordLogin.Location = New Point(148, 319)
        passwordLogin.Margin = New Padding(4)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.Size = New Size(230, 34)
        passwordLogin.TabIndex = 1
        passwordLogin.TextAlign = HorizontalAlignment.Center
        passwordLogin.UseSystemPasswordChar = True
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(510, 552)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(12, 12)
        dataView.TabIndex = 12
        dataView.Visible = False
        ' 
        ' accountIDLogin
        ' 
        accountIDLogin.BackColor = Color.White
        accountIDLogin.Font = New Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        accountIDLogin.ForeColor = Color.DarkGreen
        accountIDLogin.Location = New Point(148, 257)
        accountIDLogin.Margin = New Padding(4)
        accountIDLogin.Mask = "0-00-00000"
        accountIDLogin.Name = "accountIDLogin"
        accountIDLogin.PromptChar = "X"c
        accountIDLogin.Size = New Size(230, 34)
        accountIDLogin.TabIndex = 13
        accountIDLogin.TextAlign = HorizontalAlignment.Center
        ' 
        ' registerAdmin
        ' 
        registerAdmin.AutoSize = True
        registerAdmin.Location = New Point(161, 485)
        registerAdmin.Margin = New Padding(4, 0, 4, 0)
        registerAdmin.Name = "registerAdmin"
        registerAdmin.Size = New Size(209, 25)
        registerAdmin.TabIndex = 14
        registerAdmin.TabStop = True
        registerAdmin.Text = "Sign up as Administrator"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.ImageLocation = ""
        PictureBox9.Location = New Point(181, 48)
        PictureBox9.Margin = New Padding(4)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(174, 173)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 45
        PictureBox9.TabStop = False
        ' 
        ' forgotpasscodeportal
        ' 
        forgotpasscodeportal.AutoSize = True
        forgotpasscodeportal.BackColor = Color.Transparent
        forgotpasscodeportal.Font = New Font("Calibri", 12F, FontStyle.Bold Or FontStyle.Underline)
        forgotpasscodeportal.ForeColor = Color.White
        forgotpasscodeportal.Location = New Point(165, 560)
        forgotpasscodeportal.Name = "forgotpasscodeportal"
        forgotpasscodeportal.Size = New Size(205, 29)
        forgotpasscodeportal.TabIndex = 0
        forgotpasscodeportal.Text = "FORGOT PASSCODE"
        ' 
        ' exitbttn
        ' 
        exitbttn.BackColor = Color.Transparent
        exitbttn.BackgroundImage = CType(resources.GetObject("exitbttn.BackgroundImage"), Image)
        exitbttn.BackgroundImageLayout = ImageLayout.Zoom
        exitbttn.ImageLocation = ""
        exitbttn.Location = New Point(482, 13)
        exitbttn.Margin = New Padding(4)
        exitbttn.Name = "exitbttn"
        exitbttn.Size = New Size(41, 46)
        exitbttn.SizeMode = PictureBoxSizeMode.Zoom
        exitbttn.TabIndex = 47
        exitbttn.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(-3, 560)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(540, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 48
        PictureBox1.TabStop = False
        ' 
        ' enterbttn
        ' 
        enterbttn.BackColor = Color.Transparent
        enterbttn.BackgroundImage = CType(resources.GetObject("enterbttn.BackgroundImage"), Image)
        enterbttn.BackgroundImageLayout = ImageLayout.Stretch
        enterbttn.ImageLocation = ""
        enterbttn.Location = New Point(161, 361)
        enterbttn.Margin = New Padding(4)
        enterbttn.Name = "enterbttn"
        enterbttn.Size = New Size(217, 114)
        enterbttn.SizeMode = PictureBoxSizeMode.Zoom
        enterbttn.TabIndex = 49
        enterbttn.TabStop = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(536, 619)
        Controls.Add(enterbttn)
        Controls.Add(forgotpasscodeportal)
        Controls.Add(PictureBox1)
        Controls.Add(exitbttn)
        Controls.Add(PictureBox9)
        Controls.Add(registerAdmin)
        Controls.Add(accountIDLogin)
        Controls.Add(dataView)
        Controls.Add(passwordLogin)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(exitbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(enterbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents passwordLogin As MaskedTextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents accountIDLogin As MaskedTextBox
    Friend WithEvents registerAdmin As LinkLabel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents forgotpasscodeportal As Label
    Friend WithEvents exitbttn As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enterbttn As PictureBox

End Class
