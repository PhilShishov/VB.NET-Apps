<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreForm
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.groupBox1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.panel2)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.button3)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 46)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(535, 187)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Info"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.label3)
        Me.panel2.Controls.Add(Me.label2)
        Me.panel2.Location = New System.Drawing.Point(186, 34)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(200, 100)
        Me.panel2.TabIndex = 4
        Me.panel2.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.label3.Location = New System.Drawing.Point(37, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(136, 15)
        Me.label3.TabIndex = 1
        Me.label3.Text = "Restoring Backup ..."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(57, 17)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(99, 15)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Please Wait ..."
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(132, 37)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.Size = New System.Drawing.Size(394, 21)
        Me.textBox1.TabIndex = 3
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(471, 137)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(55, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Help"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(23, 133)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(102, 27)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Start"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 34)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(102, 27)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Select Backup"
        Me.button1.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(2, 7)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(556, 33)
        Me.panel1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(77, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(352, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "NOTE: Backup file must be in hard drive not in CD or DVD Drive."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Zip File|*.zip"
        '
        'RestoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(560, 241)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestoreForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Data"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents panel2 As Panel
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents panel1 As Panel
    Private WithEvents label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
