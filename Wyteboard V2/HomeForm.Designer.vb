<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLogin_Status2 = New System.Windows.Forms.Label()
        Me.lblLogin_Status1 = New System.Windows.Forms.Label()
        Me.lblLogin_Status = New System.Windows.Forms.Label()
        Me.lblLogin_Time2 = New System.Windows.Forms.Label()
        Me.lblLogin_Time1 = New System.Windows.Forms.Label()
        Me.lblLogin_Time = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.pnlHome = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1079, 16)
        Me.Panel1.TabIndex = 14
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Montserrat ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(11, 18)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(223, 51)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "Good Day,"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Location = New System.Drawing.Point(9, 81)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(788, 100)
        Me.Guna2Panel2.TabIndex = 11
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.Controls.Add(Me.Label8)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Location = New System.Drawing.Point(9, 187)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(788, 440)
        Me.Guna2Panel3.TabIndex = 13
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Black
        Me.lblInfo.Location = New System.Drawing.Point(11, 6)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(102, 17)
        Me.lblInfo.TabIndex = 23
        Me.lblInfo.Text = "Login Attempts"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(809, 16)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel1.Size = New System.Drawing.Size(270, 619)
        Me.Guna2Panel1.TabIndex = 12
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.Controls.Add(Me.Label2)
        Me.Guna2Panel4.Controls.Add(Me.Label1)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Status2)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Status1)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Status)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Time2)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Time1)
        Me.Guna2Panel4.Controls.Add(Me.lblLogin_Time)
        Me.Guna2Panel4.Controls.Add(Me.lblInfo)
        Me.Guna2Panel4.Location = New System.Drawing.Point(25, 247)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(233, 364)
        Me.Guna2Panel4.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(119, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Attempts"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Time"
        '
        'lblLogin_Status2
        '
        Me.lblLogin_Status2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Status2.AutoSize = True
        Me.lblLogin_Status2.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Status2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Status2.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Status2.Location = New System.Drawing.Point(119, 107)
        Me.lblLogin_Status2.Name = "lblLogin_Status2"
        Me.lblLogin_Status2.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Status2.TabIndex = 29
        Me.lblLogin_Status2.Text = "Login Attempts"
        '
        'lblLogin_Status1
        '
        Me.lblLogin_Status1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Status1.AutoSize = True
        Me.lblLogin_Status1.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Status1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Status1.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Status1.Location = New System.Drawing.Point(119, 80)
        Me.lblLogin_Status1.Name = "lblLogin_Status1"
        Me.lblLogin_Status1.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Status1.TabIndex = 28
        Me.lblLogin_Status1.Text = "Login Attempts"
        '
        'lblLogin_Status
        '
        Me.lblLogin_Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Status.AutoSize = True
        Me.lblLogin_Status.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Status.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Status.Location = New System.Drawing.Point(119, 52)
        Me.lblLogin_Status.Name = "lblLogin_Status"
        Me.lblLogin_Status.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Status.TabIndex = 27
        Me.lblLogin_Status.Text = "Login Attempts"
        '
        'lblLogin_Time2
        '
        Me.lblLogin_Time2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Time2.AutoSize = True
        Me.lblLogin_Time2.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Time2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Time2.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Time2.Location = New System.Drawing.Point(11, 107)
        Me.lblLogin_Time2.Name = "lblLogin_Time2"
        Me.lblLogin_Time2.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Time2.TabIndex = 26
        Me.lblLogin_Time2.Text = "Login Attempts"
        '
        'lblLogin_Time1
        '
        Me.lblLogin_Time1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Time1.AutoSize = True
        Me.lblLogin_Time1.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Time1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Time1.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Time1.Location = New System.Drawing.Point(11, 80)
        Me.lblLogin_Time1.Name = "lblLogin_Time1"
        Me.lblLogin_Time1.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Time1.TabIndex = 25
        Me.lblLogin_Time1.Text = "Login Attempts"
        '
        'lblLogin_Time
        '
        Me.lblLogin_Time.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLogin_Time.AutoSize = True
        Me.lblLogin_Time.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin_Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin_Time.ForeColor = System.Drawing.Color.Black
        Me.lblLogin_Time.Location = New System.Drawing.Point(11, 52)
        Me.lblLogin_Time.Name = "lblLogin_Time"
        Me.lblLogin_Time.Size = New System.Drawing.Size(102, 17)
        Me.lblLogin_Time.TabIndex = 24
        Me.lblLogin_Time.Text = "Login Attempts"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.Location = New System.Drawing.Point(25, 73)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'pnlHome
        '
        Me.pnlHome.Controls.Add(Me.Guna2Panel1)
        Me.pnlHome.Controls.Add(Me.Guna2Panel3)
        Me.pnlHome.Controls.Add(Me.Guna2Panel2)
        Me.pnlHome.Controls.Add(Me.lblUser)
        Me.pnlHome.Controls.Add(Me.Panel1)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(1079, 635)
        Me.pnlHome.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "About"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(619, 54)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 37)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mission"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(755, 36)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 37)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Vision"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 356)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(694, 72)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'HomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.pnlHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HomeForm"
        Me.Text = "HomeForm"
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.pnlHome.ResumeLayout(False)
        Me.pnlHome.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents pnlHome As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLogin_Time2 As Label
    Friend WithEvents lblLogin_Time1 As Label
    Friend WithEvents lblLogin_Time As Label
    Friend WithEvents lblLogin_Status2 As Label
    Friend WithEvents lblLogin_Status1 As Label
    Friend WithEvents lblLogin_Status As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
