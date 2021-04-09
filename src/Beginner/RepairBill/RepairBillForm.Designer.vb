<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepairBillForm
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
        Me.txtParts = New System.Windows.Forms.MaskedTextBox()
        Me.txtLabor = New System.Windows.Forms.MaskedTextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(156, 97)
        Me.txtParts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(116, 23)
        Me.txtParts.TabIndex = 14
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(156, 51)
        Me.txtLabor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(116, 23)
        Me.txtLabor.TabIndex = 13
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(306, 51)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(88, 62)
        Me.btnDisplay.TabIndex = 16
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 15
        Me.lstDisplay.Location = New System.Drawing.Point(156, 153)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(236, 109)
        Me.lstDisplay.TabIndex = 15
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(156, 13)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(236, 23)
        Me.txtName.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cost of Parts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hours of Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer Name"
        '
        'RepairBillForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 285)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.txtLabor)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RepairBillForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Repair Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtParts As MaskedTextBox
  Friend WithEvents txtLabor As MaskedTextBox
  Friend WithEvents btnDisplay As Button
  Friend WithEvents lstDisplay As ListBox
  Friend WithEvents txtName As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
