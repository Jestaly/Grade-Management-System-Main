<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClassSectionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClassSectionForm))
        classDataView = New DataGridView()
        enrollmentSectionButton = New Button()
        backbttn = New PictureBox()
        Label7 = New Label()
        createclassb = New PictureBox()
        adddepartmentbttn1 = New Label()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        CType(classDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(createclassb, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' classDataView
        ' 
        classDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        classDataView.Location = New Point(59, 135)
        classDataView.Margin = New Padding(4)
        classDataView.Name = "classDataView"
        classDataView.RowHeadersWidth = 51
        classDataView.Size = New Size(859, 374)
        classDataView.TabIndex = 8
        ' 
        ' enrollmentSectionButton
        ' 
        enrollmentSectionButton.BackColor = Color.DarkGreen
        enrollmentSectionButton.FlatStyle = FlatStyle.Popup
        enrollmentSectionButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrollmentSectionButton.ForeColor = Color.White
        enrollmentSectionButton.Location = New Point(739, 23)
        enrollmentSectionButton.Margin = New Padding(4)
        enrollmentSectionButton.Name = "enrollmentSectionButton"
        enrollmentSectionButton.Size = New Size(179, 35)
        enrollmentSectionButton.TabIndex = 12
        enrollmentSectionButton.Text = "Enrollment Section"
        enrollmentSectionButton.UseVisualStyleBackColor = False
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 31)
        backbttn.TabIndex = 52
        backbttn.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(362, 36)
        Label7.Name = "Label7"
        Label7.Size = New Size(239, 22)
        Label7.TabIndex = 53
        Label7.Text = "C L A S S   S E C T I O N"
        ' 
        ' createclassb
        ' 
        createclassb.BackgroundImage = CType(resources.GetObject("createclassb.BackgroundImage"), Image)
        createclassb.BackgroundImageLayout = ImageLayout.Stretch
        createclassb.Location = New Point(649, 513)
        createclassb.Name = "createclassb"
        createclassb.Size = New Size(38, 38)
        createclassb.TabIndex = 57
        createclassb.TabStop = False
        ' 
        ' adddepartmentbttn1
        ' 
        adddepartmentbttn1.AutoSize = True
        adddepartmentbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        adddepartmentbttn1.Location = New Point(686, 518)
        adddepartmentbttn1.Name = "adddepartmentbttn1"
        adddepartmentbttn1.Size = New Size(107, 25)
        adddepartmentbttn1.TabIndex = 56
        adddepartmentbttn1.Text = "Create Class"
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(83, 105)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 55
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(56, 102)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 54
        reloadbttn.TabStop = False
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(849, 517)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(69, 25)
        modifybttn1.TabIndex = 59
        modifybttn1.Text = "Modify"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(814, 511)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 58
        modifybttn.TabStop = False
        ' 
        ' ClassSectionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 611)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(createclassb)
        Controls.Add(adddepartmentbttn1)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(Label7)
        Controls.Add(backbttn)
        Controls.Add(enrollmentSectionButton)
        Controls.Add(classDataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ClassSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClassSectionForm"
        CType(classDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(createclassb, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents classDataView As DataGridView
    Friend WithEvents refreshButton As Button
    Friend WithEvents enrollmentSectionButton As Button
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents createclassb As PictureBox
    Friend WithEvents adddepartmentbttn1 As Label
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
End Class
