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
        Me.components = New System.ComponentModel.Container()
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Member_IdLabel As System.Windows.Forms.Label
        Dim Payment_DateLabel As System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_IdTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_DateTextBox = New System.Windows.Forms.TextBox()
        Me.btnGroupId = New System.Windows.Forms.Button()
        Me.btnGroupName = New System.Windows.Forms.Button()
        AmountLabel = New System.Windows.Forms.Label()
        Member_IdLabel = New System.Windows.Forms.Label()
        Payment_DateLabel = New System.Windows.Forms.Label()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(62, 29)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 11
        AmountLabel.Text = "Amount:"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Member_IdLabel
        '
        Member_IdLabel.AutoSize = True
        Member_IdLabel.Location = New System.Drawing.Point(48, 70)
        Member_IdLabel.Name = "Member_IdLabel"
        Member_IdLabel.Size = New System.Drawing.Size(60, 13)
        Member_IdLabel.TabIndex = 13
        Member_IdLabel.Text = "Member Id:"
        Member_IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Payment_DateLabel
        '
        Payment_DateLabel.AutoSize = True
        Payment_DateLabel.Location = New System.Drawing.Point(34, 107)
        Payment_DateLabel.Name = "Payment_DateLabel"
        Payment_DateLabel.Size = New System.Drawing.Size(77, 13)
        Payment_DateLabel.TabIndex = 15
        Payment_DateLabel.Text = "Payment Date:"
        Payment_DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(172, 147)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(103, 23)
        Me.btnShow.TabIndex = 18
        Me.btnShow.Text = "Show Payments"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(65, 147)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(117, 29)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 12
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataSource = GetType(KaratePayments.Payment)
        '
        'Member_IdTextBox
        '
        Me.Member_IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Member_Id", True))
        Me.Member_IdTextBox.Location = New System.Drawing.Point(117, 67)
        Me.Member_IdTextBox.Name = "Member_IdTextBox"
        Me.Member_IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Member_IdTextBox.TabIndex = 14
        '
        'Payment_DateTextBox
        '
        Me.Payment_DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaymentBindingSource, "Payment_Date", True))
        Me.Payment_DateTextBox.Location = New System.Drawing.Point(117, 104)
        Me.Payment_DateTextBox.Name = "Payment_DateTextBox"
        Me.Payment_DateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Payment_DateTextBox.TabIndex = 16
        '
        'btnGroupId
        '
        Me.btnGroupId.Location = New System.Drawing.Point(12, 196)
        Me.btnGroupId.Name = "btnGroupId"
        Me.btnGroupId.Size = New System.Drawing.Size(153, 23)
        Me.btnGroupId.TabIndex = 19
        Me.btnGroupId.Text = "Group Members by Id"
        Me.btnGroupId.UseVisualStyleBackColor = True
        '
        'btnGroupName
        '
        Me.btnGroupName.Location = New System.Drawing.Point(172, 196)
        Me.btnGroupName.Name = "btnGroupName"
        Me.btnGroupName.Size = New System.Drawing.Size(153, 23)
        Me.btnGroupName.TabIndex = 20
        Me.btnGroupName.Text = "Group Members By Name"
        Me.btnGroupName.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 231)
        Me.Controls.Add(Me.btnGroupName)
        Me.Controls.Add(Me.btnGroupId)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Member_IdLabel)
        Me.Controls.Add(Me.Member_IdTextBox)
        Me.Controls.Add(Payment_DateLabel)
        Me.Controls.Add(Me.Payment_DateTextBox)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add new payment"
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Member_IdTextBox As TextBox
    Friend WithEvents Payment_DateTextBox As TextBox
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents btnGroupId As Button
    Friend WithEvents btnGroupName As Button
End Class
