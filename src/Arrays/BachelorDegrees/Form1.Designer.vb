<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BachelorDegreesForm
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnTable3 = New System.Windows.Forms.Button()
        Me.btnTable2 = New System.Windows.Forms.Button()
        Me.btnTable1 = New System.Windows.Forms.Button()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(164, 207)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(224, 46)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(14, 293)
        Me.dgvOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.Size = New System.Drawing.Size(539, 220)
        Me.dgvOutput.TabIndex = 8
        '
        'btnTable3
        '
        Me.btnTable3.Location = New System.Drawing.Point(164, 120)
        Me.btnTable3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTable3.Name = "btnTable3"
        Me.btnTable3.Size = New System.Drawing.Size(224, 46)
        Me.btnTable3.TabIndex = 7
        Me.btnTable3.Text = "Bachelor Degrees Conferred in 2010 in Certain Fields"
        Me.btnTable3.UseVisualStyleBackColor = True
        '
        'btnTable2
        '
        Me.btnTable2.Location = New System.Drawing.Point(164, 67)
        Me.btnTable2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTable2.Name = "btnTable2"
        Me.btnTable2.Size = New System.Drawing.Size(224, 46)
        Me.btnTable2.TabIndex = 6
        Me.btnTable2.Text = "Percentage Change in Bachelor Degrees Conferred"
        Me.btnTable2.UseVisualStyleBackColor = True
        '
        'btnTable1
        '
        Me.btnTable1.Location = New System.Drawing.Point(164, 12)
        Me.btnTable1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTable1.Name = "btnTable1"
        Me.btnTable1.Size = New System.Drawing.Size(224, 48)
        Me.btnTable1.TabIndex = 5
        Me.btnTable1.Text = "Bachelor Degrees Conferred in Certain Fields"
        Me.btnTable1.UseVisualStyleBackColor = True
        '
        'BachelorDegreesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 535)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnTable3)
        Me.Controls.Add(Me.btnTable2)
        Me.Controls.Add(Me.btnTable1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BachelorDegreesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bachelor Degrees"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnQuit As Button
  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnTable3 As Button
  Friend WithEvents btnTable2 As Button
  Friend WithEvents btnTable1 As Button
End Class
