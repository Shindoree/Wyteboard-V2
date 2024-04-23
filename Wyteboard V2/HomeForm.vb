Imports MySql.Data.MySqlClient

Public Class HomeForm
    Public Property FirstName As String
    Public Property Username As String

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = "Welcome, " & FirstName & " !"

        ' Retrieve the latest three login attempts
        Dim loginAttempts As DataTable = GetLatestLoginAttempts(Username)

        ' Display the login attempts on labels
        DisplayLoginAttempts(loginAttempts)
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

    Private Sub pnlHome_Paint(sender As Object, e As PaintEventArgs) Handles pnlHome.Paint

    End Sub

    Private Sub lblLogin_Time1_Click(sender As Object, e As EventArgs) Handles lblLogin_Time1.Click

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub

    Private Sub Guna2Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel4.Paint

    End Sub
End Class
