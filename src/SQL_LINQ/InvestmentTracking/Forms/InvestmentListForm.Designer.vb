<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvestmentListForm
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
        Me.dgvInvestmentList = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TickerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvestmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PricePerShareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumSharesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvestmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvestTrackDbDataSet = New InvestmentTracking.InvestTrackDbDataSet()
        Me.InvestmentsTableAdapter = New InvestmentTracking.InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter()
        CType(Me.dgvInvestmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvInvestmentList
        '
        Me.dgvInvestmentList.AllowUserToAddRows = False
        Me.dgvInvestmentList.AllowUserToDeleteRows = False
        Me.dgvInvestmentList.AutoGenerateColumns = False
        Me.dgvInvestmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvestmentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TickerDataGridViewTextBoxColumn, Me.InvestmentTypeDataGridViewTextBoxColumn, Me.PricePerShareDataGridViewTextBoxColumn, Me.PurchaseDateDataGridViewTextBoxColumn, Me.NumSharesDataGridViewTextBoxColumn})
        Me.dgvInvestmentList.DataSource = Me.InvestmentsBindingSource
        Me.dgvInvestmentList.Location = New System.Drawing.Point(12, 12)
        Me.dgvInvestmentList.Name = "dgvInvestmentList"
        Me.dgvInvestmentList.ReadOnly = True
        Me.dgvInvestmentList.Size = New System.Drawing.Size(647, 299)
        Me.dgvInvestmentList.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TickerDataGridViewTextBoxColumn
        '
        Me.TickerDataGridViewTextBoxColumn.DataPropertyName = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.HeaderText = "Ticker"
        Me.TickerDataGridViewTextBoxColumn.Name = "TickerDataGridViewTextBoxColumn"
        Me.TickerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvestmentTypeDataGridViewTextBoxColumn
        '
        Me.InvestmentTypeDataGridViewTextBoxColumn.DataPropertyName = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.HeaderText = "InvestmentType"
        Me.InvestmentTypeDataGridViewTextBoxColumn.Name = "InvestmentTypeDataGridViewTextBoxColumn"
        Me.InvestmentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PricePerShareDataGridViewTextBoxColumn
        '
        Me.PricePerShareDataGridViewTextBoxColumn.DataPropertyName = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.HeaderText = "PricePerShare"
        Me.PricePerShareDataGridViewTextBoxColumn.Name = "PricePerShareDataGridViewTextBoxColumn"
        Me.PricePerShareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PurchaseDateDataGridViewTextBoxColumn
        '
        Me.PurchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate"
        Me.PurchaseDateDataGridViewTextBoxColumn.Name = "PurchaseDateDataGridViewTextBoxColumn"
        Me.PurchaseDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumSharesDataGridViewTextBoxColumn
        '
        Me.NumSharesDataGridViewTextBoxColumn.DataPropertyName = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.HeaderText = "NumShares"
        Me.NumSharesDataGridViewTextBoxColumn.Name = "NumSharesDataGridViewTextBoxColumn"
        Me.NumSharesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InvestmentsBindingSource
        '
        Me.InvestmentsBindingSource.DataMember = "Investments"
        Me.InvestmentsBindingSource.DataSource = Me.InvestTrackDbDataSet
        '
        'InvestTrackDbDataSet
        '
        Me.InvestTrackDbDataSet.DataSetName = "InvestTrackDbDataSet"
        Me.InvestTrackDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvestmentsTableAdapter
        '
        Me.InvestmentsTableAdapter.ClearBeforeFill = True
        '
        'InvestmentListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 328)
        Me.Controls.Add(Me.dgvInvestmentList)
        Me.Name = "InvestmentListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investment List"
        CType(Me.dgvInvestmentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvestTrackDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvInvestmentList As DataGridView
    Friend WithEvents InvestTrackDbDataSet As InvestTrackDbDataSet
    Friend WithEvents InvestmentsBindingSource As BindingSource
    Friend WithEvents InvestmentsTableAdapter As InvestTrackDbDataSetTableAdapters.InvestmentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TickerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InvestmentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PricePerShareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumSharesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
