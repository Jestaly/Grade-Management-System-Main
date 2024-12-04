Public Class ProfessorForm
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)


        Dim g As Graphics = e.Graphics

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Dim radius As Integer = 30
        Dim path As New Drawing2D.GraphicsPath()


        path.AddArc(rect.Left, rect.Top, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Top, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.Left, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
    End Sub

    Private Sub logoutbttn_Click(sender As Object, e As EventArgs) Handles logoutbttn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub logoutbttn2_Click(sender As Object, e As EventArgs) Handles logoutbttn2.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub notifview_Paint(sender As Object, e As PaintEventArgs) Handles logview.Paint
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim g As Graphics = e.Graphics
        Dim rect As New Rectangle(0, 0, dgv.Width - 1, dgv.Height - 1)
        Dim radius As Integer = 15 ' Set the radius of the corners

        Dim path As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90) ' Top-left corner
        path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90) ' Top-right corner
        path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90) ' Bottom-right corner
        path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90) ' Bottom-left corner
        path.CloseFigure()

        ' Set up the border color and width
        Dim pen As New Pen(Color.Gray, 2) ' Change the color and width as needed

        ' Draw the border
        g.DrawPath(pen, path)
    End Sub

    Private Sub ProfessorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logview.BorderStyle = BorderStyle.None ' Remove default border
        logview.EnableHeadersVisualStyles = False ' Disable header border style
        logview.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray ' Customize header
        logview.RowHeadersVisible = False
    End Sub

    Private Sub notifview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles logview.CellContentClick

    End Sub


    Private Sub notifbttn_Click_1(sender As Object, e As EventArgs) Handles notifbttn.Click
        notifview.Visible = True
        logview.Visible = False
    End Sub

    Private Sub logbttn_Click(sender As Object, e As EventArgs) Handles logbttn.Click
        logview.Visible = True
        notifview.Visible = False
    End Sub

    Private Sub grademanagement_Click(sender As Object, e As EventArgs) Handles grademanagement.Click
        grademanage.Visible = True
        prof_grademanagement.Show()
    End Sub
End Class

