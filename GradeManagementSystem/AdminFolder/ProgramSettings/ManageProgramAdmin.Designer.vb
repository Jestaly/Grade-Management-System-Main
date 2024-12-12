<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProgramAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProgramAdmin))
        dataView = New DataGridView()
        courseSecButton = New PictureBox()
        coursebttn = New Label()
        searchButtonPic = New PictureBox()
        searchfield = New PictureBox()
        searchProgramField = New TextBox()
        departmentlabel = New Label()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        addprogram = New PictureBox()
        addstudentbttn1 = New Label()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(courseSecButton, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(addprogram, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(83, 260)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1090, 520)
        dataView.TabIndex = 6
        ' 
        ' courseSecButton
        ' 
        courseSecButton.BackgroundImage = CType(resources.GetObject("courseSecButton.BackgroundImage"), Image)
        courseSecButton.BackgroundImageLayout = ImageLayout.Stretch
        courseSecButton.Location = New Point(1162, 42)
        courseSecButton.Name = "courseSecButton"
        courseSecButton.Size = New Size(61, 33)
        courseSecButton.TabIndex = 9
        courseSecButton.TabStop = False
        ' 
        ' coursebttn
        ' 
        coursebttn.AutoSize = True
        coursebttn.Font = New Font("Segoe UI", 6F)
        coursebttn.Location = New Point(1105, 51)
        coursebttn.Name = "coursebttn"
        coursebttn.Size = New Size(86, 15)
        coursebttn.TabIndex = 10
        coursebttn.Text = "Course Section"
        ' 
        ' searchButtonPic
        ' 
        searchButtonPic.BackgroundImage = CType(resources.GetObject("searchButtonPic.BackgroundImage"), Image)
        searchButtonPic.BackgroundImageLayout = ImageLayout.Stretch
        searchButtonPic.Location = New Point(458, 138)
        searchButtonPic.Name = "searchButtonPic"
        searchButtonPic.Size = New Size(58, 34)
        searchButtonPic.TabIndex = 78
        searchButtonPic.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(83, 116)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(453, 72)
        searchfield.TabIndex = 79
        searchfield.TabStop = False
        ' 
        ' searchProgramField
        ' 
        searchProgramField.BorderStyle = BorderStyle.None
        searchProgramField.Font = New Font("Segoe UI", 9F)
        searchProgramField.Location = New Point(112, 143)
        searchProgramField.Name = "searchProgramField"
        searchProgramField.PlaceholderText = "Search Program ID..."
        searchProgramField.Size = New Size(221, 24)
        searchProgramField.TabIndex = 80
        ' 
        ' departmentlabel
        ' 
        departmentlabel.AutoSize = True
        departmentlabel.Font = New Font("Microsoft Sans Serif", 12F)
        departmentlabel.ForeColor = Color.DarkGreen
        departmentlabel.Location = New Point(83, 46)
        departmentlabel.Name = "departmentlabel"
        departmentlabel.Size = New Size(404, 29)
        departmentlabel.TabIndex = 81
        departmentlabel.Text = "P R O G R A M  D E P A R T M E N T"
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(112, 231)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 83
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(82, 229)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(33, 29)
        reloadbttn.TabIndex = 82
        reloadbttn.TabStop = False
        ' 
        ' addprogram
        ' 
        addprogram.BackgroundImage = CType(resources.GetObject("addprogram.BackgroundImage"), Image)
        addprogram.BackgroundImageLayout = ImageLayout.Stretch
        addprogram.Location = New Point(1017, 221)
        addprogram.Name = "addprogram"
        addprogram.Size = New Size(42, 37)
        addprogram.TabIndex = 85
        addprogram.TabStop = False
        ' 
        ' addstudentbttn1
        ' 
        addstudentbttn1.AutoSize = True
        addstudentbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        addstudentbttn1.Location = New Point(1053, 229)
        addstudentbttn1.Name = "addstudentbttn1"
        addstudentbttn1.Size = New Size(120, 25)
        addstudentbttn1.TabIndex = 84
        addstudentbttn1.Text = "Add Program"
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(1030, 792)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(143, 25)
        modifybttn1.TabIndex = 87
        modifybttn1.Text = "Modify Program"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(994, 786)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 86
        modifybttn.TabStop = False
        ' 
        ' ManageProgramAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(addprogram)
        Controls.Add(addstudentbttn1)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(departmentlabel)
        Controls.Add(searchProgramField)
        Controls.Add(searchButtonPic)
        Controls.Add(searchfield)
        Controls.Add(coursebttn)
        Controls.Add(courseSecButton)
        Controls.Add(dataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageProgramAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProgramAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(courseSecButton, ComponentModel.ISupportInitialize).EndInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(addprogram, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents refreshButton As Button
    Friend WithEvents modifyProgramButton As Button
    Friend WithEvents addProgramButton As Button
    Friend WithEvents dataView As DataGridView
    Friend WithEvents courseSecButton As PictureBox
    Friend WithEvents coursebttn As Label
    Friend WithEvents searchButtonPic As PictureBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents searchProgramField As TextBox
    Friend WithEvents departmentlabel As Label
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents addprogram As PictureBox
    Friend WithEvents addstudentbttn1 As Label
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
End Class
