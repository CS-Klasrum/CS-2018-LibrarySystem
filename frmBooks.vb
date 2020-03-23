Imports MySql.Data.MySqlClient
Public Class frmBooks
    Dim str As String = "server=localhost; uid=root; pwd=; database=librarysystem"
    Dim con As New MySqlConnection(str)
    Dim borrow As String
    Public Sub ShowDT()
        'SHOW THE TABLE FROM THE DATABASE
        TxtAuthor.Enabled = False
        TxtBookTitle.Enabled = False
        TxtPageCount.Enabled = False
        TxtPublisher.Enabled = False
        TxtLocation.Enabled = False
        TxtSubject.Enabled = False
        TxtQuantity.Enabled = False

        Dim query As String = "Select * from tbl_books"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds, "Emp")
        DataGridView1.DataSource = ds.Tables(0)

        TxtAuthor.Text = ""
        TxtBookTitle.Text = ""
        TxtPageCount.Text = ""
        TxtPublisher.Text = ""
        TxtLocation.Text = ""
        TxtSubject.Text = ""
        TxtQuantity.Text = ""
        con.Close()
    End Sub

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowDT()
    End Sub

    Private Sub Btn_AddBooks_Click(sender As Object, e As EventArgs) Handles Btn_AddBooks.Click
        'Add Books to the database
        Dim adapt As New MySqlDataAdapter
        Dim command As New MySqlCommand
        Dim ds As DataSet

        If TxtAuthor.Text = "" Or TxtBookTitle.Text = "" Or TxtPageCount.Text = "" Or TxtPublisher.Text = "" Or TxtLocation.Text = "" Or TxtSubject.Text = "" Or TxtQuantity.Text = "" Then
            MsgBox("Please input something!")

        Else
            ds = New DataSet
            adapt = New MySqlDataAdapter("insert into tbl_books (BookAuthor, BookTitle, PageNumber, Publisher, Location, Subject, InStock, AvailableQuantity) VALUES ('" & TxtAuthor.Text & "','" & TxtBookTitle.Text & "','" & TxtPageCount.Text & "','" & TxtPublisher.Text & "','" & TxtLocation.Text & "','" & TxtSubject.Text & "','" & TxtQuantity.Text & "','" & TxtQuantity.Text & "')", con)
            adapt.Fill(ds, "tbl_books")

            TxtAuthor.Text = ""
            TxtBookTitle.Text = ""
            TxtPageCount.Text = ""
            TxtPublisher.Text = ""
            TxtLocation.Text = ""
            TxtSubject.Text = ""
            TxtQuantity.Text = ""
            MsgBox("Book Has Been Added!")
            ShowDT()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow

        TxtAuthor.Text = row.Cells(1).Value.ToString()
        TxtBookTitle.Text = row.Cells(2).Value.ToString()
        TxtPageCount.Text = row.Cells(3).Value.ToString()
        TxtPublisher.Text = row.Cells(4).Value.ToString()
        TxtLocation.Text = row.Cells(5).Value.ToString()
        TxtSubject.Text = row.Cells(6).Value.ToString()
        TxtQuantity.Text = row.Cells(8).Value.ToString()

    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        'THIS IS THE SEARCH
        Dim adapter As MySqlDataAdapter
        Dim ds As New DataSet

        con.Open()
        adapter = New MySqlDataAdapter("Select * from tbl_books where BookTitle like '%" & TxtSearch.Text & "%' ", con)
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
        TxtAuthor.Text = ""
        TxtBookTitle.Text = ""
        TxtPageCount.Text = ""
        TxtPublisher.Text = ""
        TxtLocation.Text = ""
        TxtSubject.Text = ""
        TxtQuantity.Text = ""
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        'Delete books 
        Dim cmd As MySqlCommand
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandText = "DELETE FROM `tbl_books` WHERE `BookTitle`= '" & TxtBookTitle.Text & "' "
        cmd.ExecuteNonQuery()
        ShowDT()

        con.Close()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        ' update database when you do some changes to your books
        Dim cmd As MySqlCommand

        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "Update tbl_books set BookAuthor=@BookAuthor, PageNumber=@PageNumber, Publisher=@Publisher, Location=@Location, Subject=@Subject where Booktitle=@Booktitle"
            cmd.Parameters.AddWithValue("@BookAuthor", TxtAuthor.Text)
            cmd.Parameters.AddWithValue("@BookTitle", TxtBookTitle.Text)
            cmd.Parameters.AddWithValue("@PageNumber", TxtPageCount.Text)
            cmd.Parameters.AddWithValue("@Publisher", TxtPublisher.Text)
            cmd.Parameters.AddWithValue("@Location", TxtLocation.Text)
            cmd.Parameters.AddWithValue("@Subject", TxtSubject.Text)
            cmd.ExecuteNonQuery()
            ShowDT()
        Catch ex As Exception

        End Try
            con.Close()
    End Sub

    Private Sub ComboBoxStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Select Case ComboBoxStatus.SelectedItem.ToString
        'Case "Available"
        ' borrow = "Available"
        ' Case "Not Available"
        'borrow = "Not Available"
        'End Select
    End Sub

    Private Sub Btn_Borrow_Click(sender As Object, e As EventArgs) Handles Btn_Borrow.Click
        'show the form where you can borrow books
        TxtAuthor.Text = ""
        TxtBookTitle.Text = ""
        TxtPageCount.Text = ""
        TxtPublisher.Text = ""
        TxtLocation.Text = ""
        TxtSubject.Text = ""
        TxtQuantity.Text = ""

        frmBorrow.Show()
        frmMainMenu.Hide()


    End Sub

    Private Sub Btn_AddNew_Click(sender As Object, e As EventArgs) Handles Btn_AddNew.Click
        TxtAuthor.Enabled = True
        TxtBookTitle.Enabled = True
        TxtPageCount.Enabled = True
        TxtPublisher.Enabled = True
        TxtLocation.Enabled = True
        TxtSubject.Enabled = True
        TxtQuantity.Enabled = True
    End Sub
End Class