<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        activitylog2 = New Panel()
        Label5 = New Label()
        coursemanage2 = New Panel()
        Label3 = New Label()
        activitylog = New Label()
        logout2 = New PictureBox()
        profile2 = New Panel()
        Label4 = New Label()
        grademanagement2 = New Panel()
        Label13 = New Label()
        logoutbttn = New Label()
        dashboard2 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox3 = New PictureBox()
        profilebttn = New Label()
        coursemanagebttn = New Label()
        grademanagebttn = New Label()
        dashboardbttn = New Label()
        notificationpanel = New Panel()
        Label11 = New Label()
        profmenu = New picture.CirclePicture()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        activitylog2.SuspendLayout()
        coursemanage2.SuspendLayout()
        CType(logout2, ComponentModel.ISupportInitialize).BeginInit()
        profile2.SuspendLayout()
        grademanagement2.SuspendLayout()
        dashboard2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        notificationpanel.SuspendLayout()
        CType(profmenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Controls.Add(activitylog2)
        Panel1.Controls.Add(coursemanage2)
        Panel1.Controls.Add(activitylog)
        Panel1.Controls.Add(logout2)
        Panel1.Controls.Add(profile2)
        Panel1.Controls.Add(grademanagement2)
        Panel1.Controls.Add(logoutbttn)
        Panel1.Controls.Add(dashboard2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(profilebttn)
        Panel1.Controls.Add(coursemanagebttn)
        Panel1.Controls.Add(grademanagebttn)
        Panel1.Controls.Add(dashboardbttn)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(167, 657)
        Panel1.TabIndex = 0
        ' 
        ' activitylog2
        ' 
        activitylog2.BackColor = Color.White
        activitylog2.Controls.Add(Label5)
        activitylog2.Location = New Point(0, 290)
        activitylog2.Margin = New Padding(2, 2, 2, 2)
        activitylog2.Name = "activitylog2"
        activitylog2.Size = New Size(240, 42)
        activitylog2.TabIndex = 10
        activitylog2.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 7.0F)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(30, 14)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 18)
        Label5.TabIndex = 2
        Label5.Text = "ACTIVITY LOG"
        ' 
        ' coursemanage2
        ' 
        coursemanage2.BackColor = Color.White
        coursemanage2.Controls.Add(Label3)
        coursemanage2.Location = New Point(-2, 294)
        coursemanage2.Name = "coursemanage2"
        coursemanage2.Size = New Size(300, 53)
        coursemanage2.TabIndex = 8
        coursemanage2.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Banner", 7.0F)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(37, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 2
        Label3.Text = "DATA SUMMARY"
        ' 
        ' activitylog
        ' 
        activitylog.AutoSize = True
        activitylog.Font = New Font("Verdana", 6.0F)
        activitylog.ForeColor = Color.White
        activitylog.Location = New Point(34, 303)
        activitylog.Margin = New Padding(2, 0, 2, 0)
        activitylog.Name = "activitylog"
        activitylog.Size = New Size(85, 12)
        activitylog.TabIndex = 11
        activitylog.Text = "ACTIVITY LOG"
        ' 
        ' logout2
        ' 
        logout2.BackgroundImageLayout = ImageLayout.Stretch
        logout2.Location = New Point(30, 583)
        logout2.Margin = New Padding(2, 2, 2, 2)
        logout2.Name = "logout2"
        logout2.Size = New Size(46, 38)
        logout2.TabIndex = 10
        logout2.TabStop = False
        ' 
        ' profile2
        ' 
        profile2.BackColor = Color.White
        profile2.Controls.Add(Label4)
        profile2.Location = New Point(2, 348)
        profile2.Margin = New Padding(2, 2, 2, 2)
        profile2.Name = "profile2"
        profile2.Size = New Size(240, 42)
        profile2.TabIndex = 9
        profile2.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Banner", 7.0F)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(30, 14)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 18)
        Label4.TabIndex = 2
        Label4.Text = "PROFILE"
        ' 
        ' grademanagement2
        ' 
        grademanagement2.BackColor = Color.White
        grademanagement2.Controls.Add(Label13)
        grademanagement2.Location = New Point(0, 180)
        grademanagement2.Margin = New Padding(2, 2, 2, 2)
        grademanagement2.Name = "grademanagement2"
        grademanagement2.Size = New Size(240, 42)
        grademanagement2.TabIndex = 7
        grademanagement2.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Sitka Banner", 7.0F)
        Label13.ForeColor = Color.DarkGreen
        Label13.Location = New Point(30, 14)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(119, 18)
        Label13.TabIndex = 2
        Label13.Text = "GRADE MANAGEMENT"
        ' 
        ' logoutbttn
        ' 
        logoutbttn.AutoSize = True
        logoutbttn.Font = New Font("Verdana", 6.0F)
        logoutbttn.ForeColor = Color.White
        logoutbttn.Location = New Point(75, 596)
        logoutbttn.Margin = New Padding(2, 0, 2, 0)
        logoutbttn.Name = "logoutbttn"
        logoutbttn.Size = New Size(56, 12)
        logoutbttn.TabIndex = 7
        logoutbttn.Text = "LOG OUT"
        ' 
        ' dashboard2
        ' 
        dashboard2.BackColor = Color.White
        dashboard2.Controls.Add(Label7)
        dashboard2.Location = New Point(0, 126)
        dashboard2.Margin = New Padding(2, 2, 2, 2)
        dashboard2.Name = "dashboard2"
        dashboard2.Size = New Size(240, 42)
        dashboard2.TabIndex = 6
        dashboard2.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sitka Banner", 7.0F)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(30, 14)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 18)
        Label7.TabIndex = 2
        Label7.Text = "D A S H B O A R D"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 6.0F)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(46, 82)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 12)
        Label6.TabIndex = 5
        Label6.Text = "F A C U L T Y"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(34, 32)
        PictureBox3.Margin = New Padding(2, 2, 2, 2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(93, 44)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' profilebttn
        ' 
        profilebttn.AutoSize = True
        profilebttn.Font = New Font("Verdana", 6.0F)
        profilebttn.ForeColor = Color.White
        profilebttn.Location = New Point(34, 363)
        profilebttn.Margin = New Padding(2, 0, 2, 0)
        profilebttn.Name = "profilebttn"
        profilebttn.Size = New Size(52, 12)
        profilebttn.TabIndex = 3
        profilebttn.Text = "PROFILE"
        ' 
        ' coursemanagebttn
        ' 
        coursemanagebttn.AutoSize = True
        coursemanagebttn.Font = New Font("Verdana", 6.0F)
        coursemanagebttn.ForeColor = Color.White
        coursemanagebttn.Location = New Point(31, 244)
        coursemanagebttn.Margin = New Padding(2, 0, 2, 0)
        coursemanagebttn.Name = "coursemanagebttn"
        coursemanagebttn.Size = New Size(91, 12)
        coursemanagebttn.TabIndex = 2
        coursemanagebttn.Text = "DATA SUMMARY"
        ' 
        ' grademanagebttn
        ' 
        grademanagebttn.AutoSize = True
        grademanagebttn.Font = New Font("Verdana", 6.0F)
        grademanagebttn.ForeColor = Color.White
        grademanagebttn.Location = New Point(30, 190)
        grademanagebttn.Margin = New Padding(2, 0, 2, 0)
        grademanagebttn.Name = "grademanagebttn"
        grademanagebttn.Size = New Size(119, 12)
        grademanagebttn.TabIndex = 1
        grademanagebttn.Text = "GRADE MANAGEMENT"
        ' 
        ' dashboardbttn
        ' 
        dashboardbttn.AutoSize = True
        dashboardbttn.Font = New Font("Verdana", 6.0F)
        dashboardbttn.ForeColor = Color.White
        dashboardbttn.Location = New Point(30, 137)
        dashboardbttn.Margin = New Padding(2, 0, 2, 0)
        dashboardbttn.Name = "dashboardbttn"
        dashboardbttn.Size = New Size(74, 12)
        dashboardbttn.TabIndex = 0
        dashboardbttn.Text = "DASHBOARD"
        ' 
        ' notificationpanel
        ' 
        notificationpanel.BackColor = Color.Honeydew
        notificationpanel.Controls.Add(Label11)
        notificationpanel.Controls.Add(profmenu)
        notificationpanel.Controls.Add(Label1)
        notificationpanel.Controls.Add(PictureBox1)
        notificationpanel.Dock = DockStyle.Right
        notificationpanel.Location = New Point(1042, 0)
        notificationpanel.Margin = New Padding(2, 2, 2, 2)
        notificationpanel.Name = "notificationpanel"
        notificationpanel.Size = New Size(318, 657)
        notificationpanel.TabIndex = 1
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sitka Banner", 8.0F)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(19, 76)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 20)
        Label11.TabIndex = 4
        Label11.Text = "Notification"
        ' 
        ' profmenu
        ' 
        profmenu.BackColor = Color.White
        profmenu.BackgroundImageLayout = ImageLayout.Zoom
        profmenu.BorderRadius = 60
        profmenu.ForeColor = Color.Black
        profmenu.GradientAngle = 90.0F
        profmenu.GradientBottomColor = Color.Transparent
        profmenu.GradientTopColor = Color.Transparent
        profmenu.Image = CType(resources.GetObject("profmenu.Image"), Image)
        profmenu.Location = New Point(261, 14)
        profmenu.Name = "profmenu"
        profmenu.Size = New Size(37, 33)
        profmenu.SizeMode = PictureBoxSizeMode.StretchImage
        profmenu.TabIndex = 79
        profmenu.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 10.0F)
        Label1.Location = New Point(94, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 24)
        Label1.TabIndex = 2
        Label1.Text = "Sese, Mary Ynah Brazil A."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(19, 22)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 24)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(163, -1)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1197, 657)
        Panel2.TabIndex = 7
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1360, 657)
        Controls.Add(notificationpanel)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        activitylog2.ResumeLayout(False)
        activitylog2.PerformLayout()
        coursemanage2.ResumeLayout(False)
        coursemanage2.PerformLayout()
        CType(logout2, ComponentModel.ISupportInitialize).EndInit()
        profile2.ResumeLayout(False)
        profile2.PerformLayout()
        grademanagement2.ResumeLayout(False)
        grademanagement2.PerformLayout()
        dashboard2.ResumeLayout(False)
        dashboard2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        notificationpanel.ResumeLayout(False)
        notificationpanel.PerformLayout()
        CType(profmenu, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents notificationpanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashboardbttn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents profilebttn As Label
    Friend WithEvents coursemanagebttn As Label
    Friend WithEvents grademanagebttn As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dashboard2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents grademanagement2 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents logoutbttn As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents coursemanage2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents profile2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents profmenu As picture.CirclePicture
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logout2 As PictureBox
    Friend WithEvents activitylog2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents activitylog As Label

End Class
