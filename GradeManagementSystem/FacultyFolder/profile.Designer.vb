<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(profile))
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox2 = New PictureBox()
        useremail = New Label()
        userdepartment = New Label()
        userjobrole = New Label()
        userfullname = New Label()
        profpic = New picture.CirclePicture()
        Label19 = New Label()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(profpic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.Location = New Point(503, 183)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(29, 32)
        PictureBox5.TabIndex = 94
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(503, 229)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(29, 29)
        PictureBox4.TabIndex = 93
        PictureBox4.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(503, 269)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 34)
        PictureBox2.TabIndex = 87
        PictureBox2.TabStop = False
        ' 
        ' useremail
        ' 
        useremail.AutoSize = True
        useremail.Font = New Font("Sitka Banner Semibold", 11F, FontStyle.Bold)
        useremail.Location = New Point(538, 271)
        useremail.Name = "useremail"
        useremail.Size = New Size(264, 32)
        useremail.TabIndex = 92
        useremail.Text = "maryynahbrazil@gmail.com"
        ' 
        ' userdepartment
        ' 
        userdepartment.AutoSize = True
        userdepartment.Font = New Font("Sitka Banner Semibold", 11F, FontStyle.Bold)
        userdepartment.Location = New Point(538, 228)
        userdepartment.Name = "userdepartment"
        userdepartment.Size = New Size(258, 32)
        userdepartment.TabIndex = 91
        userdepartment.Text = "College of Computer Studies"
        ' 
        ' userjobrole
        ' 
        userjobrole.AutoSize = True
        userjobrole.Font = New Font("Sitka Banner Semibold", 11F, FontStyle.Bold)
        userjobrole.Location = New Point(538, 183)
        userjobrole.Name = "userjobrole"
        userjobrole.Size = New Size(97, 32)
        userjobrole.TabIndex = 90
        userjobrole.Text = "Professor"
        ' 
        ' userfullname
        ' 
        userfullname.AutoSize = True
        userfullname.Font = New Font("Sitka Banner Semibold", 18F, FontStyle.Bold)
        userfullname.ForeColor = Color.DarkGreen
        userfullname.Location = New Point(415, 120)
        userfullname.Name = "userfullname"
        userfullname.Size = New Size(385, 52)
        userfullname.TabIndex = 88
        userfullname.Text = "Sese, Mary Ynah Brazil A."
        ' 
        ' profpic
        ' 
        profpic.BackColor = Color.White
        profpic.BackgroundImageLayout = ImageLayout.Zoom
        profpic.BorderRadius = 60
        profpic.ForeColor = Color.Black
        profpic.GradientAngle = 90F
        profpic.GradientBottomColor = Color.Transparent
        profpic.GradientTopColor = Color.Transparent
        profpic.Image = CType(resources.GetObject("profpic.Image"), Image)
        profpic.Location = New Point(164, 126)
        profpic.Margin = New Padding(4)
        profpic.Name = "profpic"
        profpic.Size = New Size(216, 175)
        profpic.SizeMode = PictureBoxSizeMode.StretchImage
        profpic.TabIndex = 89
        profpic.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.DarkGreen
        Label19.Location = New Point(67, 38)
        Label19.Name = "Label19"
        Label19.Size = New Size(115, 29)
        Label19.TabIndex = 86
        Label19.Text = "P R O F I L E"
        ' 
        ' profile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1103, 412)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox2)
        Controls.Add(useremail)
        Controls.Add(userdepartment)
        Controls.Add(userjobrole)
        Controls.Add(userfullname)
        Controls.Add(profpic)
        Controls.Add(Label19)
        FormBorderStyle = FormBorderStyle.None
        Name = "profile"
        Text = "profile"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(profpic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents useremail As Label
    Friend WithEvents userdepartment As Label
    Friend WithEvents userjobrole As Label
    Friend WithEvents userfullname As Label
    Friend WithEvents profpic As picture.CirclePicture
    Friend WithEvents Label19 As Label
End Class
