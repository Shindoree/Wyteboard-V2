<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cntrlTabCourses = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.chartCourse = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgViewGrade = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblNote2 = New System.Windows.Forms.Label()
        Me.lblNote1 = New System.Windows.Forms.Label()
        Me.btnDeleteTask = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddNew = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNewPT = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNewOE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.cntrlTabCourses.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.chartCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgViewGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.cntrlTabCourses)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1079, 474)
        Me.Guna2Panel1.TabIndex = 64
        '
        'cntrlTabCourses
        '
        Me.cntrlTabCourses.Controls.Add(Me.TabPage1)
        Me.cntrlTabCourses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cntrlTabCourses.ItemSize = New System.Drawing.Size(180, 40)
        Me.cntrlTabCourses.Location = New System.Drawing.Point(0, 0)
        Me.cntrlTabCourses.Name = "cntrlTabCourses"
        Me.cntrlTabCourses.SelectedIndex = 0
        Me.cntrlTabCourses.Size = New System.Drawing.Size(1079, 474)
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
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.chartCourse)
        Me.TabPage1.Controls.Add(Me.dgViewGrade)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1071, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'chartCourse
        '
        Me.chartCourse.BackColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chartCourse.ChartAreas.Add(ChartArea2)
        Me.chartCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartCourse.Enabled = False
        Legend2.Name = "Legend1"
        Me.chartCourse.Legends.Add(Legend2)
        Me.chartCourse.Location = New System.Drawing.Point(3, 321)
        Me.chartCourse.Name = "chartCourse"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartCourse.Series.Add(Series2)
        Me.chartCourse.Size = New System.Drawing.Size(1065, 102)
        Me.chartCourse.TabIndex = 1
        Me.chartCourse.Text = "Chart1"
        '
        'dgViewGrade
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgViewGrade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgViewGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgViewGrade.ColumnHeadersHeight = 40
        Me.dgViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgViewGrade.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgViewGrade.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgViewGrade.GridColor = System.Drawing.Color.White
        Me.dgViewGrade.Location = New System.Drawing.Point(3, 3)
        Me.dgViewGrade.Name = "dgViewGrade"
        Me.dgViewGrade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgViewGrade.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgViewGrade.RowHeadersVisible = False
        Me.dgViewGrade.RowHeadersWidth = 20
        Me.dgViewGrade.Size = New System.Drawing.Size(1065, 318)
        Me.dgViewGrade.TabIndex = 0
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgViewGrade.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgViewGrade.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgViewGrade.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgViewGrade.ThemeStyle.HeaderStyle.Height = 40
        Me.dgViewGrade.ThemeStyle.ReadOnly = False
        Me.dgViewGrade.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgViewGrade.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgViewGrade.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgViewGrade.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.RowsStyle.Height = 22
        Me.dgViewGrade.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgViewGrade.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.lblNote2)
        Me.Guna2Panel3.Controls.Add(Me.lblNote1)
        Me.Guna2Panel3.Controls.Add(Me.btnDeleteTask)
        Me.Guna2Panel3.Controls.Add(Me.btnAddNew)
        Me.Guna2Panel3.Controls.Add(Me.txtNewPT)
        Me.Guna2Panel3.Controls.Add(Me.txtNewOE)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.lblUser)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1079, 161)
        Me.Guna2Panel3.TabIndex = 65
        '
        'lblNote2
        '
        Me.lblNote2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNote2.AutoSize = True
        Me.lblNote2.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote2.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNote2.Location = New System.Drawing.Point(762, 115)
        Me.lblNote2.Name = "lblNote2"
        Me.lblNote2.Size = New System.Drawing.Size(281, 16)
        Me.lblNote2.TabIndex = 76
        Me.lblNote2.Text = "*PT and OE are types, becareful of deletion"
        '
        'lblNote1
        '
        Me.lblNote1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNote1.AutoSize = True
        Me.lblNote1.BackColor = System.Drawing.SystemColors.Control
        Me.lblNote1.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblNote1.Location = New System.Drawing.Point(762, 92)
        Me.lblNote1.Name = "lblNote1"
        Me.lblNote1.Size = New System.Drawing.Size(259, 16)
        Me.lblNote1.TabIndex = 75
        Me.lblNote1.Text = "*Note that OE name should be numbers"
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteTask.AutoRoundedCorners = True
        Me.btnDeleteTask.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteTask.BorderRadius = 18
        Me.btnDeleteTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeleteTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeleteTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeleteTask.FillColor = System.Drawing.Color.Red
        Me.btnDeleteTask.Font = New System.Drawing.Font("Inter SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTask.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTask.Location = New System.Drawing.Point(576, 92)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(180, 38)
        Me.btnDeleteTask.TabIndex = 74
        Me.btnDeleteTask.Text = "Delete Task"
        Me.btnDeleteTask.UseTransparentBackground = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddNew.AutoRoundedCorners = True
        Me.btnAddNew.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNew.BorderRadius = 17
        Me.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddNew.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnAddNew.Font = New System.Drawing.Font("Inter SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(390, 93)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(180, 37)
        Me.btnAddNew.TabIndex = 73
        Me.btnAddNew.Text = "Add Task"
        Me.btnAddNew.UseTransparentBackground = True
        '
        'txtNewPT
        '
        Me.txtNewPT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNewPT.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtNewPT.BorderRadius = 5
        Me.txtNewPT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPT.DefaultText = ""
        Me.txtNewPT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPT.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPT.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPT.ForeColor = System.Drawing.Color.DimGray
        Me.txtNewPT.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPT.Location = New System.Drawing.Point(200, 92)
        Me.txtNewPT.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtNewPT.Name = "txtNewPT"
        Me.txtNewPT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPT.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPT.PlaceholderText = "New PT name"
        Me.txtNewPT.SelectedText = ""
        Me.txtNewPT.Size = New System.Drawing.Size(181, 39)
        Me.txtNewPT.TabIndex = 72
        '
        'txtNewOE
        '
        Me.txtNewOE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNewOE.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtNewOE.BorderRadius = 5
        Me.txtNewOE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewOE.DefaultText = ""
        Me.txtNewOE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewOE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewOE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewOE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewOE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewOE.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewOE.ForeColor = System.Drawing.Color.DimGray
        Me.txtNewOE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewOE.Location = New System.Drawing.Point(12, 92)
        Me.txtNewOE.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtNewOE.Name = "txtNewOE"
        Me.txtNewOE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewOE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewOE.PlaceholderText = "New OE name"
        Me.txtNewOE.SelectedText = ""
        Me.txtNewOE.Size = New System.Drawing.Size(181, 39)
        Me.txtNewOE.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Add a new assessment"
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Inter SemiBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(3, 14)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(204, 45)
        Me.lblUser.TabIndex = 14
        Me.lblUser.Text = "Good Day,"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.cntrlTabCourses.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.chartCourse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgViewGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cntrlTabCourses As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents chartCourse As DataVisualization.Charting.Chart
    Friend WithEvents dgViewGrade As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents lblNote2 As Label
    Friend WithEvents lblNote1 As Label
    Friend WithEvents btnDeleteTask As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAddNew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNewPT As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNewOE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
