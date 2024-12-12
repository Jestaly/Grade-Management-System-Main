<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocationManagerAdminvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllocationManagerAdminvb))
        enrollDataView = New DataGridView()
        enrollStudentButton = New Button()
        gradeSectionButton = New Button()
        modifyEnrollButton = New Button()
        classSectionButton = New Button()
        departmentlabel = New Label()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        searchstuentField = New TextBox()
        searchButtonPic = New PictureBox()
        searchfield = New PictureBox()
        CType(enrollDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' enrollDataView
        ' 
        enrollDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrollDataView.Location = New Point(65, 263)
        enrollDataView.Margin = New Padding(4)
        enrollDataView.Name = "enrollDataView"
        enrollDataView.RowHeadersWidth = 51
        enrollDataView.Size = New Size(1129, 524)
        enrollDataView.TabIndex = 3
        ' 
        ' enrollStudentButton
        ' 
        enrollStudentButton.BackColor = Color.DarkGreen
        enrollStudentButton.FlatStyle = FlatStyle.Popup
        enrollStudentButton.Font = New Font("Segoe UI", 9F)
        enrollStudentButton.ForeColor = Color.White
        enrollStudentButton.Location = New Point(996, 89)
        enrollStudentButton.Margin = New Padding(4)
        enrollStudentButton.Name = "enrollStudentButton"
        enrollStudentButton.Size = New Size(176, 37)
        enrollStudentButton.TabIndex = 2
        enrollStudentButton.Text = "ENROLL STUDENT"
        enrollStudentButton.UseVisualStyleBackColor = False
        ' 
        ' gradeSectionButton
        ' 
        gradeSectionButton.BackColor = Color.DarkGreen
        gradeSectionButton.FlatStyle = FlatStyle.Popup
        gradeSectionButton.Font = New Font("Segoe UI", 10F)
        gradeSectionButton.ForeColor = Color.WhiteSmoke
        gradeSectionButton.Location = New Point(996, 179)
        gradeSectionButton.Margin = New Padding(4)
        gradeSectionButton.Name = "gradeSectionButton"
        gradeSectionButton.Size = New Size(176, 37)
        gradeSectionButton.TabIndex = 4
        gradeSectionButton.Text = "Grade Section"
        gradeSectionButton.UseVisualStyleBackColor = False
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.BackColor = Color.DarkGreen
        modifyEnrollButton.FlatStyle = FlatStyle.Popup
        modifyEnrollButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        modifyEnrollButton.ForeColor = Color.White
        modifyEnrollButton.Location = New Point(1018, 809)
        modifyEnrollButton.Margin = New Padding(4)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(154, 36)
        modifyEnrollButton.TabIndex = 7
        modifyEnrollButton.Text = "Modify"
        modifyEnrollButton.UseVisualStyleBackColor = False
        ' 
        ' classSectionButton
        ' 
        classSectionButton.BackColor = Color.DarkGreen
        classSectionButton.FlatStyle = FlatStyle.Popup
        classSectionButton.Font = New Font("Segoe UI", 10F)
        classSectionButton.ForeColor = Color.WhiteSmoke
        classSectionButton.Location = New Point(996, 134)
        classSectionButton.Margin = New Padding(4)
        classSectionButton.Name = "classSectionButton"
        classSectionButton.Size = New Size(176, 37)
        classSectionButton.TabIndex = 10
        classSectionButton.Text = "Class Section"
        classSectionButton.UseVisualStyleBackColor = False
        ' 
        ' departmentlabel
        ' 
        departmentlabel.AutoSize = True
        departmentlabel.Font = New Font("Microsoft Sans Serif", 12F)
        departmentlabel.ForeColor = Color.DarkGreen
        departmentlabel.Location = New Point(65, 49)
        departmentlabel.Name = "departmentlabel"
        departmentlabel.Size = New Size(391, 29)
        departmentlabel.TabIndex = 82
        departmentlabel.Text = "A L L O C A T I O N   M A N A G E R"
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(97, 231)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 85
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(67, 229)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(33, 29)
        reloadbttn.TabIndex = 84
        reloadbttn.TabStop = False
        ' 
        ' searchstuentField
        ' 
        searchstuentField.BorderStyle = BorderStyle.None
        searchstuentField.Font = New Font("Segoe UI", 9F)
        searchstuentField.Location = New Point(95, 161)
        searchstuentField.Name = "searchstuentField"
        searchstuentField.PlaceholderText = "Search Student ID..."
        searchstuentField.Size = New Size(221, 24)
        searchstuentField.TabIndex = 88
        ' 
        ' searchButtonPic
        ' 
        searchButtonPic.BackgroundImage = CType(resources.GetObject("searchButtonPic.BackgroundImage"), Image)
        searchButtonPic.BackgroundImageLayout = ImageLayout.Stretch
        searchButtonPic.Location = New Point(451, 153)
        searchButtonPic.Name = "searchButtonPic"
        searchButtonPic.Size = New Size(38, 38)
        searchButtonPic.TabIndex = 86
        searchButtonPic.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(66, 134)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(453, 72)
        searchfield.TabIndex = 87
        searchfield.TabStop = False
        ' 
        ' AllocationManagerAdminvb
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(searchstuentField)
        Controls.Add(searchButtonPic)
        Controls.Add(searchfield)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(departmentlabel)
        Controls.Add(classSectionButton)
        Controls.Add(modifyEnrollButton)
        Controls.Add(gradeSectionButton)
        Controls.Add(enrollDataView)
        Controls.Add(enrollStudentButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AllocationManagerAdminvb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AllocationManagerAdminvb"
        CType(enrollDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchButtonPic, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents enrollDataView As DataGridView
    Friend WithEvents enrollStudentButton As Button
    Friend WithEvents gradeSectionButton As Button
    Friend WithEvents modifyEnrollButton As Button
    Friend WithEvents classSectionButton As Button
    Friend WithEvents departmentlabel As Label
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents searchstuentField As TextBox
    Friend WithEvents searchButtonPic As PictureBox
    Friend WithEvents searchfield As PictureBox
End Class
