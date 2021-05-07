<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewAppointment
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
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkLicensed = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboRepairType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(21, 208)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(422, 28)
        Me.lblStatus.TabIndex = 27
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(239, 253)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 26)
        Me.btnCancel.TabIndex = 26
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(145, 253)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 26)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkLicensed
        '
        Me.chkLicensed.AutoSize = True
        Me.chkLicensed.Location = New System.Drawing.Point(275, 78)
        Me.chkLicensed.Name = "chkLicensed"
        Me.chkLicensed.Size = New System.Drawing.Size(106, 17)
        Me.chkLicensed.TabIndex = 22
        Me.chkLicensed.Text = "Must be licensed"
        Me.chkLicensed.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Description (0-100 chars)"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(22, 134)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(421, 62)
        Me.txtDescription.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Repair type"
        '
        'cboRepairType
        '
        Me.cboRepairType.FormattingEnabled = True
        Me.cboRepairType.Location = New System.Drawing.Point(109, 75)
        Me.cboRepairType.Name = "cboRepairType"
        Me.cboRepairType.Size = New System.Drawing.Size(147, 21)
        Me.cboRepairType.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Customer"
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(275, 28)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(168, 21)
        Me.cboCustomer.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Date"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(145, 28)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(100, 20)
        Me.txtTime.TabIndex = 17
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(22, 28)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(117, 20)
        Me.dtpDate.TabIndex = 15
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'frmNewAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 304)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkLicensed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboRepairType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.dtpDate)
        Me.Name = "frmNewAppointment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Appointment"
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents chkLicensed As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboRepairType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTime As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents errProvider As ErrorProvider
End Class
