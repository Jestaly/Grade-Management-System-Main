<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyGradeWeightForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyGradeWeightForm))
        deptIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        backbttn = New PictureBox()
        searchfield = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' deptIDTextBox
        ' 
        deptIDTextBox.AsciiOnly = True
        deptIDTextBox.Font = New Font("Segoe UI", 10F)
        deptIDTextBox.Location = New Point(273, 74)
        deptIDTextBox.Margin = New Padding(4)
        deptIDTextBox.Mask = "L-000"
        deptIDTextBox.Name = "deptIDTextBox"
        deptIDTextBox.PromptChar = "X"c
        deptIDTextBox.Size = New Size(129, 34)
        deptIDTextBox.TabIndex = 24
        deptIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.ForeColor = Color.White
        searchButton.Location = New Point(400, 70)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(116, 42)
        searchButton.TabIndex = 23
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(62, 71)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 38)
        Label1.TabIndex = 22
        Label1.Text = "Department ID:"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 13)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 26
        backbttn.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(267, 55)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(195, 67)
        searchfield.TabIndex = 29
        searchfield.TabStop = False
        ' 
        ' ModifyGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(588, 168)
        Controls.Add(backbttn)
        Controls.Add(deptIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(searchfield)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyGradeWeightForm"
        Text = "ModifyGradeWeightForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents deptIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents searchfield As PictureBox
End Class
