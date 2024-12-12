Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common
Imports Transitions

Public Class LoginForgot
    Private hidden As Boolean
    Private idinputTracker As Integer
    Private randomcode As String
    Private email As String

    Public connector As New DatabaseConnector
    Private emailSender As New email
    Private studentForm As New StudentForm
    Public gradingSheet As New GradingSheet

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

        p_wid.Visible = False
        p_wpassword.Visible = False
        pb_wid.Visible = False
        lbl_invalid.Visible = False

        hidden = True
    End Sub

    Private Sub btn_forgotpass_Click(sender As Object, e As EventArgs) Handles btn_forgotpass.Click

        ds_forgot.BringToFront()
        p_forgotpass.BringToFront()
        Transition.run(p_login, "Left", -350, New TransitionType_Deceleration(900))
        Transition.run(ds_login, "Left", -298, New TransitionType_Deceleration(900))

        Transition.run(p_forgotpass, "Left", 450, New TransitionType_Deceleration(1100))
        Transition.run(ds_forgot, "Left", 426, New TransitionType_Deceleration(1100))

        resetSignin()
        ShowForgotPass()
    End Sub
    Private Sub btn_signin_Click(sender As Object, e As EventArgs) Handles btn_signin.Click

        ds_login.BringToFront()
        p_login.BringToFront()
        Transition.run(p_forgotpass, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(ds_forgot, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(p_verification, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(p_changepass, "Left", 800, New TransitionType_Deceleration(900))

        Transition.run(p_login, "Left", 0, New TransitionType_Deceleration(1100))
        Transition.run(ds_login, "Left", 297, New TransitionType_Deceleration(1100))

        resetForgot()
        ShowLogin()
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

    Sub resetForgot()
        pb_wemail.Visible = False
        pb_emailerror.Visible = False

        p_wc1.Visible = False
        p_wc2.Visible = False
        p_wc3.Visible = False
        p_wc4.Visible = False
        p_wc5.Visible = False
        p_wc6.Visible = False
        lbl_wrongcode.Visible = False
    End Sub

    Sub resetSignin()
        pb_wid.Visible = False
        p_wid.Visible = False
        p_wpassword.Visible = False
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


    Private Sub txtb_userid_TextChanged(sender As Object, e As EventArgs) Handles txtb_userid.TextChanged
        Dim cursorPosition As Integer = txtb_userid.SelectionStart
        Dim textWithoutDashes As String = txtb_userid.Text.Replace("-", "")

        Dim formattedText As String = ""
        If textWithoutDashes.Length > 0 Then
            formattedText = textWithoutDashes.Substring(0, 1)
        End If
        If textWithoutDashes.Length > 1 Then
            formattedText &= "-" & textWithoutDashes.Substring(1, Math.Min(2, textWithoutDashes.Length - 1))
        End If
        If textWithoutDashes.Length > 3 Then
            formattedText &= "-" & textWithoutDashes.Substring(3, Math.Min(5, textWithoutDashes.Length - 3))
        End If

        Dim dashCountBeforeCursor As Integer = txtb_userid.Text.Substring(0, Math.Min(cursorPosition, txtb_userid.Text.Length)).Count(Function(c) c = "-")
        Dim dashCountAfterFormatting As Integer = formattedText.Substring(0, Math.Min(cursorPosition, formattedText.Length)).Count(Function(c) c = "-")

        cursorPosition += (dashCountAfterFormatting - dashCountBeforeCursor)

        txtb_userid.Text = formattedText
        txtb_userid.SelectionStart = Math.Min(cursorPosition, txtb_userid.Text.Length)
    End Sub


    Private Function trimmedID() As String
        Dim id As String = txtb_userid.Text.Replace("-", "")
        Return id
    End Function
    Private Function password() As String
        Dim pass As String = txtb_password.Text
        Return pass
    End Function

    Private Sub enterbttn_Click(sender As Object, e As EventArgs) Handles enterbttn.Click
        Try
            connector.connect.Open()
            connector.query = "SELECT student.id AS id, student.password AS password FROM student UNION SELECT professor.id AS id, professor.password AS password FROM professor UNION SELECT admin.id AS id, admin.password AS password FROM admin;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                If ((connector.reader("id").ToString IsNot Nothing AndAlso connector.reader("id").ToString.Equals(trimmedID())) And connector.reader("password").ToString IsNot Nothing AndAlso connector.reader("password").ToString.Equals(password())) Then
                    If (trimmedID().Chars(0) = "1") Then
                        connector.connect.Close()
                        Me.Visible = False
                        studentForm.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "2") Then
                        connector.connect.Close()
                        loadClass()
                        getProfName()
                        Me.Visible = False
                        gradingSheet.Visible = True
                        Return
                    ElseIf (trimmedID().Chars(0) = "3") Then
                        connector.connect.Close()
                        Me.Visible = False
                        AdminDashboard.Visible = True
                        Return
                    End If
                End If
            End While

            txtb_userid.Clear()
            txtb_password.Clear()

            p_wid.Visible = True
            p_wpassword.Visible = True
            pb_wid.Visible = True
            lbl_invalid.Visible = True

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Private Sub attendanceExists()
        Try
            connector.connect.Open()
            connector.query = "SELECT item_type FROM item WHERE item_type = 'Attendance' AND term = '" & gradingSheet.getTerm & "' AND class_id = '" & gradingSheet.classID & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("Class ID").ToString Is Nothing) Then
                    gradingSheet.attendanceButton.Enabled = False
                Else
                    gradingSheet.attendanceButton.Enabled = True
                End If
                Exit While
            End While
            gradingSheet.classChooseBox.SelectedIndex = 0
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Public Sub loadClass()
        Dim classID As String = ""
        Try
            gradingSheet.classChooseBox.Items.Clear()
            connector.connect.Open()
            connector.query = "SELECT class_id AS 'Class ID' FROM class WHERE class.professor_id = '" & trimmedID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                If (connector.reader("Class ID").ToString IsNot Nothing) Then
                    classID = connector.reader("Class ID").ToString
                    gradingSheet.classChooseBox.Items.Add(classID)
                End If
            End While
            gradingSheet.classChooseBox.SelectedIndex = 0
            connector.connect.Close()
            connector.reader.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Public Sub getProfName()
        Try
            connector.connect.Open()
            connector.query = "SELECT CONCAT(fname,' ',mname,' ',lname) AS Professor FROM professor WHERE id = '" & trimmedID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            Dim profName As String = connector.command.ExecuteScalar
            gradingSheet.profTextBox.Text = profName
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub

    Friend WithEvents dataView As DataGridView

    '''''EMAIL VERIFICATION PANEL --------------------------------------------------------------------------

    Private Sub txtb_email_TextChanged(sender As Object, e As EventArgs) Handles txtb_email.TextChanged
        If isEmail(txtb_email.Text) = True Then
            btn_reset.Enabled = True
        Else
            btn_reset.Enabled = False
        End If
    End Sub

    Function isEmail(eml As String) As Boolean
        Dim emailPattern As String = "^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$"
        Dim emailRegEx As New Regex(emailPattern, RegexOptions.IgnoreCase)
        Return emailRegEx.IsMatch(eml)
    End Function

    Sub numbergen()
        randomcode = ""
        Dim Characters(35) As String
        For i = 0 To 9   ' digits
            Characters(i) = Chr(i + 48)
        Next i
        For i = 10 To 35   ' uppercase alphabet
            Characters(i) = Chr(i + 55)
        Next i
        Randomize()
        For j = 1 To 6
            randomcode = randomcode + Characters(Int(35 * Rnd()) - 1)
        Next j
    End Sub

    Private Sub SendCode()
        emailSender.emailReset(txtb_email.Text, "Password Reset OTP", "", randomcode)
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        Dim result As Boolean

        connector.connect.Open()
        connector.query = "SELECT student.email as email FROM student UNION SELECT professor.email as email FROM professor;"
        connector.command.Connection = connector.connect
        connector.command.CommandText = connector.query


        Using command As New MySqlCommand(connector.query, connector.command.Connection)
            Dim read As MySqlDataReader
            Dim emailText As String = txtb_email.Text
            read = command.ExecuteReader

            While read.Read
                If (Not read("email").ToString.Equals("") And read("email").ToString.Equals(emailText)) Then
                    result = True
                End If
            End While

            If result = True Then
                Try
                    numbergen()
                Catch
                    numbergen()
                End Try

                SendCode()

                email = emailText
                p_verification.BringToFront()
                Transition.run(p_verification, "Left", 450, New TransitionType_Deceleration(900))
            ElseIf result = False Then
                txtb_email.Text = ""
                pb_emailerror.Visible = True
                pb_wemail.Visible = True
            End If
            read.Close()
        End Using
        connector.connect.Close()
    End Sub

    '''''CODE VERIFICATION PANEL --------------------------------------------------------------------------

    Private Sub btn_verify_Click(sender As Object, e As EventArgs) Handles btn_verify.Click

        Dim code As String

        code = txtb_c1.Text & txtb_c2.Text & txtb_c3.Text & txtb_c4.Text & txtb_c5.Text & txtb_c6.Text

        If code = randomcode Then
            p_changepass.BringToFront()
            Transition.run(p_changepass, "Left", 450, New TransitionType_Deceleration(900))
        Else
            p_wc1.Visible = True
            p_wc2.Visible = True
            p_wc3.Visible = True
            p_wc4.Visible = True
            p_wc5.Visible = True
            p_wc6.Visible = True
            lbl_wrongcode.Visible = True
        End If

    End Sub

    Sub verifyCodetxtb()
        If txtb_c1.Text = "" And txtb_c2.Text = "" And txtb_c3.Text = "" And txtb_c4.Text = "" And txtb_c5.Text = "" And txtb_c6.Text = "" Then
            btn_verify.Enabled = True
        Else
            btn_verify.Enabled = False
        End If
    End Sub

    Private Sub txtb_c1_TextChanged(sender As Object, e As EventArgs) Handles txtb_c1.TextChanged
        verifyCodetxtb()
    End Sub

    Private Sub txtb_c2_TextChanged(sender As Object, e As EventArgs) Handles txtb_c2.TextChanged
        verifyCodetxtb()
    End Sub

    Private Sub txtb_c3_TextChanged(sender As Object, e As EventArgs) Handles txtb_c3.TextChanged
        verifyCodetxtb()
    End Sub

    Private Sub txtb_c4_TextChanged(sender As Object, e As EventArgs) Handles txtb_c4.TextChanged
        verifyCodetxtb()
    End Sub

    Private Sub txtb_c5_TextChanged(sender As Object, e As EventArgs) Handles txtb_c5.TextChanged
        verifyCodetxtb()
    End Sub

    Private Sub txtb_c6_TextChanged(sender As Object, e As EventArgs) Handles txtb_c6.TextChanged
        verifyCodetxtb()
    End Sub

    '''''CHANGE PASSWORD PANEL PANEL --------------------------------------------------------------------------

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim userID As String = ""
        Dim accountTypeIdentifier As String

        If txtb_newpassword.Text = txtb_confirmpassword.Text Then
            connector.connect.Open()
            connector.query = "SELECT student.id as id, student.email as email from student union SELECT professor.id as id, professor.email as email FROM professor;"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query

            Using command As New MySqlCommand(connector.query, connector.command.Connection)
                Dim read As MySqlDataReader
                read = command.ExecuteReader

                While read.Read
                    If (read("email").Equals(email)) Then
                        userID = read("id")
                        Exit While

                    End If
                End While
                read.Close()
            End Using

            If userID <> "" Then
                accountTypeIdentifier = userID.Substring(0, 1)

                If accountTypeIdentifier = 1 Then
                    connector.query = "UPDATE student SET password = '" & txtb_newpassword.Text & "' where email = '" & email & "';"
                    signin()
                ElseIf accountTypeIdentifier = 2 Then
                    connector.query = "UPDATE professor SET password = '" & txtb_newpassword.Text & "' where email = '" & email & "';"
                    signin()
                End If
                connector.command.Connection = connector.connect
                connector.command.CommandText = connector.query
                connector.command.ExecuteNonQuery()
            End If
            connector.connect.Close()
        End If

    End Sub

    Private Sub txtb_newpassword_TextChanged(sender As Object, e As EventArgs) Handles txtb_newpassword.TextChanged
        If txtb_newpassword.Text = "" Or txtb_confirmpassword.Text = "" Then
            btn_confirm.Enabled = False
        Else
            btn_confirm.Enabled = True
        End If
    End Sub

    Private Sub txtb_confirmpassword_TextChanged(sender As Object, e As EventArgs) Handles txtb_confirmpassword.TextChanged
        If txtb_newpassword.Text = "" Or txtb_confirmpassword.Text = "" Then
            btn_confirm.Enabled = False
        Else
            btn_confirm.Enabled = True
        End If
    End Sub

    Sub signin()
        ds_login.BringToFront()
        p_login.BringToFront()
        Transition.run(p_forgotpass, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(ds_forgot, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(p_verification, "Left", 800, New TransitionType_Deceleration(900))
        Transition.run(p_changepass, "Left", 800, New TransitionType_Deceleration(900))

        Transition.run(p_login, "Left", 0, New TransitionType_Deceleration(1100))
        Transition.run(ds_login, "Left", 297, New TransitionType_Deceleration(1100))

        resetForgot()
        ShowLogin()
    End Sub
End Class