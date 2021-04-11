<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParanthesesForm
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(18, 170)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(390, 23)
        Me.txtOutput.TabIndex = 7
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(18, 95)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(391, 52)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Remove Parantheses"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sentence"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(18, 46)
        Me.txtSentence.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(390, 23)
        Me.txtSentence.TabIndex = 4
        '
        'ParanthesesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 223)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSentence)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ParanthesesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parantheses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
  Friend WithEvents btnRemove As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtSentence As TextBox
End Class
