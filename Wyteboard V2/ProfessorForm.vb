Public Class ProfessorForm
    Public Property Username As String
    Public Property FirstName As String
    Private account As Account ' Field to store the AccountForm instance
    Private CourseForm As CourseForm
    Private Sub btnSlider_Click(sender As Object, e As EventArgs) Handles btnSlider.Click
        If pnlMenu.Width > 60 Then
            pnlMenu.Width = 60 ' Set the panel width to a smaller value instantly
        Else
            pnlMenu.Width = 183 ' Set the panel width to a larger value instantly
        End If
    End Sub
    Private Sub btnOpenChildForm_Click(sender As Object, e As EventArgs) Handles btnSummary.Click, btnCourse.Click, btnAccount.Click, btnHome.Click

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
            Case "btnSummary"
                childForm = New SummaryForm()
            Case "btnCourse"
                If CourseForm Is Nothing Then
                    CourseForm = New CourseForm()
                    CourseForm.Username = Me.Username ' Pass the username to CourseForm
                End If
                ' Always load user data when opening the CourseForm
                CourseForm.LoadDataIntoDataGridView(Me.Username)
                childForm = CourseForm ' Use the existing CourseForm instance
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
            btnSummary.Text = ""
            btnLogout.Text = ""
            btnCourse.Text = ""
            btnHome.Text = ""
        Else
            btnAccount.Text = "Account"
            btnSummary.Text = "Summary"
            btnLogout.Text = "Logout"
            btnCourse.Text = "Course"
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
End Class