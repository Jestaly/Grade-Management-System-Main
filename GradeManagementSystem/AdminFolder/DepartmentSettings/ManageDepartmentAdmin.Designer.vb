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
        refreshButton = New Button()
        searchDepartmentField = New TextBox()
        dataView = New DataGridView()
        removeDeptButton = New Button()
        searchbttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addDepartment
        ' 
        addDepartment.BackColor = Color.DarkSeaGreen
        addDepartment.FlatStyle = FlatStyle.Popup
        addDepartment.Font = New Font("Sitka Banner", 9F)
        addDepartment.ForeColor = Color.Black
        addDepartment.Location = New Point(590, 115)
        addDepartment.Margin = New Padding(4, 4, 4, 4)
        addDepartment.Name = "addDepartment"
        addDepartment.Size = New Size(147, 36)
        addDepartment.TabIndex = 1
        addDepartment.Text = "Add Department"
        addDepartment.UseVisualStyleBackColor = False
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkSeaGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.Font = New Font("Sitka Banner", 9F)
        modifyButton.ForeColor = Color.Black
        modifyButton.Location = New Point(759, 115)
        modifyButton.Margin = New Padding(4, 4, 4, 4)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(156, 36)
        modifyButton.TabIndex = 2
        modifyButton.Text = "Modify Department"
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.ForeColor = Color.Black
        refreshButton.Location = New Point(60, 116)
        refreshButton.Margin = New Padding(4, 4, 4, 4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(118, 36)
        refreshButton.TabIndex = 3
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' searchDepartmentField
        ' 
        searchDepartmentField.Font = New Font("Sitka Banner Semibold", 11F, FontStyle.Bold)
        searchDepartmentField.Location = New Point(60, 37)
        searchDepartmentField.Margin = New Padding(4, 4, 4, 4)
        searchDepartmentField.Name = "searchDepartmentField"
        searchDepartmentField.PlaceholderText = "Search Department here..."
        searchDepartmentField.Size = New Size(319, 35)
        searchDepartmentField.TabIndex = 4
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(60, 159)
        dataView.Margin = New Padding(4, 4, 4, 4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(855, 356)
        dataView.TabIndex = 5
        ' 
        ' removeDeptButton
        ' 
        removeDeptButton.BackColor = Color.DarkSeaGreen
        removeDeptButton.FlatStyle = FlatStyle.Popup
        removeDeptButton.Font = New Font("Sitka Banner", 9F)
        removeDeptButton.ForeColor = Color.Black
        removeDeptButton.Location = New Point(741, 523)
        removeDeptButton.Margin = New Padding(4, 4, 4, 4)
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
        searchbttn.Location = New Point(377, 37)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(38, 35)
        searchbttn.TabIndex = 9
        searchbttn.TabStop = False
        ' 
        ' ManageDepartmentAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 609)
        Controls.Add(searchbttn)
        Controls.Add(removeDeptButton)
        Controls.Add(dataView)
        Controls.Add(searchDepartmentField)
        Controls.Add(refreshButton)
        Controls.Add(modifyButton)
        Controls.Add(addDepartment)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ManageDepartmentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageDepartmentAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addDepartment As Button
    Friend WithEvents modifyButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents searchDepartmentField As TextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeDeptButton As Button
    Friend WithEvents searchbttn As PictureBox
End Class
