<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.txtAnswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxQuestion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtConfirmAnswer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxType = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSchoolID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.imgLock = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.imgLockConfirmAnswer = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.imgLockAnswer = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.imgLockConfPass = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAnswer.BackColor = System.Drawing.Color.Transparent
        Me.txtAnswer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtAnswer.BorderRadius = 5
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer.DefaultText = ""
        Me.txtAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer.Font = New System.Drawing.Font("Montserrat", 8.249999!)
        Me.txtAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAnswer.Location = New System.Drawing.Point(517, 328)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAnswer.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAnswer.PlaceholderText = "Calamba"
        Me.txtAnswer.SelectedText = ""
        Me.txtAnswer.ShadowDecoration.BorderRadius = 2
        Me.txtAnswer.Size = New System.Drawing.Size(236, 36)
        Me.txtAnswer.TabIndex = 49
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmPass.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtConfirmPass.BorderRadius = 5
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Location = New System.Drawing.Point(517, 210)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.PlaceholderText = ""
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.ShadowDecoration.BorderRadius = 2
        Me.txtConfirmPass.Size = New System.Drawing.Size(236, 36)
        Me.txtConfirmPass.TabIndex = 48
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btnUpdate.Location = New System.Drawing.Point(361, 461)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(180, 45)
        Me.btnUpdate.TabIndex = 46
        Me.btnUpdate.Text = "Enter"
        Me.btnUpdate.UseTransparentBackground = True
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(603, 423)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 15)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Confirm Answer"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(603, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Answer"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(515, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 15)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Security Questions"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(603, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Confirm Password"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(603, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Password"
        '
        'cbxQuestion
        '
        Me.cbxQuestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxQuestion.BackColor = System.Drawing.Color.Transparent
        Me.cbxQuestion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cbxQuestion.BorderRadius = 5
        Me.cbxQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQuestion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxQuestion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxQuestion.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.cbxQuestion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxQuestion.ItemHeight = 30
        Me.cbxQuestion.Items.AddRange(New Object() {"What was the name of your first pet?", "In what city were you born?"})
        Me.cbxQuestion.Location = New System.Drawing.Point(518, 269)
        Me.cbxQuestion.Name = "cbxQuestion"
        Me.cbxQuestion.Size = New System.Drawing.Size(236, 36)
        Me.cbxQuestion.TabIndex = 40
        '
        'txtConfirmAnswer
        '
        Me.txtConfirmAnswer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirmAnswer.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmAnswer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtConfirmAnswer.BorderRadius = 5
        Me.txtConfirmAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmAnswer.DefaultText = ""
        Me.txtConfirmAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmAnswer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmAnswer.Location = New System.Drawing.Point(517, 387)
        Me.txtConfirmAnswer.Name = "txtConfirmAnswer"
        Me.txtConfirmAnswer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmAnswer.PlaceholderText = ""
        Me.txtConfirmAnswer.SelectedText = ""
        Me.txtConfirmAnswer.ShadowDecoration.BorderRadius = 2
        Me.txtConfirmAnswer.Size = New System.Drawing.Size(236, 36)
        Me.txtConfirmAnswer.TabIndex = 39
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Montserrat", 8.249999!)
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(517, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.PlaceholderText = "Include special characters"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.BorderRadius = 2
        Me.txtPassword.Size = New System.Drawing.Size(236, 36)
        Me.txtPassword.TabIndex = 38
        '
        'cbxType
        '
        Me.cbxType.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbxType.BackColor = System.Drawing.Color.Transparent
        Me.cbxType.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cbxType.BorderRadius = 5
        Me.cbxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxType.Enabled = False
        Me.cbxType.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxType.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.cbxType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxType.ItemHeight = 30
        Me.cbxType.Items.AddRange(New Object() {"Professor", "Student"})
        Me.cbxType.Location = New System.Drawing.Point(152, 387)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(236, 36)
        Me.cbxType.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(149, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Account Type?"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(149, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "School ID"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(339, 66)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Edit Account"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFirstname
        '
        Me.txtFirstname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtFirstname.BorderRadius = 5
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.DefaultText = ""
        Me.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(152, 269)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstname.PlaceholderText = "Stephen"
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.ShadowDecoration.BorderRadius = 2
        Me.txtFirstname.Size = New System.Drawing.Size(236, 36)
        Me.txtFirstname.TabIndex = 30
        '
        'txtLastname
        '
        Me.txtLastname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLastname.BackColor = System.Drawing.Color.Transparent
        Me.txtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtLastname.BorderRadius = 5
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.DefaultText = ""
        Me.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(152, 328)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastname.PlaceholderText = "Maano"
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.ShadowDecoration.BorderRadius = 2
        Me.txtLastname.Size = New System.Drawing.Size(236, 36)
        Me.txtLastname.TabIndex = 29
        '
        'txtSchoolID
        '
        Me.txtSchoolID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSchoolID.BackColor = System.Drawing.Color.Transparent
        Me.txtSchoolID.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtSchoolID.BorderRadius = 5
        Me.txtSchoolID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSchoolID.DefaultText = ""
        Me.txtSchoolID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSchoolID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSchoolID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.Enabled = False
        Me.txtSchoolID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolID.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.txtSchoolID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSchoolID.Location = New System.Drawing.Point(152, 210)
        Me.txtSchoolID.Name = "txtSchoolID"
        Me.txtSchoolID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSchoolID.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSchoolID.PlaceholderText = "2022-12345"
        Me.txtSchoolID.SelectedText = ""
        Me.txtSchoolID.ShadowDecoration.BorderRadius = 2
        Me.txtSchoolID.Size = New System.Drawing.Size(236, 36)
        Me.txtSchoolID.TabIndex = 28
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Montserrat", 8.999999!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(152, 155)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.PlaceholderText = "Example@lpulaguna.edu.ph"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.BorderRadius = 2
        Me.txtEmail.Size = New System.Drawing.Size(236, 36)
        Me.txtEmail.TabIndex = 27
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(332, 509)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(239, 17)
        Me.lblInfo.TabIndex = 54
        Me.lblInfo.Text = "Please make 2 Factor Authentication"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2Panel1.Controls.Add(Me.lblInfo)
        Me.Guna2Panel1.Controls.Add(Me.imgLock)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel1.Controls.Add(Me.imgLockConfirmAnswer)
        Me.Guna2Panel1.Controls.Add(Me.txtPassword)
        Me.Guna2Panel1.Controls.Add(Me.imgLockAnswer)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.imgLockConfPass)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txtConfirmPass)
        Me.Guna2Panel1.Controls.Add(Me.txtAnswer)
        Me.Guna2Panel1.Controls.Add(Me.cbxQuestion)
        Me.Guna2Panel1.Controls.Add(Me.txtConfirmAnswer)
        Me.Guna2Panel1.Controls.Add(Me.cbxType)
        Me.Guna2Panel1.Controls.Add(Me.txtSchoolID)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.txtLastname)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.txtFirstname)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(88, 52)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(903, 542)
        Me.Guna2Panel1.TabIndex = 55
        '
        'imgLock
        '
        Me.imgLock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLock.BackColor = System.Drawing.Color.Transparent
        Me.imgLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLock.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLock.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLock.ImageRotate = 0!
        Me.imgLock.ImageSize = New System.Drawing.Size(28, 28)
        Me.imgLock.Location = New System.Drawing.Point(712, 157)
        Me.imgLock.Name = "imgLock"
        Me.imgLock.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLock.Size = New System.Drawing.Size(37, 33)
        Me.imgLock.TabIndex = 50
        Me.imgLock.UseTransparentBackground = True
        '
        'imgLockConfirmAnswer
        '
        Me.imgLockConfirmAnswer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLockConfirmAnswer.BackColor = System.Drawing.Color.Transparent
        Me.imgLockConfirmAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLockConfirmAnswer.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfirmAnswer.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfirmAnswer.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLockConfirmAnswer.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLockConfirmAnswer.ImageRotate = 0!
        Me.imgLockConfirmAnswer.ImageSize = New System.Drawing.Size(28, 28)
        Me.imgLockConfirmAnswer.Location = New System.Drawing.Point(712, 389)
        Me.imgLockConfirmAnswer.Name = "imgLockConfirmAnswer"
        Me.imgLockConfirmAnswer.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfirmAnswer.Size = New System.Drawing.Size(37, 31)
        Me.imgLockConfirmAnswer.TabIndex = 53
        Me.imgLockConfirmAnswer.UseTransparentBackground = True
        '
        'imgLockAnswer
        '
        Me.imgLockAnswer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLockAnswer.BackColor = System.Drawing.Color.Transparent
        Me.imgLockAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLockAnswer.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockAnswer.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockAnswer.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLockAnswer.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLockAnswer.ImageRotate = 0!
        Me.imgLockAnswer.ImageSize = New System.Drawing.Size(28, 28)
        Me.imgLockAnswer.Location = New System.Drawing.Point(712, 330)
        Me.imgLockAnswer.Name = "imgLockAnswer"
        Me.imgLockAnswer.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockAnswer.Size = New System.Drawing.Size(37, 33)
        Me.imgLockAnswer.TabIndex = 52
        Me.imgLockAnswer.UseTransparentBackground = True
        '
        'imgLockConfPass
        '
        Me.imgLockConfPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.imgLockConfPass.BackColor = System.Drawing.Color.Transparent
        Me.imgLockConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLockConfPass.CheckedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.HoverState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.Image = Global.Wyteboard_V2.My.Resources.Resources.icons8_unlocked_32__1_
        Me.imgLockConfPass.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgLockConfPass.ImageRotate = 0!
        Me.imgLockConfPass.ImageSize = New System.Drawing.Size(28, 28)
        Me.imgLockConfPass.Location = New System.Drawing.Point(712, 212)
        Me.imgLockConfPass.Name = "imgLockConfPass"
        Me.imgLockConfPass.PressedState.ImageSize = New System.Drawing.Size(32, 33)
        Me.imgLockConfPass.Size = New System.Drawing.Size(37, 33)
        Me.imgLockConfPass.TabIndex = 51
        Me.imgLockConfPass.UseTransparentBackground = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 635)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Account"
        Me.Text = "Account"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAnswer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxQuestion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtConfirmAnswer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxType As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSchoolID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents imgLock As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents imgLockConfPass As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents imgLockAnswer As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents imgLockConfirmAnswer As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents lblInfo As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
