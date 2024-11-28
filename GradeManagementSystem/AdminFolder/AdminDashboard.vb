Imports Transitions
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class AdminDashboard
    Dim filedialog As New OpenFileDialog()
    Dim originalSize As Size
    Dim expandedSize As Size
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

        originalSize = Panel1.Size
        expandedSize = New Size(originalSize.Width + 275, originalSize.Height + 210)
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If

    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub PanelLeft_MouseEnter(sender As Object, e As EventArgs) Handles PanelLeft.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If

    End Sub

    Private Sub PanelLeft_MouseLeave(sender As Object, e As EventArgs) Handles PanelLeft.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles dashbtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles studbtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles progbtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles profbtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles managebtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub depBtn_MouseEnter(sender As Object, e As EventArgs) Handles depBtn.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles dashbtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles studbtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles progbtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles profbtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles managebtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub depbtn_MouseLeave(sender As Object, e As EventArgs) Handles depBtn.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Studets.Show()
    End Sub


    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Studets.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub homeIcon_MouseEnter(sender As Object, e As EventArgs) Handles homeIcon.MouseEnter
        homeIcon.Image = home2
    End Sub
    Private Sub homeIcon_MouseLeave(sender As Object, e As EventArgs) Handles homeIcon.MouseLeave
        homeIcon.Image = home1

    End Sub
    Private Sub studIcon_MouseEnter(sender As Object, e As EventArgs) Handles studIcon.MouseEnter
        studIcon.Image = stud2
    End Sub
    Private Sub studIcon_MouseLeave(sender As Object, e As EventArgs) Handles studIcon.MouseLeave
        studIcon.Image = stud1
    End Sub
    Private Sub progIcon_MouseEnter(sender As Object, e As EventArgs) Handles progIcon.MouseEnter
        progIcon.Image = prog2
    End Sub
    Private Sub progIcon_MouseLeave(sender As Object, e As EventArgs) Handles progIcon.MouseLeave
        progIcon.Image = prog1
    End Sub
    Private Sub profIcon_MouseEnter(sender As Object, e As EventArgs) Handles profIcon.MouseEnter
        profIcon.Image = prof2
    End Sub
    Private Sub profIcon_MouseLeave(sender As Object, e As EventArgs) Handles profIcon.MouseLeave
        profIcon.Image = prof1
    End Sub
    Private Sub depIcon_MouseEnter(sender As Object, e As EventArgs) Handles depIcon.MouseEnter
        depIcon.Image = department2
    End Sub
    Private Sub depIcon_MouseLeave(sender As Object, e As EventArgs) Handles depIcon.MouseLeave
        depIcon.Image = department1
    End Sub
    Private Sub alloIcon_MouseEnter(sender As Object, e As EventArgs) Handles alloIcon.MouseEnter
        alloIcon.Image = allo2
    End Sub
    Private Sub alloIcon_MouseLeave(sender As Object, e As EventArgs) Handles alloIcon.MouseLeave
        alloIcon.Image = allo1
    End Sub

    Private Sub adminBox_MouseEnter(sender As Object, e As EventArgs) Handles adminBox.MouseEnter
        adminBox.Image = admin2
    End Sub
    Private Sub adminBox_MouseLeave(sender As Object, e As EventArgs) Handles adminBox.MouseLeave
        adminBox.Image = admin1
    End Sub
    Private Sub studBox_MouseEnter(sender As Object, e As EventArgs) Handles studBox.MouseEnter
        studBox.Image = students2
    End Sub
    Private Sub studBox_MouseLeave(sender As Object, e As EventArgs) Handles studBox.MouseLeave
        studBox.Image = students1
    End Sub
    Private Sub profBox_MouseEnter(sender As Object, e As EventArgs) Handles profBox.MouseEnter
        profBox.Image = professors2
    End Sub
    Private Sub prfBox_MouseLeave(sender As Object, e As EventArgs) Handles profBox.MouseLeave
        profBox.Image = professors1
    End Sub
    Private Sub depBox_MouseEnter(sender As Object, e As EventArgs) Handles depBox.MouseEnter
        depBox.Image = departments2
    End Sub
    Private Sub depBox_MouseLeave(sender As Object, e As EventArgs) Handles depBox.MouseLeave
        depBox.Image = departments1
    End Sub
    Private Sub progBox_MouseEnter(sender As Object, e As EventArgs) Handles progBox.MouseEnter
        progBox.Image = programs2
    End Sub
    Private Sub progBox_MouseLeave(sender As Object, e As EventArgs) Handles progBox.MouseLeave
        progBox.Image = programs1
    End Sub
    Private Sub courseBox_MouseEnter(sender As Object, e As EventArgs) Handles courseBox.MouseEnter
        courseBox.Image = courses2
    End Sub
    Private Sub courseBox_MouseLeave(sender As Object, e As EventArgs) Handles courseBox.MouseLeave
        courseBox.Image = courses1
    End Sub

    Private Sub PictureBox8_MouseClick(sender As Object, e As MouseEventArgs) Handles profilemenu.Click
        secu.Visible = Not secu.Visible
        boxnum.Visible = Not boxnum.Visible
        Gerald5.Visible = Not Gerald5.Visible
        Gerald1.Visible = Not Gerald1.Visible
        Gerald2.Visible = Not Gerald2.Visible
        profpic.Visible = Not profpic.Visible
        boxname.Visible = Not boxname.Visible
        editInfo.Visible = Not editInfo.Visible
        callIcon.Visible = Not callIcon.Visible
        profname.Visible = Not profname.Visible
        proftitle.Visible = Not proftitle.Visible
        emailIcon.Visible = Not emailIcon.Visible
    End Sub

    Private Sub profpic_Click(sender As Object, e As EventArgs) Handles profpic.Click
        filedialog.Filter = "PNG Files (*.png)|*.png"
        filedialog.Title = "Select a PNG Image"

        If filedialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFile As String = filedialog.FileName
            profpic.Image = Image.FromFile(selectedFile)
            profilemenu.Image = Image.FromFile(selectedFile)
            profileleft.Image = Image.FromFile(selectedFile)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub PictureBox8_MouseClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub depBox_Click(sender As Object, e As EventArgs) Handles depBox.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles managebtn.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles depBtn.Click

    End Sub
End Class