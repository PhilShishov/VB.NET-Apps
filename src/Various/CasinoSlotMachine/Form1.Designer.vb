<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasinoSlotForm
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
        Me.picChoice3 = New System.Windows.Forms.PictureBox()
        Me.picChoice2 = New System.Windows.Forms.PictureBox()
        Me.picChoice1 = New System.Windows.Forms.PictureBox()
        Me.picChoice0 = New System.Windows.Forms.PictureBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.picSlot2 = New System.Windows.Forms.PictureBox()
        Me.picSlot1 = New System.Windows.Forms.PictureBox()
        Me.picSlot0 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        Me.timDone = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picChoice3
        '
        Me.picChoice3.Image = Global.CasinoSlotMachineVB.My.Resources.Resources.jackpot
        Me.picChoice3.Location = New System.Drawing.Point(115, 227)
        Me.picChoice3.Name = "picChoice3"
        Me.picChoice3.Size = New System.Drawing.Size(27, 28)
        Me.picChoice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice3.TabIndex = 20
        Me.picChoice3.TabStop = False
        Me.picChoice3.Visible = False
        '
        'picChoice2
        '
        Me.picChoice2.Image = Global.CasinoSlotMachineVB.My.Resources.Resources.bullseye
        Me.picChoice2.Location = New System.Drawing.Point(81, 227)
        Me.picChoice2.Name = "picChoice2"
        Me.picChoice2.Size = New System.Drawing.Size(27, 28)
        Me.picChoice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice2.TabIndex = 19
        Me.picChoice2.TabStop = False
        Me.picChoice2.Visible = False
        '
        'picChoice1
        '
        Me.picChoice1.Image = Global.CasinoSlotMachineVB.My.Resources.Resources.ball
        Me.picChoice1.Location = New System.Drawing.Point(48, 227)
        Me.picChoice1.Name = "picChoice1"
        Me.picChoice1.Size = New System.Drawing.Size(27, 28)
        Me.picChoice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice1.TabIndex = 18
        Me.picChoice1.TabStop = False
        Me.picChoice1.Visible = False
        '
        'picChoice0
        '
        Me.picChoice0.Image = Global.CasinoSlotMachineVB.My.Resources.Resources.arrow
        Me.picChoice0.Location = New System.Drawing.Point(15, 227)
        Me.picChoice0.Name = "picChoice0"
        Me.picChoice0.Size = New System.Drawing.Size(27, 28)
        Me.picChoice0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChoice0.TabIndex = 17
        Me.picChoice0.TabStop = False
        Me.picChoice0.Visible = False
        '
        'lblBank
        '
        Me.lblBank.BackColor = System.Drawing.Color.White
        Me.lblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBank.Location = New System.Drawing.Point(196, 9)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(103, 35)
        Me.lblBank.TabIndex = 16
        Me.lblBank.Text = "100"
        Me.lblBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(193, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(171, 210)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(117, 23)
        Me.btnSpin.TabIndex = 14
        Me.btnSpin.Text = "Spin It"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'picSlot2
        '
        Me.picSlot2.Location = New System.Drawing.Point(313, 56)
        Me.picSlot2.Name = "picSlot2"
        Me.picSlot2.Size = New System.Drawing.Size(117, 134)
        Me.picSlot2.TabIndex = 13
        Me.picSlot2.TabStop = False
        '
        'picSlot1
        '
        Me.picSlot1.Location = New System.Drawing.Point(171, 56)
        Me.picSlot1.Name = "picSlot1"
        Me.picSlot1.Size = New System.Drawing.Size(117, 134)
        Me.picSlot1.TabIndex = 12
        Me.picSlot1.TabStop = False
        '
        'picSlot0
        '
        Me.picSlot0.Location = New System.Drawing.Point(25, 56)
        Me.picSlot0.Name = "picSlot0"
        Me.picSlot0.Size = New System.Drawing.Size(117, 134)
        Me.picSlot0.TabIndex = 11
        Me.picSlot0.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(144, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 21
        Me.label1.Text = "Bankroll"
        '
        'timSpin
        '
        '
        'timDone
        '
        Me.timDone.Interval = 2000
        '
        'CasinoSlotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 293)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.picChoice3)
        Me.Controls.Add(Me.picChoice2)
        Me.Controls.Add(Me.picChoice1)
        Me.Controls.Add(Me.picChoice0)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.picSlot2)
        Me.Controls.Add(Me.picSlot1)
        Me.Controls.Add(Me.picSlot0)
        Me.Name = "CasinoSlotForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slot Machine"
        CType(Me.picChoice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChoice0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents picChoice3 As PictureBox
    Private WithEvents picChoice2 As PictureBox
    Private WithEvents picChoice1 As PictureBox
    Private WithEvents picChoice0 As PictureBox
    Private WithEvents lblBank As Label
    Private WithEvents btnExit As Button
    Private WithEvents btnSpin As Button
    Private WithEvents picSlot2 As PictureBox
    Private WithEvents picSlot1 As PictureBox
    Private WithEvents picSlot0 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents timSpin As Timer
    Private WithEvents timDone As Timer
End Class
