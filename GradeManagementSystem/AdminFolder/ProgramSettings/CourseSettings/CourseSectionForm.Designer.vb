<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseSectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CourseSectionForm))
        dataView = New DataGridView()
        backbttn = New PictureBox()
        searchProgramField = New TextBox()
        searchfield = New PictureBox()
        Label11 = New Label()
        addcoursebttn = New PictureBox()
        addcourse1 = New Label()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        searchButtonPic = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(addcoursebttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(99, 238)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1058, 547)
        dataView.TabIndex = 13
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(58, 36)
        backbttn.TabIndex = 38
        backbttn.TabStop = False
        ' 
        ' searchProgramField
        ' 
        searchProgramField.BorderStyle = BorderStyle.None
        searchProgramField.Font = New Font("Segoe UI", 9.0F)
        searchProgramField.Location = New Point(126, 120)
        searchProgramField.Name = "searchProgramField"
        searchProgramField.PlaceholderText = "Search Program ID..."
        searchProgramField.Size = New Size(197, 24)
        searchProgramField.TabIndex = 83
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(99, 92)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(380, 76)
        searchfield.TabIndex = 82
        searchfield.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(108, 45)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(223, 25)
        Label11.TabIndex = 84
        Label11.Text = "C O U R S E   S E C T I O N"
        ' 
        ' addcoursebttn
        ' 
        addcoursebttn.BackgroundImage = CType(resources.GetObject("addcoursebttn.BackgroundImage"), Image)
        addcoursebttn.BackgroundImageLayout = ImageLayout.Stretch
        addcoursebttn.Location = New Point(1016, 198)
        addcoursebttn.Name = "addcoursebttn"
        addcoursebttn.Size = New Size(38, 38)
        addcoursebttn.TabIndex = 88
        addcoursebttn.TabStop = False
        ' 
        ' addcourse1
        ' 
        addcourse1.AutoSize = True
        addcourse1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        addcourse1.Location = New Point(1051, 205)
        addcourse1.Name = "addcourse1"
        addcourse1.Size = New Size(106, 25)
        addcourse1.TabIndex = 87
        addcourse1.Text = "Add Course"
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(134, 205)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 86
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(102, 203)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 85
        reloadbttn.TabStop = False
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(1028, 800)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(129, 25)
        modifybttn1.TabIndex = 90
        modifybttn1.Text = "Modify Course"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(993, 792)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 89
        modifybttn.TabStop = False
        ' 
        ' searchButtonPic
        ' 
        searchButtonPic.BackgroundImage = CType(resources.GetObject("searchButtonPic.BackgroundImage"), Image)
        searchButtonPic.BackgroundImageLayout = ImageLayout.Stretch
        searchButtonPic.Location = New Point(422, 113)
        searchButtonPic.Name = "searchButtonPic"
        searchButtonPic.Size = New Size(39, 39)
        searchButtonPic.TabIndex = 91
        searchButtonPic.TabStop = False
        ' 
        ' CourseSectionForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(searchButtonPic)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(addcoursebttn)
        Controls.Add(addcourse1)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(Label11)
        Controls.Add(searchProgramField)
        Controls.Add(searchfield)
        Controls.Add(backbttn)
        Controls.Add(dataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "CourseSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourseSectionForm"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(addcoursebttn, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dataView As DataGridView
    Friend WithEvents searchCourseField As TextBox
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents searchProgramField As TextBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents addcoursebttn As PictureBox
    Friend WithEvents addcourse1 As Label
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
    Friend WithEvents searchButtonPic As PictureBox
End Class
