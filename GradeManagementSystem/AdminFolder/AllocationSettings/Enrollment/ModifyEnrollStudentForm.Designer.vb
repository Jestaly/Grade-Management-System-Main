<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyEnrollStudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyEnrollStudentForm))
        enrollmentIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        backbttn = New PictureBox()
        searchfield = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.AsciiOnly = True
        enrollmentIDTextBox.Font = New Font("Segoe UI", 10F)
        enrollmentIDTextBox.Location = New Point(243, 62)
        enrollmentIDTextBox.Margin = New Padding(4)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(130, 34)
        enrollmentIDTextBox.TabIndex = 20
        enrollmentIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.ForeColor = Color.White
        searchButton.Location = New Point(369, 55)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(99, 50)
        searchButton.TabIndex = 19
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(48, 57)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 38)
        Label1.TabIndex = 18
        Label1.Text = "Enrollment ID:"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 22
        backbttn.TabStop = False
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(236, 43)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(195, 67)
        searchfield.TabIndex = 25
        searchfield.TabStop = False
        ' 
        ' ModifyEnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(536, 152)
        Controls.Add(backbttn)
        Controls.Add(enrollmentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        Controls.Add(searchfield)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyEnrollStudentForm"
        Text = "ModifyEnrollStudentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents enrollmentIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents searchfield As PictureBox
End Class
