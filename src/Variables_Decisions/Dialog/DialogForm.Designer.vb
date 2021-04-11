<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TextBoxFont = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBoxSave = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(141, 173)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.ReadOnly = True
        Me.TextBoxPath.Size = New System.Drawing.Size(330, 23)
        Me.TextBoxPath.TabIndex = 2
        '
        'TextBoxFont
        '
        Me.TextBoxFont.Location = New System.Drawing.Point(142, 245)
        Me.TextBoxFont.Name = "TextBoxFont"
        Me.TextBoxFont.ReadOnly = True
        Me.TextBoxFont.Size = New System.Drawing.Size(330, 23)
        Me.TextBoxFont.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(39, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 27)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Font"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 435)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 33)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Select Image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(171, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Jpg Files|*.jpg|Png Files|*.png|All Files|*.*|All Images(jpg, png, ico|*.png;*.jp" &
    "g;*.ico"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files (*.txt|*.txt"
        '
        'TextBoxSave
        '
        Me.TextBoxSave.Location = New System.Drawing.Point(142, 501)
        Me.TextBoxSave.Name = "TextBoxSave"
        Me.TextBoxSave.ReadOnly = True
        Me.TextBoxSave.Size = New System.Drawing.Size(330, 23)
        Me.TextBoxSave.TabIndex = 8
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(39, 499)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 27)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Save As"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DialogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 549)
        Me.Controls.Add(Me.TextBoxSave)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBoxFont)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DialogForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dialog Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents TextBoxFont As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TextBoxSave As TextBox
    Friend WithEvents Button5 As Button
End Class
