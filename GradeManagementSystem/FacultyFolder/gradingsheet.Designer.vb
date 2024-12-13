<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradingSheet
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
        remarkDataView = New DataGridView()
        remarkColumn = New DataGridViewTextBoxColumn()
        equivalentDataView = New DataGridView()
        equivalentColumn = New DataGridViewTextBoxColumn()
        gradeDataView = New DataGridView()
        attendanceDataView = New DataGridView()
        presentColumn = New DataGridViewTextBoxColumn()
        absentColumn = New DataGridViewTextBoxColumn()
        deleteItemButton = New Button()
        addItemButton = New Button()
        submitButton = New Button()
        examDataView = New DataGridView()
        examColumn = New DataGridViewTextBoxColumn()
        quizDataView = New DataGridView()
        projectDataView = New DataGridView()
        studentInfoDataView = New DataGridView()
        TextBox33 = New TextBox()
        TextBox32 = New TextBox()
        TextBox31 = New TextBox()
        TextBox30 = New TextBox()
        TextBox29 = New TextBox()
        gradeMaxTextBox = New TextBox()
        TextBox27 = New TextBox()
        examMaxTextBox = New TextBox()
        TextBox25 = New TextBox()
        TextBox24 = New TextBox()
        TextBox23 = New TextBox()
        TextBox22 = New TextBox()
        TextBox21 = New TextBox()
        TextBox20 = New TextBox()
        TextBox18 = New TextBox()
        TextBox17 = New TextBox()
        TextBox16 = New TextBox()
        TextBox15 = New TextBox()
        AttMaxTextBox = New TextBox()
        TextBox10 = New TextBox()
        TextBox14 = New TextBox()
        TextBox13 = New TextBox()
        TextBox12 = New TextBox()
        TextBox11 = New TextBox()
        TextBox7 = New TextBox()
        profTextBox = New TextBox()
        Label17 = New Label()
        dayTextBox = New TextBox()
        Label15 = New Label()
        searchbttn = New PictureBox()
        courseTextBox = New TextBox()
        courseCodeTextBox = New TextBox()
        timeTextBox = New TextBox()
        Label14 = New Label()
        Label12 = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        semestralButton = New Button()
        finalButton = New Button()
        midtermButton = New Button()
        logoutButton = New Button()
        classChooseBox = New ComboBox()
        TextBox8 = New TextBox()
        attendanceButton = New Button()
        examButton = New Button()
        gradeColumn = New DataGridViewTextBoxColumn()
        CType(remarkDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(equivalentDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(gradeDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(attendanceDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(examDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(quizDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(projectDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentInfoDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' remarkDataView
        ' 
        remarkDataView.AllowUserToAddRows = False
        remarkDataView.AllowUserToDeleteRows = False
        remarkDataView.AllowUserToResizeColumns = False
        remarkDataView.AllowUserToResizeRows = False
        remarkDataView.BackgroundColor = Color.Honeydew
        remarkDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        remarkDataView.ColumnHeadersVisible = False
        remarkDataView.Columns.AddRange(New DataGridViewColumn() {remarkColumn})
        remarkDataView.Location = New Point(1066, 257)
        remarkDataView.Margin = New Padding(3, 2, 3, 2)
        remarkDataView.Name = "remarkDataView"
        remarkDataView.RowHeadersVisible = False
        remarkDataView.RowHeadersWidth = 62
        remarkDataView.ScrollBars = ScrollBars.Vertical
        remarkDataView.Size = New Size(74, 320)
        remarkDataView.TabIndex = 122
        ' 
        ' remarkColumn
        ' 
        remarkColumn.HeaderText = "Remark"
        remarkColumn.MinimumWidth = 6
        remarkColumn.Name = "remarkColumn"
        remarkColumn.Width = 75
        ' 
        ' equivalentDataView
        ' 
        equivalentDataView.AllowUserToAddRows = False
        equivalentDataView.AllowUserToDeleteRows = False
        equivalentDataView.AllowUserToResizeColumns = False
        equivalentDataView.AllowUserToResizeRows = False
        equivalentDataView.BackgroundColor = Color.Honeydew
        equivalentDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        equivalentDataView.ColumnHeadersVisible = False
        equivalentDataView.Columns.AddRange(New DataGridViewColumn() {equivalentColumn})
        equivalentDataView.Location = New Point(989, 257)
        equivalentDataView.Margin = New Padding(3, 2, 3, 2)
        equivalentDataView.Name = "equivalentDataView"
        equivalentDataView.RowHeadersVisible = False
        equivalentDataView.RowHeadersWidth = 62
        equivalentDataView.ScrollBars = ScrollBars.None
        equivalentDataView.Size = New Size(76, 320)
        equivalentDataView.TabIndex = 121
        ' 
        ' equivalentColumn
        ' 
        equivalentColumn.HeaderText = "Equivalent"
        equivalentColumn.MinimumWidth = 6
        equivalentColumn.Name = "equivalentColumn"
        equivalentColumn.Width = 76
        ' 
        ' gradeDataView
        ' 
        gradeDataView.AllowUserToAddRows = False
        gradeDataView.AllowUserToDeleteRows = False
        gradeDataView.AllowUserToResizeColumns = False
        gradeDataView.AllowUserToResizeRows = False
        gradeDataView.BackgroundColor = Color.Honeydew
        gradeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradeDataView.ColumnHeadersVisible = False
        gradeDataView.Columns.AddRange(New DataGridViewColumn() {gradeColumn})
        gradeDataView.Location = New Point(903, 257)
        gradeDataView.Margin = New Padding(3, 2, 3, 2)
        gradeDataView.Name = "gradeDataView"
        gradeDataView.RowHeadersVisible = False
        gradeDataView.RowHeadersWidth = 62
        gradeDataView.ScrollBars = ScrollBars.None
        gradeDataView.Size = New Size(85, 320)
        gradeDataView.TabIndex = 120
        ' 
        ' attendanceDataView
        ' 
        attendanceDataView.AllowUserToAddRows = False
        attendanceDataView.AllowUserToDeleteRows = False
        attendanceDataView.AllowUserToResizeColumns = False
        attendanceDataView.AllowUserToResizeRows = False
        attendanceDataView.BackgroundColor = Color.Honeydew
        attendanceDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        attendanceDataView.ColumnHeadersVisible = False
        attendanceDataView.Columns.AddRange(New DataGridViewColumn() {presentColumn, absentColumn})
        attendanceDataView.Location = New Point(324, 257)
        attendanceDataView.Margin = New Padding(3, 2, 3, 2)
        attendanceDataView.Name = "attendanceDataView"
        attendanceDataView.RowHeadersVisible = False
        attendanceDataView.RowHeadersWidth = 62
        attendanceDataView.ScrollBars = ScrollBars.None
        attendanceDataView.Size = New Size(132, 320)
        attendanceDataView.TabIndex = 119
        ' 
        ' presentColumn
        ' 
        presentColumn.HeaderText = "P"
        presentColumn.MinimumWidth = 6
        presentColumn.Name = "presentColumn"
        presentColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        presentColumn.Width = 67
        ' 
        ' absentColumn
        ' 
        absentColumn.HeaderText = "A"
        absentColumn.MinimumWidth = 6
        absentColumn.Name = "absentColumn"
        absentColumn.SortMode = DataGridViewColumnSortMode.NotSortable
        absentColumn.Width = 67
        ' 
        ' deleteItemButton
        ' 
        deleteItemButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        deleteItemButton.Location = New Point(1068, 594)
        deleteItemButton.Margin = New Padding(3, 2, 3, 2)
        deleteItemButton.Name = "deleteItemButton"
        deleteItemButton.Size = New Size(75, 27)
        deleteItemButton.TabIndex = 115
        deleteItemButton.Text = "Delete"
        deleteItemButton.UseVisualStyleBackColor = True
        ' 
        ' addItemButton
        ' 
        addItemButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        addItemButton.Location = New Point(959, 594)
        addItemButton.Margin = New Padding(3, 2, 3, 2)
        addItemButton.Name = "addItemButton"
        addItemButton.Size = New Size(104, 27)
        addItemButton.TabIndex = 114
        addItemButton.Text = "Add"
        addItemButton.UseVisualStyleBackColor = True
        ' 
        ' submitButton
        ' 
        submitButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submitButton.Location = New Point(1068, 141)
        submitButton.Margin = New Padding(3, 2, 3, 2)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(72, 27)
        submitButton.TabIndex = 113
        submitButton.Text = "Submit"
        submitButton.UseVisualStyleBackColor = True
        ' 
        ' examDataView
        ' 
        examDataView.AllowUserToAddRows = False
        examDataView.AllowUserToDeleteRows = False
        examDataView.AllowUserToResizeColumns = False
        examDataView.AllowUserToResizeRows = False
        examDataView.BackgroundColor = Color.Honeydew
        examDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        examDataView.ColumnHeadersVisible = False
        examDataView.Columns.AddRange(New DataGridViewColumn() {examColumn})
        examDataView.Location = New Point(825, 257)
        examDataView.Margin = New Padding(3, 2, 3, 2)
        examDataView.Name = "examDataView"
        examDataView.RowHeadersVisible = False
        examDataView.RowHeadersWidth = 62
        examDataView.ScrollBars = ScrollBars.None
        examDataView.Size = New Size(77, 320)
        examDataView.TabIndex = 111
        ' 
        ' examColumn
        ' 
        examColumn.HeaderText = "Exam"
        examColumn.MinimumWidth = 6
        examColumn.Name = "examColumn"
        examColumn.Width = 77
        ' 
        ' quizDataView
        ' 
        quizDataView.AllowUserToAddRows = False
        quizDataView.AllowUserToDeleteRows = False
        quizDataView.AllowUserToResizeColumns = False
        quizDataView.AllowUserToResizeRows = False
        quizDataView.BackgroundColor = Color.Honeydew
        quizDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        quizDataView.Location = New Point(457, 233)
        quizDataView.Margin = New Padding(3, 2, 3, 2)
        quizDataView.Name = "quizDataView"
        quizDataView.RowHeadersVisible = False
        quizDataView.RowHeadersWidth = 62
        quizDataView.ScrollBars = ScrollBars.Horizontal
        quizDataView.Size = New Size(183, 344)
        quizDataView.TabIndex = 110
        ' 
        ' projectDataView
        ' 
        projectDataView.AllowUserToAddRows = False
        projectDataView.AllowUserToDeleteRows = False
        projectDataView.AllowUserToResizeColumns = False
        projectDataView.AllowUserToResizeRows = False
        projectDataView.BackgroundColor = Color.Honeydew
        projectDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        projectDataView.Location = New Point(641, 233)
        projectDataView.Margin = New Padding(3, 2, 3, 2)
        projectDataView.Name = "projectDataView"
        projectDataView.RowHeadersVisible = False
        projectDataView.RowHeadersWidth = 62
        projectDataView.ScrollBars = ScrollBars.Horizontal
        projectDataView.Size = New Size(183, 344)
        projectDataView.TabIndex = 109
        ' 
        ' studentInfoDataView
        ' 
        studentInfoDataView.AllowUserToAddRows = False
        studentInfoDataView.AllowUserToDeleteRows = False
        studentInfoDataView.AllowUserToResizeColumns = False
        studentInfoDataView.AllowUserToResizeRows = False
        studentInfoDataView.BackgroundColor = Color.Honeydew
        studentInfoDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentInfoDataView.ColumnHeadersVisible = False
        studentInfoDataView.Location = New Point(85, 258)
        studentInfoDataView.Margin = New Padding(3, 2, 3, 2)
        studentInfoDataView.Name = "studentInfoDataView"
        studentInfoDataView.RowHeadersVisible = False
        studentInfoDataView.RowHeadersWidth = 62
        studentInfoDataView.ScrollBars = ScrollBars.Horizontal
        studentInfoDataView.Size = New Size(238, 319)
        studentInfoDataView.TabIndex = 108
        ' 
        ' TextBox33
        ' 
        TextBox33.BackColor = Color.Honeydew
        TextBox33.BorderStyle = BorderStyle.FixedSingle
        TextBox33.Enabled = False
        TextBox33.Font = New Font("Sitka Banner", 8F)
        TextBox33.Location = New Point(1066, 233)
        TextBox33.Margin = New Padding(3, 2, 3, 2)
        TextBox33.Name = "TextBox33"
        TextBox33.Size = New Size(74, 24)
        TextBox33.TabIndex = 107
        ' 
        ' TextBox32
        ' 
        TextBox32.BackColor = Color.Honeydew
        TextBox32.BorderStyle = BorderStyle.FixedSingle
        TextBox32.Enabled = False
        TextBox32.Font = New Font("Sitka Banner", 8F)
        TextBox32.Location = New Point(1066, 209)
        TextBox32.Margin = New Padding(3, 2, 3, 2)
        TextBox32.Name = "TextBox32"
        TextBox32.Size = New Size(74, 24)
        TextBox32.TabIndex = 106
        ' 
        ' TextBox31
        ' 
        TextBox31.BackColor = Color.Honeydew
        TextBox31.BorderStyle = BorderStyle.FixedSingle
        TextBox31.Enabled = False
        TextBox31.Font = New Font("Sitka Banner", 8F)
        TextBox31.Location = New Point(989, 233)
        TextBox31.Margin = New Padding(3, 2, 3, 2)
        TextBox31.Name = "TextBox31"
        TextBox31.Size = New Size(76, 24)
        TextBox31.TabIndex = 105
        ' 
        ' TextBox30
        ' 
        TextBox30.BackColor = Color.Honeydew
        TextBox30.BorderStyle = BorderStyle.FixedSingle
        TextBox30.Enabled = False
        TextBox30.Font = New Font("Sitka Banner", 8F)
        TextBox30.Location = New Point(989, 209)
        TextBox30.Margin = New Padding(3, 2, 3, 2)
        TextBox30.Name = "TextBox30"
        TextBox30.Size = New Size(76, 24)
        TextBox30.TabIndex = 104
        ' 
        ' TextBox29
        ' 
        TextBox29.BackColor = Color.Honeydew
        TextBox29.BorderStyle = BorderStyle.FixedSingle
        TextBox29.Enabled = False
        TextBox29.Font = New Font("Sitka Banner", 8F)
        TextBox29.Location = New Point(903, 233)
        TextBox29.Margin = New Padding(3, 2, 3, 2)
        TextBox29.Name = "TextBox29"
        TextBox29.Size = New Size(85, 24)
        TextBox29.TabIndex = 103
        ' 
        ' gradeMaxTextBox
        ' 
        gradeMaxTextBox.BackColor = Color.Honeydew
        gradeMaxTextBox.BorderStyle = BorderStyle.FixedSingle
        gradeMaxTextBox.Enabled = False
        gradeMaxTextBox.Font = New Font("Sitka Banner", 8F)
        gradeMaxTextBox.Location = New Point(903, 209)
        gradeMaxTextBox.Margin = New Padding(3, 2, 3, 2)
        gradeMaxTextBox.Name = "gradeMaxTextBox"
        gradeMaxTextBox.Size = New Size(85, 24)
        gradeMaxTextBox.TabIndex = 102
        gradeMaxTextBox.Text = "100"
        gradeMaxTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox27
        ' 
        TextBox27.BackColor = Color.Honeydew
        TextBox27.BorderStyle = BorderStyle.FixedSingle
        TextBox27.Enabled = False
        TextBox27.Font = New Font("Sitka Banner", 8F)
        TextBox27.Location = New Point(825, 233)
        TextBox27.Margin = New Padding(3, 2, 3, 2)
        TextBox27.Name = "TextBox27"
        TextBox27.Size = New Size(77, 24)
        TextBox27.TabIndex = 101
        ' 
        ' examMaxTextBox
        ' 
        examMaxTextBox.BackColor = Color.Honeydew
        examMaxTextBox.BorderStyle = BorderStyle.FixedSingle
        examMaxTextBox.Enabled = False
        examMaxTextBox.Font = New Font("Sitka Banner", 8F)
        examMaxTextBox.Location = New Point(825, 209)
        examMaxTextBox.Margin = New Padding(3, 2, 3, 2)
        examMaxTextBox.Name = "examMaxTextBox"
        examMaxTextBox.Size = New Size(77, 24)
        examMaxTextBox.TabIndex = 100
        examMaxTextBox.Text = "0"
        examMaxTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox25
        ' 
        TextBox25.BackColor = Color.Honeydew
        TextBox25.BorderStyle = BorderStyle.FixedSingle
        TextBox25.Enabled = False
        TextBox25.Font = New Font("Sitka Banner", 8F)
        TextBox25.Location = New Point(1066, 186)
        TextBox25.Margin = New Padding(3, 2, 3, 2)
        TextBox25.Name = "TextBox25"
        TextBox25.Size = New Size(74, 24)
        TextBox25.TabIndex = 99
        TextBox25.Text = "Remark"
        TextBox25.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox24
        ' 
        TextBox24.BackColor = Color.Honeydew
        TextBox24.BorderStyle = BorderStyle.FixedSingle
        TextBox24.Enabled = False
        TextBox24.Font = New Font("Sitka Banner", 8F)
        TextBox24.Location = New Point(989, 186)
        TextBox24.Margin = New Padding(3, 2, 3, 2)
        TextBox24.Name = "TextBox24"
        TextBox24.Size = New Size(76, 24)
        TextBox24.TabIndex = 98
        TextBox24.Text = "Equivalent"
        TextBox24.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox23
        ' 
        TextBox23.BackColor = Color.Honeydew
        TextBox23.BorderStyle = BorderStyle.FixedSingle
        TextBox23.Enabled = False
        TextBox23.Font = New Font("Sitka Banner", 8F)
        TextBox23.Location = New Point(903, 186)
        TextBox23.Margin = New Padding(3, 2, 3, 2)
        TextBox23.Name = "TextBox23"
        TextBox23.Size = New Size(85, 24)
        TextBox23.TabIndex = 97
        TextBox23.Text = "Midterm Grade"
        TextBox23.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox22
        ' 
        TextBox22.BackColor = Color.Honeydew
        TextBox22.BorderStyle = BorderStyle.FixedSingle
        TextBox22.Enabled = False
        TextBox22.Font = New Font("Sitka Banner", 8F)
        TextBox22.Location = New Point(825, 186)
        TextBox22.Margin = New Padding(3, 2, 3, 2)
        TextBox22.Name = "TextBox22"
        TextBox22.Size = New Size(77, 24)
        TextBox22.TabIndex = 96
        TextBox22.Text = "Midterm Exam"
        TextBox22.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox21
        ' 
        TextBox21.BackColor = Color.Honeydew
        TextBox21.BorderStyle = BorderStyle.FixedSingle
        TextBox21.Enabled = False
        TextBox21.Font = New Font("Sitka Banner", 8F)
        TextBox21.Location = New Point(641, 209)
        TextBox21.Margin = New Padding(3, 2, 3, 2)
        TextBox21.Name = "TextBox21"
        TextBox21.Size = New Size(183, 24)
        TextBox21.TabIndex = 95
        ' 
        ' TextBox20
        ' 
        TextBox20.BackColor = Color.Honeydew
        TextBox20.BorderStyle = BorderStyle.FixedSingle
        TextBox20.Enabled = False
        TextBox20.Font = New Font("Sitka Banner", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox20.ForeColor = Color.Black
        TextBox20.Location = New Point(641, 186)
        TextBox20.Margin = New Padding(3, 2, 3, 2)
        TextBox20.Name = "TextBox20"
        TextBox20.Size = New Size(183, 24)
        TextBox20.TabIndex = 94
        TextBox20.Text = "Projects"
        TextBox20.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox18
        ' 
        TextBox18.BackColor = Color.Honeydew
        TextBox18.BorderStyle = BorderStyle.FixedSingle
        TextBox18.Enabled = False
        TextBox18.Font = New Font("Sitka Banner", 8F)
        TextBox18.Location = New Point(161, 234)
        TextBox18.Margin = New Padding(3, 2, 3, 2)
        TextBox18.Name = "TextBox18"
        TextBox18.Size = New Size(162, 24)
        TextBox18.TabIndex = 92
        ' 
        ' TextBox17
        ' 
        TextBox17.BackColor = Color.Honeydew
        TextBox17.BorderStyle = BorderStyle.FixedSingle
        TextBox17.Enabled = False
        TextBox17.Font = New Font("Sitka Banner", 8F)
        TextBox17.Location = New Point(85, 234)
        TextBox17.Margin = New Padding(3, 2, 3, 2)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(75, 24)
        TextBox17.TabIndex = 91
        ' 
        ' TextBox16
        ' 
        TextBox16.BackColor = Color.Honeydew
        TextBox16.BorderStyle = BorderStyle.FixedSingle
        TextBox16.Enabled = False
        TextBox16.Font = New Font("Sitka Banner", 8F)
        TextBox16.Location = New Point(457, 209)
        TextBox16.Margin = New Padding(3, 2, 3, 2)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(183, 24)
        TextBox16.TabIndex = 90
        ' 
        ' TextBox15
        ' 
        TextBox15.BackColor = Color.Honeydew
        TextBox15.BorderStyle = BorderStyle.FixedSingle
        TextBox15.Enabled = False
        TextBox15.Font = New Font("Sitka Banner", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox15.ForeColor = Color.Black
        TextBox15.Location = New Point(457, 186)
        TextBox15.Margin = New Padding(3, 2, 3, 2)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(183, 24)
        TextBox15.TabIndex = 89
        TextBox15.Text = "Quizzes"
        TextBox15.TextAlign = HorizontalAlignment.Center
        ' 
        ' AttMaxTextBox
        ' 
        AttMaxTextBox.BackColor = Color.Honeydew
        AttMaxTextBox.BorderStyle = BorderStyle.FixedSingle
        AttMaxTextBox.Enabled = False
        AttMaxTextBox.Font = New Font("Sitka Banner", 8F)
        AttMaxTextBox.Location = New Point(324, 209)
        AttMaxTextBox.Margin = New Padding(3, 2, 3, 2)
        AttMaxTextBox.Name = "AttMaxTextBox"
        AttMaxTextBox.Size = New Size(132, 24)
        AttMaxTextBox.TabIndex = 88
        AttMaxTextBox.Text = "0"
        AttMaxTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox10
        ' 
        TextBox10.BackColor = Color.Honeydew
        TextBox10.BorderStyle = BorderStyle.FixedSingle
        TextBox10.Enabled = False
        TextBox10.Font = New Font("Sitka Banner", 8F)
        TextBox10.Location = New Point(324, 233)
        TextBox10.Margin = New Padding(3, 2, 3, 2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(67, 24)
        TextBox10.TabIndex = 87
        TextBox10.Text = "P"
        TextBox10.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox14
        ' 
        TextBox14.BackColor = Color.Honeydew
        TextBox14.BorderStyle = BorderStyle.FixedSingle
        TextBox14.Enabled = False
        TextBox14.Font = New Font("Sitka Banner", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox14.ForeColor = Color.Black
        TextBox14.Location = New Point(324, 186)
        TextBox14.Margin = New Padding(3, 2, 3, 2)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(132, 24)
        TextBox14.TabIndex = 86
        TextBox14.Text = "Attendance "
        TextBox14.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox13
        ' 
        TextBox13.BackColor = Color.Honeydew
        TextBox13.BorderStyle = BorderStyle.FixedSingle
        TextBox13.Enabled = False
        TextBox13.Font = New Font("Sitka Banner", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox13.ForeColor = Color.Black
        TextBox13.Location = New Point(161, 186)
        TextBox13.Margin = New Padding(3, 2, 3, 2)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(162, 24)
        TextBox13.TabIndex = 85
        TextBox13.Text = "Student Name"
        TextBox13.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox12
        ' 
        TextBox12.BackColor = Color.Honeydew
        TextBox12.BorderStyle = BorderStyle.FixedSingle
        TextBox12.Enabled = False
        TextBox12.Location = New Point(161, 209)
        TextBox12.Margin = New Padding(3, 2, 3, 2)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(162, 27)
        TextBox12.TabIndex = 84
        ' 
        ' TextBox11
        ' 
        TextBox11.BackColor = Color.Honeydew
        TextBox11.BorderStyle = BorderStyle.FixedSingle
        TextBox11.Enabled = False
        TextBox11.Font = New Font("Sitka Banner", 8F)
        TextBox11.Location = New Point(391, 233)
        TextBox11.Margin = New Padding(3, 2, 3, 2)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(65, 24)
        TextBox11.TabIndex = 83
        TextBox11.Text = "A"
        TextBox11.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Honeydew
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Enabled = False
        TextBox7.Font = New Font("Sitka Banner", 8F)
        TextBox7.Location = New Point(85, 186)
        TextBox7.Margin = New Padding(3, 2, 3, 2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(75, 24)
        TextBox7.TabIndex = 81
        TextBox7.Text = "Student ID"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' profTextBox
        ' 
        profTextBox.BackColor = Color.Honeydew
        profTextBox.BorderStyle = BorderStyle.FixedSingle
        profTextBox.Enabled = False
        profTextBox.Location = New Point(900, 73)
        profTextBox.Margin = New Padding(3, 2, 3, 2)
        profTextBox.Name = "profTextBox"
        profTextBox.Size = New Size(163, 27)
        profTextBox.TabIndex = 80
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Sitka Banner", 9F)
        Label17.ForeColor = Color.DarkGreen
        Label17.Location = New Point(509, 99)
        Label17.Name = "Label17"
        Label17.Size = New Size(74, 21)
        Label17.TabIndex = 79
        Label17.Text = "Class Code:"
        ' 
        ' dayTextBox
        ' 
        dayTextBox.BackColor = Color.Honeydew
        dayTextBox.BorderStyle = BorderStyle.FixedSingle
        dayTextBox.Enabled = False
        dayTextBox.Location = New Point(588, 123)
        dayTextBox.Margin = New Padding(3, 2, 3, 2)
        dayTextBox.Name = "dayTextBox"
        dayTextBox.Size = New Size(142, 27)
        dayTextBox.TabIndex = 77
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Sitka Banner", 9F)
        Label15.ForeColor = Color.DarkGreen
        Label15.Location = New Point(475, 124)
        Label15.Name = "Label15"
        Label15.Size = New Size(109, 21)
        Label15.TabIndex = 75
        Label15.Text = "Lecture Schedule:"
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(357, 70)
        searchbttn.Margin = New Padding(3, 2, 3, 2)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(27, 25)
        searchbttn.TabIndex = 74
        searchbttn.TabStop = False
        ' 
        ' courseTextBox
        ' 
        courseTextBox.BackColor = Color.Honeydew
        courseTextBox.BorderStyle = BorderStyle.FixedSingle
        courseTextBox.Enabled = False
        courseTextBox.Location = New Point(196, 122)
        courseTextBox.Margin = New Padding(3, 2, 3, 2)
        courseTextBox.Name = "courseTextBox"
        courseTextBox.Size = New Size(189, 27)
        courseTextBox.TabIndex = 73
        ' 
        ' courseCodeTextBox
        ' 
        courseCodeTextBox.BackColor = Color.Honeydew
        courseCodeTextBox.BorderStyle = BorderStyle.FixedSingle
        courseCodeTextBox.Enabled = False
        courseCodeTextBox.Location = New Point(196, 96)
        courseCodeTextBox.Margin = New Padding(3, 2, 3, 2)
        courseCodeTextBox.Name = "courseCodeTextBox"
        courseCodeTextBox.Size = New Size(189, 27)
        courseCodeTextBox.TabIndex = 72
        ' 
        ' timeTextBox
        ' 
        timeTextBox.BackColor = Color.Honeydew
        timeTextBox.BorderStyle = BorderStyle.FixedSingle
        timeTextBox.Enabled = False
        timeTextBox.Location = New Point(196, 70)
        timeTextBox.Margin = New Padding(3, 2, 3, 2)
        timeTextBox.Name = "timeTextBox"
        timeTextBox.Size = New Size(159, 27)
        timeTextBox.TabIndex = 71
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Sitka Banner", 9F)
        Label14.ForeColor = Color.DarkGreen
        Label14.Location = New Point(96, 123)
        Label14.Name = "Label14"
        Label14.Size = New Size(90, 21)
        Label14.TabIndex = 70
        Label14.Text = "Course Name:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Sitka Banner", 9F)
        Label12.ForeColor = Color.DarkGreen
        Label12.Location = New Point(101, 100)
        Label12.Name = "Label12"
        Label12.Size = New Size(85, 21)
        Label12.TabIndex = 69
        Label12.Text = "Course Code:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Banner", 9F)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(89, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 21)
        Label5.TabIndex = 68
        Label5.Text = "Schedule Time:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Banner", 12F)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(48, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 29)
        Label2.TabIndex = 67
        Label2.Text = "Grading Sheet"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 9F)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(828, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 21)
        Label1.TabIndex = 125
        Label1.Text = "Professor:"
        ' 
        ' semestralButton
        ' 
        semestralButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        semestralButton.Location = New Point(285, 592)
        semestralButton.Name = "semestralButton"
        semestralButton.Size = New Size(93, 29)
        semestralButton.TabIndex = 130
        semestralButton.Text = "Semestral"
        semestralButton.UseVisualStyleBackColor = True
        ' 
        ' finalButton
        ' 
        finalButton.Enabled = False
        finalButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        finalButton.Location = New Point(187, 592)
        finalButton.Name = "finalButton"
        finalButton.Size = New Size(93, 29)
        finalButton.TabIndex = 129
        finalButton.Text = "Finals"
        finalButton.UseVisualStyleBackColor = True
        ' 
        ' midtermButton
        ' 
        midtermButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        midtermButton.Location = New Point(85, 592)
        midtermButton.Name = "midtermButton"
        midtermButton.Size = New Size(93, 29)
        midtermButton.TabIndex = 128
        midtermButton.Text = "Midterm"
        midtermButton.UseVisualStyleBackColor = True
        ' 
        ' logoutButton
        ' 
        logoutButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutButton.Location = New Point(1059, 21)
        logoutButton.Margin = New Padding(3, 2, 3, 2)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(100, 29)
        logoutButton.TabIndex = 131
        logoutButton.Text = "Logout"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' classChooseBox
        ' 
        classChooseBox.BackColor = Color.Honeydew
        classChooseBox.DropDownStyle = ComboBoxStyle.DropDownList
        classChooseBox.Font = New Font("Sitka Banner", 8F)
        classChooseBox.FormattingEnabled = True
        classChooseBox.Location = New Point(588, 97)
        classChooseBox.Name = "classChooseBox"
        classChooseBox.Size = New Size(142, 27)
        classChooseBox.TabIndex = 133
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.Honeydew
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Enabled = False
        TextBox8.Location = New Point(85, 209)
        TextBox8.Margin = New Padding(3, 2, 3, 2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(75, 27)
        TextBox8.TabIndex = 82
        ' 
        ' attendanceButton
        ' 
        attendanceButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        attendanceButton.Location = New Point(849, 594)
        attendanceButton.Margin = New Padding(3, 2, 3, 2)
        attendanceButton.Name = "attendanceButton"
        attendanceButton.Size = New Size(104, 27)
        attendanceButton.TabIndex = 134
        attendanceButton.Text = "Attendance"
        attendanceButton.UseVisualStyleBackColor = True
        ' 
        ' examButton
        ' 
        examButton.Font = New Font("Sitka Text", 9F, FontStyle.Bold)
        examButton.Location = New Point(739, 594)
        examButton.Margin = New Padding(3, 2, 3, 2)
        examButton.Name = "examButton"
        examButton.Size = New Size(104, 27)
        examButton.TabIndex = 135
        examButton.Text = "Exam"
        examButton.UseVisualStyleBackColor = True
        ' 
        ' gradeColumn
        ' 
        gradeColumn.HeaderText = "Grade"
        gradeColumn.MinimumWidth = 6
        gradeColumn.Name = "gradeColumn"
        gradeColumn.ReadOnly = True
        gradeColumn.Width = 85
        ' 
        ' GradingSheet
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1191, 657)
        Controls.Add(examButton)
        Controls.Add(attendanceButton)
        Controls.Add(classChooseBox)
        Controls.Add(logoutButton)
        Controls.Add(semestralButton)
        Controls.Add(finalButton)
        Controls.Add(midtermButton)
        Controls.Add(Label1)
        Controls.Add(remarkDataView)
        Controls.Add(equivalentDataView)
        Controls.Add(gradeDataView)
        Controls.Add(attendanceDataView)
        Controls.Add(deleteItemButton)
        Controls.Add(addItemButton)
        Controls.Add(submitButton)
        Controls.Add(examDataView)
        Controls.Add(quizDataView)
        Controls.Add(projectDataView)
        Controls.Add(studentInfoDataView)
        Controls.Add(TextBox33)
        Controls.Add(TextBox32)
        Controls.Add(TextBox31)
        Controls.Add(TextBox30)
        Controls.Add(TextBox29)
        Controls.Add(gradeMaxTextBox)
        Controls.Add(TextBox27)
        Controls.Add(examMaxTextBox)
        Controls.Add(TextBox25)
        Controls.Add(TextBox24)
        Controls.Add(TextBox23)
        Controls.Add(TextBox22)
        Controls.Add(TextBox21)
        Controls.Add(TextBox20)
        Controls.Add(TextBox18)
        Controls.Add(TextBox17)
        Controls.Add(TextBox16)
        Controls.Add(TextBox15)
        Controls.Add(AttMaxTextBox)
        Controls.Add(TextBox10)
        Controls.Add(TextBox14)
        Controls.Add(TextBox13)
        Controls.Add(TextBox12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(profTextBox)
        Controls.Add(Label17)
        Controls.Add(dayTextBox)
        Controls.Add(Label15)
        Controls.Add(searchbttn)
        Controls.Add(courseTextBox)
        Controls.Add(courseCodeTextBox)
        Controls.Add(timeTextBox)
        Controls.Add(Label14)
        Controls.Add(Label12)
        Controls.Add(Label5)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "GradingSheet"
        StartPosition = FormStartPosition.CenterParent
        Text = "gradingsheet"
        CType(remarkDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(equivalentDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(gradeDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(attendanceDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(examDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(quizDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(projectDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(studentInfoDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents remarkDataView As DataGridView
    Friend WithEvents equivalentDataView As DataGridView
    Friend WithEvents gradeDataView As DataGridView
    Friend WithEvents attendanceDataView As DataGridView
    Friend WithEvents deleteItemButton As Button
    Friend WithEvents addItemButton As Button
    Friend WithEvents submitButton As Button
    Friend WithEvents examDataView As DataGridView
    Friend WithEvents quizDataView As DataGridView
    Friend WithEvents projectDataView As DataGridView
    Friend WithEvents studentInfoDataView As DataGridView
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents gradeMaxTextBox As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents examMaxTextBox As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents AttMaxTextBox As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents profTextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents dayTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents courseTextBox As TextBox
    Friend WithEvents courseCodeTextBox As TextBox
    Friend WithEvents timeTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents semestralButton As Button
    Friend WithEvents finalButton As Button
    Friend WithEvents midtermButton As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents classChooseBox As ComboBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents remarkColumn As DataGridViewTextBoxColumn
    Friend WithEvents equivalentColumn As DataGridViewTextBoxColumn
    Friend WithEvents examColumn As DataGridViewTextBoxColumn
    Friend WithEvents attendanceButton As Button
    Friend WithEvents presentColumn As DataGridViewTextBoxColumn
    Friend WithEvents absentColumn As DataGridViewTextBoxColumn
    Friend WithEvents examButton As Button
    Friend WithEvents gradeColumn As DataGridViewTextBoxColumn
End Class
