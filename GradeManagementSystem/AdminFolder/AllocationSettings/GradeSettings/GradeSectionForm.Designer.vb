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
        modifyGradeWeightButton = New Button()
        gradeWeightDataView = New DataGridView()
        addGradeWeightButton = New Button()
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.Location = New Point(72, 58)
        refreshButton.Margin = New Padding(4, 4, 4, 4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(110, 36)
        refreshButton.TabIndex = 16
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' modifyGradeWeightButton
        ' 
        modifyGradeWeightButton.BackColor = Color.DarkSeaGreen
        modifyGradeWeightButton.FlatStyle = FlatStyle.Popup
        modifyGradeWeightButton.Font = New Font("Sitka Banner", 9F)
        modifyGradeWeightButton.Location = New Point(720, 58)
        modifyGradeWeightButton.Margin = New Padding(4, 4, 4, 4)
        modifyGradeWeightButton.Name = "modifyGradeWeightButton"
        modifyGradeWeightButton.Size = New Size(110, 36)
        modifyGradeWeightButton.TabIndex = 14
        modifyGradeWeightButton.Text = "Modify"
        modifyGradeWeightButton.UseVisualStyleBackColor = False
        ' 
        ' gradeWeightDataView
        ' 
        gradeWeightDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradeWeightDataView.Location = New Point(72, 102)
        gradeWeightDataView.Margin = New Padding(4, 4, 4, 4)
        gradeWeightDataView.Name = "gradeWeightDataView"
        gradeWeightDataView.RowHeadersWidth = 51
        gradeWeightDataView.Size = New Size(758, 339)
        gradeWeightDataView.TabIndex = 13
        ' 
        ' addGradeWeightButton
        ' 
        addGradeWeightButton.BackColor = Color.DarkSeaGreen
        addGradeWeightButton.FlatStyle = FlatStyle.Popup
        addGradeWeightButton.Font = New Font("Sitka Banner", 9F)
        addGradeWeightButton.Location = New Point(72, 449)
        addGradeWeightButton.Margin = New Padding(4, 4, 4, 4)
        addGradeWeightButton.Name = "addGradeWeightButton"
        addGradeWeightButton.Size = New Size(182, 45)
        addGradeWeightButton.TabIndex = 12
        addGradeWeightButton.Text = "ADD GRADE WEIGHT"
        addGradeWeightButton.UseVisualStyleBackColor = False
        ' 
        ' GradeSectionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(909, 564)
        Controls.Add(refreshButton)
        Controls.Add(modifyGradeWeightButton)
        Controls.Add(gradeWeightDataView)
        Controls.Add(addGradeWeightButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "GradeSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "GradeSectionForm"
        CType(gradeWeightDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents modifyGradeWeightButton As Button
    Friend WithEvents gradeWeightDataView As DataGridView
    Friend WithEvents addGradeWeightButton As Button
End Class
