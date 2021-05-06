<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpPurchDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPricePerShare = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.cboInvestmentType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtShares = New System.Windows.Forms.TextBox()
        Me.txtTicker = New System.Windows.Forms.TextBox()
        Me.btnShowList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(332, 220)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 20)
        Me.lblTotal.TabIndex = 30
        Me.lblTotal.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Total amount:"
        '
        'dtpPurchDate
        '
        Me.dtpPurchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPurchDate.Location = New System.Drawing.Point(154, 177)
        Me.dtpPurchDate.Name = "dtpPurchDate"
        Me.dtpPurchDate.Size = New System.Drawing.Size(122, 20)
        Me.dtpPurchDate.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Purchase date:"
        '
        'lblPricePerShare
        '
        Me.lblPricePerShare.AutoSize = True
        Me.lblPricePerShare.Location = New System.Drawing.Point(361, 132)
        Me.lblPricePerShare.Name = "lblPricePerShare"
        Me.lblPricePerShare.Size = New System.Drawing.Size(28, 13)
        Me.lblPricePerShare.TabIndex = 26
        Me.lblPricePerShare.Text = "0.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Price per share:"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(249, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 27)
        Me.btnClose.TabIndex = 24
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Investment Purchase Information"
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(137, 261)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(91, 27)
        Me.btnConfirm.TabIndex = 23
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'cboInvestmentType
        '
        Me.cboInvestmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvestmentType.FormattingEnabled = True
        Me.cboInvestmentType.Items.AddRange(New Object() {"Stock", "Mutual fund", "Commodity", "Money market"})
        Me.cboInvestmentType.Location = New System.Drawing.Point(153, 77)
        Me.cboInvestmentType.Name = "cboInvestmentType"
        Me.cboInvestmentType.Size = New System.Drawing.Size(156, 21)
        Me.cboInvestmentType.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Ticker symbol:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Number of shares:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Investment type:"
        '
        'txtShares
        '
        Me.txtShares.Location = New System.Drawing.Point(153, 217)
        Me.txtShares.Name = "txtShares"
        Me.txtShares.Size = New System.Drawing.Size(52, 20)
        Me.txtShares.TabIndex = 21
        '
        'txtTicker
        '
        Me.txtTicker.Location = New System.Drawing.Point(153, 129)
        Me.txtTicker.Name = "txtTicker"
        Me.txtTicker.Size = New System.Drawing.Size(75, 20)
        Me.txtTicker.TabIndex = 20
        '
        'btnShowList
        '
        Me.btnShowList.Location = New System.Drawing.Point(39, 263)
        Me.btnShowList.Name = "btnShowList"
        Me.btnShowList.Size = New System.Drawing.Size(75, 23)
        Me.btnShowList.TabIndex = 31
        Me.btnShowList.Text = "Show List"
        Me.btnShowList.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 309)
        Me.Controls.Add(Me.btnShowList)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpPurchDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPricePerShare)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.cboInvestmentType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtShares)
        Me.Controls.Add(Me.txtTicker)
        Me.Name = "MainForm"
        Me.Text = "Investment Tracking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpPurchDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPricePerShare As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents cboInvestmentType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtShares As TextBox
    Friend WithEvents txtTicker As TextBox
    Friend WithEvents btnShowList As Button
End Class
