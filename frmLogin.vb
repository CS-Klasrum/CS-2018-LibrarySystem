Imports MySql.Data.MySqlClient
Public Class frmLogin
    Public conn As New MySqlConnection("Server=localhost; User Id=root; Password=''; Database=db_login")
    Public adapter As New MySqlDataAdapter
    Public command As New MySqlCommand
    Dim ds As DataSet
    Dim encrypt As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        frmMainMenu.Label2.Text = TxtUsername.Text
        Encryption()
        DBConn()
    End Sub
    Public Sub Encryption()
        ' encrypt the password
        Dim eeee As Integer = 3
        For Each letter As String In TxtPassword.Text()
            encrypt += Chr(Asc(letter) + eeee)

        Next
        TxtPassword.Text = encrypt

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSP.CheckedChanged
        'show password
        If TxtPassword.UseSystemPasswordChar = True Then

            TxtPassword.UseSystemPasswordChar = False

        Else

            TxtPassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        'exit the program
        Dim ask As MsgBoxResult

        ask = MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Exit")

        If ask = MsgBoxResult.Yes Then
            Me.Close()
        Else
            If ask = MsgBoxResult.No Then
                MsgBox("Okay")
            End If
        End If

    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyData = Keys.Enter Then
            Btn_Login.PerformClick()
        End If
    End Sub

    Public Sub DBConn()
        ' check connection
        Dim McN As New DTConnection

        Try
            McN.open()

            ds = New DataSet

            adapter = New MySqlDataAdapter("select * from tbl_accounts where Username = '" & TxtUsername.Text & "' and Password = '" & TxtPassword.Text & "'", conn)

            adapter.Fill(ds, "tbl_accounts")

            If ds.Tables("tbl_accounts").Rows.Count > 0 Then
                MsgBox("Successfully Login")
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                encrypt = ""
                frmMainMenu.Show()
                Me.Hide()
            Else
                TxtUsername.Text = ""
                TxtPassword.Text = ""
                encrypt = ""
                MsgBox("Invalid Username or Password")
            End If
            McN.close()
        Catch ex As Exception
            MsgBox("You have No Connection")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            encrypt = ""
            McN.close()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        encrypt = ""
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
