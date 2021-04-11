<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PalindromeForm
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
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(127, 157)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(116, 23)
        Me.txtOutput.TabIndex = 7
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(46, 85)
        Me.btnAnalyze.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(275, 47)
        Me.btnAnalyze.TabIndex = 6
        Me.btnAnalyze.Text = "Determine if Palindrome"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(18, 42)
        Me.txtWord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(333, 23)
        Me.txtWord.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the Word or Phrase"
        '
        'PalindromeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 202)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PalindromeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
  Friend WithEvents btnAnalyze As Button
  Friend WithEvents txtWord As TextBox
  Friend WithEvents Label1 As Label
End Class
