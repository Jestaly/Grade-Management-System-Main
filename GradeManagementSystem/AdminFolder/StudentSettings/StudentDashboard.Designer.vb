<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel2 = New Panel()
        courseinfo = New PictureBox()
        studinfo = New PictureBox()
        acadper = New PictureBox()
        settings = New PictureBox()
        Label1 = New Label()
        logoutbttn = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox9 = New PictureBox()
        Label3 = New Label()
        academicper = New PictureBox()
        Label2 = New Label()
        course = New PictureBox()
        PictureBox2 = New PictureBox()
        studentinfo = New PictureBox()
        DataGridView1 = New DataGridView()
        column = New DataGridViewButtonColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(courseinfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(studinfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(acadper, ComponentModel.ISupportInitialize).BeginInit()
        CType(settings, ComponentModel.ISupportInitialize).BeginInit()
        CType(logoutbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(academicper, ComponentModel.ISupportInitialize).BeginInit()
        CType(course, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentinfo, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Yellow
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(122, 649)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkGreen
        Panel2.Controls.Add(courseinfo)
        Panel2.Controls.Add(studinfo)
        Panel2.Controls.Add(acadper)
        Panel2.Controls.Add(settings)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(logoutbttn)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PictureBox9)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(academicper)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(course)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(studentinfo)
        Panel2.Location = New Point(10, -1)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(112, 647)
        Panel2.TabIndex = 1
        ' 
        ' courseinfo
        ' 
        courseinfo.BackColor = Color.Transparent
        courseinfo.BackgroundImageLayout = ImageLayout.Stretch
        courseinfo.Location = New Point(10, 216)
        courseinfo.Margin = New Padding(2)
        courseinfo.Name = "courseinfo"
        courseinfo.Size = New Size(149, 62)
        courseinfo.TabIndex = 21
        courseinfo.TabStop = False
        courseinfo.Visible = False
        ' 
        ' studinfo
        ' 
        studinfo.BackColor = Color.Transparent
        studinfo.BackgroundImageLayout = ImageLayout.Stretch
        studinfo.Location = New Point(10, 121)
        studinfo.Margin = New Padding(2)
        studinfo.Name = "studinfo"
        studinfo.Size = New Size(139, 62)
        studinfo.TabIndex = 20
        studinfo.TabStop = False
        studinfo.Visible = False
        ' 
        ' acadper
        ' 
        acadper.BackColor = Color.Transparent
        acadper.BackgroundImageLayout = ImageLayout.Stretch
        acadper.Location = New Point(12, 310)
        acadper.Margin = New Padding(2)
        acadper.Name = "acadper"
        acadper.Size = New Size(154, 65)
        acadper.TabIndex = 18
        acadper.TabStop = False
        acadper.Visible = False
        ' 
        ' settings
        ' 
        settings.BackColor = Color.Transparent
        settings.BackgroundImageLayout = ImageLayout.Stretch
        settings.Location = New Point(10, 405)
        settings.Margin = New Padding(2)
        settings.Name = "settings"
        settings.Size = New Size(142, 69)
        settings.TabIndex = 19
        settings.TabStop = False
        settings.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 579)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 18)
        Label1.TabIndex = 18
        Label1.Text = "LOG OUT"
        ' 
        ' logoutbttn
        ' 
        logoutbttn.BackColor = Color.Transparent
        logoutbttn.BackgroundImageLayout = ImageLayout.Stretch
        logoutbttn.Location = New Point(35, 538)
        logoutbttn.Margin = New Padding(2)
        logoutbttn.Name = "logoutbttn"
        logoutbttn.Size = New Size(46, 38)
        logoutbttn.TabIndex = 19
        logoutbttn.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 4.5F)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(22, 464)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 10)
        Label5.TabIndex = 17
        Label5.Text = "Security Settings"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 4.5F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(13, 360)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 10)
        Label4.TabIndex = 16
        Label4.Text = "Academic Performance"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox9.Location = New Point(31, 416)
        PictureBox9.Margin = New Padding(2)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(55, 50)
        PictureBox9.TabIndex = 16
        PictureBox9.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 4.5F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(16, 262)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 10)
        Label3.TabIndex = 15
        Label3.Text = "Course Information"
        ' 
        ' academicper
        ' 
        academicper.BackColor = Color.Transparent
        academicper.BackgroundImageLayout = ImageLayout.Stretch
        academicper.Location = New Point(25, 314)
        academicper.Margin = New Padding(2)
        academicper.Name = "academicper"
        academicper.Size = New Size(60, 45)
        academicper.TabIndex = 15
        academicper.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 4.5F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(14, 166)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 10)
        Label2.TabIndex = 14
        Label2.Text = "Student Information"
        ' 
        ' course
        ' 
        course.BackColor = Color.Transparent
        course.BackgroundImageLayout = ImageLayout.Stretch
        course.Location = New Point(27, 216)
        course.Margin = New Padding(2)
        course.Name = "course"
        course.Size = New Size(57, 47)
        course.TabIndex = 14
        course.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(22, 19)
        PictureBox2.Margin = New Padding(2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 64)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' studentinfo
        ' 
        studentinfo.BackColor = Color.Transparent
        studentinfo.BackgroundImageLayout = ImageLayout.Stretch
        studentinfo.Location = New Point(24, 121)
        studentinfo.Margin = New Padding(2)
        studentinfo.Name = "studentinfo"
        studentinfo.Size = New Size(60, 48)
        studentinfo.TabIndex = 13
        studentinfo.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Red
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Red
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {column})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Red
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(145, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(832, 517)
        DataGridView1.TabIndex = 1
        ' 
        ' column
        ' 
        column.HeaderText = "Column1"
        column.MinimumWidth = 6
        column.Name = "column"
        column.Resizable = DataGridViewTriState.True
        column.SortMode = DataGridViewColumnSortMode.Automatic
        column.Width = 125
        ' 
        ' StudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1322, 645)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2)
        Name = "StudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StudentDashboard"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(courseinfo, ComponentModel.ISupportInitialize).EndInit()
        CType(studinfo, ComponentModel.ISupportInitialize).EndInit()
        CType(acadper, ComponentModel.ISupportInitialize).EndInit()
        CType(settings, ComponentModel.ISupportInitialize).EndInit()
        CType(logoutbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(academicper, ComponentModel.ISupportInitialize).EndInit()
        CType(course, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(studentinfo, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents studentinfo As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents academicper As PictureBox
    Friend WithEvents course As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logoutbttn As PictureBox
    Friend WithEvents studinfo As PictureBox
    Friend WithEvents acadper As PictureBox
    Friend WithEvents settings As PictureBox
    Friend WithEvents courseinfo As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents column As DataGridViewButtonColumn
End Class
