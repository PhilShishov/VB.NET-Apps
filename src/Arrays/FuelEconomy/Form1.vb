Public Class FuelEconomyForm
    Structure Cars
        Dim carName As String
        Dim numOfCarsTested As Integer
        Dim totalGallons As Double
    End Structure

    Const NUM_OF_MODELS As Integer = 5 '5 TESTED MODELS
    Const MILES_DRIVEN = 100 'EACH CAR WAS DRIVEN 100 MILES
    Dim input() As String = IO.File.ReadAllLines("Mileage.txt") 'INPUT FILE
    Dim allCars(input.Length - 1) As Cars 'STRUCTURE ARRAY HOLDING INPUT FILE
    Dim distinctCars(NUM_OF_MODELS - 1) As Cars 'STRUCTURE ARRAY HOLDING VALUES FOR DISTINCT CARS (5 MODELS)

    'MOVE GALLONS AND CARS TESTED FOR EACH DISTINCT MODEL TO STRUCTURE ARRAY
    Private Sub getData()
        For i As Integer = 0 To distinctCars.Length - 1
            For c As Integer = 0 To allCars.Length - 1
                If distinctCars(i).carName = allCars(c).carName Then
                    distinctCars(i).numOfCarsTested += 1
                    distinctCars(i).totalGallons += allCars(i).totalGallons
                End If
            Next
        Next
    End Sub

    'USE STRUCTURE ARRAY AS A SOURCE AND MOVE ALL DISTINCT CAR NAMES INTO distinctCars STRUCTURE ARRAY
    Private Sub getModels()
        Dim query = From car In allCars
                    Select car.carName
                    Distinct

        For i As Integer = 0 To query.Count() - 1
            distinctCars(i).carName = query(i)
        Next
    End Sub

    'SPLIT FILE DELIMITED BY COMMA AND MOVE IT TO STRUCTURE ARRAY
    Private Sub MoveFile()
        Dim line As String
        For i As Integer = 0 To allCars.Length - 1
            line = input(i)
            allCars(i).carName = line.Split(","c)(0)
            allCars(i).totalGallons = CDbl(line.Split(","c)(1))
        Next
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim query = From car In distinctCars
                    Let mpg As Double = (MILES_DRIVEN * car.numOfCarsTested) / car.totalGallons
                    Let output As String = FormatNumber(mpg, 2)
                    Order By mpg Descending
                    Select car.carName, output

        dgvOutput.DataSource = query.ToList
        dgvOutput.Columns(0).HeaderText = "Model"
        dgvOutput.Columns(1).HeaderText = "MPG"
    End Sub

    Private Sub frmFuelEconomy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MOVE FILE INTO ARRAY
        MoveFile()

        'GET ALL MODELS OF CARS TESTED
        getModels()

        'ADD GALLONS AND NUMBER OF CARS TESTED TO THE ARRAY
        getData()
    End Sub
End Class
