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
        createClassButton = New Button()
        classDataView = New DataGridView()
        enrollDataView = New DataGridView()
        enrollStudentButton = New Button()
        gradeSectionButton = New Button()
        modifyClassButton = New Button()
        deleteClassButton = New Button()
        deleteEnrollButton = New Button()
        modifyEnrollButton = New Button()
        refreshButton = New Button()
        CType(classDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(enrollDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' createClassButton
        ' 
        createClassButton.Location = New Point(33, 36)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(141, 40)
        createClassButton.TabIndex = 0
        createClassButton.Text = "CREATE CLASS"
        createClassButton.UseVisualStyleBackColor = True
        ' 
        ' classDataView
        ' 
        classDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        classDataView.Location = New Point(33, 95)
        classDataView.Name = "classDataView"
        classDataView.RowHeadersWidth = 51
        classDataView.Size = New Size(277, 271)
        classDataView.TabIndex = 1
        ' 
        ' enrollDataView
        ' 
        enrollDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrollDataView.Location = New Point(341, 95)
        enrollDataView.Name = "enrollDataView"
        enrollDataView.RowHeadersWidth = 51
        enrollDataView.Size = New Size(277, 271)
        enrollDataView.TabIndex = 3
        ' 
        ' enrollStudentButton
        ' 
        enrollStudentButton.Location = New Point(341, 36)
        enrollStudentButton.Name = "enrollStudentButton"
        enrollStudentButton.Size = New Size(141, 40)
        enrollStudentButton.TabIndex = 2
        enrollStudentButton.Text = "ENROLL STUDENT"
        enrollStudentButton.UseVisualStyleBackColor = True
        ' 
        ' gradeSectionButton
        ' 
        gradeSectionButton.Location = New Point(641, 12)
        gradeSectionButton.Name = "gradeSectionButton"
        gradeSectionButton.Size = New Size(110, 27)
        gradeSectionButton.TabIndex = 4
        gradeSectionButton.Text = "Grade Section"
        gradeSectionButton.UseVisualStyleBackColor = True
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.Location = New Point(180, 25)
        modifyClassButton.Name = "modifyClassButton"
        modifyClassButton.Size = New Size(88, 29)
        modifyClassButton.TabIndex = 5
        modifyClassButton.Text = "Modify"
        modifyClassButton.UseVisualStyleBackColor = True
        ' 
        ' deleteClassButton
        ' 
        deleteClassButton.Location = New Point(180, 60)
        deleteClassButton.Name = "deleteClassButton"
        deleteClassButton.Size = New Size(88, 29)
        deleteClassButton.TabIndex = 6
        deleteClassButton.Text = "Delete"
        deleteClassButton.UseVisualStyleBackColor = True
        ' 
        ' deleteEnrollButton
        ' 
        deleteEnrollButton.Location = New Point(497, 60)
        deleteEnrollButton.Name = "deleteEnrollButton"
        deleteEnrollButton.Size = New Size(88, 29)
        deleteEnrollButton.TabIndex = 8
        deleteEnrollButton.Text = "Delete"
        deleteEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.Location = New Point(497, 25)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(88, 29)
        modifyEnrollButton.TabIndex = 7
        modifyEnrollButton.Text = "Modify"
        modifyEnrollButton.UseVisualStyleBackColor = True
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(641, 46)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(109, 29)
        refreshButton.TabIndex = 9
        refreshButton.Text = "Refresh All"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' AllocationManagerAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(774, 378)
        Controls.Add(refreshButton)
        Controls.Add(deleteEnrollButton)
        Controls.Add(modifyEnrollButton)
        Controls.Add(deleteClassButton)
        Controls.Add(modifyClassButton)
        Controls.Add(gradeSectionButton)
        Controls.Add(enrollDataView)
        Controls.Add(enrollStudentButton)
        Controls.Add(classDataView)
        Controls.Add(createClassButton)
        Name = "AllocationManagerAdminvb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AllocationManagerAdminvb"
        CType(classDataView, ComponentModel.ISupportInitialize).EndInit()
        CType(enrollDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents createClassButton As Button
    Friend WithEvents classDataView As DataGridView
    Friend WithEvents enrollDataView As DataGridView
    Friend WithEvents enrollStudentButton As Button
    Friend WithEvents gradeSectionButton As Button
    Friend WithEvents modifyClassButton As Button
    Friend WithEvents deleteClassButton As Button
    Friend WithEvents deleteEnrollButton As Button
    Friend WithEvents modifyEnrollButton As Button
    Friend WithEvents refreshButton As Button
End Class
