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
        SuspendLayout()
        ' 
        ' professorIDLabel
        ' 
        professorIDLabel.AutoSize = True
        professorIDLabel.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        professorIDLabel.Location = New Point(227, 64)
        professorIDLabel.Name = "professorIDLabel"
        professorIDLabel.Size = New Size(136, 31)
        professorIDLabel.TabIndex = 1
        professorIDLabel.Text = "Professor ID"
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(223, 177)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(140, 59)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        profIDTextBox.Location = New Point(168, 107)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "0"c
        profIDTextBox.Size = New Size(251, 51)
        profIDTextBox.TabIndex = 3
        ' 
        ' ModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(596, 353)
        Controls.Add(profIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(professorIDLabel)
        Name = "ModifyProfessorForm"
        Text = "ModifyProfessorForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents professorIDLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents profIDTextBox As MaskedTextBox
End Class
