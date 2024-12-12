Imports Transitions
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Linq.Expressions


Public Class AdminDashboard
    Dim filedialog As New OpenFileDialog()
    Dim originalSize As Size
    Dim originalSize1 As Size
    Dim expandedSize As Size
    Dim originalSize2 As Size
    Dim expandedSize1 As Size
    Public connector As New DatabaseConnector

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
    Private originalPositions As Dictionary(Of Control, Integer)

    Private originalImage As Image
    Private hoverImage As Image
    Private expand As Boolean = False

    Public Property CornerRadius As Integer = 30
    Private Const MAX_SLIDE_OFFSET As Integer = 100
    Dim slideOffset As Integer = 100
    Private Const SLIDE_DISTANCE As Integer = 278
    Private Const MAXSLIDE_DISTANCE As Integer = 278

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90)
        path.AddArc(Me.ClientSize.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90)
        path.AddArc(Me.ClientSize.Width - CornerRadius, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90)
        path.AddArc(0, Me.ClientSize.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90)
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
        changeEmail.Hide()
        changeNumber.Hide()
        eklavutxt.Hide()
        eklavutxt2.Hide()
        tuldoklikod.Hide()
        tuldokharap.Hide()
        seemore.Hide()
        actlog.Hide()
        dtg1.Hide()
        dashIcon2.Hide()
        studIcon2.Hide()
        profIcon2.Hide()
        progIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Hide()

        originalSize = Panel1.Size
        expandedSize = New Size(originalSize.Width + 345, originalSize.Height + 280)
        originalSize1 = Gerald1.Size
        originalSize2 = studBox.Size
        expandedSize1 = New Size(originalSize1.Width, originalSize1.Height + 115)

        originalPositions = New Dictionary(Of Control, Integer) From {
            {studBox, studBox.Left},
            {adminBox, adminBox.Left},
            {profBox, profBox.Left},
            {progBox, progBox.Left},
            {depBox, depBox.Left},
            {courseBox, courseBox.Left}
            }
        Panel2.BringToFront()
    End Sub
    '===========================================MOUSE ENTER=================================='
    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter,
        PanelLeft.MouseEnter, dashbtn.MouseEnter, progbtn.MouseEnter, profbtn.MouseEnter, managebtn.MouseEnter,
        depBtn.MouseEnter, studbtn.MouseEnter, Panel2.MouseEnter, PictureBox2.MouseEnter, homeIcon.MouseEnter,
        studIcon.MouseEnter, profIcon.MouseEnter, progIcon.MouseEnter, alloIcon.MouseEnter, depIcon.MouseEnter
        If Not expand Then
            Dim newStudBoxLeft As Integer = Math.Min(originalPositions(studBox) + slideOffset, originalPositions(studBox) + MAX_SLIDE_OFFSET)
            Dim newAdminBoxLeft As Integer = Math.Min(originalPositions(adminBox) + slideOffset, originalPositions(adminBox) + MAX_SLIDE_OFFSET)
            Dim newProgBoxLeft As Integer = Math.Min(originalPositions(progBox) + slideOffset, originalPositions(progBox) + MAX_SLIDE_OFFSET)
            Dim newProfBoxLeft As Integer = Math.Min(originalPositions(profBox) + slideOffset, originalPositions(profBox) + MAX_SLIDE_OFFSET)
            Dim newDepBoxLeft As Integer = Math.Min(originalPositions(depBox) + slideOffset, originalPositions(depBox) + MAX_SLIDE_OFFSET)
            Dim newCourseBoxLeft As Integer = Math.Min(originalPositions(courseBox) + slideOffset, originalPositions(courseBox) + MAX_SLIDE_OFFSET)
            ' Dim newLeft As Integer = Me.Width - searchstudent.Width - SLIDE_DISTANCE
            'searchstudent.Location = New Point(485, 200)
            ' Transition.run(searchstudent, "Left", newLeft, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            Transition.run(studBox, "Left", newStudBoxLeft, New TransitionType_Deceleration(500))
            Transition.run(adminBox, "Left", newAdminBoxLeft, New TransitionType_Deceleration(500))
            Transition.run(progBox, "Left", newProgBoxLeft, New TransitionType_Deceleration(500))
            Transition.run(profBox, "Left", newProfBoxLeft, New TransitionType_Deceleration(500))
            Transition.run(depBox, "Left", newDepBoxLeft, New TransitionType_Deceleration(500))
            Transition.run(courseBox, "Left", newCourseBoxLeft, New TransitionType_Deceleration(500))
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
    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles PanelLeft.MouseLeave,
            dashbtn.MouseLeave, progbtn.MouseLeave, profbtn.MouseLeave, managebtn.MouseLeave,
        depBtn.MouseLeave, Panel2.MouseLeave
        If expand Then
            'searchstudent.Location = New Point(220, 200)
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(100))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(100))
            'searchstudent.Location = New Point(220, 200)
            expand = False
        End If
    End Sub
    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        If expand Then

            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            Transition.run(studBox, "Left", studBox.Left - slideOffset, New TransitionType_Deceleration(500))
            Transition.run(adminBox, "Left", adminBox.Left - slideOffset, New TransitionType_Deceleration(500))
            Transition.run(progBox, "Left", progBox.Left - slideOffset, New TransitionType_Deceleration(500))
            Transition.run(profBox, "Left", profBox.Left - slideOffset, New TransitionType_Deceleration(500))
            Transition.run(depBox, "Left", depBox.Left - slideOffset, New TransitionType_Deceleration(500))
            Transition.run(courseBox, "Left", courseBox.Left - slideOffset, New TransitionType_Deceleration(500))
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
        LoginForgot.Visible = True
    End Sub
    Private Sub studBox_Click(sender As Object, e As EventArgs) Handles studBox.Click
        searchstudent.Show()
    End Sub
    Private Sub profBox_Click(sender As Object, e As EventArgs) Handles profBox.Click
        searchprofessor.Show()
    End Sub
    Private Sub adminBox_Click(sender As Object, e As EventArgs) Handles adminBox.Click
        searchadmin.Show()
    End Sub
    Private Sub courseBox_Click(sender As Object, e As EventArgs) Handles courseBox.Click
        searchprogram.Show()
    End Sub
    Private Sub progBox_Click(sender As Object, e As EventArgs) Handles progBox.Click
        searchprogram.Show()
    End Sub
    Private Sub depBox_Click(sender As Object, e As EventArgs) Handles depBox.Click
        searchdepartment.Show()
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
        secu.Location = New Point(1160, 440)
        boxnum.Location = New Point(1180, 310)
        Gerald5.Location = New Point(1100, 50)
        Gerald1.Location = New Point(1104, 53)
        Gerald2.Location = New Point(1115, 250)

        boxname.Location = New Point(1180, 270)
        editInfo.Location = New Point(1200, 410)
        callIcon.Location = New Point(1140, 305)
        profname.Location = New Point(1140, 180)
        proftitle.Location = New Point(1195, 215)
        emailIcon.Location = New Point(1140, 265)
        profpic.Location = New Point(1190, 60)

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

            editInfo.Location = New Point(1200, 600)
            secu.Hide()
            changeEmail.Visible = True
            changeNumber.Visible = True
            eklavutxt.Visible = True
            eklavutxt2.Visible = True
        Else
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", originalSize1.Height, New TransitionType_Deceleration(100))

            editInfo.Location = New Point(1200, 410)
            secu.Show()
            changeEmail.Visible = False
            changeNumber.Visible = False
            eklavutxt.Visible = False
            eklavutxt2.Visible = False
        End If
        expand = Not expand
    End Sub
    Private Sub secu_Click(sender As Object, e As EventArgs) Handles secu.Click
        If Not expand Then
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald1, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", expandedSize1.Height, New TransitionType_Deceleration(100))

            secu.Location = New Point(1170, 600)
            editInfo.Hide()
            changeEmail.Visible = True
            changeNumber.Visible = True
            eklavutxt.Visible = True
            eklavutxt2.Visible = True

        Else
            Transition.run(Gerald1, "Height", originalSize1.Height, New TransitionType_Deceleration(100))
            Transition.run(Gerald5, "Height", originalSize1.Height, New TransitionType_Deceleration(100))

            secu.Location = New Point(1160, 440)
            editInfo.Show()
            changeEmail.BackColor = Color.Transparent
            changeNumber.BackColor = Color.Transparent
            changeEmail.Visible = False
            changeNumber.Visible = False
            eklavutxt.Visible = False
            eklavutxt2.Visible = False
        End If
        expand = Not expand
    End Sub
    Private Sub tuldok_Click(sender As Object, e As EventArgs) Handles tuldok.Click
        tuldoklikod.BringToFront()
        tuldoklikod.Location = New Point(600, 50)
        tuldokharap.BringToFront()
        tuldokharap.Location = New Point(606, 54)
        seemore.BringToFront()
        seemore.Location = New Point(980, 500)
        actlog.BringToFront()
        actlog.Location = New Point(670, 80)
        dtg1.BringToFront()
        dtg1.Location = New Point(665, 120)


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
        dashIcon2.Show()
        studIcon2.Hide()
        progIcon2.Hide()
        profIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Hide()
    End Sub
    Private Sub studbtn_Click(sender As Object, e As EventArgs) Handles studbtn.Click
        mngStudent.Visible = Not mngStudent.Visible
        dashIcon2.Hide()
        studIcon2.Show()
        progIcon2.Hide()
        profIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Hide()

    End Sub
    Private Sub progbtn_Click(sender As Object, e As EventArgs) Handles progbtn.Click
        mngProgram.Visible = Not mngProgram.Visible
        dashIcon2.Hide()
        studIcon2.Hide()
        progIcon2.Show()
        profIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Hide()
    End Sub
    Private Sub profbtn_Click(sender As Object, e As EventArgs) Handles profbtn.Click
        mngProfessor.Visible = Not mngProfessor.Visible
        dashIcon2.Hide()
        studIcon2.Hide()
        progIcon2.Hide()
        profIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Hide()
    End Sub
    Private Sub depBtn_Click(sender As Object, e As EventArgs) Handles depBtn.Click
        mngDepartment.Visible = Not mngDepartment.Visible
        dashIcon2.Hide()
        studIcon2.Hide()
        progIcon2.Hide()
        profIcon2.Hide()
        depIcon2.Show()
        alloIcon2.Hide()
    End Sub
    Private Sub managebtn_Click(sender As Object, e As EventArgs) Handles managebtn.Click
        allocMng.Visible = Not allocMng.Visible
        dashIcon2.Hide()
        studIcon2.Hide()
        progIcon2.Hide()
        profIcon2.Hide()
        depIcon2.Hide()
        alloIcon2.Show()
    End Sub

    Private Sub dashbtn_MouseHover(sender As Object, e As EventArgs) Handles dashbtn.MouseEnter
        homeIcon.Image = home2
    End Sub
    Private Sub studbtn_MouseHover(sender As Object, e As EventArgs) Handles studbtn.MouseEnter
        studIcon.Image = stud2
    End Sub
    Private Sub progbtn_MouseHover(sender As Object, e As EventArgs) Handles progbtn.MouseEnter
        progIcon.Image = prog2
    End Sub
    Private Sub profbtn_MouseHover(sender As Object, e As EventArgs) Handles profbtn.MouseEnter
        profIcon.Image = prof2
    End Sub
    Private Sub depbtn_MouseHover(sender As Object, e As EventArgs) Handles depBtn.MouseEnter
        depIcon.Image = department2
    End Sub
    Private Sub managebtn_MouseHover(sender As Object, e As EventArgs) Handles managebtn.MouseEnter
        alloIcon.Image = allo2
    End Sub
    Private Sub dashbtn_MouseLeave(sender As Object, e As EventArgs) Handles dashbtn.MouseLeave
        homeIcon.Image = home1
    End Sub
    Private Sub studbtn_MouseLeave(sender As Object, e As EventArgs) Handles studbtn.MouseLeave
        studIcon.Image = stud1
    End Sub
    Private Sub progbtn_MouseLeave(sender As Object, e As EventArgs) Handles progbtn.MouseLeave
        progIcon.Image = prog1
    End Sub
    Private Sub profbtn_MouseLeave(sender As Object, e As EventArgs) Handles profbtn.MouseLeave
        profIcon.Image = prof1
    End Sub
    Private Sub depbtn_MouseLeave(sender As Object, e As EventArgs) Handles depBtn.MouseLeave
        depIcon.Image = department1
    End Sub
    Private Sub managebtn_MouseLeave(sender As Object, e As EventArgs) Handles managebtn.MouseLeave
        alloIcon.Image = allo1
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Try
            connector.connect.Open()
            connector.command.Connection = connector.connect

            connector.query = "INSERT INTO testNotif2 (NotifDate) VALUES (NOW())"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "SELECT * FROM testNotif2"
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command

            connector.dataAdapter.Fill(connector.dataTable)
            dtg1.DataSource = connector.dataTable
        Finally

        End Try
    End Sub

    Private Sub Gerald1_Click(sender As Object, e As EventArgs) Handles Gerald1.Click

    End Sub


End Class