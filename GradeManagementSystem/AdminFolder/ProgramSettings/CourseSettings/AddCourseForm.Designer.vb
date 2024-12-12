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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCourseForm))
        Label3 = New Label()
        Label2 = New Label()
        Label = New Label()
        courseNameTextBox = New TextBox()
        unitTextBox = New TextBox()
        Button2 = New Button()
        addCourseButton = New Button()
        courseIDTextBox = New MaskedTextBox()
        backbttn = New PictureBox()
        addcourselabel = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(114, 194)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 25)
        Label3.TabIndex = 14
        Label3.Text = "Units:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(43, 147)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 25)
        Label2.TabIndex = 13
        Label2.Text = "Course Name:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(71, 100)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(97, 25)
        Label.TabIndex = 12
        Label.Text = "Course ID:"
        ' 
        ' courseNameTextBox
        ' 
        courseNameTextBox.Font = New Font("Segoe UI", 10F)
        courseNameTextBox.Location = New Point(174, 143)
        courseNameTextBox.Margin = New Padding(4)
        courseNameTextBox.Name = "courseNameTextBox"
        courseNameTextBox.Size = New Size(214, 34)
        courseNameTextBox.TabIndex = 11
        ' 
        ' unitTextBox
        ' 
        unitTextBox.Font = New Font("Segoe UI", 10F)
        unitTextBox.Location = New Point(174, 190)
        unitTextBox.Margin = New Padding(4)
        unitTextBox.Name = "unitTextBox"
        unitTextBox.Size = New Size(214, 34)
        unitTextBox.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.White
        Button2.Location = New Point(258, 262)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 36)
        Button2.TabIndex = 9
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' addCourseButton
        ' 
        addCourseButton.BackColor = Color.DarkGreen
        addCourseButton.FlatStyle = FlatStyle.Flat
        addCourseButton.ForeColor = Color.White
        addCourseButton.Location = New Point(114, 262)
        addCourseButton.Margin = New Padding(4)
        addCourseButton.Name = "addCourseButton"
        addCourseButton.Size = New Size(116, 36)
        addCourseButton.TabIndex = 8
        addCourseButton.Text = "Add"
        addCourseButton.UseVisualStyleBackColor = False
        ' 
        ' courseIDTextBox
        ' 
        courseIDTextBox.Enabled = False
        courseIDTextBox.Font = New Font("Segoe UI", 10F)
        courseIDTextBox.Location = New Point(174, 96)
        courseIDTextBox.Margin = New Padding(4)
        courseIDTextBox.Mask = "L-000"
        courseIDTextBox.Name = "courseIDTextBox"
        courseIDTextBox.PromptChar = "X"c
        courseIDTextBox.Size = New Size(214, 34)
        courseIDTextBox.TabIndex = 19
        courseIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 36)
        backbttn.TabIndex = 33
        backbttn.TabStop = False
        ' 
        ' addcourselabel
        ' 
        addcourselabel.AutoSize = True
        addcourselabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addcourselabel.ForeColor = Color.DarkGreen
        addcourselabel.Location = New Point(163, 33)
        addcourselabel.Margin = New Padding(4, 0, 4, 0)
        addcourselabel.Name = "addcourselabel"
        addcourselabel.Size = New Size(171, 25)
        addcourselabel.TabIndex = 34
        addcourselabel.Text = "A D D   C O U R S E"
        ' 
        ' AddCourseForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(487, 345)
        Controls.Add(addcourselabel)
        Controls.Add(backbttn)
        Controls.Add(courseIDTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(courseNameTextBox)
        Controls.Add(unitTextBox)
        Controls.Add(Button2)
        Controls.Add(addCourseButton)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AddCourseForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddCourseForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents courseNameTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents addCourseButton As Button
    Friend WithEvents courseIDTextBox As MaskedTextBox
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents addcourselabel As Label
End Class
