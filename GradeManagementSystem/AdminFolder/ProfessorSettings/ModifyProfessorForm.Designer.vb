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
        professorIDLabel = New Label()
        searchButton = New Button()
        profIDTextBox = New MaskedTextBox()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' professorIDLabel
        ' 
        professorIDLabel.AutoSize = True
        professorIDLabel.Font = New Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        professorIDLabel.ForeColor = Color.DarkGreen
        professorIDLabel.Location = New Point(49, 72)
        professorIDLabel.Margin = New Padding(4, 0, 4, 0)
        professorIDLabel.Name = "professorIDLabel"
        professorIDLabel.Size = New Size(152, 40)
        professorIDLabel.TabIndex = 1
        professorIDLabel.Text = "Professor ID"
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkSeaGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Location = New Point(153, 213)
        searchButton.Margin = New Padding(4, 4, 4, 4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(93, 36)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Font = New Font("Segoe UI", 19F)
        profIDTextBox.Location = New Point(47, 114)
        profIDTextBox.Margin = New Padding(4, 4, 4, 4)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "X"c
        profIDTextBox.Size = New Size(313, 58)
        profIDTextBox.TabIndex = 3
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.Red
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 8F)
        backButton.ForeColor = Color.White
        backButton.Location = New Point(337, 13)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(53, 30)
        backButton.TabIndex = 16
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(403, 280)
        Controls.Add(backButton)
        Controls.Add(profIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(professorIDLabel)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ModifyProfessorForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyProfessorForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents professorIDLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents profIDTextBox As MaskedTextBox
    Friend WithEvents backButton As Button
End Class
