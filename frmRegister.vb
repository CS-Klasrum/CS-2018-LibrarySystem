Imports MySql.Data.MySqlClient
Public Class frmRegister
    Public conn As New MySqlConnection("Server=localhost; User Id=root; Password=''; Database=librarysystem")
    Public adapter As New MySqlDataAdapter
    Public command As New MySqlCommand
    Dim ds As DataSet
    Dim encrypt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_SignUp.Click
        Encryption()
        ds = New DataSet
        adapter = New MySqlDataAdapter("insert into tbl_accounts (FirstName, MiddleName, LastName, Username, Password) VALUES ('" & TxtFirstName.Text & "','" & TxtMiddleName.Text & "','" & TxtLastName.Text & "','" & TxtUsername.Text & "','" & TxtPassword.Text & "')", conn)
        adapter.Fill(ds, "tbl_accounts")

        TxtFirstName.Text = ""
        TxtMiddleName.Text = ""
        TxtLastName.Text = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""

        MsgBox("Registered")
    End Sub

    Public Sub Encryption()
        Dim eeee As Integer = 3

        For Each letter As String In TxtPassword.Text
            encrypt += Chr(Asc(letter) + eeee)

        Next
        TxtPassword.Text = encrypt

    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class