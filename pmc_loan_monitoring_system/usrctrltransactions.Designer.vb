<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrctrltransactions
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
        Me.tabctrlLoanTrans = New System.Windows.Forms.TabControl()
        Me.cashloantab = New System.Windows.Forms.TabPage()
        Me.rieloantab = New System.Windows.Forms.TabPage()
        Me.gcloantab = New System.Windows.Forms.TabPage()
        Me.othertab = New System.Windows.Forms.TabPage()
        Me.tabctrlLoanTrans.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrlLoanTrans
        '
        Me.tabctrlLoanTrans.Controls.Add(Me.cashloantab)
        Me.tabctrlLoanTrans.Controls.Add(Me.rieloantab)
        Me.tabctrlLoanTrans.Controls.Add(Me.gcloantab)
        Me.tabctrlLoanTrans.Controls.Add(Me.othertab)
        Me.tabctrlLoanTrans.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabctrlLoanTrans.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tabctrlLoanTrans.ItemSize = New System.Drawing.Size(76, 40)
        Me.tabctrlLoanTrans.Location = New System.Drawing.Point(3, 3)
        Me.tabctrlLoanTrans.Name = "tabctrlLoanTrans"
        Me.tabctrlLoanTrans.Padding = New System.Drawing.Point(40, 3)
        Me.tabctrlLoanTrans.SelectedIndex = 0
        Me.tabctrlLoanTrans.ShowToolTips = True
        Me.tabctrlLoanTrans.Size = New System.Drawing.Size(1222, 748)
        Me.tabctrlLoanTrans.TabIndex = 1
        '
        'cashloantab
        '
        Me.cashloantab.BackColor = System.Drawing.Color.White
        Me.cashloantab.Location = New System.Drawing.Point(4, 44)
        Me.cashloantab.Name = "cashloantab"
        Me.cashloantab.Padding = New System.Windows.Forms.Padding(3)
        Me.cashloantab.Size = New System.Drawing.Size(1214, 700)
        Me.cashloantab.TabIndex = 0
        Me.cashloantab.Text = "Cash Loan"
        '
        'rieloantab
        '
        Me.rieloantab.Location = New System.Drawing.Point(4, 44)
        Me.rieloantab.Name = "rieloantab"
        Me.rieloantab.Padding = New System.Windows.Forms.Padding(3)
        Me.rieloantab.Size = New System.Drawing.Size(1214, 700)
        Me.rieloantab.TabIndex = 1
        Me.rieloantab.Text = "Rice Loan"
        Me.rieloantab.UseVisualStyleBackColor = True
        '
        'gcloantab
        '
        Me.gcloantab.Location = New System.Drawing.Point(4, 44)
        Me.gcloantab.Name = "gcloantab"
        Me.gcloantab.Padding = New System.Windows.Forms.Padding(3)
        Me.gcloantab.Size = New System.Drawing.Size(1214, 700)
        Me.gcloantab.TabIndex = 2
        Me.gcloantab.Text = "Gift Certificate Loan"
        Me.gcloantab.UseVisualStyleBackColor = True
        '
        'othertab
        '
        Me.othertab.Location = New System.Drawing.Point(4, 44)
        Me.othertab.Name = "othertab"
        Me.othertab.Padding = New System.Windows.Forms.Padding(3)
        Me.othertab.Size = New System.Drawing.Size(1214, 700)
        Me.othertab.TabIndex = 3
        Me.othertab.Text = "Other Transactions"
        Me.othertab.UseVisualStyleBackColor = True
        '
        'usrctrltransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabctrlLoanTrans)
        Me.Name = "usrctrltransactions"
        Me.Size = New System.Drawing.Size(1228, 754)
        Me.tabctrlLoanTrans.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabctrlLoanTrans As System.Windows.Forms.TabControl
    Friend WithEvents cashloantab As System.Windows.Forms.TabPage
    Friend WithEvents rieloantab As System.Windows.Forms.TabPage
    Friend WithEvents gcloantab As System.Windows.Forms.TabPage
    Friend WithEvents othertab As System.Windows.Forms.TabPage

End Class
