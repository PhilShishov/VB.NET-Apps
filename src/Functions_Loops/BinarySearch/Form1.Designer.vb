<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarySearchForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFirstTwo = New System.Windows.Forms.Label()
        Me.mtbInput = New System.Windows.Forms.MaskedTextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lstStates = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "States:"
        '
        'lblFirstTwo
        '
        Me.lblFirstTwo.Location = New System.Drawing.Point(153, 33)
        Me.lblFirstTwo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstTwo.Name = "lblFirstTwo"
        Me.lblFirstTwo.Size = New System.Drawing.Size(90, 30)
        Me.lblFirstTwo.TabIndex = 10
        Me.lblFirstTwo.Text = "First two letters of state:"
        '
        'mtbInput
        '
        Me.mtbInput.Location = New System.Drawing.Point(252, 37)
        Me.mtbInput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.mtbInput.Mask = "LL"
        Me.mtbInput.Name = "mtbInput"
        Me.mtbInput.Size = New System.Drawing.Size(24, 23)
        Me.mtbInput.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(156, 103)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(131, 33)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search For State"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(70, 225)
        Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(163, 23)
        Me.txtOutput.TabIndex = 8
        '
        'lstStates
        '
        Me.lstStates.FormattingEnabled = True
        Me.lstStates.ItemHeight = 15
        Me.lstStates.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Montana", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
        Me.lstStates.Location = New System.Drawing.Point(18, 33)
        Me.lstStates.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstStates.Name = "lstStates"
        Me.lstStates.Size = New System.Drawing.Size(116, 184)
        Me.lstStates.Sorted = True
        Me.lstStates.TabIndex = 7
        '
        'BinarySearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 270)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFirstTwo)
        Me.Controls.Add(Me.mtbInput)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lstStates)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "BinarySearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binary Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
  Friend WithEvents lblFirstTwo As Label
  Friend WithEvents mtbInput As MaskedTextBox
  Friend WithEvents btnSearch As Button
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents lstStates As ListBox
End Class
