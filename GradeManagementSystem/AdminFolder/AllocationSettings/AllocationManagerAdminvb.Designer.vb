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
        CType(classDataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(enrollDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' createClassButton
        ' 
        createClassButton.Location = New Point(104, 25)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(141, 51)
        createClassButton.TabIndex = 0
        createClassButton.Text = "CREATE CLASS"
        createClassButton.UseVisualStyleBackColor = True
        ' 
        ' classDataView
        ' 
        classDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        classDataView.Location = New Point(33, 82)
        classDataView.Name = "classDataView"
        classDataView.RowHeadersWidth = 51
        classDataView.Size = New Size(277, 284)
        classDataView.TabIndex = 1
        ' 
        ' enrollDataView
        ' 
        enrollDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrollDataView.Location = New Point(341, 82)
        enrollDataView.Name = "enrollDataView"
        enrollDataView.RowHeadersWidth = 51
        enrollDataView.Size = New Size(285, 284)
        enrollDataView.TabIndex = 3
        ' 
        ' enrollStudentButton
        ' 
        enrollStudentButton.Location = New Point(411, 25)
        enrollStudentButton.Name = "enrollStudentButton"
        enrollStudentButton.Size = New Size(141, 51)
        enrollStudentButton.TabIndex = 2
        enrollStudentButton.Text = "ENROLL STUDENT"
        enrollStudentButton.UseVisualStyleBackColor = True
        ' 
        ' gradeSectionButton
        ' 
        gradeSectionButton.Location = New Point(585, 12)
        gradeSectionButton.Name = "gradeSectionButton"
        gradeSectionButton.Size = New Size(115, 29)
        gradeSectionButton.TabIndex = 4
        gradeSectionButton.Text = "Grade Section"
        gradeSectionButton.UseVisualStyleBackColor = True
        ' 
        ' AllocationManagerAdminvb
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 378)
        Controls.Add(gradeSectionButton)
        Controls.Add(enrollDataView)
        Controls.Add(enrollStudentButton)
        Controls.Add(classDataView)
        Controls.Add(createClassButton)
        Name = "AllocationManagerAdminvb"
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
End Class
