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
        Me.imgLockConfPass = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.imgLockPass = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.cbxType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPasswordReg = New System.Windows.Forms.Label()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtSchoolID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblSchoolID = New System.Windows.Forms.Label()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEmailReg = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCreateAcc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'imgLockConfPass
        '
        Me.imgLockConfPass.BackColor = System.Drawing.Color.Transparent
        Me.imgLockConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLockConfPass.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLockConfPass.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLockConfPass.ImageRotate = 0!
        Me.imgLockConfPass.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.Location = New System.Drawing.Point(730, 361)
        Me.imgLockConfPass.Name = "imgLockConfPass"
        Me.imgLockConfPass.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.Size = New System.Drawing.Size(46, 39)
        Me.imgLockConfPass.TabIndex = 60
        Me.imgLockConfPass.UseTransparentBackground = True
        '
        'imgLockPass
        '
        Me.imgLockPass.BackColor = System.Drawing.Color.Transparent
        Me.imgLockPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLockPass.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockPass.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockPass.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLockPass.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLockPass.ImageRotate = 0!
        Me.imgLockPass.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockPass.Location = New System.Drawing.Point(485, 361)
        Me.imgLockPass.Name = "imgLockPass"
        Me.imgLockPass.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockPass.Size = New System.Drawing.Size(46, 39)
        Me.imgLockPass.TabIndex = 59
        Me.imgLockPass.UseTransparentBackground = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.White
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(303, 106)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(12, 17)
        Me.lblError.TabIndex = 58
        Me.lblError.Text = "."
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.BackColor = System.Drawing.Color.White
        Me.lblAccountType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountType.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblAccountType.Location = New System.Drawing.Point(492, 422)
        Me.lblAccountType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(95, 17)
        Me.lblAccountType.TabIndex = 57
        Me.lblAccountType.Text = "Account Type"
        '
        'cbxType
        '
        Me.cbxType.BackColor = System.Drawing.Color.Transparent
        Me.cbxType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.cbxType.BorderRadius = 5
        Me.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxType.ForeColor = System.Drawing.Color.Black
        Me.cbxType.ItemHeight = 30
        Me.cbxType.Items.AddRange(New Object() {"Professor", "Student"})
        Me.cbxType.Location = New System.Drawing.Point(458, 447)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(166, 36)
        Me.cbxType.TabIndex = 56
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.BackColor = System.Drawing.Color.White
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblConfirmPassword.Location = New System.Drawing.Point(552, 333)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(121, 17)
        Me.lblConfirmPassword.TabIndex = 54
        Me.lblConfirmPassword.Text = "Confirm Password"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtConfirmPass.BorderRadius = 5
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Location = New System.Drawing.Point(548, 357)
        Me.txtConfirmPass.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.PlaceholderText = "Juan"
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.Size = New System.Drawing.Size(231, 48)
        Me.txtConfirmPass.TabIndex = 53
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
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(306, 357)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.PlaceholderText = "Juan"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(231, 48)
        Me.txtPassword.TabIndex = 52
        '
        'lblPasswordReg
        '
        Me.lblPasswordReg.AutoSize = True
        Me.lblPasswordReg.BackColor = System.Drawing.Color.White
        Me.lblPasswordReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasswordReg.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblPasswordReg.Location = New System.Drawing.Point(303, 333)
        Me.lblPasswordReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPasswordReg.Name = "lblPasswordReg"
        Me.lblPasswordReg.Size = New System.Drawing.Size(69, 17)
        Me.lblPasswordReg.TabIndex = 51
        Me.lblPasswordReg.Text = "Password"
        '
        'txtLastname
        '
        Me.txtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtLastname.BorderRadius = 5
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.Black
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(548, 257)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.PlaceholderText = "Dela Cruz"
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.Size = New System.Drawing.Size(231, 48)
        Me.txtLastname.TabIndex = 50
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.White
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblLastName.Location = New System.Drawing.Point(545, 234)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(76, 17)
        Me.lblLastName.TabIndex = 49
        Me.lblLastName.Text = "Last Name"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtFirstname.BorderRadius = 5
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.Black
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(306, 257)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.PlaceholderText = "Juan"
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.Size = New System.Drawing.Size(231, 48)
        Me.txtFirstname.TabIndex = 48
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.White
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblFirstName.Location = New System.Drawing.Point(303, 233)
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
        Me.txtSchoolID.Location = New System.Drawing.Point(590, 164)
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
        Me.lblSchoolID.Location = New System.Drawing.Point(587, 140)
        Me.lblSchoolID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSchoolID.Name = "lblSchoolID"
        Me.lblSchoolID.Size = New System.Drawing.Size(68, 17)
        Me.lblSchoolID.TabIndex = 45
        Me.lblSchoolID.Text = "School ID"
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
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(306, 164)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.PlaceholderText = "johnsmith@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(272, 48)
        Me.txtEmail.TabIndex = 44
        '
        'lblEmailReg
        '
        Me.lblEmailReg.AutoSize = True
        Me.lblEmailReg.BackColor = System.Drawing.Color.White
        Me.lblEmailReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailReg.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblEmailReg.Location = New System.Drawing.Point(303, 140)
        Me.lblEmailReg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailReg.Name = "lblEmailReg"
        Me.lblEmailReg.Size = New System.Drawing.Size(42, 17)
        Me.lblEmailReg.TabIndex = 43
        Me.lblEmailReg.Text = "Email"
        '
        'btnBack
        '
        Me.btnBack.AutoRoundedCorners = True
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnBack.BorderRadius = 21
        Me.btnBack.BorderThickness = 1
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.White
        Me.btnBack.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(319, 514)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(180, 45)
        Me.btnBack.TabIndex = 42
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseTransparentBackground = True
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoRoundedCorners = True
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderRadius = 21
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(575, 514)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(180, 45)
        Me.btnUpdate.TabIndex = 41
        Me.btnUpdate.Text = "Sign Up"
        Me.btnUpdate.UseTransparentBackground = True
        '
        'lblCreateAcc
        '
        Me.lblCreateAcc.AutoSize = True
        Me.lblCreateAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAcc.Location = New System.Drawing.Point(300, 75)
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
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.imgLockConfPass)
        Me.Controls.Add(Me.imgLockPass)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblCreateAcc)
        Me.Controls.Add(Me.lblAccountType)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.cbxType)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblEmailReg)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.lblSchoolID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtSchoolID)
        Me.Controls.Add(Me.lblPasswordReg)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblLastName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLockConfPass As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents imgLockPass As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblError As Label
    Friend WithEvents lblAccountType As Label
    Friend WithEvents cbxType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPasswordReg As Label
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtSchoolID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblSchoolID As Label
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmailReg As Label
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCreateAcc As Label
End Class
