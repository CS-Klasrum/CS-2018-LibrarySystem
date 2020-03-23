Imports MySql.Data.MySqlClient
Public Class frmReturnBooks
    Dim str As String = "server=localhost; uid=root; pwd=; database=librarysystem"
    Dim con As New MySqlConnection(str)

    Public Sub ShowTB()
        Dim query As String = "Select * from tbl_borrowedbooks"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        con.Open()
        adapter = New MySqlDataAdapter("Select * from tbl_borrowedbooks where BookName like '%" & TextBox1.Text & "%' ", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub frmReturnBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTransactionID.Enabled = False
        TxtStudentName.Enabled = False
        TxtBookTitle.Enabled = False
        TxtCourse.Enabled = False
        ShowTB()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        TxtTransactionID.Text = row.Cells(0).Value.ToString()
        TxtStudentName.Text = row.Cells(1).Value.ToString()
        TxtCourse.Text = row.Cells(2).Value.ToString()
        TxtBookTitle.Text = row.Cells(3).Value.ToString()
        Lbl_IssueDate.Text = row.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bnt_Return.Click
        'THIS BUTTON RETURN THE BOOK FROM THE LIBRARY
        Dim cmd1 As MySqlCommand
        Dim cmd2 As MySqlCommand
        Dim ds As DataSet
        Dim adapt As MySqlDataAdapter
        con.Open()

        ds = New DataSet
        adapt = New MySqlDataAdapter("insert into tbl_history (TransactionID, StudentName, Course, BookName, BorrowDate, ReturnDate) VALUES ('" & TxtTransactionID.Text & "','" & TxtStudentName.Text & "','" & TxtCourse.Text & "','" & TxtBookTitle.Text & "','" & Lbl_IssueDate.Text & "','" & DateTimePickerReturnDate.Text & "')", con)
        adapt.Fill(ds, "tbl_history")


        cmd1 = con.CreateCommand()
        cmd1.CommandText = "Update tbl_books set AvailableQuantity=AvailableQuantity+1 where BookTitle='" & TxtBookTitle.Text & "'"
        cmd1.ExecuteNonQuery()


        cmd2 = con.CreateCommand()
        cmd2.CommandText = "DELETE FROM `tbl_borrowedbooks` WHERE `TransactionID`= '" & TxtTransactionID.Text & "' "
        cmd2.ExecuteNonQuery()

        MsgBox("Book Has Been Return!")

        con.Close()
        ShowTB()
    End Sub
End Class