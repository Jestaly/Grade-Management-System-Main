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
        Label1 = New Label()
        programComboBox = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        courseIDLabel = New Label()
        courseNameTextBox = New TextBox()
        unitTextBox = New TextBox()
        Button2 = New Button()
        modifyCourseButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(107, 217)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 34
        Label1.Text = "Program"
        ' 
        ' programComboBox
        ' 
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(180, 214)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(172, 28)
        programComboBox.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(132, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 32
        Label3.Text = "Units"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(75, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 31
        Label2.Text = "Course Name"
        ' 
        ' courseIDLabel
        ' 
        courseIDLabel.AutoSize = True
        courseIDLabel.Location = New Point(123, 41)
        courseIDLabel.Name = "courseIDLabel"
        courseIDLabel.Size = New Size(48, 20)
        courseIDLabel.TabIndex = 30
        courseIDLabel.Text = "C-000"
        ' 
        ' courseNameTextBox
        ' 
        courseNameTextBox.Location = New Point(180, 108)
        courseNameTextBox.Name = "courseNameTextBox"
        courseNameTextBox.Size = New Size(172, 27)
        courseNameTextBox.TabIndex = 29
        ' 
        ' unitTextBox
        ' 
        unitTextBox.Location = New Point(180, 160)
        unitTextBox.Name = "unitTextBox"
        unitTextBox.Size = New Size(172, 27)
        unitTextBox.TabIndex = 28
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(65, 313)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 29)
        Button2.TabIndex = 27
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' modifyCourseButton
        ' 
        modifyCourseButton.Location = New Point(65, 278)
        modifyCourseButton.Name = "modifyCourseButton"
        modifyCourseButton.Size = New Size(119, 29)
        modifyCourseButton.TabIndex = 26
        modifyCourseButton.Text = "Modify Course"
        modifyCourseButton.UseVisualStyleBackColor = True
        ' 
        ' OfficialModifyCourseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 402)
        Controls.Add(Label1)
        Controls.Add(programComboBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(courseIDLabel)
        Controls.Add(courseNameTextBox)
        Controls.Add(unitTextBox)
        Controls.Add(Button2)
        Controls.Add(modifyCourseButton)
        Name = "OfficialModifyCourseForm"
        Text = "OfficialModifyCourseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents courseIDLabel As Label
    Friend WithEvents courseNameTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents modifyCourseButton As Button
End Class
