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
        modifyEnrollButton = New Button()
        refreshButton = New Button()
        classSectionButton = New Button()
        CType(enrollDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' enrollDataView
        ' 
        enrollDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        enrollDataView.Location = New Point(65, 139)
        enrollDataView.Margin = New Padding(4, 4, 4, 4)
        enrollDataView.Name = "enrollDataView"
        enrollDataView.RowHeadersWidth = 51
        enrollDataView.Size = New Size(915, 372)
        enrollDataView.TabIndex = 3
        ' 
        ' enrollStudentButton
        ' 
        enrollStudentButton.BackColor = Color.DarkSeaGreen
        enrollStudentButton.FlatStyle = FlatStyle.Popup
        enrollStudentButton.Font = New Font("Sitka Banner", 9F)
        enrollStudentButton.Location = New Point(65, 531)
        enrollStudentButton.Margin = New Padding(4, 4, 4, 4)
        enrollStudentButton.Name = "enrollStudentButton"
        enrollStudentButton.Size = New Size(176, 49)
        enrollStudentButton.TabIndex = 2
        enrollStudentButton.Text = "ENROLL STUDENT"
        enrollStudentButton.UseVisualStyleBackColor = False
        ' 
        ' gradeSectionButton
        ' 
        gradeSectionButton.BackColor = Color.DarkSeaGreen
        gradeSectionButton.FlatStyle = FlatStyle.Popup
        gradeSectionButton.Font = New Font("Sitka Banner", 9F)
        gradeSectionButton.Location = New Point(842, 40)
        gradeSectionButton.Margin = New Padding(4, 4, 4, 4)
        gradeSectionButton.Name = "gradeSectionButton"
        gradeSectionButton.Size = New Size(138, 34)
        gradeSectionButton.TabIndex = 4
        gradeSectionButton.Text = "Grade Section"
        gradeSectionButton.UseVisualStyleBackColor = False
        ' 
        ' modifyEnrollButton
        ' 
        modifyEnrollButton.BackColor = Color.DarkSeaGreen
        modifyEnrollButton.FlatStyle = FlatStyle.Popup
        modifyEnrollButton.Font = New Font("Sitka Banner", 9F)
        modifyEnrollButton.Location = New Point(870, 531)
        modifyEnrollButton.Margin = New Padding(4, 4, 4, 4)
        modifyEnrollButton.Name = "modifyEnrollButton"
        modifyEnrollButton.Size = New Size(110, 36)
        modifyEnrollButton.TabIndex = 7
        modifyEnrollButton.Text = "Modify"
        modifyEnrollButton.UseVisualStyleBackColor = False
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 8F)
        refreshButton.Location = New Point(65, 96)
        refreshButton.Margin = New Padding(4, 4, 4, 4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(110, 35)
        refreshButton.TabIndex = 9
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' classSectionButton
        ' 
        classSectionButton.BackColor = Color.DarkSeaGreen
        classSectionButton.FlatStyle = FlatStyle.Popup
        classSectionButton.Font = New Font("Sitka Banner", 9F)
        classSectionButton.Location = New Point(680, 40)
        classSectionButton.Margin = New Padding(4, 4, 4, 4)
        classSectionButton.Name = "classSectionButton"
        classSectionButton.Size = New Size(138, 35)
        classSectionButton.TabIndex = 10
        classSectionButton.Text = "Class Section"
        classSectionButton.UseVisualStyleBackColor = False
        ' 
        ' AllocationManagerAdminvb
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1049, 615)
        Controls.Add(classSectionButton)
        Controls.Add(refreshButton)
        Controls.Add(modifyEnrollButton)
        Controls.Add(gradeSectionButton)
        Controls.Add(enrollDataView)
        Controls.Add(enrollStudentButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "AllocationManagerAdminvb"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AllocationManagerAdminvb"
        CType(enrollDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents enrollDataView As DataGridView
    Friend WithEvents enrollStudentButton As Button
    Friend WithEvents gradeSectionButton As Button
    Friend WithEvents modifyEnrollButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents classSectionButton As Button
End Class
