Imports MySql.Data.MySqlClient
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
            btnRegistration.Text = ""
            btnLogout.Text = ""
            btnHome.Text = ""
        Else
            btnAccount.Text = "Account"
            btnRegistration.Text = "Enrollment"
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
    Public Function GetLatestLoginAttempts(email As String) As DataTable
        Dim loginAttempts As New DataTable()

        ' Database connection string
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

        ' SQL query to retrieve the latest three login attempts
        Dim query As String = "SELECT email, login_time, login_status FROM wyteboard.login_attempts WHERE email = @email ORDER BY login_time DESC LIMIT 3"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create MySqlCommand
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@email", email)

                    ' Create DataAdapter to fill DataTable
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(loginAttempts)
                End Using
            End Using

            Return loginAttempts
        Catch ex As Exception
            MessageBox.Show("Error retrieving login attempts: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return loginAttempts
        End Try
    End Function

    Private Sub DisplayLoginAttempts(loginAttempts As DataTable)
        If loginAttempts.Rows.Count > 0 Then
            ' Display the login date and status of the first attempt
            lblLogin_Time.Text = loginAttempts.Rows(0)("login_time").ToString()
            lblLogin_Status.Text = loginAttempts.Rows(0)("login_status").ToString()
            SetLabelColor(lblLogin_Status, loginAttempts.Rows(0)("login_status").ToString())

            ' If there are more than one attempts, display them on additional labels
            If loginAttempts.Rows.Count > 1 Then
                lblLogin_Time1.Text = loginAttempts.Rows(1)("login_time").ToString()
                lblLogin_Status1.Text = loginAttempts.Rows(1)("login_status").ToString()
                SetLabelColor(lblLogin_Status1, loginAttempts.Rows(1)("login_status").ToString())
            End If

            If loginAttempts.Rows.Count > 2 Then
                lblLogin_Time2.Text = loginAttempts.Rows(2)("login_time").ToString()
                lblLogin_Status2.Text = loginAttempts.Rows(2)("login_status").ToString()
                SetLabelColor(lblLogin_Status2, loginAttempts.Rows(2)("login_status").ToString())
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

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginAttempts As DataTable = GetLatestLoginAttempts(Username)

        ' Display the login attempts on labels
        DisplayLoginAttempts(loginAttempts)
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel5.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class