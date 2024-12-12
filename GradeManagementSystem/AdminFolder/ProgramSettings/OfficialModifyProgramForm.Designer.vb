<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyProgramForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyProgramForm))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        modifyButton = New Button()
        yearAddedTextBox = New TextBox()
        programnameTextBox = New TextBox()
        programIDTextBox = New MaskedTextBox()
        sectionBox = New DomainUpDown()
        Label4 = New Label()
        backButton = New Button()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        backbttn = New PictureBox()
        Label6 = New Label()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(113, 98)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 28)
        Label1.TabIndex = 0
        Label1.Text = "Program ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(79, 138)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 28)
        Label2.TabIndex = 1
        Label2.Text = "Program Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(109, 183)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 28)
        Label3.TabIndex = 2
        Label3.Text = "Date Added:"
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.ForeColor = Color.White
        modifyButton.Location = New Point(137, 339)
        modifyButton.Margin = New Padding(4, 5, 4, 5)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(118, 42)
        modifyButton.TabIndex = 3
        modifyButton.Text = "Modify "
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' yearAddedTextBox
        ' 
        yearAddedTextBox.Font = New Font("Segoe UI", 10F)
        yearAddedTextBox.Location = New Point(242, 179)
        yearAddedTextBox.Margin = New Padding(4, 5, 4, 5)
        yearAddedTextBox.Name = "yearAddedTextBox"
        yearAddedTextBox.Size = New Size(210, 34)
        yearAddedTextBox.TabIndex = 4
        ' 
        ' programnameTextBox
        ' 
        programnameTextBox.Font = New Font("Segoe UI", 10F)
        programnameTextBox.Location = New Point(242, 135)
        programnameTextBox.Margin = New Padding(4, 5, 4, 5)
        programnameTextBox.Name = "programnameTextBox"
        programnameTextBox.Size = New Size(210, 34)
        programnameTextBox.TabIndex = 5
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Font = New Font("Segoe UI", 10F)
        programIDTextBox.Location = New Point(242, 95)
        programIDTextBox.Margin = New Padding(4, 5, 4, 5)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(210, 34)
        programIDTextBox.TabIndex = 6
        programIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' sectionBox
        ' 
        sectionBox.BorderStyle = BorderStyle.FixedSingle
        sectionBox.Font = New Font("Segoe UI", 10F)
        sectionBox.Items.Add("1")
        sectionBox.Items.Add("2")
        sectionBox.Items.Add("3")
        sectionBox.Items.Add("4")
        sectionBox.Items.Add("5")
        sectionBox.Items.Add("6")
        sectionBox.Items.Add("7")
        sectionBox.Items.Add("8")
        sectionBox.Items.Add("9")
        sectionBox.Items.Add("10")
        sectionBox.Location = New Point(242, 270)
        sectionBox.Margin = New Padding(4, 6, 4, 6)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(95, 34)
        sectionBox.TabIndex = 12
        sectionBox.Text = "1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(141, 270)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 11
        Label4.Text = "Sections:"
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.DarkGreen
        backButton.FlatStyle = FlatStyle.Popup
        backButton.ForeColor = Color.White
        backButton.Location = New Point(286, 339)
        backButton.Margin = New Padding(4, 5, 4, 5)
        backButton.Name = "backButton"
        backButton.Size = New Size(118, 42)
        backButton.TabIndex = 18
        backButton.Text = "Clear"
        backButton.UseVisualStyleBackColor = False
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Segoe UI", 10F)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(242, 223)
        departmentComboBox.Margin = New Padding(4, 5, 4, 5)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(210, 36)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(107, 229)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 28)
        Label5.TabIndex = 20
        Label5.Text = "Department:"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(12, 12)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(44, 35)
        backbttn.TabIndex = 24
        backbttn.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(129, 31)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(273, 28)
        Label6.TabIndex = 25
        Label6.Text = "M O D I F Y   P R O G R A M"
        ' 
        ' OfficialModifyProgramForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(536, 423)
        Controls.Add(Label6)
        Controls.Add(backbttn)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(backButton)
        Controls.Add(sectionBox)
        Controls.Add(Label4)
        Controls.Add(programIDTextBox)
        Controls.Add(programnameTextBox)
        Controls.Add(yearAddedTextBox)
        Controls.Add(modifyButton)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Sitka Banner Semibold", 10F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 5, 4, 5)
        Name = "OfficialModifyProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyProgramForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents modifyButton As Button
    Friend WithEvents yearAddedTextBox As TextBox
    Friend WithEvents programnameTextBox As TextBox
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents sectionBox As DomainUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents backButton As Button
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label6 As Label
End Class
