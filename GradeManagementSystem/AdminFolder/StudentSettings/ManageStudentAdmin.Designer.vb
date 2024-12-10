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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageStudentAdmin))
        searchStudentField = New TextBox()
        addStudent = New Button()
        modifyStudent = New Button()
        dataView = New DataGridView()
        refreshButton = New Button()
        removeStudent = New Button()
        PictureBox1 = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchStudentField
        ' 
        searchStudentField.Font = New Font("Sitka Banner", 11F)
        searchStudentField.Location = New Point(76, 54)
        searchStudentField.Margin = New Padding(4)
        searchStudentField.Name = "searchStudentField"
        searchStudentField.PlaceholderText = "Search Student ID here..."
        searchStudentField.Size = New Size(421, 35)
        searchStudentField.TabIndex = 0
        ' 
        ' addStudent
        ' 
        addStudent.BackColor = Color.DarkSeaGreen
        addStudent.FlatStyle = FlatStyle.Popup
        addStudent.Font = New Font("Sitka Banner", 9F)
        addStudent.Location = New Point(990, 118)
        addStudent.Margin = New Padding(4)
        addStudent.Name = "addStudent"
        addStudent.Size = New Size(144, 36)
        addStudent.TabIndex = 1
        addStudent.Text = "Add Student"
        addStudent.UseVisualStyleBackColor = False
        ' 
        ' modifyStudent
        ' 
        modifyStudent.BackColor = Color.DarkSeaGreen
        modifyStudent.FlatStyle = FlatStyle.Popup
        modifyStudent.Font = New Font("Sitka Banner", 9F)
        modifyStudent.Location = New Point(1142, 118)
        modifyStudent.Margin = New Padding(4)
        modifyStudent.Name = "modifyStudent"
        modifyStudent.Size = New Size(158, 36)
        modifyStudent.TabIndex = 2
        modifyStudent.Text = "Modify Student"
        modifyStudent.UseVisualStyleBackColor = False
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(76, 162)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1224, 492)
        dataView.TabIndex = 4
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.Location = New Point(76, 118)
        refreshButton.Margin = New Padding(4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(89, 36)
        refreshButton.TabIndex = 5
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' removeStudent
        ' 
        removeStudent.BackColor = Color.DarkSeaGreen
        removeStudent.FlatStyle = FlatStyle.Popup
        removeStudent.Font = New Font("Sitka Banner", 9F)
        removeStudent.Location = New Point(1142, 662)
        removeStudent.Margin = New Padding(4)
        removeStudent.Name = "removeStudent"
        removeStudent.Size = New Size(158, 36)
        removeStudent.TabIndex = 6
        removeStudent.Text = "Remove Student"
        removeStudent.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(496, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 34)
        PictureBox1.TabIndex = 72
        PictureBox1.TabStop = False
        ' 
        ' ManageStudentAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1383, 749)
        Controls.Add(PictureBox1)
        Controls.Add(removeStudent)
        Controls.Add(refreshButton)
        Controls.Add(dataView)
        Controls.Add(modifyStudent)
        Controls.Add(addStudent)
        Controls.Add(searchStudentField)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageStudentAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "  "
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchStudentField As TextBox
    Friend WithEvents addStudent As Button
    Friend WithEvents modifyStudent As Button
    Friend WithEvents refreshButton As Button
    Public WithEvents dataView As DataGridView
    Friend WithEvents removeStudent As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
