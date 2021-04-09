<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.ComboBoxSender = New System.Windows.Forms.ComboBox()
        Me.ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxDataset = New ComboBoxApp.ComboBoxDataset()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ItemsTableAdapter = New ComboBoxApp.ComboBoxDatasetTableAdapters.ItemsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCustomer = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelSelectedItemIndex = New System.Windows.Forms.Label()
        Me.LabelSelectedItemText = New System.Windows.Forms.Label()
        Me.LabelSelectedItemValue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxSender
        '
        Me.ComboBoxSender.DataSource = Me.ItemsBindingSource
        Me.ComboBoxSender.DisplayMember = "Title"
        Me.ComboBoxSender.FormattingEnabled = True
        Me.ComboBoxSender.Location = New System.Drawing.Point(132, 101)
        Me.ComboBoxSender.Name = "ComboBoxSender"
        Me.ComboBoxSender.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxSender.TabIndex = 0
        Me.ComboBoxSender.ValueMember = "id"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sender:"
        '
        'ItemsTableAdapter
        '
        Me.ItemsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer:"
        '
        'ComboBoxCustomer
        '
        Me.ComboBoxCustomer.DataSource = Me.BindingSource1
        Me.ComboBoxCustomer.DisplayMember = "Title"
        Me.ComboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCustomer.FormattingEnabled = True
        Me.ComboBoxCustomer.Location = New System.Drawing.Point(132, 200)
        Me.ComboBoxCustomer.Name = "ComboBoxCustomer"
        Me.ComboBoxCustomer.Size = New System.Drawing.Size(121, 23)
        Me.ComboBoxCustomer.TabIndex = 2
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Items"
        Me.BindingSource1.DataSource = Me.ComboBoxDataset
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Load Items ASC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(223, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 26)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Load Items DESC"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Selected Item Text:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(277, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Selected Item Index:"
        '
        'LabelSelectedItemIndex
        '
        Me.LabelSelectedItemIndex.Location = New System.Drawing.Point(394, 89)
        Me.LabelSelectedItemIndex.Name = "LabelSelectedItemIndex"
        Me.LabelSelectedItemIndex.Size = New System.Drawing.Size(118, 15)
        Me.LabelSelectedItemIndex.TabIndex = 9
        Me.LabelSelectedItemIndex.Text = "-"
        '
        'LabelSelectedItemText
        '
        Me.LabelSelectedItemText.Location = New System.Drawing.Point(394, 115)
        Me.LabelSelectedItemText.Name = "LabelSelectedItemText"
        Me.LabelSelectedItemText.Size = New System.Drawing.Size(111, 15)
        Me.LabelSelectedItemText.TabIndex = 8
        Me.LabelSelectedItemText.Text = "-"
        '
        'LabelSelectedItemValue
        '
        Me.LabelSelectedItemValue.Location = New System.Drawing.Point(394, 140)
        Me.LabelSelectedItemValue.Name = "LabelSelectedItemValue"
        Me.LabelSelectedItemValue.Size = New System.Drawing.Size(111, 15)
        Me.LabelSelectedItemValue.TabIndex = 11
        Me.LabelSelectedItemValue.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(277, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Selected Item Value:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(149, 333)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 26)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Advance ComboBox Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(149, 365)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(175, 26)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "CRUD ComboBox Form"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(524, 399)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelSelectedItemValue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelSelectedItemIndex)
        Me.Controls.Add(Me.LabelSelectedItemText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxSender)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Items"
        CType(Me.ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxSender As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxDataset As ComboBoxDataset
    Friend WithEvents ItemsBindingSource As BindingSource
    Friend WithEvents ItemsTableAdapter As ComboBoxDatasetTableAdapters.ItemsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCustomer As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelSelectedItemIndex As Label
    Friend WithEvents LabelSelectedItemText As Label
    Friend WithEvents LabelSelectedItemValue As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
