<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitConversionForm
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtDesired = New System.Windows.Forms.TextBox()
        Me.txtOriginal = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstUnits = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(289, 197)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(112, 23)
        Me.txtOutput.TabIndex = 19
        Me.txtOutput.TabStop = False
        '
        'txtDesired
        '
        Me.txtDesired.Location = New System.Drawing.Point(289, 100)
        Me.txtDesired.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDesired.Name = "txtDesired"
        Me.txtDesired.ReadOnly = True
        Me.txtDesired.Size = New System.Drawing.Size(116, 23)
        Me.txtDesired.TabIndex = 14
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(289, 54)
        Me.txtOriginal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.ReadOnly = True
        Me.txtOriginal.Size = New System.Drawing.Size(116, 23)
        Me.txtOriginal.TabIndex = 12
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(289, 14)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(116, 23)
        Me.txtLength.TabIndex = 10
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(176, 135)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(230, 33)
        Me.btnConvert.TabIndex = 16
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 201)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Desired Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(172, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Desired Units (1-9)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Original Units (1-9)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Length to Convert"
        '
        'lstUnits
        '
        Me.lstUnits.FormattingEnabled = True
        Me.lstUnits.ItemHeight = 15
        Me.lstUnits.Items.AddRange(New Object() {"1. inch", "2. fathom", "3. foot", "4. furlong", "5. kilometer", "6. meter", "7. mile", "8. rod", "9. yard"})
        Me.lstUnits.Location = New System.Drawing.Point(14, 14)
        Me.lstUnits.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstUnits.Name = "lstUnits"
        Me.lstUnits.Size = New System.Drawing.Size(139, 154)
        Me.lstUnits.TabIndex = 11
        Me.lstUnits.TabStop = False
        '
        'UnitConversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 253)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtDesired)
        Me.Controls.Add(Me.txtOriginal)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstUnits)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UnitConversionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
  Friend WithEvents txtDesired As TextBox
  Friend WithEvents txtOriginal As TextBox
  Friend WithEvents txtLength As TextBox
  Friend WithEvents btnConvert As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents lstUnits As ListBox
End Class
