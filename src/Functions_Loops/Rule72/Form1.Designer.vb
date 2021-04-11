<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rule72Form
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnEvaluate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(26, 66)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(191, 319)
        Me.lstOutput.TabIndex = 4
        '
        'btnEvaluate
        '
        Me.btnEvaluate.Location = New System.Drawing.Point(26, 20)
        Me.btnEvaluate.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnEvaluate.Name = "btnEvaluate"
        Me.btnEvaluate.Size = New System.Drawing.Size(191, 33)
        Me.btnEvaluate.TabIndex = 3
        Me.btnEvaluate.Text = "Evaluate Rule"
        '
        'Rule72Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 404)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnEvaluate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Rule72Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rule 72"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
  Friend WithEvents btnEvaluate As Button
End Class
