Public Class frmmain

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dock dashboard as initial usercontrol to main panel
        pnlmain.Controls.Clear()
        lbltext.Text = "Dashboard"

        Dim D As New usrctrldashboard()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim res As DialogResult
        res = MsgBox("Do you really want to exit the application?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        'dock dashboard as initial usercontrol to main panel
        pnlmain.Controls.Clear()
        lbltext.Text = "Dashboard"

        Dim D As New usrctrldashboard()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'dock user management usercontrol to main panel
        pnlmain.Controls.Clear()

        lbltext.Text = "User Management"
        Dim D As New usrctrlusermanagement()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnlogout_Click_1(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim res As DialogResult
        Dim LoginForm As New frmlogin

        res = MsgBox("Are you sure you want to logout?", vbYesNo, "System Notification")

        If res = DialogResult.Yes Then

            LoginForm.Show()
            Me.Close()


        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        'dock loan transaction usercontrol to main panel
        pnlmain.Controls.Clear()

        lbltext.Text = "Loan Transactions - Cash Loan"
        Dim D As New usrctrltransactions()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub
End Class
