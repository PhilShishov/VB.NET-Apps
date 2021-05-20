Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports FlightSchedulerLibrary

<TestClass>
Public Class FlightTest
    Private context As TestContext
    Public Property TestContext As TestContext
        Get
            Return context
        End Get
        Set(value As TestContext)
            context = value
        End Set
    End Property

    <ClassInitialize>
    Public Shared Sub ClassInit(testContext As TestContext)
        Flight.GetData("..\..\..\FlightData.txt")
    End Sub

    <TestMethod>
    Public Sub GetArrivalTest1()
        Dim departure As Integer = 0
        Dim arrival As Integer = 3
        Dim departWhen As Date = #10/01/2019 8:30:00 AM#
        Dim target As Flight = New Flight(departure, arrival, departWhen)

        Dim expected As Date = #10/01/2019 1:30:00 PM#
        Dim actual As Date = target.GetArrival()

        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod>
    Public Sub GetArrivalTest2()
        Dim departure As Integer = 0
        Dim arrival As Integer = 2
        Dim departWhen As Date = #10/01/2019 8:30:00 AM#
        Dim target As Flight = New Flight(departure, arrival, departWhen)

        Dim expected As Date = #10/01/2019 3:30:00 PM#
        Dim actual As Date = target.GetArrival()

        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod>
    Public Sub GetArrivalTest3()
        Dim departure As Integer = 1
        Dim arrival As Integer = 2
        Dim departWhen As Date = #10/01/2019 8:30:00 AM#
        Dim target As Flight = New Flight(departure, arrival, departWhen)

        Dim expected As Date = #10/01/2019 5:30:00 PM#
        Dim actual As Date = target.GetArrival()

        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod>
    Public Sub GetArrivalTest4()
        Dim departure As Integer = 1
        Dim arrival As Integer = 0
        Dim departWhen As Date = #10/01/2019 11:30:00 PM#
        Dim target As Flight = New Flight(departure, arrival, departWhen)

        Dim expected As Date = #10/02/2019 2:30:00 AM#
        Dim actual As Date = target.GetArrival()

        Assert.AreEqual(expected, actual)
    End Sub

    <TestMethod>
    Public Sub GetArrivalTest5()
        Dim departure As Integer = 3
        Dim arrival As Integer = 4
        Dim departWhen As Date = #10/01/2019 11:30:00 AM#
        Dim target As Flight = New Flight(departure, arrival, departWhen)

        Dim expected As Date = #10/01/2019 5:00:00 PM#
        Dim actual As Date = target.GetArrival()

        Assert.AreEqual(expected, actual)
    End Sub
End Class