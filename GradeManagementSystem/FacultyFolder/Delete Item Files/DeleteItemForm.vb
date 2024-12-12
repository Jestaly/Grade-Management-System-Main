Imports MySql.Data.MySqlClient
Public Class DeleteItemForm
    Private connector As New DatabaseConnector
    Private deleteProjectForm As New DeleteProjectForm
    Private deleteQuizForm As New DeleteQuizForm

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Visible = False
    End Sub

    Private Sub DeleteItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        makedDPFChild()
        makedDQFChild()
    End Sub
    Private Sub loadProject()
        Dim classID = LoginForgot.gradingSheet.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Project' AND class_id = '" & classID & "' AND term = '" & GradingSheet.getTerm & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                deleteProjectForm.chooseProjectBox.Items.Add(connector.reader("item_name").ToString())
            End While
        Catch ex As MySqlException
            MessageBox.Show("Database Error")
        End Try

        If deleteProjectForm.chooseProjectBox.Items.Count > 0 Then
            deleteProjectForm.chooseProjectBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub loadQuiz()
        Dim classID = LoginForgot.gradingSheet.classChooseBox.Text
        Try
            connector.connect.Open()
            connector.query = "SELECT item_name FROM item WHERE item_type = 'Quiz' AND class_id = '" & classID & "' AND term = '" & GradingSheet.getTerm & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader
            While connector.reader.Read
                deleteQuizForm.chooseQuizBox.Items.Add(connector.reader("item_name").ToString())
            End While
        Catch ex As MySqlException
            MessageBox.Show("Database Error")
        End Try

        If deleteQuizForm.chooseQuizBox.Items.Count > 0 Then
            deleteQuizForm.chooseQuizBox.SelectedIndex = 0
        End If
    End Sub
    Private Sub makedDPFChild()
        deleteProjectForm.TopLevel = False
        deleteProjectForm.Parent = Me.Parent
        CenterDPF()
        deleteProjectForm.BringToFront()
    End Sub

    Private Sub CenterDPF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - deleteProjectForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - deleteProjectForm.Height) \ 2
        deleteProjectForm.Location = New Point(x, y)
    End Sub

    Private Sub makedDQFChild()
        deleteQuizForm.TopLevel = False
        deleteQuizForm.Parent = Me.Parent
        CenterDQF()
        deleteQuizForm.BringToFront()
    End Sub

    Private Sub CenterDQF()
        Dim x As Integer = (Me.Parent.ClientSize.Width - deleteQuizForm.Width) \ 2
        Dim y As Integer = (Me.Parent.ClientSize.Height - deleteQuizForm.Height) \ 2
        deleteQuizForm.Location = New Point(x, y)
    End Sub

    Private Sub deleteQuizButton_Click(sender As Object, e As EventArgs) Handles deleteQuizButton.Click
        loadQuiz()
        Me.Visible = False
        deleteQuizForm.Visible = True
    End Sub

    Private Sub deleteProjectButton_Click(sender As Object, e As EventArgs) Handles deleteProjectButton.Click
        loadProject()
        Me.Visible = False
        deleteProjectForm.Visible = True
    End Sub
End Class