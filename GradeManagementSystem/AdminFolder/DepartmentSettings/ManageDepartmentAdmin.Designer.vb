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
        searchButton = New Button()
        addDepartment = New Button()
        modifyButton = New Button()
        refreshButton = New Button()
        searchDepartmentField = New TextBox()
        dataView = New DataGridView()
        removeDeptButton = New Button()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(220, 29)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(94, 29)
        searchButton.TabIndex = 0
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' addDepartment
        ' 
        addDepartment.Location = New Point(496, 24)
        addDepartment.Name = "addDepartment"
        addDepartment.Size = New Size(166, 29)
        addDepartment.TabIndex = 1
        addDepartment.Text = "Add Department"
        addDepartment.UseVisualStyleBackColor = True
        ' 
        ' modifyButton
        ' 
        modifyButton.Location = New Point(496, 57)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(166, 29)
        modifyButton.TabIndex = 2
        modifyButton.Text = "Modify Department"
        modifyButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(33, 93)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 3
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' searchDepartmentField
        ' 
        searchDepartmentField.Location = New Point(33, 30)
        searchDepartmentField.Name = "searchDepartmentField"
        searchDepartmentField.Size = New Size(181, 27)
        searchDepartmentField.TabIndex = 4
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(33, 128)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(629, 265)
        dataView.TabIndex = 5
        ' 
        ' removeDeptButton
        ' 
        removeDeptButton.Location = New Point(496, 92)
        removeDeptButton.Name = "removeDeptButton"
        removeDeptButton.Size = New Size(166, 29)
        removeDeptButton.TabIndex = 6
        removeDeptButton.Text = "Remove Department"
        removeDeptButton.UseVisualStyleBackColor = True
        ' 
        ' ManageDepartmentAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 405)
        Controls.Add(removeDeptButton)
        Controls.Add(dataView)
        Controls.Add(searchDepartmentField)
        Controls.Add(refreshButton)
        Controls.Add(modifyButton)
        Controls.Add(addDepartment)
        Controls.Add(searchButton)
        Name = "ManageDepartmentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageDepartmentAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchButton As Button
    Friend WithEvents addDepartment As Button
    Friend WithEvents modifyButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents searchDepartmentField As TextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeDeptButton As Button
End Class
