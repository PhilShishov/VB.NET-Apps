Public Class Workshop

    Private adapter As New TrainingDataSetTableAdapters.WorkshopsTableAdapter
    Private listAdapter As New TrainingDataSetTableAdapters.WorkshopListTableAdapter
    Private categoriesAdapter As New TrainingDataSetTableAdapters.CategoriesTableAdapter

    Public Property Id As Short
    Public Property Title As String
    Public Property NumDays As Integer
    Public Property Cost As Double
    Public Property Category As CategoryType

    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = listAdapter.GetDataJoinTables()
            Return table
        End Get
    End Property

    Public ReadOnly Property Categories As DataTable
        Get
            Dim table As DataTable = categoriesAdapter.GetData()
            Return table
        End Get
    End Property

    Public Function FindById(workshopId As Short) As TrainingDataSet.WorkshopsRow
        Return adapter.GetData().FindById(workshopId)
    End Function

    Public Function Update(id As Short, categoryId As Short, days As Short,
                           cost As Decimal, description As String) As Boolean

        Dim origData As TrainingDataSet.WorkshopsRow = FindById(id)

        Return adapter.Update(id, categoryId, days, cost, description,
                              origData.Id, origData.CategoryId, origData.NumOfDays, origData.Cost, origData.Title)
    End Function

    Public Overrides Function ToString() As String
        Return $"{Title}, Days = {NumDays}, Category = {Category}, Cost = {Cost.ToString("c")}"
    End Function
End Class
