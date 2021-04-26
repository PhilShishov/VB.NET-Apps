<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankTellerForm
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.txtAccountNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(369, 200)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(138, 30)
        Me.btnSave.TabIndex = 33
        Me.btnSave.Text = "Save Balance"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(369, 155)
        Me.btnTotals.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(138, 31)
        Me.btnTotals.TabIndex = 32
        Me.btnTotals.Text = "Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(233, 18)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(63, 30)
        Me.btnFind.TabIndex = 31
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(369, 92)
        Me.lblBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(119, 27)
        Me.lblBalance.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(386, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Balance:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(369, 243)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(138, 31)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnWithdraw)
        Me.GroupBox1.Controls.Add(Me.btnDeposit)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 155)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(332, 120)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an action:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(214, 54)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(101, 23)
        Me.txtAmount.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Amount:"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Enabled = False
        Me.btnWithdraw.Location = New System.Drawing.Point(8, 72)
        Me.btnWithdraw.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(108, 30)
        Me.btnWithdraw.TabIndex = 13
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.Enabled = False
        Me.btnDeposit.Location = New System.Drawing.Point(8, 33)
        Me.btnDeposit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(108, 30)
        Me.btnDeposit.TabIndex = 12
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Account holder name:"
        '
        'lblAccountName
        '
        Me.lblAccountName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccountName.Location = New System.Drawing.Point(20, 92)
        Me.lblAccountName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Size = New System.Drawing.Size(209, 27)
        Me.lblAccountName.TabIndex = 25
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Location = New System.Drawing.Point(150, 21)
        Me.txtAccountNum.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(70, 23)
        Me.txtAccountNum.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Account number:"
        '
        'BankTellerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 300)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnTotals)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAccountName)
        Me.Controls.Add(Me.txtAccountNum)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BankTellerForm"
        Me.Text = "Bank Teller"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnTotals As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents txtAccountNum As TextBox
    Friend WithEvents Label1 As Label
End Class
