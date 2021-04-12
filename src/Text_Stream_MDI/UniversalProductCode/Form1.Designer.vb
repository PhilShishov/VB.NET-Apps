<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UPCForm
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
        Me.mtbUPC = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.btnDisplayReceipt = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mtbUPC
        '
        Me.mtbUPC.Location = New System.Drawing.Point(66, 95)
        Me.mtbUPC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtbUPC.Mask = "000000000000"
        Me.mtbUPC.Name = "mtbUPC"
        Me.mtbUPC.Size = New System.Drawing.Size(126, 23)
        Me.mtbUPC.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 100)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "UPC"
        '
        'lstReceipt
        '
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 15
        Me.lstReceipt.Location = New System.Drawing.Point(29, 133)
        Me.lstReceipt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(378, 139)
        Me.lstReceipt.TabIndex = 8
        Me.lstReceipt.TabStop = False
        '
        'btnDisplayReceipt
        '
        Me.btnDisplayReceipt.Location = New System.Drawing.Point(244, 69)
        Me.btnDisplayReceipt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplayReceipt.Name = "btnDisplayReceipt"
        Me.btnDisplayReceipt.Size = New System.Drawing.Size(164, 46)
        Me.btnDisplayReceipt.TabIndex = 7
        Me.btnDisplayReceipt.Text = "Display Receipt"
        Me.btnDisplayReceipt.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(244, 8)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(164, 51)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add to Receipt"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(29, 14)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(164, 46)
        Me.btnCustomer.TabIndex = 9
        Me.btnCustomer.Text = "New Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'UPCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 298)
        Me.Controls.Add(Me.mtbUPC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.btnDisplayReceipt)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCustomer)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UPCForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbUPC As MaskedTextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents lstReceipt As ListBox
  Friend WithEvents btnDisplayReceipt As Button
  Friend WithEvents btnAdd As Button
  Friend WithEvents btnCustomer As Button
End Class
