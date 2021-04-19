<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AirplaneTakeOffForm
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lstAircraft = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(234, 48)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(314, 132)
        Me.lblResult.TabIndex = 5
        '
        'lstAircraft
        '
        Me.lstAircraft.FormattingEnabled = True
        Me.lstAircraft.ItemHeight = 15
        Me.lstAircraft.Location = New System.Drawing.Point(18, 46)
        Me.lstAircraft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstAircraft.Name = "lstAircraft"
        Me.lstAircraft.Size = New System.Drawing.Size(186, 124)
        Me.lstAircraft.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select an Aircraft"
        '
        'AirplaneTakeOffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 225)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstAircraft)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AirplaneTakeOffForm"
        Me.Text = "Airplane Take Off Calculation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents lstAircraft As ListBox
    Friend WithEvents Label1 As Label
End Class
