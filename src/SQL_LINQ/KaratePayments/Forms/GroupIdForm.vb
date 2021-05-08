Public Class GroupIdForm
    Private db As New KarateClassesDataContext

    Private Sub frmGroupPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From aPayment In db.Payments
                    Group aPayment By aPayment.Member_Id
                        Into PaymentGroup = Group

        For Each grp In query
            lstBox.Items.Add("Member ID = " & grp.Member_Id)
            For Each aPayment In grp.PaymentGroup
                lstBox.Items.Add(aPayment.Amount.ToString("n") & ", " & aPayment.Payment_Date.ToString("d"))
            Next
            lstBox.Items.Add(" ")
        Next
    End Sub
End Class
