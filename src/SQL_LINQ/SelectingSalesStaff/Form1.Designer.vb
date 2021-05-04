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
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Hire_DateLabel As System.Windows.Forms.Label
        Dim Full_TimeLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New SelectingSalesStaff.CompanyDataSet()
        Me.Hire_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Full_TimeCheckBox = New System.Windows.Forms.CheckBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SalesStaffTableAdapter = New SelectingSalesStaff.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        SalaryLabel = New System.Windows.Forms.Label()
        Hire_DateLabel = New System.Windows.Forms.Label()
        Full_TimeLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Location = New System.Drawing.Point(38, 164)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 18
        SalaryLabel.Text = "Salary:"
        '
        'Hire_DateLabel
        '
        Hire_DateLabel.AutoSize = True
        Hire_DateLabel.Location = New System.Drawing.Point(22, 131)
        Hire_DateLabel.Name = "Hire_DateLabel"
        Hire_DateLabel.Size = New System.Drawing.Size(55, 13)
        Hire_DateLabel.TabIndex = 16
        Hire_DateLabel.Text = "Hire Date:"
        '
        'Full_TimeLabel
        '
        Full_TimeLabel.AutoSize = True
        Full_TimeLabel.Location = New System.Drawing.Point(27, 106)
        Full_TimeLabel.Name = "Full_TimeLabel"
        Full_TimeLabel.Size = New System.Drawing.Size(52, 13)
        Full_TimeLabel.TabIndex = 14
        Full_TimeLabel.Text = "Full Time:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(58, 78)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 12
        IDLabel.Text = "ID:"
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(83, 161)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalaryTextBox.TabIndex = 19
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hire_DateDateTimePicker
        '
        Me.Hire_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.SalesStaffBindingSource, "Hire_Date", True))
        Me.Hire_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hire_DateDateTimePicker.Location = New System.Drawing.Point(83, 131)
        Me.Hire_DateDateTimePicker.Name = "Hire_DateDateTimePicker"
        Me.Hire_DateDateTimePicker.Size = New System.Drawing.Size(113, 20)
        Me.Hire_DateDateTimePicker.TabIndex = 17
        '
        'Full_TimeCheckBox
        '
        Me.Full_TimeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.SalesStaffBindingSource, "Full_Time", True))
        Me.Full_TimeCheckBox.Location = New System.Drawing.Point(85, 101)
        Me.Full_TimeCheckBox.Name = "Full_TimeCheckBox"
        Me.Full_TimeCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Full_TimeCheckBox.TabIndex = 15
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SalesStaffBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(85, 75)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(53, 20)
        Me.IDTextBox.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Select a Name:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SalesStaffBindingSource
        Me.ComboBox1.DisplayMember = "FullName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(30, 31)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "ID"
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 220)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Hire_DateLabel)
        Me.Controls.Add(Me.Hire_DateDateTimePicker)
        Me.Controls.Add(Full_TimeLabel)
        Me.Controls.Add(Me.Full_TimeCheckBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "MainForm"
        Me.Text = "Selecting Sales Staff"
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Hire_DateDateTimePicker As DateTimePicker
    Friend WithEvents Full_TimeCheckBox As CheckBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SalesStaffBindingSource As BindingSource
    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents SalesStaffTableAdapter As CompanyDataSetTableAdapters.SalesStaffTableAdapter
End Class
