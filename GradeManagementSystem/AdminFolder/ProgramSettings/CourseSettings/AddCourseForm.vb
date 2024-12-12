Imports MySql.Data.MySqlClient
Public Class AddCourseForm
    Private connector As New DatabaseConnector
    Private Sub AddCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub
    Private Sub addCourseButton_Click(sender As Object, e As EventArgs) Handles addCourseButton.Click
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO course VALUES ('" & getCourseID() & "','" & courseNameTextBox.Text & "'," & unitTextBox.Text & ");"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.query = "INSERT INTO course_count_history VALUES ();"
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Added Succesfully!")
            connector.connect.Close()
            Me.Visible = False
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
    End Sub
    Private Function getCourseID() As String
        Dim courseID = courseIDTextBox.Text.Replace("-", "")
        Return courseID
    End Function

    Private Sub AddCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        p.AddLine(40, 0, Me.Width - 40, 0)
        p.AddArc(New Rectangle(Me.Width - 40, 0, 40, 40), 270, 90)
        p.AddLine(Me.Width, 40, Me.Width, Me.Height - 40)
        p.AddArc(New Rectangle(Me.Width - 40, Me.Height - 40, 40, 40), 0, 90)
        p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
        p.AddArc(New Rectangle(0, Me.Height - 40, 40, 40), 90, 90)
        p.AddLine(0, Me.Height - 40, 0, 40)
        p.CloseFigure()
        Me.Region = New Region(p)
    End Sub

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub

    Private Sub addcourselabel_Click(sender As Object, e As EventArgs) Handles addcourselabel.Click

    End Sub
End Class