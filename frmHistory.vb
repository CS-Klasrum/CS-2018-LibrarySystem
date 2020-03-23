Imports MySql.Data.MySqlClient
Public Class frmHistory
    'THIS FORM SHOW THE HISTORY OF THE BORROW AND RETURN BOOKS
    Dim str As String = "server=localhost; uid=root; pwd=; database=librarysystem"
    Dim con As New MySqlConnection(str)
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query1 As String = "Select * from tbl_history"
        Dim adpt1 As New MySqlDataAdapter(query1, con)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "Emp")
        DataGridView1.DataSource = ds1.Tables(0)
    End Sub
End Class