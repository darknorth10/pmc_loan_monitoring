Imports MySql.Data.MySqlClient


Module ConnectionDB
    Public con As MySqlConnection = New MySqlConnection()
    Public cmd As MySqlCommand = New MySqlCommand()
    Public dr As MySqlDataReader
End Module
