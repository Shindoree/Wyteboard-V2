Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class LoginForm
    Public Shared Username As String
    Public Shared Firstname As String

    Private connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

        ' Load saved email and password if "Keep Signed In" was previously checked
        If My.Settings.KeepSignedIn IsNot Nothing AndAlso Boolean.TryParse(My.Settings.KeepSignedIn, False) Then
            txtEmail.Text = My.Settings.SavedEmail
            txtPassword.Text = My.Settings.SavedPassword
        End If

        If Not String.IsNullOrEmpty(txtEmail.Text) AndAlso Not String.IsNullOrEmpty(txtPassword.Text) Then
            tglKeepSigned.Checked = True
        End If

    End Sub

    Private Sub imgLock_Click(sender As Object, e As EventArgs) Handles imgLock.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
            imgLock.Image = Wyteboard_V2.My.Resources.Resources.icons8_lock_32__1_
        Else
            txtPassword.UseSystemPasswordChar = True
            imgLock.Image = Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text

        Dim usernameIsEmpty As Boolean = String.IsNullOrWhiteSpace(email)
        Dim passwordIsEmpty As Boolean = String.IsNullOrWhiteSpace(password)

        If usernameIsEmpty AndAlso passwordIsEmpty Then
            lblError.Text = "Username and password cannot be empty"
            txtEmail.BorderColor = Color.Red
            txtPassword.BorderColor = Color.Red
            Return
        End If

        If usernameIsEmpty Then
            lblError.Text = "Username cannot be empty"
            txtEmail.BorderColor = Color.Red
            Return
        End If

        If passwordIsEmpty Then
            lblError.Text = "Password cannot be empty"
            txtPassword.BorderColor = Color.Red
            Return
        End If

        If Not email.EndsWith("@lpulaguna.edu.ph") Then
            lblError.Text = "Invalid Email Domain"
            txtEmail.BorderColor = Color.Red ' Set border color to red for invalid domain
            Return
        End If

        Dim userType As String = GetUserType(email, password)

        If userType <> "" Then
            InsertLoginAttempt(email, "Success")
            HandleLoginSuccess(email, userType)
        Else
            InsertLoginAttempt(email, "Failed")
            lblError.Text = "Invalid User"
            txtEmail.BorderColor = Color.Red ' Set border color to red for invalid user
        End If

        If tglKeepSigned.Checked Then
            My.Settings.SavedEmail = txtEmail.Text.Trim()
            My.Settings.SavedPassword = txtPassword.Text
            My.Settings.KeepSignedIn = True
            My.Settings.Save()
        End If
    End Sub

    Private Sub InsertLoginAttempt(email As String, status As String)
        Dim query As String = "INSERT INTO login_attempts (email, login_status, login_time) VALUES (@email, @status, @login_time)"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@login_time", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error inserting login attempt: " & ex.Message)
        End Try
    End Sub

    Private Sub HandleLoginSuccess(email As String, userType As String)
        If userType = "Professor" Then
            Me.Hide()
            Dim professorForm As New ProfessorForm()
            professorForm.Username = email ' Pass the username to ProfessorForm
            professorForm.FirstName = GetFirstName(email) ' Pass the first name to ProfessorForm
            LoginForm.Username = email ' Set the username property in the LoginForm
            professorForm.Show()
        ElseIf userType = "Student" Then
            Console.WriteLine("Redirecting to Student Form") ' Debug: Output redirection to console
            Me.Hide()
            Dim studentForm As New StudentForm()
            studentForm.Username = email ' Pass the username to StudentForm
            studentForm.FirstName = GetFirstName(email) ' Pass the first name to StudentForm
            LoginForm.Username = email ' Set the username property in the LoginForm
            studentForm.Show()
        ElseIf userType = "Admin" Then
            Me.Hide()
            Dim adminForm As New AdminForm()
            adminForm.Username = email ' Pass the username to AdminForm
            adminForm.FirstName = GetFirstName(email) ' Pass the first name to AdminForm
            LoginForm.Username = email ' Set the username property in the LoginForm
            adminForm.Show()
        End If
    End Sub

    Function GetUserType(email As String, password As String) As String
        Dim query As String = "SELECT type FROM tb_user WHERE email = @email AND password = @password"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        Return result.ToString()
                    Else
                        Return ""
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving user type: " & ex.Message)
            Return ""
        End Try
    End Function

    Function GetFirstName(email As String) As String
        Dim firstName As String = ""
        Dim query As String = "SELECT firstname FROM tb_user WHERE email = @email"
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@email", email)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        firstName = result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving first name: " & ex.Message)
        End Try
        Return firstName
    End Function

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        lblError.Text = ""
        txtEmail.BorderColor = Color.Black ' Reset border color to black
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblError.Text = ""
        txtPassword.BorderColor = Color.Black ' Reset border color to black
    End Sub


    Private Sub lnkForgetpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgetpassword.LinkClicked
        Me.Hide()
        Dim ForgotPasswordForm As New ForgotPasswordForm()
        ForgotPasswordForm.Show()
    End Sub
    Private Sub tglKeepSigned_CheckedChanged(sender As Object, e As EventArgs) Handles tglKeepSigned.CheckedChanged
        ' Clear saved email and password if "Keep Signed In" is unchecked
        If Not tglKeepSigned.Checked Then
            My.Settings.SavedEmail = ""
            My.Settings.SavedPassword = ""
            My.Settings.KeepSignedIn = False
            My.Settings.Save()
        End If
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub
End Class
