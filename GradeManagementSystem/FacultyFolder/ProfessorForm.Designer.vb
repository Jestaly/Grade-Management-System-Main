<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfessorForm
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
        Label1 = New Label()
        dataGridView1 = New DataGridView()
        dataGridView2 = New DataGridView()
        dataGridView3 = New DataGridView()
        refreshButton = New Button()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(195, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 62)
        Label1.TabIndex = 0
        Label1.Text = "PROFESSOR FORM"
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Location = New Point(124, 140)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersVisible = False
        dataGridView1.RowHeadersWidth = 51
        dataGridView1.ScrollBars = ScrollBars.Horizontal
        dataGridView1.Size = New Size(168, 263)
        dataGridView1.TabIndex = 1
        ' 
        ' dataGridView2
        ' 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView2.Location = New Point(292, 140)
        dataGridView2.Name = "dataGridView2"
        dataGridView2.RowHeadersVisible = False
        dataGridView2.RowHeadersWidth = 51
        dataGridView2.ScrollBars = ScrollBars.Horizontal
        dataGridView2.Size = New Size(168, 263)
        dataGridView2.TabIndex = 2
        ' 
        ' dataGridView3
        ' 
        dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView3.Location = New Point(460, 140)
        dataGridView3.Name = "dataGridView3"
        dataGridView3.RowHeadersVisible = False
        dataGridView3.RowHeadersWidth = 51
        dataGridView3.Size = New Size(168, 263)
        dataGridView3.TabIndex = 3
        ' 
        ' refreshButton
        ' 
        refreshButton.Location = New Point(118, 105)
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(94, 29)
        refreshButton.TabIndex = 4
        refreshButton.Text = "Refresh"
        refreshButton.UseVisualStyleBackColor = True
        ' 
        ' ProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(refreshButton)
        Controls.Add(dataGridView3)
        Controls.Add(dataGridView2)
        Controls.Add(dataGridView1)
        Controls.Add(Label1)
        Name = "ProfessorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfessorForm"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(dataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents dataGridView2 As DataGridView
    Friend WithEvents dataGridView3 As DataGridView
    Friend WithEvents refreshButton As Button
End Class
