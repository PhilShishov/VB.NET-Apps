<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurveGradesForm
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
        Me.txtStandDev = New System.Windows.Forms.TextBox()
        Me.txtMean = New System.Windows.Forms.TextBox()
        Me.txtNumExams = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtStandDev
        '
        Me.txtStandDev.Location = New System.Drawing.Point(138, 177)
        Me.txtStandDev.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtStandDev.Name = "txtStandDev"
        Me.txtStandDev.ReadOnly = True
        Me.txtStandDev.Size = New System.Drawing.Size(75, 23)
        Me.txtStandDev.TabIndex = 15
        '
        'txtMean
        '
        Me.txtMean.Location = New System.Drawing.Point(138, 122)
        Me.txtMean.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMean.Name = "txtMean"
        Me.txtMean.ReadOnly = True
        Me.txtMean.Size = New System.Drawing.Size(75, 23)
        Me.txtMean.TabIndex = 14
        '
        'txtNumExams
        '
        Me.txtNumExams.Location = New System.Drawing.Point(138, 70)
        Me.txtNumExams.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtNumExams.Name = "txtNumExams"
        Me.txtNumExams.ReadOnly = True
        Me.txtNumExams.Size = New System.Drawing.Size(75, 23)
        Me.txtNumExams.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Standard Deviation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Mean:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Number of Exams:"
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(14, 14)
        Me.btnAnalyze.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(200, 45)
        Me.btnAnalyze.TabIndex = 9
        Me.btnAnalyze.Text = "Analyze Grades"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'dgvScores
        '
        Me.dgvScores.AllowUserToResizeColumns = False
        Me.dgvScores.AllowUserToResizeRows = False
        Me.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.Location = New System.Drawing.Point(240, 14)
        Me.dgvScores.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.RowHeadersVisible = False
        Me.dgvScores.Size = New System.Drawing.Size(280, 359)
        Me.dgvScores.TabIndex = 8
        '
        'CurveGradesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 402)
        Me.Controls.Add(Me.txtStandDev)
        Me.Controls.Add(Me.txtMean)
        Me.Controls.Add(Me.txtNumExams)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.dgvScores)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CurveGradesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curve Grades"
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtStandDev As TextBox
  Friend WithEvents txtMean As TextBox
  Friend WithEvents txtNumExams As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnAnalyze As Button
  Friend WithEvents dgvScores As DataGridView
End Class
