<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MealsForm
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
        Me.radVeg = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radLowCal = New System.Windows.Forms.RadioButton()
        Me.radUnoccupied = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'radVeg
        '
        Me.radVeg.Location = New System.Drawing.Point(174, 75)
        Me.radVeg.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.radVeg.Name = "radVeg"
        Me.radVeg.Size = New System.Drawing.Size(91, 32)
        Me.radVeg.TabIndex = 7
        Me.radVeg.Text = "Vegetarian"
        '
        'radRegular
        '
        Me.radRegular.Location = New System.Drawing.Point(174, 32)
        Me.radRegular.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(72, 32)
        Me.radRegular.TabIndex = 6
        Me.radRegular.Text = "Regular"
        '
        'radLowCal
        '
        Me.radLowCal.Location = New System.Drawing.Point(41, 75)
        Me.radLowCal.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.radLowCal.Name = "radLowCal"
        Me.radLowCal.Size = New System.Drawing.Size(96, 32)
        Me.radLowCal.TabIndex = 5
        Me.radLowCal.Text = "Low Calorie"
        '
        'radUnoccupied
        '
        Me.radUnoccupied.Location = New System.Drawing.Point(41, 32)
        Me.radUnoccupied.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.radUnoccupied.Name = "radUnoccupied"
        Me.radUnoccupied.Size = New System.Drawing.Size(103, 32)
        Me.radUnoccupied.TabIndex = 4
        Me.radUnoccupied.Text = "Unoccupied"
        '
        'MealsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 140)
        Me.Controls.Add(Me.radVeg)
        Me.Controls.Add(Me.radRegular)
        Me.Controls.Add(Me.radLowCal)
        Me.Controls.Add(Me.radUnoccupied)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MealsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Meals"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radVeg As RadioButton
  Friend WithEvents radRegular As RadioButton
  Friend WithEvents radLowCal As RadioButton
  Friend WithEvents radUnoccupied As RadioButton
End Class
