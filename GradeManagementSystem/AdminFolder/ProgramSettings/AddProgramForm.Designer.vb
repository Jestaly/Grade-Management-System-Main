<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProgramForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProgramForm))
        addProgramButton = New Button()
        Button2 = New Button()
        dateAddedTextBox = New TextBox()
        programNameTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label = New Label()
        sectionBox = New DomainUpDown()
        Label1 = New Label()
        Label4 = New Label()
        departmentComboBox = New ComboBox()
        programIDTextBox = New MaskedTextBox()
        Label5 = New Label()
        backbttn = New PictureBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addProgramButton
        ' 
        addProgramButton.BackColor = Color.Green
        addProgramButton.FlatStyle = FlatStyle.Popup
        addProgramButton.Font = New Font("Segoe UI", 9F)
        addProgramButton.ForeColor = Color.White
        addProgramButton.Location = New Point(138, 353)
        addProgramButton.Margin = New Padding(4)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(107, 37)
        addProgramButton.TabIndex = 0
        addProgramButton.Text = "Add"
        addProgramButton.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 9F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(253, 353)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 37)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' dateAddedTextBox
        ' 
        dateAddedTextBox.Font = New Font("Sitka Banner", 10F)
        dateAddedTextBox.Location = New Point(213, 180)
        dateAddedTextBox.Margin = New Padding(4)
        dateAddedTextBox.Name = "dateAddedTextBox"
        dateAddedTextBox.Size = New Size(218, 33)
        dateAddedTextBox.TabIndex = 3
        ' 
        ' programNameTextBox
        ' 
        programNameTextBox.Font = New Font("Sitka Banner", 10F)
        programNameTextBox.Location = New Point(213, 136)
        programNameTextBox.Margin = New Padding(4)
        programNameTextBox.Name = "programNameTextBox"
        programNameTextBox.Size = New Size(218, 33)
        programNameTextBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(51, 136)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 25)
        Label2.TabIndex = 6
        Label2.Text = "Program Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(51, 180)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 25)
        Label3.TabIndex = 7
        Label3.Text = "Date Added:"
        ' 
        ' Label
        ' 
        Label.AutoSize = True
        Label.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label.ForeColor = Color.DarkGreen
        Label.Location = New Point(51, 94)
        Label.Margin = New Padding(4, 0, 4, 0)
        Label.Name = "Label"
        Label.Size = New Size(111, 25)
        Label.TabIndex = 5
        Label.Text = "Program ID:"
        ' 
        ' sectionBox
        ' 
        sectionBox.BorderStyle = BorderStyle.FixedSingle
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
        sectionBox.Location = New Point(213, 266)
        sectionBox.Margin = New Padding(4)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(86, 30)
        sectionBox.TabIndex = 10
        sectionBox.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(51, 271)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 25)
        Label1.TabIndex = 9
        Label1.Text = "Section:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(51, 224)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 25)
        Label4.TabIndex = 18
        Label4.Text = "Department:"
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(213, 224)
        departmentComboBox.Margin = New Padding(4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(218, 34)
        departmentComboBox.TabIndex = 19
        ' 
        ' programIDTextBox
        ' 
        programIDTextBox.Enabled = False
        programIDTextBox.Font = New Font("Sitka Banner", 10F)
        programIDTextBox.Location = New Point(213, 94)
        programIDTextBox.Margin = New Padding(4)
        programIDTextBox.Mask = "L-000"
        programIDTextBox.Name = "programIDTextBox"
        programIDTextBox.PromptChar = "X"c
        programIDTextBox.Size = New Size(99, 33)
        programIDTextBox.TabIndex = 20
        programIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(154, 38)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(189, 25)
        Label5.TabIndex = 21
        Label5.Text = "A D D  P R O G R A M"
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(-1, 0)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(59, 36)
        backbttn.TabIndex = 33
        backbttn.TabStop = False
        ' 
        ' AddProgramForm
        ' 
        AutoScaleDimensions = New SizeF(9F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(497, 417)
        Controls.Add(backbttn)
        Controls.Add(Label5)
        Controls.Add(programIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(Label4)
        Controls.Add(sectionBox)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label)
        Controls.Add(programNameTextBox)
        Controls.Add(dateAddedTextBox)
        Controls.Add(Button2)
        Controls.Add(addProgramButton)
        Font = New Font("Sitka Banner", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AddProgramForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddProgramForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addProgramButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dateAddedTextBox As TextBox
    Friend WithEvents programNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents sectionBox As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents programIDTextBox As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents backbttn As PictureBox
End Class
