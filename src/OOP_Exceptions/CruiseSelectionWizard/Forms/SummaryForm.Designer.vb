<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.lvwCruises = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.radZero = New System.Windows.Forms.RadioButton()
        Me.rad25 = New System.Windows.Forms.RadioButton()
        Me.rad50 = New System.Windows.Forms.RadioButton()
        Me.rad75 = New System.Windows.Forms.RadioButton()
        Me.rad100 = New System.Windows.Forms.RadioButton()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvwCruises
        '
        Me.lvwCruises.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCruises.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvwCruises.HideSelection = False
        Me.lvwCruises.Location = New System.Drawing.Point(4, 127)
        Me.lvwCruises.Name = "lvwCruises"
        Me.lvwCruises.Size = New System.Drawing.Size(628, 134)
        Me.lvwCruises.TabIndex = 31
        Me.lvwCruises.UseCompatibleStateImageBehavior = False
        Me.lvwCruises.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cruise Name"
        Me.ColumnHeader1.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Region"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Passengers"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Formal"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Avg Age"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'radZero
        '
        Me.radZero.AutoSize = True
        Me.radZero.Location = New System.Drawing.Point(355, 91)
        Me.radZero.Name = "radZero"
        Me.radZero.Size = New System.Drawing.Size(31, 17)
        Me.radZero.TabIndex = 30
        Me.radZero.Text = "0"
        Me.radZero.UseVisualStyleBackColor = True
        '
        'rad25
        '
        Me.rad25.AutoSize = True
        Me.rad25.Location = New System.Drawing.Point(274, 91)
        Me.rad25.Name = "rad25"
        Me.rad25.Size = New System.Drawing.Size(37, 17)
        Me.rad25.TabIndex = 29
        Me.rad25.Text = "25"
        Me.rad25.UseVisualStyleBackColor = True
        '
        'rad50
        '
        Me.rad50.AutoSize = True
        Me.rad50.Checked = True
        Me.rad50.Location = New System.Drawing.Point(181, 91)
        Me.rad50.Name = "rad50"
        Me.rad50.Size = New System.Drawing.Size(37, 17)
        Me.rad50.TabIndex = 28
        Me.rad50.TabStop = True
        Me.rad50.Text = "50"
        Me.rad50.UseVisualStyleBackColor = True
        '
        'rad75
        '
        Me.rad75.AutoSize = True
        Me.rad75.Location = New System.Drawing.Point(97, 91)
        Me.rad75.Name = "rad75"
        Me.rad75.Size = New System.Drawing.Size(37, 17)
        Me.rad75.TabIndex = 27
        Me.rad75.Text = "75"
        Me.rad75.UseVisualStyleBackColor = True
        '
        'rad100
        '
        Me.rad100.AutoSize = True
        Me.rad100.Location = New System.Drawing.Point(15, 91)
        Me.rad100.Name = "rad100"
        Me.rad100.Size = New System.Drawing.Size(43, 17)
        Me.rad100.TabIndex = 26
        Me.rad100.Text = "100"
        Me.rad100.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(12, 272)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(215, 13)
        Me.lblMessage.TabIndex = 25
        Me.lblMessage.Text = "Please select a cruise before viewing details"
        Me.lblMessage.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(4, 24)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(579, 51)
        Me.lblQuestion.TabIndex = 24
        Me.lblQuestion.Text = "Based on your preferences, the following are recommended cruises. The percentage " &
    "match with your criteria is shown on the left. Select the minimum matching perce" &
    "ntage to display:"
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPrevious.Location = New System.Drawing.Point(274, 267)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(60, 23)
        Me.btnPrevious.TabIndex = 23
        Me.btnPrevious.Text = "Prev"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(386, 267)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 314)
        Me.Controls.Add(Me.lvwCruises)
        Me.Controls.Add(Me.radZero)
        Me.Controls.Add(Me.rad25)
        Me.Controls.Add(Me.rad50)
        Me.Controls.Add(Me.rad75)
        Me.Controls.Add(Me.rad100)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Summary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvwCruises As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents radZero As RadioButton
    Friend WithEvents rad25 As RadioButton
    Friend WithEvents rad50 As RadioButton
    Friend WithEvents rad75 As RadioButton
    Friend WithEvents rad100 As RadioButton
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnClose As Button
End Class
