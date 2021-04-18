<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboItemsCrudForm
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
        Dim LabelId As System.Windows.Forms.Label
        Dim LabelTitle As System.Windows.Forms.Label
        Dim LabelGroupId As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComboItemsCrudForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Item_titleLabel1 = New System.Windows.Forms.Label()
        Me.Group_idLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.parent_group_id = New System.Windows.Forms.Label()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxDataset = New ComboBoxApp.ComboBoxDataset()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsTableAdapter = New ComboBoxApp.ComboBoxDatasetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager = New ComboBoxApp.ComboBoxDatasetTableAdapters.TableAdapterManager()
        LabelId = New System.Windows.Forms.Label()
        LabelTitle = New System.Windows.Forms.Label()
        LabelGroupId = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelId
        '
        LabelId.AutoSize = True
        LabelId.Location = New System.Drawing.Point(525, 91)
        LabelId.Name = "LabelId"
        LabelId.Size = New System.Drawing.Size(25, 15)
        LabelId.TabIndex = 5
        LabelId.Text = "ID :"
        '
        'LabelTitle
        '
        LabelTitle.AutoSize = True
        LabelTitle.Location = New System.Drawing.Point(514, 114)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New System.Drawing.Size(36, 15)
        LabelTitle.TabIndex = 7
        LabelTitle.Text = "Title :"
        '
        'LabelGroupId
        '
        LabelGroupId.AutoSize = True
        LabelGroupId.Location = New System.Drawing.Point(490, 137)
        LabelGroupId.Name = "LabelGroupId"
        LabelGroupId.Size = New System.Drawing.Size(62, 15)
        LabelGroupId.TabIndex = 9
        LabelGroupId.Text = "Group ID :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(490, 238)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(93, 15)
        Label2.TabIndex = 12
        Label2.Text = "parent group id:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxTitle)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Title:"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Location = New System.Drawing.Point(89, 16)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(252, 21)
        Me.TextBoxTitle.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(367, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GroupIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(4, 57)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(448, 290)
        Me.DataGridView1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(222, 393)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Edit Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(337, 393)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 32)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "ID", True))
        Me.IdLabel1.Location = New System.Drawing.Point(552, 91)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 6
        Me.IdLabel1.Text = "Label2"
        '
        'Item_titleLabel1
        '
        Me.Item_titleLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "Title", True))
        Me.Item_titleLabel1.Location = New System.Drawing.Point(552, 114)
        Me.Item_titleLabel1.Name = "Item_titleLabel1"
        Me.Item_titleLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Item_titleLabel1.TabIndex = 8
        Me.Item_titleLabel1.Text = "Label2"
        '
        'Group_idLabel1
        '
        Me.Group_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "GroupId", True))
        Me.Group_idLabel1.Location = New System.Drawing.Point(552, 137)
        Me.Group_idLabel1.Name = "Group_idLabel1"
        Me.Group_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Group_idLabel1.TabIndex = 10
        Me.Group_idLabel1.Text = "Label2"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.ItemsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(10, 351)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(439, 25)
        Me.BindingNavigator1.TabIndex = 11
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'parent_group_id
        '
        Me.parent_group_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ItemsBindingSource, "GroupId", True))
        Me.parent_group_id.Location = New System.Drawing.Point(589, 238)
        Me.parent_group_id.Name = "parent_group_id"
        Me.parent_group_id.Size = New System.Drawing.Size(100, 23)
        Me.parent_group_id.TabIndex = 13
        Me.parent_group_id.Text = "Label2"
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
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupIdDataGridViewTextBoxColumn
        '
        Me.GroupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId"
        Me.GroupIdDataGridViewTextBoxColumn.HeaderText = "GroupId"
        Me.GroupIdDataGridViewTextBoxColumn.Name = "GroupIdDataGridViewTextBoxColumn"
        Me.GroupIdDataGridViewTextBoxColumn.ReadOnly = True
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
        'ComboItemsCrudForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(455, 445)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.parent_group_id)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(LabelId)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(LabelTitle)
        Me.Controls.Add(Me.Item_titleLabel1)
        Me.Controls.Add(LabelGroupId)
        Me.Controls.Add(Me.Group_idLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ComboItemsCrudForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBoxDataset As ComboBoxDataset
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As ComboBoxDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents ItemtitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As ComboBoxDatasetTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Item_titleLabel1 As Label
    Friend WithEvents Group_idLabel1 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents parent_group_id As Label
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
