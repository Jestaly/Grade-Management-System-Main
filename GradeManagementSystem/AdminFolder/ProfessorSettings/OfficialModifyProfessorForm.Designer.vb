<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OfficialModifyProfessorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OfficialModifyProfessorForm))
        modifyButton = New Button()
        clearButton = New Button()
        Label11 = New Label()
        backbttn = New PictureBox()
        Label8 = New Label()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label6 = New Label()
        profIDTextBox = New MaskedTextBox()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        emailTextBox = New TextBox()
        middlenameTextBox = New TextBox()
        firstnameTextBox = New TextBox()
        lastnameTextBox = New TextBox()
        Label7 = New Label()
        TextBox1 = New TextBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' modifyButton
        ' 
        modifyButton.BackColor = Color.DarkGreen
        modifyButton.FlatStyle = FlatStyle.Popup
        modifyButton.ForeColor = Color.White
        modifyButton.Location = New Point(620, 374)
        modifyButton.Margin = New Padding(4)
        modifyButton.Name = "modifyButton"
        modifyButton.Size = New Size(96, 41)
        modifyButton.TabIndex = 10
        modifyButton.Text = "Modify"
        modifyButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(741, 375)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(85, 40)
        clearButton.TabIndex = 11
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(317, 35)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(259, 25)
        Label11.TabIndex = 37
        Label11.Text = "M O D I F Y  P R O F E S S O R "
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(3, 2)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(58, 36)
        backbttn.TabIndex = 38
        backbttn.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(237, 223)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 25)
        Label8.TabIndex = 59
        Label8.Text = "Phone Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(237, 247)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 34)
        TextBox2.TabIndex = 58
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Female", "Male"})
        ComboBox1.Location = New Point(29, 248)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 33)
        ComboBox1.TabIndex = 57
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(28, 223)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 25)
        Label9.TabIndex = 56
        Label9.Text = "Gender"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(29, 116)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 25)
        Label6.TabIndex = 55
        Label6.Text = "Professor ID:"
        ' 
        ' profIDTextBox
        ' 
        profIDTextBox.Enabled = False
        profIDTextBox.Font = New Font("Segoe UI", 10F)
        profIDTextBox.Location = New Point(143, 110)
        profIDTextBox.Margin = New Padding(4)
        profIDTextBox.Mask = "0-00-00000"
        profIDTextBox.Name = "profIDTextBox"
        profIDTextBox.PromptChar = "X"c
        profIDTextBox.Size = New Size(155, 34)
        profIDTextBox.TabIndex = 54
        profIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Segoe UI", 10F)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(486, 245)
        departmentComboBox.Margin = New Padding(4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(384, 36)
        departmentComboBox.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(486, 221)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 25)
        Label5.TabIndex = 52
        Label5.Text = "Department"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(29, 290)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 25)
        Label4.TabIndex = 51
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(683, 160)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 50
        Label3.Text = "Last Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(467, 157)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 49
        Label2.Text = "Middle Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(29, 157)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 48
        Label1.Text = "First Name"
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Segoe UI", 10F)
        emailTextBox.Location = New Point(29, 314)
        emailTextBox.Margin = New Padding(4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(430, 34)
        emailTextBox.TabIndex = 47
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Segoe UI", 10F)
        middlenameTextBox.Location = New Point(467, 183)
        middlenameTextBox.Margin = New Padding(4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(208, 34)
        middlenameTextBox.TabIndex = 46
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Segoe UI", 10F)
        firstnameTextBox.Location = New Point(29, 183)
        firstnameTextBox.Margin = New Padding(4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(430, 34)
        firstnameTextBox.TabIndex = 45
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Segoe UI", 10F)
        lastnameTextBox.Location = New Point(683, 183)
        lastnameTextBox.Margin = New Padding(4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(187, 34)
        lastnameTextBox.TabIndex = 44
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(28, 350)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(139, 25)
        Label7.TabIndex = 61
        Label7.Text = "Date of Joining"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(28, 374)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 34)
        TextBox1.TabIndex = 60
        ' 
        ' OfficialModifyProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(899, 459)
        Controls.Add(Label7)
        Controls.Add(TextBox1)
        Controls.Add(Label8)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(profIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(emailTextBox)
        Controls.Add(middlenameTextBox)
        Controls.Add(firstnameTextBox)
        Controls.Add(lastnameTextBox)
        Controls.Add(backbttn)
        Controls.Add(Label11)
        Controls.Add(clearButton)
        Controls.Add(modifyButton)
        Font = New Font("Sitka Banner", 10F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "OfficialModifyProfessorForm"
        StartPosition = FormStartPosition.CenterParent
        Text = "OfficialModifyProfessorForm"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents modifyButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents backbttn As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Private WithEvents ComboBox1 As ComboBox
    Private WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents profIDTextBox As MaskedTextBox
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
