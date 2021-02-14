Public Class Form

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
        Dim Msg As String = Me.TextBoxMsg.Text

        MessageBox.Show("Hi: " + Msg + " ; What's Up?")
        MessageBox.Show("Hi: " + Msg + " ; Are you great?")
        MessageBox.Show("Hi: " + Msg + " ; What's going on?")
    End Sub

    Dim my_var As String

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim N1 As String = Me.TextBoxN1.Text
        Dim N2 As String = Me.TextBoxN2.Text

        '-------------------------------
        Dim Res As String = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim N1 As Integer
        Dim N2 As Integer
        Integer.TryParse(Me.TextBoxN1.Text, N1)
        Integer.TryParse(Me.TextBoxN2.Text, N2)
        '-------------------------------
        Dim Res As Integer = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim N1 As Integer
        Dim N2 As Integer
        Integer.TryParse(Me.TextBoxN1.Text, N1)
        Integer.TryParse(Me.TextBoxN2.Text, N2)
        '-------------------------------
        Dim Res As Integer = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim N1 As Double
        Dim N2 As Double
        Double.TryParse(Me.TextBoxN1.Text, N1)
        Double.TryParse(Me.TextBoxN2.Text, N2)
        '-------------------------------
        Dim Res As Double = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim N1 As Decimal
        Dim N2 As Decimal
        Decimal.TryParse(Me.TextBoxN1.Text, N1)
        Decimal.TryParse(Me.TextBoxN2.Text, N2)
        '-------------------------------
        Dim Res As Decimal = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim B As Boolean = Me.Button17.Enabled
        MessageBox.Show(B.ToString())
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
        Dim F_Path As String = Me.TextBoxFilePath.Text

        Me.Process1.StartInfo.FileName = F_Path
        Me.Process1.Start()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim Age As Integer
        Dim BirthYear As Integer
        Integer.TryParse(Me.TextBoxBirthYear.Text, BirthYear)
        Age = Date.Now.Year - BirthYear

        If (Age > 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + Age.ToString() + " - " + "You are middle aged!"
        Else
            Me.TextBoxAge.Text = "Your Age Is: " + Age.ToString() + " - " + "You are young!"
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim Age As Integer
        Dim BirthYear As Integer
        Integer.TryParse(Me.TextBoxBirthYear.Text, BirthYear)
        Age = Date.Now.Year - BirthYear

        If (Age > 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + Age.ToString() + " - " + "You are middle aged!"
        ElseIf (Age < 30) Then
            Me.TextBoxAge.Text = "Your Age Is: " + Age.ToString() + " - " + "You are young!"
        Else
            Me.TextBoxAge.Text = "Your Age Is: " + Age.ToString() + " - " + "You are good!"
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
        Dim MonthNum As Integer
        Integer.TryParse(Me.TextBoxMonthNum.Text, MonthNum)
        '----------------------------
        Dim MonthName As String = "Unknown"

        If (MonthNum = 1) Then
            MonthName = "January"
        End If
        '----------------------------
        If (MonthNum = 2) Then
            MonthName = "February"
        End If
        '----------------------------
        If (MonthNum = 3) Then
            MonthName = "March"
        End If
        '----------------------------
        If (MonthNum = 4) Then
            MonthName = "April"
        End If
        '----------------------------
        If (MonthNum = 5) Then
            MonthName = "May"
        End If
        '----------------------------
        If (MonthNum = 6) Then
            MonthName = "June"
        End If
        '----------------------------
        If (MonthNum = 7) Then
            MonthName = "July"
        End If
        '----------------------------
        If (MonthNum = 8) Then
            MonthName = "August"
        End If
        '----------------------------
        If (MonthNum = 9) Then
            MonthName = "September"
        End If
        '----------------------------
        If (MonthNum = 10) Then
            MonthName = "October"
        End If
        '----------------------------
        If (MonthNum = 11) Then
            MonthName = "November"
        End If
        '----------------------------
        If (MonthNum = 12) Then
            MonthName = "December"
        End If
        '----------------------------
        Me.TextBoxMonthName.Text = MonthName
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim MonthNum As Integer
        Integer.TryParse(Me.TextBoxMonthNum.Text, MonthNum)
        Dim MonthName As String

        '----------------------------
        Select Case MonthNum
            Case 1
                MonthName = "January"

            Case 2
                MonthName = "February"

            Case 3
                MonthName = "March"

            Case 4
                MonthName = "April"

            Case 5
                MonthName = "May"

            Case 6
                MonthName = "June"

            Case 7
                MonthName = "July"

            Case 8
                MonthName = "August"

            Case 9
                MonthName = "September"

            Case 10
                MonthName = "October"

            Case 11
                MonthName = "November"

            Case 12
                MonthName = "December"
            Case Else
                MonthName = "Unknown"
        End Select
        '------------------------
        Me.TextBoxMonthName.Text = MonthName
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim MonthName As String = Me.TextBoxMyMonth.Text.ToLower()
        '--------------------------------
        Dim MonthNum As Integer

        Select Case MonthName

            Case "january"
                MonthNum = 1

            Case "february"
                MonthNum = 2

            Case "march"
                MonthNum = 3

            Case "april"
                MonthNum = 4

            Case "may"
                MonthNum = 5

            Case "june"
                MonthNum = 6

            Case "july"
                MonthNum = 7

            Case "august"
                MonthNum = 8

            Case "september"
                MonthNum = 9

            Case "october"
                MonthNum = 10

            Case "november"
                MonthNum = 11

            Case "december"
                MonthNum = 12

            Case Else
                MonthNum = -1
        End Select
        '---------------------------
        If (MonthNum = -1) Then
            Me.TextBoxMyMonthNum.Text = "Invalid Month Name!"
        Else
            Me.TextBoxMyMonthNum.Text = MonthNum.ToString()
        End If
        '---------------------------
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim N1 As Double = Val(Me.TextBoxN1.Text)
        Dim N2 As Double = Val(Me.TextBoxN2.Text)

        Dim Res As Double = N1 + N2
        Me.TextBoxResult.Text = Res.ToString()
    End Sub
End Class
