Imports MySql.Data.MySqlClient

Public Class OfficialModifyCourseForm
    Private connector As New DatabaseConnector
    Private Sub OfficialModifyCourseForm_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False
    End Sub

    Private Sub modifyCourseButton_Click(sender As Object, e As EventArgs) Handles modifyCourseButton.Click
        Try
            connector.connect.Open()
            connector.query = "UPDATE course SET course_name = '" & courseNameTextBox.Text & "', units = " & unitTextBox.Text & " WHERE course_id = '" & trimmedCourseID() & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            MessageBox.Show("Modified Successfully!")
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database Error")
        End Try
        Me.Visible = False
    End Sub

    Private Function trimmedCourseID() As String
        Dim courseID As String = courseIDTextBox.Text
        courseID = courseID.Replace("-", "")
        Return courseID
    End Function

    Private Sub backbttn_Click(sender As Object, e As EventArgs) Handles backbttn.Click
        Me.Visible = False
    End Sub

    Private Sub OfficialModifyCourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class