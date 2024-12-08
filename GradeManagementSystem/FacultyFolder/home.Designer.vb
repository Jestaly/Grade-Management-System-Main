<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        components = New ComponentModel.Container()
        DataGridView1 = New DataGridView()
        Label10 = New Label()
        datetime = New Label()
        Panel4 = New Panel()
        Label9 = New Label()
        Label8 = New Label()
        Timer1 = New Timer(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(82, 388)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(966, 306)
        DataGridView1.TabIndex = 11
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.DarkGreen
        Label10.Location = New Point(78, 346)
        Label10.Name = "Label10"
        Label10.Size = New Size(162, 29)
        Label10.TabIndex = 10
        Label10.Text = "CLASS SCHEDULE"
        ' 
        ' datetime
        ' 
        datetime.AutoSize = True
        datetime.Font = New Font("Sitka Banner Semibold", 8F, FontStyle.Bold)
        datetime.ForeColor = Color.DarkGreen
        datetime.Location = New Point(803, 38)
        datetime.Name = "datetime"
        datetime.Size = New Size(128, 23)
        datetime.TabIndex = 9
        datetime.Text = "Real time and date"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Honeydew
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(77, 134)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(970, 138)
        Panel4.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sitka Banner Semibold", 12F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(30, 43)
        Label9.Name = "Label9"
        Label9.Size = New Size(110, 35)
        Label9.TabIndex = 5
        Label9.Text = "Hello Sese"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sitka Banner Semibold", 12F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(57, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 35)
        Label8.TabIndex = 7
        Label8.Text = "D A S H B O A R D"
        ' 
        ' Timer1
        ' 
        ' 
        ' home
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1134, 828)
        Controls.Add(DataGridView1)
        Controls.Add(Label10)
        Controls.Add(datetime)
        Controls.Add(Panel4)
        Controls.Add(Label8)
        FormBorderStyle = FormBorderStyle.None
        Name = "home"
        Text = "home"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents datetime As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
End Class
