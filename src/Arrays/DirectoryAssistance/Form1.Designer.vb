<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirectoryAssistanceForm
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
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnAnother = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(198, 142)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(116, 23)
        Me.txtCode.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Push-button code:"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(370, 55)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(250, 109)
        Me.lstOutput.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Click the buttons" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to select letters"
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(227, 99)
        Me.btn8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(88, 27)
        Me.btn8.TabIndex = 21
        Me.btn8.Tag = "8"
        Me.btn8.Text = "8  WXYZ"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(121, 99)
        Me.btn7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(88, 27)
        Me.btn7.TabIndex = 20
        Me.btn7.Tag = "7"
        Me.btn7.Text = "7  TUV"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(18, 99)
        Me.btn6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(88, 27)
        Me.btn6.TabIndex = 19
        Me.btn6.Tag = "6"
        Me.btn6.Text = "6  PQRS"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(227, 55)
        Me.btn5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(88, 27)
        Me.btn5.TabIndex = 18
        Me.btn5.Tag = "5"
        Me.btn5.Text = "5  MNO"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(121, 55)
        Me.btn4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(88, 27)
        Me.btn4.TabIndex = 17
        Me.btn4.Tag = "4"
        Me.btn4.Text = "4  JKL"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(18, 55)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(88, 27)
        Me.btn3.TabIndex = 16
        Me.btn3.Tag = "3"
        Me.btn3.Text = "3  GHI"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn2.Location = New System.Drawing.Point(227, 10)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(88, 27)
        Me.btn2.TabIndex = 15
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2  DEF"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(121, 10)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(88, 27)
        Me.btn1.TabIndex = 14
        Me.btn1.Tag = "1"
        Me.btn1.Text = "1  ABC"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnAnother
        '
        Me.btnAnother.Location = New System.Drawing.Point(370, 10)
        Me.btnAnother.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAnother.Name = "btnAnother"
        Me.btnAnother.Size = New System.Drawing.Size(251, 27)
        Me.btnAnother.TabIndex = 22
        Me.btnAnother.Text = "Look Up Another Person"
        Me.btnAnother.UseVisualStyleBackColor = True
        '
        'DirectoryAssistanceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 192)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnAnother)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "DirectoryAssistanceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Directory Assistance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCode As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents Label1 As Label
  Friend WithEvents btn8 As Button
  Friend WithEvents btn7 As Button
  Friend WithEvents btn6 As Button
  Friend WithEvents btn5 As Button
  Friend WithEvents btn4 As Button
  Friend WithEvents btn3 As Button
  Friend WithEvents btn2 As Button
  Friend WithEvents btn1 As Button
  Friend WithEvents btnAnother As Button
End Class
