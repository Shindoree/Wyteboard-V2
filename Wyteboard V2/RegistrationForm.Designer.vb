<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.pnlOverview = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.cmbboxAccountType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.picLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPasswordReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordReg = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtSchoolID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchoolID = New System.Windows.Forms.Label()
        Me.txtEmailReg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEmailReg = New System.Windows.Forms.Label()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCreateAcc = New System.Windows.Forms.Label()
        Me.pnlOverview.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlOverview
        '
        Me.pnlOverview.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlOverview.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.pnlOverview.BorderRadius = 10
        Me.pnlOverview.BorderThickness = 1
        Me.pnlOverview.Controls.Add(Me.Label2)
        Me.pnlOverview.Controls.Add(Me.Label3)
        Me.pnlOverview.Controls.Add(Me.Label4)
        Me.pnlOverview.Controls.Add(Me.Label5)
        Me.pnlOverview.Controls.Add(Me.Label6)
        Me.pnlOverview.Location = New System.Drawing.Point(661, 28)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Size = New System.Drawing.Size(587, 662)
        Me.pnlOverview.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-141, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-141, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "School ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-141, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-141, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-141, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Account Type?"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.lblAccountType)
        Me.Guna2Panel2.Controls.Add(Me.cmbboxAccountType)
        Me.Guna2Panel2.Controls.Add(Me.picLogo)
        Me.Guna2Panel2.Controls.Add(Me.lblConfirmPassword)
        Me.Guna2Panel2.Controls.Add(Me.txtConfirmPassword)
        Me.Guna2Panel2.Controls.Add(Me.txtPasswordReg)
        Me.Guna2Panel2.Controls.Add(Me.lblPasswordReg)
        Me.Guna2Panel2.Controls.Add(Me.txtLastName)
        Me.Guna2Panel2.Controls.Add(Me.lblLastName)
        Me.Guna2Panel2.Controls.Add(Me.txtFirstName)
        Me.Guna2Panel2.Controls.Add(Me.lblFirstName)
        Me.Guna2Panel2.Controls.Add(Me.txtSchoolID)
        Me.Guna2Panel2.Controls.Add(Me.lblSchoolID)
        Me.Guna2Panel2.Controls.Add(Me.txtEmailReg)
        Me.Guna2Panel2.Controls.Add(Me.lblEmailReg)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel2.Controls.Add(Me.lblCreateAcc)
        Me.Guna2Panel2.Location = New System.Drawing.Point(36, 28)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.Size = New System.Drawing.Size(589, 662)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.BackColor = System.Drawing.Color.White
        Me.lblAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAccountType.Location = New System.Drawing.Point(254, 477)
        Me.lblAccountType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(95, 17)
        Me.lblAccountType.TabIndex = 57
        Me.lblAccountType.Text = "Account Type"
        '
        'cmbboxAccountType
        '
        Me.cmbboxAccountType.BackColor = System.Drawing.Color.Transparent
        Me.cmbboxAccountType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.cmbboxAccountType.BorderRadius = 5
        Me.cmbboxAccountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbboxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxAccountType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxAccountType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbboxAccountType.ForeColor = System.Drawing.Color.Black
        Me.cmbboxAccountType.ItemHeight = 30
        Me.cmbboxAccountType.Location = New System.Drawing.Point(220, 502)
        Me.cmbboxAccountType.Name = "cmbboxAccountType"
        Me.cmbboxAccountType.Size = New System.Drawing.Size(166, 36)
        Me.cmbboxAccountType.TabIndex = 56
        '
        'picLogo
        '
        Me.picLogo.FillColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.ImageRotate = 0!
        Me.picLogo.Location = New System.Drawing.Point(47, 39)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(266, 66)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 55
        Me.picLogo.TabStop = False
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.White
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblConfirmPassword.Location = New System.Drawing.Point(314, 388)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(121, 17)
        Me.lblConfirmPassword.TabIndex = 54
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtConfirmPassword.BorderRadius = 5
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(310, 412)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.PlaceholderText = "Juan"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(231, 48)
        Me.txtConfirmPassword.TabIndex = 53
        '
        'txtPasswordReg
        '
        Me.txtPasswordReg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtPasswordReg.BorderRadius = 5
        Me.txtPasswordReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordReg.DefaultText = ""
        Me.txtPasswordReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordReg.ForeColor = System.Drawing.Color.Black
        Me.txtPasswordReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordReg.Location = New System.Drawing.Point(68, 412)
        Me.txtPasswordReg.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPasswordReg.Name = "txtPasswordReg"
        Me.txtPasswordReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPasswordReg.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordReg.PlaceholderText = "Juan"
        Me.txtPasswordReg.SelectedText = ""
        Me.txtPasswordReg.Size = New System.Drawing.Size(231, 48)
        Me.txtPasswordReg.TabIndex = 52
        '
        'lblPasswordReg
        '
        Me.lblPasswordReg.AutoSize = True
        Me.lblPasswordReg.BackColor = System.Drawing.Color.White
        Me.lblPasswordReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordReg.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPasswordReg.Location = New System.Drawing.Point(65, 388)
        Me.lblPasswordReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordReg.Name = "lblPasswordReg"
        Me.lblPasswordReg.Size = New System.Drawing.Size(69, 17)
        Me.lblPasswordReg.TabIndex = 51
        Me.lblPasswordReg.Text = "Password"
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtLastName.BorderRadius = 5
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.Black
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(310, 312)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.PlaceholderText = "Dela Cruz"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(231, 48)
        Me.txtLastName.TabIndex = 50
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.White
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLastName.Location = New System.Drawing.Point(307, 289)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 49
        Me.lblLastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtFirstName.BorderRadius = 5
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Black
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(68, 312)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.PlaceholderText = "Juan"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(231, 48)
        Me.txtFirstName.TabIndex = 48
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.White
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblFirstName.Location = New System.Drawing.Point(65, 288)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lblFirstName.TabIndex = 47
        Me.lblFirstName.Text = "First Name"
        '
        'txtSchoolID
        '
        Me.txtSchoolID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtSchoolID.BorderRadius = 5
        Me.txtSchoolID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolID.DefaultText = ""
        Me.txtSchoolID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchoolID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchoolID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchoolID.ForeColor = System.Drawing.Color.Black
        Me.txtSchoolID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolID.Location = New System.Drawing.Point(352, 219)
        Me.txtSchoolID.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtSchoolID.Name = "txtSchoolID"
        Me.txtSchoolID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.PlaceholderText = "2020-12345"
        Me.txtSchoolID.SelectedText = ""
        Me.txtSchoolID.Size = New System.Drawing.Size(189, 48)
        Me.txtSchoolID.TabIndex = 46
        '
        'lblSchoolID
        '
        Me.lblSchoolID.AutoSize = True
        Me.lblSchoolID.BackColor = System.Drawing.Color.White
        Me.lblSchoolID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchoolID.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblSchoolID.Location = New System.Drawing.Point(349, 195)
        Me.lblSchoolID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSchoolID.Name = "lblSchoolID"
        Me.lblSchoolID.Size = New System.Drawing.Size(68, 17)
        Me.lblSchoolID.TabIndex = 45
        Me.lblSchoolID.Text = "School ID"
        '
        'txtEmailReg
        '
        Me.txtEmailReg.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtEmailReg.BorderRadius = 5
        Me.txtEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailReg.DefaultText = ""
        Me.txtEmailReg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailReg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailReg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailReg.ForeColor = System.Drawing.Color.Black
        Me.txtEmailReg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailReg.Location = New System.Drawing.Point(68, 219)
        Me.txtEmailReg.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtEmailReg.Name = "txtEmailReg"
        Me.txtEmailReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailReg.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailReg.PlaceholderText = "johnsmith@lpulaguna.edu.ph"
        Me.txtEmailReg.SelectedText = ""
        Me.txtEmailReg.Size = New System.Drawing.Size(272, 48)
        Me.txtEmailReg.TabIndex = 44
        '
        'lblEmailReg
        '
        Me.lblEmailReg.AutoSize = True
        Me.lblEmailReg.BackColor = System.Drawing.Color.White
        Me.lblEmailReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailReg.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblEmailReg.Location = New System.Drawing.Point(65, 195)
        Me.lblEmailReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailReg.Name = "lblEmailReg"
        Me.lblEmailReg.Size = New System.Drawing.Size(42, 17)
        Me.lblEmailReg.TabIndex = 43
        Me.lblEmailReg.Text = "Email"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Guna2Button3.BorderRadius = 21
        Me.Guna2Button3.BorderThickness = 1
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.White
        Me.Guna2Button3.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Guna2Button3.Location = New System.Drawing.Point(81, 569)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button3.TabIndex = 42
        Me.Guna2Button3.Text = "Cancel"
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'Guna2Button4
        '
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 21
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(337, 569)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button4.TabIndex = 41
        Me.Guna2Button4.Text = "Sign Up"
        Me.Guna2Button4.UseTransparentBackground = True
        '
        'lblCreateAcc
        '
        Me.lblCreateAcc.AutoSize = True
        Me.lblCreateAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAcc.Location = New System.Drawing.Point(62, 130)
        Me.lblCreateAcc.Name = "lblCreateAcc"
        Me.lblCreateAcc.Size = New System.Drawing.Size(233, 31)
        Me.lblCreateAcc.TabIndex = 40
        Me.lblCreateAcc.Text = "Let's get started!"
        Me.lblCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1280, 715)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.pnlOverview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationForm"
        Me.pnlOverview.ResumeLayout(False)
        Me.pnlOverview.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlOverview As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents cmbboxAccountType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents picLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPasswordReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPasswordReg As Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtSchoolID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchoolID As Label
    Friend WithEvents txtEmailReg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmailReg As Label
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCreateAcc As Label
End Class
