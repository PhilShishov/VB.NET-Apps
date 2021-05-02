Imports System.IO

Public Class Account
    Public Property AccountId As String
    Public Property AccountName As String
    Public Property Balance As Decimal
    Public Property FilePath As String
    Public Property ErrorMsg As String
    Public Property Records As List(Of Account)

    Private _totalDeposits As Decimal
    Private _totalWithdrawals As Decimal

    Public ReadOnly Property TotalDeposits As Decimal
        Get
            Return _totalDeposits
        End Get
    End Property

    Public ReadOnly Property TotalWithdrawals As Decimal
        Get
            Return _totalWithdrawals
        End Get
    End Property

    Public Sub New()
        AccountName = String.Empty
        Balance = 0D
        Records = New List(Of Account)
    End Sub

    Public Function GetData(acctId As String) As Boolean

        Dim infile As StreamReader = Nothing
        ErrorMsg = String.Empty

        Try
            infile = File.OpenText(FilePath)
            While Not infile.EndOfStream
                Dim line As String = infile.ReadLine()
                Dim fields() As String = line.Split(","c)
                If fields(0) = acctId Then
                    AccountId = fields(0)
                    AccountName = fields(1)
                    Balance = CDec(fields(2))
                    _totalDeposits = 0D
                    _totalWithdrawals = 0D
                    Return True
                End If
            End While
            ErrorMsg = "Account " & AccountId & "Not Found"
            Return False
        Catch ex As Exception
            ErrorMsg = ex.Message
            Return False
        Finally
            If infile IsNot Nothing Then infile.Close()
        End Try
    End Function

    Public Function GetData() As Boolean

        Dim infile As StreamReader = Nothing
        ErrorMsg = String.Empty
        Dim fields() As String

        Try
            infile = File.OpenText(FilePath)
            While Not infile.EndOfStream
                Dim line As String = infile.ReadLine()
                fields = line.Split(","c)
                Dim acct As Account = New Account With {
                    .AccountId = fields(0),
                    .AccountName = fields(1),
                    .Balance = CDec(fields(2))
                }
                Records.Add(acct)
            End While
            If Records IsNot Nothing Then Return True
        Catch ex As Exception
            ErrorMsg = ex.Message
            Return False
        Finally
            If infile IsNot Nothing Then infile.Close()
        End Try
        Return False
    End Function

    Public Sub Deposit(amount As Decimal)
        If amount < 0 Then
            Throw New ArgumentException("Deposit must be a positive value.")
        Else
            Balance += amount
            _totalDeposits += amount
        End If
    End Sub

    Public Function Withdraw(amount As Decimal) As Boolean

        If amount < 0 Then
            Throw New ArgumentException("Withdrawal must be a positive value.")
        ElseIf amount > Balance Then
            Throw New ArgumentException("Insufficient funds for withdrawal.")
        Else
            Balance -= amount
            _totalWithdrawals += amount
            Return True
        End If

        Return False
    End Function
End Class
