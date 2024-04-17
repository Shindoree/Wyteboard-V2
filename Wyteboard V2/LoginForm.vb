Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public Shared Username As String
    Public Shared Firstname As String
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
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
        Dim usernameIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtEmail.Text)
        Dim passwordIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtPassword.Text)

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

        Dim userType As String = GetUserType(txtEmail.Text, txtPassword.Text)

        If userType = "Admin" OrElse userType = "Professor" Then
            Me.Hide()
            Dim professorForm As New ProfessorForm()
            professorForm.Username = txtEmail.Text ' Pass the username to ProfessorForm
            professorForm.FirstName = GetFirstName(txtEmail.Text) ' Pass the first name to ProfessorForm
            LoginForm.Username = txtEmail.Text ' Set the username property in the LoginForm
            professorForm.Show()
        ElseIf userType = "Student" Then
            Console.WriteLine("Redirecting to Student Form") ' Debug: Output redirection to console
            Me.Hide()
            Dim studentForm As New StudentForm()
            studentForm.Username = txtEmail.Text ' Pass the username to StudentForm
            studentForm.FirstName = GetFirstName(txtEmail.Text) ' Pass the first name to StudentForm
            LoginForm.Username = txtEmail.Text ' Set the username property in the LoginForm
            studentForm.Show()
        Else
            lblError.Text = "Invalid User"
        End If
    End Sub

    Function GetUserType(email As String, password As String) As String
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"
        Dim query As String = "SELECT type FROM wyteboard.tb_users WHERE email = @email AND password = @password"

        Try
            Using myConnection As New MySqlConnection(connectionString)
                myConnection.Open()
                Dim myCommand As New MySqlCommand(query, myConnection)
                myCommand.Parameters.AddWithValue("@email", email)
                myCommand.Parameters.AddWithValue("@password", password)
                Dim result As String = Convert.ToString(myCommand.ExecuteScalar())
                Return result
            End Using
        Catch ex As Exception
            MsgBox("Error retrieving user type: " & ex.Message)
            Return Nothing
        End Try
    End Function
    Function GetFirstName(email As String) As String
        Dim firstName As String = ""
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"
        Dim query As String = "SELECT firstname FROM tb_users WHERE email = @email"

        Try
            Using myConnection As New MySqlConnection(connectionString)
                myConnection.Open()
                Using myCommand As New MySqlCommand(query, myConnection)
                    myCommand.Parameters.AddWithValue("@email", email)
                    Dim result As Object = myCommand.ExecuteScalar()
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

        txtEmail.BorderColor = Color.Gray
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblError.Text = ""

        txtPassword.BorderColor = Color.Gray
    End Sub

    Private Sub lnkForgetpassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgetpassword.LinkClicked
        Me.Hide()
        Dim ForgotPasswordForm As New ForgotPasswordForm()
        ForgotPasswordForm.Show()
    End Sub
End Class
