<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommitteeForm
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCommMembers = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCommittees = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAllMembers = New System.Windows.Forms.ListBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 350)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(555, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.Location = New System.Drawing.Point(250, 188)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(68, 31)
        Me.btnRemove.TabIndex = 23
        Me.btnRemove.Text = "<--"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(250, 134)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 31)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = "-->"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(344, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Current Members"
        '
        'lstCommMembers
        '
        Me.lstCommMembers.FormattingEnabled = True
        Me.lstCommMembers.ItemHeight = 15
        Me.lstCommMembers.Location = New System.Drawing.Point(348, 83)
        Me.lstCommMembers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstCommMembers.Name = "lstCommMembers"
        Me.lstCommMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstCommMembers.Size = New System.Drawing.Size(163, 184)
        Me.lstCommMembers.Sorted = True
        Me.lstCommMembers.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "General Member List"
        '
        'cboCommittees
        '
        Me.cboCommittees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommittees.FormattingEnabled = True
        Me.cboCommittees.Items.AddRange(New Object() {"Activities", "Community Services", "Executive", "Membership", "Programming Team", "Scholarship", "Sports", "Travel", "Volunteer Tutoring", "", ""})
        Me.cboCommittees.Location = New System.Drawing.Point(222, 13)
        Me.cboCommittees.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cboCommittees.Name = "cboCommittees"
        Me.cboCommittees.Size = New System.Drawing.Size(240, 23)
        Me.cboCommittees.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Select a Committee"
        '
        'lstAllMembers
        '
        Me.lstAllMembers.FormattingEnabled = True
        Me.lstAllMembers.ItemHeight = 15
        Me.lstAllMembers.Items.AddRange(New Object() {"Adams, Ben", "Baker, Sam", "Chong, Anne", "Davis, Sandra", "Easterlin, John", "Fernandez, Jose", "Fox, Barbara", "Gomez, Ignacio", "Halperin, James", "Iams, Jeffrey", "Johnson, Beth", "Kenwood, Brian", "Saint Pierre, Justin"})
        Me.lstAllMembers.Location = New System.Drawing.Point(31, 83)
        Me.lstAllMembers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstAllMembers.Name = "lstAllMembers"
        Me.lstAllMembers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAllMembers.Size = New System.Drawing.Size(182, 139)
        Me.lstAllMembers.TabIndex = 16
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(230, 292)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(88, 31)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'CommitteeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 372)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstCommMembers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboCommittees)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstAllMembers)
        Me.Controls.Add(Me.btnQuit)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "CommitteeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Club Committee Organizer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lstCommMembers As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboCommittees As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAllMembers As ListBox
    Friend WithEvents btnQuit As Button
End Class
