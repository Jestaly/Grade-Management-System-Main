<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudentAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudentAdmin))
        dataView = New DataGridView()
        departmentlabel = New Label()
        searchStudentField = New TextBox()
        searchbttn = New PictureBox()
        searchfield = New PictureBox()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        addstudentbttn = New PictureBox()
        addstudentbttn1 = New Label()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(addstudentbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(70, 299)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1120, 488)
        dataView.TabIndex = 4
        ' 
        ' departmentlabel
        ' 
        departmentlabel.AutoSize = True
        departmentlabel.Font = New Font("Microsoft Sans Serif", 12F)
        departmentlabel.ForeColor = Color.DarkGreen
        departmentlabel.Location = New Point(70, 55)
        departmentlabel.Name = "departmentlabel"
        departmentlabel.Size = New Size(341, 29)
        departmentlabel.TabIndex = 74
        departmentlabel.Text = "S T U D E N T  R E G I S T R Y"
        ' 
        ' searchStudentField
        ' 
        searchStudentField.BorderStyle = BorderStyle.None
        searchStudentField.Location = New Point(96, 153)
        searchStudentField.Name = "searchStudentField"
        searchStudentField.PlaceholderText = "Search Student ID..."
        searchStudentField.Size = New Size(199, 24)
        searchStudentField.TabIndex = 77
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(407, 148)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(52, 35)
        searchbttn.TabIndex = 75
        searchbttn.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(70, 125)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(408, 75)
        searchfield.TabIndex = 76
        searchfield.TabStop = False
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(96, 264)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 79
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(69, 262)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 78
        reloadbttn.TabStop = False
        ' 
        ' addstudentbttn
        ' 
        addstudentbttn.BackgroundImage = CType(resources.GetObject("addstudentbttn.BackgroundImage"), Image)
        addstudentbttn.BackgroundImageLayout = ImageLayout.Stretch
        addstudentbttn.Location = New Point(1041, 259)
        addstudentbttn.Name = "addstudentbttn"
        addstudentbttn.Size = New Size(38, 38)
        addstudentbttn.TabIndex = 81
        addstudentbttn.TabStop = False
        ' 
        ' addstudentbttn1
        ' 
        addstudentbttn1.AutoSize = True
        addstudentbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        addstudentbttn1.Location = New Point(1078, 264)
        addstudentbttn1.Name = "addstudentbttn1"
        addstudentbttn1.Size = New Size(112, 25)
        addstudentbttn1.TabIndex = 80
        addstudentbttn1.Text = "Add Student"
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(1055, 802)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(135, 25)
        modifybttn1.TabIndex = 83
        modifybttn1.Text = "Modify Student"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(1021, 794)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 82
        modifybttn.TabStop = False
        ' 
        ' ManageStudentAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(addstudentbttn)
        Controls.Add(addstudentbttn1)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(searchStudentField)
        Controls.Add(searchbttn)
        Controls.Add(searchfield)
        Controls.Add(departmentlabel)
        Controls.Add(dataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageStudentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "  "
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(addstudentbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents dataView As DataGridView
    Friend WithEvents departmentlabel As Label
    Friend WithEvents searchStudentField As TextBox
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents addstudentbttn As PictureBox
    Friend WithEvents addstudentbttn1 As Label
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
End Class
