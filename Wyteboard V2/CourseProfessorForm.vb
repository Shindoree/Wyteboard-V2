Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class CourseProfessorForm
    Public Property Username As String
    Public Property FirstName As String
    Private isLoadingData As Boolean = False

    Private Sub CourseProfessorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form load code here
        LoadDataIntoDataGridView(Username)
        lblUser.Text = "Hello " & FirstName & ", Enjoy your day!"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim schoolID As String = txtSchoolID.Text
        Dim username As String = txtEmail.Text
        Dim subject As String = cbxSubject.SelectedItem.ToString()

        ' Validate inputs
        If String.IsNullOrEmpty(schoolID) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(subject) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Database connection string
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

        ' SQL query to insert data into database
        Dim query As String = "INSERT INTO tb_course (schoolid, username, subject) VALUES (@schoolID, @username, @subject)"

        Try
            ' Open connection to MySQL database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create MySqlCommand
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@schoolID", schoolID)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@subject", subject)

                    ' Execute the command
                    cmd.ExecuteNonQuery()

                    ' Inform user that data has been successfully added
                    MessageBox.Show("New student added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear input fields after successful insertion
                    txtSchoolID.Clear()
                    txtEmail.Clear()
                    cbxSubject.SelectedIndex = -1
                End Using
            End Using

            ' Refresh DataGridView and chart after adding a new user
            LoadDataIntoDataGridView(username)
            UpdateChartData()

        Catch ex As Exception
            ' Display error message if insertion fails
            MessageBox.Show("Error inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadDataIntoDataGridView(username As String)
        Dim myConnection As MySqlConnection
        Dim myCommand As MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myDataSet As New DataSet

        If isLoadingData Then Return ' If already loading data, exit the method to avoid reentrant calls
        isLoadingData = True ' Set the flag to indicate that data loading is in progress
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
            Dim query As String = "SELECT schoolid, oe1,oe2,oe3,oe4,oe5,oe6,oe7,oe8,oe9,oe10, pt1,pt2,pt3, prelimexam,midtermexam, finalgrade, subject FROM wyteboard.tb_course WHERE subject = 'IM1'"

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
            dgViewGrade.Columns("oe1").HeaderText = "OE1"
            dgViewGrade.Columns("oe2").HeaderText = "OE2"
            dgViewGrade.Columns("oe3").HeaderText = "OE3"
            dgViewGrade.Columns("oe4").HeaderText = "OE4"
            dgViewGrade.Columns("oe5").HeaderText = "OE5"
            dgViewGrade.Columns("oe6").HeaderText = "OE6"
            dgViewGrade.Columns("oe7").HeaderText = "OE7"
            dgViewGrade.Columns("oe8").HeaderText = "OE8"
            dgViewGrade.Columns("oe9").HeaderText = "OE9"
            dgViewGrade.Columns("oe10").HeaderText = "OE10"
            dgViewGrade.Columns("pt1").HeaderText = "PT1"
            dgViewGrade.Columns("pt2").HeaderText = "PT2"
            dgViewGrade.Columns("pt3").HeaderText = "PT3"
            dgViewGrade.Columns("prelimexam").HeaderText = "Prelim Exam"
            dgViewGrade.Columns("midtermexam").HeaderText = "Midterm Exam"
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
        ComputeFinalGrade()
        isLoadingData = False
    End Sub

    Public Sub ComputeFinalGrade()
        For Each row As DataGridViewRow In dgViewGrade.Rows
            Dim oeTotal As Double = 0
            Dim ptTotal As Double = 0
            Dim prelimExam As Double = 0
            Dim midtermExam As Double = 0

            Dim oeCount As Integer = 0
            For i As Integer = 1 To 10
                Dim oeCellValue As Object = row.Cells("oe" & i).Value
                If oeCellValue IsNot DBNull.Value AndAlso IsNumeric(oeCellValue) Then
                    oeTotal += CDbl(oeCellValue)
                    oeCount += 1
                End If
            Next

            Dim ptCount As Integer = 0
            For i As Integer = 1 To 3
                Dim ptCellValue As Object = row.Cells("pt" & i).Value
                If ptCellValue IsNot DBNull.Value AndAlso IsNumeric(ptCellValue) Then
                    ptTotal += CDbl(ptCellValue)
                    ptCount += 1
                End If
            Next

            Dim prelimExamCellValue As Object = row.Cells("prelimexam").Value
            If prelimExamCellValue IsNot DBNull.Value AndAlso IsNumeric(prelimExamCellValue) Then
                prelimExam = CDbl(prelimExamCellValue)
            End If

            Dim midtermExamCellValue As Object = row.Cells("midtermexam").Value
            If midtermExamCellValue IsNot DBNull.Value AndAlso IsNumeric(midtermExamCellValue) Then
                midtermExam = CDbl(midtermExamCellValue)
            End If

            Dim oePercent As Double = oeTotal / (oeCount * 100) * 100
            Dim ptPercent As Double = ptTotal / (ptCount * 100) * 100
            Dim prelimPercent As Double = prelimExam
            Dim midtermPercent As Double = midtermExam

            Dim finalGrade As Double = (oePercent * 0.2) + (ptPercent * 0.4) + (prelimPercent * 0.2) + (midtermPercent * 0.2)

            row.Cells("finalgrade").Value = finalGrade.ToString("F2") & "%"
        Next
    End Sub

    Private Sub dgViewGrade_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgViewGrade.CellEndEdit
        ' Get the edited value
        Dim editedValue As Object = dgViewGrade.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        ' Get the corresponding column name
        Dim columnName As String = dgViewGrade.Columns(e.ColumnIndex).Name

        ' Update the value in the database
        UpdateDatabase(editedValue, columnName, e.RowIndex)
    End Sub

    Private Sub UpdateDatabase(value As Object, columnName As String, rowIndex As Integer)
        ' Database connection string
        Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

        ' SQL query to update the value in the database
        Dim query As String = $"UPDATE tb_course SET {columnName} = @value WHERE subject = 'IM1' AND schoolid = @schoolID"

        Try
            ' Open connection to MySQL database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create MySqlCommand
                Using cmd As New MySqlCommand(query, connection)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@value", value)
                    ' Assuming schoolid is a unique identifier for the row
                    cmd.Parameters.AddWithValue("@schoolID", dgViewGrade.Rows(rowIndex).Cells("schoolid").Value)

                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Inform the user that the value has been updated
            MessageBox.Show("Value updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Update the corresponding cell value in the DataGridView
            dgViewGrade.Rows(rowIndex).Cells(columnName).Value = value

            ' Recalculate and update final grades
            ComputeFinalGrade()

            ' Update chart data
            UpdateChartData()
        Catch ex As Exception
            ' Handle exception
            MessageBox.Show("Error updating value: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateChartData()
        ' Clear existing series data
        chartCourse.Series.Clear()

        ' Repopulate the chart with updated data
        For Each column As DataGridViewColumn In dgViewGrade.Columns
            If column.Name <> "schoolid" AndAlso column.Name <> "finalgrade" AndAlso column.Name <> "subject" Then
                Dim series As New Series()
                series.Name = column.Name
                series.ChartType = SeriesChartType.Column

                For Each row As DataGridViewRow In dgViewGrade.Rows
                    If Not row.IsNewRow Then
                        series.Points.AddXY(row.Index + 1, row.Cells(column.Name).Value)
                    End If
                Next

                chartCourse.Series.Add(series)
            End If
        Next
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
End Class
