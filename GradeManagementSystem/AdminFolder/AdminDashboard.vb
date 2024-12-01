Imports Transitions
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class AdminDashboard
    Dim filedialog As New OpenFileDialog()
    Dim originalSize As Size
    Dim expandedSize As Size
    Dim originalSize1 As Size
    Dim expandedSize1 As Size
    Dim home1 As Image = My.Resources.home1
    Dim home2 As Image = My.Resources.home2
    Dim stud1 As Image = My.Resources.stud1
    Dim stud2 As Image = My.Resources.stud2
    Dim prog1 As Image = My.Resources.prog1
    Dim prog2 As Image = My.Resources.prog2
    Dim prof1 As Image = My.Resources.prof1
    Dim prof2 As Image = My.Resources.prof2
    Dim allo1 As Image = My.Resources.allocation1
    Dim allo2 As Image = My.Resources.allocation2
    Dim admin1 As Image = My.Resources.administrator1
    Dim admin2 As Image = My.Resources.administrator2
    Dim courses1 As Image = My.Resources.courses1
    Dim courses2 As Image = My.Resources.courses2
    Dim programs1 As Image = My.Resources.programs1
    Dim programs2 As Image = My.Resources.programs2
    Dim professors1 As Image = My.Resources.professors1
    Dim professors2 As Image = My.Resources.professors2
    Dim students1 As Image = My.Resources.students1
    Dim students2 As Image = My.Resources.students2
    Dim departments1 As Image = My.Resources.departments1
    Dim departments2 As Image = My.Resources.departments2
    Dim department1 As Image = My.Resources.department1
    Dim department2 As Image = My.Resources.department2

    Private originalImage As Image
    Private hoverImage As Image
    Private expand As Boolean = False

    Public Property CornerRadius As Integer = 30
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90) ' Top-left corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90) ' Top-right corner
        path.AddArc(Me.ClientSize.Width - CornerRadius, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90) ' Bottom-right corner
        path.AddArc(0, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90) ' Bottom-left corner
        path.CloseAllFigures()
        Me.Region = New Region(path)
        e.Graphics.DrawPath(New Pen(Color.Black, 2), path)
    End Sub
    Private Sub AdminDashboard(sender As Object, e As EventArgs) Handles MyBase.Load
        secu.Hide()
        boxnum.Hide()
        Gerald5.Hide()
        Gerald1.Hide()
        Gerald2.Hide()
        profpic.Hide()
        boxname.Hide()
        editInfo.Hide()
        callIcon.Hide()
        profname.Hide()
        proftitle.Hide()
        emailIcon.Hide()
        eklavu1.Hide()
        eklavu2.Hide()
        eklavutxt.Hide()
        eklavutxt2.Hide()
        tuldoklikod.Hide()
        tuldokharap.Hide()
        seemore.Hide()
        actlog.Hide()
        dtg1.Hide()

        originalSize = Panel1.Size
        expandedSize = New Size(originalSize.Width + 345, originalSize.Height + 280)
        originalSize1 = Gerald1.Size
        expandedSize1 = New Size(originalSize1.Width, originalSize1.Height + 115)
    End Sub
    '===========================================MOUSE ENTER=================================='
    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter,
        PanelLeft.MouseEnter, dashbtn.MouseEnter, progbtn.MouseEnter, profbtn.MouseEnter, managebtn.MouseEnter,
        depBtn.MouseEnter, studbtn.MouseEnter, Panel2.MouseEnter, PictureBox2.MouseEnter, homeIcon.MouseEnter,
        studIcon.MouseEnter, profIcon.MouseEnter, progIcon.MouseEnter, alloIcon.MouseEnter, depIcon.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub nameLeft_MouseEnter(sender As Object, e As EventArgs) Handles nameleft.MouseEnter,
        Adminleft.MouseEnter, profileleft.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    '==========================================MOUSE LEAVE===================================='
    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave,
            PanelLeft.MouseLeave, dashbtn.MouseLeave, progbtn.MouseLeave, profbtn.MouseLeave, managebtn.MouseLeave,
        depBtn.MouseLeave, Panel2.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs)
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs)
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub

    Private Sub nameLeft_MouseLeave(sender As Object, e As EventArgs) Handles nameleft.MouseLeave,
        Adminleft.MouseLeave, profileleft.MouseLeave
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    '=====================================DASHBOARD BUTTON==============================='
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Visible = False
        LoginForm.Visible = True
    End Sub
    Private Sub studBox_Click(sender As Object, e As EventArgs) Handles studBox.Click
        StudentForm.Show()
    End Sub
    Private Sub profBox_Click(sender As Object, e As EventArgs) Handles profBox.Click
        StudentForm.Show()
    End Sub

    '=======================================ICON MOUSE ENTER========================================='
    Private Sub homeIcon_MouseEnter(sender As Object, e As EventArgs) Handles homeIcon.MouseEnter
        homeIcon.Image = home2
    End Sub
    Private Sub studIcon_MouseEnter(sender As Object, e As EventArgs) Handles studIcon.MouseEnter
        studIcon.Image = stud2
    End Sub
    Private Sub progIcon_MouseEnter(sender As Object, e As EventArgs) Handles progIcon.MouseEnter
        progIcon.Image = prog2
    End Sub
    Private Sub profIcon_MouseEnter(sender As Object, e As EventArgs) Handles profIcon.MouseEnter
        profIcon.Image = prof2
    End Sub
    Private Sub depIcon_MouseEnter(sender As Object, e As EventArgs) Handles depIcon.MouseEnter
        depIcon.Image = department2
    End Sub
    Private Sub alloIcon_MouseEnter(sender As Object, e As EventArgs) Handles alloIcon.MouseEnter
        alloIcon.Image = allo2
    End Sub
    '=======================================ICON MOUSE LEAVE========================================='
    Private Sub homeIcon_MouseLeave(sender As Object, e As EventArgs) Handles homeIcon.MouseLeave
        homeIcon.Image = home1
    End Sub

    Private Sub studIcon_MouseLeave(sender As Object, e As EventArgs) Handles studIcon.MouseLeave
        studIcon.Image = stud1
    End Sub

    Private Sub progIcon_MouseLeave(sender As Object, e As EventArgs) Handles progIcon.MouseLeave
        progIcon.Image = prog1
    End Sub

    Private Sub profIcon_MouseLeave(sender As Object, e As EventArgs) Handles profIcon.MouseLeave
        profIcon.Image = prof1
    End Sub

    Private Sub depIcon_MouseLeave(sender As Object, e As EventArgs) Handles depIcon.MouseLeave
        depIcon.Image = department1
    End Sub

    Private Sub alloIcon_MouseLeave(sender As Object, e As EventArgs) Handles alloIcon.MouseLeave
        alloIcon.Image = allo1
    End Sub
    '==================================DASHBOARD MOUSE ENTER================================='
    Private Sub adminBox_MouseEnter(sender As Object, e As EventArgs) Handles adminBox.MouseEnter
        adminBox.Image = admin2
    End Sub
    Private Sub studBox_MouseEnter(sender As Object, e As EventArgs) Handles studBox.MouseEnter
        studBox.Image = students2
    End Sub
    Private Sub profBox_MouseEnter(sender As Object, e As EventArgs) Handles profBox.MouseEnter
        profBox.Image = professors2
    End Sub
    Private Sub depBox_MouseEnter(sender As Object, e As EventArgs) Handles depBox.MouseEnter
        depBox.Image = departments2
    End Sub
    Private Sub progBox_MouseEnter(sender As Object, e As EventArgs) Handles progBox.MouseEnter
        progBox.Image = programs2
    End Sub
    Private Sub courseBox_MouseEnter(sender As Object, e As EventArgs) Handles courseBox.MouseEnter
        courseBox.Image = courses2
    End Sub
    '==================================DASHBOARD MOUSE LEAVE================================='
    Private Sub adminBox_MouseLeave(sender As Object, e As EventArgs) Handles adminBox.MouseLeave
        adminBox.Image = admin1
    End Sub

    Private Sub studBox_MouseLeave(sender As Object, e As EventArgs) Handles studBox.MouseLeave
        studBox.Image = students1
    End Sub

    Private Sub prfBox_MouseLeave(sender As Object, e As EventArgs) Handles profBox.MouseLeave
        profBox.Image = professors1
    End Sub

    Private Sub depBox_MouseLeave(sender As Object, e As EventArgs) Handles depBox.MouseLeave
        depBox.Image = departments1
    End Sub

    Private Sub progBox_MouseLeave(sender As Object, e As EventArgs) Handles progBox.MouseLeave
        progBox.Image = programs1
    End Sub

    Private Sub courseBox_MouseLeave(sender As Object, e As EventArgs) Handles courseBox.MouseLeave
        courseBox.Image = courses1
    End Sub
    '=========================================PICTUREBOX========================================'
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub profpic_MouseClick(sender As Object, e As MouseEventArgs) Handles profpic.MouseClick
        filedialog.Filter = "PNG Files (*.png)|*.png"
        filedialog.Title = "Select a PNG Image"

        If filedialog.ShowDialog = DialogResult.OK Then

            Dim selectedFile = filedialog.FileName
            profmenu.Image = Image.FromFile(selectedFile)
            profileleft.Image = Image.FromFile(selectedFile)
            profpic.Image = Image.FromFile(selectedFile)
        End If
    End Sub
    Private Sub profmenu_MouseClick(sender As Object, e As MouseEventArgs) Handles profmenu.MouseClick
        secu.Visible = Not secu.Visible
        boxnum.Visible = Not boxnum.Visible
        Gerald5.Visible = Not Gerald5.Visible
        Gerald1.Visible = Not Gerald1.Visible
        Gerald2.Visible = Not Gerald2.Visible

        boxname.Visible = Not boxname.Visible
        editInfo.Visible = Not editInfo.Visible
        callIcon.Visible = Not callIcon.Visible
        profname.Visible = Not profname.Visible
        proftitle.Visible = Not proftitle.Visible
        emailIcon.Visible = Not emailIcon.Visible
        profpic.Visible = Not profpic.Visible
    End Sub
    '========================================PROFILE INFO========================================='
    Private Sub editInfo_Click(sender As Object, e As MouseEventArgs) Handles editInfo.Click
        If Not expand Then
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald1, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))

            editInfo.Location = New Point(1070, 480)
            secu.Hide()
            eklavu1.Show()
            eklavu2.Show()
            eklavutxt.Show()
            eklavutxt2.Show()
        Else
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", originalSize1.Height, New TransitionType_Deceleration(100))

            editInfo.Location = New Point(1065, 323)
            secu.Show()
            eklavu1.Hide()
            eklavu2.Hide()
            eklavutxt.Hide()
            eklavutxt2.Hide()
        End If
        expand = Not expand
    End Sub
    Private Sub secu_Click(sender As Object, e As EventArgs) Handles secu.Click
        If Not expand Then
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald1, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))

            secu.Location = New Point(1040, 470)
            editInfo.Hide()
            eklavu1.Show()
            eklavu2.Show()
            eklavutxt.Show()
            eklavutxt2.Show()
        Else
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", originalSize1.Height, New TransitionType_Deceleration(100))

            secu.Location = New Point(1040, 355)
            editInfo.Show()
            eklavu1.Hide()
            eklavu2.Hide()
            eklavutxt.Hide()
            eklavutxt2.Hide()
        End If
        expand = Not expand
    End Sub
    Private Sub tuldok_Click(sender As Object, e As EventArgs) Handles tuldok.Click
        tuldoklikod.Visible = Not tuldoklikod.Visible
        tuldokharap.Visible = Not tuldokharap.Visible
        seemore.Visible = Not seemore.Visible
        actlog.Visible = Not actlog.Visible
        dtg1.Visible = Not dtg1.Visible
    End Sub
    '========================================OTHERS========================================='
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        DateTimePicker1.Value = DateTime.Now
    End Sub

    '========================================BACKEND========================================'
    Private mngStudent As New ManageStudentAdmin
    Private mngProgram As New ManageProgramAdmin
    Private mngProfessor As New ManageProfessorAdmin
    Private mngDepartment As New ManageDepartmentAdmin
    Private allocMng As New AllocationManagerAdminvb
    Private Sub dashbtn_Click(sender As Object, e As EventArgs) Handles dashbtn.Click
        Me.Visible = True
    End Sub
    Private Sub studbtn_Click(sender As Object, e As EventArgs) Handles studbtn.Click
        mngStudent.Visible = True
    End Sub
    Private Sub progbtn_Click(sender As Object, e As EventArgs) Handles progbtn.Click
        mngProgram.Visible = True
    End Sub
    Private Sub profbtn_Click(sender As Object, e As EventArgs) Handles profbtn.Click
        mngProfessor.Visible = True
    End Sub
    Private Sub depBtn_Click(sender As Object, e As EventArgs) Handles depBtn.Click
        mngDepartment.Visible = True
    End Sub
    Private Sub managebtn_Click(sender As Object, e As EventArgs) Handles managebtn.Click
        allocMng.Visible = True
    End Sub
End Class