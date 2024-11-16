Imports MySql.Data.MySqlClient
Public Class DatabaseConnector
    Public command As New MySqlCommand
    Public dt As New DataTable
    Public da As New MySqlDataAdapter
    Public query As String
    Public connect As New MySqlConnection("server=localhost;port=3307;user=root;password=joseph;database=student")


End Class
