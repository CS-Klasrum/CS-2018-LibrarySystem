Imports MySql.Data.MySqlClient
Module MyConnect
    Public Class DTConnection
        Dim conn As New MySqlConnection("Server=localhost; User Id=root; Password=''; Database=db_login")
        Public Function open()
            conn.Open()
            Return conn
        End Function

        Public Function close()
            conn.Close()
            Return conn
        End Function

    End Class
End Module
