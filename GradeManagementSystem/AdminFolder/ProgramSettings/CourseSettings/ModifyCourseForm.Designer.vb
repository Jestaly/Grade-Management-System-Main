<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyCourseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyCourseForm))
        courseIDTextBox = New MaskedTextBox()
        Label1 = New Label()
        searchfield = New PictureBox()
        backbttn = New PictureBox()
        searchButton = New Button()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' courseIDTextBox
        ' 
        courseIDTextBox.AsciiOnly = True
        courseIDTextBox.Font = New Font("Segoe UI", 10F)
        courseIDTextBox.Location = New Point(196, 74)
        courseIDTextBox.Margin = New Padding(4)
        courseIDTextBox.Mask = "L-000"
        courseIDTextBox.Name = "courseIDTextBox"
        courseIDTextBox.PromptChar = "X"c
        courseIDTextBox.Size = New Size(141, 34)
        courseIDTextBox.TabIndex = 6
        courseIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(39, 71)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 38)
        Label1.TabIndex = 4
        Label1.Text = "Course ID:"
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(187, 55)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(195, 67)
        searchfield.TabIndex = 22
        searchfield.TabStop = False
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 23
        backbttn.TabStop = False
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.ForeColor = Color.White
        searchButton.Location = New Point(338, 69)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(93, 45)
        searchButton.TabIndex = 24
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyCourseForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(484, 168)
        Controls.Add(searchButton)
        Controls.Add(backbttn)
        Controls.Add(courseIDTextBox)
        Controls.Add(Label1)
        Controls.Add(searchfield)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyCourseForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyCourseForm"
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents courseIDTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents departmentIDTextBox As MaskedTextBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents searchButton As Button
End Class
