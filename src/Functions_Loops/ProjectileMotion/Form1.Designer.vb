<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectileMotionForm
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
        Me.txtInitialVelocity = New System.Windows.Forms.TextBox()
        Me.txtInitialHeight = New System.Windows.Forms.TextBox()
        Me.lblInitialVelocity = New System.Windows.Forms.Label()
        Me.lblInitialHeight = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnApproxTime = New System.Windows.Forms.Button()
        Me.btnTable = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnMaxHeight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInitialVelocity
        '
        Me.txtInitialVelocity.Location = New System.Drawing.Point(241, 13)
        Me.txtInitialVelocity.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtInitialVelocity.Name = "txtInitialVelocity"
        Me.txtInitialVelocity.Size = New System.Drawing.Size(28, 23)
        Me.txtInitialVelocity.TabIndex = 10
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Location = New System.Drawing.Point(96, 15)
        Me.txtInitialHeight.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(30, 23)
        Me.txtInitialHeight.TabIndex = 9
        '
        'lblInitialVelocity
        '
        Me.lblInitialVelocity.Location = New System.Drawing.Point(144, 6)
        Me.lblInitialVelocity.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblInitialVelocity.Name = "lblInitialVelocity"
        Me.lblInitialVelocity.Size = New System.Drawing.Size(88, 37)
        Me.lblInitialVelocity.TabIndex = 16
        Me.lblInitialVelocity.Text = "Initial Velocity: (feet / second)"
        '
        'lblInitialHeight
        '
        Me.lblInitialHeight.Location = New System.Drawing.Point(15, 10)
        Me.lblInitialHeight.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblInitialHeight.Name = "lblInitialHeight"
        Me.lblInitialHeight.Size = New System.Drawing.Size(78, 32)
        Me.lblInitialHeight.TabIndex = 15
        Me.lblInitialHeight.Text = "Initial Height: (feet)"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(203, 102)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(68, 39)
        Me.btnQuit.TabIndex = 14
        Me.btnQuit.Text = "Quit"
        '
        'btnApproxTime
        '
        Me.btnApproxTime.Location = New System.Drawing.Point(18, 102)
        Me.btnApproxTime.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnApproxTime.Name = "btnApproxTime"
        Me.btnApproxTime.Size = New System.Drawing.Size(176, 39)
        Me.btnApproxTime.TabIndex = 12
        Me.btnApproxTime.Text = "Determine Approximate Time until Ball Hits the Ground"
        '
        'btnTable
        '
        Me.btnTable.Location = New System.Drawing.Point(205, 55)
        Me.btnTable.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnTable.Name = "btnTable"
        Me.btnTable.Size = New System.Drawing.Size(66, 39)
        Me.btnTable.TabIndex = 13
        Me.btnTable.Text = "Display Table"
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(19, 155)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(251, 158)
        Me.lstOutput.TabIndex = 17
        '
        'btnMaxHeight
        '
        Me.btnMaxHeight.Location = New System.Drawing.Point(18, 55)
        Me.btnMaxHeight.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnMaxHeight.Name = "btnMaxHeight"
        Me.btnMaxHeight.Size = New System.Drawing.Size(176, 39)
        Me.btnMaxHeight.TabIndex = 11
        Me.btnMaxHeight.Text = "Determine Maximum Height"
        '
        'ProjectileMotionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 344)
        Me.Controls.Add(Me.txtInitialVelocity)
        Me.Controls.Add(Me.txtInitialHeight)
        Me.Controls.Add(Me.lblInitialVelocity)
        Me.Controls.Add(Me.lblInitialHeight)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnApproxTime)
        Me.Controls.Add(Me.btnTable)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnMaxHeight)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ProjectileMotionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projectile Motion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInitialVelocity As TextBox
  Friend WithEvents txtInitialHeight As TextBox
  Friend WithEvents lblInitialVelocity As Label
  Friend WithEvents lblInitialHeight As Label
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnApproxTime As Button
  Friend WithEvents btnTable As Button
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents btnMaxHeight As Button
End Class
