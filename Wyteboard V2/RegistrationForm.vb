Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class RegistrationForm


    Private Sub txtSchoolID_TextChanged(sender As Object, e As EventArgs) Handles txtSchoolID.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtLastname_TextChanged(sender As Object, e As EventArgs) Handles txtLastname.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxType.SelectedIndexChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        ResetFieldBorders()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ResetFieldBorders()
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If AreFieldsEmpty() Then
            lblError.Text = "Please fill in all fields before submitting."
            Return
        End If


        If txtPassword.Text <> txtConfirmPass.Text Then
            lblError.Text = "Passwords do not match."
            txtPassword.BorderColor = Color.Red
            txtConfirmPass.BorderColor = Color.Red
            Return
        End If
        insertLogs()
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Dim LoginForm As New LoginForm()
        LoginForm.Show()
    End Sub

    Sub insertLogs()
        Dim myConnectionx As MySqlConnection = Nothing
        Dim myCommandx As MySqlCommand = Nothing
        Dim timestampValue As String = DateTime.Now.ToString("yyyy-MM-dd")

        Try
            myConnectionx = New MySqlConnection(
                "Database= wyteboard;" &
                "Data Source= localhost;" &
                "User id= admin;" &
                "Password= IamFinal0904;" &
                "Port=3306;Command Timeout=600;")

            myConnectionx.Open()
            Dim query As String = "INSERT INTO wyteboard.tb_users (email, firstname, lastname, password, schoolid, timestamp,  type ) VALUES (@email, @firstname, @lastname, @password, @schoolid, @timestamp, @type)"
            myCommandx = New MySqlCommand(query, myConnectionx)

            myCommandx.Parameters.AddWithValue("@email", txtEmail.Text)
            myCommandx.Parameters.AddWithValue("@firstName", txtFirstname.Text)
            myCommandx.Parameters.AddWithValue("@lastName", txtLastname.Text)
            myCommandx.Parameters.AddWithValue("@passWord", txtPassword.Text)
            myCommandx.Parameters.AddWithValue("@schoolid", txtSchoolID.Text)
            myCommandx.Parameters.AddWithValue("@timestamp", timestampValue)
            myCommandx.Parameters.AddWithValue("@type", cbxType.SelectedItem.ToString())

            myCommandx.ExecuteNonQuery()
            lblError.Text = "Successfully created an account. Please go back to login page."
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                lblError.Text = "Please choose a different email."

            Else
                MsgBox("Error: " & ex.Message)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If myConnectionx IsNot Nothing Then
                myConnectionx.Close()
            End If
        End Try
    End Sub
    Private Sub ToggleVisibility(textBox As Guna2TextBox, imageButton As Guna2ImageButton)
        textBox.UseSystemPasswordChar = Not textBox.UseSystemPasswordChar
        If textBox.UseSystemPasswordChar Then
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_lock_32__1_
        Else
            imageButton.Image = Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        End If
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPass.UseSystemPasswordChar = True
    End Sub

    Private Sub imgLockPass_Click(sender As Object, e As EventArgs) Handles imgLockPass.Click
        ToggleVisibility(txtPassword, imgLockPass)
    End Sub

    Private Sub imgLockConfPass_Click(sender As Object, e As EventArgs) Handles imgLockConfPass.Click
        ToggleVisibility(txtConfirmPass, imgLockConfPass)
    End Sub

    Private Sub lblError_Click(sender As Object, e As EventArgs) Handles lblError.Click

    End Sub
End Class