<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.lblLightning = New System.Windows.Forms.Label()
        Me.lblSnowing = New System.Windows.Forms.Label()
        Me.lblRaining = New System.Windows.Forms.Label()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLightning
        '
        Me.lblLightning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLightning.Location = New System.Drawing.Point(131, 158)
        Me.lblLightning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLightning.Name = "lblLightning"
        Me.lblLightning.Size = New System.Drawing.Size(52, 17)
        Me.lblLightning.TabIndex = 16
        Me.lblLightning.Text = "0"
        Me.lblLightning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSnowing
        '
        Me.lblSnowing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSnowing.Location = New System.Drawing.Point(131, 118)
        Me.lblSnowing.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSnowing.Name = "lblSnowing"
        Me.lblSnowing.Size = New System.Drawing.Size(52, 17)
        Me.lblSnowing.TabIndex = 15
        Me.lblSnowing.Text = "0"
        Me.lblSnowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRaining
        '
        Me.lblRaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRaining.Location = New System.Drawing.Point(131, 73)
        Me.lblRaining.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRaining.Name = "lblRaining"
        Me.lblRaining.Size = New System.Drawing.Size(52, 17)
        Me.lblRaining.TabIndex = 14
        Me.lblRaining.Text = "0"
        Me.lblRaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNormal
        '
        Me.lblNormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNormal.Location = New System.Drawing.Point(131, 33)
        Me.lblNormal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(52, 17)
        Me.lblNormal.TabIndex = 12
        Me.lblNormal.Text = "0"
        Me.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lightning:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 120)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Snowing:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Raining:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Normal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(131, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "0"
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 227)
        Me.Controls.Add(Me.lblLightning)
        Me.Controls.Add(Me.lblSnowing)
        Me.Controls.Add(Me.lblRaining)
        Me.Controls.Add(Me.lblNormal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLightning As Label
    Friend WithEvents lblSnowing As Label
    Friend WithEvents lblRaining As Label
    Friend WithEvents lblNormal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
