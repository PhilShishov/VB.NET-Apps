<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LengthConversionForm
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
        Me.txtFeet = New System.Windows.Forms.MaskedTextBox()
        Me.txtYards = New System.Windows.Forms.MaskedTextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lstMetric = New System.Windows.Forms.ListBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInches = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtFeet
        '
        Me.txtFeet.Location = New System.Drawing.Point(86, 106)
        Me.txtFeet.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFeet.Name = "txtFeet"
        Me.txtFeet.Size = New System.Drawing.Size(116, 23)
        Me.txtFeet.TabIndex = 2
        '
        'txtYards
        '
        Me.txtYards.Location = New System.Drawing.Point(86, 66)
        Me.txtYards.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtYards.Name = "txtYards"
        Me.txtYards.Size = New System.Drawing.Size(116, 23)
        Me.txtYards.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.AutoEllipsis = True
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblError.Location = New System.Drawing.Point(83, 148)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 17
        Me.lblError.Visible = False
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(239, 25)
        Me.btnConvert.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(167, 45)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert To Metric"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lstMetric
        '
        Me.lstMetric.FormattingEnabled = True
        Me.lstMetric.ItemHeight = 15
        Me.lstMetric.Location = New System.Drawing.Point(239, 89)
        Me.lstMetric.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstMetric.Name = "lstMetric"
        Me.lstMetric.Size = New System.Drawing.Size(166, 79)
        Me.lstMetric.TabIndex = 15
        Me.lstMetric.TabStop = False
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(86, 25)
        Me.txtMiles.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(116, 23)
        Me.txtMiles.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Feet"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Yards"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Miles"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 150)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Inches"
        '
        'txtInches
        '
        Me.txtInches.Location = New System.Drawing.Point(86, 147)
        Me.txtInches.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtInches.Name = "txtInches"
        Me.txtInches.Size = New System.Drawing.Size(116, 23)
        Me.txtInches.TabIndex = 3
        '
        'LengthConversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 210)
        Me.Controls.Add(Me.txtInches)
        Me.Controls.Add(Me.txtFeet)
        Me.Controls.Add(Me.txtYards)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lstMetric)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "LengthConversionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Length Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFeet As MaskedTextBox
  Friend WithEvents txtYards As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnConvert As Button
  Friend WithEvents lstMetric As ListBox
  Friend WithEvents txtMiles As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtInches As MaskedTextBox
End Class
