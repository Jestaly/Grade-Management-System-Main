<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeSectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeSectionForm))
        gradeWeightDataView = New DataGridView()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        addgradebttn = New PictureBox()
        adddepartmentbttn1 = New Label()
        backbttn = New PictureBox()
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(addgradebttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gradeWeightDataView
        ' 
        gradeWeightDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradeWeightDataView.Location = New Point(72, 102)
        gradeWeightDataView.Margin = New Padding(4)
        gradeWeightDataView.Name = "gradeWeightDataView"
        gradeWeightDataView.RowHeadersWidth = 51
        gradeWeightDataView.Size = New Size(758, 375)
        gradeWeightDataView.TabIndex = 13
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(104, 69)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 18
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(77, 67)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 17
        reloadbttn.TabStop = False
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(761, 490)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(69, 25)
        modifybttn1.TabIndex = 20
        modifybttn1.Text = "Modify"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(730, 484)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 19
        modifybttn.TabStop = False
        ' 
        ' addgradebttn
        ' 
        addgradebttn.BackgroundImage = CType(resources.GetObject("addgradebttn.BackgroundImage"), Image)
        addgradebttn.BackgroundImageLayout = ImageLayout.Stretch
        addgradebttn.Location = New Point(634, 62)
        addgradebttn.Name = "addgradebttn"
        addgradebttn.Size = New Size(38, 38)
        addgradebttn.TabIndex = 22
        addgradebttn.TabStop = False
        ' 
        ' adddepartmentbttn1
        ' 
        adddepartmentbttn1.AutoSize = True
        adddepartmentbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        adddepartmentbttn1.Location = New Point(671, 67)
        adddepartmentbttn1.Name = "adddepartmentbttn1"
        adddepartmentbttn1.Size = New Size(159, 25)
        adddepartmentbttn1.TabIndex = 21
        adddepartmentbttn1.Text = "Add Grade Weight"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 48
        backbttn.TabStop = False
        ' 
        ' GradeSectionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(909, 564)
        Controls.Add(backbttn)
        Controls.Add(addgradebttn)
        Controls.Add(adddepartmentbttn1)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(gradeWeightDataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "GradeSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GradeSectionForm"
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        CType(addgradebttn, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents gradeWeightDataView As DataGridView
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
    Friend WithEvents addgradebttn As PictureBox
    Friend WithEvents adddepartmentbttn1 As Label
    Friend WithEvents backbttn As PictureBox
End Class
