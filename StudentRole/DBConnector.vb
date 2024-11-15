Imports MySql.Data.MySqlClient

Public Class DBConnector
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim str As String
    Dim x As Integer
    Dim con As New MySqlConnection("server=localhost;port=3307;user=root;password=joseph;database=sales")
    Public Sub connectToDB()

        MessageBox.Show("Connected!")
    End Sub
End Class
