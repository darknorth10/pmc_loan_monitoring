Imports MySql.Data.MySqlClient

Public Class usrctrldashboard

    Private Sub usrctrldashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Str = "SELECT * FROM user_table"
            con.Open()
            Dim Search As New MySqlDataAdapter(Str, con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "user_table")
            dg1.DataSource = ds.Tables("user_table")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
End Class
