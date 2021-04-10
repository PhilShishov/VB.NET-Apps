Public Class GPAForm
    Dim floatingSum As Double
    Dim numberOfCourses As Integer

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim grades As String
        Dim gradeValue, hours As Integer
        Dim courseGrade As Double

        'validate input
        If (cmbGrades.SelectedIndex > -1) And (txtHours.Text = "1" Or txtHours.Text = "2" Or txtHours.Text = "3" Or txtHours.Text = "4") Then
            grades = cmbGrades.Text
            gradeValue = CalculateGrade(grades)

            hours = CInt(txtHours.Text)
            courseGrade = CalculateCourseGrade(gradeValue, hours)
            numberOfCourses += 1
            floatingSum += courseGrade

            ResetForm()
        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim gpa As Double

        If numberOfCourses > 0 Then
            gpa = floatingSum / numberOfCourses
            txtGPA.Text = gpa.ToString("N2")
            floatingSum = 0
            numberOfCourses = 0
            ResetForm()
        Else
            MessageBox.Show("Please enter some grades first", "Nothing to calculate", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ResetForm()
        cmbGrades.SelectedIndex = -1
        cmbGrades.Text = "Select Grade"
        txtHours.Clear()
    End Sub

    Function CalculateCourseGrade(gradeValue As Integer, hours As Integer) As Double
        Dim courseGrade, finalGrade As Double
        Dim maxPossibleGrade As Integer

        maxPossibleGrade = 4 * hours '4 represents A
        courseGrade = gradeValue * hours
        finalGrade = (courseGrade / maxPossibleGrade) * 4

        Return finalGrade

    End Function

    Function CalculateGrade(grades As String) As Integer
        Dim gradeValue As Integer

        Select Case (grades)
            Case "A"
                gradeValue = 4
            Case "B"
                gradeValue = 3
            Case "C"
                gradeValue = 2
            Case "D"
                gradeValue = 1
            Case Else
                gradeValue = 0
        End Select

        Return gradeValue
    End Function
End Class
