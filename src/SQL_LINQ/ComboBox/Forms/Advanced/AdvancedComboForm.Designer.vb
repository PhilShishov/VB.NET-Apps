<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedComboForm
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
        Dim LabelId As System.Windows.Forms.Label
        Dim LabelSubject As System.Windows.Forms.Label
        Dim LabelRegDate As System.Windows.Forms.Label
        Dim LabelComment As System.Windows.Forms.Label
        Dim LabelSenderIncome As System.Windows.Forms.Label
        Dim LabelSenderDebt As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxPriority = New System.Windows.Forms.ComboBox()
        Me.CustomersInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxDataset = New ComboBoxApp.ComboBoxDataset()
        Me.PriorityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSender = New System.Windows.Forms.ComboBox()
        Me.SenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.GenderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboItemsTableAdapter = New ComboBoxApp.ComboBoxDatasetTableAdapters.ItemsTableAdapter()
        Me.ButtonAddSender = New System.Windows.Forms.Button()
        Me.ButtonAddPriority = New System.Windows.Forms.Button()
        Me.ButtonAddGender = New System.Windows.Forms.Button()
        Me.CustomersInfoTableAdapter = New ComboBoxApp.ComboBoxDatasetTableAdapters.CustomersInfoTableAdapter()
        Me.TableAdapterManager = New ComboBoxApp.ComboBoxDatasetTableAdapters.TableAdapterManager()
        Me.DataGridViewCustomersInfo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxSubject = New System.Windows.Forms.TextBox()
        Me.DateTimePickerRegDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxComment = New System.Windows.Forms.TextBox()
        Me.TextBoxSenderIncome = New System.Windows.Forms.TextBox()
        Me.TextBoxSenderDebt = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        LabelId = New System.Windows.Forms.Label()
        LabelSubject = New System.Windows.Forms.Label()
        LabelRegDate = New System.Windows.Forms.Label()
        LabelComment = New System.Windows.Forms.Label()
        LabelSenderIncome = New System.Windows.Forms.Label()
        LabelSenderDebt = New System.Windows.Forms.Label()
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriorityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GenderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewCustomersInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelId
        '
        LabelId.AutoSize = True
        LabelId.Location = New System.Drawing.Point(207, 23)
        LabelId.Name = "LabelId"
        LabelId.Size = New System.Drawing.Size(25, 15)
        LabelId.TabIndex = 12
        LabelId.Text = "ID :"
        '
        'LabelSubject
        '
        LabelSubject.AutoSize = True
        LabelSubject.Location = New System.Drawing.Point(178, 51)
        LabelSubject.Name = "LabelSubject"
        LabelSubject.Size = New System.Drawing.Size(54, 15)
        LabelSubject.TabIndex = 13
        LabelSubject.Text = "Subject :"
        '
        'LabelRegDate
        '
        LabelRegDate.AutoSize = True
        LabelRegDate.Location = New System.Drawing.Point(167, 79)
        LabelRegDate.Name = "LabelRegDate"
        LabelRegDate.Size = New System.Drawing.Size(65, 15)
        LabelRegDate.TabIndex = 14
        LabelRegDate.Text = "Reg Date :"
        '
        'LabelComment
        '
        LabelComment.AutoSize = True
        LabelComment.Location = New System.Drawing.Point(164, 194)
        LabelComment.Name = "LabelComment"
        LabelComment.Size = New System.Drawing.Size(67, 15)
        LabelComment.TabIndex = 16
        LabelComment.Text = "Comment :"
        '
        'LabelSenderIncome
        '
        LabelSenderIncome.AutoSize = True
        LabelSenderIncome.Location = New System.Drawing.Point(134, 224)
        LabelSenderIncome.Name = "LabelSenderIncome"
        LabelSenderIncome.Size = New System.Drawing.Size(97, 15)
        LabelSenderIncome.TabIndex = 18
        LabelSenderIncome.Text = "Sender Income :"
        '
        'LabelSenderDebt
        '
        LabelSenderDebt.AutoSize = True
        LabelSenderDebt.Location = New System.Drawing.Point(149, 251)
        LabelSenderDebt.Name = "LabelSenderDebt"
        LabelSenderDebt.Size = New System.Drawing.Size(82, 15)
        LabelSenderDebt.TabIndex = 20
        LabelSenderDebt.Text = "Sender Debt :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Priority :"
        '
        'ComboBoxPriority
        '
        Me.ComboBoxPriority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxPriority.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Priority", True))
        Me.ComboBoxPriority.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersInfoBindingSource, "PriorityId", True))
        Me.ComboBoxPriority.DataSource = Me.PriorityBindingSource1
        Me.ComboBoxPriority.DisplayMember = "Title"
        Me.ComboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPriority.FormattingEnabled = True
        Me.ComboBoxPriority.Location = New System.Drawing.Point(233, 131)
        Me.ComboBoxPriority.Name = "ComboBoxPriority"
        Me.ComboBoxPriority.Size = New System.Drawing.Size(198, 23)
        Me.ComboBoxPriority.TabIndex = 6
        Me.ComboBoxPriority.ValueMember = "ID"
        '
        'CustomersInfoBindingSource
        '
        Me.CustomersInfoBindingSource.DataMember = "CustomersInfo"
        Me.CustomersInfoBindingSource.DataSource = Me.ComboBoxDataset
        '
        'ComboBoxDataset
        '
        Me.ComboBoxDataset.DataSetName = "ComboBoxDataset"
        Me.ComboBoxDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PriorityBindingSource1
        '
        Me.PriorityBindingSource1.DataMember = "Items"
        Me.PriorityBindingSource1.DataSource = Me.ComboBoxDataset
        Me.PriorityBindingSource1.Filter = ""
        Me.PriorityBindingSource1.Sort = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sender :"
        '
        'ComboBoxSender
        '
        Me.ComboBoxSender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxSender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Sender", True))
        Me.ComboBoxSender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersInfoBindingSource, "SenderId", True))
        Me.ComboBoxSender.DataSource = Me.SenderBindingSource
        Me.ComboBoxSender.DisplayMember = "Title"
        Me.ComboBoxSender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSender.FormattingEnabled = True
        Me.ComboBoxSender.Location = New System.Drawing.Point(233, 102)
        Me.ComboBoxSender.Name = "ComboBoxSender"
        Me.ComboBoxSender.Size = New System.Drawing.Size(198, 23)
        Me.ComboBoxSender.TabIndex = 4
        Me.ComboBoxSender.ValueMember = "ID"
        '
        'SenderBindingSource
        '
        Me.SenderBindingSource.DataMember = "Items"
        Me.SenderBindingSource.DataSource = Me.ComboBoxDataset
        Me.SenderBindingSource.Filter = ""
        Me.SenderBindingSource.Sort = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender :"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Gender", True))
        Me.ComboBoxGender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CustomersInfoBindingSource, "GenderId", True))
        Me.ComboBoxGender.DataSource = Me.GenderBindingSource1
        Me.ComboBoxGender.DisplayMember = "Title"
        Me.ComboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Location = New System.Drawing.Point(233, 160)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(198, 23)
        Me.ComboBoxGender.TabIndex = 8
        Me.ComboBoxGender.ValueMember = "ID"
        '
        'GenderBindingSource1
        '
        Me.GenderBindingSource1.DataMember = "Items"
        Me.GenderBindingSource1.DataSource = Me.ComboBoxDataset
        Me.GenderBindingSource1.Filter = ""
        '
        'ComboItemsTableAdapter
        '
        Me.ComboItemsTableAdapter.ClearBeforeFill = True
        '
        'ButtonAddSender
        '
        Me.ButtonAddSender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddSender.Location = New System.Drawing.Point(437, 102)
        Me.ButtonAddSender.Name = "ButtonAddSender"
        Me.ButtonAddSender.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAddSender.TabIndex = 10
        Me.ButtonAddSender.Text = "+"
        Me.ButtonAddSender.UseVisualStyleBackColor = True
        '
        'ButtonAddPriority
        '
        Me.ButtonAddPriority.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddPriority.Location = New System.Drawing.Point(437, 131)
        Me.ButtonAddPriority.Name = "ButtonAddPriority"
        Me.ButtonAddPriority.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAddPriority.TabIndex = 11
        Me.ButtonAddPriority.Text = "+"
        Me.ButtonAddPriority.UseVisualStyleBackColor = True
        '
        'ButtonAddGender
        '
        Me.ButtonAddGender.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddGender.Location = New System.Drawing.Point(437, 161)
        Me.ButtonAddGender.Name = "ButtonAddGender"
        Me.ButtonAddGender.Size = New System.Drawing.Size(36, 23)
        Me.ButtonAddGender.TabIndex = 12
        Me.ButtonAddGender.Text = "+"
        Me.ButtonAddGender.UseVisualStyleBackColor = True
        '
        'CustomersInfoTableAdapter
        '
        Me.CustomersInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersInfoTableAdapter = Me.CustomersInfoTableAdapter
        Me.TableAdapterManager.ItemsTableAdapter = Me.ComboItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = ComboBoxApp.ComboBoxDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewCustomersInfo
        '
        Me.DataGridViewCustomersInfo.AutoGenerateColumns = False
        Me.DataGridViewCustomersInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewCustomersInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DataGridViewCustomersInfo.DataSource = Me.CustomersInfoBindingSource
        Me.DataGridViewCustomersInfo.Location = New System.Drawing.Point(10, 326)
        Me.DataGridViewCustomersInfo.Name = "DataGridViewCustomersInfo"
        Me.DataGridViewCustomersInfo.Size = New System.Drawing.Size(573, 220)
        Me.DataGridViewCustomersInfo.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Subject"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Subject"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RegDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RegDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SenderId"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SenderId"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Priority"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Priority"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PriorityId"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PriorityId"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GenderId"
        Me.DataGridViewTextBoxColumn9.HeaderText = "GenderId"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "SenderIncome"
        Me.DataGridViewTextBoxColumn11.HeaderText = "SenderIncome"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SenderDebt"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SenderDebt"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'TextBoxId
        '
        Me.TextBoxId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "ID", True))
        Me.TextBoxId.Location = New System.Drawing.Point(233, 20)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.ReadOnly = True
        Me.TextBoxId.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxId.TabIndex = 13
        '
        'TextBoxSubject
        '
        Me.TextBoxSubject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Subject", True))
        Me.TextBoxSubject.Location = New System.Drawing.Point(233, 48)
        Me.TextBoxSubject.Name = "TextBoxSubject"
        Me.TextBoxSubject.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxSubject.TabIndex = 14
        '
        'DateTimePickerRegDate
        '
        Me.DateTimePickerRegDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomersInfoBindingSource, "RegDate", True))
        Me.DateTimePickerRegDate.Location = New System.Drawing.Point(233, 75)
        Me.DateTimePickerRegDate.Name = "DateTimePickerRegDate"
        Me.DateTimePickerRegDate.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerRegDate.TabIndex = 15
        '
        'TextBoxComment
        '
        Me.TextBoxComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "Comment", True))
        Me.TextBoxComment.Location = New System.Drawing.Point(233, 191)
        Me.TextBoxComment.Name = "TextBoxComment"
        Me.TextBoxComment.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxComment.TabIndex = 17
        '
        'TextBoxSenderIncome
        '
        Me.TextBoxSenderIncome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "SenderIncome", True))
        Me.TextBoxSenderIncome.Location = New System.Drawing.Point(233, 221)
        Me.TextBoxSenderIncome.Name = "TextBoxSenderIncome"
        Me.TextBoxSenderIncome.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxSenderIncome.TabIndex = 19
        '
        'TextBoxSenderDebt
        '
        Me.TextBoxSenderDebt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersInfoBindingSource, "SenderDebt", True))
        Me.TextBoxSenderDebt.Location = New System.Drawing.Point(233, 248)
        Me.TextBoxSenderDebt.Name = "TextBoxSenderDebt"
        Me.TextBoxSenderDebt.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxSenderDebt.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(LabelSenderDebt)
        Me.GroupBox1.Controls.Add(Me.TextBoxSenderDebt)
        Me.GroupBox1.Controls.Add(LabelSenderIncome)
        Me.GroupBox1.Controls.Add(Me.TextBoxSenderIncome)
        Me.GroupBox1.Controls.Add(LabelComment)
        Me.GroupBox1.Controls.Add(Me.TextBoxComment)
        Me.GroupBox1.Controls.Add(LabelRegDate)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerRegDate)
        Me.GroupBox1.Controls.Add(LabelSubject)
        Me.GroupBox1.Controls.Add(Me.TextBoxSubject)
        Me.GroupBox1.Controls.Add(LabelId)
        Me.GroupBox1.Controls.Add(Me.TextBoxId)
        Me.GroupBox1.Controls.Add(Me.ButtonAddGender)
        Me.GroupBox1.Controls.Add(Me.ButtonAddPriority)
        Me.GroupBox1.Controls.Add(Me.ButtonAddSender)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxGender)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPriority)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxSender)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 276)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(479, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "+  CRUD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(479, 131)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "+  CRUD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(479, 102)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "+  CRUD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.Location = New System.Drawing.Point(12, 6)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(104, 31)
        Me.ButtonSave.TabIndex = 23
        Me.ButtonSave.Text = "Save Changes"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'AdvancedComboForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(588, 566)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewCustomersInfo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AdvancedComboForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced ComboBox Form"
        CType(Me.CustomersInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriorityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GenderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewCustomersInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPriority As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxSender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ComboBoxDataset As ComboBoxDataset
    Friend WithEvents ComboItemsTableAdapter As ComboBoxDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents PriorityBindingSource1 As BindingSource
    Friend WithEvents GenderBindingSource1 As BindingSource
    Friend WithEvents SenderBindingSource As BindingSource
    Friend WithEvents ButtonAddSender As Button
    Friend WithEvents ButtonAddPriority As Button
    Friend WithEvents ButtonAddGender As Button
    Friend WithEvents CustomersInfoBindingSource As BindingSource
    Friend WithEvents CustomersInfoTableAdapter As ComboBoxDatasetTableAdapters.CustomersInfoTableAdapter
    Friend WithEvents TableAdapterManager As ComboBoxDatasetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewCustomersInfo As DataGridView
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxSubject As TextBox
    Friend WithEvents DateTimePickerRegDate As DateTimePicker
    Friend WithEvents TextBoxComment As TextBox
    Friend WithEvents TextBoxSenderIncome As TextBox
    Friend WithEvents TextBoxSenderDebt As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
