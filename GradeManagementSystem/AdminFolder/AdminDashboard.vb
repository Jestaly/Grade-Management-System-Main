Imports Transitions
Imports System.IO


Public Class AdminDashboard
    Dim originalSize As Size
    Dim expandedSize As Size

    Private originalImage As Image
    Private hoverImage As Image
    Private expand As Boolean = False

    Private Sub AdminDashboard(sender As Object, e As EventArgs) Handles MyBase.Load

        studbox.Show()
        studbox2.Hide()
        profbox2.Hide()
        
        profbox.Show()
        originalSize = Panel1.Size
        expandedSize = New Size(originalSize.Width + 210, originalSize.Height + 210)
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
    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
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
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
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

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter

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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Application.Exit()

    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Studets.Show()
    End Sub

    Private Sub Gerald1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Gerald3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Gerald4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles studbox.Click
        Studets.Show()
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As EventArgs) Handles studbox.MouseEnter
        studbox.Hide()
        studbox2.Show()

    End Sub

    Private Sub PictureBox11_MouseLeave(sender As Object, e As EventArgs) Handles studbox.MouseLeave
        studbox.Show()
        studbox2.Hide()
    End Sub

    Private Sub PictureBox12_MouseEnter(sender As Object, e As EventArgs) Handles profbox.MouseEnter
        profbox2.Show()
        profbox.Hide()
    End Sub
    Private Sub PictureBox12_MouseLeave(sender As Object, e As EventArgs) Handles profbox.MouseLeave
        studbox.Hide()
        studbox2.Show()
    End Sub


End Class