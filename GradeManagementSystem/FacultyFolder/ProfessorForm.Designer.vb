<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfessorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProfessorForm))
        Gerald1 = New gerald.Gerald()
        profmenu = New picture.CirclePicture()
        grademanagement = New PictureBox()
        course = New PictureBox()
        PictureBox9 = New PictureBox()
        logoutbttn = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        logoutbttn2 = New Label()
        PictureBox2 = New PictureBox()
        notifbttn = New PictureBox()
        logbttn = New PictureBox()
        logview = New DataGridView()
        notifview = New DataGridView()
        grademanage = New PictureBox()
        coursemanage = New PictureBox()
        settings = New PictureBox()
        CType(profmenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(grademanagement, ComponentModel.ISupportInitialize).BeginInit()
        CType(course, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(notifbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(logbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(logview, ComponentModel.ISupportInitialize).BeginInit()
        CType(notifview, ComponentModel.ISupportInitialize).BeginInit()
        CType(grademanage, ComponentModel.ISupportInitialize).BeginInit()
        CType(coursemanage, ComponentModel.ISupportInitialize).BeginInit()
        CType(settings, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Gerald1
        ' 
        Gerald1.BackColor = Color.White
        Gerald1.BackgroundImageLayout = ImageLayout.None
        Gerald1.BorderRadius = 60
        Gerald1.ForeColor = Color.Black
        Gerald1.GradientAngle = 90F
        Gerald1.GradientBottomColor = Color.Honeydew
        Gerald1.GradientTopColor = Color.Honeydew
        Gerald1.Location = New Point(123, 15)
        Gerald1.Name = "Gerald1"
        Gerald1.Size = New Size(1466, 755)
        Gerald1.TabIndex = 0
        Gerald1.Text = "Gerald1"
        Gerald1.UseVisualStyleBackColor = False
        ' 
        ' profmenu
        ' 
        profmenu.BackColor = Color.White
        profmenu.BackgroundImageLayout = ImageLayout.Zoom
        profmenu.BorderRadius = 60
        profmenu.ForeColor = Color.Black
        profmenu.GradientAngle = 90F
        profmenu.GradientBottomColor = Color.Transparent
        profmenu.GradientTopColor = Color.Transparent
        profmenu.Image = CType(resources.GetObject("profmenu.Image"), Image)
        profmenu.Location = New Point(33, 31)
        profmenu.Margin = New Padding(4)
        profmenu.Name = "profmenu"
        profmenu.Size = New Size(64, 61)
        profmenu.SizeMode = PictureBoxSizeMode.StretchImage
        profmenu.TabIndex = 79
        profmenu.TabStop = False
        ' 
        ' grademanagement
        ' 
        grademanagement.BackColor = Color.Transparent
        grademanagement.BackgroundImage = CType(resources.GetObject("grademanagement.BackgroundImage"), Image)
        grademanagement.BackgroundImageLayout = ImageLayout.Stretch
        grademanagement.Location = New Point(25, 270)
        grademanagement.Name = "grademanagement"
        grademanagement.Size = New Size(68, 50)
        grademanagement.TabIndex = 81
        grademanagement.TabStop = False
        ' 
        ' course
        ' 
        course.BackColor = Color.Transparent
        course.BackgroundImage = CType(resources.GetObject("course.BackgroundImage"), Image)
        course.BackgroundImageLayout = ImageLayout.Stretch
        course.Location = New Point(34, 397)
        course.Name = "course"
        course.Size = New Size(63, 48)
        course.TabIndex = 82
        course.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(31, 527)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(60, 53)
        PictureBox9.TabIndex = 84
        PictureBox9.TabStop = False
        ' 
        ' logoutbttn
        ' 
        logoutbttn.BackColor = Color.Transparent
        logoutbttn.BackgroundImage = CType(resources.GetObject("logoutbttn.BackgroundImage"), Image)
        logoutbttn.BackgroundImageLayout = ImageLayout.Stretch
        logoutbttn.Location = New Point(33, 679)
        logoutbttn.Name = "logoutbttn"
        logoutbttn.Size = New Size(57, 47)
        logoutbttn.TabIndex = 86
        logoutbttn.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 4F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(15, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 10)
        Label2.TabIndex = 88
        Label2.Text = "GRADE MANAGEMENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 4.5F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(28, 203)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 12)
        Label1.TabIndex = 89
        Label1.Text = "DASHBOARD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 4F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(14, 447)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 10)
        Label3.TabIndex = 90
        Label3.Text = "COURSE MANAGEMENT"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 4F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(18, 579)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 10)
        Label5.TabIndex = 92
        Label5.Text = "SECURITY SETTINGS"
        ' 
        ' logoutbttn2
        ' 
        logoutbttn2.AutoSize = True
        logoutbttn2.Font = New Font("Verdana", 4.5F)
        logoutbttn2.ForeColor = Color.White
        logoutbttn2.Location = New Point(33, 728)
        logoutbttn2.Name = "logoutbttn2"
        logoutbttn2.Size = New Size(55, 12)
        logoutbttn2.TabIndex = 93
        logoutbttn2.Text = "LOG OUT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(35, 151)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(55, 49)
        PictureBox2.TabIndex = 87
        PictureBox2.TabStop = False
        ' 
        ' notifbttn
        ' 
        notifbttn.BackColor = Color.Honeydew
        notifbttn.BackgroundImage = CType(resources.GetObject("notifbttn.BackgroundImage"), Image)
        notifbttn.BackgroundImageLayout = ImageLayout.Stretch
        notifbttn.Location = New Point(1438, 42)
        notifbttn.Name = "notifbttn"
        notifbttn.Size = New Size(41, 40)
        notifbttn.TabIndex = 96
        notifbttn.TabStop = False
        ' 
        ' logbttn
        ' 
        logbttn.BackColor = Color.Honeydew
        logbttn.BackgroundImage = CType(resources.GetObject("logbttn.BackgroundImage"), Image)
        logbttn.BackgroundImageLayout = ImageLayout.Stretch
        logbttn.Location = New Point(1506, 42)
        logbttn.Name = "logbttn"
        logbttn.Size = New Size(44, 40)
        logbttn.TabIndex = 97
        logbttn.TabStop = False
        ' 
        ' logview
        ' 
        logview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        logview.Location = New Point(886, 88)
        logview.Name = "logview"
        logview.RowHeadersWidth = 62
        logview.Size = New Size(664, 580)
        logview.TabIndex = 98
        logview.Visible = False
        ' 
        ' notifview
        ' 
        notifview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        notifview.Location = New Point(817, 88)
        notifview.Name = "notifview"
        notifview.RowHeadersWidth = 62
        notifview.Size = New Size(664, 580)
        notifview.TabIndex = 99
        notifview.Visible = False
        ' 
        ' grademanage
        ' 
        grademanage.BackColor = Color.Transparent
        grademanage.BackgroundImage = CType(resources.GetObject("grademanage.BackgroundImage"), Image)
        grademanage.BackgroundImageLayout = ImageLayout.Stretch
        grademanage.Location = New Point(15, 264)
        grademanage.Name = "grademanage"
        grademanage.Size = New Size(174, 65)
        grademanage.TabIndex = 100
        grademanage.TabStop = False
        grademanage.Visible = False
        ' 
        ' coursemanage
        ' 
        coursemanage.BackColor = Color.Transparent
        coursemanage.BackgroundImage = CType(resources.GetObject("coursemanage.BackgroundImage"), Image)
        coursemanage.BackgroundImageLayout = ImageLayout.Stretch
        coursemanage.Location = New Point(12, 394)
        coursemanage.Name = "coursemanage"
        coursemanage.Size = New Size(186, 75)
        coursemanage.TabIndex = 101
        coursemanage.TabStop = False
        coursemanage.Visible = False
        ' 
        ' settings
        ' 
        settings.BackColor = Color.Transparent
        settings.BackgroundImage = CType(resources.GetObject("settings.BackgroundImage"), Image)
        settings.BackgroundImageLayout = ImageLayout.Stretch
        settings.Location = New Point(12, 525)
        settings.Name = "settings"
        settings.Size = New Size(177, 75)
        settings.TabIndex = 102
        settings.TabStop = False
        settings.Visible = False
        ' 
        ' ProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGreen
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1601, 782)
        Controls.Add(notifview)
        Controls.Add(logview)
        Controls.Add(notifbttn)
        Controls.Add(logbttn)
        Controls.Add(Gerald1)
        Controls.Add(settings)
        Controls.Add(coursemanage)
        Controls.Add(grademanage)
        Controls.Add(logoutbttn2)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(logoutbttn)
        Controls.Add(PictureBox9)
        Controls.Add(course)
        Controls.Add(grademanagement)
        Controls.Add(profmenu)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ProfessorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfessorForm"
        CType(profmenu, ComponentModel.ISupportInitialize).EndInit()
        CType(grademanagement, ComponentModel.ISupportInitialize).EndInit()
        CType(course, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(notifbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(logbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(logview, ComponentModel.ISupportInitialize).EndInit()
        CType(notifview, ComponentModel.ISupportInitialize).EndInit()
        CType(grademanage, ComponentModel.ISupportInitialize).EndInit()
        CType(coursemanage, ComponentModel.ISupportInitialize).EndInit()
        CType(settings, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Gerald1 As gerald.Gerald
    Friend WithEvents profmenu As picture.CirclePicture
    Friend WithEvents grademanagement As PictureBox
    Friend WithEvents course As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents logoutbttn As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents logoutbttn2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents notifbttn As PictureBox
    Friend WithEvents logbttn As PictureBox
    Friend WithEvents logview As DataGridView
    Friend WithEvents notifview As DataGridView
    Friend WithEvents grademanage As PictureBox
    Friend WithEvents coursemanage As PictureBox
    Friend WithEvents settings As PictureBox
End Class
