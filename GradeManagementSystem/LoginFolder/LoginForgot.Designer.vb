<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForgot
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
        p_login = New Panel()
        enterbttn = New Button()
        Gerald3 = New gerald.Gerald()
        PictureBox3 = New PictureBox()
        accountIDLogin = New MaskedTextBox()
        PictureBox2 = New PictureBox()
        Gerald2 = New gerald.Gerald()
        PictureBox1 = New PictureBox()
        passwordLogin = New TextBox()
        Gerald1 = New gerald.Gerald()
        lbl_invalid = New Label()
        p_base = New Panel()
        p_changepass = New Panel()
        btn_eye = New PictureBox()
        txtb_confirmpassword = New TextBox()
        Gerald12 = New gerald.Gerald()
        txtb_newpassword = New TextBox()
        PictureBox4 = New PictureBox()
        Gerald4 = New gerald.Gerald()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Gerald17 = New gerald.Gerald()
        p_verification = New Panel()
        btn_back = New PictureBox()
        txtb_c6 = New TextBox()
        Gerald11 = New gerald.Gerald()
        txtb_c5 = New TextBox()
        Gerald10 = New gerald.Gerald()
        txtb_c4 = New TextBox()
        Gerald7 = New gerald.Gerald()
        txtb_c3 = New TextBox()
        Gerald6 = New gerald.Gerald()
        txtb_c2 = New TextBox()
        Gerald5 = New gerald.Gerald()
        txtb_c1 = New TextBox()
        lbl_verification = New Label()
        lbl_codesent = New Label()
        bg_code = New gerald.Gerald()
        btn_verify = New Button()
        btnbg_verify = New gerald.Gerald()
        lbl_besure = New Label()
        lbl_ready = New Label()
        p_forgotpass = New Panel()
        lbl_resetpass = New Label()
        lbl_emailme = New Label()
        TextBox2 = New TextBox()
        btn_reset = New Button()
        Gerald8 = New gerald.Gerald()
        PictureBox8 = New PictureBox()
        Gerald9 = New gerald.Gerald()
        lbl_fpass = New Label()
        lbl_login = New Label()
        lbl_welcome = New Label()
        btn_forgotpass = New Button()
        btnbg_forgotpass = New gerald.Gerald()
        bg_fpass = New gerald.Gerald()
        btn_signin = New Button()
        btnbg_signin = New gerald.Gerald()
        bg_signin = New gerald.Gerald()
        p_login.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        p_base.SuspendLayout()
        p_changepass.SuspendLayout()
        CType(btn_eye, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        p_verification.SuspendLayout()
        CType(btn_back, ComponentModel.ISupportInitialize).BeginInit()
        p_forgotpass.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' p_login
        ' 
        p_login.BackColor = Color.White
        p_login.CausesValidation = False
        p_login.Controls.Add(enterbttn)
        p_login.Controls.Add(Gerald3)
        p_login.Controls.Add(PictureBox3)
        p_login.Controls.Add(accountIDLogin)
        p_login.Controls.Add(PictureBox2)
        p_login.Controls.Add(Gerald2)
        p_login.Controls.Add(PictureBox1)
        p_login.Controls.Add(passwordLogin)
        p_login.Controls.Add(Gerald1)
        p_login.Controls.Add(lbl_invalid)
        p_login.Location = New Point(0, 0)
        p_login.Name = "p_login"
        p_login.Size = New Size(350, 600)
        p_login.TabIndex = 0
        ' 
        ' enterbttn
        ' 
        enterbttn.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        enterbttn.BackgroundImageLayout = ImageLayout.None
        enterbttn.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        enterbttn.FlatStyle = FlatStyle.Flat
        enterbttn.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        enterbttn.ForeColor = Color.White
        enterbttn.Location = New Point(88, 435)
        enterbttn.Name = "enterbttn"
        enterbttn.Size = New Size(176, 30)
        enterbttn.TabIndex = 0
        enterbttn.Text = "LOG IN"
        enterbttn.UseVisualStyleBackColor = False
        ' 
        ' Gerald3
        ' 
        Gerald3.BackColor = Color.White
        Gerald3.BorderRadius = 40
        Gerald3.ForeColor = Color.Black
        Gerald3.GradientAngle = 90.0F
        Gerald3.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald3.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald3.Location = New Point(75, 430)
        Gerald3.Name = "Gerald3"
        Gerald3.Size = New Size(200, 40)
        Gerald3.TabIndex = 6
        Gerald3.Text = "Gerald3"
        Gerald3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.PLP_LOGO
        PictureBox3.Location = New Point(138, 111)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(76, 76)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' accountIDLogin
        ' 
        accountIDLogin.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        accountIDLogin.BorderStyle = BorderStyle.None
        accountIDLogin.Font = New Font("Segoe UI", 9.0F)
        accountIDLogin.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        accountIDLogin.Location = New Point(84, 250)
        accountIDLogin.Mask = "0-00-00000"
        accountIDLogin.Name = "accountIDLogin"
        accountIDLogin.Size = New Size(211, 20)
        accountIDLogin.TabIndex = 5
        accountIDLogin.Text = "00000000"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.icon_id
        PictureBox2.Location = New Point(51, 252)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(17, 17)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Gerald2
        ' 
        Gerald2.BackColor = Color.White
        Gerald2.BorderRadius = 20
        Gerald2.ForeColor = Color.Black
        Gerald2.GradientAngle = 90.0F
        Gerald2.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald2.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald2.Location = New Point(35, 240)
        Gerald2.Name = "Gerald2"
        Gerald2.Size = New Size(280, 40)
        Gerald2.TabIndex = 4
        Gerald2.Text = "Gerald2"
        Gerald2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icon_lock
        PictureBox1.Location = New Point(51, 312)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(17, 17)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' passwordLogin
        ' 
        passwordLogin.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        passwordLogin.BorderStyle = BorderStyle.None
        passwordLogin.Font = New Font("Segoe UI", 9.0F)
        passwordLogin.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        passwordLogin.Location = New Point(84, 310)
        passwordLogin.Name = "passwordLogin"
        passwordLogin.PlaceholderText = "Password"
        passwordLogin.Size = New Size(211, 20)
        passwordLogin.TabIndex = 0
        ' 
        ' Gerald1
        ' 
        Gerald1.BackColor = Color.White
        Gerald1.BorderRadius = 20
        Gerald1.ForeColor = Color.Black
        Gerald1.GradientAngle = 90.0F
        Gerald1.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald1.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald1.Location = New Point(35, 300)
        Gerald1.Name = "Gerald1"
        Gerald1.Size = New Size(280, 40)
        Gerald1.TabIndex = 1
        Gerald1.Text = "Gerald1"
        Gerald1.UseVisualStyleBackColor = False
        ' 
        ' lbl_invalid
        ' 
        lbl_invalid.AutoSize = True
        lbl_invalid.Font = New Font("Microsoft Sans Serif", 8.25F)
        lbl_invalid.ForeColor = Color.FromArgb(CByte(202), CByte(48), CByte(48))
        lbl_invalid.Location = New Point(35, 348)
        lbl_invalid.Name = "lbl_invalid"
        lbl_invalid.Size = New Size(151, 17)
        lbl_invalid.TabIndex = 0
        lbl_invalid.Text = "Invalid ID or Password."
        lbl_invalid.Visible = False
        ' 
        ' p_base
        ' 
        p_base.BackgroundImage = My.Resources.Resources.PLPBG
        p_base.BackgroundImageLayout = ImageLayout.Center
        p_base.CausesValidation = False
        p_base.Controls.Add(p_changepass)
        p_base.Controls.Add(p_verification)
        p_base.Controls.Add(p_login)
        p_base.Controls.Add(lbl_besure)
        p_base.Controls.Add(lbl_ready)
        p_base.Controls.Add(p_forgotpass)
        p_base.Controls.Add(lbl_fpass)
        p_base.Controls.Add(lbl_login)
        p_base.Controls.Add(lbl_welcome)
        p_base.Controls.Add(btn_forgotpass)
        p_base.Controls.Add(btnbg_forgotpass)
        p_base.Controls.Add(bg_fpass)
        p_base.Controls.Add(btn_signin)
        p_base.Controls.Add(btnbg_signin)
        p_base.Controls.Add(bg_signin)
        p_base.Location = New Point(0, 0)
        p_base.Name = "p_base"
        p_base.Size = New Size(800, 600)
        p_base.TabIndex = 1
        ' 
        ' p_changepass
        ' 
        p_changepass.BackColor = Color.White
        p_changepass.CausesValidation = False
        p_changepass.Controls.Add(btn_eye)
        p_changepass.Controls.Add(txtb_confirmpassword)
        p_changepass.Controls.Add(Gerald12)
        p_changepass.Controls.Add(txtb_newpassword)
        p_changepass.Controls.Add(PictureBox4)
        p_changepass.Controls.Add(Gerald4)
        p_changepass.Controls.Add(Label1)
        p_changepass.Controls.Add(Label2)
        p_changepass.Controls.Add(Button1)
        p_changepass.Controls.Add(Gerald17)
        p_changepass.Location = New Point(800, 0)
        p_changepass.Name = "p_changepass"
        p_changepass.Size = New Size(350, 600)
        p_changepass.TabIndex = 18
        ' 
        ' btn_eye
        ' 
        btn_eye.Image = My.Resources.Resources.icon_eye
        btn_eye.Location = New Point(50, 297)
        btn_eye.Name = "btn_eye"
        btn_eye.Size = New Size(20, 20)
        btn_eye.SizeMode = PictureBoxSizeMode.Zoom
        btn_eye.TabIndex = 23
        btn_eye.TabStop = False
        ' 
        ' txtb_confirmpassword
        ' 
        txtb_confirmpassword.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_confirmpassword.BorderStyle = BorderStyle.None
        txtb_confirmpassword.Font = New Font("Segoe UI", 9.0F)
        txtb_confirmpassword.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_confirmpassword.Location = New Point(84, 354)
        txtb_confirmpassword.Name = "txtb_confirmpassword"
        txtb_confirmpassword.PlaceholderText = "Confirm Password"
        txtb_confirmpassword.Size = New Size(211, 20)
        txtb_confirmpassword.TabIndex = 21
        ' 
        ' Gerald12
        ' 
        Gerald12.BackColor = Color.White
        Gerald12.BorderRadius = 20
        Gerald12.ForeColor = Color.Black
        Gerald12.GradientAngle = 90.0F
        Gerald12.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald12.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald12.Location = New Point(35, 344)
        Gerald12.Name = "Gerald12"
        Gerald12.Size = New Size(280, 40)
        Gerald12.TabIndex = 22
        Gerald12.Text = "Gerald12"
        Gerald12.UseVisualStyleBackColor = False
        ' 
        ' txtb_newpassword
        ' 
        txtb_newpassword.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_newpassword.BorderStyle = BorderStyle.None
        txtb_newpassword.Font = New Font("Segoe UI", 9.0F)
        txtb_newpassword.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_newpassword.Location = New Point(84, 297)
        txtb_newpassword.Name = "txtb_newpassword"
        txtb_newpassword.PlaceholderText = "New Password"
        txtb_newpassword.Size = New Size(211, 20)
        txtb_newpassword.TabIndex = 7
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.icon_leftarrow
        PictureBox4.Location = New Point(20, 20)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(24, 24)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' Gerald4
        ' 
        Gerald4.BackColor = Color.White
        Gerald4.BorderRadius = 20
        Gerald4.ForeColor = Color.Black
        Gerald4.GradientAngle = 90.0F
        Gerald4.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald4.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald4.Location = New Point(35, 287)
        Gerald4.Name = "Gerald4"
        Gerald4.Size = New Size(280, 40)
        Gerald4.TabIndex = 8
        Gerald4.Text = "Gerald4"
        Gerald4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        Label1.Location = New Point(23, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(305, 35)
        Label1.TabIndex = 8
        Label1.Text = "RESET YOUR PASSWORD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        Label2.Location = New Point(30, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(290, 51)
        Label2.TabIndex = 7
        Label2.Text = "You have successfully verified yourself." & vbCrLf & "Please fill out the following to reset and create" & vbCrLf & "a new password."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Enabled = False
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(84, 437)
        Button1.Name = "Button1"
        Button1.Size = New Size(176, 30)
        Button1.TabIndex = 0
        Button1.Text = "CONFIRM"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Gerald17
        ' 
        Gerald17.BackColor = Color.White
        Gerald17.BorderRadius = 40
        Gerald17.Enabled = False
        Gerald17.ForeColor = Color.Black
        Gerald17.GradientAngle = 90.0F
        Gerald17.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald17.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald17.Location = New Point(71, 432)
        Gerald17.Name = "Gerald17"
        Gerald17.Size = New Size(200, 40)
        Gerald17.TabIndex = 6
        Gerald17.Text = "Gerald3"
        Gerald17.UseVisualStyleBackColor = False
        ' 
        ' p_verification
        ' 
        p_verification.BackColor = Color.White
        p_verification.CausesValidation = False
        p_verification.Controls.Add(btn_back)
        p_verification.Controls.Add(txtb_c6)
        p_verification.Controls.Add(Gerald11)
        p_verification.Controls.Add(txtb_c5)
        p_verification.Controls.Add(Gerald10)
        p_verification.Controls.Add(txtb_c4)
        p_verification.Controls.Add(Gerald7)
        p_verification.Controls.Add(txtb_c3)
        p_verification.Controls.Add(Gerald6)
        p_verification.Controls.Add(txtb_c2)
        p_verification.Controls.Add(Gerald5)
        p_verification.Controls.Add(txtb_c1)
        p_verification.Controls.Add(lbl_verification)
        p_verification.Controls.Add(lbl_codesent)
        p_verification.Controls.Add(bg_code)
        p_verification.Controls.Add(btn_verify)
        p_verification.Controls.Add(btnbg_verify)
        p_verification.Location = New Point(800, 0)
        p_verification.Name = "p_verification"
        p_verification.Size = New Size(350, 600)
        p_verification.TabIndex = 10
        ' 
        ' btn_back
        ' 
        btn_back.Image = My.Resources.Resources.icon_leftarrow
        btn_back.Location = New Point(20, 20)
        btn_back.Name = "btn_back"
        btn_back.Size = New Size(24, 24)
        btn_back.SizeMode = PictureBoxSizeMode.Zoom
        btn_back.TabIndex = 20
        btn_back.TabStop = False
        ' 
        ' txtb_c6
        ' 
        txtb_c6.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c6.BorderStyle = BorderStyle.None
        txtb_c6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c6.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c6.Location = New Point(280, 312)
        txtb_c6.MaxLength = 1
        txtb_c6.Name = "txtb_c6"
        txtb_c6.Size = New Size(40, 23)
        txtb_c6.TabIndex = 19
        txtb_c6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald11
        ' 
        Gerald11.BackColor = Color.White
        Gerald11.BorderRadius = 20
        Gerald11.ForeColor = Color.Black
        Gerald11.GradientAngle = 90.0F
        Gerald11.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald11.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald11.Location = New Point(280, 300)
        Gerald11.Name = "Gerald11"
        Gerald11.Size = New Size(40, 45)
        Gerald11.TabIndex = 18
        Gerald11.Text = "Gerald2"
        Gerald11.UseVisualStyleBackColor = False
        ' 
        ' txtb_c5
        ' 
        txtb_c5.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c5.BorderStyle = BorderStyle.None
        txtb_c5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c5.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c5.Location = New Point(230, 312)
        txtb_c5.MaxLength = 1
        txtb_c5.Name = "txtb_c5"
        txtb_c5.Size = New Size(40, 23)
        txtb_c5.TabIndex = 17
        txtb_c5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald10
        ' 
        Gerald10.BackColor = Color.White
        Gerald10.BorderRadius = 20
        Gerald10.ForeColor = Color.Black
        Gerald10.GradientAngle = 90.0F
        Gerald10.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald10.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald10.Location = New Point(230, 300)
        Gerald10.Name = "Gerald10"
        Gerald10.Size = New Size(40, 45)
        Gerald10.TabIndex = 16
        Gerald10.Text = "Gerald2"
        Gerald10.UseVisualStyleBackColor = False
        ' 
        ' txtb_c4
        ' 
        txtb_c4.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c4.BorderStyle = BorderStyle.None
        txtb_c4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c4.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c4.Location = New Point(180, 312)
        txtb_c4.MaxLength = 1
        txtb_c4.Name = "txtb_c4"
        txtb_c4.Size = New Size(40, 23)
        txtb_c4.TabIndex = 15
        txtb_c4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald7
        ' 
        Gerald7.BackColor = Color.White
        Gerald7.BorderRadius = 20
        Gerald7.ForeColor = Color.Black
        Gerald7.GradientAngle = 90.0F
        Gerald7.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald7.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald7.Location = New Point(180, 300)
        Gerald7.Name = "Gerald7"
        Gerald7.Size = New Size(40, 45)
        Gerald7.TabIndex = 14
        Gerald7.Text = "Gerald2"
        Gerald7.UseVisualStyleBackColor = False
        ' 
        ' txtb_c3
        ' 
        txtb_c3.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c3.BorderStyle = BorderStyle.None
        txtb_c3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c3.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c3.Location = New Point(130, 312)
        txtb_c3.MaxLength = 1
        txtb_c3.Name = "txtb_c3"
        txtb_c3.Size = New Size(40, 23)
        txtb_c3.TabIndex = 13
        txtb_c3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald6
        ' 
        Gerald6.BackColor = Color.White
        Gerald6.BorderRadius = 20
        Gerald6.ForeColor = Color.Black
        Gerald6.GradientAngle = 90.0F
        Gerald6.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald6.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald6.Location = New Point(130, 300)
        Gerald6.Name = "Gerald6"
        Gerald6.Size = New Size(40, 45)
        Gerald6.TabIndex = 12
        Gerald6.Text = "Gerald2"
        Gerald6.UseVisualStyleBackColor = False
        ' 
        ' txtb_c2
        ' 
        txtb_c2.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c2.BorderStyle = BorderStyle.None
        txtb_c2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c2.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c2.Location = New Point(80, 312)
        txtb_c2.MaxLength = 1
        txtb_c2.Name = "txtb_c2"
        txtb_c2.Size = New Size(40, 23)
        txtb_c2.TabIndex = 11
        txtb_c2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Gerald5
        ' 
        Gerald5.BackColor = Color.White
        Gerald5.BorderRadius = 20
        Gerald5.ForeColor = Color.Black
        Gerald5.GradientAngle = 90.0F
        Gerald5.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald5.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald5.Location = New Point(80, 300)
        Gerald5.Name = "Gerald5"
        Gerald5.Size = New Size(40, 45)
        Gerald5.TabIndex = 10
        Gerald5.Text = "Gerald2"
        Gerald5.UseVisualStyleBackColor = False
        ' 
        ' txtb_c1
        ' 
        txtb_c1.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        txtb_c1.BorderStyle = BorderStyle.None
        txtb_c1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtb_c1.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        txtb_c1.Location = New Point(30, 312)
        txtb_c1.MaxLength = 1
        txtb_c1.Name = "txtb_c1"
        txtb_c1.Size = New Size(40, 23)
        txtb_c1.TabIndex = 9
        txtb_c1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lbl_verification
        ' 
        lbl_verification.AutoSize = True
        lbl_verification.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_verification.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_verification.Location = New Point(83, 179)
        lbl_verification.Name = "lbl_verification"
        lbl_verification.Size = New Size(184, 35)
        lbl_verification.TabIndex = 8
        lbl_verification.Text = "VERIFICATION"
        ' 
        ' lbl_codesent
        ' 
        lbl_codesent.AutoSize = True
        lbl_codesent.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_codesent.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_codesent.Location = New Point(23, 219)
        lbl_codesent.Name = "lbl_codesent"
        lbl_codesent.Size = New Size(304, 51)
        lbl_codesent.TabIndex = 7
        lbl_codesent.Text = "A code has been sent to the email you provided." & vbCrLf & "Enter it here to verify your identity and reset" & vbCrLf & "your password."
        lbl_codesent.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' bg_code
        ' 
        bg_code.BackColor = Color.White
        bg_code.BorderRadius = 20
        bg_code.ForeColor = Color.Black
        bg_code.GradientAngle = 90.0F
        bg_code.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        bg_code.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        bg_code.Location = New Point(30, 300)
        bg_code.Name = "bg_code"
        bg_code.Size = New Size(40, 45)
        bg_code.TabIndex = 4
        bg_code.Text = "Gerald2"
        bg_code.UseVisualStyleBackColor = False
        ' 
        ' btn_verify
        ' 
        btn_verify.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_verify.BackgroundImageLayout = ImageLayout.None
        btn_verify.Enabled = False
        btn_verify.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_verify.FlatStyle = FlatStyle.Flat
        btn_verify.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_verify.ForeColor = Color.White
        btn_verify.Location = New Point(76, 389)
        btn_verify.Name = "btn_verify"
        btn_verify.Size = New Size(176, 30)
        btn_verify.TabIndex = 0
        btn_verify.Text = "VERIFY"
        btn_verify.UseVisualStyleBackColor = False
        ' 
        ' btnbg_verify
        ' 
        btnbg_verify.BackColor = Color.White
        btnbg_verify.BorderRadius = 40
        btnbg_verify.Enabled = False
        btnbg_verify.ForeColor = Color.Black
        btnbg_verify.GradientAngle = 90.0F
        btnbg_verify.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_verify.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_verify.Location = New Point(63, 384)
        btnbg_verify.Name = "btnbg_verify"
        btnbg_verify.Size = New Size(200, 40)
        btnbg_verify.TabIndex = 6
        btnbg_verify.Text = "Gerald3"
        btnbg_verify.UseVisualStyleBackColor = False
        ' 
        ' lbl_besure
        ' 
        lbl_besure.AutoSize = True
        lbl_besure.BackColor = Color.Transparent
        lbl_besure.Enabled = False
        lbl_besure.Font = New Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_besure.ForeColor = Color.White
        lbl_besure.Location = New Point(44, 238)
        lbl_besure.Name = "lbl_besure"
        lbl_besure.Size = New Size(362, 62)
        lbl_besure.TabIndex = 11
        lbl_besure.Text = "Be sure to properly remember your" & vbCrLf & "login credentials!"
        lbl_besure.TextAlign = ContentAlignment.MiddleCenter
        lbl_besure.Visible = False
        ' 
        ' lbl_ready
        ' 
        lbl_ready.AutoSize = True
        lbl_ready.BackColor = Color.Transparent
        lbl_ready.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_ready.ForeColor = Color.White
        lbl_ready.Location = New Point(55, 178)
        lbl_ready.Name = "lbl_ready"
        lbl_ready.Size = New Size(340, 50)
        lbl_ready.TabIndex = 10
        lbl_ready.Text = "READY TO LOGIN?"
        lbl_ready.Visible = False
        ' 
        ' p_forgotpass
        ' 
        p_forgotpass.BackColor = Color.White
        p_forgotpass.CausesValidation = False
        p_forgotpass.Controls.Add(lbl_resetpass)
        p_forgotpass.Controls.Add(lbl_emailme)
        p_forgotpass.Controls.Add(TextBox2)
        p_forgotpass.Controls.Add(btn_reset)
        p_forgotpass.Controls.Add(Gerald8)
        p_forgotpass.Controls.Add(PictureBox8)
        p_forgotpass.Controls.Add(Gerald9)
        p_forgotpass.Location = New Point(800, 0)
        p_forgotpass.Name = "p_forgotpass"
        p_forgotpass.Size = New Size(350, 600)
        p_forgotpass.TabIndex = 9
        ' 
        ' lbl_resetpass
        ' 
        lbl_resetpass.AutoSize = True
        lbl_resetpass.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_resetpass.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_resetpass.Location = New Point(22, 180)
        lbl_resetpass.Name = "lbl_resetpass"
        lbl_resetpass.Size = New Size(305, 35)
        lbl_resetpass.TabIndex = 8
        lbl_resetpass.Text = "RESET YOUR PASSWORD"
        ' 
        ' lbl_emailme
        ' 
        lbl_emailme.AutoSize = True
        lbl_emailme.Font = New Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_emailme.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        lbl_emailme.Location = New Point(33, 219)
        lbl_emailme.Name = "lbl_emailme"
        lbl_emailme.Size = New Size(283, 34)
        lbl_emailme.TabIndex = 7
        lbl_emailme.Text = "Enter your email address or username and" & vbCrLf & "we’ll send you a code to reset your password"
        lbl_emailme.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Segoe UI", 9.0F)
        TextBox2.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        TextBox2.Location = New Point(76, 309)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Email"
        TextBox2.Size = New Size(211, 20)
        TextBox2.TabIndex = 0
        ' 
        ' btn_reset
        ' 
        btn_reset.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_reset.BackgroundImageLayout = ImageLayout.None
        btn_reset.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_reset.FlatStyle = FlatStyle.Flat
        btn_reset.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_reset.ForeColor = Color.White
        btn_reset.Location = New Point(76, 389)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(176, 30)
        btn_reset.TabIndex = 0
        btn_reset.Text = "RESET PASSWORD"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' Gerald8
        ' 
        Gerald8.BackColor = Color.White
        Gerald8.BorderRadius = 40
        Gerald8.ForeColor = Color.Black
        Gerald8.GradientAngle = 90.0F
        Gerald8.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald8.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        Gerald8.Location = New Point(63, 384)
        Gerald8.Name = "Gerald8"
        Gerald8.Size = New Size(200, 40)
        Gerald8.TabIndex = 6
        Gerald8.Text = "Gerald3"
        Gerald8.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.icon_envelope
        PictureBox8.Location = New Point(42, 310)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(17, 17)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 2
        PictureBox8.TabStop = False
        ' 
        ' Gerald9
        ' 
        Gerald9.BackColor = Color.White
        Gerald9.BorderRadius = 20
        Gerald9.ForeColor = Color.Black
        Gerald9.GradientAngle = 90.0F
        Gerald9.GradientBottomColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald9.GradientTopColor = Color.FromArgb(CByte(244), CByte(248), CByte(247))
        Gerald9.Location = New Point(23, 297)
        Gerald9.Name = "Gerald9"
        Gerald9.Size = New Size(280, 40)
        Gerald9.TabIndex = 4
        Gerald9.Text = "Gerald2"
        Gerald9.UseVisualStyleBackColor = False
        ' 
        ' lbl_fpass
        ' 
        lbl_fpass.AutoSize = True
        lbl_fpass.BackColor = Color.Transparent
        lbl_fpass.Enabled = False
        lbl_fpass.Font = New Font("Segoe UI", 6.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_fpass.ForeColor = Color.White
        lbl_fpass.Location = New Point(509, 386)
        lbl_fpass.Name = "lbl_fpass"
        lbl_fpass.Size = New Size(132, 24)
        lbl_fpass.TabIndex = 8
        lbl_fpass.Text = "FORGOT YOUR PASSWORD?" & vbCrLf & "RESET IT HERE"
        lbl_fpass.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.BackColor = Color.Transparent
        lbl_login.Enabled = False
        lbl_login.Font = New Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_login.ForeColor = Color.White
        lbl_login.Location = New Point(395, 225)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(360, 62)
        lbl_login.TabIndex = 1
        lbl_login.Text = "Log in and access, view, or manage" & vbCrLf & "grades and classes."
        lbl_login.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_welcome
        ' 
        lbl_welcome.AutoSize = True
        lbl_welcome.BackColor = Color.Transparent
        lbl_welcome.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_welcome.ForeColor = Color.White
        lbl_welcome.Location = New Point(440, 165)
        lbl_welcome.Name = "lbl_welcome"
        lbl_welcome.Size = New Size(271, 62)
        lbl_welcome.TabIndex = 0
        lbl_welcome.Text = "WELCOME!"
        ' 
        ' btn_forgotpass
        ' 
        btn_forgotpass.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_forgotpass.BackgroundImageLayout = ImageLayout.None
        btn_forgotpass.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_forgotpass.FlatStyle = FlatStyle.Flat
        btn_forgotpass.Font = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_forgotpass.ForeColor = Color.White
        btn_forgotpass.Location = New Point(486, 348)
        btn_forgotpass.Name = "btn_forgotpass"
        btn_forgotpass.Size = New Size(176, 30)
        btn_forgotpass.TabIndex = 7
        btn_forgotpass.Text = "FORGOT PASSWORD"
        btn_forgotpass.UseVisualStyleBackColor = False
        ' 
        ' btnbg_forgotpass
        ' 
        btnbg_forgotpass.BackColor = Color.White
        btnbg_forgotpass.BorderRadius = 40
        btnbg_forgotpass.ForeColor = Color.Black
        btnbg_forgotpass.GradientAngle = 90.0F
        btnbg_forgotpass.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_forgotpass.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_forgotpass.Location = New Point(475, 345)
        btnbg_forgotpass.Name = "btnbg_forgotpass"
        btnbg_forgotpass.Size = New Size(195, 35)
        btnbg_forgotpass.TabIndex = 7
        btnbg_forgotpass.Text = "Gerald4"
        btnbg_forgotpass.UseVisualStyleBackColor = False
        ' 
        ' bg_fpass
        ' 
        bg_fpass.BackColor = Color.White
        bg_fpass.BorderRadius = 40
        bg_fpass.ForeColor = Color.Black
        bg_fpass.GradientAngle = 90.0F
        bg_fpass.GradientBottomColor = Color.White
        bg_fpass.GradientTopColor = Color.White
        bg_fpass.Location = New Point(473, 343)
        bg_fpass.Name = "bg_fpass"
        bg_fpass.Size = New Size(200, 40)
        bg_fpass.TabIndex = 7
        bg_fpass.Text = "Gerald4"
        bg_fpass.UseVisualStyleBackColor = False
        ' 
        ' btn_signin
        ' 
        btn_signin.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_signin.BackgroundImageLayout = ImageLayout.None
        btn_signin.FlatAppearance.BorderColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btn_signin.FlatStyle = FlatStyle.Flat
        btn_signin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_signin.ForeColor = Color.White
        btn_signin.Location = New Point(136, 353)
        btn_signin.Name = "btn_signin"
        btn_signin.Size = New Size(176, 30)
        btn_signin.TabIndex = 15
        btn_signin.Text = "SIGN IN"
        btn_signin.UseVisualStyleBackColor = False
        btn_signin.Visible = False
        ' 
        ' btnbg_signin
        ' 
        btnbg_signin.BackColor = Color.White
        btnbg_signin.BorderRadius = 40
        btnbg_signin.ForeColor = Color.Black
        btnbg_signin.GradientAngle = 90.0F
        btnbg_signin.GradientBottomColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_signin.GradientTopColor = Color.FromArgb(CByte(0), CByte(102), CByte(0))
        btnbg_signin.Location = New Point(125, 350)
        btnbg_signin.Name = "btnbg_signin"
        btnbg_signin.Size = New Size(195, 35)
        btnbg_signin.TabIndex = 16
        btnbg_signin.Text = "Gerald4"
        btnbg_signin.UseVisualStyleBackColor = False
        btnbg_signin.Visible = False
        ' 
        ' bg_signin
        ' 
        bg_signin.BackColor = Color.White
        bg_signin.BorderRadius = 40
        bg_signin.ForeColor = Color.Black
        bg_signin.GradientAngle = 90.0F
        bg_signin.GradientBottomColor = Color.White
        bg_signin.GradientTopColor = Color.White
        bg_signin.Location = New Point(123, 348)
        bg_signin.Name = "bg_signin"
        bg_signin.Size = New Size(200, 40)
        bg_signin.TabIndex = 17
        bg_signin.Text = "Gerald4"
        bg_signin.UseVisualStyleBackColor = False
        bg_signin.Visible = False
        ' 
        ' LoginForgot
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 600)
        Controls.Add(p_base)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForgot"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForgot"
        p_login.ResumeLayout(False)
        p_login.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        p_base.ResumeLayout(False)
        p_base.PerformLayout()
        p_changepass.ResumeLayout(False)
        p_changepass.PerformLayout()
        CType(btn_eye, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        p_verification.ResumeLayout(False)
        p_verification.PerformLayout()
        CType(btn_back, ComponentModel.ISupportInitialize).EndInit()
        p_forgotpass.ResumeLayout(False)
        p_forgotpass.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents p_login As Panel
    Friend WithEvents p_base As Panel
    Friend WithEvents lbl_invalid As Label
    Friend WithEvents Gerald1 As gerald.Gerald
    Friend WithEvents passwordLogin As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Gerald2 As gerald.Gerald
    Friend WithEvents accountIDLogin As MaskedTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Gerald3 As gerald.Gerald
    Friend WithEvents enterbttn As Button
    Friend WithEvents lbl_welcome As Label
    Friend WithEvents bg_fpass As gerald.Gerald
    Friend WithEvents btnbg_forgotpass As gerald.Gerald
    Friend WithEvents lbl_fpass As Label
    Friend WithEvents btn_forgotpass As Button
    Friend WithEvents p_forgotpass As Panel
    Friend WithEvents lbl_emailme As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents Gerald8 As gerald.Gerald
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Gerald9 As gerald.Gerald
    Friend WithEvents lbl_resetpass As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_besure As Label
    Friend WithEvents lbl_ready As Label
    Friend WithEvents btn_signin As Button
    Friend WithEvents btnbg_signin As gerald.Gerald
    Friend WithEvents bg_signin As gerald.Gerald
    Friend WithEvents p_verification As Panel
    Friend WithEvents lbl_verification As Label
    Friend WithEvents lbl_codesent As Label
    Friend WithEvents btn_verify As Button
    Friend WithEvents btnbg_verify As gerald.Gerald
    Friend WithEvents txtb_c1 As TextBox
    Friend WithEvents bg_code As gerald.Gerald
    Friend WithEvents txtb_c6 As TextBox
    Friend WithEvents Gerald11 As gerald.Gerald
    Friend WithEvents txtb_c5 As TextBox
    Friend WithEvents Gerald10 As gerald.Gerald
    Friend WithEvents txtb_c4 As TextBox
    Friend WithEvents Gerald7 As gerald.Gerald
    Friend WithEvents txtb_c3 As TextBox
    Friend WithEvents Gerald6 As gerald.Gerald
    Friend WithEvents txtb_c2 As TextBox
    Friend WithEvents Gerald5 As gerald.Gerald
    Friend WithEvents btn_back As PictureBox
    Friend WithEvents p_changepass As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Gerald17 As gerald.Gerald
    Friend WithEvents txtb_newpassword As TextBox
    Friend WithEvents Gerald4 As gerald.Gerald
    Friend WithEvents txtb_confirmpassword As TextBox
    Friend WithEvents Gerald12 As gerald.Gerald
    Friend WithEvents btn_eye As PictureBox
End Class
