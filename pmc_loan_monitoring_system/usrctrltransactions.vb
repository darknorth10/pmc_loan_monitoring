Public Class usrctrltransactions

    Private Sub tabctrlLoanTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabctrlLoanTrans.SelectedIndexChanged
        If tabctrlLoanTrans.SelectedTab Is cashloantab Then
            frmmain.lbltext.Text = "Loan Transaction - Cash Loan"

        ElseIf tabctrlLoanTrans.SelectedTab Is rieloantab Then
            frmmain.lbltext.Text = "Loan Transaction - Rice Loan"
        ElseIf tabctrlLoanTrans.SelectedTab Is gcloantab Then
            frmmain.lbltext.Text = "Loan Transaction - Gift Certificate Loan"

        ElseIf tabctrlLoanTrans.SelectedTab Is othertab Then
            frmmain.lbltext.Text = "Loan Transaction - Others"
        End If
    End Sub

    Private Sub Licensing1_Load(sender As Object, e As EventArgs)

    End Sub
End Class
