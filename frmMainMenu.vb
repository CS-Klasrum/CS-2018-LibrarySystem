Public Class frmMainMenu
    'show other form
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Bnt_Books.Click
        switchPanel(frmBooks)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(frmHistory)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmReturnBooks.ShowTB()
        switchPanel(frmReturnBooks)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        Dim ask As MsgBoxResult

        ask = MsgBox("Are You Sure?", MsgBoxStyle.YesNo, "Exit")

        If ask = MsgBoxResult.Yes Then
            frmLogin.Show()
            Me.Close()
        Else
            If ask = MsgBoxResult.No Then
                MsgBox("Sure")
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class