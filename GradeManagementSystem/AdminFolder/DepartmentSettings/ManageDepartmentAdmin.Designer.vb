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
        addDepartment = New Button()
        modifyButton = New Button()
        dataView = New DataGridView()
        removeDeptButton = New Button()
        searchbttn = New PictureBox()
        departmentlabel = New Label()
        searchfield = New PictureBox()
        TextBox1 = New TextBox()
        reloadbttn = New PictureBox()
        reloadbttn1 = New Label()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addDepartment
        ' 
        addDepartment.BackColor = Color.DarkGreen
        addDepartment.FlatStyle = FlatStyle.Popup
        addDepartment.Font = New Font("Microsoft Sans Serif", 8.25F)
        addDepartment.ForeColor = Color.White
        addDepartment.Location = New Point(1045, 275)
        addDepartment.Margin = New Padding(4)
        addDepartment.Name = "addDepartment"
        addDepartment.Size = New Size(147, 36)
        addDepartment.TabIndex = 1
        addDepartment.Text = "Add Department"
        addDepartment.UseVisualStyleBackColor = False
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        modifyButton.ForeColor = Color.White
        modifyButton.Location = New Point(837, 831)
        modifyButton.Margin = New Padding(4)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(173, 36)
        modifyButton.TabIndex = 2
        modifyButton.Text = "Modify Department"
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(71, 319)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1121, 495)
        dataView.TabIndex = 5
        ' 
        ' removeDeptButton
        ' 
        removeDeptButton.BackColor = Color.DarkGreen
        removeDeptButton.FlatStyle = FlatStyle.Popup
        removeDeptButton.Font = New Font("Microsoft Sans Serif", 8.25F)
        removeDeptButton.ForeColor = Color.White
        removeDeptButton.Location = New Point(1018, 831)
        removeDeptButton.Margin = New Padding(4)
        removeDeptButton.Name = "removeDeptButton"
        removeDeptButton.Size = New Size(174, 36)
        removeDeptButton.TabIndex = 6
        removeDeptButton.Text = "Remove Department"
        removeDeptButton.UseVisualStyleBackColor = False
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
        searchfield.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_0932281
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
        reloadbttn.BackgroundImage = My.Resources.Resources.Screenshot_2024_12_12_095237
        reloadbttn.BackgroundImageLayout = ImageLayout.Stretch
        reloadbttn.Location = New Point(71, 281)
        reloadbttn.Name = "reloadbttn"
        reloadbttn.Size = New Size(30, 30)
        reloadbttn.TabIndex = 13
        reloadbttn.TabStop = False
        ' 
        ' reloadbttn1
        ' 
        reloadbttn1.AutoSize = True
        reloadbttn1.ForeColor = Color.FromArgb(CByte(4), CByte(64), CByte(30))
        reloadbttn1.Location = New Point(98, 283)
        reloadbttn1.Name = "reloadbttn1"
        reloadbttn1.Size = New Size(66, 25)
        reloadbttn1.TabIndex = 14
        reloadbttn1.Text = "Reload"
        ' 
        ' ManageDepartmentAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1261, 897)
        Controls.Add(reloadbttn1)
        Controls.Add(reloadbttn)
        Controls.Add(TextBox1)
        Controls.Add(searchbttn)
        Controls.Add(searchfield)
        Controls.Add(departmentlabel)
        Controls.Add(removeDeptButton)
        Controls.Add(dataView)
        Controls.Add(modifyButton)
        Controls.Add(addDepartment)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageDepartmentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageDepartmentAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(reloadbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addDepartment As Button
    Friend WithEvents modifyButton As Button
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeDeptButton As Button
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents departmentlabel As Label
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents reloadbttn As PictureBox
    Friend WithEvents reloadbttn1 As Label
End Class
