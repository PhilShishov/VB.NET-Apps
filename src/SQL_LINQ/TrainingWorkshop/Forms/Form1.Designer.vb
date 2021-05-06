<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.dgvWorkshops = New System.Windows.Forms.DataGridView()
        CType(Me.dgvWorkshops, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(12, 204)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(97, 23)
        Me.btnDetails.TabIndex = 5
        Me.btnDetails.Text = "Show Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(115, 204)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(375, 23)
        Me.lblResult.TabIndex = 3
        '
        'dgvWorkshops
        '
        Me.dgvWorkshops.AllowUserToAddRows = False
        Me.dgvWorkshops.AllowUserToDeleteRows = False
        Me.dgvWorkshops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkshops.Location = New System.Drawing.Point(13, 13)
        Me.dgvWorkshops.Name = "dgvWorkshops"
        Me.dgvWorkshops.ReadOnly = True
        Me.dgvWorkshops.Size = New System.Drawing.Size(798, 185)
        Me.dgvWorkshops.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 246)
        Me.Controls.Add(Me.dgvWorkshops)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Training Workshops"
        CType(Me.dgvWorkshops, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDetails As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents dgvWorkshops As DataGridView
End Class
