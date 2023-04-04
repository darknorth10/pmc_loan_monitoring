<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrctrldashboard
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
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblmembers = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.Pmc_dbDataSet = New pmc_loan_monitoring_system.pmc_dbDataSet()
        Me.UsertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_tableTableAdapter = New pmc_loan_monitoring_system.pmc_dbDataSetTableAdapters.user_tableTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards5.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.DarkTurquoise
        Me.BunifuCards1.Controls.Add(Me.lblmembers)
        Me.BunifuCards1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuCards1.Controls.Add(Me.PictureBox1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(49, 21)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(269, 129)
        Me.BunifuCards1.TabIndex = 6
        '
        'lblmembers
        '
        Me.lblmembers.AutoSize = True
        Me.lblmembers.BackColor = System.Drawing.Color.White
        Me.lblmembers.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmembers.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmembers.ForeColor = System.Drawing.Color.Black
        Me.lblmembers.Location = New System.Drawing.Point(117, 68)
        Me.lblmembers.Name = "lblmembers"
        Me.lblmembers.Size = New System.Drawing.Size(26, 27)
        Me.lblmembers.TabIndex = 3
        Me.lblmembers.Text = "0"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(99, 23)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(88, 21)
        Me.BunifuCustomLabel1.TabIndex = 2
        Me.BunifuCustomLabel1.Text = "Members"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pmc_loan_monitoring_system.My.Resources.Resources.group
        Me.PictureBox1.Location = New System.Drawing.Point(25, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.White
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = True
        Me.BunifuCards4.color = System.Drawing.Color.Gold
        Me.BunifuCards4.Controls.Add(Me.BunifuCustomLabel6)
        Me.BunifuCards4.Controls.Add(Me.BunifuCustomLabel7)
        Me.BunifuCards4.Controls.Add(Me.PictureBox4)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(922, 21)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = True
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(266, 129)
        Me.BunifuCards4.TabIndex = 3
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel6.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(131, 64)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(26, 27)
        Me.BunifuCustomLabel6.TabIndex = 9
        Me.BunifuCustomLabel6.Text = "0"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel7.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(95, 21)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(97, 20)
        Me.BunifuCustomLabel7.TabIndex = 8
        Me.BunifuCustomLabel7.Text = "Transactions"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.pmc_loan_monitoring_system.My.Resources.Resources.transaction
        Me.PictureBox4.Location = New System.Drawing.Point(4, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(89, 43)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.Tomato
        Me.BunifuCards3.Controls.Add(Me.BunifuCustomLabel4)
        Me.BunifuCards3.Controls.Add(Me.BunifuCustomLabel5)
        Me.BunifuCards3.Controls.Add(Me.PictureBox3)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(633, 21)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(265, 129)
        Me.BunifuCards3.TabIndex = 4
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(130, 63)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(26, 27)
        Me.BunifuCustomLabel4.TabIndex = 9
        Me.BunifuCustomLabel4.Text = "0"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(119, 23)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(45, 21)
        Me.BunifuCustomLabel5.TabIndex = 8
        Me.BunifuCustomLabel5.Text = "Rice"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.pmc_loan_monitoring_system.My.Resources.Resources.wheat
        Me.PictureBox3.Location = New System.Drawing.Point(22, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards2.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuCards2.Controls.Add(Me.BunifuCustomLabel3)
        Me.BunifuCards2.Controls.Add(Me.PictureBox2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(341, 21)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(269, 129)
        Me.BunifuCards2.TabIndex = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(119, 66)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(26, 27)
        Me.BunifuCustomLabel2.TabIndex = 6
        Me.BunifuCustomLabel2.Text = "0"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(86, 23)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(145, 21)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Total Cash Loan"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.pmc_loan_monitoring_system.My.Resources.Resources.loan
        Me.PictureBox2.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.White
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = True
        Me.BunifuCards5.color = System.Drawing.Color.Tomato
        Me.BunifuCards5.Controls.Add(Me.dg1)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(49, 256)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = True
        Me.BunifuCards5.ShadowDepth = 20
        Me.BunifuCards5.Size = New System.Drawing.Size(1139, 417)
        Me.BunifuCards5.TabIndex = 7
        '
        'dg1
        '
        Me.dg1.AutoGenerateColumns = False
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn})
        Me.dg1.DataSource = Me.UsertableBindingSource
        Me.dg1.Location = New System.Drawing.Point(116, 15)
        Me.dg1.Name = "dg1"
        Me.dg1.RowTemplate.Height = 24
        Me.dg1.Size = New System.Drawing.Size(907, 386)
        Me.dg1.TabIndex = 19
        '
        'Pmc_dbDataSet
        '
        Me.Pmc_dbDataSet.DataSetName = "pmc_dbDataSet"
        Me.Pmc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsertableBindingSource
        '
        Me.UsertableBindingSource.DataMember = "user_table"
        Me.UsertableBindingSource.DataSource = Me.Pmc_dbDataSet
        '
        'User_tableTableAdapter
        '
        Me.User_tableTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'usrctrldashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCards5)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.BunifuCards4)
        Me.Controls.Add(Me.BunifuCards3)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Name = "usrctrldashboard"
        Me.Size = New System.Drawing.Size(1228, 754)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards5.ResumeLayout(False)
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblmembers As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsertableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Pmc_dbDataSet As pmc_loan_monitoring_system.pmc_dbDataSet
    Friend WithEvents User_tableTableAdapter As pmc_loan_monitoring_system.pmc_dbDataSetTableAdapters.user_tableTableAdapter

End Class
