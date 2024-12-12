<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyStudentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModifyStudentForm))
        StudentIDLabel = New Label()
        studentIDTextBox = New MaskedTextBox()
        Button1 = New Button()
        searchfield = New PictureBox()
        backbttn = New PictureBox()
        CType(searchfield, ComponentModel.ISupportInitialize).BeginInit()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' StudentIDLabel
        ' 
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StudentIDLabel.ForeColor = Color.DarkGreen
        StudentIDLabel.Location = New Point(47, 67)
        StudentIDLabel.Margin = New Padding(4, 0, 4, 0)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New Size(136, 32)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID:"
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Font = New Font("Segoe UI", 10F)
        studentIDTextBox.Location = New Point(192, 66)
        studentIDTextBox.Margin = New Padding(4)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(142, 34)
        studentIDTextBox.TabIndex = 3
        studentIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGreen
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(334, 60)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 45)
        Button1.TabIndex = 20
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' searchfield
        ' 
        searchfield.BackColor = SystemColors.Control
        searchfield.BackgroundImage = CType(resources.GetObject("searchfield.BackgroundImage"), Image)
        searchfield.BackgroundImageLayout = ImageLayout.Stretch
        searchfield.Location = New Point(184, 47)
        searchfield.Name = "searchfield"
        searchfield.Size = New Size(195, 67)
        searchfield.TabIndex = 22
        searchfield.TabStop = False
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(8, 7)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 29
        backbttn.TabStop = False
        ' 
        ' ModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(476, 154)
        Controls.Add(backbttn)
        Controls.Add(Button1)
        Controls.Add(studentIDTextBox)
        Controls.Add(StudentIDLabel)
        Controls.Add(searchfield)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "ModifyStudentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyStudentForm"
        CType(searchfield, ComponentModel.ISupportInitialize).EndInit()
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StudentIDLabel As Label
    Friend WithEvents studentIDTextBox As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents searchfield As PictureBox
    Friend WithEvents backbttn As PictureBox
End Class
