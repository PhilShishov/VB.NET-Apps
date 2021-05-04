Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub

    Private Sub radFullTime_CheckedChanged(sender As Object, e As EventArgs) Handles radFullTime.CheckedChanged
        SalesStaffTableAdapter.Full_Time(CompanyDataSet.SalesStaff)
        CalcAvgSalary()
    End Sub

    Private Sub radPartTime_CheckedChanged(sender As Object, e As EventArgs) Handles radPartTime.CheckedChanged
        SalesStaffTableAdapter.Part_Time(CompanyDataSet.SalesStaff)
        CalcAvgSalary()
    End Sub

    Private Sub CalcAvgSalary()
        Dim row As CompanyDataSet.SalesStaffRow
        Dim totalSalary As Decimal

        For Each row In CompanyDataSet.SalesStaff.Rows
            totalSalary += row.Salary
        Next

        Dim avg As Decimal = totalSalary / CompanyDataSet.SalesStaff.Rows.Count

        lblAverageSalary.Text = FormatCurrency(avg)
    End Sub
End Class
