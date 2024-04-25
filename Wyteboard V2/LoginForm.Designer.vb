<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lnkForgetpassword = New System.Windows.Forms.LinkLabel()
        Me.lblKeepSigned = New System.Windows.Forms.Label()
        Me.tglKeepSigned = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picBlue = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblError = New System.Windows.Forms.Label()
        Me.imgLock = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.picLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Inter SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(94, 523)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(532, 72)
        Me.btnLogin.TabIndex = 6
        Me.btnLogin.Text = "Sign In"
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.White
        Me.lblInfo.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfo.Location = New System.Drawing.Point(284, 429)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(332, 24)
        Me.lblInfo.TabIndex = 22
        Me.lblInfo.Text = "Enter your credentials to continue"
        '
        'lnkForgetpassword
        '
        Me.lnkForgetpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkForgetpassword.AutoSize = True
        Me.lnkForgetpassword.BackColor = System.Drawing.Color.White
        Me.lnkForgetpassword.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkForgetpassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lnkForgetpassword.Location = New System.Drawing.Point(447, 465)
        Me.lnkForgetpassword.Name = "lnkForgetpassword"
        Me.lnkForgetpassword.Size = New System.Drawing.Size(178, 24)
        Me.lnkForgetpassword.TabIndex = 5
        Me.lnkForgetpassword.TabStop = True
        Me.lnkForgetpassword.Text = "Forgot Password?"
        '
        'lblKeepSigned
        '
        Me.lblKeepSigned.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblKeepSigned.AutoSize = True
        Me.lblKeepSigned.BackColor = System.Drawing.Color.White
        Me.lblKeepSigned.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeepSigned.Location = New System.Drawing.Point(160, 468)
        Me.lblKeepSigned.Name = "lblKeepSigned"
        Me.lblKeepSigned.Size = New System.Drawing.Size(185, 24)
        Me.lblKeepSigned.TabIndex = 20
        Me.lblKeepSigned.Text = "Keep me signed in"
        '
        'tglKeepSigned
        '
        Me.tglKeepSigned.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tglKeepSigned.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglKeepSigned.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tglKeepSigned.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.tglKeepSigned.CheckedState.InnerColor = System.Drawing.Color.White
        Me.tglKeepSigned.Location = New System.Drawing.Point(94, 465)
        Me.tglKeepSigned.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tglKeepSigned.Name = "tglKeepSigned"
        Me.tglKeepSigned.Size = New System.Drawing.Size(60, 32)
        Me.tglKeepSigned.TabIndex = 4
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
        Me.txtPassword.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(93, 365)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.PlaceholderText = ""
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(534, 74)
        Me.txtPassword.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.lblWelcome)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.picBlue)
        Me.Guna2Panel2.Location = New System.Drawing.Point(952, 18)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(950, 1072)
        Me.Guna2Panel2.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(430, 240)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 61)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "and"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(165, 178)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(641, 61)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Your All-in-One Gradebook"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(219, 297)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 61)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Performance Tracker"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Wyteboard_V2.My.Resources.Resources.Aesthetic_Minimal_Laptop_On_Table_Mockup_Instagram_Post__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(90, 382)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(770, 637)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'picBlue
        '
        Me.picBlue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picBlue.BorderRadius = 20
        Me.picBlue.FillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.picBlue.ImageRotate = 0!
        Me.picBlue.Location = New System.Drawing.Point(57, 49)
        Me.picBlue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picBlue.Name = "picBlue"
        Me.picBlue.Size = New System.Drawing.Size(834, 983)
        Me.picBlue.TabIndex = 0
        Me.picBlue.TabStop = False
        '
        'lblPassword
        '
        Me.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPassword.Location = New System.Drawing.Point(183, 638)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(101, 24)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Password"
        '
        'lblEmail
        '
        Me.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.White
        Me.lblEmail.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEmail.Location = New System.Drawing.Point(183, 505)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(60, 24)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.DimGray
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(189, 542)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(9, 11, 9, 11)
        Me.txtEmail.MaxLength = 45
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.PlaceholderText = "johnsmith@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(532, 74)
        Me.txtEmail.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.Controls.Add(Me.btnLogin)
        Me.Guna2Panel3.Controls.Add(Me.lnkForgetpassword)
        Me.Guna2Panel3.Controls.Add(Me.lblKeepSigned)
        Me.Guna2Panel3.Controls.Add(Me.lblError)
        Me.Guna2Panel3.Controls.Add(Me.tglKeepSigned)
        Me.Guna2Panel3.Controls.Add(Me.imgLock)
        Me.Guna2Panel3.Controls.Add(Me.txtPassword)
        Me.Guna2Panel3.Location = New System.Drawing.Point(96, 309)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel3.Size = New System.Drawing.Size(718, 709)
        Me.Guna2Panel3.TabIndex = 24
        '
        'lblError
        '
        Me.lblError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(93, 160)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 24)
        Me.lblError.TabIndex = 23
        '
        'imgLock
        '
        Me.imgLock.BackColor = System.Drawing.Color.Transparent
        Me.imgLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLock.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLock.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLock.ImageRotate = 0!
        Me.imgLock.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.Location = New System.Drawing.Point(550, 371)
        Me.imgLock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.Size = New System.Drawing.Size(69, 60)
        Me.imgLock.TabIndex = 3
        Me.imgLock.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.Controls.Add(Me.lblInfo)
        Me.Guna2Panel1.Controls.Add(Me.lblPassword)
        Me.Guna2Panel1.Controls.Add(Me.lblSignIn)
        Me.Guna2Panel1.Controls.Add(Me.picLogo)
        Me.Guna2Panel1.Controls.Add(Me.lblEmail)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel1.Location = New System.Drawing.Point(18, 18)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(910, 1072)
        Me.Guna2Panel1.TabIndex = 15
        '
        'lblSignIn
        '
        Me.lblSignIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.White
        Me.lblSignIn.Font = New System.Drawing.Font("Inter SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.Location = New System.Drawing.Point(378, 363)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(157, 50)
        Me.lblSignIn.TabIndex = 16
        Me.lblSignIn.Text = "Sign In"
        '
        'picLogo
        '
        Me.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picLogo.FillColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.ImageRotate = 0!
        Me.picLogo.Location = New System.Drawing.Point(178, 115)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(552, 140)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 15
        Me.picLogo.TabStop = False
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
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(1920, 1108)
        Me.Guna2Panel4.TabIndex = 17
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1920, 1108)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picBlue As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents lnkForgetpassword As LinkLabel
    Friend WithEvents lblKeepSigned As Label
    Friend WithEvents tglKeepSigned As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblSignIn As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents imgLock As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblError As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
