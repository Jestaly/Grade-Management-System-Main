<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyCourseForm
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
        Label3 = New Label()
        Label2 = New Label()
        courseNameTextBox = New TextBox()
        unitTextBox = New TextBox()
        Button2 = New Button()
        modifyCourseButton = New Button()
        backButton = New Button()
        courseIDTextBox = New MaskedTextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 32
        Label3.Text = "Units"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 31
        Label2.Text = "Course Name"
        ' 
        ' courseNameTextBox
        ' 
        courseNameTextBox.Location = New Point(114, 68)
        courseNameTextBox.Name = "courseNameTextBox"
        courseNameTextBox.Size = New Size(172, 27)
        courseNameTextBox.TabIndex = 29
        ' 
        ' unitTextBox
        ' 
        unitTextBox.Location = New Point(114, 101)
        unitTextBox.Name = "unitTextBox"
        unitTextBox.Size = New Size(172, 27)
        unitTextBox.TabIndex = 28
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(178, 168)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 29)
        Button2.TabIndex = 27
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' modifyCourseButton
        ' 
        modifyCourseButton.Location = New Point(52, 168)
        modifyCourseButton.Name = "modifyCourseButton"
        modifyCourseButton.Size = New Size(119, 29)
        modifyCourseButton.TabIndex = 26
        modifyCourseButton.Text = "Modify Course"
        modifyCourseButton.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(245, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 35
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' courseIDTextBox
        ' 
        courseIDTextBox.Enabled = False
        courseIDTextBox.Location = New Point(114, 35)
        courseIDTextBox.Mask = "L-000"
        courseIDTextBox.Name = "courseIDTextBox"
        courseIDTextBox.PromptChar = "X"c
        courseIDTextBox.Size = New Size(107, 27)
        courseIDTextBox.TabIndex = 37
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 36
        Label1.Text = "Course ID"
        ' 
        ' OfficialModifyCourseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(353, 221)
        Controls.Add(courseIDTextBox)
        Controls.Add(Label1)
        Controls.Add(backButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(courseNameTextBox)
        Controls.Add(unitTextBox)
        Controls.Add(Button2)
        Controls.Add(modifyCourseButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "OfficialModifyCourseForm"
        Text = "OfficialModifyCourseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents courseNameTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents modifyCourseButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents courseIDTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
End Class
