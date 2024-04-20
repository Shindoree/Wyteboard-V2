<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlSidebarTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSlider = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlDisplay = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLogin_Status2 = New System.Windows.Forms.Label()
        Me.lblLogin_Status1 = New System.Windows.Forms.Label()
        Me.lblLogin_Status = New System.Windows.Forms.Label()
        Me.lblLogin_Time2 = New System.Windows.Forms.Label()
        Me.lblLogin_Time1 = New System.Windows.Forms.Label()
        Me.lblLogin_Time = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pnlMenu.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlSidebarTop.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplay.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.White
        Me.pnlMenu.Controls.Add(Me.pnlControl)
        Me.pnlMenu.Controls.Add(Me.pnlSidebarTop)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Enabled = True
        Me.pnlMenu.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.pnlMenu.Size = New System.Drawing.Size(183, 720)
        Me.pnlMenu.TabIndex = 0
        '
        'pnlControl
        '
        Me.pnlControl.Controls.Add(Me.btnLogout)
        Me.pnlControl.Controls.Add(Me.btnSummary)
        Me.pnlControl.Controls.Add(Me.btnCourse)
        Me.pnlControl.Controls.Add(Me.btnAccount)
        Me.pnlControl.Controls.Add(Me.btnHome)
        Me.pnlControl.Location = New System.Drawing.Point(0, 73)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(183, 647)
        Me.pnlControl.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnLogout.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_logout_32
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 574)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(183, 73)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSummary
        '
        Me.btnSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSummary.FlatAppearance.BorderSize = 0
        Me.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSummary.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSummary.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_summary_32
        Me.btnSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSummary.Location = New System.Drawing.Point(0, 219)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(183, 73)
        Me.btnSummary.TabIndex = 16
        Me.btnSummary.Text = "Summary"
        Me.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'btnCourse
        '
        Me.btnCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCourse.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCourse.FlatAppearance.BorderSize = 0
        Me.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourse.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourse.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCourse.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_course_32__1_
        Me.btnCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourse.Location = New System.Drawing.Point(0, 146)
        Me.btnCourse.Name = "btnCourse"
        Me.btnCourse.Size = New System.Drawing.Size(183, 73)
        Me.btnCourse.TabIndex = 15
        Me.btnCourse.Text = "Courses"
        Me.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCourse.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.Silver
        Me.btnAccount.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_account_32__1_
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(0, 73)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(183, 73)
        Me.btnAccount.TabIndex = 14
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnHome.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_home_32
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(183, 73)
        Me.btnHome.TabIndex = 18
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'pnlSidebarTop
        '
        Me.pnlSidebarTop.Controls.Add(Me.btnSlider)
        Me.pnlSidebarTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebarTop.Name = "pnlSidebarTop"
        Me.pnlSidebarTop.Size = New System.Drawing.Size(183, 73)
        Me.pnlSidebarTop.TabIndex = 0
        '
        'btnSlider
        '
        Me.btnSlider.BackColor = System.Drawing.Color.Transparent
        Me.btnSlider.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSlider.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSlider.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSlider.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSlider.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSlider.FillColor = System.Drawing.Color.Transparent
        Me.btnSlider.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSlider.ForeColor = System.Drawing.Color.White
        Me.btnSlider.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_menu_50
        Me.btnSlider.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSlider.Location = New System.Drawing.Point(118, 0)
        Me.btnSlider.Name = "btnSlider"
        Me.btnSlider.Size = New System.Drawing.Size(65, 73)
        Me.btnSlider.TabIndex = 1
        Me.btnSlider.UseTransparentBackground = True
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(183, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1097, 69)
        Me.Guna2Panel4.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = Global.Wyteboard_V2.My.Resources.Resources.Wyteboard_Logo_01
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1097, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 12
        Me.Guna2PictureBox1.TabStop = False
        '
        'pnlDisplay
        '
        Me.pnlDisplay.Controls.Add(Me.Guna2Panel1)
        Me.pnlDisplay.Controls.Add(Me.Guna2Panel3)
        Me.pnlDisplay.Controls.Add(Me.Guna2Panel2)
        Me.pnlDisplay.Controls.Add(Me.lblUser)
        Me.pnlDisplay.Controls.Add(Me.Panel1)
        Me.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay.Location = New System.Drawing.Point(183, 69)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(1097, 651)
        Me.pnlDisplay.TabIndex = 14
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Guna2Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel1.Location = New System.Drawing.Point(827, 16)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel1.Size = New System.Drawing.Size(270, 635)
        Me.Guna2Panel1.TabIndex = 12
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.Location = New System.Drawing.Point(25, 73)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(18, 195)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(788, 440)
        Me.Guna2Panel3.TabIndex = 13
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 10
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Location = New System.Drawing.Point(18, 89)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(788, 100)
        Me.Guna2Panel2.TabIndex = 11
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Montserrat ExtraBold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(20, 26)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(223, 51)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "Good Day,"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 16)
        Me.Panel1.TabIndex = 14
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel5.BackColor = System.Drawing.Color.White
        Me.Guna2Panel5.Controls.Add(Me.Label2)
        Me.Guna2Panel5.Controls.Add(Me.Label1)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Status2)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Status1)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Status)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Time2)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Time1)
        Me.Guna2Panel5.Controls.Add(Me.lblLogin_Time)
        Me.Guna2Panel5.Controls.Add(Me.lblInfo)
        Me.Guna2Panel5.Location = New System.Drawing.Point(25, 247)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(233, 364)
        Me.Guna2Panel5.TabIndex = 26
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
        'StudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentForm"
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlSidebarTop.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplay.ResumeLayout(False)
        Me.pnlDisplay.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlSidebarTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnSlider As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlDisplay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLogin_Status2 As Label
    Friend WithEvents lblLogin_Status1 As Label
    Friend WithEvents lblLogin_Status As Label
    Friend WithEvents lblLogin_Time2 As Label
    Friend WithEvents lblLogin_Time1 As Label
    Friend WithEvents lblLogin_Time As Label
    Friend WithEvents lblInfo As Label
End Class
