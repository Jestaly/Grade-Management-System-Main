<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyDepartmentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyDepartmentForm))
        departmentNameTextBox = New TextBox()
        departmentHeadTextBox = New TextBox()
        clearButton = New Button()
        modifyDepartmentButton = New Button()
        deptIDTextBox = New MaskedTextBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label = New Label()
        backbttn = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' departmentNameTextBox
        ' 
        departmentNameTextBox.Font = New Font("Segoe UI", 9F)
        departmentNameTextBox.Location = New Point(226, 138)
        departmentNameTextBox.Margin = New Padding(4, 5, 4, 5)
        departmentNameTextBox.Name = "departmentNameTextBox"
        departmentNameTextBox.Size = New Size(252, 31)
        departmentNameTextBox.TabIndex = 18
        ' 
        ' departmentHeadTextBox
        ' 
        departmentHeadTextBox.Font = New Font("Segoe UI", 9F)
        departmentHeadTextBox.Location = New Point(226, 184)
        departmentHeadTextBox.Margin = New Padding(4, 5, 4, 5)
        departmentHeadTextBox.Name = "departmentHeadTextBox"
        departmentHeadTextBox.Size = New Size(252, 31)
        departmentHeadTextBox.TabIndex = 17
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Sitka Banner", 9F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(354, 235)
        clearButton.Margin = New Padding(4, 5, 4, 5)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(92, 42)
        clearButton.TabIndex = 16
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' modifyDepartmentButton
        ' 
        modifyDepartmentButton.BackColor = Color.DarkGreen
        modifyDepartmentButton.FlatStyle = FlatStyle.Popup
        modifyDepartmentButton.Font = New Font("Sitka Banner", 9F)
        modifyDepartmentButton.ForeColor = Color.White
        modifyDepartmentButton.Location = New Point(242, 235)
        modifyDepartmentButton.Margin = New Padding(4, 5, 4, 5)
        modifyDepartmentButton.Name = "modifyDepartmentButton"
        modifyDepartmentButton.Size = New Size(92, 42)
        modifyDepartmentButton.TabIndex = 15
        modifyDepartmentButton.Text = "Modify"
        modifyDepartmentButton.UseVisualStyleBackColor = False
        ' 
        ' deptIDTextBox
        ' 
        deptIDTextBox.Enabled = False
        deptIDTextBox.Font = New Font("Segoe UI", 9F)
        deptIDTextBox.Location = New Point(226, 95)
        deptIDTextBox.Margin = New Padding(4, 5, 4, 5)
        deptIDTextBox.Mask = "L-000"
        deptIDTextBox.Name = "deptIDTextBox"
        deptIDTextBox.PromptChar = "X"c
        deptIDTextBox.Size = New Size(252, 31)
        deptIDTextBox.TabIndex = 23
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(132, 49)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 25)
        Label1.TabIndex = 24
        Label1.Text = "M O D I F Y   D E P A R T M E N T"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(47, 184)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 25)
        Label3.TabIndex = 27
        Label3.Text = "Department Head:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(46, 138)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 26
        Label2.Text = "Department Name:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(46, 96)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(141, 25)
        Label.TabIndex = 25
        Label.Text = "Department ID:"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(54, 32)
        backbttn.TabIndex = 28
        backbttn.TabStop = False
        ' 
        ' OfficialModifyDepartmentForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(530, 319)
        Controls.Add(backbttn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(Label1)
        Controls.Add(deptIDTextBox)
        Controls.Add(departmentNameTextBox)
        Controls.Add(departmentHeadTextBox)
        Controls.Add(clearButton)
        Controls.Add(modifyDepartmentButton)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        ForeColor = Color.DarkGreen
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyDepartmentForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyDepartmentForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents departmentNameTextBox As TextBox
    Friend WithEvents departmentHeadTextBox As TextBox
    Friend WithEvents clearButton As Button
    Friend WithEvents modifyDepartmentButton As Button
    Friend WithEvents deptIDTextBox As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label As Label
    Friend WithEvents backbttn As PictureBox
End Class
