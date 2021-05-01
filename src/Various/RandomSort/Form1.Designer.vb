<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SortIntegersForm
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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.nudValue = New System.Windows.Forms.NumericUpDown()
        Me.lstValues = New System.Windows.Forms.ListBox()
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(35, 314)
        Me.btnSort.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(140, 27)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "Sort Integers"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'nudValue
        '
        Me.nudValue.Location = New System.Drawing.Point(35, 283)
        Me.nudValue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.nudValue.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudValue.Name = "nudValue"
        Me.nudValue.Size = New System.Drawing.Size(140, 23)
        Me.nudValue.TabIndex = 4
        Me.nudValue.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.ItemHeight = 15
        Me.lstValues.Location = New System.Drawing.Point(35, 25)
        Me.lstValues.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(139, 244)
        Me.lstValues.TabIndex = 3
        '
        'SortIntegersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 372)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.nudValue)
        Me.Controls.Add(Me.lstValues)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SortIntegersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort Integers"
        CType(Me.nudValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents btnSort As Button
    Private WithEvents nudValue As NumericUpDown
    Private WithEvents lstValues As ListBox
End Class
