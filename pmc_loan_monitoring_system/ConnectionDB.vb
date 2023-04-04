Imports MySql.Data.MySqlClient


Module ConnectionDB
    Public con As MySqlConnection = New MySqlConnection("server=localhost;database=pmc_db;uid=root;password=root")
    Public cmd As MySqlCommand = New MySqlCommand()
    Public dr As MySqlDataReader
End Module
