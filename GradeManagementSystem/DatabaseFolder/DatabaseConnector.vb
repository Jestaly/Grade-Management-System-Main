Imports MySql.Data.MySqlClient
Public Class DatabaseConnector
    Public command As New MySqlCommand
    Public dataTable As New DataTable
    Public dataAdapter As New MySqlDataAdapter
    Public query As String
    Public connect As New MySqlConnection("server=junction.proxy.rlwy.net;port=53279;user=root;database=railway;password=UqyPpiCjXZajgtFXekWpBeuaocTXTkkt")
    Public reader As MySqlDataReader
End Class
