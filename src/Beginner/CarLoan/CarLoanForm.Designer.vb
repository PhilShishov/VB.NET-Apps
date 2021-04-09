<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarLoanForm
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
        Me.txtPayments = New System.Windows.Forms.MaskedTextBox()
        Me.txtYears = New System.Windows.Forms.MaskedTextBox()
        Me.txtInterest = New System.Windows.Forms.MaskedTextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtPayments
        '
        Me.txtPayments.Location = New System.Drawing.Point(162, 230)
        Me.txtPayments.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPayments.Name = "txtPayments"
        Me.txtPayments.ReadOnly = True
        Me.txtPayments.Size = New System.Drawing.Size(116, 23)
        Me.txtPayments.TabIndex = 24
        Me.txtPayments.TabStop = False
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(162, 113)
        Me.txtYears.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(116, 23)
        Me.txtYears.TabIndex = 25
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(162, 73)
        Me.txtInterest.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(116, 23)
        Me.txtInterest.TabIndex = 23
        '
        'lblError
        '
        Me.lblError.AutoEllipsis = True
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblError.Location = New System.Drawing.Point(159, 155)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 28
        Me.lblError.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(56, 155)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(223, 45)
        Me.btnCalculate.TabIndex = 27
        Me.btnCalculate.Text = "Calculate Monthly Payments"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(162, 32)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(116, 23)
        Me.txtAmount.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Monthly Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Number Of Years"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Interst Rate (%)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Amount Of Loan"
        '
        'CarLoanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 278)
        Me.Controls.Add(Me.txtPayments)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CarLoanForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPayments As MaskedTextBox
  Friend WithEvents txtYears As MaskedTextBox
  Friend WithEvents txtInterest As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnCalculate As Button
  Friend WithEvents txtAmount As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
