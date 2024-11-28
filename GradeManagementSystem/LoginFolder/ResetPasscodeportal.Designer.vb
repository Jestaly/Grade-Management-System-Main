<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPasscodeportal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResetPasscodeportal))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        digitcodetxt = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        newpasswordtxt = New TextBox()
        confirmnewpasswordtxt = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        digitcode_errormessage = New Label()
        newpassword_errormessage = New Label()
        confirmnewpassword_errormessage = New Label()
        PictureBox9 = New PictureBox()
        tryagainclick = New Label()
        resetpasscodebttn = New PictureBox()
        confirmnewpasscode_errormessage = New Label()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(resetpasscodebttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(69, 29)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 29)
        Label1.TabIndex = 1
        Label1.Text = "C h e c k  y o u r  e m a i l !"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(34, 71)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(396, 18)
        Label2.TabIndex = 2
        Label2.Text = "Input the 6-digit code, then set your new password."
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SeaGreen
        Label3.Font = New Font("Segoe UI", 25F)
        Label3.ForeColor = Color.SeaGreen
        Label3.Location = New Point(69, 134)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(335, 57)
        Label3.TabIndex = 4
        Label3.Text = "anong label niyo"
        ' 
        ' digitcodetxt
        ' 
        digitcodetxt.BackColor = Color.SeaGreen
        digitcodetxt.BorderStyle = BorderStyle.None
        digitcodetxt.Font = New Font("Segoe UI", 11F)
        digitcodetxt.ForeColor = Color.White
        digitcodetxt.Location = New Point(81, 150)
        digitcodetxt.Margin = New Padding(2, 2, 2, 2)
        digitcodetxt.Name = "digitcodetxt"
        digitcodetxt.Size = New Size(287, 25)
        digitcodetxt.TabIndex = 5
        digitcodetxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 7F)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(73, 117)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 14)
        Label4.TabIndex = 6
        Label4.Text = "Enter 6 - digit code"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        Label5.Font = New Font("Segoe UI", 25F)
        Label5.ForeColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        Label5.Location = New Point(69, 237)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(335, 57)
        Label5.TabIndex = 7
        Label5.Text = "anong label niyo"
        ' 
        ' newpasswordtxt
        ' 
        newpasswordtxt.BackColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        newpasswordtxt.BorderStyle = BorderStyle.None
        newpasswordtxt.Font = New Font("Segoe UI", 11F)
        newpasswordtxt.ForeColor = Color.White
        newpasswordtxt.Location = New Point(81, 253)
        newpasswordtxt.Margin = New Padding(2, 2, 2, 2)
        newpasswordtxt.Name = "newpasswordtxt"
        newpasswordtxt.Size = New Size(287, 25)
        newpasswordtxt.TabIndex = 8
        newpasswordtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' confirmnewpasswordtxt
        ' 
        confirmnewpasswordtxt.BackColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        confirmnewpasswordtxt.BorderStyle = BorderStyle.None
        confirmnewpasswordtxt.Font = New Font("Segoe UI", 11F)
        confirmnewpasswordtxt.ForeColor = Color.White
        confirmnewpasswordtxt.Location = New Point(81, 356)
        confirmnewpasswordtxt.Margin = New Padding(2, 2, 2, 2)
        confirmnewpasswordtxt.Name = "confirmnewpasswordtxt"
        confirmnewpasswordtxt.Size = New Size(287, 25)
        confirmnewpasswordtxt.TabIndex = 10
        confirmnewpasswordtxt.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        Label6.Font = New Font("Segoe UI", 25F)
        Label6.ForeColor = Color.FromArgb(CByte(148), CByte(219), CByte(179))
        Label6.Location = New Point(69, 340)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(335, 57)
        Label6.TabIndex = 9
        Label6.Text = "anong label niyo"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 7F)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(73, 219)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 14)
        Label7.TabIndex = 11
        Label7.Text = "Enter New Passcode"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 7F)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(73, 322)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(151, 14)
        Label8.TabIndex = 12
        Label8.Text = "Confirm New Passcode"
        ' 
        ' digitcode_errormessage
        ' 
        digitcode_errormessage.AutoSize = True
        digitcode_errormessage.Font = New Font("Verdana", 7F)
        digitcode_errormessage.ForeColor = Color.Red
        digitcode_errormessage.Location = New Point(69, 187)
        digitcode_errormessage.Margin = New Padding(2, 0, 2, 0)
        digitcode_errormessage.Name = "digitcode_errormessage"
        digitcode_errormessage.Size = New Size(0, 14)
        digitcode_errormessage.TabIndex = 13
        ' 
        ' newpassword_errormessage
        ' 
        newpassword_errormessage.AutoSize = True
        newpassword_errormessage.Font = New Font("Verdana", 7F)
        newpassword_errormessage.ForeColor = Color.Red
        newpassword_errormessage.Location = New Point(71, 290)
        newpassword_errormessage.Margin = New Padding(2, 0, 2, 0)
        newpassword_errormessage.Name = "newpassword_errormessage"
        newpassword_errormessage.Size = New Size(0, 14)
        newpassword_errormessage.TabIndex = 14
        ' 
        ' confirmnewpassword_errormessage
        ' 
        confirmnewpassword_errormessage.AutoSize = True
        confirmnewpassword_errormessage.Font = New Font("Verdana", 7F)
        confirmnewpassword_errormessage.ForeColor = Color.Red
        confirmnewpassword_errormessage.Location = New Point(69, 416)
        confirmnewpassword_errormessage.Margin = New Padding(2, 0, 2, 0)
        confirmnewpassword_errormessage.Name = "confirmnewpassword_errormessage"
        confirmnewpassword_errormessage.Size = New Size(0, 14)
        confirmnewpassword_errormessage.TabIndex = 15
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox9.ImageLocation = ""
        PictureBox9.Location = New Point(86, 516)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(102, 46)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 47
        PictureBox9.TabStop = False
        ' 
        ' tryagainclick
        ' 
        tryagainclick.AutoSize = True
        tryagainclick.Font = New Font("Verdana", 10F)
        tryagainclick.ForeColor = Color.DimGray
        tryagainclick.Location = New Point(182, 528)
        tryagainclick.Margin = New Padding(2, 0, 2, 0)
        tryagainclick.Name = "tryagainclick"
        tryagainclick.Size = New Size(89, 20)
        tryagainclick.TabIndex = 48
        tryagainclick.Text = "Try Again"
        ' 
        ' resetpasscodebttn
        ' 
        resetpasscodebttn.BackColor = Color.Transparent
        resetpasscodebttn.BackgroundImage = CType(resources.GetObject("resetpasscodebttn.BackgroundImage"), Image)
        resetpasscodebttn.BackgroundImageLayout = ImageLayout.Stretch
        resetpasscodebttn.ImageLocation = ""
        resetpasscodebttn.Location = New Point(146, 416)
        resetpasscodebttn.Name = "resetpasscodebttn"
        resetpasscodebttn.Size = New Size(150, 69)
        resetpasscodebttn.SizeMode = PictureBoxSizeMode.Zoom
        resetpasscodebttn.TabIndex = 50
        resetpasscodebttn.TabStop = False
        ' 
        ' confirmnewpasscode_errormessage
        ' 
        confirmnewpasscode_errormessage.AutoSize = True
        confirmnewpasscode_errormessage.Font = New Font("Verdana", 7F)
        confirmnewpasscode_errormessage.ForeColor = Color.Red
        confirmnewpasscode_errormessage.Location = New Point(71, 394)
        confirmnewpasscode_errormessage.Margin = New Padding(2, 0, 2, 0)
        confirmnewpasscode_errormessage.Name = "confirmnewpasscode_errormessage"
        confirmnewpasscode_errormessage.Size = New Size(0, 14)
        confirmnewpasscode_errormessage.TabIndex = 51
        ' 
        ' ResetPasscodeportal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        ClientSize = New Size(455, 602)
        Controls.Add(confirmnewpasscode_errormessage)
        Controls.Add(tryagainclick)
        Controls.Add(PictureBox9)
        Controls.Add(confirmnewpassword_errormessage)
        Controls.Add(newpassword_errormessage)
        Controls.Add(digitcode_errormessage)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(confirmnewpasswordtxt)
        Controls.Add(Label6)
        Controls.Add(newpasswordtxt)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(digitcodetxt)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(resetpasscodebttn)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "ResetPasscodeportal"
        Text = "ResetPasscodeportal"
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(resetpasscodebttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents digitcodetxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents newpasswordtxt As TextBox
    Friend WithEvents confirmnewpasswordtxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents digitcode_errormessage As Label
    Friend WithEvents newpassword_errormessage As Label
    Friend WithEvents confirmnewpassword_errormessage As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents tryagainclick As Label
    Friend WithEvents resetpasscodebttn As PictureBox
    Friend WithEvents confirmnewpasscode_errormessage As Label
End Class
