<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItemForm
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
        addQuizButton = New Button()
        addProjectButton = New Button()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' addQuizButton
        ' 
        addQuizButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addQuizButton.Location = New Point(153, 69)
        addQuizButton.Name = "addQuizButton"
        addQuizButton.Size = New Size(239, 75)
        addQuizButton.TabIndex = 0
        addQuizButton.Text = "Quiz"
        addQuizButton.UseVisualStyleBackColor = True
        ' 
        ' addProjectButton
        ' 
        addProjectButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addProjectButton.Location = New Point(153, 150)
        addProjectButton.Name = "addProjectButton"
        addProjectButton.Size = New Size(239, 75)
        addProjectButton.TabIndex = 1
        addProjectButton.Text = "Project"
        addProjectButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(415, 22)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 2
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddItemForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(540, 306)
        Controls.Add(backButton)
        Controls.Add(addProjectButton)
        Controls.Add(addQuizButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddItemForm"
        Text = "AddItemForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents addQuizButton As Button
    Friend WithEvents addProjectButton As Button
    Friend WithEvents backButton As Button
End Class
