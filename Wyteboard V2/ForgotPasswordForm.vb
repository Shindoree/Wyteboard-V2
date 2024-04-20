Imports DocumentFormat.OpenXml.Office2016.Drawing.Command
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class ForgotPasswordForm
    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the items for cbxSecurityQuestion
        cbxSecurityQuestion.Items.Clear()
        cbxSecurityQuestion.Items.Add("What was the name of your first pet?")
        cbxSecurityQuestion.Items.Add("In what city were you born?")

        txtNewPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim email As String = txtEmail.Text
        Dim schoolID As String = txtSchoolID.Text
        Dim question As String = cbxSecurityQuestion.SelectedItem.ToString()
        Dim answer As String = txtSecAnswer.Text
        Dim newPassword As String = txtNewPassword.Text
        Dim confirmPass As String = txtConfirmPass.Text

        ' Check if newPassword and confirmPass match
        If newPassword = confirmPass Then
            Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600"
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM tb_user WHERE email = @Email AND schoolid = @SchoolID AND question = @SecurityQuestion AND answer = @SecurityAnswer"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@SchoolID", schoolID)
                    command.Parameters.AddWithValue("@SecurityQuestion", question)
                    command.Parameters.AddWithValue("@SecurityAnswer", answer)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        ' Update password
                        Dim updateQuery As String = "UPDATE tb_user SET password = @NewPassword WHERE email = @Email"
                        Using updateCommand As New MySqlCommand(updateQuery, connection)
                            updateCommand.Parameters.AddWithValue("@NewPassword", newPassword)
                            updateCommand.Parameters.AddWithValue("@Email", email)
                            updateCommand.ExecuteNonQuery()
                            MessageBox.Show("Password updated successfully!")
                        End Using
                    Else
                        MessageBox.Show("Invalid credentials. Please check your input.")
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("Passwords do not match. Please re-enter.")
        End If
    End Sub

    Private Sub imgLockPass_Click(sender As Object, e As EventArgs) Handles imgLockPass.Click
        ToggleVisibility(txtNewPassword, imgLockPass)
    End Sub

    Private Sub imgLockConfPass_Click(sender As Object, e As EventArgs) Handles imgLockConfPass.Click
        ToggleVisibility(txtConfirmPass, imgLockConfPass)
    End Sub

    Private Sub ToggleVisibility(textBox As Guna2TextBox, imageButton As Guna2ImageButton)
        textBox.UseSystemPasswordChar = Not textBox.UseSystemPasswordChar
        If textBox.UseSystemPasswordChar Then
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Else
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_lock_32__1_
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        Dim LoginForm As New LoginForm()
        LoginForm.Show()
    End Sub
End Class
