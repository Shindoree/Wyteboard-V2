Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CourseForm
    Public Property FirstName As String
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
            Dim query As String = "SELECT schoolid, oe1, pt1, prelimexam, finalgrade, subject FROM wyteboard.tb_course1 WHERE username = @username"

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
            dgViewGrade.Columns("oe1").HeaderText = "Outcome Evaluation"
            dgViewGrade.Columns("pt1").HeaderText = "Performance Task"
            dgViewGrade.Columns("prelimexam").HeaderText = "Exam"
            dgViewGrade.Columns("finalgrade").HeaderText = "Final Grade"
            dgViewGrade.Columns("subject").HeaderText = "Subject"

            ' Populate the chart with data of oe, pt, and exam
            If myDataSet.Tables("myData").Rows.Count > 0 Then
                chartCourse.Series.Clear()
                For Each column As DataColumn In myDataSet.Tables("myData").Columns
                    If column.ColumnName <> "schoolid" AndAlso column.ColumnName <> "finalgrade" AndAlso column.ColumnName <> "subject" Then
                        Dim series As New Series()
                        series.Name = column.ColumnName
                        series.ChartType = SeriesChartType.Column
                        For i As Integer = 0 To myDataSet.Tables("myData").Rows.Count - 1
                            series.Points.AddXY(i + 1, myDataSet.Tables("myData").Rows(i)(column.ColumnName))
                        Next
                        chartCourse.Series.Add(series)
                    End If
                Next

                ' Set TabPage1 text to the subject from the first row
                TabPage1.Text = myDataSet.Tables("myData").Rows(0)("subject").ToString()
            End If

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            myConnection.Close()
        End Try
    End Sub

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to load data into DataGridView
        LoadDataIntoDataGridView(Username)
        lblUser.Text = "Hello " & FirstName & ", Enjoy your day!"
    End Sub

    Private Sub dgViewGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgViewGrade.CellContentClick

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub cntrlTabCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cntrlTabCourses.SelectedIndexChanged

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub chartCourse_Click(sender As Object, e As EventArgs) Handles chartCourse.Click

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class
