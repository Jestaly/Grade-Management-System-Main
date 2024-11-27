<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyDepartmentForm
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
        departmentIDTextBox = New MaskedTextBox()
        searchButton = New Button()
        Label1 = New Label()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' departmentIDTextBox
        ' 
        departmentIDTextBox.AsciiOnly = True
        departmentIDTextBox.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentIDTextBox.Location = New Point(96, 110)
        departmentIDTextBox.Mask = "L-000"
        departmentIDTextBox.Name = "departmentIDTextBox"
        departmentIDTextBox.PromptChar = "X"c
        departmentIDTextBox.Size = New Size(195, 38)
        departmentIDTextBox.TabIndex = 6
        ' 
        ' searchButton
        ' 
        searchButton.Location = New Point(124, 154)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(130, 45)
        searchButton.TabIndex = 5
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(109, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 31)
        Label1.TabIndex = 4
        Label1.Text = "Department ID"
        ' 
        ' backButton
        ' 
        backButton.Location = New Point(261, 21)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 16
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' ModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(389, 262)
        Controls.Add(backButton)
        Controls.Add(departmentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ModifyDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyDepartmentForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents departmentIDTextBox As MaskedTextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Button
End Class
