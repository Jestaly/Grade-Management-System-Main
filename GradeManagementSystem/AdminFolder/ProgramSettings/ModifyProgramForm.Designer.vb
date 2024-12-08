<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyProgramForm
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
        searchButton = New Button()
        programIDTextBox = New MaskedTextBox()
        backButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sitka Banner Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(82, 67)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 40)
        Label1.TabIndex = 1
        Label1.Text = "Program ID"
        ' 
        ' searchButton
        ' 
        searchButton.BackColor = Color.DarkSeaGreen
        searchButton.FlatStyle = FlatStyle.Popup
        searchButton.Font = New Font("Sitka Banner", 9F)
        searchButton.Location = New Point(162, 207)
        searchButton.Margin = New Padding(4, 4, 4, 4)
        searchButton.Name = "searchButton"
        searchButton.Size = New Size(108, 41)
        searchButton.TabIndex = 2
        searchButton.Text = "Search"
        searchButton.UseVisualStyleBackColor = False
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.AsciiOnly = True
        programIDTextBox.Font = New Font("Sitka Banner", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        programIDTextBox.Location = New Point(82, 111)
        programIDTextBox.Margin = New Padding(4, 4, 4, 4)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(256, 43)
        programIDTextBox.TabIndex = 3
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.Red
        backButton.FlatStyle = FlatStyle.Popup
        backButton.Font = New Font("Sitka Banner", 8F)
        backButton.ForeColor = Color.White
        backButton.Location = New Point(355, 13)
        backButton.Margin = New Padding(4, 4, 4, 4)
        backButton.Name = "backButton"
        backButton.Size = New Size(61, 34)
        backButton.TabIndex = 17
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' ModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(441, 277)
        Controls.Add(backButton)
        Controls.Add(programIDTextBox)
        Controls.Add(searchButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 4, 4, 4)
        Name = "ModifyProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "ModifyProgramForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents searchButton As Button
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents backButton As Button
End Class
