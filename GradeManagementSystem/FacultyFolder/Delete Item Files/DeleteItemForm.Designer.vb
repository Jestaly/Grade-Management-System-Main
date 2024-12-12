<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteItemForm
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
        deleteProjectButton = New Button()
        deleteQuizButton = New Button()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(348, 20)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 5
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' deleteProjectButton
        ' 
        deleteProjectButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deleteProjectButton.Location = New Point(113, 152)
        deleteProjectButton.Name = "deleteProjectButton"
        deleteProjectButton.Size = New Size(239, 75)
        deleteProjectButton.TabIndex = 4
        deleteProjectButton.Text = "Project"
        deleteProjectButton.UseVisualStyleBackColor = True
        ' 
        ' deleteQuizButton
        ' 
        deleteQuizButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deleteQuizButton.Location = New Point(113, 71)
        deleteQuizButton.Name = "deleteQuizButton"
        deleteQuizButton.Size = New Size(239, 75)
        deleteQuizButton.TabIndex = 3
        deleteQuizButton.Text = "Quiz"
        deleteQuizButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteItemForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(470, 270)
        Controls.Add(backButton)
        Controls.Add(deleteProjectButton)
        Controls.Add(deleteQuizButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "DeleteItemForm"
        Text = "DeleteItemForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents deleteProjectButton As Button
    Friend WithEvents deleteQuizButton As Button
End Class
