Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports MySql.Data.MySqlClient.X.XDevAPI.Common

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
        Dim subject As String = If(cbxSubject.SelectedItem IsNot Nothing, cbxSubject.SelectedItem.ToString(), "")

        ' Validate inputs
        If String.IsNullOrEmpty(schoolID) OrElse String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(subject) Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check if the email and school ID exist in tb_user
        If Not UserExists(username, schoolID) Then
            MessageBox.Show("User with the provided email and school ID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

    Private Function AddNewColumn(columnName As String, columnType As String) As Boolean
        Try
            ' Database connection string
            Dim connectionString As String = "Database=wyteboard;Data Source=localhost;User id=admin;Password=IamFinal0904;Port=3306;Command Timeout=600;"

            ' Determine the last column index of the specified type (OE or PT)
            Dim lastColumnIndex As Integer = -1
            For Each column As DataGridViewColumn In dgViewGrade.Columns
                If column.Name.StartsWith(columnType) Then
                    Dim index As Integer = dgViewGrade.Columns.IndexOf(column)
                    If index > lastColumnIndex Then
                        lastColumnIndex = index
                    End If
                End If
            Next

            ' Construct the ALTER TABLE query to add the new column after the last column of its type
            Dim query As String
            If lastColumnIndex >= 0 Then
                query = $"ALTER TABLE tb_course ADD COLUMN {columnType}{columnName} VARCHAR(45) AFTER {dgViewGrade.Columns(lastColumnIndex).Name}"
            Else
                ' If no columns of the specified type exist, add the new column as the first column
                query = $"ALTER TABLE tb_course ADD COLUMN {columnType}{columnName} VARCHAR(45) FIRST"
            End If

            ' Open connection to MySQL database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Create MySqlCommand
                Using cmd As New MySqlCommand(query, connection)
                    ' Execute the command
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Inform the user that the column has been added
            MessageBox.Show($"New {columnType.ToUpper()} column '{columnName}' added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh the entire form to update the DataGridView with the latest data
            ClearAndReloadDataGridView()

            Return True
        Catch ex As Exception
            ' Handle exception
            MessageBox.Show($"Error adding new {columnType.ToUpper()} column: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function UserExists(username As String, schoolID As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tb_user WHERE email = @username AND schoolID = @schoolID"
        Dim connectionString As String = "Your_Connection_String_Here"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@schoolID", schoolID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking user existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

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

            ' Generate the SELECT statement to get the subjects handled by the professor
            Dim subjectsQuery As String = $"SELECT subjects FROM tb_handler WHERE email = @username"

            myCommand = New MySqlCommand(subjectsQuery, myConnection)
            myCommand.Parameters.AddWithValue("@username", username)

            ' Execute the query to get the subjects
            Dim subjects As String = ""

            Using reader As MySqlDataReader = myCommand.ExecuteReader()
                If reader.Read() Then
                    subjects = reader.GetString("subjects")
                End If
            End Using

            ' Split the subjects string into individual subjects
            Dim subjectArray As String() = subjects.Split(","c)

            ' Generate the IN clause for the SQL query
            Dim subjectList As String = String.Join(",", subjectArray.Select(Function(s) $"'{s}'"))

            ' Generate the SELECT statement to retrieve data for the professor's subjects
            Dim query As String = $"SELECT * FROM wyteboard.tb_course WHERE subject IN ({subjectList}) ORDER BY fullname ASC"

            myCommand = New MySqlCommand(query, myConnection)

            ' Fill the DataSet with the schema and data from the database
            myAdapter.SelectCommand = myCommand
            myAdapter.FillSchema(myDataSet, SchemaType.Source, "myData")
            myAdapter.Fill(myDataSet, "myData")

            ' Set the DataSource of the DataGridView
            dgViewGrade.DataSource = myDataSet.Tables("myData")

            ' Refresh the DataGridView to display the newly added columns and update column headers
            dgViewGrade.Refresh()

            ' Compute final grade after loading data
            ComputeFinalGrade()

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        Finally
            myConnection.Close()
        End Try

        UpdateChartData()
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

            ' Include newly created columns in the computation
            For Each column As DataGridViewColumn In dgViewGrade.Columns
                If column.Name.StartsWith("oe") AndAlso column.Index > 10 Then
                    Dim oeCellValue As Object = row.Cells(column.Index).Value
                    If oeCellValue IsNot DBNull.Value AndAlso IsNumeric(oeCellValue) Then
                        oeTotal += CDbl(oeCellValue)
                        oeCount += 1
                    End If
                ElseIf column.Name.StartsWith("pt") AndAlso column.Index > 3 Then
                    Dim ptCellValue As Object = row.Cells(column.Index).Value
                    If ptCellValue IsNot DBNull.Value AndAlso IsNumeric(ptCellValue) Then
                        ptTotal += CDbl(ptCellValue)
                        ptCount += 1
                    End If
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

    Private Sub dgViewGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgViewGrade.CellContentClick

    End Sub
    Private Sub ClearAndReloadDataGridView()
        ' Clear existing data from DataGridView
        dgViewGrade.DataSource = Nothing
        dgViewGrade.Rows.Clear()
        dgViewGrade.Columns.Clear()

        ' Reload data into DataGridView
        LoadDataIntoDataGridView(Username)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ' Add new OE column if the txtNewOE TextBox is not empty
        If Not String.IsNullOrEmpty(txtNewOE.Text.Trim()) Then
            Dim newOEColumnName As String = txtNewOE.Text.Trim()

            ' Add the new OE column to the database
            If AddNewColumn(newOEColumnName, "oe") Then
                ' Refresh the DataGridView and chart
                LoadDataIntoDataGridView(Username)
                UpdateChartData() ' Update chart data after adding new columns
            End If
        End If

        ' Check if the new PT field is not empty
        If Not String.IsNullOrEmpty(txtNewPT.Text.Trim()) Then
            Dim newPTColumnName As String = txtNewPT.Text.Trim()

            ' Add the new PT column to the database
            If AddNewColumn(newPTColumnName, "pt") Then
                ' Refresh the DataGridView and chart
                LoadDataIntoDataGridView(Username)
                UpdateChartData() ' Update chart data after adding new columns
            End If
        End If
    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub
End Class
