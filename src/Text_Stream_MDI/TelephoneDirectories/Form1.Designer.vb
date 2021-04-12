<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhoneDirectoriesForm
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
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddListing = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtCurrentDirectory = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPhoneDirectories = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewDirectory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(144, 284)
        Me.dgvOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.Size = New System.Drawing.Size(317, 138)
        Me.dgvOutput.TabIndex = 28
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(366, 210)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(153, 54)
        Me.btnRemove.TabIndex = 27
        Me.btnRemove.Text = "Remove a Listing from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the Current Directory"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAddListing
        '
        Me.btnAddListing.Location = New System.Drawing.Point(115, 210)
        Me.btnAddListing.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAddListing.Name = "btnAddListing"
        Me.btnAddListing.Size = New System.Drawing.Size(153, 54)
        Me.btnAddListing.TabIndex = 26
        Me.btnAddListing.Text = "Add a Listing to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Current Directory"
        Me.btnAddListing.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(393, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(441, 119)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 23)
        Me.txtName.TabIndex = 23
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(441, 163)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(157, 23)
        Me.txtPhoneNumber.TabIndex = 22
        '
        'txtCurrentDirectory
        '
        Me.txtCurrentDirectory.Location = New System.Drawing.Point(441, 73)
        Me.txtCurrentDirectory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCurrentDirectory.Name = "txtCurrentDirectory"
        Me.txtCurrentDirectory.ReadOnly = True
        Me.txtCurrentDirectory.Size = New System.Drawing.Size(157, 23)
        Me.txtCurrentDirectory.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Current Phone Directory"
        '
        'lstPhoneDirectories
        '
        Me.lstPhoneDirectories.FormattingEnabled = True
        Me.lstPhoneDirectories.ItemHeight = 15
        Me.lstPhoneDirectories.Location = New System.Drawing.Point(18, 76)
        Me.lstPhoneDirectories.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstPhoneDirectories.Name = "lstPhoneDirectories"
        Me.lstPhoneDirectories.Size = New System.Drawing.Size(250, 109)
        Me.lstPhoneDirectories.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(51, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Phone Directories"
        '
        'btnNewDirectory
        '
        Me.btnNewDirectory.Location = New System.Drawing.Point(349, 10)
        Me.btnNewDirectory.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewDirectory.Name = "btnNewDirectory"
        Me.btnNewDirectory.Size = New System.Drawing.Size(250, 43)
        Me.btnNewDirectory.TabIndex = 17
        Me.btnNewDirectory.Text = "Create a New Phone Directory"
        Me.btnNewDirectory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Click on one of the existing phone directories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below to make it the current phon" &
    "e directory"
        '
        'PhoneDirectoriesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 444)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddListing)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtCurrentDirectory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstPhoneDirectories)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNewDirectory)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PhoneDirectoriesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telephone Directories"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnRemove As Button
  Friend WithEvents btnAddListing As Button
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtName As TextBox
  Friend WithEvents txtPhoneNumber As TextBox
  Friend WithEvents txtCurrentDirectory As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents lstPhoneDirectories As ListBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnNewDirectory As Button
  Friend WithEvents Label1 As Label
End Class
