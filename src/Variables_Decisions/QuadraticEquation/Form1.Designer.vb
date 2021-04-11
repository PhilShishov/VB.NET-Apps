<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuadraticEquationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.btnFindSolution = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSolutions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "a"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "b"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "c"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(33, 14)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(66, 23)
        Me.txtA.TabIndex = 0
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(161, 14)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(66, 23)
        Me.txtB.TabIndex = 1
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(289, 14)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(66, 23)
        Me.txtC.TabIndex = 2
        '
        'btnFindSolution
        '
        Me.btnFindSolution.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnFindSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFindSolution.Location = New System.Drawing.Point(18, 61)
        Me.btnFindSolution.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFindSolution.Name = "btnFindSolution"
        Me.btnFindSolution.Size = New System.Drawing.Size(338, 72)
        Me.btnFindSolution.TabIndex = 3
        Me.btnFindSolution.Text = "Find Solution"
        Me.btnFindSolution.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 166)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Solutions"
        '
        'txtSolutions
        '
        Me.txtSolutions.Location = New System.Drawing.Point(93, 163)
        Me.txtSolutions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSolutions.Name = "txtSolutions"
        Me.txtSolutions.ReadOnly = True
        Me.txtSolutions.Size = New System.Drawing.Size(262, 23)
        Me.txtSolutions.TabIndex = 5
        Me.txtSolutions.TabStop = False
        '
        'QuadraticEquationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 200)
        Me.Controls.Add(Me.txtSolutions)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFindSolution)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "QuadraticEquationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quadratic Equation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents txtA As TextBox
  Friend WithEvents txtB As TextBox
  Friend WithEvents txtC As TextBox
  Friend WithEvents btnFindSolution As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents txtSolutions As TextBox
End Class
