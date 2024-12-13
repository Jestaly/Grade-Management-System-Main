<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class searchprogram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        searchbttn = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.searchbttn
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(464, 141)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 27)
        PictureBox1.TabIndex = 71
        PictureBox1.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DarkSeaGreen
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 10.0F)
        TextBox2.Location = New Point(201, 139)
        TextBox2.Margin = New Padding(2, 2, 2, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(261, 30)
        TextBox2.TabIndex = 70
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 9.0F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(73, 142)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 21)
        Label3.TabIndex = 69
        Label3.Text = "Program Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 6.0F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(1050, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 14)
        Label5.TabIndex = 68
        Label5.Text = "First Semester"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Sitka Text Semibold", 7.0F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1211, 663)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 43)
        Button2.TabIndex = 67
        Button2.Text = "DASHBOARD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(91, 240)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1219, 404)
        DataGridView1.TabIndex = 66
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 6.0F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(1142, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 18)
        Label4.TabIndex = 65
        Label4.Text = "School Year: 2024 - 2025"
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = My.Resources.Resources.searchbttn
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(355, 109)
        searchbttn.Margin = New Padding(2, 2, 2, 2)
        searchbttn.Name = "searchbttn"
        searchbttn.TabIndex = 64
        searchbttn.TabIndex = 64
        searchbttn.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkSeaGreen
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10.0F)
        TextBox1.Location = New Point(200, 107)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(153, 30)
        TextBox1.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 9.0F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(73, 110)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 21)
        Label2.TabIndex = 62
        Label2.Text = "Program ID:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(54, 30)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 28)
        Label1.TabIndex = 61
        Label1.Text = "P R O G R A M S "
        ' 
        ' searchprogram
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 743)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(searchbttn)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Text = "searchprogram"
        Text = "searchprogram"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
