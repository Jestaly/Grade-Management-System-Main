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
        Label1 = New Label()
        searchButton = New Button()
        programIDTextBox = New MaskedTextBox()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(114, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 31)
        Label1.TabIndex = 1
        Label1.Text = "Program ID"
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(114, 133)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(130, 45)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.AsciiOnly = True
        programIDTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        programIDTextBox.Location = New Point(90, 89)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(184, 38)
        programIDTextBox.TabIndex = 3
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(265, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 17
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' ModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(371, 215)
        Controls.Add(backButton)
        Controls.Add(programIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModifyProgramForm"
        Text = "ModifyProgramForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents backButton As Button
End Class
