<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        dashboardButton = New Button()
        manageStudentButton = New Button()
        manageProgramButton = New Button()
        manageProfessor = New Button()
        allocationManager = New Button()
        logoutButton = New Button()
        manageDepartmentButton = New Button()
        SuspendLayout()
        ' 
        ' dashboardButton
        ' 
        dashboardButton.Location = New Point(31, 54)
        dashboardButton.Name = "dashboardButton"
        dashboardButton.Size = New Size(178, 46)
        dashboardButton.TabIndex = 0
        dashboardButton.Text = "Dashboard"
        dashboardButton.UseVisualStyleBackColor = True
        ' 
        ' manageStudentButton
        ' 
        manageStudentButton.Location = New Point(31, 106)
        manageStudentButton.Name = "manageStudentButton"
        manageStudentButton.Size = New Size(178, 46)
        manageStudentButton.TabIndex = 1
        manageStudentButton.Text = "Manage Student"
        manageStudentButton.UseVisualStyleBackColor = True
        ' 
        ' manageProgramButton
        ' 
        manageProgramButton.Location = New Point(31, 210)
        manageProgramButton.Name = "manageProgramButton"
        manageProgramButton.Size = New Size(178, 46)
        manageProgramButton.TabIndex = 2
        manageProgramButton.Text = "Manage Program"
        manageProgramButton.UseVisualStyleBackColor = True
        ' 
        ' manageProfessor
        ' 
        manageProfessor.Location = New Point(31, 158)
        manageProfessor.Name = "manageProfessor"
        manageProfessor.Size = New Size(178, 46)
        manageProfessor.TabIndex = 3
        manageProfessor.Text = "Manage Professor"
        manageProfessor.UseVisualStyleBackColor = True
        ' 
        ' allocationManager
        ' 
        allocationManager.Location = New Point(31, 314)
        allocationManager.Name = "allocationManager"
        allocationManager.Size = New Size(178, 46)
        allocationManager.TabIndex = 4
        allocationManager.Text = "Allocation Manager"
        allocationManager.UseVisualStyleBackColor = True
        ' 
        ' logoutButton
        ' 
        logoutButton.Location = New Point(31, 374)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(178, 46)
        logoutButton.TabIndex = 5
        logoutButton.Text = "Logout"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' manageDepartmentButton
        ' 
        manageDepartmentButton.Location = New Point(31, 262)
        manageDepartmentButton.Name = "manageDepartmentButton"
        manageDepartmentButton.Size = New Size(178, 46)
        manageDepartmentButton.TabIndex = 6
        manageDepartmentButton.Text = "Manage Department"
        manageDepartmentButton.UseVisualStyleBackColor = True
        ' 
        ' AdminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(manageDepartmentButton)
        Controls.Add(logoutButton)
        Controls.Add(allocationManager)
        Controls.Add(manageProfessor)
        Controls.Add(manageProgramButton)
        Controls.Add(manageStudentButton)
        Controls.Add(dashboardButton)
        Name = "AdminForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents dashboardButton As Button
    Friend WithEvents manageStudentButton As Button
    Friend WithEvents manageProgramButton As Button
    Friend WithEvents manageProfessor As Button
    Friend WithEvents allocationManager As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents manageDepartmentButton As Button
End Class
