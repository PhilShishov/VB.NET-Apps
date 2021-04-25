<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpreadOfEpidemicForm
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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.picOutput = New System.Windows.Forms.PictureBox()
        Me.btnAdvance = New System.Windows.Forms.Button()
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(28, 159)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(117, 33)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show Day 0"
        '
        'picOutput
        '
        Me.picOutput.Location = New System.Drawing.Point(15, 14)
        Me.picOutput.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.picOutput.Name = "picOutput"
        Me.picOutput.Size = New System.Drawing.Size(365, 138)
        Me.picOutput.TabIndex = 3
        Me.picOutput.TabStop = False
        '
        'btnAdvance
        '
        Me.btnAdvance.Location = New System.Drawing.Point(170, 159)
        Me.btnAdvance.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(117, 33)
        Me.btnAdvance.TabIndex = 4
        Me.btnAdvance.Text = "Advance One Day"
        '
        'SpreadOfEpidemicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 205)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.picOutput)
        Me.Controls.Add(Me.btnAdvance)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SpreadOfEpidemicForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spread Of Epidemic"
        CType(Me.picOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnShow As Button
  Friend WithEvents picOutput As PictureBox
  Friend WithEvents btnAdvance As Button
End Class
