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
        modifyClassButton = New Button()
        classDataView = New DataGridView()
        createClassButton = New Button()
        refreshButton = New Button()
        enrollmentSectionButton = New Button()
        CType(classDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' modifyClassButton
        ' 
        modifyClassButton.BackColor = Color.DarkSeaGreen
        modifyClassButton.FlatStyle = FlatStyle.Popup
        modifyClassButton.Font = New Font("Sitka Banner", 9F)
        modifyClassButton.Location = New Point(808, 517)
        modifyClassButton.Margin = New Padding(4, 4, 4, 4)
        modifyClassButton.Name = "modifyClassButton"
        modifyClassButton.Size = New Size(110, 36)
        modifyClassButton.TabIndex = 9
        modifyClassButton.Text = "Modify"
        modifyClassButton.UseVisualStyleBackColor = False
        ' 
        ' classDataView
        ' 
        classDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        classDataView.Location = New Point(59, 158)
        classDataView.Margin = New Padding(4, 4, 4, 4)
        classDataView.Name = "classDataView"
        classDataView.RowHeadersWidth = 51
        classDataView.Size = New Size(859, 351)
        classDataView.TabIndex = 8
        ' 
        ' createClassButton
        ' 
        createClassButton.BackColor = Color.DarkSeaGreen
        createClassButton.FlatStyle = FlatStyle.Popup
        createClassButton.Font = New Font("Sitka Banner", 9F)
        createClassButton.Location = New Point(59, 517)
        createClassButton.Margin = New Padding(4, 4, 4, 4)
        createClassButton.Name = "createClassButton"
        createClassButton.Size = New Size(176, 50)
        createClassButton.TabIndex = 7
        createClassButton.Text = "CREATE CLASS"
        createClassButton.UseVisualStyleBackColor = False
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.Location = New Point(59, 114)
        refreshButton.Margin = New Padding(4, 4, 4, 4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(110, 36)
        refreshButton.TabIndex = 11
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentSectionButton
        ' 
        enrollmentSectionButton.BackColor = Color.DarkSeaGreen
        enrollmentSectionButton.FlatStyle = FlatStyle.Popup
        enrollmentSectionButton.Font = New Font("Sitka Banner", 9F)
        enrollmentSectionButton.Location = New Point(739, 23)
        enrollmentSectionButton.Margin = New Padding(4, 4, 4, 4)
        enrollmentSectionButton.Name = "enrollmentSectionButton"
        enrollmentSectionButton.Size = New Size(179, 35)
        enrollmentSectionButton.TabIndex = 12
        enrollmentSectionButton.Text = "Enrollment Section"
        enrollmentSectionButton.UseVisualStyleBackColor = False
        ' 
        ' ClassSectionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 611)
        Controls.Add(enrollmentSectionButton)
        Controls.Add(refreshButton)
        Controls.Add(modifyClassButton)
        Controls.Add(classDataView)
        Controls.Add(createClassButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ClassSectionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ClassSectionForm"
        CType(classDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents modifyClassButton As Button
    Friend WithEvents classDataView As DataGridView
    Friend WithEvents createClassButton As Button
    Friend WithEvents refreshButton As Button
    Friend WithEvents enrollmentSectionButton As Button
End Class
