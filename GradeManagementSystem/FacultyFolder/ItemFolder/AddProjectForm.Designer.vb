<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProjectForm
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
        backButton = New Button()
        maxScoreButton = New Button()
        Label1 = New Label()
        maxScoreTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(227, 17)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 7
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' maxScoreButton
        ' 
        maxScoreButton.Location = New Point(104, 123)
        maxScoreButton.Name = "maxScoreButton"
        maxScoreButton.Size = New Size(94, 29)
        maxScoreButton.TabIndex = 6
        maxScoreButton.Text = "Enter"
        maxScoreButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(104, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 5
        Label1.Text = "Max Score"
        ' 
        ' maxScoreTextBox
        ' 
        maxScoreTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        maxScoreTextBox.Location = New Point(61, 79)
        maxScoreTextBox.Name = "maxScoreTextBox"
        maxScoreTextBox.Size = New Size(187, 38)
        maxScoreTextBox.TabIndex = 4
        ' 
        ' AddProjectForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(332, 189)
        Controls.Add(backButton)
        Controls.Add(maxScoreButton)
        Controls.Add(Label1)
        Controls.Add(maxScoreTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddProjectForm"
        Text = "AddProjectForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents maxScoreButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents maxScoreTextBox As TextBox
End Class
