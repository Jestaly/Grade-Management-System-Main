<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDepartmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDepartmentForm))
        Label3 = New Label()
        Label2 = New Label()
        Label = New Label()
        departmentNameTextBox = New TextBox()
        departmentHeadTextBox = New TextBox()
        clearButton = New Button()
        addDepartmentButton = New Button()
        departmentIDTextBox = New MaskedTextBox()
        backbttn = New PictureBox()
        Label1 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(28, 180)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 25)
        Label3.TabIndex = 14
        Label3.Text = "Department Head:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(27, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 13
        Label2.Text = "Department Name:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(27, 92)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(141, 25)
        Label.TabIndex = 12
        Label.Text = "Department ID:"
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Font = New Font("Segoe UI", 9F)
        departmentNameTextBox.Location = New Point(202, 131)
        departmentNameTextBox.Margin = New Padding(4)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(255, 31)
        departmentNameTextBox.TabIndex = 11
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Font = New Font("Segoe UI", 9F)
        departmentHeadTextBox.Location = New Point(202, 174)
        departmentHeadTextBox.Margin = New Padding(4)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(255, 31)
        departmentHeadTextBox.TabIndex = 10
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Segoe UI", 9F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(347, 243)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(95, 37)
        clearButton.TabIndex = 9
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' addDepartmentButton
        ' 
        addDepartmentButton.BackColor = Color.DarkGreen
        addDepartmentButton.FlatStyle = FlatStyle.Popup
        addDepartmentButton.Font = New Font("Segoe UI", 9F)
        addDepartmentButton.ForeColor = Color.White
        addDepartmentButton.Location = New Point(241, 243)
        addDepartmentButton.Margin = New Padding(4)
        addDepartmentButton.Name = "addDepartmentButton"
        addDepartmentButton.Size = New Size(98, 37)
        addDepartmentButton.TabIndex = 8
        addDepartmentButton.Text = "Add "
        addDepartmentButton.UseVisualStyleBackColor = False
        ' 
        ' departmentIDTextBox
        ' 
        departmentIDTextBox.Enabled = False
        departmentIDTextBox.Font = New Font("Segoe UI", 9F)
        departmentIDTextBox.Location = New Point(202, 89)
        departmentIDTextBox.Margin = New Padding(4)
        departmentIDTextBox.Mask = "L-000"
        departmentIDTextBox.Name = "departmentIDTextBox"
        departmentIDTextBox.PromptChar = "X"c
        departmentIDTextBox.Size = New Size(255, 31)
        departmentIDTextBox.TabIndex = 16
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 17
        backbttn.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(130, 43)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 25)
        Label1.TabIndex = 18
        Label1.Text = "A D D  D E P A R T M E N T"
        ' 
        ' AddDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(493, 315)
        Controls.Add(Label1)
        Controls.Add(backbttn)
        Controls.Add(departmentIDTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(addDepartmentButton)
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AddDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddDepartmentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents addDepartmentButton As Button
    Friend WithEvents departmentIDTextBox As MaskedTextBox
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label1 As Label
End Class
