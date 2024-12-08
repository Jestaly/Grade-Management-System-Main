<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProfessorAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProfessorAdmin))
        refreshButton = New Button()
        addProfessorButton = New Button()
        modifyProfessorButton = New Button()
        searchProfessorField = New TextBox()
        dataView = New DataGridView()
        removeProfButton = New Button()
        searchbttn = New PictureBox()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' refreshButton
        ' 
        refreshButton.BackColor = Color.DarkSeaGreen
        refreshButton.FlatStyle = FlatStyle.Popup
        refreshButton.Font = New Font("Sitka Banner", 9F)
        refreshButton.Location = New Point(37, 127)
        refreshButton.Margin = New Padding(4, 4, 4, 4)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(118, 36)
        refreshButton.TabIndex = 0
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = False
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.BackColor = Color.DarkSeaGreen
        addProfessorButton.FlatStyle = FlatStyle.Popup
        addProfessorButton.Font = New Font("Sitka Banner", 9F)
        addProfessorButton.Location = New Point(840, 127)
        addProfessorButton.Margin = New Padding(4, 4, 4, 4)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(152, 36)
        addProfessorButton.TabIndex = 2
        addProfessorButton.Text = "Add Professor"
        addProfessorButton.UseVisualStyleBackColor = False
        ' 
        ' modifyProfessorButton
        ' 
        modifyProfessorButton.BackColor = Color.DarkSeaGreen
        modifyProfessorButton.FlatStyle = FlatStyle.Popup
        modifyProfessorButton.Font = New Font("Sitka Banner", 9F)
        modifyProfessorButton.Location = New Point(673, 127)
        modifyProfessorButton.Margin = New Padding(4, 4, 4, 4)
        modifyProfessorButton.Name = "modifyProfessorButton"
        modifyProfessorButton.Size = New Size(159, 36)
        modifyProfessorButton.TabIndex = 3
        modifyProfessorButton.Text = "Modify Professor"
        modifyProfessorButton.UseVisualStyleBackColor = False
        ' 
        ' searchProfessorField
        ' 
        searchProfessorField.Font = New Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchProfessorField.Location = New Point(37, 39)
        searchProfessorField.Margin = New Padding(4, 4, 4, 4)
        searchProfessorField.Name = "searchProfessorField"
        searchProfessorField.PlaceholderText = "Search Professor here..."
        searchProfessorField.Size = New Size(333, 33)
        searchProfessorField.TabIndex = 4
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(37, 171)
        dataView.Margin = New Padding(4, 4, 4, 4)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(955, 398)
        dataView.TabIndex = 5
        ' 
        ' removeProfButton
        ' 
        removeProfButton.BackColor = Color.DarkSeaGreen
        removeProfButton.FlatStyle = FlatStyle.Popup
        removeProfButton.Font = New Font("Sitka Banner", 9F)
        removeProfButton.Location = New Point(816, 577)
        removeProfButton.Margin = New Padding(4, 4, 4, 4)
        removeProfButton.Name = "removeProfButton"
        removeProfButton.Size = New Size(176, 36)
        removeProfButton.TabIndex = 6
        removeProfButton.Text = "Remove Professor"
        removeProfButton.UseVisualStyleBackColor = False
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(371, 37)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(38, 35)
        searchbttn.TabIndex = 9
        searchbttn.TabStop = False
        ' 
        ' ManageProfessorAdmin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1031, 654)
        Controls.Add(searchbttn)
        Controls.Add(removeProfButton)
        Controls.Add(dataView)
        Controls.Add(searchProfessorField)
        Controls.Add(modifyProfessorButton)
        Controls.Add(addProfessorButton)
        Controls.Add(refreshButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ManageProfessorAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProfessorAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents addProfessorButton As Button
    Friend WithEvents modifyProfessorButton As Button
    Friend WithEvents searchProfessorField As TextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeProfButton As Button
    Friend WithEvents searchbttn As PictureBox
End Class
