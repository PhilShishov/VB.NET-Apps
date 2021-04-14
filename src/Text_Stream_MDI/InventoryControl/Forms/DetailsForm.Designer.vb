<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsForm
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
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.radNonFiction = New System.Windows.Forms.RadioButton()
        Me.radFiction = New System.Windows.Forms.RadioButton()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(37, 171)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(194, 29)
        Me.btnRecord.TabIndex = 28
        Me.btnRecord.Text = "Record Details"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.radNonFiction)
        Me.grpCategory.Controls.Add(Me.radFiction)
        Me.grpCategory.Location = New System.Drawing.Point(34, 107)
        Me.grpCategory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCategory.Size = New System.Drawing.Size(195, 58)
        Me.grpCategory.TabIndex = 23
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "Category"
        '
        'radNonFiction
        '
        Me.radNonFiction.Location = New System.Drawing.Point(87, 24)
        Me.radNonFiction.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radNonFiction.Name = "radNonFiction"
        Me.radNonFiction.Size = New System.Drawing.Size(96, 24)
        Me.radNonFiction.TabIndex = 1
        Me.radNonFiction.Text = "Nonfiction"
        '
        'radFiction
        '
        Me.radFiction.Checked = True
        Me.radFiction.Location = New System.Drawing.Point(10, 24)
        Me.radFiction.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radFiction.Name = "radFiction"
        Me.radFiction.Size = New System.Drawing.Size(96, 24)
        Me.radFiction.TabIndex = 0
        Me.radFiction.TabStop = True
        Me.radFiction.Text = "Fiction"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(172, 76)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(57, 20)
        Me.txtPrice.TabIndex = 27
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(134, 79)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 26
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(76, 76)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(38, 20)
        Me.txtStock.TabIndex = 25
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(34, 79)
        Me.lblStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(38, 13)
        Me.lblStock.TabIndex = 24
        Me.lblStock.Text = "Stock:"
        Me.lblStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(76, 44)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(153, 20)
        Me.txtAuthor.TabIndex = 22
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(31, 47)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(41, 13)
        Me.lblAuthor.TabIndex = 21
        Me.lblAuthor.Text = "Author:"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(76, 12)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(153, 20)
        Me.txtTitle.TabIndex = 20
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(42, 15)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Title:"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 216)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "DetailsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Details"
        Me.grpCategory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRecord As Button
  Friend WithEvents grpCategory As GroupBox
  Friend WithEvents radNonFiction As RadioButton
  Friend WithEvents radFiction As RadioButton
  Friend WithEvents txtPrice As TextBox
  Friend WithEvents lblPrice As Label
  Friend WithEvents txtStock As TextBox
  Friend WithEvents lblStock As Label
  Friend WithEvents txtAuthor As TextBox
  Friend WithEvents lblAuthor As Label
  Friend WithEvents txtTitle As TextBox
  Friend WithEvents lblTitle As Label
End Class
