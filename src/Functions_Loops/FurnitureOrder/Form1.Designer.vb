<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FurnitureOrderForm
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
        Me.txtSofas = New System.Windows.Forms.TextBox()
        Me.txtChairs = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSofas
        '
        Me.txtSofas.Location = New System.Drawing.Point(212, 200)
        Me.txtSofas.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSofas.Name = "txtSofas"
        Me.txtSofas.Size = New System.Drawing.Size(63, 23)
        Me.txtSofas.TabIndex = 18
        Me.txtSofas.Tag = "text"
        '
        'txtChairs
        '
        Me.txtChairs.Location = New System.Drawing.Point(212, 153)
        Me.txtChairs.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtChairs.Name = "txtChairs"
        Me.txtChairs.Size = New System.Drawing.Size(63, 23)
        Me.txtChairs.TabIndex = 16
        Me.txtChairs.Tag = "text"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(212, 111)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(254, 23)
        Me.txtCity.TabIndex = 14
        Me.txtCity.Tag = "text"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(212, 66)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(254, 23)
        Me.txtAddress.TabIndex = 12
        Me.txtAddress.Tag = "text"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(212, 22)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 23)
        Me.txtName.TabIndex = 10
        Me.txtName.Tag = "text"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(572, 276)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(215, 35)
        Me.btnQuit.TabIndex = 22
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(295, 275)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(215, 35)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.BackColor = System.Drawing.SystemColors.Control
        Me.btnProcessOrder.Location = New System.Drawing.Point(29, 276)
        Me.btnProcessOrder.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(215, 33)
        Me.btnProcessOrder.TabIndex = 20
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = False
        '
        'lstDisplay
        '
        Me.lstDisplay.Enabled = False
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 15
        Me.lstDisplay.Location = New System.Drawing.Point(505, 22)
        Me.lstDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(280, 199)
        Me.lstDisplay.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 203)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Number of Sofas Ordered"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Number of Chairs Ordered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "City, State, ZIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Street"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer Name (Last, First)"
        '
        'FurnitureOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 330)
        Me.Controls.Add(Me.txtSofas)
        Me.Controls.Add(Me.txtChairs)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FurnitureOrderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Furniture Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSofas As TextBox
  Friend WithEvents txtChairs As TextBox
  Friend WithEvents txtCity As TextBox
  Friend WithEvents txtAddress As TextBox
  Friend WithEvents txtName As TextBox
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnClear As Button
  Friend WithEvents btnProcessOrder As Button
  Friend WithEvents lstDisplay As ListBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
