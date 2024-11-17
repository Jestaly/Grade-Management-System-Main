<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStudentAdmin
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
        searchStudentField = New TextBox()
        addStudent = New Button()
        modifyStudent = New Button()
        searchStudent = New Button()
        dataView = New DataGridView()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchStudentField
        ' 
        searchStudentField.Location = New Point(28, 35)
        searchStudentField.Name = "searchStudentField"
        searchStudentField.PlaceholderText = "Search student here"
        searchStudentField.Size = New Size(233, 27)
        searchStudentField.TabIndex = 0
        ' 
        ' addStudent
        ' 
        addStudent.Location = New Point(525, 33)
        addStudent.Name = "addStudent"
        addStudent.Size = New Size(115, 29)
        addStudent.TabIndex = 1
        addStudent.Text = "Add Student"
        addStudent.UseVisualStyleBackColor = True
        ' 
        ' modifyStudent
        ' 
        modifyStudent.Location = New Point(646, 33)
        modifyStudent.Name = "modifyStudent"
        modifyStudent.Size = New Size(126, 29)
        modifyStudent.TabIndex = 2
        modifyStudent.Text = "Modify Student"
        modifyStudent.UseVisualStyleBackColor = True
        ' 
        ' searchStudent
        ' 
        searchStudent.Location = New Point(267, 33)
        searchStudent.Name = "searchStudent"
        searchStudent.Size = New Size(94, 29)
        searchStudent.TabIndex = 3
        searchStudent.Text = "Search"
        searchStudent.UseVisualStyleBackColor = True
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(28, 68)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(744, 359)
        dataView.TabIndex = 4
        ' 
        ' ManageStudentAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(dataView)
        Controls.Add(searchStudent)
        Controls.Add(modifyStudent)
        Controls.Add(addStudent)
        Controls.Add(searchStudentField)
        Name = "ManageStudentAdmin"
        Text = "  "
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchStudentField As TextBox
    Friend WithEvents addStudent As Button
    Friend WithEvents modifyStudent As Button
    Friend WithEvents searchStudent As Button
    Friend WithEvents dataView As DataGridView
End Class
