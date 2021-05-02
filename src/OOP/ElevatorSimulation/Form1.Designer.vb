<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElevatorForm
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
        Me.lblFloorNumber = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlElevator = New System.Windows.Forms.Panel()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlElevator.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFloorNumber
        '
        Me.lblFloorNumber.AutoSize = True
        Me.lblFloorNumber.Location = New System.Drawing.Point(287, 36)
        Me.lblFloorNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFloorNumber.Name = "lblFloorNumber"
        Me.lblFloorNumber.Size = New System.Drawing.Size(13, 15)
        Me.lblFloorNumber.TabIndex = 5
        Me.lblFloorNumber.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Floor:"
        '
        'pnlElevator
        '
        Me.pnlElevator.BackColor = System.Drawing.Color.Silver
        Me.pnlElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlElevator.Controls.Add(Me.lblPassengers)
        Me.pnlElevator.Location = New System.Drawing.Point(16, 132)
        Me.pnlElevator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlElevator.Name = "pnlElevator"
        Me.pnlElevator.Size = New System.Drawing.Size(90, 30)
        Me.pnlElevator.TabIndex = 3
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Location = New System.Drawing.Point(34, 7)
        Me.lblPassengers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(13, 15)
        Me.lblPassengers.TabIndex = 0
        Me.lblPassengers.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'ElevatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 361)
        Me.Controls.Add(Me.lblFloorNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlElevator)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ElevatorForm"
        Me.Text = "Elevator"
        Me.pnlElevator.ResumeLayout(False)
        Me.pnlElevator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFloorNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlElevator As Panel
    Friend WithEvents lblPassengers As Label
    Friend WithEvents Timer1 As Timer
End Class
