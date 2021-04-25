<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseballForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.lstTeams = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Show Players with Greater Avg than Team's Avg"
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(218, 44)
        Me.dgvOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.Size = New System.Drawing.Size(357, 140)
        Me.dgvOutput.TabIndex = 6
        '
        'lstTeams
        '
        Me.lstTeams.FormattingEnabled = True
        Me.lstTeams.ItemHeight = 15
        Me.lstTeams.Location = New System.Drawing.Point(15, 44)
        Me.lstTeams.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstTeams.Name = "lstTeams"
        Me.lstTeams.Size = New System.Drawing.Size(174, 139)
        Me.lstTeams.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click on the Team"
        '
        'BaseballForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 203)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.lstTeams)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BaseballForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baseball"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents lstTeams As ListBox
  Friend WithEvents Label1 As Label
End Class
