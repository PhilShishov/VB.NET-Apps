<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingMachineForm
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
        Me.lblVotes = New System.Windows.Forms.Label()
        Me.btnNominate = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnTally = New System.Windows.Forms.Button()
        Me.lstVotes = New System.Windows.Forms.ListBox()
        Me.lstCandidates = New System.Windows.Forms.ListBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVotes
        '
        Me.lblVotes.AutoSize = True
        Me.lblVotes.Location = New System.Drawing.Point(251, 47)
        Me.lblVotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVotes.Name = "lblVotes"
        Me.lblVotes.Size = New System.Drawing.Size(59, 15)
        Me.lblVotes.TabIndex = 13
        Me.lblVotes.Text = "# of votes"
        Me.lblVotes.Visible = False
        '
        'btnNominate
        '
        Me.btnNominate.Location = New System.Drawing.Point(18, 215)
        Me.btnNominate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNominate.Name = "btnNominate"
        Me.btnNominate.Size = New System.Drawing.Size(88, 73)
        Me.btnNominate.TabIndex = 12
        Me.btnNominate.Text = "Nominate Candidate"
        Me.btnNominate.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(124, 215)
        Me.btnVote.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(88, 73)
        Me.btnVote.TabIndex = 11
        Me.btnVote.Text = "Start Voting"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnTally
        '
        Me.btnTally.Location = New System.Drawing.Point(233, 215)
        Me.btnTally.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTally.Name = "btnTally"
        Me.btnTally.Size = New System.Drawing.Size(88, 73)
        Me.btnTally.TabIndex = 10
        Me.btnTally.Text = "Tally Votes"
        Me.btnTally.UseVisualStyleBackColor = True
        '
        'lstVotes
        '
        Me.lstVotes.FormattingEnabled = True
        Me.lstVotes.ItemHeight = 15
        Me.lstVotes.Location = New System.Drawing.Point(244, 66)
        Me.lstVotes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstVotes.Name = "lstVotes"
        Me.lstVotes.Size = New System.Drawing.Size(76, 124)
        Me.lstVotes.TabIndex = 9
        Me.lstVotes.Visible = False
        '
        'lstCandidates
        '
        Me.lstCandidates.FormattingEnabled = True
        Me.lstCandidates.ItemHeight = 15
        Me.lstCandidates.Location = New System.Drawing.Point(18, 66)
        Me.lstCandidates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstCandidates.Name = "lstCandidates"
        Me.lstCandidates.Size = New System.Drawing.Size(191, 124)
        Me.lstCandidates.TabIndex = 8
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(14, 10)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(307, 53)
        Me.lblInstructions.TabIndex = 7
        Me.lblInstructions.Text = "Click ""Nominate Candidate"" to enter a candidate, or ""Start Voting"" to end nominat" &
    "ions and start the voting."
        '
        'VotingMachineForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 310)
        Me.Controls.Add(Me.lblVotes)
        Me.Controls.Add(Me.btnNominate)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnTally)
        Me.Controls.Add(Me.lstVotes)
        Me.Controls.Add(Me.lstCandidates)
        Me.Controls.Add(Me.lblInstructions)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "VotingMachineForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Voting Machine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVotes As Label
  Friend WithEvents btnNominate As Button
  Friend WithEvents btnVote As Button
  Friend WithEvents btnTally As Button
  Friend WithEvents lstVotes As ListBox
  Friend WithEvents lstCandidates As ListBox
  Friend WithEvents lblInstructions As Label
End Class
