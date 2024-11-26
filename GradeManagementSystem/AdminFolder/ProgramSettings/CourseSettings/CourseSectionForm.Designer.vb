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
        backButton = New Button()
        dataView = New DataGridView()
        addCourseButton = New Button()
        modifyCourseButton = New Button()
        searchButton = New Button()
        refreshButton = New Button()
        searchCourseField = New TextBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(12, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 1
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(58, 146)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(644, 273)
        dataView.TabIndex = 13
        ' 
        ' addCourseButton
        ' 
        addCourseButton.Location = New Point(181, 111)
        addCourseButton.Name = "addCourseButton"
        addCourseButton.Size = New Size(124, 29)
        addCourseButton.TabIndex = 12
        addCourseButton.Text = "Add Course"
        addCourseButton.UseVisualStyleBackColor = True
        ' 
        ' modifyCourseButton
        ' 
        modifyCourseButton.Location = New Point(311, 111)
        modifyCourseButton.Name = "modifyCourseButton"
        modifyCourseButton.Size = New Size(127, 29)
        modifyCourseButton.TabIndex = 11
        modifyCourseButton.Text = "Modify Course"
        modifyCourseButton.UseVisualStyleBackColor = True
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(270, 57)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(94, 29)
        searchButton.TabIndex = 10
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(58, 111)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 9
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' searchCourseField
        ' 
        searchCourseField.Location = New Point(58, 57)
        searchCourseField.Name = "searchCourseField"
        searchCourseField.PlaceholderText = "Search Program here.."
        searchCourseField.Size = New Size(206, 27)
        searchCourseField.TabIndex = 7
        ' 
        ' CourseSectionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(760, 431)
        Controls.Add(dataView)
        Controls.Add(addCourseButton)
        Controls.Add(modifyCourseButton)
        Controls.Add(searchButton)
        Controls.Add(refreshButton)
        Controls.Add(searchCourseField)
        Controls.Add(backButton)
        Name = "CourseSectionForm"
        Text = "CourseSectionForm"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents backButton As Button
    Friend WithEvents dataView As DataGridView
    Friend WithEvents addCourseButton As Button
    Friend WithEvents modifyCourseButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents searchCourseField As TextBox
End Class
