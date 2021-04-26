<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientBillingForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblBilling = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.cboClient = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(27, 67)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 2)
        Me.Panel1.TabIndex = 25
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(349, 225)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 31)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(227, 225)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(88, 31)
        Me.btnStop.TabIndex = 23
        Me.btnStop.Text = "Stop"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(106, 225)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(88, 31)
        Me.btnStart.TabIndex = 22
        Me.btnStart.Text = "Start"
        '
        'lblBilling
        '
        Me.lblBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBilling.Location = New System.Drawing.Point(41, 103)
        Me.lblBilling.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBilling.Name = "lblBilling"
        Me.lblBilling.Size = New System.Drawing.Size(168, 23)
        Me.lblBilling.TabIndex = 21
        Me.lblBilling.Text = "Billing in progress. . ."
        Me.lblBilling.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBilling.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(186, 177)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Billable hours, minutes:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(227, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 18)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stop time:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(227, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Start time:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuration
        '
        Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDuration.Enabled = False
        Me.lblDuration.Location = New System.Drawing.Point(396, 177)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(93, 23)
        Me.lblDuration.TabIndex = 17
        '
        'lblStop
        '
        Me.lblStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStop.Enabled = False
        Me.lblStop.Location = New System.Drawing.Point(396, 140)
        Me.lblStop.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(93, 23)
        Me.lblStop.TabIndex = 16
        '
        'lblStart
        '
        Me.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStart.Enabled = False
        Me.lblStart.Location = New System.Drawing.Point(396, 103)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(93, 23)
        Me.lblStart.TabIndex = 15
        '
        'cboClient
        '
        Me.cboClient.Location = New System.Drawing.Point(227, 27)
        Me.cboClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboClient.Name = "cboClient"
        Me.cboClient.Size = New System.Drawing.Size(279, 23)
        Me.cboClient.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(69, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Client Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClientBillingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 299)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblBilling)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.cboClient)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ClientBillingForm"
        Me.Text = "Client Billing"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblBilling As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents cboClient As ComboBox
    Friend WithEvents Label1 As Label
End Class
