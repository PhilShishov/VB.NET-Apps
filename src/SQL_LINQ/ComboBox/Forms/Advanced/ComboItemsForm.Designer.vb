<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboItemsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.del_Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxDataset = New ComboBoxApp.ComboBoxDataset()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.group_id_Label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button4 = New System.Windows.Forms.Button()
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.ItemsTableAdapter = New ComboBoxApp.ComboBoxDatasetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New ComboBoxApp.ComboBoxDatasetTableAdapters.TableAdapterManager()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.del_Column1, Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GroupIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(399, 448)
        Me.DataGridView1.TabIndex = 0
        '
        'del_Column1
        '
        Me.del_Column1.HeaderText = "Delete"
        Me.del_Column1.Name = "del_Column1"
        Me.del_Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.del_Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.del_Column1.Text = "Delete"
        Me.del_Column1.UseColumnTextForButtonValue = True
        Me.del_Column1.Width = 70
        '
        'ItemsBindingSource
        '
        Me.ItemsBindingSource.DataMember = "Items"
        Me.ItemsBindingSource.DataSource = Me.ComboBoxDataset
        '
        'ComboBoxDataset
        '
        Me.ComboBoxDataset.DataSetName = "ComboBoxDataset"
        Me.ComboBoxDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonSave
        '
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.Location = New System.Drawing.Point(12, 464)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(124, 31)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save && Exit"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExit.Location = New System.Drawing.Point(142, 464)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 31)
        Me.ButtonExit.TabIndex = 2
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-21, 457)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 1)
        Me.Panel1.TabIndex = 3
        '
        'group_id_Label1
        '
        Me.group_id_Label1.Location = New System.Drawing.Point(614, 29)
        Me.group_id_Label1.Name = "group_id_Label1"
        Me.group_id_Label1.Size = New System.Drawing.Size(82, 25)
        Me.group_id_Label1.TabIndex = 4
        Me.group_id_Label1.Text = "0"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(604, 129)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(107, 27)
        Me.button2.TabIndex = 8
        Me.button2.Text = "Columns Count"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(604, 96)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(107, 27)
        Me.button1.TabIndex = 7
        Me.button1.Text = "Rows Count"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(604, 193)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(107, 27)
        Me.button3.TabIndex = 9
        Me.button3.Text = "Row State"
        Me.button3.UseVisualStyleBackColor = True
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 15
        Me.listBox1.Location = New System.Drawing.Point(422, 32)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(149, 364)
        Me.listBox1.TabIndex = 11
        '
        'button4
        '
        Me.button4.Location = New System.Drawing.Point(422, 2)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(149, 27)
        Me.button4.TabIndex = 10
        Me.button4.Text = "All Row States"
        Me.button4.UseVisualStyleBackColor = True
        '
        'button5
        '
        Me.button5.Location = New System.Drawing.Point(431, 402)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(126, 27)
        Me.button5.TabIndex = 12
        Me.button5.Text = "Accept Changes"
        Me.button5.UseVisualStyleBackColor = True
        '
        'button6
        '
        Me.button6.Location = New System.Drawing.Point(577, 325)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(144, 27)
        Me.button6.TabIndex = 13
        Me.button6.Text = "Read column value"
        Me.button6.UseVisualStyleBackColor = True
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersInfoTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Me.ItemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = ComboBoxApp.ComboBoxDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(577, 369)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(144, 27)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Write column value"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'GroupIdDataGridViewTextBoxColumn
        '
        Me.GroupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId"
        Me.GroupIdDataGridViewTextBoxColumn.HeaderText = "GroupId"
        Me.GroupIdDataGridViewTextBoxColumn.Name = "GroupIdDataGridViewTextBoxColumn"
        '
        'ComboItemsForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(408, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.group_id_Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ComboItemsForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Items List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBoxDataset As ComboBoxDataset
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As ComboBoxDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents group_id_Label1 As Label
    Friend WithEvents TableAdapterManager As ComboBoxDatasetTableAdapters.TableAdapterManager
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents button3 As Button
    Private WithEvents listBox1 As ListBox
    Private WithEvents button4 As Button
    Private WithEvents button5 As Button
    Private WithEvents button6 As Button
    Private WithEvents Button7 As Button
    Friend WithEvents ItemtitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents del_Column1 As DataGridViewButtonColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
