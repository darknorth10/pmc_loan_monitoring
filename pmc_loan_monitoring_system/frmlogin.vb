Public Class frmlogin
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusername.Focus()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'mysql configs
        con.ConnectionString = My.Settings.pmc_dbConnectionString
        cmd.Connection = con

        'open connection
        con.Open()

        cmd.CommandText = "select * from user_table where username = @un and password = @pw"

        Dim a = cmd.Parameters

        a.Clear()
        a.AddWithValue("un", txtusername.Text)
        a.AddWithValue("pw", txtpassword.Text)


        'execute
        cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader()

        'check if user exist and confirm validity
        If txtusername.Text = "" Or txtpassword.Text = "" Then
            MsgBox("All fields are required", vbCritical, "Incorrect Credentials")
        Else
            If dr.HasRows Then
                dr.Read()
                'check if active
                If dr(3) = "active" Then
                    'check user type
                    If dr(4) = "Admin" Then
                        frmmain.Show()
                        frmmain.lblusername.Text = dr(1)
                        Me.Close()

                    Else
                        MsgBox("user is " + dr(4), vbInformation, "information")

                    End If
                Else
                    MsgBox("Account is inactive please contact your administrator", vbCritical, "Error Logging In")
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    txtusername.Focus()
                End If

            Else
                MsgBox("Wrong username or password", vbCritical, "Incorrect Credentials")
                txtusername.Text = ""
                txtpassword.Text = ""
                txtusername.Focus()

            End If
        End If

        'close connection
        con.Close()
    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim res As DialogResult
        res = MsgBox("Do you really want to exit the application?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            System.Windows.Forms.Application.Exit()
        End If
    End Sub
End Class