﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSlider = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnCourse = New System.Windows.Forms.Button()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlControl = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.pnlSidebarTop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlDisplay = New Guna.UI2.WinForms.Guna2Panel()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenu.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.pnlSidebarTop.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlDisplay.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.White
        Me.pnlMenu.Controls.Add(Me.pnlSidebarTop)
        Me.pnlMenu.Controls.Add(Me.pnlControl)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Enabled = True
        Me.pnlMenu.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.pnlMenu.Size = New System.Drawing.Size(183, 720)
        Me.pnlMenu.TabIndex = 19
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
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel4.Location = New System.Drawing.Point(183, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1097, 69)
        Me.Guna2Panel4.TabIndex = 18
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
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 16)
        Me.Panel1.TabIndex = 14
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
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
        Me.pnlDisplay.TabIndex = 20
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.pnlMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminForm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlControl.ResumeLayout(False)
        Me.pnlSidebarTop.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pnlDisplay.ResumeLayout(False)
        Me.pnlDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSlider As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnCourse As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlControl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlSidebarTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlDisplay As Guna.UI2.WinForms.Guna2Panel
End Class
