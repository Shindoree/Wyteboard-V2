Public Class StudentForm
    Public Property Username As String
    Public Property FirstName As String
    Private account As Account ' Field to store the AccountForm instance
    Private CourseForm As CourseForm
    Private LoginAttempts As DataTable ' DataTable to store login attempts

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
                    CourseForm.FirstName = Me.FirstName ' Pass the first name to HomeForm
                    CourseForm.Username = Me.Username ' Pass the username to CourseForm
                End If
                ' Always load user data when opening the CourseForm
                CourseForm.LoadDataIntoDataGridView(Me.Username)
                childForm = CourseForm ' Use the existing CourseForm instance
            Case "btnHome"
                Dim homeForm As New HomeForm()
                homeForm.Username = Me.Username ' Pass the username to HomeForm
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
        ' Display a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check if the user confirmed the logout
        If result = DialogResult.Yes Then
            ' Hide the current form
            Me.Hide()

            ' Show the login form
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub

    Private Sub pnlDisplay_Paint(sender As Object, e As PaintEventArgs) Handles pnlDisplay.Paint
        lblUser.Text = "Welcome, " & FirstName & " !"
    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize HomeForm to retrieve login attempts data
        Dim homeForm As New HomeForm()
        ' Set the username and first name properties if needed
        homeForm.Username = Me.Username ' Assuming you have the username property in StudentForm
        homeForm.FirstName = Me.FirstName ' Assuming you have the first name property in StudentForm

        ' Retrieve login attempts data from HomeForm and assign it to LoginAttempts
        LoginAttempts = homeForm.GetLatestLoginAttempts(Me.Username)

        ' Display the login attempts data received from HomeForm
        DisplayLoginAttempts()
    End Sub

    Private Sub DisplayLoginAttempts()
        If LoginAttempts.Rows.Count > 0 Then
            ' Display the login date and status of the first attempt
            lblLogin_Time.Text = LoginAttempts.Rows(0)("login_time").ToString()
            lblLogin_Status.Text = LoginAttempts.Rows(0)("login_status").ToString()
            SetLabelColor(lblLogin_Status, LoginAttempts.Rows(0)("login_status").ToString())

            ' If there are more than one attempts, display them on additional labels
            If LoginAttempts.Rows.Count > 1 Then
                lblLogin_Time1.Text = LoginAttempts.Rows(1)("login_time").ToString()
                lblLogin_Status1.Text = LoginAttempts.Rows(1)("login_status").ToString()
                SetLabelColor(lblLogin_Status1, LoginAttempts.Rows(1)("login_status").ToString())
            End If

            If LoginAttempts.Rows.Count > 2 Then
                lblLogin_Time2.Text = LoginAttempts.Rows(2)("login_time").ToString()
                lblLogin_Status2.Text = LoginAttempts.Rows(2)("login_status").ToString()
                SetLabelColor(lblLogin_Status2, LoginAttempts.Rows(2)("login_status").ToString())
            End If
        Else
            ' No login attempts found, display N/A on labels
            lblLogin_Time.Text = "N/A"
            lblLogin_Status.Text = "N/A"
            lblLogin_Time1.Text = "N/A"
            lblLogin_Status1.Text = "N/A"
            lblLogin_Time2.Text = "N/A"
            lblLogin_Status2.Text = "N/A"
        End If
    End Sub

    Private Sub SetLabelColor(label As Label, status As String)
        If status = "Success" Then
            label.ForeColor = Color.Green
        ElseIf status = "Failed" Then
            label.ForeColor = Color.Red
        End If
    End Sub
End Class
