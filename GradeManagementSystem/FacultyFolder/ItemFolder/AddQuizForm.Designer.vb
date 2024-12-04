<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddQuizForm
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
        maxScoreTextBox = New TextBox()
        Label1 = New Label()
        maxScoreButton = New Button()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' maxScoreTextBox
        ' 
        maxScoreTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        maxScoreTextBox.Location = New Point(72, 74)
        maxScoreTextBox.Name = "maxScoreTextBox"
        maxScoreTextBox.Size = New Size(187, 38)
        maxScoreTextBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(115, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 1
        Label1.Text = "Max Score"
        ' 
        ' maxScoreButton
        ' 
        maxScoreButton.Location = New Point(115, 118)
        maxScoreButton.Name = "maxScoreButton"
        maxScoreButton.Size = New Size(94, 29)
        maxScoreButton.TabIndex = 2
        maxScoreButton.Text = "Enter"
        maxScoreButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(238, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 3
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddQuizForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(344, 188)
        Controls.Add(backButton)
        Controls.Add(maxScoreButton)
        Controls.Add(Label1)
        Controls.Add(maxScoreTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddQuizForm"
        Text = "AddQuizForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents maxScoreTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents maxScoreButton As Button
    Friend WithEvents backButton As Button
End Class
