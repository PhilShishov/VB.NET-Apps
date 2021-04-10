<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProverbsForms
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblProverb = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(18, 110)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(119, 40)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Proverb"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtAnswer
        '
        Me.txtAnswer.Enabled = False
        Me.txtAnswer.Location = New System.Drawing.Point(168, 65)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAnswer.MaxLength = 1
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(40, 23)
        Me.txtAnswer.TabIndex = 6
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(44, 68)
        Me.lblAnswer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(106, 15)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "True (T) or False (F)"
        '
        'lblProverb
        '
        Me.lblProverb.Location = New System.Drawing.Point(14, 10)
        Me.lblProverb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProverb.Name = "lblProverb"
        Me.lblProverb.Size = New System.Drawing.Size(243, 27)
        Me.lblProverb.TabIndex = 7
        '
        'btnAnswer
        '
        Me.btnAnswer.Enabled = False
        Me.btnAnswer.Location = New System.Drawing.Point(144, 110)
        Me.btnAnswer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(119, 40)
        Me.btnAnswer.TabIndex = 8
        Me.btnAnswer.Text = "Record Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'ProverbsForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 183)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.lblProverb)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ProverbsForms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proverbs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplay As Button
  Friend WithEvents txtAnswer As TextBox
  Friend WithEvents lblAnswer As Label
  Friend WithEvents lblProverb As Label
  Friend WithEvents btnAnswer As Button
End Class
