<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinterSportsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lnkForecast = New System.Windows.Forms.LinkLabel()
        Me.chkWaiver = New System.Windows.Forms.CheckBox()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEquipment = New System.Windows.Forms.ListBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(558, 172)
        Me.txtDeposit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(92, 23)
        Me.txtDeposit.TabIndex = 36
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(374, 265)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(88, 31)
        Me.btnClose.TabIndex = 35
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(239, 265)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 31)
        Me.btnCalculate.TabIndex = 34
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(467, 16)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(186, 29)
        Me.lblDate.TabIndex = 33
        Me.lblDate.Text = "(date)"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 215)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Bal due"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 172)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Deposit"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(513, 130)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 15)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Tax"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(479, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Subtotal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(559, 209)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(91, 31)
        Me.lblBalance.TabIndex = 28
        Me.lblBalance.Text = "0.00"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(559, 125)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(91, 31)
        Me.lblTax.TabIndex = 27
        Me.lblTax.Text = "0.00"
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(559, 82)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(91, 31)
        Me.lblSubtotal.TabIndex = 26
        Me.lblSubtotal.Text = "0.00"
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lnkForecast
        '
        Me.lnkForecast.AutoSize = True
        Me.lnkForecast.Location = New System.Drawing.Point(26, 271)
        Me.lnkForecast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnkForecast.Name = "lnkForecast"
        Me.lnkForecast.Size = New System.Drawing.Size(96, 15)
        Me.lnkForecast.TabIndex = 25
        Me.lnkForecast.TabStop = True
        Me.lnkForecast.Text = "Weather forecast"
        '
        'chkWaiver
        '
        Me.chkWaiver.AutoSize = True
        Me.chkWaiver.Location = New System.Drawing.Point(239, 185)
        Me.chkWaiver.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkWaiver.Name = "chkWaiver"
        Me.chkWaiver.Size = New System.Drawing.Size(104, 19)
        Me.chkWaiver.TabIndex = 24
        Me.chkWaiver.Text = "Liability waiver"
        Me.chkWaiver.UseVisualStyleBackColor = True
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(239, 142)
        Me.chkInsurance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(124, 19)
        Me.chkInsurance.TabIndex = 23
        Me.chkInsurance.Text = "Damage insurance"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Rental duration"
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Items.AddRange(New Object() {"1 day", "2 days", "3 days", "1 week", "2 weeks"})
        Me.cboDuration.Location = New System.Drawing.Point(239, 82)
        Me.cboDuration.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(199, 23)
        Me.cboDuration.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 62)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Select all Equipment to be Rented"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstEquipment
        '
        Me.lstEquipment.FormattingEnabled = True
        Me.lstEquipment.ItemHeight = 15
        Me.lstEquipment.Items.AddRange(New Object() {"Skis, beginner", "Skis, advanced", "Snowboard, beginner", "Snowboard, advanced", "Ski boots", "Snowboard boots", "Helmet, standard", "Helmet, deluxe"})
        Me.lstEquipment.Location = New System.Drawing.Point(14, 77)
        Me.lstEquipment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstEquipment.Name = "lstEquipment"
        Me.lstEquipment.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstEquipment.Size = New System.Drawing.Size(194, 139)
        Me.lstEquipment.TabIndex = 19
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'WinterSportsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 333)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lnkForecast)
        Me.Controls.Add(Me.chkWaiver)
        Me.Controls.Add(Me.chkInsurance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboDuration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstEquipment)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "WinterSportsForm"
        Me.Text = "Winter Sports Rentals"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lnkForecast As LinkLabel
    Friend WithEvents chkWaiver As CheckBox
    Friend WithEvents chkInsurance As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDuration As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstEquipment As ListBox
    Friend WithEvents errProvider As ErrorProvider
End Class
