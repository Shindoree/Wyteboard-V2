Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    Private connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

    Private Sub txtConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub imgLockConfPass_Click(sender As Object, e As EventArgs) Handles imgLockConfPass.Click
        ToggleVisibility(txtConfirmPass, imgLockConfPass)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub imgLock_Click(sender As Object, e As EventArgs) Handles imgLock.Click
        ToggleVisibility(txtPassword, imgLock)
    End Sub

    Private Sub cbxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtLastname_TextChanged(sender As Object, e As EventArgs) Handles txtLastname.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtSchoolID_TextChanged(sender As Object, e As EventArgs) Handles txtSchoolID.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub lblInfo_Click(sender As Object, e As EventArgs) Handles lblInfo.Click
        ' Handle label click event if needed
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If AreFieldsEmpty() Then
            lblInfo.Text = "Please fill in all fields before submitting."
            Return
        End If

        If txtPassword.Text <> txtConfirmPass.Text Then
            lblInfo.Text = "Passwords do not match."
            txtPassword.BorderColor = Color.Red
            txtConfirmPass.BorderColor = Color.Red
            Return
        End If

        InsertLogs()
    End Sub

    Private Function AreFieldsEmpty() As Boolean
        Dim isEmpty As Boolean = False

        If String.IsNullOrEmpty(txtEmail.Text) Then
            txtEmail.BorderColor = Color.Red
            isEmpty = True
        End If

        If String.IsNullOrEmpty(txtSchoolID.Text) Then
            txtSchoolID.BorderColor = Color.Red
            isEmpty = True
        End If

        If String.IsNullOrEmpty(txtFirstname.Text) Then
            txtFirstname.BorderColor = Color.Red
            isEmpty = True
        End If

        If String.IsNullOrEmpty(txtLastname.Text) Then
            txtLastname.BorderColor = Color.Red
            isEmpty = True
        End If

        If cbxType.SelectedIndex = -1 Then
            cbxType.BorderColor = Color.Red
            isEmpty = True
        End If

        If String.IsNullOrEmpty(txtPassword.Text) Then
            txtPassword.BorderColor = Color.Red
            isEmpty = True
        End If

        If String.IsNullOrEmpty(txtConfirmPass.Text) Then
            txtConfirmPass.BorderColor = Color.Red
            isEmpty = True
        End If

        Return isEmpty
    End Function

    Private Sub ResetFieldBorders()
        txtEmail.BorderColor = Color.Empty
        txtSchoolID.BorderColor = Color.Empty
        txtFirstname.BorderColor = Color.Empty
        txtLastname.BorderColor = Color.Empty
        cbxType.BorderColor = Color.Empty
        txtPassword.BorderColor = Color.Empty
        txtConfirmPass.BorderColor = Color.Empty
    End Sub

    Private Sub ToggleVisibility(textBox As Guna2TextBox, imageButton As Guna2ImageButton)
        textBox.UseSystemPasswordChar = Not textBox.UseSystemPasswordChar
        If textBox.UseSystemPasswordChar Then
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_lock_32__1_
        Else
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        End If
    End Sub

    Private Sub InsertLogs()
        Dim timestampValue As String = DateTime.Now.ToString("yyyy-MM-dd")

        Try
            Using myConnectionx As New MySqlConnection(connectionString)
                myConnectionx.Open()
                Dim query As String = "INSERT INTO wyteboard.tb_user (email, firstname, lastname, password, schoolid, timestamp, type ) VALUES (@email, @firstname, @lastname, @password, @schoolid, @timestamp, @type)"
                Using myCommandx As New MySqlCommand(query, myConnectionx)
                    myCommandx.Parameters.AddWithValue("@email", txtEmail.Text)
                    myCommandx.Parameters.AddWithValue("@firstName", txtFirstname.Text)
                    myCommandx.Parameters.AddWithValue("@lastName", txtLastname.Text)
                    myCommandx.Parameters.AddWithValue("@passWord", txtPassword.Text)
                    myCommandx.Parameters.AddWithValue("@schoolid", txtSchoolID.Text)
                    myCommandx.Parameters.AddWithValue("@timestamp", timestampValue)
                    myCommandx.Parameters.AddWithValue("@type", cbxType.SelectedItem.ToString())
                    myCommandx.ExecuteNonQuery()
                End Using
                lblInfo.Text = "Account creation done. Please go back to Login Page."
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                lblInfo.Text = "The provided username or email is already in use. Please choose a different one."
            Else
                MsgBox("Error: " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub
End Class