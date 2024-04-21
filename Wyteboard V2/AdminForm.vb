Public Class AdminForm
    Public Property Username As String
    Public Property FirstName As String
    Private account As Account ' Field to store the AccountForm instance
    Private CourseProfessorForm As CourseProfessorForm ' Update the variable type
    Private Sub btnSlider_Click(sender As Object, e As EventArgs) Handles btnSlider.Click
        If pnlMenu.Width > 60 Then
            pnlMenu.Width = 60 ' Set the panel width to a smaller value instantly
        Else
            pnlMenu.Width = 183 ' Set the panel width to a larger value instantly
        End If
    End Sub
    Private Sub btnOpenChildForm_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click, btnAccount.Click, btnHome.Click

        Console.WriteLine("Button clicked: " & DirectCast(sender, Button).Name)
        Dim btn As Button = DirectCast(sender, Button)
        Dim childForm As Form = Nothing

        ' Determine which child form to open based on the button clicked
        Select Case btn.Name
            Case "btnAccount"
                If account Is Nothing Then
                    account = New Account()
                    account.Username = Me.Username ' Pass the username to AccountForm
                End If
                ' Always load user data when opening the AccountForm
                account.LoadUserData(account.Username)
                childForm = account
            Case "btnRegistration"
                childForm = New RegistrationForm()
                childForm = RegistrationForm
            Case "btnHome"
                Dim homeForm As New HomeForm()
                homeForm.FirstName = Me.FirstName ' Pass the first name to HomeForm
                childForm = homeForm
        End Select

        ' Open the selected child form
        If childForm IsNot Nothing Then
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            pnlDisplay.Controls.Clear()
            pnlDisplay.Controls.Add(childForm)
            childForm.Show()
        End If
    End Sub
    Private Sub pnlMenu_SizeChanged(sender As Object, e As EventArgs) Handles pnlMenu.SizeChanged
        If pnlMenu.Width < 180 Then
            btnAccount.Text = ""
            btnRegistration.Text = ""
            btnLogout.Text = ""
            btnHome.Text = ""
        Else
            btnAccount.Text = "Account"
            btnRegistration.Text = "Enroll Student"
            btnLogout.Text = "Logout"
            btnHome.Text = "Home"
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim LoginForm As New LoginForm()
        LoginForm.Show()
    End Sub
    Private Sub pnlDisplay_Paint(sender As Object, e As PaintEventArgs) Handles pnlDisplay.Paint
        lblUser.Text = "Welcome, " & FirstName & " !"
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class