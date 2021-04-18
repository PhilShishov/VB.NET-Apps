<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountForm
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
        Me.dgvTransactions = New System.Windows.Forms.DataGridView()
        Me.grpCheck = New System.Windows.Forms.GroupBox()
        Me.txtCheckTo = New System.Windows.Forms.TextBox()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblCheckDollar = New System.Windows.Forms.Label()
        Me.lblCheckTo = New System.Windows.Forms.Label()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.grpWithdrawal = New System.Windows.Forms.GroupBox()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.lblWithdrawalDollar = New System.Windows.Forms.Label()
        Me.grpTransfer = New System.Windows.Forms.GroupBox()
        Me.txtTransfer = New System.Windows.Forms.TextBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lblTransDollar = New System.Windows.Forms.Label()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.lblTransfer = New System.Windows.Forms.Label()
        Me.cboTransfer = New System.Windows.Forms.ComboBox()
        Me.grpCredit = New System.Windows.Forms.GroupBox()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.lblDepositDollar = New System.Windows.Forms.Label()
        Me.grpAccount = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.cboAccount = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCheck.SuspendLayout()
        Me.grpWithdrawal.SuspendLayout()
        Me.grpTransfer.SuspendLayout()
        Me.grpCredit.SuspendLayout()
        Me.grpAccount.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransactions
        '
        Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactions.Location = New System.Drawing.Point(210, 273)
        Me.dgvTransactions.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvTransactions.Name = "dgvTransactions"
        Me.dgvTransactions.RowHeadersVisible = False
        Me.dgvTransactions.Size = New System.Drawing.Size(394, 152)
        Me.dgvTransactions.TabIndex = 13
        '
        'grpCheck
        '
        Me.grpCheck.Controls.Add(Me.txtCheckTo)
        Me.grpCheck.Controls.Add(Me.txtCheck)
        Me.grpCheck.Controls.Add(Me.btnCheck)
        Me.grpCheck.Controls.Add(Me.lblCheckDollar)
        Me.grpCheck.Controls.Add(Me.lblCheckTo)
        Me.grpCheck.Controls.Add(Me.lblCheck)
        Me.grpCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpCheck.Location = New System.Drawing.Point(551, 97)
        Me.grpCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCheck.Name = "grpCheck"
        Me.grpCheck.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCheck.Size = New System.Drawing.Size(244, 157)
        Me.grpCheck.TabIndex = 11
        Me.grpCheck.TabStop = False
        Me.grpCheck.Text = "Check"
        '
        'txtCheckTo
        '
        Me.txtCheckTo.Location = New System.Drawing.Point(110, 57)
        Me.txtCheckTo.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCheckTo.Name = "txtCheckTo"
        Me.txtCheckTo.Size = New System.Drawing.Size(118, 20)
        Me.txtCheckTo.TabIndex = 4
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(153, 24)
        Me.txtCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(74, 20)
        Me.txtCheck.TabIndex = 2
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCheck.Location = New System.Drawing.Point(117, 97)
        Me.btnCheck.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(112, 33)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Sign Check"
        '
        'lblCheckDollar
        '
        Me.lblCheckDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheckDollar.Location = New System.Drawing.Point(130, 21)
        Me.lblCheckDollar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckDollar.Name = "lblCheckDollar"
        Me.lblCheckDollar.Size = New System.Drawing.Size(23, 27)
        Me.lblCheckDollar.TabIndex = 1
        Me.lblCheckDollar.Text = "$"
        Me.lblCheckDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCheckTo
        '
        Me.lblCheckTo.AutoSize = True
        Me.lblCheckTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheckTo.Location = New System.Drawing.Point(22, 60)
        Me.lblCheckTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheckTo.Name = "lblCheckTo"
        Me.lblCheckTo.Size = New System.Drawing.Size(73, 13)
        Me.lblCheckTo.TabIndex = 3
        Me.lblCheckTo.Text = "to the order of"
        Me.lblCheckTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheck.Location = New System.Drawing.Point(22, 28)
        Me.lblCheck.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(82, 13)
        Me.lblCheck.TabIndex = 0
        Me.lblCheck.Text = "Pay this amount"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpWithdrawal
        '
        Me.grpWithdrawal.Controls.Add(Me.txtWithdrawal)
        Me.grpWithdrawal.Controls.Add(Me.btnWithdrawal)
        Me.grpWithdrawal.Controls.Add(Me.lblWithdrawalDollar)
        Me.grpWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpWithdrawal.Location = New System.Drawing.Point(20, 180)
        Me.grpWithdrawal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpWithdrawal.Name = "grpWithdrawal"
        Me.grpWithdrawal.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpWithdrawal.Size = New System.Drawing.Size(282, 74)
        Me.grpWithdrawal.TabIndex = 12
        Me.grpWithdrawal.TabStop = False
        Me.grpWithdrawal.Text = "Withdrawal"
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(51, 26)
        Me.txtWithdrawal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(94, 20)
        Me.txtWithdrawal.TabIndex = 1
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnWithdrawal.Location = New System.Drawing.Point(167, 20)
        Me.btnWithdrawal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(102, 33)
        Me.btnWithdrawal.TabIndex = 2
        Me.btnWithdrawal.Text = "Withdrawal"
        '
        'lblWithdrawalDollar
        '
        Me.lblWithdrawalDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWithdrawalDollar.Location = New System.Drawing.Point(22, 22)
        Me.lblWithdrawalDollar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWithdrawalDollar.Name = "lblWithdrawalDollar"
        Me.lblWithdrawalDollar.Size = New System.Drawing.Size(23, 27)
        Me.lblWithdrawalDollar.TabIndex = 0
        Me.lblWithdrawalDollar.Text = "$"
        Me.lblWithdrawalDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpTransfer
        '
        Me.grpTransfer.Controls.Add(Me.txtTransfer)
        Me.grpTransfer.Controls.Add(Me.btnTransfer)
        Me.grpTransfer.Controls.Add(Me.lblTransDollar)
        Me.grpTransfer.Controls.Add(Me.lblTransferTo)
        Me.grpTransfer.Controls.Add(Me.lblTransfer)
        Me.grpTransfer.Controls.Add(Me.cboTransfer)
        Me.grpTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpTransfer.Location = New System.Drawing.Point(313, 97)
        Me.grpTransfer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpTransfer.Name = "grpTransfer"
        Me.grpTransfer.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpTransfer.Size = New System.Drawing.Size(220, 157)
        Me.grpTransfer.TabIndex = 10
        Me.grpTransfer.TabStop = False
        Me.grpTransfer.Text = "Transfer"
        '
        'txtTransfer
        '
        Me.txtTransfer.Location = New System.Drawing.Point(111, 61)
        Me.txtTransfer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtTransfer.Name = "txtTransfer"
        Me.txtTransfer.Size = New System.Drawing.Size(90, 20)
        Me.txtTransfer.TabIndex = 4
        '
        'btnTransfer
        '
        Me.btnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTransfer.Location = New System.Drawing.Point(100, 97)
        Me.btnTransfer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(102, 33)
        Me.btnTransfer.TabIndex = 5
        Me.btnTransfer.Text = "Transfer"
        '
        'lblTransDollar
        '
        Me.lblTransDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTransDollar.Location = New System.Drawing.Point(90, 58)
        Me.lblTransDollar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransDollar.Name = "lblTransDollar"
        Me.lblTransDollar.Size = New System.Drawing.Size(22, 27)
        Me.lblTransDollar.TabIndex = 3
        Me.lblTransDollar.Text = "$"
        Me.lblTransDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransferTo
        '
        Me.lblTransferTo.AutoSize = True
        Me.lblTransferTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTransferTo.Location = New System.Drawing.Point(22, 67)
        Me.lblTransferTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransferTo.Name = "lblTransferTo"
        Me.lblTransferTo.Size = New System.Drawing.Size(16, 13)
        Me.lblTransferTo.TabIndex = 2
        Me.lblTransferTo.Text = "to"
        Me.lblTransferTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTransfer
        '
        Me.lblTransfer.AutoSize = True
        Me.lblTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTransfer.Location = New System.Drawing.Point(22, 27)
        Me.lblTransfer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransfer.Name = "lblTransfer"
        Me.lblTransfer.Size = New System.Drawing.Size(69, 13)
        Me.lblTransfer.TabIndex = 0
        Me.lblTransfer.Text = "Transfer from"
        Me.lblTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTransfer
        '
        Me.cboTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransfer.FormattingEnabled = True
        Me.cboTransfer.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cboTransfer.Location = New System.Drawing.Point(111, 22)
        Me.cboTransfer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboTransfer.MaxDropDownItems = 2
        Me.cboTransfer.Name = "cboTransfer"
        Me.cboTransfer.Size = New System.Drawing.Size(90, 21)
        Me.cboTransfer.TabIndex = 1
        '
        'grpCredit
        '
        Me.grpCredit.Controls.Add(Me.txtDeposit)
        Me.grpCredit.Controls.Add(Me.btnDeposit)
        Me.grpCredit.Controls.Add(Me.lblDepositDollar)
        Me.grpCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpCredit.Location = New System.Drawing.Point(20, 97)
        Me.grpCredit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCredit.Name = "grpCredit"
        Me.grpCredit.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpCredit.Size = New System.Drawing.Size(282, 74)
        Me.grpCredit.TabIndex = 9
        Me.grpCredit.TabStop = False
        Me.grpCredit.Text = "Deposit"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(49, 26)
        Me.txtDeposit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(96, 20)
        Me.txtDeposit.TabIndex = 0
        '
        'btnDeposit
        '
        Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDeposit.Location = New System.Drawing.Point(167, 22)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(102, 33)
        Me.btnDeposit.TabIndex = 1
        Me.btnDeposit.Text = "Deposit"
        '
        'lblDepositDollar
        '
        Me.lblDepositDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDepositDollar.Location = New System.Drawing.Point(22, 22)
        Me.lblDepositDollar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepositDollar.Name = "lblDepositDollar"
        Me.lblDepositDollar.Size = New System.Drawing.Size(23, 27)
        Me.lblDepositDollar.TabIndex = 9
        Me.lblDepositDollar.Text = "$"
        Me.lblDepositDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAccount
        '
        Me.grpAccount.Controls.Add(Me.txtDate)
        Me.grpAccount.Controls.Add(Me.lblDate)
        Me.grpAccount.Controls.Add(Me.txtBalance)
        Me.grpAccount.Controls.Add(Me.lblBalance)
        Me.grpAccount.Controls.Add(Me.lblAccount)
        Me.grpAccount.Controls.Add(Me.cboAccount)
        Me.grpAccount.Location = New System.Drawing.Point(27, 14)
        Me.grpAccount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpAccount.Name = "grpAccount"
        Me.grpAccount.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpAccount.Size = New System.Drawing.Size(768, 76)
        Me.grpAccount.TabIndex = 8
        Me.grpAccount.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDate.Location = New System.Drawing.Point(662, 23)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(89, 20)
        Me.txtDate.TabIndex = 6
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(568, 28)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(76, 15)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Today's Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBalance
        '
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBalance.Location = New System.Drawing.Point(348, 18)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(131, 20)
        Me.txtBalance.TabIndex = 3
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(282, 28)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(51, 15)
        Me.lblBalance.TabIndex = 2
        Me.lblBalance.Text = "Balance:"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(33, 25)
        Me.lblAccount.Margin = New System.Windows.Forms.Padding(4, 3, 0, 3)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(55, 15)
        Me.lblAccount.TabIndex = 0
        Me.lblAccount.Text = "Account:"
        Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAccount
        '
        Me.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cboAccount.FormattingEnabled = True
        Me.cboAccount.Items.AddRange(New Object() {"Checking", "Savings"})
        Me.cboAccount.Location = New System.Drawing.Point(93, 22)
        Me.cboAccount.Margin = New System.Windows.Forms.Padding(1, 3, 4, 3)
        Me.cboAccount.MaxDropDownItems = 2
        Me.cboAccount.Name = "cboAccount"
        Me.cboAccount.Size = New System.Drawing.Size(90, 21)
        Me.cboAccount.TabIndex = 1
        '
        'BankAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 459)
        Me.Controls.Add(Me.dgvTransactions)
        Me.Controls.Add(Me.grpCheck)
        Me.Controls.Add(Me.grpWithdrawal)
        Me.Controls.Add(Me.grpTransfer)
        Me.Controls.Add(Me.grpCredit)
        Me.Controls.Add(Me.grpAccount)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BankAccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Account"
        CType(Me.dgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCheck.ResumeLayout(False)
        Me.grpCheck.PerformLayout()
        Me.grpWithdrawal.ResumeLayout(False)
        Me.grpWithdrawal.PerformLayout()
        Me.grpTransfer.ResumeLayout(False)
        Me.grpTransfer.PerformLayout()
        Me.grpCredit.ResumeLayout(False)
        Me.grpCredit.PerformLayout()
        Me.grpAccount.ResumeLayout(False)
        Me.grpAccount.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTransactions As DataGridView
  Friend WithEvents grpCheck As GroupBox
  Friend WithEvents txtCheckTo As TextBox
  Friend WithEvents txtCheck As TextBox
  Friend WithEvents btnCheck As Button
  Friend WithEvents lblCheckDollar As Label
  Friend WithEvents lblCheckTo As Label
  Friend WithEvents lblCheck As Label
  Friend WithEvents grpWithdrawal As GroupBox
  Friend WithEvents txtWithdrawal As TextBox
  Friend WithEvents btnWithdrawal As Button
  Friend WithEvents lblWithdrawalDollar As Label
  Friend WithEvents grpTransfer As GroupBox
  Friend WithEvents txtTransfer As TextBox
  Friend WithEvents btnTransfer As Button
  Friend WithEvents lblTransDollar As Label
  Friend WithEvents lblTransferTo As Label
  Friend WithEvents lblTransfer As Label
  Friend WithEvents cboTransfer As ComboBox
  Friend WithEvents grpCredit As GroupBox
  Friend WithEvents txtDeposit As TextBox
  Friend WithEvents btnDeposit As Button
  Friend WithEvents lblDepositDollar As Label
  Friend WithEvents grpAccount As GroupBox
  Friend WithEvents txtDate As TextBox
  Friend WithEvents lblDate As Label
  Friend WithEvents txtBalance As TextBox
  Friend WithEvents lblBalance As Label
  Friend WithEvents lblAccount As Label
  Friend WithEvents cboAccount As ComboBox
End Class
