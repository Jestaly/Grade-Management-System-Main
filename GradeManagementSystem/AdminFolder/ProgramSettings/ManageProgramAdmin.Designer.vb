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
        searchProgramField = New TextBox()
        courseSectionButton = New Button()
        refreshButton = New Button()
        searchButton = New Button()
        modifyProgramButton = New Button()
        addProgramButton = New Button()
        dataView = New DataGridView()
        removeProgramForm = New Button()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchProgramField
        ' 
        searchProgramField.Location = New Point(30, 29)
        searchProgramField.Name = "searchProgramField"
        searchProgramField.PlaceholderText = "Search Program here.."
        searchProgramField.Size = New Size(206, 27)
        searchProgramField.TabIndex = 0
        ' 
        ' courseSectionButton
        ' 
        courseSectionButton.Location = New Point(555, 27)
        courseSectionButton.Name = "courseSectionButton"
        courseSectionButton.Size = New Size(119, 29)
        courseSectionButton.TabIndex = 1
        courseSectionButton.Text = "Course Section"
        courseSectionButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(30, 83)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 2
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(242, 29)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(94, 29)
        searchButton.TabIndex = 3
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' modifyProgramButton
        ' 
        modifyProgramButton.Location = New Point(283, 83)
        modifyProgramButton.Name = "modifyProgramButton"
        modifyProgramButton.Size = New Size(127, 29)
        modifyProgramButton.TabIndex = 4
        modifyProgramButton.Text = "Modify Program"
        modifyProgramButton.UseVisualStyleBackColor = True
        ' 
        ' addProgramButton
        ' 
        addProgramButton.Location = New Point(153, 83)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(124, 29)
        addProgramButton.TabIndex = 5
        addProgramButton.Text = "Add Program"
        addProgramButton.UseVisualStyleBackColor = True
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(30, 118)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(644, 273)
        dataView.TabIndex = 6
        ' 
        ' removeProgramForm
        ' 
        removeProgramForm.Location = New Point(416, 83)
        removeProgramForm.Name = "removeProgramForm"
        removeProgramForm.Size = New Size(135, 29)
        removeProgramForm.TabIndex = 7
        removeProgramForm.Text = "Remove Program"
        removeProgramForm.UseVisualStyleBackColor = True
        ' 
        ' ManageProgramAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(711, 421)
        Controls.Add(removeProgramForm)
        Controls.Add(dataView)
        Controls.Add(addProgramButton)
        Controls.Add(modifyProgramButton)
        Controls.Add(searchButton)
        Controls.Add(refreshButton)
        Controls.Add(courseSectionButton)
        Controls.Add(searchProgramField)
        Name = "ManageProgramAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProgramAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchProgramField As TextBox
    Friend WithEvents courseSectionButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents modifyProgramButton As Button
    Friend WithEvents addProgramButton As Button
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeProgramForm As Button
End Class
