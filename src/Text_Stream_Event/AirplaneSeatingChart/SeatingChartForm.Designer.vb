<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeatingChartForm
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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblRow = New System.Windows.Forms.Label()
        Me.txtRow = New System.Windows.Forms.TextBox()
        Me.lstRows = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 15
        Me.lstDisplay.Location = New System.Drawing.Point(49, 198)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(215, 64)
        Me.lstDisplay.TabIndex = 34
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtF.Location = New System.Drawing.Point(434, 478)
        Me.txtF.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtF.Name = "txtF"
        Me.txtF.ReadOnly = True
        Me.txtF.Size = New System.Drawing.Size(45, 35)
        Me.txtF.TabIndex = 33
        Me.txtF.TabStop = False
        Me.txtF.Text = "."
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtE
        '
        Me.txtE.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtE.Location = New System.Drawing.Point(371, 478)
        Me.txtE.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtE.Name = "txtE"
        Me.txtE.ReadOnly = True
        Me.txtE.Size = New System.Drawing.Size(46, 35)
        Me.txtE.TabIndex = 32
        Me.txtE.TabStop = False
        Me.txtE.Text = "."
        Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtD
        '
        Me.txtD.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtD.Location = New System.Drawing.Point(308, 478)
        Me.txtD.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtD.Name = "txtD"
        Me.txtD.ReadOnly = True
        Me.txtD.Size = New System.Drawing.Size(46, 35)
        Me.txtD.TabIndex = 31
        Me.txtD.TabStop = False
        Me.txtD.Text = "."
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtC.Location = New System.Drawing.Point(222, 478)
        Me.txtC.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtC.Name = "txtC"
        Me.txtC.ReadOnly = True
        Me.txtC.Size = New System.Drawing.Size(45, 35)
        Me.txtC.TabIndex = 30
        Me.txtC.TabStop = False
        Me.txtC.Text = "."
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtA.Location = New System.Drawing.Point(96, 478)
        Me.txtA.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtA.Name = "txtA"
        Me.txtA.ReadOnly = True
        Me.txtA.Size = New System.Drawing.Size(46, 35)
        Me.txtA.TabIndex = 29
        Me.txtA.TabStop = False
        Me.txtA.Text = "."
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtB.Location = New System.Drawing.Point(159, 478)
        Me.txtB.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(46, 35)
        Me.txtB.TabIndex = 28
        Me.txtB.TabStop = False
        Me.txtB.Text = "."
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblF.Location = New System.Drawing.Point(444, 447)
        Me.lblF.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(26, 27)
        Me.lblF.TabIndex = 27
        Me.lblF.Text = "F"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblE.Location = New System.Drawing.Point(382, 447)
        Me.lblE.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(26, 27)
        Me.lblE.TabIndex = 26
        Me.lblE.Text = "E"
        '
        'lblD
        '
        Me.lblD.AutoSize = True
        Me.lblD.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblD.Location = New System.Drawing.Point(318, 447)
        Me.lblD.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(26, 27)
        Me.lblD.TabIndex = 25
        Me.lblD.Text = "D"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblC.Location = New System.Drawing.Point(232, 447)
        Me.lblC.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(26, 27)
        Me.lblC.TabIndex = 24
        Me.lblC.Text = "C"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblB.Location = New System.Drawing.Point(169, 447)
        Me.lblB.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(26, 27)
        Me.lblB.TabIndex = 23
        Me.lblB.Text = "B"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblA.Location = New System.Drawing.Point(106, 447)
        Me.lblA.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(26, 27)
        Me.lblA.TabIndex = 22
        Me.lblA.Text = "A"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(49, 142)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(216, 33)
        Me.btnDisplay.TabIndex = 21
        Me.btnDisplay.Text = "Display Statistics"
        '
        'lblRow
        '
        Me.lblRow.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRow.Location = New System.Drawing.Point(20, 451)
        Me.lblRow.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblRow.Name = "lblRow"
        Me.lblRow.Size = New System.Drawing.Size(62, 22)
        Me.lblRow.TabIndex = 20
        Me.lblRow.Text = "Row #"
        '
        'txtRow
        '
        Me.txtRow.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtRow.Location = New System.Drawing.Point(27, 478)
        Me.txtRow.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtRow.Name = "txtRow"
        Me.txtRow.ReadOnly = True
        Me.txtRow.Size = New System.Drawing.Size(54, 35)
        Me.txtRow.TabIndex = 19
        Me.txtRow.TabStop = False
        '
        'lstRows
        '
        Me.lstRows.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstRows.FormattingEnabled = True
        Me.lstRows.ItemHeight = 21
        Me.lstRows.Location = New System.Drawing.Point(318, 31)
        Me.lstRows.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.lstRows.Name = "lstRows"
        Me.lstRows.Size = New System.Drawing.Size(156, 382)
        Me.lstRows.TabIndex = 18
        '
        'SeatingChartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 549)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblRow)
        Me.Controls.Add(Me.txtRow)
        Me.Controls.Add(Me.lstRows)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SeatingChartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seating chart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplay As ListBox
  Friend WithEvents txtF As TextBox
  Friend WithEvents txtE As TextBox
  Friend WithEvents txtD As TextBox
  Friend WithEvents txtC As TextBox
  Friend WithEvents txtA As TextBox
  Friend WithEvents txtB As TextBox
  Friend WithEvents lblF As Label
  Friend WithEvents lblE As Label
  Friend WithEvents lblD As Label
  Friend WithEvents lblC As Label
  Friend WithEvents lblB As Label
  Friend WithEvents lblA As Label
  Friend WithEvents btnDisplay As Button
  Friend WithEvents lblRow As Label
  Friend WithEvents txtRow As TextBox
  Friend WithEvents lstRows As ListBox
End Class
