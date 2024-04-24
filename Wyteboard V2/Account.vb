Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class Account
    Public Property Username As String
    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData(Username)
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
        txtAnswer.UseSystemPasswordChar = True
        txtConfirmAnswer.UseSystemPasswordChar = True
    End Sub
    Public Sub LoadUserData(email As String)
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600"
        Dim query As String = "SELECT * FROM wyteboard.tb_user WHERE email = @email"

        Try
            Using myConnection As New MySqlConnection(connectionString)
                myConnection.Open()
                Dim myCommand As New MySqlCommand(query, myConnection)
                myCommand.Parameters.AddWithValue("@email", email)

                Using reader As MySqlDataReader = myCommand.ExecuteReader()
                    If reader.Read() Then
                        txtEmail.Text = reader.GetString("email")
                        txtSchoolID.Text = reader.GetString("schoolid")
                        txtFirstname.Text = reader.GetString("firstname")
                        txtLastname.Text = reader.GetString("lastname")
                        ' Update other textboxes with corresponding database fields
                    Else
                        MessageBox.Show("User not found.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching user data: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateUserData()
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600"
        Dim query As String = "UPDATE wyteboard.tb_user SET schoolid = @schoolid, firstname = @firstname, lastname = @lastname, password = @password, question = @question, answer = @answer  WHERE email = @email"

        Try
            Using myConnection As New MySqlConnection(connectionString)
                myConnection.Open()
                Dim myCommand As New MySqlCommand(query, myConnection)
                myCommand.Parameters.AddWithValue("@schoolid", txtSchoolID.Text)
                myCommand.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                myCommand.Parameters.AddWithValue("@lastname", txtLastname.Text)
                myCommand.Parameters.AddWithValue("@password", txtPassword.Text)
                myCommand.Parameters.AddWithValue("@question", cbxQuestion.Text)
                myCommand.Parameters.AddWithValue("@answer", txtAnswer.Text)

                myCommand.Parameters.AddWithValue("@email", txtEmail.Text)

                Dim rowsAffected As Integer = myCommand.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    lblInfo.Text = "User Data Updated Successfully."
                Else
                    lblInfo.Text = "Failed to update user data."
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating user data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        txtEmail.BorderColor = Color.Gray
        txtPassword.BorderColor = Color.Gray
        txtConfirmPass.BorderColor = Color.Gray
        txtAnswer.BorderColor = Color.Gray
        txtConfirmAnswer.BorderColor = Color.Gray
        cbxQuestion.BorderColor = Color.Gray
        txtSchoolID.BorderColor = Color.Gray


        ' Highlight unfilled or mismatched controls with a red border
        Dim usernameIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtEmail.Text)
        Dim passwordIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtPassword.Text)
        Dim confirmPasswordIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtConfirmPass.Text)
        Dim answerIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtAnswer.Text)
        Dim confirmAnswerIsEmpty As Boolean = String.IsNullOrWhiteSpace(txtConfirmAnswer.Text)
        Dim questionNotSelected As Boolean = cbxQuestion.SelectedIndex = -1
        Dim passwordsNotMatch As Boolean = txtPassword.Text <> txtConfirmPass.Text
        Dim answersNotMatch As Boolean = txtAnswer.Text <> txtConfirmAnswer.Text
        Dim emailDoesNotEndWithLPULaguna As Boolean = Not txtEmail.Text.EndsWith("@lpulaguna.edu.ph", StringComparison.OrdinalIgnoreCase)

        If usernameIsEmpty OrElse passwordIsEmpty OrElse confirmPasswordIsEmpty OrElse answerIsEmpty OrElse confirmAnswerIsEmpty OrElse questionNotSelected OrElse Not ValidateSchoolID() OrElse passwordsNotMatch OrElse answersNotMatch OrElse emailDoesNotEndWithLPULaguna Then
            lblInfo.Text = "Invalid inputs."
            If usernameIsEmpty Then txtEmail.BorderColor = Color.Red
            If passwordIsEmpty Then txtPassword.BorderColor = Color.Red
            If confirmPasswordIsEmpty Then txtConfirmPass.BorderColor = Color.Red
            If answerIsEmpty Then txtAnswer.BorderColor = Color.Red
            If confirmAnswerIsEmpty Then txtConfirmAnswer.BorderColor = Color.Red
            If questionNotSelected Then cbxQuestion.BorderColor = Color.Red
            If Not ValidateSchoolID() Then txtSchoolID.BorderColor = Color.Red

            If passwordsNotMatch Then
                txtPassword.BorderColor = Color.Red
                txtConfirmPass.BorderColor = Color.Red
                lblInfo.Text = "Passwords do not match."
            End If
            If answersNotMatch Then
                txtAnswer.BorderColor = Color.Red
                txtConfirmAnswer.BorderColor = Color.Red
                lblInfo.Text = "Answers do not match."
            End If
            If emailDoesNotEndWithLPULaguna Then
                txtEmail.BorderColor = Color.Red
                lblInfo.Text = "Please enter a valid email ending with @lpulaguna.edu.ph."
            End If
            Return
        End If

        ' Update user data if all data is filled and validated
        UpdateUserData()
        lblInfo.Text = "User Data Updated Successfully."
    End Sub
    Private Function ValidateSchoolID() As Boolean
        ' Retrieve the school ID from the database for the current user
        Dim storedSchoolID As String = GetStoredSchoolID(Username)

        ' Check if the entered school ID matches the one stored in the database
        If String.Equals(txtSchoolID.Text, storedSchoolID) Then
            ' School ID matches, no validation error
            txtSchoolID.BorderColor = Color.Empty
            Return True
        Else
            ' School ID does not match, display error and return False
            txtSchoolID.BorderColor = Color.Red
            Return False
        End If
    End Function
    Private Function GetStoredSchoolID(email As String) As String
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600"
        Dim query As String = "SELECT schoolid FROM wyteboard.tb_user WHERE email = @email"

        Try
            Using myConnection As New MySqlConnection(connectionString)
                myConnection.Open()
                Dim myCommand As New MySqlCommand(query, myConnection)
                myCommand.Parameters.AddWithValue("@email", email)

                Dim storedSchoolID As String = Convert.ToString(myCommand.ExecuteScalar())
                Return storedSchoolID
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving school ID: " & ex.Message)
            Return String.Empty
        End Try
    End Function
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter
        txtEmail.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs)
        txtPassword.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub

    Private Sub txtConfirmPass_Enter(sender As Object, e As EventArgs)
        txtConfirmPass.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub

    Private Sub txtAnswer_Enter(sender As Object, e As EventArgs) Handles txtAnswer.Enter
        txtAnswer.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub

    Private Sub txtConfirmAnswer_Enter(sender As Object, e As EventArgs) Handles txtConfirmAnswer.Enter
        txtConfirmAnswer.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub

    Private Sub cbxQuestion_Enter(sender As Object, e As EventArgs) Handles cbxQuestion.Enter
        cbxQuestion.BorderColor = Color.Gray ' Set the border color back to normal
        lblInfo.Text = "" ' Clear any previous error message
    End Sub
    Private Sub ToggleVisibility(textBox As Guna2TextBox, imageButton As Guna2ImageButton)
        textBox.UseSystemPasswordChar = Not textBox.UseSystemPasswordChar
        If textBox.UseSystemPasswordChar Then
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Else
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_lock_32__1_
        End If
    End Sub
    Private Sub imgLockConfPass_Click(sender As Object, e As EventArgs) Handles imgLockConfPass.Click
        ToggleVisibility(txtConfirmPass, imgLockConfPass)
    End Sub

    Private Sub imgLockAnswer_Click(sender As Object, e As EventArgs) Handles imgLockAnswer.Click
        ToggleVisibility(txtAnswer, imgLockAnswer)
    End Sub

    Private Sub imgLockConfirmAnswer_Click(sender As Object, e As EventArgs) Handles imgLockConfirmAnswer.Click
        ToggleVisibility(txtConfirmAnswer, imgLockConfirmAnswer)
    End Sub

    Private Sub imgLock_Click(sender As Object, e As EventArgs) Handles imgLock.Click
        ToggleVisibility(txtPassword, imgLock)
    End Sub

End Class