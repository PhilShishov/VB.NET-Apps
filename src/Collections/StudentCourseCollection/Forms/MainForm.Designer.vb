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
        Me.btnCourseInfo = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtFindId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lstStudents = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCourseInfo
        '
        Me.btnCourseInfo.Enabled = False
        Me.btnCourseInfo.Location = New System.Drawing.Point(330, 87)
        Me.btnCourseInfo.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnCourseInfo.Name = "btnCourseInfo"
        Me.btnCourseInfo.Size = New System.Drawing.Size(174, 29)
        Me.btnCourseInfo.TabIndex = 20
        Me.btnCourseInfo.Text = "Course Information"
        Me.btnCourseInfo.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(22, 234)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(99, 29)
        Me.btnFind.TabIndex = 22
        Me.btnFind.Text = "Find by ID"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtFindId
        '
        Me.txtFindId.Location = New System.Drawing.Point(24, 270)
        Me.txtFindId.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtFindId.Name = "txtFindId"
        Me.txtFindId.Size = New System.Drawing.Size(90, 23)
        Me.txtFindId.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Test average:"
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(141, 93)
        Me.txtAverage.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(63, 23)
        Me.txtAverage.TabIndex = 18
        '
        'lstStudents
        '
        Me.lstStudents.FormattingEnabled = True
        Me.lstStudents.ItemHeight = 15
        Me.lstStudents.Location = New System.Drawing.Point(154, 164)
        Me.lstStudents.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lstStudents.Name = "lstStudents"
        Me.lstStudents.Size = New System.Drawing.Size(383, 139)
        Me.lstStudents.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(22, 148)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 2)
        Me.Panel1.TabIndex = 24
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(22, 164)
        Me.btnView.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(99, 29)
        Me.btnView.TabIndex = 21
        Me.btnView.Text = "View All"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(330, 35)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 29)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add to Collection"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Student ID:"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(141, 22)
        Me.txtIdNumber.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(90, 23)
        Me.txtIdNumber.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Last name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(141, 58)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(162, 23)
        Me.txtLastName.TabIndex = 16
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 342)
        Me.Controls.Add(Me.btnCourseInfo)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFindId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.lstStudents)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastName)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Course Collection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCourseInfo As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtFindId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents lstStudents As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnView As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastName As TextBox
End Class
