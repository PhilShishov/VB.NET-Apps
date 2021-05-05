<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.dgrMembers = New System.Windows.Forms.DataGridView()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateJoinedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KarateMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KarateDataSet = New KarateMemberDates.KarateDataSet()
        Me.MembersTableAdapter = New KarateMemberDates.KarateDataSetTableAdapters.MembersTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpJoinDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radAfter = New System.Windows.Forms.RadioButton()
        Me.radBefore = New System.Windows.Forms.RadioButton()
        Me.btnAllMembers = New System.Windows.Forms.Button()
        CType(Me.dgrMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgrMembers
        '
        Me.dgrMembers.AllowUserToAddRows = False
        Me.dgrMembers.AllowUserToDeleteRows = False
        Me.dgrMembers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrMembers.AutoGenerateColumns = False
        Me.dgrMembers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LastNameDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.DateJoinedDataGridViewTextBoxColumn})
        Me.dgrMembers.DataSource = Me.KarateMembersBindingSource
        Me.dgrMembers.Location = New System.Drawing.Point(17, 138)
        Me.dgrMembers.Name = "dgrMembers"
        Me.dgrMembers.ReadOnly = True
        Me.dgrMembers.RowHeadersVisible = False
        Me.dgrMembers.Size = New System.Drawing.Size(443, 247)
        Me.dgrMembers.TabIndex = 12
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        Me.PhoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateJoinedDataGridViewTextBoxColumn
        '
        Me.DateJoinedDataGridViewTextBoxColumn.DataPropertyName = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.HeaderText = "Date_Joined"
        Me.DateJoinedDataGridViewTextBoxColumn.Name = "DateJoinedDataGridViewTextBoxColumn"
        Me.DateJoinedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KarateMembersBindingSource
        '
        Me.KarateMembersBindingSource.DataMember = "Members"
        Me.KarateMembersBindingSource.DataSource = Me.KarateDataSet
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "KarateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAllMembers)
        Me.Panel1.Controls.Add(Me.dtpJoinDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.radAfter)
        Me.Panel1.Controls.Add(Me.radBefore)
        Me.Panel1.Location = New System.Drawing.Point(17, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 88)
        Me.Panel1.TabIndex = 13
        '
        'dtpJoinDate
        '
        Me.dtpJoinDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpJoinDate.Location = New System.Drawing.Point(96, 13)
        Me.dtpJoinDate.Name = "dtpJoinDate"
        Me.dtpJoinDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpJoinDate.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "View members who joined..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a date:"
        '
        'radAfter
        '
        Me.radAfter.AutoSize = True
        Me.radAfter.Location = New System.Drawing.Point(272, 54)
        Me.radAfter.Name = "radAfter"
        Me.radAfter.Size = New System.Drawing.Size(118, 17)
        Me.radAfter.TabIndex = 3
        Me.radAfter.Text = "On or after this date"
        '
        'radBefore
        '
        Me.radBefore.AutoSize = True
        Me.radBefore.Checked = True
        Me.radBefore.Location = New System.Drawing.Point(158, 54)
        Me.radBefore.Name = "radBefore"
        Me.radBefore.Size = New System.Drawing.Size(99, 17)
        Me.radBefore.TabIndex = 2
        Me.radBefore.TabStop = True
        Me.radBefore.Text = "Before this date"
        '
        'btnAllMembers
        '
        Me.btnAllMembers.Location = New System.Drawing.Point(292, 12)
        Me.btnAllMembers.Name = "btnAllMembers"
        Me.btnAllMembers.Size = New System.Drawing.Size(75, 23)
        Me.btnAllMembers.TabIndex = 6
        Me.btnAllMembers.Text = "All Members"
        Me.btnAllMembers.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgrMembers)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karate Member Dates"
        CType(Me.dgrMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgrMembers As DataGridView
    Friend WithEvents KarateMembersBindingSource As BindingSource
    Friend WithEvents KarateDataSet As KarateDataSet
    Friend WithEvents MembersTableAdapter As KarateDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateJoinedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpJoinDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents radAfter As RadioButton
    Friend WithEvents radBefore As RadioButton
    Friend WithEvents btnAllMembers As Button
End Class
