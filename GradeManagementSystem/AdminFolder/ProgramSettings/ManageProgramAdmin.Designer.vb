<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProgramAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProgramAdmin))
        searchProgramField = New TextBox()
        refreshButton = New Button()
        modifyProgramButton = New Button()
        addProgramButton = New Button()
        dataView = New DataGridView()
        removeProgramForm = New Button()
        searchbttn = New PictureBox()
        courseSecButton = New PictureBox()
        Label1 = New Label()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(courseSecButton, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' searchProgramField
        ' 
        searchProgramField.Font = New Font("Sitka Banner", 11F)
        searchProgramField.Location = New Point(60, 49)
        searchProgramField.Margin = New Padding(4)
        searchProgramField.Name = "searchProgramField"
        searchProgramField.PlaceholderText = "Search Program ID here..."
        searchProgramField.Size = New Size(434, 35)
        searchProgramField.TabIndex = 0
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.Location = New Point(62, 149)
        refreshButton.Margin = New Padding(4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(106, 37)
        refreshButton.TabIndex = 2
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' modifyProgramButton
        ' 
        modifyProgramButton.BackColor = Color.DarkSeaGreen
        modifyProgramButton.FlatStyle = FlatStyle.Popup
        modifyProgramButton.Font = New Font("Sitka Banner", 9F)
        modifyProgramButton.Location = New Point(1167, 149)
        modifyProgramButton.Margin = New Padding(4)
        modifyProgramButton.Name = "modifyProgramButton"
        modifyProgramButton.Size = New Size(142, 37)
        modifyProgramButton.TabIndex = 4
        modifyProgramButton.Text = "Modify Program"
        modifyProgramButton.UseVisualStyleBackColor = False
        ' 
        ' addProgramButton
        ' 
        addProgramButton.BackColor = Color.DarkSeaGreen
        addProgramButton.FlatStyle = FlatStyle.Popup
        addProgramButton.Font = New Font("Sitka Banner", 9F)
        addProgramButton.Location = New Point(1019, 149)
        addProgramButton.Margin = New Padding(4)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(140, 37)
        addProgramButton.TabIndex = 5
        addProgramButton.Text = "Add Program"
        addProgramButton.UseVisualStyleBackColor = False
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(62, 194)
        dataView.Margin = New Padding(4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(1247, 455)
        dataView.TabIndex = 6
        ' 
        ' removeProgramForm
        ' 
        removeProgramForm.BackColor = Color.DarkSeaGreen
        removeProgramForm.FlatStyle = FlatStyle.Popup
        removeProgramForm.Font = New Font("Sitka Banner", 9F)
        removeProgramForm.Location = New Point(1158, 657)
        removeProgramForm.Margin = New Padding(4)
        removeProgramForm.Name = "removeProgramForm"
        removeProgramForm.Size = New Size(151, 37)
        removeProgramForm.TabIndex = 7
        removeProgramForm.Text = "Remove Program"
        removeProgramForm.UseVisualStyleBackColor = False
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(495, 49)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(38, 35)
        searchbttn.TabIndex = 8
        searchbttn.TabStop = False
        ' 
        ' courseSecButton
        ' 
        courseSecButton.BackgroundImage = CType(resources.GetObject("courseSecButton.BackgroundImage"), Image)
        courseSecButton.BackgroundImageLayout = ImageLayout.Stretch
        courseSecButton.Location = New Point(1294, 36)
        courseSecButton.Name = "courseSecButton"
        courseSecButton.Size = New Size(55, 34)
        courseSecButton.TabIndex = 9
        courseSecButton.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner", 7F)
        Label1.Location = New Point(1211, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 10
        Label1.Text = "Course Section"
        ' 
        ' ManageProgramAdmin
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1383, 749)
        Controls.Add(Label1)
        Controls.Add(courseSecButton)
        Controls.Add(searchbttn)
        Controls.Add(removeProgramForm)
        Controls.Add(dataView)
        Controls.Add(addProgramButton)
        Controls.Add(modifyProgramButton)
        Controls.Add(refreshButton)
        Controls.Add(searchProgramField)
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ManageProgramAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProgramAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(courseSecButton, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchProgramField As TextBox
    Friend WithEvents refreshButton As Button
    Friend WithEvents modifyProgramButton As Button
    Friend WithEvents addProgramButton As Button
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeProgramForm As Button
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents courseSecButton As PictureBox
    Friend WithEvents Label1 As Label
End Class
