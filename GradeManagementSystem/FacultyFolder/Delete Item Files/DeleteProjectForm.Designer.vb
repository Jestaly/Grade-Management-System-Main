<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteProjectForm
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
        Label1 = New Label()
        chooseProjectBox = New DomainUpDown()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(213, 21)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 11
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' deleteProjectButton
        ' 
        deleteProjectButton.Location = New Point(114, 135)
        deleteProjectButton.Name = "deleteProjectButton"
        deleteProjectButton.Size = New Size(94, 29)
        deleteProjectButton.TabIndex = 10
        deleteProjectButton.Text = "Enter"
        deleteProjectButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(96, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 28)
        Label1.TabIndex = 9
        Label1.Text = "Delete Project"
        ' 
        ' chooseProjectBox
        ' 
        chooseProjectBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chooseProjectBox.Location = New Point(71, 95)
        chooseProjectBox.Name = "chooseProjectBox"
        chooseProjectBox.Size = New Size(187, 34)
        chooseProjectBox.TabIndex = 12
        ' 
        ' DeleteProjectForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(326, 185)
        Controls.Add(chooseProjectBox)
        Controls.Add(backButton)
        Controls.Add(deleteProjectButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DeleteProjectForm"
        Text = "DeleteProjectForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents deleteProjectButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chooseProjectBox As DomainUpDown
End Class
