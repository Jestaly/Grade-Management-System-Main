<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class generateSummary
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
        generatesummarylabel = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' generatesummarylabel
        ' 
        generatesummarylabel.AutoSize = True
        generatesummarylabel.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        generatesummarylabel.ForeColor = Color.DarkGreen
        generatesummarylabel.Location = New Point(441, 37)
        generatesummarylabel.Name = "generatesummarylabel"
        generatesummarylabel.Size = New Size(366, 30)
        generatesummarylabel.TabIndex = 73
        generatesummarylabel.Text = "A d m i n   S u m m a r y   R e p o r t"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label1.ForeColor = Color.DarkGreen
        Label1.Location = New Point(74, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 25)
        Label1.TabIndex = 74
        Label1.Text = "Academic Year:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.DarkGreen
        Label2.Location = New Point(74, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 75
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.DarkGreen
        Label3.Location = New Point(74, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 25)
        Label3.TabIndex = 76
        Label3.Text = "Date Generated:"
        ' 
        ' generateSummary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1265, 896)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(generatesummarylabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "generateSummary"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents generatesummarylabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
