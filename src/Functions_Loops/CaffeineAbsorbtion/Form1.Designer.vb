<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaffeineAbsorbtionForm
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
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt3
        '
        Me.txt3.Enabled = False
        Me.txt3.Location = New System.Drawing.Point(183, 125)
        Me.txt3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(116, 23)
        Me.txt3.TabIndex = 13
        '
        'txt2
        '
        Me.txt2.Enabled = False
        Me.txt2.Location = New System.Drawing.Point(183, 78)
        Me.txt2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(116, 23)
        Me.txt2.TabIndex = 12
        '
        'txt1
        '
        Me.txt1.Enabled = False
        Me.txt1.Location = New System.Drawing.Point(183, 30)
        Me.txt1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(116, 23)
        Me.txt1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Q3: Hourly cups: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Q2: 1 Cup: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Q1: 1 Cup: When will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "65 mg. remain?"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(14, 190)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(286, 40)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate Values"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'CaffeineAbsorbtionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 249)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CaffeineAbsorbtionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caffeine Absorbtion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt3 As TextBox
  Friend WithEvents txt2 As TextBox
  Friend WithEvents txt1 As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnCalculate As Button
End Class
