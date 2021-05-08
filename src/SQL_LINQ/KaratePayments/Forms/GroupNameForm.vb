Public Class GroupNameForm
    Private db As New KarateClassesDataContext

    Private Sub frmGroupByName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From aPayment In db.Payments
                    Group aPayment By
                        MemberName = New With {aPayment.Member.First_Name, aPayment.Member.Last_Name}
                        Into PaymentGroup = Group
                    Order By MemberName.Last_Name

        For Each grp In query
            lstBox.Items.Add(grp.MemberName.First_Name & " " & grp.MemberName.Last_Name)

            For Each aPayment In grp.PaymentGroup
                lstBox.Items.Add(aPayment.Amount.ToString("n") & ", " & aPayment.Payment_Date.ToString("d"))
            Next
            lstBox.Items.Add(" ")
        Next
    End Sub
End Class
