<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRAForm
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
        Me.txtLarryTotalIRA = New System.Windows.Forms.TextBox()
        Me.txtEarlTotalIRA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLarryTotalDeposits = New System.Windows.Forms.TextBox()
        Me.txtEarlTotalDeposits = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLarryTotalIRA
        '
        Me.txtLarryTotalIRA.Location = New System.Drawing.Point(275, 171)
        Me.txtLarryTotalIRA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLarryTotalIRA.Name = "txtLarryTotalIRA"
        Me.txtLarryTotalIRA.ReadOnly = True
        Me.txtLarryTotalIRA.Size = New System.Drawing.Size(116, 23)
        Me.txtLarryTotalIRA.TabIndex = 21
        '
        'txtEarlTotalIRA
        '
        Me.txtEarlTotalIRA.Location = New System.Drawing.Point(51, 174)
        Me.txtEarlTotalIRA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEarlTotalIRA.Name = "txtEarlTotalIRA"
        Me.txtEarlTotalIRA.ReadOnly = True
        Me.txtEarlTotalIRA.Size = New System.Drawing.Size(116, 23)
        Me.txtEarlTotalIRA.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Larry"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Earl"
        '
        'txtLarryTotalDeposits
        '
        Me.txtLarryTotalDeposits.Location = New System.Drawing.Point(275, 62)
        Me.txtLarryTotalDeposits.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLarryTotalDeposits.Name = "txtLarryTotalDeposits"
        Me.txtLarryTotalDeposits.ReadOnly = True
        Me.txtLarryTotalDeposits.Size = New System.Drawing.Size(116, 23)
        Me.txtLarryTotalDeposits.TabIndex = 17
        '
        'txtEarlTotalDeposits
        '
        Me.txtEarlTotalDeposits.Location = New System.Drawing.Point(49, 62)
        Me.txtEarlTotalDeposits.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEarlTotalDeposits.Name = "txtEarlTotalDeposits"
        Me.txtEarlTotalDeposits.ReadOnly = True
        Me.txtEarlTotalDeposits.Size = New System.Drawing.Size(116, 23)
        Me.txtEarlTotalDeposits.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(133, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Amounts in IRA upon retirement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Larry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Earl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(161, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Amounts Deposited"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(136, 226)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(155, 52)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate Amounts"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'IRAForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 302)
        Me.Controls.Add(Me.txtLarryTotalIRA)
        Me.Controls.Add(Me.txtEarlTotalIRA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLarryTotalDeposits)
        Me.Controls.Add(Me.txtEarlTotalDeposits)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "IRAForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLarryTotalIRA As TextBox
  Friend WithEvents txtEarlTotalIRA As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtLarryTotalDeposits As TextBox
  Friend WithEvents txtEarlTotalDeposits As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnCalculate As Button
End Class
