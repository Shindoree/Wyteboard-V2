Imports MySql.Data.MySqlClient
Public Class CourseForm
    Public Property Username As String
    Public Sub LoadDataIntoDataGridView(username As String)
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet

        ' Connection string to your database
        Dim connectionString As String = "Database=wyteboard;" &
            "Data Source=localhost;" &
            "User id=admin;" &
            "Password=IamFinal0904;" &
            "Port=3306;Command Timeout=600;"

        myConnection = New MySqlConnection(connectionString)

        Try
            myConnection.Open()

            ' Use parameters to prevent SQL injection
            Dim query As String = "SELECT schoolid, oe, pt, exam, finalgrade FROM wyteboard.tb_course1 WHERE username = @username"

            myCommand = New MySqlCommand(query, myConnection)
            myCommand.Parameters.AddWithValue("@username", username) ' Use the provided username

            myAdapter.SelectCommand = myCommand
            myAdapter.Fill(myDataSet, "myData")

            ' Set the DataSource of the DataGridView
            dgViewGrade.DataSource = myDataSet.Tables("myData")

            ' Set AutoGenerateColumns to True to display column headers
            dgViewGrade.AutoGenerateColumns = True

            ' Set the HeaderText for each column
            dgViewGrade.Columns("schoolid").HeaderText = "School ID"
            dgViewGrade.Columns("oe").HeaderText = "Outcome Evaluation"
            dgViewGrade.Columns("pt").HeaderText = "Performance Task"
            dgViewGrade.Columns("exam").HeaderText = "Exam"
            dgViewGrade.Columns("finalgrade").HeaderText = "Final Grade"

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            myConnection.Close()
        End Try
    End Sub
End Class