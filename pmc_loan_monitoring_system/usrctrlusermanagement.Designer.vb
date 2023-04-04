<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrctrlusermanagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbostatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbout = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconfirmpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtregpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtreguser = New System.Windows.Forms.TextBox()
        Me.btnclearuser = New Guna.UI2.WinForms.Guna2Button()
        Me.btnupdateuser = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnchangepass = New Guna.UI2.WinForms.Guna2Button()
        Me.btn2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnadduser = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtln = New System.Windows.Forms.TextBox()
        Me.btnchange = New Guna.UI2.WinForms.Guna2Button()
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.dgusers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pmc_dbDataSet = New pmc_loan_monitoring_system.pmc_dbDataSet()
        Me.User_tableTableAdapter = New pmc_loan_monitoring_system.pmc_dbDataSetTableAdapters.user_tableTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label5.Location = New System.Drawing.Point(905, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Status"
        '
        'cbostatus
        '
        Me.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbostatus.Enabled = False
        Me.cbostatus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbostatus.FormattingEnabled = True
        Me.cbostatus.Items.AddRange(New Object() {"", "active", "inactive"})
        Me.cbostatus.Location = New System.Drawing.Point(987, 296)
        Me.cbostatus.Name = "cbostatus"
        Me.cbostatus.Size = New System.Drawing.Size(179, 28)
        Me.cbostatus.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label4.Location = New System.Drawing.Point(877, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "User Type"
        '
        'cbout
        '
        Me.cbout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbout.Enabled = False
        Me.cbout.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbout.FormattingEnabled = True
        Me.cbout.Items.AddRange(New Object() {"", "Admin", "Loan Officer", "Secretary", "Manager"})
        Me.cbout.Location = New System.Drawing.Point(987, 236)
        Me.cbout.Name = "cbout"
        Me.cbout.Size = New System.Drawing.Size(179, 28)
        Me.cbout.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label3.Location = New System.Drawing.Point(391, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Re-enter Password"
        '
        'txtconfirmpass
        '
        Me.txtconfirmpass.Enabled = False
        Me.txtconfirmpass.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtconfirmpass.Location = New System.Drawing.Point(574, 353)
        Me.txtconfirmpass.Name = "txtconfirmpass"
        Me.txtconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpass.Size = New System.Drawing.Size(214, 28)
        Me.txtconfirmpass.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label2.Location = New System.Drawing.Point(467, 294)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'txtregpass
        '
        Me.txtregpass.Enabled = False
        Me.txtregpass.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtregpass.Location = New System.Drawing.Point(574, 294)
        Me.txtregpass.Name = "txtregpass"
        Me.txtregpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtregpass.Size = New System.Drawing.Size(214, 28)
        Me.txtregpass.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label1.Location = New System.Drawing.Point(467, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username"
        '
        'txtreguser
        '
        Me.txtreguser.Enabled = False
        Me.txtreguser.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtreguser.Location = New System.Drawing.Point(574, 236)
        Me.txtreguser.Name = "txtreguser"
        Me.txtreguser.Size = New System.Drawing.Size(214, 28)
        Me.txtreguser.TabIndex = 3
        '
        'btnclearuser
        '
        Me.btnclearuser.BackColor = System.Drawing.Color.Transparent
        Me.btnclearuser.BorderRadius = 20
        Me.btnclearuser.CheckedState.Parent = Me.btnclearuser
        Me.btnclearuser.CustomImages.Parent = Me.btnclearuser
        Me.btnclearuser.Enabled = False
        Me.btnclearuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclearuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnclearuser.ForeColor = System.Drawing.Color.White
        Me.btnclearuser.HoverState.Parent = Me.btnclearuser
        Me.btnclearuser.Location = New System.Drawing.Point(924, 87)
        Me.btnclearuser.Name = "btnclearuser"
        Me.btnclearuser.PressedColor = System.Drawing.Color.DimGray
        Me.btnclearuser.ShadowDecoration.Parent = Me.btnclearuser
        Me.btnclearuser.Size = New System.Drawing.Size(168, 52)
        Me.btnclearuser.TabIndex = 2
        Me.btnclearuser.Text = "Clear"
        '
        'btnupdateuser
        '
        Me.btnupdateuser.BackColor = System.Drawing.Color.Transparent
        Me.btnupdateuser.BorderRadius = 20
        Me.btnupdateuser.CheckedState.Parent = Me.btnupdateuser
        Me.btnupdateuser.CustomImages.Parent = Me.btnupdateuser
        Me.btnupdateuser.Enabled = False
        Me.btnupdateuser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnupdateuser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnupdateuser.ForeColor = System.Drawing.Color.White
        Me.btnupdateuser.HoverState.Parent = Me.btnupdateuser
        Me.btnupdateuser.Location = New System.Drawing.Point(503, 87)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.PressedColor = System.Drawing.Color.DimGray
        Me.btnupdateuser.ShadowDecoration.Parent = Me.btnupdateuser
        Me.btnupdateuser.Size = New System.Drawing.Size(168, 52)
        Me.btnupdateuser.TabIndex = 1
        Me.btnupdateuser.Text = "Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox1.Controls.Add(Me.btnchangepass)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnclearuser)
        Me.GroupBox1.Controls.Add(Me.btnupdateuser)
        Me.GroupBox1.Controls.Add(Me.btnadduser)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(30, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(1169, 162)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "    Action Bar    "
        '
        'btnchangepass
        '
        Me.btnchangepass.BackColor = System.Drawing.Color.Transparent
        Me.btnchangepass.BorderRadius = 20
        Me.btnchangepass.CheckedState.Parent = Me.btnchangepass
        Me.btnchangepass.CustomImages.Parent = Me.btnchangepass
        Me.btnchangepass.Enabled = False
        Me.btnchangepass.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnchangepass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnchangepass.ForeColor = System.Drawing.Color.White
        Me.btnchangepass.HoverState.Parent = Me.btnchangepass
        Me.btnchangepass.Location = New System.Drawing.Point(717, 87)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.PressedColor = System.Drawing.Color.DimGray
        Me.btnchangepass.ShadowDecoration.Parent = Me.btnchangepass
        Me.btnchangepass.Size = New System.Drawing.Size(168, 52)
        Me.btnchangepass.TabIndex = 10
        Me.btnchangepass.Text = "Change Password"
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Transparent
        Me.btn2.BorderRadius = 20
        Me.btn2.CheckedState.Parent = Me.btn2
        Me.btn2.CustomImages.Parent = Me.btn2
        Me.btn2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.HoverState.Parent = Me.btn2
        Me.btn2.Location = New System.Drawing.Point(72, 87)
        Me.btn2.Name = "btn2"
        Me.btn2.PressedColor = System.Drawing.Color.DimGray
        Me.btn2.ShadowDecoration.Parent = Me.btn2
        Me.btn2.Size = New System.Drawing.Size(168, 52)
        Me.btn2.TabIndex = 9
        Me.btn2.Text = "Add User"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.Guna2TextBox1.BorderRadius = 20
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.IconLeft = Global.pmc_loan_monitoring_system.My.Resources.Resources.search_interface_symbol
        Me.Guna2TextBox1.IconLeftOffset = New System.Drawing.Point(50, 0)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(182, 32)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Search"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(818, 45)
        Me.Guna2TextBox1.TabIndex = 0
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnadduser
        '
        Me.btnadduser.BackColor = System.Drawing.Color.Transparent
        Me.btnadduser.BorderRadius = 20
        Me.btnadduser.CheckedState.Parent = Me.btnadduser
        Me.btnadduser.CustomImages.Parent = Me.btnadduser
        Me.btnadduser.Enabled = False
        Me.btnadduser.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnadduser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnadduser.ForeColor = System.Drawing.Color.White
        Me.btnadduser.HoverState.Parent = Me.btnadduser
        Me.btnadduser.Location = New System.Drawing.Point(286, 87)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.PressedColor = System.Drawing.Color.DimGray
        Me.btnadduser.ShadowDecoration.Parent = Me.btnadduser
        Me.btnadduser.Size = New System.Drawing.Size(168, 52)
        Me.btnadduser.TabIndex = 8
        Me.btnadduser.Text = "Save User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label6.Location = New System.Drawing.Point(32, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "First name"
        '
        'txtfn
        '
        Me.txtfn.Enabled = False
        Me.txtfn.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtfn.Location = New System.Drawing.Point(139, 236)
        Me.txtfn.Name = "txtfn"
        Me.txtfn.Size = New System.Drawing.Size(214, 28)
        Me.txtfn.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.Label7.Location = New System.Drawing.Point(32, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 21)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Last name"
        '
        'txtln
        '
        Me.txtln.Enabled = False
        Me.txtln.Font = New System.Drawing.Font("Century Gothic", 9.8!)
        Me.txtln.Location = New System.Drawing.Point(139, 295)
        Me.txtln.Name = "txtln"
        Me.txtln.Size = New System.Drawing.Size(214, 28)
        Me.txtln.TabIndex = 2
        '
        'btnchange
        '
        Me.btnchange.BorderRadius = 5
        Me.btnchange.CheckedState.Parent = Me.btnchange
        Me.btnchange.CustomImages.Parent = Me.btnchange
        Me.btnchange.Enabled = False
        Me.btnchange.FillColor = System.Drawing.Color.Gray
        Me.btnchange.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchange.ForeColor = System.Drawing.Color.White
        Me.btnchange.HoverState.Parent = Me.btnchange
        Me.btnchange.Location = New System.Drawing.Point(794, 299)
        Me.btnchange.Name = "btnchange"
        Me.btnchange.ShadowDecoration.Parent = Me.btnchange
        Me.btnchange.Size = New System.Drawing.Size(75, 25)
        Me.btnchange.TabIndex = 31
        Me.btnchange.Text = "Change"
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Location = New System.Drawing.Point(79, 353)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(51, 17)
        Me.lbluserid.TabIndex = 30
        Me.lbluserid.Text = "Label8"
        Me.lbluserid.Visible = False
        '
        'dgusers
        '
        Me.dgusers.AllowUserToAddRows = False
        Me.dgusers.AllowUserToDeleteRows = False
        Me.dgusers.AllowUserToResizeColumns = False
        Me.dgusers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgusers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgusers.AutoGenerateColumns = False
        Me.dgusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgusers.BackgroundColor = System.Drawing.Color.White
        Me.dgusers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgusers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgusers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgusers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgusers.ColumnHeadersHeight = 46
        Me.dgusers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgusers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.dgusers.DataSource = Me.UsertableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgusers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgusers.EnableHeadersVisualStyles = False
        Me.dgusers.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgusers.Location = New System.Drawing.Point(30, 402)
        Me.dgusers.MultiSelect = False
        Me.dgusers.Name = "dgusers"
        Me.dgusers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgusers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgusers.RowHeadersVisible = False
        Me.dgusers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgusers.RowTemplate.Height = 24
        Me.dgusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgusers.Size = New System.Drawing.Size(1169, 332)
        Me.dgusers.TabIndex = 32
        Me.dgusers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgusers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dgusers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgusers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgusers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgusers.ThemeStyle.HeaderStyle.Height = 46
        Me.dgusers.ThemeStyle.ReadOnly = True
        Me.dgusers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgusers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgusers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgusers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.RowsStyle.Height = 24
        Me.dgusers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.dgusers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertableBindingSource
        '
        Me.UsertableBindingSource.DataMember = "user_table"
        Me.UsertableBindingSource.DataSource = Me.Pmc_dbDataSet
        '
        'Pmc_dbDataSet
        '
        Me.Pmc_dbDataSet.DataSetName = "pmc_dbDataSet"
        Me.Pmc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_tableTableAdapter
        '
        Me.User_tableTableAdapter.ClearBeforeFill = True
        '
        'usrctrlusermanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.Controls.Add(Me.dgusers)
        Me.Controls.Add(Me.btnchange)
        Me.Controls.Add(Me.lbluserid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtfn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbostatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfirmpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtregpass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtreguser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "usrctrlusermanagement"
        Me.Size = New System.Drawing.Size(1228, 754)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbostatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbout As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtregpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtreguser As System.Windows.Forms.TextBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnclearuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnupdateuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnadduser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtfn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtln As System.Windows.Forms.TextBox
    Friend WithEvents btn2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnchangepass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnchange As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbluserid As System.Windows.Forms.Label
    Friend WithEvents dgusers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents UsertableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pmc_dbDataSet As pmc_loan_monitoring_system.pmc_dbDataSet
    Friend WithEvents User_tableTableAdapter As pmc_loan_monitoring_system.pmc_dbDataSetTableAdapters.user_tableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
