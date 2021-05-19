Imports System.IO
Imports System.IO.File

Public Class Flight
    Private Shared FlightDurations(,) As Double

    Public Property DepartureAirport As Airport
    Public Property ArrivalAirport As Airport
    Public Property DepartsWhen As Date
    Public Property Duration As Double

    Public Shared LastError As String
    Public Shared AirportList As New ArrayList

    Public Sub New(departureIndex As Integer, arrivalIndex As Integer, deptWhen As Date)
        DepartureAirport = CType(AirportList(departureIndex), Airport)
        ArrivalAirport = CType(AirportList(arrivalIndex), Airport)
        DepartsWhen = deptWhen
        Duration = FlightDurations(departureIndex, arrivalIndex)
    End Sub

    Public Function GetArrival() As Date
        Dim temp As Date = DepartsWhen.AddHours(-DepartureAirport.UTCOffset)

        temp = temp.AddHours(Duration)

        Return temp.AddHours(ArrivalAirport.UTCOffset)
    End Function

    Public Shared Function GetData(filePath As String) As Boolean
        Dim inFile As StreamReader = Nothing
        LastError = String.Empty

        Try
            inFile = OpenText(filePath)
            While Not inFile.EndOfStream
                Dim codes() As String = inFile.ReadLine().Split(" "c)
                Dim utcOffsets() As String = inFile.ReadLine().Split(" "c)

                For i = 0 To codes.Length - 1
                    AirportList.Add(New Airport(codes(i), CInt(utcOffsets(i))))
                Next

                ReDim FlightDurations(codes.Length - 1, utcOffsets.Length - 1)

                For i = 0 To codes.Length - 1
                    Dim temp As String() = inFile.ReadLine().Split(" "c)
                    For j = 0 To utcOffsets.Length - 1
                        FlightDurations(i, j) = CDbl(temp(j))
                    Next
                Next
                Return True
            End While

            LastError = "Something is wrong with the input file"
            Return False
        Catch ex As Exception
            LastError = ex.Message
            Return False
        Finally
            If inFile IsNot Nothing Then inFile.Close()
        End Try

        Return False
    End Function
End Class
