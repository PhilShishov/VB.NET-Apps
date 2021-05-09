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
        Me.chkDescending = New System.Windows.Forms.CheckBox()
        Me.btnByPE_Ratio = New System.Windows.Forms.Button()
        Me.btnByPrice = New System.Windows.Forms.Button()
        Me.btnByTicker = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkDescending
        '
        Me.chkDescending.AutoSize = True
        Me.chkDescending.Location = New System.Drawing.Point(245, 183)
        Me.chkDescending.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkDescending.Name = "chkDescending"
        Me.chkDescending.Size = New System.Drawing.Size(119, 19)
        Me.chkDescending.TabIndex = 11
        Me.chkDescending.Text = "Descending order"
        Me.chkDescending.UseVisualStyleBackColor = True
        '
        'btnByPE_Ratio
        '
        Me.btnByPE_Ratio.Location = New System.Drawing.Point(18, 166)
        Me.btnByPE_Ratio.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnByPE_Ratio.Name = "btnByPE_Ratio"
        Me.btnByPE_Ratio.Size = New System.Drawing.Size(125, 27)
        Me.btnByPE_Ratio.TabIndex = 10
        Me.btnByPE_Ratio.Text = "Sort by PE Ratio"
        Me.btnByPE_Ratio.UseVisualStyleBackColor = True
        '
        'btnByPrice
        '
        Me.btnByPrice.Location = New System.Drawing.Point(18, 115)
        Me.btnByPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnByPrice.Name = "btnByPrice"
        Me.btnByPrice.Size = New System.Drawing.Size(125, 27)
        Me.btnByPrice.TabIndex = 9
        Me.btnByPrice.Text = "Sort by Price"
        Me.btnByPrice.UseVisualStyleBackColor = True
        '
        'btnByTicker
        '
        Me.btnByTicker.Location = New System.Drawing.Point(18, 67)
        Me.btnByTicker.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnByTicker.Name = "btnByTicker"
        Me.btnByTicker.Size = New System.Drawing.Size(125, 27)
        Me.btnByTicker.TabIndex = 8
        Me.btnByTicker.Text = "Sort by Ticker"
        Me.btnByTicker.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 15
        Me.lstBox.Location = New System.Drawing.Point(172, 67)
        Me.lstBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(326, 109)
        Me.lstBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "This application sorts a list of stocks in different ways"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 227)
        Me.Controls.Add(Me.chkDescending)
        Me.Controls.Add(Me.btnByPE_Ratio)
        Me.Controls.Add(Me.btnByPrice)
        Me.Controls.Add(Me.btnByTicker)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainForm"
        Me.Text = "Ordering Stocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkDescending As CheckBox
    Friend WithEvents btnByPE_Ratio As Button
    Friend WithEvents btnByPrice As Button
    Friend WithEvents btnByTicker As Button
    Friend WithEvents lstBox As ListBox
    Friend WithEvents Label1 As Label
End Class
