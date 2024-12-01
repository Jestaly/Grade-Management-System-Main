<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllocationManagerAdminvb
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
        enrollDataView = New DataGridView()
        enrollStudentButton = New Button()
        gradeSectionButton = New Button()
        deleteEnrollButton = New Button()
        modifyEnrollButton = New Button()
        refreshButton = New Button()
        classSectionButton = New Button()
        CType(enrollDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' enrollDataView
        ' 
        enrollDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrollDataView.Location = New Point(79, 95)
        enrollDataView.Name = "enrollDataView"
        enrollDataView.RowHeadersWidth = 51
        enrollDataView.Size = New Size(405, 271)
        enrollDataView.TabIndex = 3
        ' 
        ' enrollStudentButton
        ' 
        enrollStudentButton.Location = New Point(79, 49)
        enrollStudentButton.Name = "enrollStudentButton"
        enrollStudentButton.Size = New Size(141, 40)
        enrollStudentButton.TabIndex = 2
        enrollStudentButton.Text = "ENROLL STUDENT"
        enrollStudentButton.UseVisualStyleBackColor = True
        ' 
        ' gradeSectionButton
        ' 
        gradeSectionButton.Location = New Point(522, 43)
        gradeSectionButton.Name = "gradeSectionButton"
        gradeSectionButton.Size = New Size(110, 27)
        gradeSectionButton.TabIndex = 4
        gradeSectionButton.Text = "Grade Section"
        gradeSectionButton.UseVisualStyleBackColor = True
        ' 
        ' deleteEnrollButton
        ' 
        deleteEnrollButton.Location = New Point(396, 57)
        deleteEnrollButton.Name = "deleteEnrollButton"
        deleteEnrollButton.Size = New Size(88, 29)
        deleteEnrollButton.TabIndex = 8
        deleteEnrollButton.Text = "Delete"
        deleteEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.Location = New Point(396, 22)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(88, 29)
        modifyEnrollButton.TabIndex = 7
        modifyEnrollButton.Text = "Modify"
        modifyEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(302, 57)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(88, 29)
        refreshButton.TabIndex = 9
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' classSectionButton
        ' 
        classSectionButton.Location = New Point(522, 12)
        classSectionButton.Name = "classSectionButton"
        classSectionButton.Size = New Size(110, 28)
        classSectionButton.TabIndex = 10
        classSectionButton.Text = "Class Section"
        classSectionButton.UseVisualStyleBackColor = True
        ' 
        ' AllocationManagerAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 378)
        Controls.Add(classSectionButton)
        Controls.Add(refreshButton)
        Controls.Add(deleteEnrollButton)
        Controls.Add(modifyEnrollButton)
        Controls.Add(gradeSectionButton)
        Controls.Add(enrollDataView)
        Controls.Add(enrollStudentButton)
        Name = "AllocationManagerAdminvb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AllocationManagerAdminvb"
        CType(enrollDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents enrollDataView As DataGridView
    Friend WithEvents enrollStudentButton As Button
    Friend WithEvents gradeSectionButton As Button
    Friend WithEvents deleteEnrollButton As Button
    Friend WithEvents modifyEnrollButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents classSectionButton As Button
End Class
