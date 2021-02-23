Public Class MainForm
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TextBox2.Text = Date.Now.ToString()
        '--------------------------------------------
        Me.TextBoxHour.Text = Date.Now.Hour.ToString()
        Me.TextBoxMinute.Text = Date.Now.Minute.ToString()
        Me.TextBoxSecond.Text = Date.Now.Second.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Panel1.Enabled = False
        Me.Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Panel1.Enabled = True
        Me.Button5.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Me.TextBox2.Text = Date.Now.ToString()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.dc_TextBox3.Text = Date.Now.Hour.ToString() +
            ":" + Date.Now.Minute.ToString() +
            ":" + Date.Now.Second.ToString() +
            ":" + Date.Now.Millisecond.ToString()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Timer2.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Timer2.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MessageBox.Show("Do you wanna exit?", "Confirm Message",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.PictureBox1.BackgroundImage = Image.FromFile("D:\Projects\VB.NET-Apps\images\Koala.jpg")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim msg As String = Me.TextBoxMsg.Text

        MessageBox.Show("Hi: " + msg + " ; What's Up?")
        MessageBox.Show("Hi: " + msg + " ; Are you great?")
        MessageBox.Show("Hi: " + msg + " ; What's going on?")
    End Sub

    Dim my_var As String

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim n1 As String = Me.TextBoxN1.Text
        Dim n2 As String = Me.TextBoxN2.Text

        '-------------------------------
        Dim res As String = n1 + n2
        Me.TextBoxResult.Text = res.ToString()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Integer.TryParse(Me.TextBoxN1.Text, n1)
        Integer.TryParse(Me.TextBoxN2.Text, n2)
        '-------------------------------
        Dim res As Integer = n1 + n2
        Me.TextBoxResult.Text = res.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Integer.TryParse(Me.TextBoxN1.Text, n1)
        Integer.TryParse(Me.TextBoxN2.Text, n2)
        '-------------------------------
        Dim res As Integer = n1 + n2
        Me.TextBoxResult.Text = res.ToString()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim n1 As Double
        Dim n2 As Double
        Double.TryParse(Me.TextBoxN1.Text, n1)
        Double.TryParse(Me.TextBoxN2.Text, n2)
        '-------------------------------
        Dim res As Double = n1 + n2
        Me.TextBoxResult.Text = res.ToString()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim n1 As Decimal
        Dim n2 As Decimal
        Decimal.TryParse(Me.TextBoxN1.Text, n1)
        Decimal.TryParse(Me.TextBoxN2.Text, n2)
        '-------------------------------
        Dim res As Decimal = n1 + n2
        Me.TextBoxResult.Text = res.ToString()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim b As Boolean = Me.Button17.Enabled
        MessageBox.Show(b.ToString())
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        MessageBox.Show("Have a nice day", "Bye")
        Application.Exit()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Me.Close()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\calc.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\mspaint.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Me.Process1.StartInfo.FileName = "C:\Windows\System32\notepad.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Me.Process1.StartInfo.FileName = "D:\Applications\7-Zip\7zFM.exe"
        Me.Process1.Start()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim fPath As String = Me.TextBoxFilePath.Text

        Me.Process1.StartInfo.FileName = fPath
        Me.Process1.Start()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim birthYear As Integer
        Integer.TryParse(Me.TextBoxBirthYear.Text, birthYear)

        Dim age As Integer = Date.Now.Year - birthYear

        If (age > 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + age.ToString() + " - " + "You are middle aged!"
        Else
            Me.TextBoxAge.Text = "Your Age Is: " + age.ToString() + " - " + "You are young!"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim birthYear As Integer
        Integer.TryParse(Me.TextBoxBirthYear.Text, birthYear)

        Dim age As Integer = Date.Now.Year - birthYear

        If (age > 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + age.ToString() + " - " + "You are middle aged!"
        ElseIf (age < 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + age.ToString() + " - " + "You are young!"
        Else
            Me.TextBoxAge.Text = "Your Age Is: " + age.ToString() + " - " + "You are good!"
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        For i As Integer = 0 To 4 Step 1
            MessageBox.Show("Number: " + i.ToString())
        Next
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        For i As Integer = 1 To 20 Step 1
            Me.ComboBox1.Items.Add("Item: " + i.ToString)
        Next
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim monthNum As Integer
        Integer.TryParse(Me.TextBoxMonthNum.Text, monthNum)
        '----------------------------
        Dim monthName As String = "Unknown"

        If (monthNum = 1) Then
            monthName = "January"
        End If
        '----------------------------
        If (monthNum = 2) Then
            monthName = "February"
        End If
        '----------------------------
        If (monthNum = 3) Then
            monthName = "March"
        End If
        '----------------------------
        If (monthNum = 4) Then
            monthName = "April"
        End If
        '----------------------------
        If (monthNum = 5) Then
            monthName = "May"
        End If
        '----------------------------
        If (monthNum = 6) Then
            monthName = "June"
        End If
        '----------------------------
        If (monthNum = 7) Then
            monthName = "July"
        End If
        '----------------------------
        If (monthNum = 8) Then
            monthName = "August"
        End If
        '----------------------------
        If (monthNum = 9) Then
            monthName = "September"
        End If
        '----------------------------
        If (monthNum = 10) Then
            monthName = "October"
        End If
        '----------------------------
        If (monthNum = 11) Then
            monthName = "November"
        End If
        '----------------------------
        If (monthNum = 12) Then
            monthName = "December"
        End If
        '----------------------------
        Me.TextBoxMonthName.Text = monthName
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim monthNum As Integer
        Integer.TryParse(Me.TextBoxMonthNum.Text, monthNum)
        Dim monthName As String

        '----------------------------
        Select Case monthNum
            Case 1
                monthName = "January"

            Case 2
                monthName = "February"

            Case 3
                monthName = "March"

            Case 4
                monthName = "April"

            Case 5
                monthName = "May"

            Case 6
                monthName = "June"

            Case 7
                monthName = "July"

            Case 8
                monthName = "August"

            Case 9
                monthName = "September"

            Case 10
                monthName = "October"

            Case 11
                monthName = "November"

            Case 12
                monthName = "December"
            Case Else
                monthName = "Unknown"
        End Select
        '------------------------
        Me.TextBoxMonthName.Text = monthName
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim monthName As String = Me.TextBoxMyMonth.Text.ToLower()
        '--------------------------------
        Dim monthNum As Integer

        Select Case monthName

            Case "january"
                monthNum = 1

            Case "february"
                monthNum = 2

            Case "march"
                monthNum = 3

            Case "april"
                monthNum = 4

            Case "may"
                monthNum = 5

            Case "june"
                monthNum = 6

            Case "july"
                monthNum = 7

            Case "august"
                monthNum = 8

            Case "september"
                monthNum = 9

            Case "october"
                monthNum = 10

            Case "november"
                monthNum = 11

            Case "december"
                monthNum = 12

            Case Else
                monthNum = -1
        End Select
        '---------------------------
        If (monthNum = -1) Then
            Me.TextBoxMyMonthNum.Text = "Invalid Month Name!"
        Else
            Me.TextBoxMyMonthNum.Text = monthNum.ToString()
        End If
        '---------------------------
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim n1 As Double = Val(Me.TextBoxN1.Text)
        Dim n2 As Double = Val(Me.TextBoxN2.Text)

        Dim res As Double = n1 + n2
        Me.TextBoxResult.Text = res.ToString()
    End Sub
End Class
