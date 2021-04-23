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
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lstWorkshops = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(14, 235)
        Me.btnDetails.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(113, 27)
        Me.btnDetails.TabIndex = 5
        Me.btnDetails.Text = "Show Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lstWorkshops
        '
        Me.lstWorkshops.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstWorkshops.FormattingEnabled = True
        Me.lstWorkshops.ItemHeight = 15
        Me.lstWorkshops.Location = New System.Drawing.Point(14, 14)
        Me.lstWorkshops.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstWorkshops.Name = "lstWorkshops"
        Me.lstWorkshops.Size = New System.Drawing.Size(557, 199)
        Me.lstWorkshops.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(134, 235)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(438, 27)
        Me.lblResult.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 284)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lstWorkshops)
        Me.Controls.Add(Me.lblResult)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Workshops"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDetails As Button
    Friend WithEvents lstWorkshops As ListBox
    Friend WithEvents lblResult As Label
End Class
