<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyDepartmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyDepartmentForm))
        departmentIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        searchfield = New PictureBox()
        backbttn = New PictureBox()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' departmentIDTextBox
        ' 
        departmentIDTextBox.AsciiOnly = True
        departmentIDTextBox.BackColor = SystemColors.Control
        departmentIDTextBox.Font = New Font("Segoe UI Semibold", 9.8F, FontStyle.Bold)
        departmentIDTextBox.Location = New Point(214, 68)
        departmentIDTextBox.Margin = New Padding(4)
        departmentIDTextBox.Mask = "L-000"
        departmentIDTextBox.Name = "departmentIDTextBox"
        departmentIDTextBox.PromptChar = "X"c
        departmentIDTextBox.Size = New Size(131, 34)
        departmentIDTextBox.TabIndex = 6
        departmentIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.ForeColor = Color.White
        searchButton.Location = New Point(341, 62)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(91, 45)
        searchButton.TabIndex = 5
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(30, 69)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 32)
        Label1.TabIndex = 4
        Label1.Text = "Department ID:"
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(207, 49)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(195, 67)
        searchfield.TabIndex = 19
        searchfield.TabStop = False
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 20
        backbttn.TabStop = False
        ' 
        ' ModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(456, 150)
        Controls.Add(searchButton)
        Controls.Add(backbttn)
        Controls.Add(departmentIDTextBox)
        Controls.Add(searchfield)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyDepartmentForm"
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents departmentIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents backbttn As PictureBox
End Class
