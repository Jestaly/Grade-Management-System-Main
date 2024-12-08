<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(searchstudent))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        searchbttn = New PictureBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        TextBox3 = New TextBox()
        Label6 = New Label()
        CType(searchbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(59, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 32)
        Label1.TabIndex = 0
        Label1.Text = "S T U D E N T S"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(71, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 26)
        Label2.TabIndex = 1
        Label2.Text = "Student ID: "
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkSeaGreen
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(227, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 34)
        TextBox1.TabIndex = 2
        ' 
        ' searchbttn
        ' 
        searchbttn.BackgroundImage = CType(resources.GetObject("searchbttn.BackgroundImage"), Image)
        searchbttn.BackgroundImageLayout = ImageLayout.Stretch
        searchbttn.Location = New Point(418, 129)
        searchbttn.Name = "searchbttn"
        searchbttn.Size = New Size(40, 34)
        searchbttn.TabIndex = 17
        searchbttn.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkSeaGreen
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Sitka Small", 7.5F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(1089, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 23)
        Label3.TabIndex = 18
        Label3.Text = "Total Enrolled Students"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Khaki
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(1089, 123)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(204, 34)
        TextBox2.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Sitka Small", 6F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(1090, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 18)
        Label4.TabIndex = 20
        Label4.Text = "School Year: 2024 - 2025"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(71, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1242, 423)
        DataGridView1.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Sitka Text Semibold", 7F, FontStyle.Bold)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1103, 674)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 43)
        Button1.TabIndex = 22
        Button1.Text = "SELECT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Sitka Text Semibold", 7F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1200, 674)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 43)
        Button2.TabIndex = 23
        Button2.Text = "DASHBOARD"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sitka Small", 6F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(1090, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 18)
        Label5.TabIndex = 24
        Label5.Text = "First Semester"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(583, 169)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 34)
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.DarkSeaGreen
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Segoe UI", 10F)
        TextBox3.Location = New Point(224, 169)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(361, 34)
        TextBox3.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sitka Small", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(71, 173)
        Label6.Name = "Label6"
        Label6.Size = New Size(159, 26)
        Label6.TabIndex = 25
        Label6.Text = "Student Name: "
        ' 
        ' searchstudent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1385, 743)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(searchbttn)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "searchstudent"
        Text = "searchstudent"
        CType(searchbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents searchbttn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
End Class
