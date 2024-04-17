Public Class HomeForm
    Public Property FirstName As String
    Private Sub pnlHome_Paint(sender As Object, e As PaintEventArgs) Handles pnlHome.Paint

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = "Welcome, " & FirstName & " !"
    End Sub
End Class