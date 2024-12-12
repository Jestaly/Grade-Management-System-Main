<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyProfessorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyProfessorForm))
        professorIDLabel = New Label()
        profIDTextBox = New MaskedTextBox()
        searchb = New Button()
        searchfield = New PictureBox()
        backbttn = New PictureBox()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' professorIDLabel
        ' 
        professorIDLabel.AutoSize = True
        professorIDLabel.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        professorIDLabel.ForeColor = Color.DarkGreen
        professorIDLabel.Location = New Point(43, 69)
        professorIDLabel.Margin = New Padding(4, 0, 4, 0)
        professorIDLabel.Name = "professorIDLabel"
        professorIDLabel.Size = New Size(167, 36)
        professorIDLabel.TabIndex = 1
        professorIDLabel.Text = "Professor ID:"
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Font = New Font("Segoe UI", 10F)
        profIDTextBox.Location = New Point(213, 71)
        profIDTextBox.Margin = New Padding(4)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "X"c
        profIDTextBox.Size = New Size(125, 34)
        profIDTextBox.TabIndex = 3
        profIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchb
        ' 
        searchb.BackColor = Color.DarkGreen
        searchb.FlatStyle = FlatStyle.Popup
        searchb.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchb.ForeColor = Color.White
        searchb.Location = New Point(340, 65)
        searchb.Margin = New Padding(4)
        searchb.Name = "searchb"
        searchb.Size = New Size(85, 45)
        searchb.TabIndex = 20
        searchb.Text = "Search"
        searchb.UseVisualStyleBackColor = False
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(206, 52)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(189, 67)
        searchfield.TabIndex = 22
        searchfield.TabStop = False
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(4, 2)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 23
        backbttn.TabStop = False
        ' 
        ' ModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(477, 156)
        Controls.Add(backbttn)
        Controls.Add(searchb)
        Controls.Add(profIDTextBox)
        Controls.Add(professorIDLabel)
        Controls.Add(searchfield)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyProfessorForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyProfessorForm"
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents professorIDLabel As Label
    Friend WithEvents profIDTextBox As MaskedTextBox
    Friend WithEvents searchb As Button
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents backbttn As PictureBox
End Class
