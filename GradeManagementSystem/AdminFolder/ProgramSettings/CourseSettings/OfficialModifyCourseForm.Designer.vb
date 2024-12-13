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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyCourseForm))
        Label3 = New Label()
        Label2 = New Label()
        courseNameTextBox = New TextBox()
        unitTextBox = New TextBox()
        Button2 = New Button()
        modifyCourseButton = New Button()
        courseIDTextBox = New MaskedTextBox()
        Label1 = New Label()
        backbttn = New PictureBox()
        Label4 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(131, 175)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 32
        Label3.Text = "Units:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(64, 136)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 31
        Label2.Text = "Course Name:"
        ' 
        ' courseNameTextBox
        ' 
        courseNameTextBox.Location = New Point(200, 136)
        courseNameTextBox.Margin = New Padding(4)
        courseNameTextBox.Name = "courseNameTextBox"
        courseNameTextBox.Size = New Size(214, 31)
        courseNameTextBox.TabIndex = 29
        ' 
        ' unitTextBox
        ' 
        unitTextBox.Location = New Point(199, 172)
        unitTextBox.Margin = New Padding(4)
        unitTextBox.Name = "unitTextBox"
        unitTextBox.Size = New Size(214, 31)
        unitTextBox.TabIndex = 28
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(267, 239)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 36)
        Button2.TabIndex = 27
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' modifyCourseButton
        ' 
        modifyCourseButton.BackColor = Color.DarkGreen
        modifyCourseButton.FlatStyle = FlatStyle.Flat
        modifyCourseButton.ForeColor = Color.White
        modifyCourseButton.Location = New Point(103, 239)
        modifyCourseButton.Margin = New Padding(4)
        modifyCourseButton.Name = "modifyCourseButton"
        modifyCourseButton.Size = New Size(127, 36)
        modifyCourseButton.TabIndex = 26
        modifyCourseButton.Text = "Modify"
        modifyCourseButton.UseVisualStyleBackColor = False
        ' 
        ' courseIDTextBox
        ' 
        courseIDTextBox.Enabled = False
        courseIDTextBox.Location = New Point(199, 97)
        courseIDTextBox.Margin = New Padding(4)
        courseIDTextBox.Mask = "L-000"
        courseIDTextBox.Name = "courseIDTextBox"
        courseIDTextBox.PromptChar = "X"c
        courseIDTextBox.Size = New Size(215, 31)
        courseIDTextBox.TabIndex = 37
        courseIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(94, 97)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 36
        Label1.Text = "Course ID:"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 11)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 36)
        backbttn.TabIndex = 38
        backbttn.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(160, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(213, 25)
        Label4.TabIndex = 39
        Label4.Text = "M O D I F Y   C O U R S E"
        ' 
        ' OfficialModifyCourseForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(513, 306)
        Controls.Add(Label4)
        Controls.Add(backbttn)
        Controls.Add(courseIDTextBox)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(courseNameTextBox)
        Controls.Add(unitTextBox)
        Controls.Add(Button2)
        Controls.Add(modifyCourseButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "OfficialModifyCourseForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyCourseForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents courseNameTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents modifyCourseButton As Button
    Friend WithEvents courseIDTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label4 As Label
End Class
