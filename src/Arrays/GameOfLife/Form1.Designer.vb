<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOfLifeForm
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblIndividuals = New System.Windows.Forms.Label()
        Me.lstGeneration = New System.Windows.Forms.ListBox()
        Me.txtIndividuals = New System.Windows.Forms.TextBox()
        Me.btnGeneration = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(252, 28)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(112, 33)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "New Game"
        '
        'lblIndividuals
        '
        Me.lblIndividuals.AutoSize = True
        Me.lblIndividuals.Location = New System.Drawing.Point(255, 118)
        Me.lblIndividuals.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblIndividuals.Name = "lblIndividuals"
        Me.lblIndividuals.Size = New System.Drawing.Size(67, 15)
        Me.lblIndividuals.TabIndex = 8
        Me.lblIndividuals.Text = "Individuals:"
        Me.lblIndividuals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstGeneration
        '
        Me.lstGeneration.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstGeneration.FormattingEnabled = True
        Me.lstGeneration.ItemHeight = 16
        Me.lstGeneration.Location = New System.Drawing.Point(15, 28)
        Me.lstGeneration.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lstGeneration.Name = "lstGeneration"
        Me.lstGeneration.Size = New System.Drawing.Size(206, 196)
        Me.lstGeneration.TabIndex = 7
        '
        'txtIndividuals
        '
        Me.txtIndividuals.Location = New System.Drawing.Point(330, 114)
        Me.txtIndividuals.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtIndividuals.Name = "txtIndividuals"
        Me.txtIndividuals.ReadOnly = True
        Me.txtIndividuals.Size = New System.Drawing.Size(44, 23)
        Me.txtIndividuals.TabIndex = 6
        '
        'btnGeneration
        '
        Me.btnGeneration.Location = New System.Drawing.Point(239, 70)
        Me.btnGeneration.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnGeneration.Name = "btnGeneration"
        Me.btnGeneration.Size = New System.Drawing.Size(134, 33)
        Me.btnGeneration.TabIndex = 5
        Me.btnGeneration.Text = "Generation #1"
        '
        'GameOfLifeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 269)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.lblIndividuals)
        Me.Controls.Add(Me.lstGeneration)
        Me.Controls.Add(Me.txtIndividuals)
        Me.Controls.Add(Me.btnGeneration)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "GameOfLifeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Of Life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNew As Button
  Friend WithEvents lblIndividuals As Label
  Friend WithEvents lstGeneration As ListBox
  Friend WithEvents txtIndividuals As TextBox
  Friend WithEvents btnGeneration As Button
End Class
