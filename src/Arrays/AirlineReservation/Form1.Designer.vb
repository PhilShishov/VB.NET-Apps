<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AirlineReservationForm
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
        Me.mtbSeatCol = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSeatRow = New System.Windows.Forms.MaskedTextBox()
        Me.lstWaitingList = New System.Windows.Forms.ListBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mtbSeatCol
        '
        Me.mtbSeatCol.Location = New System.Drawing.Point(332, 17)
        Me.mtbSeatCol.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtbSeatCol.Mask = "L"
        Me.mtbSeatCol.Name = "mtbSeatCol"
        Me.mtbSeatCol.Size = New System.Drawing.Size(23, 23)
        Me.mtbSeatCol.TabIndex = 15
        '
        'mtbSeatRow
        '
        Me.mtbSeatRow.Location = New System.Drawing.Point(301, 17)
        Me.mtbSeatRow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtbSeatRow.Mask = "##"
        Me.mtbSeatRow.Name = "mtbSeatRow"
        Me.mtbSeatRow.Size = New System.Drawing.Size(24, 23)
        Me.mtbSeatRow.TabIndex = 13
        '
        'lstWaitingList
        '
        Me.lstWaitingList.Enabled = False
        Me.lstWaitingList.FormattingEnabled = True
        Me.lstWaitingList.ItemHeight = 15
        Me.lstWaitingList.Location = New System.Drawing.Point(66, 172)
        Me.lstWaitingList.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstWaitingList.Name = "lstWaitingList"
        Me.lstWaitingList.Size = New System.Drawing.Size(139, 79)
        Me.lstWaitingList.TabIndex = 22
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(247, 82)
        Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(108, 169)
        Me.lstOutput.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "(1A, 1B, 1C, 2A, 2B,...10D)"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(70, 14)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(116, 23)
        Me.txtName.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Waiting List"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(66, 115)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(122, 27)
        Me.btnQuit.TabIndex = 19
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(66, 82)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 27)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete Passenger"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(66, 48)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 27)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add Passenger"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Seat:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name:"
        '
        'AirlineReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 284)
        Me.Controls.Add(Me.mtbSeatCol)
        Me.Controls.Add(Me.mtbSeatRow)
        Me.Controls.Add(Me.lstWaitingList)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "AirlineReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirlineReservation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtbSeatCol As MaskedTextBox
  Friend WithEvents mtbSeatRow As MaskedTextBox
  Friend WithEvents lstWaitingList As ListBox
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents Label4 As Label
  Friend WithEvents txtName As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnDelete As Button
  Friend WithEvents btnAdd As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
