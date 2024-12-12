<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteQuizForm
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
        chooseQuizBox = New DomainUpDown()
        backButton = New Button()
        deleteQuizButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' chooseQuizBox
        ' 
        chooseQuizBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chooseQuizBox.Location = New Point(51, 86)
        chooseQuizBox.Name = "chooseQuizBox"
        chooseQuizBox.Size = New Size(187, 34)
        chooseQuizBox.TabIndex = 16
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(193, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 15
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' deleteQuizButton
        ' 
        deleteQuizButton.Location = New Point(94, 126)
        deleteQuizButton.Name = "deleteQuizButton"
        deleteQuizButton.Size = New Size(94, 29)
        deleteQuizButton.TabIndex = 14
        deleteQuizButton.Text = "Enter"
        deleteQuizButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(85, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 28)
        Label1.TabIndex = 13
        Label1.Text = "Delete Quiz"
        ' 
        ' DeleteQuizForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(303, 177)
        Controls.Add(chooseQuizBox)
        Controls.Add(backButton)
        Controls.Add(deleteQuizButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "DeleteQuizForm"
        Text = "DeleteQuizForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chooseQuizBox As DomainUpDown
    Friend WithEvents backButton As Button
    Friend WithEvents deleteQuizButton As Button
    Friend WithEvents Label1 As Label
End Class
