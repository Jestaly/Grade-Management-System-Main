<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyGradeWeightForm
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
        deptIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(233, 21)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 25
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' deptIDTextBox
        ' 
        deptIDTextBox.AsciiOnly = True
        deptIDTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        deptIDTextBox.Location = New Point(87, 102)
        deptIDTextBox.Mask = "L-000"
        deptIDTextBox.Name = "deptIDTextBox"
        deptIDTextBox.PromptChar = "X"c
        deptIDTextBox.Size = New Size(187, 38)
        deptIDTextBox.TabIndex = 24
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(116, 146)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(130, 45)
        searchButton.TabIndex = 23
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(99, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 31)
        Label1.TabIndex = 22
        Label1.Text = "Department ID"
        ' 
        ' ModifyGradeWeightForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(365, 243)
        Controls.Add(backButton)
        Controls.Add(deptIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModifyGradeWeightForm"
        Text = "ModifyGradeWeightForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents backButton As Button
    Friend WithEvents deptIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
End Class
