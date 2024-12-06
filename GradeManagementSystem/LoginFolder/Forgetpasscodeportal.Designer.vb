<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgetpasscodeportal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgetpasscodeportal))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        emailaddress = New TextBox()
        Label4 = New Label()
        backtologinicon = New PictureBox()
        backtologinclick = New Label()
        resetpasscodebttn = New PictureBox()
        CType(backtologinicon, ComponentModel.ISupportInitialize).BeginInit()
        CType(resetpasscodebttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(87, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 34)
        Label1.TabIndex = 0
        Label1.Text = "F o r g e t  P a s s c o d e ?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(46, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(482, 22)
        Label2.TabIndex = 1
        Label2.Text = "No need to worry, we’ll email you reset instructions."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SeaGreen
        Label3.Font = New Font("Segoe UI", 27F)
        Label3.ForeColor = Color.SeaGreen
        Label3.Location = New Point(71, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(428, 72)
        Label3.TabIndex = 3
        Label3.Text = "anong label niyo"
        ' 
        ' emailaddress
        ' 
        emailaddress.BackColor = Color.SeaGreen
        emailaddress.BorderStyle = BorderStyle.None
        emailaddress.Font = New Font("Segoe UI", 11F)
        emailaddress.ForeColor = Color.ForestGreen
        emailaddress.Location = New Point(105, 250)
        emailaddress.Name = "emailaddress"
        emailaddress.Size = New Size(359, 30)
        emailaddress.TabIndex = 2
        emailaddress.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 7F)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(209, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 17)
        Label4.TabIndex = 4
        Label4.Text = "Enter Email Address"
        ' 
        ' backtologinicon
        ' 
        backtologinicon.BackColor = Color.Transparent
        backtologinicon.BackgroundImage = CType(resources.GetObject("backtologinicon.BackgroundImage"), Image)
        backtologinicon.BackgroundImageLayout = ImageLayout.Zoom
        backtologinicon.ImageLocation = ""
        backtologinicon.Location = New Point(93, 458)
        backtologinicon.Margin = New Padding(4)
        backtologinicon.Name = "backtologinicon"
        backtologinicon.Size = New Size(123, 57)
        backtologinicon.SizeMode = PictureBoxSizeMode.Zoom
        backtologinicon.TabIndex = 46
        backtologinicon.TabStop = False
        ' 
        ' backtologinclick
        ' 
        backtologinclick.AutoSize = True
        backtologinclick.Font = New Font("Verdana", 10F)
        backtologinclick.ForeColor = Color.DimGray
        backtologinclick.Location = New Point(202, 474)
        backtologinclick.Name = "backtologinclick"
        backtologinclick.Size = New Size(148, 25)
        backtologinclick.TabIndex = 47
        backtologinclick.Text = "Back to Login"
        ' 
        ' resetpasscodebttn
        ' 
        resetpasscodebttn.BackColor = Color.Transparent
        resetpasscodebttn.BackgroundImage = CType(resources.GetObject("resetpasscodebttn.BackgroundImage"), Image)
        resetpasscodebttn.BackgroundImageLayout = ImageLayout.Stretch
        resetpasscodebttn.ImageLocation = ""
        resetpasscodebttn.Location = New Point(175, 327)
        resetpasscodebttn.Margin = New Padding(4)
        resetpasscodebttn.Name = "resetpasscodebttn"
        resetpasscodebttn.Size = New Size(194, 85)
        resetpasscodebttn.SizeMode = PictureBoxSizeMode.Zoom
        resetpasscodebttn.TabIndex = 51
        resetpasscodebttn.TabStop = False
        ' 
        ' Forgetpasscodeportal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MintCream
        ClientSize = New Size(574, 589)
        Controls.Add(resetpasscodebttn)
        Controls.Add(backtologinclick)
        Controls.Add(backtologinicon)
        Controls.Add(Label4)
        Controls.Add(emailaddress)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Forgetpasscodeportal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgetpasscodeportal"
        CType(backtologinicon, ComponentModel.ISupportInitialize).EndInit()
        CType(resetpasscodebttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents emailaddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents backtologinicon As PictureBox
    Friend WithEvents backtologinclick As Label
    Friend WithEvents resetpasscodebttn As PictureBox
End Class
