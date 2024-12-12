<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProfessorAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProfessorAdmin))
        dataView = New DataGridView()
        TextBox1 = New TextBox()
        searchbttn = New PictureBox()
        searchfield = New PictureBox()
        departmentlabel = New Label()
        addprofessorbttn = New PictureBox()
        addprofessor1 = New Label()
        reloadbttn1 = New Label()
        reloadbttn = New PictureBox()
        modifybttn1 = New Label()
        modifybttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(addprofessorbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(93, 290)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1089, 494)
        dataView.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(119, 154)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search Department ID..."
        TextBox1.Size = New Size(199, 24)
        TextBox1.TabIndex = 16
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(430, 149)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(52, 35)
        searchbttn.TabIndex = 13
        searchbttn.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932282
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(93, 126)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(408, 75)
        searchfield.TabIndex = 15
        searchfield.TabStop = False
        ' 
        ' departmentlabel
        ' 
        departmentlabel.AutoSize = True
        departmentlabel.Font = New Font("Microsoft Sans Serif", 12F)
        departmentlabel.ForeColor = Color.DarkGreen
        departmentlabel.Location = New Point(93, 40)
        departmentlabel.Name = "departmentlabel"
        departmentlabel.Size = New Size(388, 29)
        departmentlabel.TabIndex = 14
        departmentlabel.Text = "P R O F E S S O R  R E G I S T R Y"
        ' 
        ' addprofessorbttn
        ' 
        addprofessorbttn.BackgroundImage = CType(resources.GetObject("addprofessorbttn.BackgroundImage"), Image)
        addprofessorbttn.BackgroundImageLayout = ImageLayout.Stretch
        addprofessorbttn.Location = New Point(999, 249)
        addprofessorbttn.Name = "addprofessorbttn"
        addprofessorbttn.Size = New Size(38, 38)
        addprofessorbttn.TabIndex = 21
        addprofessorbttn.TabStop = False
        ' 
        ' addprofessor1
        ' 
        addprofessor1.AutoSize = True
        addprofessor1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        addprofessor1.Location = New Point(1036, 254)
        addprofessor1.Name = "addprofessor1"
        addprofessor1.Size = New Size(146, 25)
        addprofessor1.TabIndex = 20
        addprofessor1.Text = "Add Department"
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(115, 259)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 19
        reloadbttn1.Text = "Reload"
        ' 
        ' reloadbttn
        ' 
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0952371
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(88, 257)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 18
        reloadbttn.TabStop = False
        ' 
        ' modifybttn1
        ' 
        modifybttn1.AutoSize = True
        modifybttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        modifybttn1.Location = New Point(1013, 797)
        modifybttn1.Name = "modifybttn1"
        modifybttn1.Size = New Size(169, 25)
        modifybttn1.TabIndex = 23
        modifybttn1.Text = "Modify Department"
        ' 
        ' modifybttn
        ' 
        modifybttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_101453
        modifybttn.BackgroundImageLayout = ImageLayout.Stretch
        modifybttn.Location = New Point(978, 791)
        modifybttn.Name = "modifybttn"
        modifybttn.Size = New Size(38, 38)
        modifybttn.TabIndex = 22
        modifybttn.TabStop = False
        ' 
        ' ManageProfessorAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(modifybttn1)
        Controls.Add(modifybttn)
        Controls.Add(addprofessorbttn)
        Controls.Add(addprofessor1)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(TextBox1)
        Controls.Add(searchbttn)
        Controls.Add(searchfield)
        Controls.Add(departmentlabel)
        Controls.Add(dataView)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageProfessorAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProfessorAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(addprofessorbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(modifybttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dataView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents departmentlabel As Label
    Friend WithEvents addprofessorbttn As PictureBox
    Friend WithEvents addprofessor1 As Label
    Friend WithEvents reloadbttn1 As Label
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents modifybttn1 As Label
    Friend WithEvents modifybttn As PictureBox
End Class
