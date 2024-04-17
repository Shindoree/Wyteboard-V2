Public Class StudentForm
    Public Property Username As String
    Private account As Account ' Field to store the AccountForm instance
    Private CourseForm As CourseForm
    Private Sub btnSlider_Click(sender As Object, e As EventArgs) Handles btnSlider.Click
        If pnlMenu.Width > 60 Then
            pnlMenu.Width = 60 ' Set the panel width to a smaller value instantly
        Else
            pnlMenu.Width = 183 ' Set the panel width to a larger value instantly
        End If
    End Sub
    Private Sub btnOpenChildForm_Click(sender As Object, e As EventArgs) Handles btnSummary.Click, btnCourse.Click, btnAccount.Click
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
        Else
            btnAccount.Text = "Account"
            btnSummary.Text = "Summary"
            btnLogout.Text = "Logout"
            btnCourse.Text = "Course"
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Dim LoginForm As New LoginForm()
        LoginForm.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub

    Private Sub pnlMenu_Paint(sender As Object, e As PaintEventArgs) Handles pnlMenu.Paint

    End Sub

    Private Sub pnlControl_Paint(sender As Object, e As PaintEventArgs) Handles pnlControl.Paint

    End Sub

    Private Sub pnlSidebarTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlSidebarTop.Paint

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub

    Private Sub pnlDisplay_Paint(sender As Object, e As PaintEventArgs) Handles pnlDisplay.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class