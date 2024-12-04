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
        refreshButton = New Button()
        quizDataView = New DataGridView()
        attendanceDataView = New DataGridView()
        studentInfoDataView = New DataGridView()
        classChooseBox = New DomainUpDown()
        projectDataView = New DataGridView()
        examDataView = New DataGridView()
        gradeDataView = New DataGridView()
        equivalentDataView = New DataGridView()
        remarkDataView = New DataGridView()
        midtermButton = New Button()
        finalButton = New Button()
        addItemButton = New Button()
        deleteItemButton = New Button()
        courseTextBox = New TextBox()
        profTextBox = New TextBox()
        timeTextBox = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        Panel6 = New Panel()
        Label6 = New Label()
        Panel7 = New Panel()
        Label7 = New Label()
        Panel8 = New Panel()
        Label8 = New Label()
        logoutButton = New Button()
        dayTextBox = New TextBox()
        semestralButton = New Button()
        CType(quizDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(attendanceDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentInfoDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(projectDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(examDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(gradeDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(equivalentDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(remarkDataView, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(98, 99)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 12
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' quizDataView
        ' 
        quizDataView.BackgroundColor = SystemColors.ButtonFace
        quizDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        quizDataView.Location = New Point(562, 170)
        quizDataView.Name = "quizDataView"
        quizDataView.RowHeadersVisible = False
        quizDataView.RowHeadersWidth = 51
        quizDataView.ScrollBars = ScrollBars.Horizontal
        quizDataView.Size = New Size(197, 400)
        quizDataView.TabIndex = 11
        ' 
        ' attendanceDataView
        ' 
        attendanceDataView.BackgroundColor = SystemColors.ButtonFace
        attendanceDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        attendanceDataView.Location = New Point(395, 170)
        attendanceDataView.Name = "attendanceDataView"
        attendanceDataView.RowHeadersVisible = False
        attendanceDataView.RowHeadersWidth = 51
        attendanceDataView.ScrollBars = ScrollBars.None
        attendanceDataView.Size = New Size(166, 400)
        attendanceDataView.TabIndex = 10
        ' 
        ' studentInfoDataView
        ' 
        studentInfoDataView.BackgroundColor = SystemColors.ButtonFace
        studentInfoDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentInfoDataView.Location = New Point(98, 170)
        studentInfoDataView.Name = "studentInfoDataView"
        studentInfoDataView.RowHeadersVisible = False
        studentInfoDataView.RowHeadersWidth = 51
        studentInfoDataView.ScrollBars = ScrollBars.Horizontal
        studentInfoDataView.Size = New Size(296, 400)
        studentInfoDataView.TabIndex = 9
        ' 
        ' classChooseBox
        ' 
        classChooseBox.Location = New Point(603, 58)
        classChooseBox.Name = "classChooseBox"
        classChooseBox.ReadOnly = True
        classChooseBox.Size = New Size(195, 27)
        classChooseBox.TabIndex = 13
        ' 
        ' projectDataView
        ' 
        projectDataView.BackgroundColor = SystemColors.ButtonFace
        projectDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        projectDataView.Location = New Point(760, 170)
        projectDataView.Name = "projectDataView"
        projectDataView.RowHeadersVisible = False
        projectDataView.RowHeadersWidth = 51
        projectDataView.ScrollBars = ScrollBars.Horizontal
        projectDataView.Size = New Size(197, 400)
        projectDataView.TabIndex = 14
        ' 
        ' examDataView
        ' 
        examDataView.BackgroundColor = SystemColors.ButtonFace
        examDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        examDataView.Location = New Point(958, 170)
        examDataView.Name = "examDataView"
        examDataView.RowHeadersVisible = False
        examDataView.RowHeadersWidth = 51
        examDataView.ScrollBars = ScrollBars.None
        examDataView.Size = New Size(81, 400)
        examDataView.TabIndex = 15
        ' 
        ' gradeDataView
        ' 
        gradeDataView.BackgroundColor = SystemColors.ButtonFace
        gradeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradeDataView.Location = New Point(1040, 170)
        gradeDataView.Name = "gradeDataView"
        gradeDataView.RowHeadersVisible = False
        gradeDataView.RowHeadersWidth = 51
        gradeDataView.ScrollBars = ScrollBars.None
        gradeDataView.Size = New Size(81, 400)
        gradeDataView.TabIndex = 16
        ' 
        ' equivalentDataView
        ' 
        equivalentDataView.BackgroundColor = SystemColors.ButtonFace
        equivalentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        equivalentDataView.Location = New Point(1122, 170)
        equivalentDataView.Name = "equivalentDataView"
        equivalentDataView.RowHeadersVisible = False
        equivalentDataView.RowHeadersWidth = 51
        equivalentDataView.ScrollBars = ScrollBars.None
        equivalentDataView.Size = New Size(98, 400)
        equivalentDataView.TabIndex = 17
        ' 
        ' remarkDataView
        ' 
        remarkDataView.BackgroundColor = SystemColors.ButtonFace
        remarkDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        remarkDataView.Location = New Point(1221, 170)
        remarkDataView.Name = "remarkDataView"
        remarkDataView.RowHeadersVisible = False
        remarkDataView.RowHeadersWidth = 51
        remarkDataView.ScrollBars = ScrollBars.Vertical
        remarkDataView.Size = New Size(99, 400)
        remarkDataView.TabIndex = 18
        ' 
        ' midtermButton
        ' 
        midtermButton.Location = New Point(98, 576)
        midtermButton.Name = "midtermButton"
        midtermButton.Size = New Size(94, 29)
        midtermButton.TabIndex = 19
        midtermButton.Text = "Midterm"
        midtermButton.UseVisualStyleBackColor = True
        ' 
        ' finalButton
        ' 
        finalButton.Location = New Point(198, 576)
        finalButton.Name = "finalButton"
        finalButton.Size = New Size(94, 29)
        finalButton.TabIndex = 20
        finalButton.Text = "Finals"
        finalButton.UseVisualStyleBackColor = True
        ' 
        ' addItemButton
        ' 
        addItemButton.Location = New Point(1106, 576)
        addItemButton.Name = "addItemButton"
        addItemButton.Size = New Size(104, 29)
        addItemButton.TabIndex = 21
        addItemButton.Text = "Add Item"
        addItemButton.UseVisualStyleBackColor = True
        ' 
        ' deleteItemButton
        ' 
        deleteItemButton.Location = New Point(1216, 576)
        deleteItemButton.Name = "deleteItemButton"
        deleteItemButton.Size = New Size(104, 29)
        deleteItemButton.TabIndex = 22
        deleteItemButton.Text = "Delete Item"
        deleteItemButton.UseVisualStyleBackColor = True
        ' 
        ' courseTextBox
        ' 
        courseTextBox.Enabled = False
        courseTextBox.Location = New Point(283, 90)
        courseTextBox.Name = "courseTextBox"
        courseTextBox.Size = New Size(195, 27)
        courseTextBox.TabIndex = 23
        ' 
        ' profTextBox
        ' 
        profTextBox.Enabled = False
        profTextBox.Location = New Point(283, 57)
        profTextBox.Name = "profTextBox"
        profTextBox.Size = New Size(195, 27)
        profTextBox.TabIndex = 24
        ' 
        ' timeTextBox
        ' 
        timeTextBox.Enabled = False
        timeTextBox.Location = New Point(603, 90)
        timeTextBox.Name = "timeTextBox"
        timeTextBox.Size = New Size(195, 27)
        timeTextBox.TabIndex = 26
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LimeGreen
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(98, 134)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(296, 36)
        Panel1.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 20)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT INFORMATION"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LimeGreen
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(395, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(166, 36)
        Panel2.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 20)
        Label2.TabIndex = 1
        Label2.Text = "ATTENDANCE"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LimeGreen
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(562, 134)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(197, 36)
        Panel3.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 2
        Label3.Text = "QUIZZES"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LimeGreen
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(760, 134)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(197, 36)
        Panel4.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(57, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 2
        Label4.Text = "PROJECTS"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LimeGreen
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(958, 134)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(81, 36)
        Panel5.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 3
        Label5.Text = "EXAM"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.LimeGreen
        Panel6.Controls.Add(Label6)
        Panel6.Location = New Point(1040, 134)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(81, 36)
        Panel6.TabIndex = 32
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 4
        Label6.Text = "GRADE"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.LimeGreen
        Panel7.Controls.Add(Label7)
        Panel7.Location = New Point(1122, 134)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(98, 36)
        Panel7.TabIndex = 33
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(8, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 17)
        Label7.TabIndex = 5
        Label7.Text = "EQUIVALENT"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.LimeGreen
        Panel8.Controls.Add(Label8)
        Panel8.Location = New Point(1221, 134)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(99, 36)
        Panel8.TabIndex = 34
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(75, 20)
        Label8.TabIndex = 6
        Label8.Text = "REMARKS"
        ' 
        ' logoutButton
        ' 
        logoutButton.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        logoutButton.ForeColor = SystemColors.Control
        logoutButton.Location = New Point(1233, 26)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(115, 36)
        logoutButton.TabIndex = 35
        logoutButton.Text = "Logout"
        logoutButton.UseVisualStyleBackColor = False
        ' 
        ' dayTextBox
        ' 
        dayTextBox.Enabled = False
        dayTextBox.Location = New Point(804, 90)
        dayTextBox.Name = "dayTextBox"
        dayTextBox.Size = New Size(111, 27)
        dayTextBox.TabIndex = 36
        ' 
        ' semestralButton
        ' 
        semestralButton.Location = New Point(298, 576)
        semestralButton.Name = "semestralButton"
        semestralButton.Size = New Size(94, 29)
        semestralButton.TabIndex = 37
        semestralButton.Text = "Semestral"
        semestralButton.UseVisualStyleBackColor = True
        ' 
        ' ProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GrayText
        ClientSize = New Size(1419, 650)
        Controls.Add(semestralButton)
        Controls.Add(dayTextBox)
        Controls.Add(logoutButton)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(timeTextBox)
        Controls.Add(profTextBox)
        Controls.Add(courseTextBox)
        Controls.Add(deleteItemButton)
        Controls.Add(addItemButton)
        Controls.Add(finalButton)
        Controls.Add(midtermButton)
        Controls.Add(remarkDataView)
        Controls.Add(equivalentDataView)
        Controls.Add(gradeDataView)
        Controls.Add(examDataView)
        Controls.Add(projectDataView)
        Controls.Add(classChooseBox)
        Controls.Add(refreshButton)
        Controls.Add(quizDataView)
        Controls.Add(attendanceDataView)
        Controls.Add(studentInfoDataView)
        Name = "ProfessorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfessorForm"
        CType(quizDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(attendanceDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(studentInfoDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(projectDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(examDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(gradeDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(equivalentDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(remarkDataView, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents quizDataView As DataGridView
    Friend WithEvents attendanceDataView As DataGridView
    Friend WithEvents studentInfoDataView As DataGridView
    Friend WithEvents classChooseBox As DomainUpDown
    Friend WithEvents projectDataView As DataGridView
    Friend WithEvents examDataView As DataGridView
    Friend WithEvents gradeDataView As DataGridView
    Friend WithEvents equivalentDataView As DataGridView
    Friend WithEvents remarkDataView As DataGridView
    Friend WithEvents midtermButton As Button
    Friend WithEvents finalButton As Button
    Friend WithEvents addItemButton As Button
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents courseTextBox As TextBox
    Friend WithEvents profTextBox As TextBox
    Friend WithEvents timeTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents logoutButton As Button
    Friend WithEvents dayTextBox As TextBox
    Friend WithEvents semestralButton As Button
End Class
