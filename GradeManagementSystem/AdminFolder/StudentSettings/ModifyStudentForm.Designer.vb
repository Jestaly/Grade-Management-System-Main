<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyStudentForm
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
        StudentIDLabel = New Label()
        searchButton = New Button()
        studentIDTextBox = New MaskedTextBox()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' StudentIDLabel
        ' 
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StudentIDLabel.ForeColor = Color.DarkGreen
        StudentIDLabel.Location = New Point(44, 66)
        StudentIDLabel.Margin = New Padding(4, 0, 4, 0)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New Size(136, 40)
        StudentIDLabel.TabIndex = 1
        StudentIDLabel.Text = "Student ID"
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkSeaGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F)
        searchButton.Location = New Point(164, 216)
        searchButton.Margin = New Padding(4, 4, 4, 4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(132, 46)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' studentIDTextBox
        ' 
        studentIDTextBox.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentIDTextBox.Location = New Point(48, 111)
        studentIDTextBox.Margin = New Padding(4, 4, 4, 4)
        studentIDTextBox.Mask = "0-00-00000"
        studentIDTextBox.Name = "studentIDTextBox"
        studentIDTextBox.PromptChar = "X"c
        studentIDTextBox.Size = New Size(358, 60)
        studentIDTextBox.TabIndex = 3
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.Red
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F)
        backButton.ForeColor = Color.White
        backButton.Location = New Point(378, 12)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(65, 33)
        backButton.TabIndex = 19
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(456, 298)
        Controls.Add(backButton)
        Controls.Add(studentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(StudentIDLabel)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ModifyStudentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents StudentIDLabel As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents studentIDTextBox As MaskedTextBox
    Friend WithEvents backButton As Button
End Class
