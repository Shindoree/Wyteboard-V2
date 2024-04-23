Imports MySql.Data.MySqlClient

Public Class EnrollmentForm
    Private connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

    Private Sub EnrollmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentSubjectData()
        LoadUserData()
        LoadHandlerData()
        LoadSubjects() ' Call the method to load subjects into the ComboBox
    End Sub

    Private Sub LoadUserData()
        Dim query As String = "SELECT schoolid, firstname, lastname, email, password, type, timestamp FROM wyteboard.tb_user WHERE type NOT IN ('Professor', 'Admin')"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        dgViewGrade.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStudentSubjectData()
        Dim query As String = "SELECT * FROM wyteboard.tb_studentsubject"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        dgViewSub.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student subject data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadHandlerData()
        Dim query As String = "SELECT * FROM wyteboard.tb_handler"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        dgHandler.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading handler data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSubjects()
        Dim query As String = "SELECT DISTINCT subjects FROM wyteboard.tb_handler"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            cbxSubject.Items.Add(reader("subjects").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subjects: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim email As String = txtEmail.Text
            Dim subject As String = cbxSubject.SelectedItem?.ToString()

            If Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(subject) Then
                Dim query As String = "INSERT INTO wyteboard.tb_studentsubject (email, subject) VALUES (@email, @subject)"

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@email", email)
                        command.Parameters.AddWithValue("@subject", subject)
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Data inserted successfully.")
                            ' You may want to reload the data in the DataGridView dgViewSub after insertion
                            LoadStudentSubjectData()
                        Else
                            MessageBox.Show("No rows were affected.")
                        End If
                    End Using
                End Using
            Else
                MessageBox.Show("Please fill in both email and subject fields.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error inserting data into tb_studentsubject: " & ex.Message)
        End Try
    End Sub


    Private Sub dgHandler_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgHandler.CellContentClick
        ' Handle cell content click event for the handler DataGridView
    End Sub

    Private Sub cbxSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSubject.SelectedIndexChanged
        ' Handle selected index changed event for the ComboBox
    End Sub

    Private Sub txtSchoolID_TextChanged(sender As Object, e As EventArgs)
        ' Handle text changed event for the School ID TextBox
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        ' Handle text changed event for the Email TextBox
    End Sub
End Class
