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
        deleteClassButton = New Button()
        modifyClassButton = New Button()
        classDataView = New DataGridView()
        createClassButton = New Button()
        refreshButton = New Button()
        enrollmentSectionButton = New Button()
        CType(classDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' deleteClassButton
        ' 
        deleteClassButton.Location = New Point(394, 58)
        deleteClassButton.Name = "deleteClassButton"
        deleteClassButton.Size = New Size(88, 29)
        deleteClassButton.TabIndex = 10
        deleteClassButton.Text = "Delete"
        deleteClassButton.UseVisualStyleBackColor = True
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.Location = New Point(394, 23)
        modifyClassButton.Name = "modifyClassButton"
        modifyClassButton.Size = New Size(88, 29)
        modifyClassButton.TabIndex = 9
        modifyClassButton.Text = "Modify"
        modifyClassButton.UseVisualStyleBackColor = True
        ' 
        ' classDataView
        ' 
        classDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        classDataView.Location = New Point(66, 93)
        classDataView.Name = "classDataView"
        classDataView.RowHeadersWidth = 51
        classDataView.Size = New Size(416, 271)
        classDataView.TabIndex = 8
        ' 
        ' createClassButton
        ' 
        createClassButton.Location = New Point(66, 47)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(141, 40)
        createClassButton.TabIndex = 7
        createClassButton.Text = "CREATE CLASS"
        createClassButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(300, 58)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(88, 29)
        refreshButton.TabIndex = 11
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' enrollmentSectionButton
        ' 
        enrollmentSectionButton.Location = New Point(488, 12)
        enrollmentSectionButton.Name = "enrollmentSectionButton"
        enrollmentSectionButton.Size = New Size(143, 28)
        enrollmentSectionButton.TabIndex = 12
        enrollmentSectionButton.Text = "Enrollment Section"
        enrollmentSectionButton.UseVisualStyleBackColor = True
        ' 
        ' ClassSectionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(642, 391)
        Controls.Add(enrollmentSectionButton)
        Controls.Add(refreshButton)
        Controls.Add(deleteClassButton)
        Controls.Add(modifyClassButton)
        Controls.Add(classDataView)
        Controls.Add(createClassButton)
        Name = "ClassSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClassSectionForm"
        CType(classDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents deleteClassButton As Button
    Friend WithEvents modifyClassButton As Button
    Friend WithEvents classDataView As DataGridView
    Friend WithEvents createClassButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents enrollmentSectionButton As Button
End Class
