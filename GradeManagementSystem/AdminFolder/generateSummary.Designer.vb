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
        SuspendLayout()
        ' 
        ' generatesummarylabel
        ' 
        generatesummarylabel.AutoSize = True
        generatesummarylabel.Font = New Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        generatesummarylabel.ForeColor = Color.DarkGreen
        generatesummarylabel.Location = New Point(81, 57)
        generatesummarylabel.Name = "generatesummarylabel"
        generatesummarylabel.Size = New Size(299, 32)
        generatesummarylabel.TabIndex = 73
        generatesummarylabel.Text = "S u m m a r y  R e p o r t"
        ' 
        ' generateSummary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1265, 896)
        Controls.Add(generatesummarylabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "generateSummary"
        Text = "generateSummary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents generatesummarylabel As Label
End Class
