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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1079, 635)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 0
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Guna2DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(891, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(184, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(312, 292)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(885, 621)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'CourseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CourseForm"
        Me.Text = "CourseForm"
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
End Class
