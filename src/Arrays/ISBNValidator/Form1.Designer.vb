<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISBNValidatorForm
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
        Me.mtbISBN = New System.Windows.Forms.MaskedTextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtbISBN
        '
        Me.mtbISBN.Location = New System.Drawing.Point(118, 23)
        Me.mtbISBN.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtbISBN.Mask = "0-00-000000-&"
        Me.mtbISBN.Name = "mtbISBN"
        Me.mtbISBN.Size = New System.Drawing.Size(116, 23)
        Me.mtbISBN.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(118, 147)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(116, 23)
        Me.txtOutput.TabIndex = 9
        Me.txtOutput.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Valid ISBN?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ISBN Number"
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(30, 65)
        Me.btnValidate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(182, 61)
        Me.btnValidate.TabIndex = 7
        Me.btnValidate.Text = "Check Validity"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'ISBNValidatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 200)
        Me.Controls.Add(Me.mtbISBN)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnValidate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ISBNValidatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISBN Validator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbISBN As MaskedTextBox
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnValidate As Button
End Class
