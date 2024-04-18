<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cntrlTabCourses = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgViewGrade = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chartCourse = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.cntrlTabCourses.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgViewGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.cntrlTabCourses)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 177)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(759, 446)
        Me.Guna2Panel1.TabIndex = 0
        '
        'cntrlTabCourses
        '
        Me.cntrlTabCourses.Controls.Add(Me.TabPage1)
        Me.cntrlTabCourses.Controls.Add(Me.TabPage2)
        Me.cntrlTabCourses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cntrlTabCourses.ItemSize = New System.Drawing.Size(180, 40)
        Me.cntrlTabCourses.Location = New System.Drawing.Point(0, 0)
        Me.cntrlTabCourses.Name = "cntrlTabCourses"
        Me.cntrlTabCourses.SelectedIndex = 0
        Me.cntrlTabCourses.Size = New System.Drawing.Size(759, 446)
        Me.cntrlTabCourses.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.cntrlTabCourses.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cntrlTabCourses.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.cntrlTabCourses.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.cntrlTabCourses.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cntrlTabCourses.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.cntrlTabCourses.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.cntrlTabCourses.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.cntrlTabCourses.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.cntrlTabCourses.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.cntrlTabCourses.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.cntrlTabCourses.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.cntrlTabCourses.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.cntrlTabCourses.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.cntrlTabCourses.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cntrlTabCourses.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.cntrlTabCourses.TabIndex = 0
        Me.cntrlTabCourses.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.cntrlTabCourses.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgViewGrade)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(751, 398)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgViewGrade
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgViewGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgViewGrade.ColumnHeadersHeight = 20
        Me.dgViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgViewGrade.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgViewGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgViewGrade.Enabled = False
        Me.dgViewGrade.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.Location = New System.Drawing.Point(3, 3)
        Me.dgViewGrade.Name = "dgViewGrade"
        Me.dgViewGrade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgViewGrade.RowHeadersVisible = False
        Me.dgViewGrade.Size = New System.Drawing.Size(745, 392)
        Me.dgViewGrade.TabIndex = 0
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgViewGrade.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgViewGrade.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgViewGrade.ThemeStyle.HeaderStyle.Height = 20
        Me.dgViewGrade.ThemeStyle.ReadOnly = False
        Me.dgViewGrade.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgViewGrade.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgViewGrade.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.RowsStyle.Height = 22
        Me.dgViewGrade.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1041, 436)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chartCourse
        '
        Me.chartCourse.BackColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.chartCourse.ChartAreas.Add(ChartArea4)
        Me.chartCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.chartCourse.Enabled = False
        Legend4.Name = "Legend1"
        Me.chartCourse.Legends.Add(Legend4)
        Me.chartCourse.Location = New System.Drawing.Point(0, 0)
        Me.chartCourse.Name = "chartCourse"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.chartCourse.Series.Add(Series4)
        Me.chartCourse.Size = New System.Drawing.Size(306, 293)
        Me.chartCourse.TabIndex = 1
        Me.chartCourse.Text = "Chart1"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.Controls.Add(Me.chartCourse)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel2.Location = New System.Drawing.Point(773, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(306, 635)
        Me.Guna2Panel2.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Montserrat ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(3, 9)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(223, 51)
        Me.lblUser.TabIndex = 11
        Me.lblUser.Text = "Good Day,"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CourseForm"
        Me.Text = "CourseForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.cntrlTabCourses.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgViewGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cntrlTabCourses As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgViewGrade As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chartCourse As DataVisualization.Charting.Chart
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUser As Label
End Class
