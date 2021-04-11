<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnitPriceForm
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
        Me.txtPricePerOunce = New System.Windows.Forms.MaskedTextBox()
        Me.txtPounds = New System.Windows.Forms.MaskedTextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtPriceOfItem = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOunces = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'txtPricePerOunce
        '
        Me.txtPricePerOunce.Location = New System.Drawing.Point(161, 241)
        Me.txtPricePerOunce.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPricePerOunce.Name = "txtPricePerOunce"
        Me.txtPricePerOunce.ReadOnly = True
        Me.txtPricePerOunce.Size = New System.Drawing.Size(116, 23)
        Me.txtPricePerOunce.TabIndex = 35
        Me.txtPricePerOunce.TabStop = False
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(94, 107)
        Me.txtPounds.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(55, 23)
        Me.txtPounds.TabIndex = 1
        '
        'lblError
        '
        Me.lblError.AutoEllipsis = True
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblError.Location = New System.Drawing.Point(150, 189)
        Me.lblError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 38
        Me.lblError.Visible = False
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(55, 163)
        Me.btnDetermine.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(223, 45)
        Me.btnDetermine.TabIndex = 3
        Me.btnDetermine.Text = "Determine Unit Price"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtPriceOfItem
        '
        Me.txtPriceOfItem.Location = New System.Drawing.Point(149, 22)
        Me.txtPriceOfItem.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPriceOfItem.Name = "txtPriceOfItem"
        Me.txtPriceOfItem.Size = New System.Drawing.Size(116, 23)
        Me.txtPriceOfItem.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Price Per Ounce"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Pounds"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Price of Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(128, 66)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Weight"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(181, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Ounces"
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(238, 107)
        Me.txtOunces.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(55, 23)
        Me.txtOunces.TabIndex = 2
        '
        'UnitPriceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPricePerOunce)
        Me.Controls.Add(Me.txtOunces)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtPriceOfItem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "UnitPriceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPricePerOunce As MaskedTextBox
  Friend WithEvents txtPounds As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnDetermine As Button
  Friend WithEvents txtPriceOfItem As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtOunces As MaskedTextBox
End Class
