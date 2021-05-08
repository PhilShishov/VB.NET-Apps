Public Class MainForm
    Private db As New CourseRegistrationClassesDataContext

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = From aStudent In db.Students
                    Select aStudent.Id, aStudent.LastName, aStudent.Status,
                           aStudent.Major, Courses = aStudent.Courses.Count()
                    Order By Id

        dgvStudents.DataSource = query
    End Sub

    Private Sub dgvStudents_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStudents.SelectionChanged
        If dgvStudents.SelectedRows.Count = 0 Then Return

        Dim studentId As Short = CShort(dgvStudents.SelectedRows(0).Cells(0).Value)
        Dim query = From aCourse In (From aCourse In db.Courses
                                     Select aCourse
                                     Where aCourse.Student_Id = studentId
                                     Order By aCourse.Id)
                    Select aCourse.Id, aCourse.Credits, aCourse.Grade

        dgvCourses.DataSource = query
    End Sub
End Class
