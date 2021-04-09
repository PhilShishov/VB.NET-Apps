<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeForADollarForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt10 = New System.Windows.Forms.TextBox()
        Me.txt25 = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "1c"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "5c"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "10c"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "25c"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Enter amount"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(107, 152)
        Me.txt1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(116, 23)
        Me.txt1.TabIndex = 16
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(107, 122)
        Me.txt5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt5.Name = "txt5"
        Me.txt5.ReadOnly = True
        Me.txt5.Size = New System.Drawing.Size(116, 23)
        Me.txt5.TabIndex = 15
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(107, 92)
        Me.txt10.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt10.Name = "txt10"
        Me.txt10.ReadOnly = True
        Me.txt10.Size = New System.Drawing.Size(116, 23)
        Me.txt10.TabIndex = 14
        '
        'txt25
        '
        Me.txt25.Location = New System.Drawing.Point(107, 62)
        Me.txt25.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt25.Name = "txt25"
        Me.txt25.ReadOnly = True
        Me.txt25.Size = New System.Drawing.Size(116, 23)
        Me.txt25.TabIndex = 13
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(107, 14)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(116, 23)
        Me.txtAmount.TabIndex = 12
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Location = New System.Drawing.Point(119, 203)
        Me.ButtonCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(88, 42)
        Me.ButtonCalculate.TabIndex = 11
        Me.ButtonCalculate.Text = "Calculate Change"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'ChangeForADollarForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 271)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.txt10)
        Me.Controls.Add(Me.txt25)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.ButtonCalculate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ChangeForADollarForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change For a Dollar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents txt1 As TextBox
  Friend WithEvents txt5 As TextBox
  Friend WithEvents txt10 As TextBox
  Friend WithEvents txt25 As TextBox
  Friend WithEvents txtAmount As TextBox
  Friend WithEvents ButtonCalculate As Button
End Class
