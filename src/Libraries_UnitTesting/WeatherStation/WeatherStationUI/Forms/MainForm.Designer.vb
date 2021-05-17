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
        Me.lblEventDetected = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEventDetected
        '
        Me.lblEventDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEventDetected.Location = New System.Drawing.Point(29, 51)
        Me.lblEventDetected.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEventDetected.Name = "lblEventDetected"
        Me.lblEventDetected.Size = New System.Drawing.Size(324, 21)
        Me.lblEventDetected.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'btnSummary
        '
        Me.btnSummary.Location = New System.Drawing.Point(203, 85)
        Me.btnSummary.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(135, 27)
        Me.btnSummary.TabIndex = 7
        Me.btnSummary.Text = "Show Summary"
        Me.btnSummary.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "The following event was detected:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(29, 85)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(135, 27)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start monitoring"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 158)
        Me.Controls.Add(Me.lblEventDetected)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weather Station"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEventDetected As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSummary As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
End Class
