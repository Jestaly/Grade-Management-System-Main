<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetAttendanceForm
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
        numDaysButton = New Button()
        Label1 = New Label()
        numDaysTextBox = New TextBox()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(328, 24)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 15
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' numDaysButton
        ' 
        numDaysButton.Location = New Point(184, 176)
        numDaysButton.Name = "numDaysButton"
        numDaysButton.Size = New Size(94, 29)
        numDaysButton.TabIndex = 14
        numDaysButton.Text = "Enter"
        numDaysButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(159, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 28)
        Label1.TabIndex = 13
        Label1.Text = "Number of Days"
        ' 
        ' numDaysTextBox
        ' 
        numDaysTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        numDaysTextBox.Location = New Point(140, 132)
        numDaysTextBox.Name = "numDaysTextBox"
        numDaysTextBox.Size = New Size(187, 38)
        numDaysTextBox.TabIndex = 12
        ' 
        ' SetAttendanceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(460, 278)
        Controls.Add(backButton)
        Controls.Add(numDaysButton)
        Controls.Add(Label1)
        Controls.Add(numDaysTextBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "SetAttendanceForm"
        Text = "SetAttendance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents numDaysButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents numDaysTextBox As TextBox
End Class
