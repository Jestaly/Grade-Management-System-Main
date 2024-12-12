<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfessorAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProfessorAccount))
        lastnameTextBox = New TextBox()
        firstnameTextBox = New TextBox()
        middlenameTextBox = New TextBox()
        emailTextBox = New TextBox()
        addProfessorButton = New Button()
        clearButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        departmentComboBox = New ComboBox()
        Label5 = New Label()
        professorIDTextBox = New MaskedTextBox()
        Label6 = New Label()
        Label11 = New Label()
        backbttn = New PictureBox()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label8 = New Label()
        TextBox2 = New TextBox()
        CType(backbttn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lastnameTextBox
        ' 
        lastnameTextBox.Font = New Font("Segoe UI", 10F)
        lastnameTextBox.Location = New Point(687, 157)
        lastnameTextBox.Margin = New Padding(4)
        lastnameTextBox.Name = "lastnameTextBox"
        lastnameTextBox.Size = New Size(187, 34)
        lastnameTextBox.TabIndex = 1
        ' 
        ' firstnameTextBox
        ' 
        firstnameTextBox.Font = New Font("Segoe UI", 10F)
        firstnameTextBox.Location = New Point(33, 157)
        firstnameTextBox.Margin = New Padding(4)
        firstnameTextBox.Name = "firstnameTextBox"
        firstnameTextBox.Size = New Size(430, 34)
        firstnameTextBox.TabIndex = 2
        ' 
        ' middlenameTextBox
        ' 
        middlenameTextBox.Font = New Font("Segoe UI", 10F)
        middlenameTextBox.Location = New Point(471, 157)
        middlenameTextBox.Margin = New Padding(4)
        middlenameTextBox.Name = "middlenameTextBox"
        middlenameTextBox.Size = New Size(208, 34)
        middlenameTextBox.TabIndex = 3
        ' 
        ' emailTextBox
        ' 
        emailTextBox.Font = New Font("Segoe UI", 10F)
        emailTextBox.Location = New Point(33, 288)
        emailTextBox.Margin = New Padding(4)
        emailTextBox.Name = "emailTextBox"
        emailTextBox.Size = New Size(430, 34)
        emailTextBox.TabIndex = 4
        ' 
        ' addProfessorButton
        ' 
        addProfessorButton.BackColor = Color.DarkGreen
        addProfessorButton.FlatStyle = FlatStyle.Popup
        addProfessorButton.Font = New Font("Segoe UI", 9F)
        addProfessorButton.ForeColor = Color.White
        addProfessorButton.Location = New Point(602, 349)
        addProfessorButton.Margin = New Padding(4)
        addProfessorButton.Name = "addProfessorButton"
        addProfessorButton.Size = New Size(100, 38)
        addProfessorButton.TabIndex = 5
        addProfessorButton.Text = "Add"
        addProfessorButton.UseVisualStyleBackColor = False
        ' 
        ' clearButton
        ' 
        clearButton.BackColor = Color.DarkGreen
        clearButton.FlatStyle = FlatStyle.Popup
        clearButton.Font = New Font("Segoe UI", 9F)
        clearButton.ForeColor = Color.White
        clearButton.Location = New Point(725, 349)
        clearButton.Margin = New Padding(4)
        clearButton.Name = "clearButton"
        clearButton.Size = New Size(100, 38)
        clearButton.TabIndex = 6
        clearButton.Text = "Clear"
        clearButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(33, 131)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 7
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(471, 131)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 8
        Label2.Text = "Middle Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(687, 134)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 9
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.DarkGreen
        Label4.Location = New Point(33, 264)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 25)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' departmentComboBox
        ' 
        departmentComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        departmentComboBox.Font = New Font("Segoe UI", 10F)
        departmentComboBox.FormattingEnabled = True
        departmentComboBox.Location = New Point(490, 219)
        departmentComboBox.Margin = New Padding(4)
        departmentComboBox.Name = "departmentComboBox"
        departmentComboBox.Size = New Size(384, 36)
        departmentComboBox.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.DarkGreen
        Label5.Location = New Point(490, 195)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 25)
        Label5.TabIndex = 20
        Label5.Text = "Department"
        ' 
        ' professorIDTextBox
        ' 
        professorIDTextBox.Enabled = False
        professorIDTextBox.Font = New Font("Segoe UI", 10F)
        professorIDTextBox.Location = New Point(147, 84)
        professorIDTextBox.Margin = New Padding(4)
        professorIDTextBox.Mask = "0-00-00000"
        professorIDTextBox.Name = "professorIDTextBox"
        professorIDTextBox.PromptChar = "X"c
        professorIDTextBox.Size = New Size(155, 34)
        professorIDTextBox.TabIndex = 22
        professorIDTextBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(33, 90)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 25)
        Label6.TabIndex = 23
        Label6.Text = "Professor ID:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.DarkGreen
        Label11.Location = New Point(337, 41)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(214, 25)
        Label11.TabIndex = 36
        Label11.Text = "A D D  P R O F E S S O R "
        ' 
        ' backbttn
        ' 
        backbttn.BackgroundImage = CType(resources.GetObject("backbttn.BackgroundImage"), Image)
        backbttn.BackgroundImageLayout = ImageLayout.Stretch
        backbttn.Location = New Point(6, 4)
        backbttn.Name = "backbttn"
        backbttn.Size = New Size(58, 36)
        backbttn.TabIndex = 37
        backbttn.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 9F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Female", "Male"})
        ComboBox1.Location = New Point(33, 222)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(187, 33)
        ComboBox1.TabIndex = 39
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.DarkGreen
        Label9.Location = New Point(32, 197)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 25)
        Label9.TabIndex = 38
        Label9.Text = "Gender"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(33, 329)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(139, 25)
        Label7.TabIndex = 41
        Label7.Text = "Date of Joining"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(33, 353)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 34)
        TextBox1.TabIndex = 40
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(241, 197)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 25)
        Label8.TabIndex = 43
        Label8.Text = "Phone Number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F)
        TextBox2.Location = New Point(241, 221)
        TextBox2.Margin = New Padding(4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 34)
        TextBox2.TabIndex = 42
        ' 
        ' AddProfessorAccount
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(899, 459)
        Controls.Add(Label8)
        Controls.Add(TextBox2)
        Controls.Add(Label7)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label9)
        Controls.Add(backbttn)
        Controls.Add(Label11)
        Controls.Add(Label6)
        Controls.Add(professorIDTextBox)
        Controls.Add(departmentComboBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(clearButton)
        Controls.Add(addProfessorButton)
        Controls.Add(emailTextBox)
        Controls.Add(middlenameTextBox)
        Controls.Add(firstnameTextBox)
        Controls.Add(lastnameTextBox)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "AddProfessorAccount"
        StartPosition = FormStartPosition.CenterParent
        Text = "AddProfessorAccount"
        CType(backbttn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lastnameTextBox As TextBox
    Friend WithEvents firstnameTextBox As TextBox
    Friend WithEvents middlenameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents addProfessorButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents departmentComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents professorIDTextBox As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents backbttn As PictureBox
    Private WithEvents ComboBox1 As ComboBox
    Private WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
