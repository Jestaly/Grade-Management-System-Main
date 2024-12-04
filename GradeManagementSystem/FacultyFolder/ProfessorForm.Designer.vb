<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProfessorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        refreshButton = New Button()
        quizDataView = New DataGridView()
        attendanceDataView = New DataGridView()
        studentInfoDataView = New DataGridView()
        classChooseBox = New DomainUpDown()
        projectDataView = New DataGridView()
        examDataView = New DataGridView()
        gradeDataView = New DataGridView()
        equivalentDataView = New DataGridView()
        remarkDataView = New DataGridView()
        midtermButton = New Button()
        finalButton = New Button()
        addItemButton = New Button()
        deleteItemButton = New Button()
        courseTextBox = New TextBox()
        profTextBox = New TextBox()
        timeTextBox = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 62)
        Label1.TabIndex = 0
        Label1.Text = "PROFESSOR FORM"
        ' 
        ' ProfessorForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Name = "ProfessorForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfessorForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
End Class
