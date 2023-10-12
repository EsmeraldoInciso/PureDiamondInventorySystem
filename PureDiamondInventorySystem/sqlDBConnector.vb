Imports MySql.Data.MySqlClient

Module sqlDBConnector
    Public Function strConnection() As MySqlConnection
        Return New MySqlConnection("server = localhost; user = root; password =; database = db_inventory_braga")
    End Function
    Public strcon As MySqlConnection = strConnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

End Module
