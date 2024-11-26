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
        addProgramButton = New Button()
        Button2 = New Button()
        dateAddedTextBox = New TextBox()
        programNameTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        programIDLabel = New Label()
        sectionBox = New DomainUpDown()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' addProgramButton
        ' 
        addProgramButton.Location = New Point(36, 235)
        addProgramButton.Name = "addProgramButton"
        addProgramButton.Size = New Size(109, 29)
        addProgramButton.TabIndex = 0
        addProgramButton.Text = "Add Program"
        addProgramButton.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(36, 270)
        Button2.Name = "Button2"
        Button2.Size = New Size(109, 29)
        Button2.TabIndex = 1
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' dateAddedTextBox
        ' 
        dateAddedTextBox.Location = New Point(131, 150)
        dateAddedTextBox.Name = "dateAddedTextBox"
        dateAddedTextBox.Size = New Size(172, 27)
        dateAddedTextBox.TabIndex = 3
        ' 
        ' programNameTextBox
        ' 
        programNameTextBox.Location = New Point(131, 98)
        programNameTextBox.Name = "programNameTextBox"
        programNameTextBox.Size = New Size(172, 27)
        programNameTextBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 20)
        Label2.TabIndex = 6
        Label2.Text = "Program Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 7
        Label3.Text = "Date Added"
        ' 
        ' programIDLabel
        ' 
        programIDLabel.AutoSize = True
        programIDLabel.Location = New Point(74, 31)
        programIDLabel.Name = "programIDLabel"
        programIDLabel.Size = New Size(47, 20)
        programIDLabel.TabIndex = 5
        programIDLabel.Text = "P-000"
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
        sectionBox.Location = New Point(405, 98)
        sectionBox.Name = "sectionBox"
        sectionBox.ReadOnly = True
        sectionBox.Size = New Size(76, 27)
        sectionBox.TabIndex = 10
        sectionBox.Text = "1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(335, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 9
        Label1.Text = "Sections"
        ' 
        ' AddProgramForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(605, 358)
        Controls.Add(sectionBox)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(programIDLabel)
        Controls.Add(programNameTextBox)
        Controls.Add(dateAddedTextBox)
        Controls.Add(Button2)
        Controls.Add(addProgramButton)
        Name = "AddProgramForm"
        Text = "AddProgramForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addProgramButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dateAddedTextBox As TextBox
    Friend WithEvents programNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents programIDLabel As Label
    Friend WithEvents sectionBox As DomainUpDown
    Friend WithEvents Label1 As Label
End Class
