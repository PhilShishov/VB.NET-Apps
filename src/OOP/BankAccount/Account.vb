Public Class Account
    Dim trans(50) As Transaction
    Dim lastNum As Integer 'last transaction stored

    Private _name As String 'name of the account (savings or checking)
    Private _balance As Double 'current balance

    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Public ReadOnly Property Balance() As Double
        Get
            Return _balance
        End Get
    End Property

    'Insufficient event is raised when a withdrawal is more than the balance.
    Public Event InsufficientFunds(over As Double)
    Public Event TransactionCommitted()

    Public Sub New(name As String)
        _name = name
    End Sub

    Public Sub Add(transaction As Transaction)
        'Add transaction to the account
        Dim newBalance As Double

        'Calculate new balance
        If transaction.Credit Then
            newBalance = Balance + transaction.Amount
        Else
            newBalance = Balance - transaction.Amount
        End If

        'If new balance is negative, then raise the insufficient event.
        If newBalance < 0 Then
            RaiseEvent InsufficientFunds(newBalance)
        Else
            lastNum += 1
            'Ensure there is space to store the transaction within the array.
            If trans.Count() - 1 <= lastNum Then
                ReDim Preserve trans(lastNum + 1)
            End If
            'Store the tranasction, new balance, and raise the committed event.
            trans(lastNum) = transaction
            _balance = newBalance
            RaiseEvent TransactionCommitted()
        End If
    End Sub

    Public Sub Load()
        'Load the data from a comma separated text file
        Dim fileName As String = _name & ".txt"
        Dim sr As IO.StreamReader
        Dim line() As String 'Array to receive values from the Split function
        Dim trans As Transaction
        'if file exists, load it
        If IO.File.Exists(fileName) Then
            sr = IO.File.OpenText(fileName)
            'loop through all the lines
            While Not sr.EndOfStream
                line = sr.ReadLine().Split(","c)
                'add to the account
                'trans = New Transaction(Date.Parse(line(0)), line(1), CDbl(line(2)), CBool(line(3)))
                'trans = New Transaction(Date.ParseExact(line(0), "MMddyyyy", Globalization.CultureInfo.InvariantCulture), line(1), CDbl(line(2)), CBool(line(3)))
                trans = New Transaction(Convert.ToDateTime(line(0), Globalization.CultureInfo.InvariantCulture), line(1), CDbl(line(2)), CBool(line(3)))
                Add(trans)
            End While
            sr.Close()
        End If
    End Sub

End Class
