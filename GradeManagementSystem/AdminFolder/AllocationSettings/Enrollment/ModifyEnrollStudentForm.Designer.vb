<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyEnrollStudentForm
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
        enrollmentIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(226, 12)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 21
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.AsciiOnly = True
        enrollmentIDTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrollmentIDTextBox.Location = New Point(73, 93)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(187, 38)
        enrollmentIDTextBox.TabIndex = 20
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(102, 137)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(130, 45)
        searchButton.TabIndex = 19
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(92, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 31)
        Label1.TabIndex = 18
        Label1.Text = "Enrollment ID"
        ' 
        ' ModifyEnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(346, 220)
        Controls.Add(backButton)
        Controls.Add(enrollmentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModifyEnrollStudentForm"
        Text = "ModifyEnrollStudentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents enrollmentIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
End Class
