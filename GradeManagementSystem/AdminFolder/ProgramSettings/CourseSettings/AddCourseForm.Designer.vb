<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm
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
        courseIDLabel = New Label()
        courseNameTextBox = New TextBox()
        unitTextBox = New TextBox()
        Button2 = New Button()
        addCourseButton = New Button()
        programComboBox = New ComboBox()
        Label1 = New Label()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(73, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 20)
        Label3.TabIndex = 14
        Label3.Text = "Units"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 20)
        Label2.TabIndex = 13
        Label2.Text = "Course Name"
        ' 
        ' courseIDLabel
        ' 
        courseIDLabel.AutoSize = True
        courseIDLabel.Location = New Point(33, 23)
        courseIDLabel.Name = "courseIDLabel"
        courseIDLabel.Size = New Size(48, 20)
        courseIDLabel.TabIndex = 12
        courseIDLabel.Text = "C-000"
        ' 
        ' courseNameTextBox
        ' 
        courseNameTextBox.Location = New Point(121, 53)
        courseNameTextBox.Name = "courseNameTextBox"
        courseNameTextBox.Size = New Size(172, 27)
        courseNameTextBox.TabIndex = 11
        ' 
        ' unitTextBox
        ' 
        unitTextBox.Location = New Point(121, 86)
        unitTextBox.Name = "unitTextBox"
        unitTextBox.Size = New Size(172, 27)
        unitTextBox.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(154, 153)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 29)
        Button2.TabIndex = 9
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' addCourseButton
        ' 
        addCourseButton.Location = New Point(39, 153)
        addCourseButton.Name = "addCourseButton"
        addCourseButton.Size = New Size(109, 29)
        addCourseButton.TabIndex = 8
        addCourseButton.Text = "Add Course"
        addCourseButton.UseVisualStyleBackColor = True
        ' 
        ' programComboBox
        ' 
        programComboBox.FormattingEnabled = True
        programComboBox.Location = New Point(121, 119)
        programComboBox.Name = "programComboBox"
        programComboBox.Size = New Size(172, 28)
        programComboBox.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 16
        Label1.Text = "Program"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(220, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 18
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' AddCourseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(353, 197)
        Controls.Add(backButton)
        Controls.Add(Label1)
        Controls.Add(programComboBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(courseIDLabel)
        Controls.Add(courseNameTextBox)
        Controls.Add(unitTextBox)
        Controls.Add(Button2)
        Controls.Add(addCourseButton)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddCourseForm"
        Text = "AddCourseForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents courseIDLabel As Label
    Friend WithEvents courseNameTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents addCourseButton As Button
    Friend WithEvents programComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
End Class
