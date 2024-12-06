Imports System.Drawing.Drawing2D
Imports System.Windows
Imports Transitions

Public Class LoginForgot
    Dim originallocation As Size
    Dim hiddenlocation As Size
    Dim originallocation_fpass As Size
    Dim hiddenlocation_fpass As Size

    Dim hidden As Boolean

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, 20, 20, 180, 90)
        path.AddArc(Me.ClientSize.Width - 20, 0, 20, 20, 270, 90)
        path.AddArc(Me.ClientSize.Width - 20, Me.ClientSize.Height - 20, 20, 20, 0, 90)
        path.AddArc(0, Me.ClientSize.Height - 20, 20, 20, 90, 90)
        path.CloseAllFigures()
        Me.Region = New Region(path)
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub

    Private Sub LoginForgot_Load(sender As Object, e As EventArgs)
        enterbttn.FlatAppearance.BorderColor = Color.Green
        btn_forgotpass.FlatAppearance.BorderColor = Color.Green

        p_login.Location = New Point(0, 0)
        p_forgotpass.Location = New Point(800, 0)

        hidden = True
    End Sub

    Private Sub btn_forgotpass_Click(sender As Object, e As EventArgs) Handles btn_forgotpass.Click
        p_forgotpass.BringToFront()
        Transition.run(p_login, "Left", -350, New TransitionType_Deceleration(900))
        ShowForgotPass()
        Transition.run(p_forgotpass, "Left", 450, New TransitionType_Deceleration(1100))
    End Sub
    Private Sub btn_signin_Click(sender As Object, e As EventArgs) Handles btn_signin.Click
        p_login.BringToFront()
        Transition.run(p_forgotpass, "Left", 800, New TransitionType_Deceleration(900))
        ShowLogin()
        Transition.run(p_login, "Left", 0, New TransitionType_Deceleration(1100))

        Transition.run(p_verification, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(p_changepass, "Left", 800, New TransitionType_Deceleration(900))

    End Sub
    Sub ShowForgotPass()
        lbl_welcome.Visible = False
        lbl_login.Visible = False
        lbl_fpass.Visible = False

        bg_fpass.Visible = False
        btnbg_forgotpass.Visible = False
        btn_forgotpass.Visible = False
        btn_forgotpass.Enabled = False

        lbl_ready.Visible = True
        lbl_besure.Visible = True


        btn_signin.Visible = True
        btn_signin.Enabled = True
        bg_signin.Visible = True
        btnbg_signin.Visible = True

    End Sub
    Sub ShowLogin()
        lbl_welcome.Visible = True
        lbl_login.Visible = True
        lbl_fpass.Visible = True

        bg_fpass.Visible = True
        btnbg_forgotpass.Visible = True
        btn_forgotpass.Visible = True
        btn_forgotpass.Enabled = True

        lbl_ready.Visible = False
        lbl_besure.Visible = False

        bg_signin.Visible = False
        btnbg_signin.Visible = False
        btn_signin.Visible = False
        btn_signin.Enabled = False

    End Sub

    Sub verifytxtb_c()
        If txtb_c1.Text = "" Or txtb_c2.Text = "" Or txtb_c3.Text = "" Or txtb_c4.Text = "" Or txtb_c5.Text = "" Or txtb_c6.Text = "" Then
            btn_verify.Enabled = False
            btnbg_verify.Enabled = False
        Else
            btn_verify.Enabled = True
            btnbg_verify.Enabled = True
        End If
    End Sub

    Sub checkcodeinput(previous As TextBox, following As TextBox, e As KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
            following.Focus()
        ElseIf Asc(e.KeyChar) = 8 Then
            previous.Focus()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtb_c1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c1.KeyPress
        checkcodeinput(txtb_c1, txtb_c2, e)
        verifytxtb_c()
    End Sub

    Private Sub txtb_c2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c2.KeyPress
        checkcodeinput(txtb_c1, txtb_c3, e)
        verifytxtb_c()
    End Sub

    Private Sub txtb_c3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c3.KeyPress
        checkcodeinput(txtb_c2, txtb_c4, e)
        verifytxtb_c()
    End Sub

    Private Sub txtb_c4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c4.KeyPress
        checkcodeinput(txtb_c3, txtb_c5, e)
        verifytxtb_c()
    End Sub

    Private Sub txtb_c5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c5.KeyPress
        checkcodeinput(txtb_c4, txtb_c6, e)
        verifytxtb_c()
    End Sub

    Private Sub txtb_c6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtb_c6.KeyPress
        checkcodeinput(txtb_c5, txtb_c6, e)
        verifytxtb_c()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Transition.run(p_verification, "Left", 800, New TransitionType_Deceleration(900))
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        p_verification.BringToFront()
        Transition.run(p_verification, "Left", 450, New TransitionType_Deceleration(900))
    End Sub

    Private Sub btn_verify_Click(sender As Object, e As EventArgs) Handles btn_verify.Click
        p_changepass.BringToFront()
        Transition.run(p_changepass, "Left", 450, New TransitionType_Deceleration(900))
    End Sub

    Private Sub btn_eye_Click(sender As Object, e As EventArgs) Handles btn_eye.Click

        If hidden = True Then
            txtb_newpassword.PasswordChar = ""
            txtb_confirmpassword.PasswordChar = ""

            btn_eye.Image = Image.FromFile("C:\Users\PLPASIG\Source\Repos\ashooo\Grade-Management-System-Main-fluffbunny\GradeManagementSystem\Resources\icon_eyeslash.png")
            hidden = False
        Else
            txtb_newpassword.PasswordChar = "•"
            txtb_confirmpassword.PasswordChar = "•"

            btn_eye.Image = Image.FromFile("C:\Users\PLPASIG\Source\Repos\ashooo\Grade-Management-System-Main-fluffbunny\GradeManagementSystem\Resources\icon_eye.png")
            hidden = True
        End If

    End Sub

End Class