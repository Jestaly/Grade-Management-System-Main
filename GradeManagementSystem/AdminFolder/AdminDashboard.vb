Imports Transitions
Imports System.IO


Public Class AdminDashboard
    Dim originalSize As Size
    Dim expandedSize As Size
    Dim home1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\home1.png")
    Dim home2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\home2.png")
    Dim stud1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\stud1.png")
    Dim stud2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\stud2.png")
    Dim prog1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\prog1.png")
    Dim prog2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\prog2.png")
    Dim prof1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\prof1.png")
    Dim prof2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\prof2.png")
    Dim allo1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\allocation1.png")
    Dim allo2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\allocation2.png")
    Dim admin1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\1.png")
    Dim admin2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\2.png")
    Dim courses1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\3.png")
    Dim courses2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\4.png")
    Dim programs1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\5.png")
    Dim programs2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\6.png")
    Dim professors1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\7.png")
    Dim professors2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\8.png")
    Dim students1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\9.png")
    Dim students2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\10.png")
    Dim departments1 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\11.png")
    Dim departments2 As Image = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\dashboard\12.png")


    Private originalImage As Image
    Private hoverImage As Image
    Private expand As Boolean = False

    Private Sub AdminDashboard(sender As Object, e As EventArgs) Handles MyBase.Load
        'home1 = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\home1")
        'home2 = Image.FromFile("C:\Users\Administrator\source\repos\Chicken-mcqueen\Kuruguda\GradeManagementSystem\AdminFolder\Resources\panel\home2") 

        originalSize = Panel1.Size
        expandedSize = New Size(originalSize.Width + 243, originalSize.Height + 210)
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

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        If Not expand Then
            Transition.run(Panel1, "Width", expandedSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", expandedSize.Height, New TransitionType_Deceleration(500))
            expand = True
        End If
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        If expand Then
            Transition.run(Panel1, "Width", originalSize.Width, New TransitionType_Deceleration(500))
            Transition.run(Panel1, "Height", originalSize.Height, New TransitionType_Deceleration(500))
            expand = False
        End If
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
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
    Private Sub alloIcon_MouseEnter(sender As Object, e As EventArgs) Handles alloIcon.MouseEnter
        alloIcon.Image = allo2
    End Sub
    Private Sub alloIcon_MouseLeave(sender As Object, e As EventArgs) Handles alloIcon.MouseLeave
        alloIcon.Image = allo1
    End Sub

    Private Sub adminBox_MouseEnter(sender As Object, e As EventArgs) Handles adminBox.MouseEnter
        adminBox.Image = admin2
        adminBox.BackgroundImageLayout = ImageLayout.Stretch
        adminBox.BackColor = Color.Transparent
    End Sub
    Private Sub adminBox_MouseLeave(sender As Object, e As EventArgs) Handles adminBox.MouseLeave
        adminBox.Image = admin1
        adminBox.BackgroundImageLayout = ImageLayout.Stretch
        adminBox.BackColor = Color.Transparent
    End Sub
End Class