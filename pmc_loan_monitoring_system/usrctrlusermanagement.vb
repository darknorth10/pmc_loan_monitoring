Public Class usrctrlusermanagement
    'refresh the datagridview
    Sub dgrefresh()
        Me.User_tableTableAdapter.Fill(Me.Pmc_dbDataSet.user_table)
    End Sub

    'enables disabled fields
    Sub enableFields()
        txtfn.Enabled = True
        txtln.Enabled = True
        txtreguser.Enabled = True
        txtregpass.Enabled = True
        txtconfirmpass.Enabled = True
        cbout.Enabled = True
        cbostatus.Enabled = True
    End Sub

    'clear fields
    Sub clearFields()
        txtreguser.Text = ""
        txtregpass.Text = ""
        txtconfirmpass.Text = ""
        txtfn.Text = ""
        txtln.Text = ""
        cbout.Text = ""
        cbostatus.Text = ""
        btnchangepass.Enabled = False
    End Sub

    'disabled fields
    Sub disableFields()
        txtfn.Enabled = False
        txtln.Enabled = False
        txtreguser.Enabled = False
        txtregpass.Enabled = False
        txtconfirmpass.Enabled = False
        cbout.Enabled = False
        cbostatus.Enabled = False
    End Sub

    Private Sub usrctrlusermanagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgrefresh()
    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        If txtreguser.Text = "" Or txtregpass.Text = "" Or txtconfirmpass.Text = "" Or cbout.Text = "" Or cbostatus.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Then
            MsgBox("All fields are required", vbCritical, "Error")
        Else

            If txtregpass.Text = txtconfirmpass.Text Then

                'mysql configs
                con.ConnectionString = My.Settings.pmc_dbConnectionString
                cmd.Connection = con

                'open connection
                con.Open()

                cmd.CommandText = "select * from user_table where username = @un and type = @ut"

                Dim a = cmd.Parameters

                a.Clear()
                a.AddWithValue("un", txtreguser.Text)
                a.AddWithValue("ut", cbout.Text)

                'execute
                cmd.ExecuteNonQuery()

                dr = cmd.ExecuteReader()

                If dr.HasRows Then
                    MsgBox("User already exist", vbCritical, "Error")
                    txtreguser.Text = ""
                    txtreguser.Focus()
                    con.Close()
                Else
                    con.Close()
                    con.Open()

                    cmd.CommandText = "insert into user_table values (Null, @un, @pw, @st, @ut, @fn, @ln)"

                    Dim b = cmd.Parameters

                    b.Clear()
                    b.AddWithValue("un", txtreguser.Text)
                    b.AddWithValue("pw", txtregpass.Text)
                    b.AddWithValue("ut", cbout.Text)
                    b.AddWithValue("st", cbostatus.Text)
                    b.AddWithValue("fn", txtfn.Text)
                    b.AddWithValue("ln", txtln.Text)
                    'execute
                    cmd.ExecuteNonQuery()

                    MsgBox("Success Adding User", vbInformation, "Success")
                    con.Close()
                    txtreguser.Text = ""
                    txtregpass.Text = ""
                    txtconfirmpass.Text = ""
                    cbout.Text = ""
                    cbostatus.Text = ""
                    txtfn.Text = ""
                    txtln.Text = ""

                    con.Close()
                    disableFields()
                End If
            Else
                MsgBox("password does not match", vbCritical, "error")
                txtregpass.Text = ""
                txtconfirmpass.Text = ""
                txtregpass.Focus()
            End If
        End If
        dgrefresh()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn2.Click
        clearFields()
        enableFields()
        txtfn.Focus()
        btn2.Enabled = False
        btnadduser.Enabled = True
        btnupdateuser.Enabled = False
        btnclearuser.Enabled = True
    End Sub



    Private Sub btnclearuser_Click(sender As Object, e As EventArgs) Handles btnclearuser.Click

        Dim res As DialogResult
        res = MsgBox("Clear current fields?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            clearFields()
            disableFields()
            btn2.Enabled = True
            btnclearuser.Enabled = False
            btnadduser.Enabled = False
            btnupdateuser.Enabled = False
            btnchangepass.Enabled = False
        End If
        
    End Sub

    Private Sub btnupdateuser_Click(sender As Object, e As EventArgs) Handles btnupdateuser.Click

        If cbostatus.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Then
            MsgBox("All fields are required", vbCritical, "Error")
        Else

            'mysql configs
            con.ConnectionString = My.Settings.pmc_dbConnectionString
            cmd.Connection = con

            'open connection
            con.Open()

            'check if there are changes to be made
            cmd.CommandText = "select firstname, lastname, status from user_table where id = @uid"

            Dim b = cmd.Parameters

            b.Clear()
            b.AddWithValue("uid", Convert.ToInt32(lbluserid.Text))

            'execute
            cmd.ExecuteNonQuery()

            'get query values
            dr = cmd.ExecuteReader

            dr.Read()

            If dr(0) = txtfn.Text And dr(1) = txtln.Text And dr(2) = cbostatus.SelectedItem Then
                MsgBox("No changes detected", vbInformation, "System Notification")
                'close connection
                con.Close()

            Else
                Dim res2 As DialogResult
                res2 = MsgBox("Do you really want to update selected user?", vbYesNo, "System Confirmation")

                If res2 = DialogResult.Yes Then

                    'close initial connection for checking changes
                    con.Close()
                    'open again
                    con.Open()
                    'update user
                    cmd.CommandText = "UPDATE `user_table` SET `status` = @st, `firstname` = @fn, `lastname` = @ln WHERE (`id` = @uid)"

                    Dim c = cmd.Parameters

                    c.Clear()
                    c.AddWithValue("uid", Convert.ToInt32(lbluserid.Text))
                    c.AddWithValue("st", cbostatus.Text)
                    c.AddWithValue("fn", txtfn.Text)
                    c.AddWithValue("ln", txtln.Text)
                    'execute
                    cmd.ExecuteNonQuery()
                    MsgBox("Success Updating User", vbInformation, "Success")

                    con.Close()
                    clearFields()
                    disableFields()
                    dgrefresh()

                    btnupdateuser.Enabled = False
                    btn2.Enabled = True
                    btnchangepass.Enabled = False
                    btnclearuser.Enabled = False
                End If
                
            End If

        End If

    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        disableFields()
        txtregpass.Enabled = True
        txtconfirmpass.Enabled = True

        If txtregpass.Text = "" Or txtconfirmpass.Text = "" Then
            MsgBox("Both fields are required", vbCritical, "Error")
        Else
           

            If txtregpass.Text = txtconfirmpass.Text Then
                Dim res3 As DialogResult
                res3 = MsgBox("Change selected user's password?", vbYesNo, "System Confirmation")

                If res3 = DialogResult.Yes Then
                    'open connection
                    con.Open()

                    'check if there are changes to be made
                    cmd.CommandText = "update user_table set password = @pw where id = @uid"
                    Dim d = cmd.Parameters

                    d.Clear()
                    d.AddWithValue("uid", Convert.ToInt32(lbluserid.Text))
                    d.AddWithValue("pw", txtregpass.Text)

                    cmd.ExecuteNonQuery()

                    con.Close()

                    MsgBox("Success Changing Password", vbInformation, "Success")
                    dgrefresh()

                    clearFields()
                    disableFields()
                    btn2.Enabled = True
                    btnupdateuser.Enabled = False
                    btnchange.Enabled = False
                    btnclearuser.Enabled = False

                End If
                
            Else
                MsgBox("Passwords do not match", vbCritical, "Error")

            End If


        End If
    End Sub

    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        btnchangepass.Enabled = True
        txtregpass.Enabled = True
        txtconfirmpass.Enabled = True
        txtfn.Enabled = False
        txtln.Enabled = False
        cbostatus.Enabled = False
        btnupdateuser.Enabled = False

        btnchange.Enabled = False
    End Sub

    Private Sub dgusers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgusers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = dgusers.Rows(e.RowIndex)
            lbluserid.Text = row.Cells(0).Value
            txtreguser.Text = row.Cells(3).Value
            txtregpass.Text = ""
            txtconfirmpass.Text = ""
            txtfn.Text = row.Cells(1).Value
            txtln.Text = row.Cells(2).Value
            cbout.Text = row.Cells(6).Value
            cbostatus.Text = row.Cells(5).Value

            enableFields()
            txtreguser.Enabled = False
            txtregpass.Enabled = False
            txtconfirmpass.Enabled = False
            cbout.Enabled = False

            btnupdateuser.Enabled = True
            btnclearuser.Enabled = True
            btnadduser.Enabled = False
            btn2.Enabled = False
            btnchange.Enabled = True
        End If
    End Sub
End Class
