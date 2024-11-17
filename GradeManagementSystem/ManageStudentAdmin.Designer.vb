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
        TextBox1 = New TextBox()
        addStudent = New Button()
        modifyStudent = New Button()
        searchStudent = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search student here"
        TextBox1.Size = New Size(233, 27)
        TextBox1.TabIndex = 0
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(744, 359)
        DataGridView1.TabIndex = 4
        ' 
        ' ManageStudentAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(searchStudent)
        Controls.Add(modifyStudent)
        Controls.Add(addStudent)
        Controls.Add(TextBox1)
        Name = "ManageStudentAdmin"
        Text = "ManageStudentAdmin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addStudent As Button
    Friend WithEvents modifyStudent As Button
    Friend WithEvents searchStudent As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
