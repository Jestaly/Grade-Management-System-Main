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
        departmentIDTextBox.Font = New Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        departmentIDTextBox.Location = New Point(64, 114)
        departmentIDTextBox.Margin = New Padding(4)
        departmentIDTextBox.Mask = "L-000"
        departmentIDTextBox.Name = "departmentIDTextBox"
        departmentIDTextBox.PromptChar = "X"c
        departmentIDTextBox.Size = New Size(317, 43)
        departmentIDTextBox.TabIndex = 6
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkSeaGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchButton.ForeColor = Color.Black
        searchButton.Location = New Point(116, 207)
        searchButton.Margin = New Padding(4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(94, 45)
        searchButton.TabIndex = 5
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(60, 71)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 40)
        Label1.TabIndex = 4
        Label1.Text = "Department ID"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.Red
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backButton.ForeColor = Color.White
        backButton.Location = New Point(229, 207)
        backButton.Margin = New Padding(4)
        backButton.Name = "backButton"
        backButton.Size = New Size(95, 45)
        backButton.TabIndex = 16
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(450, 310)
        Controls.Add(backButton)
        Controls.Add(departmentIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
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
