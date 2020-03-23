Imports MySql.Data.MySqlClient
Public Class frmBorrow
    Dim str As String = "server=localhost; uid=root; pwd=; database=librarysystem"
    Dim con As New MySqlConnection(str)

    Public Sub ShowTable()

        Dim query As String = "Select * from tbl_students"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)

        Dim query1 As String = "Select * from tbl_books"
        Dim adpt1 As New MySqlDataAdapter(query1, con)
        Dim ds1 As New DataSet()
        adpt1.Fill(ds1, "Emp")
        DataGridView2.DataSource = ds1.Tables(0)

        
    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        frmBooks.ShowDT()
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub Btn_IssueBook_Click(sender As Object, e As EventArgs) Handles Btn_IssueBook.Click
        'borrow the book
        Dim adapt As New MySqlDataAdapter
        Dim ds As DataSet
        Dim cmd As MySqlCommand
        Dim ds1 As New DataSet
        con.Open()

        Dim adapt1 As New MySqlDataAdapter("Select * From tbl_books where AvailableQuantity = '" & TxtQuantity.Text & "'", con)
        adapt1.Fill(ds1, "tbl_books")

        If TxtFirstName.Text = "" Or TxtLastName.Text = "" Or TxtMiddleName.Text = "" Or TxtCourse.Text = "" Or TxtQuantity.Text = "" Or TxtSearchBookTitle.Text = "" Then
            MsgBox("Select First")

        ElseIf ds1.Tables("tbl_books").Rows.Count > 0 And TxtQuantity.Text > 0 Then

            ds = New DataSet
            adapt = New MySqlDataAdapter("insert into tbl_borrowedbooks (TransactionID, StudentName, Course, BookName, BorrowDate) VALUES ('" & TxtSearchStudent.Text & "','" & TxtFirstName.Text & "','" & TxtCourse.Text & "','" & TxtSearchBookTitle.Text & "','" & DateTimePickerIssueDate.Text & "')", con)
            adapt.Fill(ds, "tbl_borrowedbooks")

            cmd = con.CreateCommand()
            cmd.CommandText = "Update tbl_books set AvailableQuantity=AvailableQuantity-1 where BookTitle='" & TxtSearchBookTitle.Text & "'"
            cmd.ExecuteNonQuery()

            TxtLastName.Text = ""
            TxtFirstName.Text = ""
            TxtMiddleName.Text = ""
            TxtCourse.Text = ""
            TxtQuantity.Text = ""
            TxtSearchBookTitle.Text = ""

            MsgBox("Book Has Been Borrowed!")

            ShowTable()
        Else
        MsgBox("Not Available")
        End If

        con.Close()
    End Sub

    Private Sub TxtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles TxtSearchStudent.TextChanged
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        con.Open()
        adapter = New MySqlDataAdapter("Select * from tbl_students where StudentID like '%" & TxtSearchStudent.Text & "%' ", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub frmBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtFirstName.Enabled = False
        TxtLastName.Enabled = False
        TxtMiddleName.Enabled = False
        TxtCourse.Enabled = False
        TxtQuantity.Enabled = False
        ShowTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        TxtLastName.Text = row.Cells(1).Value.ToString()
        TxtFirstName.Text = row.Cells(2).Value.ToString()
        TxtMiddleName.Text = row.Cells(3).Value.ToString()
        TxtCourse.Text = row.Cells(4).Value.ToString()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim row As DataGridViewRow = DataGridView2.CurrentRow

        TxtQuantity.Text = row.Cells(8).Value.ToString()
        TxtSearchBookTitle.Text = row.Cells(2).Value.ToString()

    End Sub
End Class