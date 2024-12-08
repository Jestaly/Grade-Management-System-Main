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
        backButton.BackColor = Color.Red
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(365, 13)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(54, 34)
        backButton.TabIndex = 21
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' enrollmentIDTextBox
        ' 
        enrollmentIDTextBox.AsciiOnly = True
        enrollmentIDTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        enrollmentIDTextBox.Location = New Point(59, 116)
        enrollmentIDTextBox.Margin = New Padding(4, 4, 4, 4)
        enrollmentIDTextBox.Mask = "L-000"
        enrollmentIDTextBox.Name = "enrollmentIDTextBox"
        enrollmentIDTextBox.PromptChar = "X"c
        enrollmentIDTextBox.Size = New Size(300, 44)
        enrollmentIDTextBox.TabIndex = 20
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkSeaGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.Location = New Point(154, 201)
        searchButton.Margin = New Padding(4, 4, 4, 4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(106, 40)
        searchButton.TabIndex = 19
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(59, 74)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 40)
        Label1.TabIndex = 18
        Label1.Text = "Enrollment ID"
        ' 
        ' ModifyEnrollStudentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(432, 275)
        Controls.Add(backButton)
        Controls.Add(enrollmentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
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
