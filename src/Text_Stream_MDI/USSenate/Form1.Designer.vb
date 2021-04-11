<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USSenateForm
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
        Me.lstSenators = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstState = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstSenators
        '
        Me.lstSenators.FormattingEnabled = True
        Me.lstSenators.ItemHeight = 15
        Me.lstSenators.Location = New System.Drawing.Point(181, 60)
        Me.lstSenators.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstSenators.Name = "lstSenators"
        Me.lstSenators.Size = New System.Drawing.Size(139, 109)
        Me.lstSenators.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Senators"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "State"
        '
        'lstState
        '
        Me.lstState.FormattingEnabled = True
        Me.lstState.ItemHeight = 15
        Me.lstState.Location = New System.Drawing.Point(12, 60)
        Me.lstState.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstState.Name = "lstState"
        Me.lstState.Size = New System.Drawing.Size(139, 214)
        Me.lstState.TabIndex = 4
        '
        'USSenateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.lstSenators)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstState)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "USSenateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "U.S. Senate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSenators As ListBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents lstState As ListBox
End Class
