<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryManagementForm
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnBills = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MICROLANDDataSet = New S_08_01_OrdersAndInventoryManagement.MICROLANDDataSet()
        Me.CustomersTableAdapter = New S_08_01_OrdersAndInventoryManagement.MICROLANDDataSetTableAdapters.CustomersTableAdapter()
        Me.InventoryTableAdapter = New S_08_01_OrdersAndInventoryManagement.MICROLANDDataSetTableAdapters.InventoryTableAdapter()
        Me.OrdersTableAdapter = New S_08_01_OrdersAndInventoryManagement.MICROLANDDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MICROLANDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 64)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(254, 277)
        Me.lstOutput.TabIndex = 7
        '
        'btnBills
        '
        Me.btnBills.Location = New System.Drawing.Point(179, 19)
        Me.btnBills.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBills.Name = "btnBills"
        Me.btnBills.Size = New System.Drawing.Size(87, 39)
        Me.btnBills.TabIndex = 6
        Me.btnBills.Text = "Bills for Today's Orders"
        '
        'btnStock
        '
        Me.btnStock.Location = New System.Drawing.Point(12, 19)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(87, 39)
        Me.btnStock.TabIndex = 5
        Me.btnStock.Text = "Out of Stock Items"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Orders"
        Me.BindingSource1.DataSource = Me.MICROLANDDataSet
        '
        'MICROLANDDataSet
        '
        Me.MICROLANDDataSet.DataSetName = "MICROLANDDataSet"
        Me.MICROLANDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'InventoryManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 349)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnBills)
        Me.Controls.Add(Me.btnStock)
        Me.Name = "InventoryManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MICROLANDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnBills As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MICROLANDDataSet As MICROLANDDataSet
    Friend WithEvents CustomersTableAdapter As MICROLANDDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents InventoryTableAdapter As MICROLANDDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents OrdersTableAdapter As MICROLANDDataSetTableAdapters.OrdersTableAdapter
End Class
