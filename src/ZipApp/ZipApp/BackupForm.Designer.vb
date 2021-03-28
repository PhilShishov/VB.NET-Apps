<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelProgress = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelOverall = New System.Windows.Forms.Label()
        Me.LabelSub = New System.Windows.Forms.Label()
        Me.ProgressBarOverall = New System.Windows.Forms.ProgressBar()
        Me.ProgressBarSub = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1.SuspendLayout()
        Me.PanelProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PanelProgress)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'PanelProgress
        '
        Me.PanelProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelProgress.Controls.Add(Me.Panel2)
        Me.PanelProgress.Controls.Add(Me.LabelOverall)
        Me.PanelProgress.Controls.Add(Me.LabelSub)
        Me.PanelProgress.Controls.Add(Me.ProgressBarOverall)
        Me.PanelProgress.Controls.Add(Me.ProgressBarSub)
        Me.PanelProgress.Controls.Add(Me.Label2)
        Me.PanelProgress.Controls.Add(Me.Label1)
        Me.PanelProgress.Location = New System.Drawing.Point(218, 46)
        Me.PanelProgress.Name = "PanelProgress"
        Me.PanelProgress.Size = New System.Drawing.Size(280, 141)
        Me.PanelProgress.TabIndex = 4
        Me.PanelProgress.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(0, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 1)
        Me.Panel2.TabIndex = 6
        '
        'LabelOverall
        '
        Me.LabelOverall.Location = New System.Drawing.Point(223, 115)
        Me.LabelOverall.Name = "LabelOverall"
        Me.LabelOverall.Size = New System.Drawing.Size(52, 15)
        Me.LabelOverall.TabIndex = 5
        Me.LabelOverall.Text = "0"
        Me.LabelOverall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSub
        '
        Me.LabelSub.Location = New System.Drawing.Point(223, 87)
        Me.LabelSub.Name = "LabelSub"
        Me.LabelSub.Size = New System.Drawing.Size(52, 15)
        Me.LabelSub.TabIndex = 4
        Me.LabelSub.Text = "0"
        Me.LabelSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBarOverall
        '
        Me.ProgressBarOverall.Location = New System.Drawing.Point(11, 110)
        Me.ProgressBarOverall.Name = "ProgressBarOverall"
        Me.ProgressBarOverall.Size = New System.Drawing.Size(206, 23)
        Me.ProgressBarOverall.TabIndex = 3
        '
        'ProgressBarSub
        '
        Me.ProgressBarSub.Location = New System.Drawing.Point(11, 81)
        Me.ProgressBarSub.Name = "ProgressBarSub"
        Me.ProgressBarSub.Size = New System.Drawing.Size(206, 23)
        Me.ProgressBarSub.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(59, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Backup is in Progress..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(89, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Wait"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(179, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(387, 23)
        Me.TextBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(560, 219)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 31)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(49, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(49, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Backup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(681, 280)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackupForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelProgress.ResumeLayout(False)
        Me.PanelProgress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelProgress As Panel
    Friend WithEvents LabelOverall As Label
    Friend WithEvents LabelSub As Label
    Friend WithEvents ProgressBarOverall As ProgressBar
    Friend WithEvents ProgressBarSub As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
