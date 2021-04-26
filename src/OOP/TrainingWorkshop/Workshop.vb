Public Class Workshop
    Public Property Title As String
    Public Property Days As Integer
    Public Property Category As CategoryType
    Public Property Cost As Double

    Public Shared ReadOnly Categories As String() = {"Application development", "Databases", "Networking", "System administration"}

    Public Overrides Function ToString() As String
        Return $"{Title}, Days= {Days}, Category= {Category}, Cost: {Cost.ToString("c")}"
    End Function

    Enum CategoryType
        AppDev
        Database
        Networking
        SysAdmin
    End Enum

End Class
