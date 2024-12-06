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
        refreshButton = New Button()
        searchButton = New Button()
        addProfessorButton = New Button()
        modifyProfessorButton = New Button()
        searchProfessorField = New TextBox()
        dataView = New DataGridView()
        removeProfButton = New Button()
        CType(dataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(16, 85)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 0
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(212, 30)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(94, 29)
        searchButton.TabIndex = 1
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.Location = New Point(642, 30)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(138, 29)
        addProfessorButton.TabIndex = 2
        addProfessorButton.Text = "Add Professor"
        addProfessorButton.UseVisualStyleBackColor = True
        ' 
        ' modifyProfessorButton
        ' 
        modifyProfessorButton.Location = New Point(490, 30)
        modifyProfessorButton.Name = "modifyProfessorButton"
        modifyProfessorButton.Size = New Size(146, 29)
        modifyProfessorButton.TabIndex = 3
        modifyProfessorButton.Text = "Modify Professor"
        modifyProfessorButton.UseVisualStyleBackColor = True
        ' 
        ' searchProfessorField
        ' 
        searchProfessorField.Location = New Point(16, 32)
        searchProfessorField.Name = "searchProfessorField"
        searchProfessorField.PlaceholderText = "Search Professor here.."
        searchProfessorField.Size = New Size(190, 27)
        searchProfessorField.TabIndex = 4
        ' 
        ' dataView
        ' 
        dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataView.Location = New Point(16, 120)
        dataView.Name = "dataView"
        dataView.RowHeadersWidth = 51
        dataView.Size = New Size(764, 318)
        dataView.TabIndex = 5
        ' 
        ' removeProfButton
        ' 
        removeProfButton.Location = New Point(639, 65)
        removeProfButton.Name = "removeProfButton"
        removeProfButton.Size = New Size(141, 29)
        removeProfButton.TabIndex = 6
        removeProfButton.Text = "Remove Professor"
        removeProfButton.UseVisualStyleBackColor = True
        ' 
        ' ManageProfessorAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(removeProfButton)
        Controls.Add(dataView)
        Controls.Add(searchProfessorField)
        Controls.Add(modifyProfessorButton)
        Controls.Add(addProfessorButton)
        Controls.Add(searchButton)
        Controls.Add(refreshButton)
        Name = "ManageProfessorAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ManageProfessorAdmin"
        CType(dataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents refreshButton As Button
    Friend WithEvents searchButton As Button
    Friend WithEvents addProfessorButton As Button
    Friend WithEvents modifyProfessorButton As Button
    Friend WithEvents searchProfessorField As TextBox
    Friend WithEvents dataView As DataGridView
    Friend WithEvents removeProfButton As Button
End Class
