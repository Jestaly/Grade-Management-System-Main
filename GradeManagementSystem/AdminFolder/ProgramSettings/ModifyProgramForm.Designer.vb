<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyProgramForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyProgramForm))
        Label1 = New Label()
        searchButton = New Button()
        programIDTextBox = New MaskedTextBox()
        searchfield = New PictureBox()
        backbttn = New PictureBox()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(53, 68)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 32)
        Label1.TabIndex = 1
        Label1.Text = "Program ID:"
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F)
        searchButton.ForeColor = Color.White
        searchButton.Location = New Point(320, 60)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(96, 46)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.AsciiOnly = True
        programIDTextBox.Font = New Font("Segoe UI", 10F)
        programIDTextBox.Location = New Point(199, 67)
        programIDTextBox.Margin = New Padding(4)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(126, 34)
        programIDTextBox.TabIndex = 3
        programIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(191, 48)
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
        backbttn.Size = New Size(44, 35)
        backbttn.TabIndex = 23
        backbttn.TabStop = False
        ' 
        ' ModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(464, 146)
        Controls.Add(backbttn)
        Controls.Add(searchButton)
        Controls.Add(programIDTextBox)
        Controls.Add(searchfield)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyProgramForm"
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents backbttn As PictureBox
End Class
