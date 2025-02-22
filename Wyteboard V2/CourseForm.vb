﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CourseForm
    Inherits Form


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
            Dim query As String = "SELECT schoolid, oe1,oe2,oe3,oe4,oe5,oe6,oe7,oe8,oe9,oe10, pt1,pt2,pt3, prelimexam,midtermexam, finalgrade, subject FROM wyteboard.tb_course WHERE username = @username AND subject = 'IM1'"

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
            dgViewGrade.Columns("midtermexam").HeaderText = "midterm Exam"
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

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LoadDataIntoTabPages(Username)
        ' Call the method to load data into DataGridView
        LoadDataIntoDataGridView(Username)
        lblUser.Text = "Hello " & FirstName & ", Enjoy your day!"
    End Sub
    ' Public Sub LoadDataIntoTabPages(email As String)
    'Dim myConnection As MySqlConnection
    'Dim myCommand As MySqlCommand
    'Dim myAdapter As New MySqlDataAdapter
    'Dim myDataSet As New DataSet

    ' Connection string to your database
    'im connectionString As String = "Database=wyteboard;" &
    ' "Data Source=localhost;" &
    '"User id=admin;" &
    ' "Password=IamFinal0904;" &
    '"Port=3306;Command Timeout=600;"
    '
    'myConnection = New MySqlConnection(connectionString)
    '
    ' Try
    '        myConnection.Open()
    '
    ' Use parameters to prevent SQL injection
    'Dim query As String = "SELECT DISTINCT subject FROM wyteboard.tb_studentsubject WHERE email= @email"
    '
    '   myCommand = New MySqlCommand(query, myConnection)
    '     myCommand.Parameters.AddWithValue("@email", email) ' Use the provided username

    ' Execute the query to retrieve subjects
    'Dim reader As MySqlDataReader = myCommand.ExecuteReader()

    ' Populate tab pages with subjects
    'While reader.Read()
    'Dim subject As String = reader.GetString("subject")
    'Dim tabPage As New TabPage(subject)
    '           cntrlTabCourses.TabPages.Add(tabPage)
    'End While
    '       reader.Close()
    '
    'Catch ex As Exception
    '       MsgBox("Error loading data: " & ex.Message)
    'Finally
    '       myConnection.Close()
    'End Try
    'End Sub
    Private Sub dgViewGrade_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgViewGrade.CellContentClick

    End Sub
End Class
