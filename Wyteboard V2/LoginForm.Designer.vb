﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblEnterCred = New System.Windows.Forms.Label()
        Me.lnklblForgotPassword = New System.Windows.Forms.LinkLabel()
        Me.lblKeepSigned = New System.Windows.Forms.Label()
        Me.tglKeepSigned = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.picLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.picBlue = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnSignIn)
        Me.Guna2Panel1.Controls.Add(Me.lblEnterCred)
        Me.Guna2Panel1.Controls.Add(Me.lnklblForgotPassword)
        Me.Guna2Panel1.Controls.Add(Me.lblKeepSigned)
        Me.Guna2Panel1.Controls.Add(Me.tglKeepSigned)
        Me.Guna2Panel1.Controls.Add(Me.txtPassword)
        Me.Guna2Panel1.Controls.Add(Me.lblPassword)
        Me.Guna2Panel1.Controls.Add(Me.lblSignIn)
        Me.Guna2Panel1.Controls.Add(Me.picLogo)
        Me.Guna2Panel1.Controls.Add(Me.lblEmail)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 11)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(607, 697)
        Me.Guna2Panel1.TabIndex = 13
        '
        'btnSignIn
        '
        Me.btnSignIn.BorderRadius = 10
        Me.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSignIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnSignIn.Font = New System.Drawing.Font("Inter SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.Location = New System.Drawing.Point(126, 548)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(355, 47)
        Me.btnSignIn.TabIndex = 23
        Me.btnSignIn.Text = "Sign In"
        '
        'lblEnterCred
        '
        Me.lblEnterCred.AutoSize = True
        Me.lblEnterCred.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterCred.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblEnterCred.Location = New System.Drawing.Point(189, 279)
        Me.lblEnterCred.Name = "lblEnterCred"
        Me.lblEnterCred.Size = New System.Drawing.Size(228, 17)
        Me.lblEnterCred.TabIndex = 22
        Me.lblEnterCred.Text = "Enter your credentials to continue"
        '
        'lnklblForgotPassword
        '
        Me.lnklblForgotPassword.AutoSize = True
        Me.lnklblForgotPassword.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklblForgotPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lnklblForgotPassword.Location = New System.Drawing.Point(361, 512)
        Me.lnklblForgotPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnklblForgotPassword.Name = "lnklblForgotPassword"
        Me.lnklblForgotPassword.Size = New System.Drawing.Size(120, 16)
        Me.lnklblForgotPassword.TabIndex = 21
        Me.lnklblForgotPassword.TabStop = True
        Me.lnklblForgotPassword.Text = "Forgot Password?"
        '
        'lblKeepSigned
        '
        Me.lblKeepSigned.AutoSize = True
        Me.lblKeepSigned.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeepSigned.Location = New System.Drawing.Point(170, 512)
        Me.lblKeepSigned.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKeepSigned.Name = "lblKeepSigned"
        Me.lblKeepSigned.Size = New System.Drawing.Size(128, 17)
        Me.lblKeepSigned.TabIndex = 20
        Me.lblKeepSigned.Text = "Keep me signed in"
        '
        'tglKeepSigned
        '
        Me.tglKeepSigned.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglKeepSigned.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglKeepSigned.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tglKeepSigned.CheckedState.InnerColor = System.Drawing.Color.White
        Me.tglKeepSigned.Location = New System.Drawing.Point(126, 510)
        Me.tglKeepSigned.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tglKeepSigned.Name = "tglKeepSigned"
        Me.tglKeepSigned.Size = New System.Drawing.Size(40, 21)
        Me.tglKeepSigned.TabIndex = 19
        Me.tglKeepSigned.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tglKeepSigned.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.tglKeepSigned.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tglKeepSigned.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(125, 445)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.PlaceholderText = "*****"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(356, 48)
        Me.txtPassword.TabIndex = 18
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPassword.Location = New System.Drawing.Point(122, 421)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(72, 17)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Font = New System.Drawing.Font("Inter SemiBold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.Location = New System.Drawing.Point(252, 236)
        Me.lblSignIn.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(103, 33)
        Me.lblSignIn.TabIndex = 16
        Me.lblSignIn.Text = "Sign In"
        '
        'picLogo
        '
        Me.picLogo.FillColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.ImageRotate = 0!
        Me.picLogo.Location = New System.Drawing.Point(102, 55)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(368, 91)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 15
        Me.picLogo.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblEmail.Location = New System.Drawing.Point(122, 328)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Inter", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(126, 352)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.PlaceholderText = "johnsmith@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(355, 48)
        Me.txtEmail.TabIndex = 13
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.lblWelcome)
        Me.Guna2Panel2.Controls.Add(Me.picBlue)
        Me.Guna2Panel2.Location = New System.Drawing.Point(635, 11)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(633, 697)
        Me.Guna2Panel2.TabIndex = 14
        '
        'picBlue
        '
        Me.picBlue.BorderRadius = 20
        Me.picBlue.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.picBlue.ImageRotate = 0!
        Me.picBlue.Location = New System.Drawing.Point(74, 55)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(556, 639)
        Me.picBlue.TabIndex = 0
        Me.picBlue.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(92, 186)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(593, 48)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Your All-in-One Gradebook and"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(131, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Performance Tracker"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(64, 201)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel3.Size = New System.Drawing.Size(479, 461)
        Me.Guna2Panel3.TabIndex = 24
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblEnterCred As Label
    Friend WithEvents lnklblForgotPassword As LinkLabel
    Friend WithEvents lblKeepSigned As Label
    Friend WithEvents tglKeepSigned As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblSignIn As Label
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picBlue As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
