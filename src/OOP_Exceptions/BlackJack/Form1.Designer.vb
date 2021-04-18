<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlackJackForm
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
        Me.txtDealer = New System.Windows.Forms.TextBox()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.lblDealer = New System.Windows.Forms.Label()
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.btnNewHand = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.lstDealer = New System.Windows.Forms.ListBox()
        Me.lstPlayer = New System.Windows.Forms.ListBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtDealer
        '
        Me.txtDealer.Location = New System.Drawing.Point(306, 110)
        Me.txtDealer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDealer.Name = "txtDealer"
        Me.txtDealer.ReadOnly = True
        Me.txtDealer.Size = New System.Drawing.Size(45, 23)
        Me.txtDealer.TabIndex = 15
        Me.txtDealer.TabStop = False
        Me.txtDealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlayer
        '
        Me.txtPlayer.Location = New System.Drawing.Point(102, 107)
        Me.txtPlayer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.ReadOnly = True
        Me.txtPlayer.Size = New System.Drawing.Size(45, 23)
        Me.txtPlayer.TabIndex = 14
        Me.txtPlayer.TabStop = False
        Me.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDealer
        '
        Me.lblDealer.AutoSize = True
        Me.lblDealer.Location = New System.Drawing.Point(217, 112)
        Me.lblDealer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDealer.Name = "lblDealer"
        Me.lblDealer.Size = New System.Drawing.Size(71, 15)
        Me.lblDealer.TabIndex = 6
        Me.lblDealer.Text = "Dealer Total:"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Location = New System.Drawing.Point(14, 110)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(70, 15)
        Me.lblPlayer.TabIndex = 7
        Me.lblPlayer.Text = "Player Total:"
        '
        'btnNewHand
        '
        Me.btnNewHand.Location = New System.Drawing.Point(126, 136)
        Me.btnNewHand.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewHand.Name = "btnNewHand"
        Me.btnNewHand.Size = New System.Drawing.Size(122, 33)
        Me.btnNewHand.TabIndex = 11
        Me.btnNewHand.Text = "New Hand"
        '
        'btnHold
        '
        Me.btnHold.Location = New System.Drawing.Point(273, 136)
        Me.btnHold.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(78, 33)
        Me.btnHold.TabIndex = 13
        Me.btnHold.Text = "Hold"
        '
        'btnHit
        '
        Me.btnHit.Location = New System.Drawing.Point(14, 136)
        Me.btnHit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(90, 33)
        Me.btnHit.TabIndex = 12
        Me.btnHit.Text = "Hit Me"
        '
        'lstDealer
        '
        Me.lstDealer.FormattingEnabled = True
        Me.lstDealer.ItemHeight = 15
        Me.lstDealer.Location = New System.Drawing.Point(194, 14)
        Me.lstDealer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstDealer.Name = "lstDealer"
        Me.lstDealer.Size = New System.Drawing.Size(157, 79)
        Me.lstDealer.TabIndex = 8
        Me.lstDealer.TabStop = False
        '
        'lstPlayer
        '
        Me.lstPlayer.FormattingEnabled = True
        Me.lstPlayer.ItemHeight = 15
        Me.lstPlayer.Location = New System.Drawing.Point(14, 14)
        Me.lstPlayer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstPlayer.Name = "lstPlayer"
        Me.lstPlayer.Size = New System.Drawing.Size(157, 79)
        Me.lstPlayer.TabIndex = 9
        Me.lstPlayer.TabStop = False
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(14, 175)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(336, 23)
        Me.txtOutput.TabIndex = 10
        Me.txtOutput.TabStop = False
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BlackJackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 216)
        Me.Controls.Add(Me.txtDealer)
        Me.Controls.Add(Me.txtPlayer)
        Me.Controls.Add(Me.lblDealer)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.btnNewHand)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.lstDealer)
        Me.Controls.Add(Me.lstPlayer)
        Me.Controls.Add(Me.txtOutput)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BlackJackForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Black Jack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDealer As TextBox
  Friend WithEvents txtPlayer As TextBox
  Friend WithEvents lblDealer As Label
  Friend WithEvents lblPlayer As Label
  Friend WithEvents btnNewHand As Button
  Friend WithEvents btnHold As Button
  Friend WithEvents btnHit As Button
  Friend WithEvents lstDealer As ListBox
  Friend WithEvents lstPlayer As ListBox
  Friend WithEvents txtOutput As TextBox
End Class
