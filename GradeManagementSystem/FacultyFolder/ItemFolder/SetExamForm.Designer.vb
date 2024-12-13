<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetExamForm
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
        examLimButton = New Button()
        Label1 = New Label()
        examLimTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(340, 25)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' examLimButton
        ' 
        examLimButton.Location = New Point(185, 177)
        examLimButton.Name = "examLimButton"
        examLimButton.Size = New Size(94, 29)
        examLimButton.TabIndex = 18
        examLimButton.Text = "Enter"
        examLimButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(153, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 28)
        Label1.TabIndex = 17
        Label1.Text = "Exam Score Limit"
        ' 
        ' examLimTextBox
        ' 
        examLimTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        examLimTextBox.Location = New Point(141, 133)
        examLimTextBox.Name = "examLimTextBox"
        examLimTextBox.Size = New Size(187, 38)
        examLimTextBox.TabIndex = 16
        ' 
        ' SetExamForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(460, 278)
        Controls.Add(backButton)
        Controls.Add(examLimButton)
        Controls.Add(Label1)
        Controls.Add(examLimTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "SetExamForm"
        Text = "SetExamForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents examLimButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents examLimTextBox As TextBox
End Class
