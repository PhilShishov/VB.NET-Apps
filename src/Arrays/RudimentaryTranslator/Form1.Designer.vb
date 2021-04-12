<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RudimentaryTranslatorForm
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
        Me.txtGerman = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFrench = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTranslate = New System.Windows.Forms.Button()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGerman
        '
        Me.txtGerman.Location = New System.Drawing.Point(150, 189)
        Me.txtGerman.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGerman.Name = "txtGerman"
        Me.txtGerman.ReadOnly = True
        Me.txtGerman.Size = New System.Drawing.Size(408, 23)
        Me.txtGerman.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 193)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "German Sentence"
        '
        'txtFrench
        '
        Me.txtFrench.Location = New System.Drawing.Point(150, 144)
        Me.txtFrench.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFrench.Name = "txtFrench"
        Me.txtFrench.ReadOnly = True
        Me.txtFrench.Size = New System.Drawing.Size(408, 23)
        Me.txtFrench.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "French Sentence"
        '
        'btnTranslate
        '
        Me.btnTranslate.Location = New System.Drawing.Point(181, 69)
        Me.btnTranslate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnTranslate.Name = "btnTranslate"
        Me.btnTranslate.Size = New System.Drawing.Size(345, 37)
        Me.btnTranslate.TabIndex = 9
        Me.btnTranslate.Text = "Translate Sentence"
        Me.btnTranslate.UseVisualStyleBackColor = True
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(150, 21)
        Me.txtEnglish.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(408, 23)
        Me.txtEnglish.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "English Sentence"
        '
        'RudimentaryTranslatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 242)
        Me.Controls.Add(Me.txtGerman)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFrench)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTranslate)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RudimentaryTranslatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rudimentary Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGerman As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents txtFrench As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnTranslate As Button
  Friend WithEvents txtEnglish As TextBox
  Friend WithEvents Label1 As Label
End Class
