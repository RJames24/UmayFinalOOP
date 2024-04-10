Imports MySql.Data.MySqlClient
Module connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Sub OpenCon()
        con.ConnectionString = My.Settings.ohmysalondbConnectionString
        con.Open()
        cmd.Connection = con
    End Sub
End Module
