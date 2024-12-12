<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageDepartmentAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageDepartmentAdmin))
        dataView = New DataGridView()
        searchbttn = New PictureBox()
        departmentlabel = New Label()
        searchfield = New PictureBox()
        TextBox1 = New TextBox()
        reloadbttn = New PictureBox()
        reloadbttn1 = New Label()
        modifybttn = New PictureBox()
        adddepartmentbttn1 = New Label()
        adddepartmentbttn = New PictureBox()
        modifybttn1 = New Label()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(adddepartmentbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(71, 296)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1121, 495)
        dataView.TabIndex = 5
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(408, 160)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(52, 35)
        searchbttn.TabIndex = 9
        searchbttn.TabStop = False
        ' 
        ' departmentlabel
        ' 
        departmentlabel.AutoSize = True
        departmentlabel.Font = New Font("Microsoft Sans Serif", 12F)
        departmentlabel.ForeColor = Color.DarkGreen
        departmentlabel.Location = New Point(71, 51)
        departmentlabel.Name = "departmentlabel"
        departmentlabel.Size = New Size(472, 29)
        departmentlabel.TabIndex = 10
        departmentlabel.Text = "D E P A R T M E N T  M A N A G E M E N T"
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(71, 137)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(408, 75)
        searchfield.TabIndex = 11
        searchfield.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(97, 165)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search Department ID..."
        TextBox1.Size = New Size(199, 24)
        TextBox1.TabIndex = 12
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(71, 258)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 13
        reloadbttn.TabStop = False
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(98, 260)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 14
        reloadbttn1.Text = "Reload"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(988, 794)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 15
        modifybttn.TabStop = False
        ' 
        ' adddepartmentbttn1
        ' 
        adddepartmentbttn1.AutoSize = True
        adddepartmentbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        adddepartmentbttn1.Location = New Point(1046, 258)
        adddepartmentbttn1.Name = "adddepartmentbttn1"
        adddepartmentbttn1.Size = New Size(146, 25)
        adddepartmentbttn1.TabIndex = 16
        adddepartmentbttn1.Text = "Add Department"
        ' 
        ' adddepartmentbttn
        ' 
        adddepartmentbttn.BackgroundImage = CType(resources.GetObject("adddepartmentbttn.BackgroundImage"), Image)
        adddepartmentbttn.BackgroundImageLayout = ImageLayout.Stretch
        adddepartmentbttn.Location = New Point(1009, 253)
        adddepartmentbttn.Name = "adddepartmentbttn"
        adddepartmentbttn.Size = New Size(38, 38)
        adddepartmentbttn.TabIndex = 17
        adddepartmentbttn.TabStop = False
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(1023, 800)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(169, 25)
        modifybttn1.TabIndex = 18
        modifybttn1.Text = "Modify Department"
        ' 
        ' ManageDepartmentAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(modifybttn1)
        Controls.Add(adddepartmentbttn)
        Controls.Add(adddepartmentbttn1)
        Controls.Add(modifybttn)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(TextBox1)
        Controls.Add(searchbttn)
        Controls.Add(searchfield)
        Controls.Add(departmentlabel)
        Controls.Add(dataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageDepartmentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageDepartmentAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        CType(adddepartmentbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dataView As DataGridView
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents departmentlabel As Label
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents modifybttn As PictureBox
    Friend WithEvents adddepartmentbttn1 As Label
    Friend WithEvents adddepartmentbttn As PictureBox
    Friend WithEvents modifybttn1 As Label
End Class
