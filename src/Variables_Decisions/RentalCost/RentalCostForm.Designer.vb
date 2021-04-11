<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCostForm
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
        Me.btnDisplayRates = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstBill = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayRates
        '
        Me.btnDisplayRates.Location = New System.Drawing.Point(22, 38)
        Me.btnDisplayRates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplayRates.Name = "btnDisplayRates"
        Me.btnDisplayRates.Size = New System.Drawing.Size(177, 61)
        Me.btnDisplayRates.TabIndex = 0
        Me.btnDisplayRates.Text = "Display Rental Rates"
        Me.btnDisplayRates.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(22, 216)
        Me.btnDisplayBill.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(177, 61)
        Me.btnDisplayBill.TabIndex = 3
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Item (1, 2, or 3)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Duration (H, or F)"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(167, 123)
        Me.txtItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(32, 23)
        Me.txtItem.TabIndex = 1
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(167, 167)
        Me.txtDuration.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(32, 23)
        Me.txtDuration.TabIndex = 2
        '
        'lstRentalRates
        '
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.ItemHeight = 15
        Me.lstRentalRates.Location = New System.Drawing.Point(218, 38)
        Me.lstRentalRates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(327, 109)
        Me.lstRentalRates.TabIndex = 6
        Me.lstRentalRates.TabStop = False
        '
        'lstBill
        '
        Me.lstBill.FormattingEnabled = True
        Me.lstBill.ItemHeight = 15
        Me.lstBill.Location = New System.Drawing.Point(218, 167)
        Me.lstBill.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstBill.Name = "lstBill"
        Me.lstBill.Size = New System.Drawing.Size(327, 109)
        Me.lstBill.TabIndex = 7
        Me.lstBill.TabStop = False
        '
        'RentalCostForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 318)
        Me.Controls.Add(Me.lstBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRates)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RentalCostForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplayRates As Button
  Friend WithEvents btnDisplayBill As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents txtItem As TextBox
  Friend WithEvents txtDuration As TextBox
  Friend WithEvents lstRentalRates As ListBox
  Friend WithEvents lstBill As ListBox
End Class
