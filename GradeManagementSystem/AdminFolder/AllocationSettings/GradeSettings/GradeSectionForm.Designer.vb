<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeSectionForm
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
        refreshButton = New Button()
        deleteGradeWeightButton = New Button()
        modifyGradeWeightButton = New Button()
        gradeWeightDataView = New DataGridView()
        addGradeWeightButton = New Button()
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(351, 55)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(88, 29)
        refreshButton.TabIndex = 16
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' deleteGradeWeightButton
        ' 
        deleteGradeWeightButton.Location = New Point(445, 55)
        deleteGradeWeightButton.Name = "deleteGradeWeightButton"
        deleteGradeWeightButton.Size = New Size(88, 29)
        deleteGradeWeightButton.TabIndex = 15
        deleteGradeWeightButton.Text = "Delete"
        deleteGradeWeightButton.UseVisualStyleBackColor = True
        ' 
        ' modifyGradeWeightButton
        ' 
        modifyGradeWeightButton.Location = New Point(445, 20)
        modifyGradeWeightButton.Name = "modifyGradeWeightButton"
        modifyGradeWeightButton.Size = New Size(88, 29)
        modifyGradeWeightButton.TabIndex = 14
        modifyGradeWeightButton.Text = "Modify"
        modifyGradeWeightButton.UseVisualStyleBackColor = True
        ' 
        ' gradeWeightDataView
        ' 
        gradeWeightDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradeWeightDataView.Location = New Point(117, 90)
        gradeWeightDataView.Name = "gradeWeightDataView"
        gradeWeightDataView.RowHeadersWidth = 51
        gradeWeightDataView.Size = New Size(416, 271)
        gradeWeightDataView.TabIndex = 13
        ' 
        ' addGradeWeightButton
        ' 
        addGradeWeightButton.Location = New Point(117, 44)
        addGradeWeightButton.Name = "addGradeWeightButton"
        addGradeWeightButton.Size = New Size(167, 40)
        addGradeWeightButton.TabIndex = 12
        addGradeWeightButton.Text = "ADD GRADE WEIGHT"
        addGradeWeightButton.UseVisualStyleBackColor = True
        ' 
        ' GradeSectionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(651, 380)
        Controls.Add(refreshButton)
        Controls.Add(deleteGradeWeightButton)
        Controls.Add(modifyGradeWeightButton)
        Controls.Add(gradeWeightDataView)
        Controls.Add(addGradeWeightButton)
        Name = "GradeSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GradeSectionForm"
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents deleteGradeWeightButton As Button
    Friend WithEvents modifyGradeWeightButton As Button
    Friend WithEvents gradeWeightDataView As DataGridView
    Friend WithEvents addGradeWeightButton As Button
End Class
