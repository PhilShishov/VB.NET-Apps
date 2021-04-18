<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeBookForm
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
        Dim FinalExamLabel As System.Windows.Forms.Label
        Dim SecondExamLabel As System.Windows.Forms.Label
        Dim FirstExamLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeBookForm))
        Me.dgvOutput = New System.Windows.Forms.DataGridView()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtExamFinal = New System.Windows.Forms.TextBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradebookDataSet = New S_08_02_GradeBook.GradebookDataSet()
        Me.txtExam2 = New System.Windows.Forms.TextBox()
        Me.txtExam1 = New System.Windows.Forms.TextBox()
        Me.txtStudentId = New System.Windows.Forms.TextBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradesTableAdapter = New S_08_02_GradeBook.GradebookDataSetTableAdapters.GradesTableAdapter()
        Me.StudentsTableAdapter = New S_08_02_GradeBook.GradebookDataSetTableAdapters.StudentsTableAdapter()
        FinalExamLabel = New System.Windows.Forms.Label()
        SecondExamLabel = New System.Windows.Forms.Label()
        FirstExamLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FinalExamLabel
        '
        FinalExamLabel.AutoSize = True
        FinalExamLabel.Location = New System.Drawing.Point(22, 199)
        FinalExamLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FinalExamLabel.Name = "FinalExamLabel"
        FinalExamLabel.Size = New System.Drawing.Size(58, 13)
        FinalExamLabel.TabIndex = 17
        FinalExamLabel.Text = "final Exam:"
        '
        'SecondExamLabel
        '
        SecondExamLabel.AutoSize = True
        SecondExamLabel.Location = New System.Drawing.Point(7, 165)
        SecondExamLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SecondExamLabel.Name = "SecondExamLabel"
        SecondExamLabel.Size = New System.Drawing.Size(74, 13)
        SecondExamLabel.TabIndex = 15
        SecondExamLabel.Text = "second Exam:"
        '
        'FirstExamLabel
        '
        FirstExamLabel.AutoSize = True
        FirstExamLabel.Location = New System.Drawing.Point(22, 132)
        FirstExamLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstExamLabel.Name = "FirstExamLabel"
        FirstExamLabel.Size = New System.Drawing.Size(55, 13)
        FirstExamLabel.TabIndex = 13
        FirstExamLabel.Text = "first Exam:"
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(19, 98)
        StudentIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(59, 13)
        StudentIDLabel.TabIndex = 11
        StudentIDLabel.Text = "student ID:"
        '
        'dgvOutput
        '
        Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutput.Location = New System.Drawing.Point(161, 98)
        Me.dgvOutput.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOutput.Name = "dgvOutput"
        Me.dgvOutput.RowHeadersVisible = False
        Me.dgvOutput.RowTemplate.Height = 24
        Me.dgvOutput.Size = New System.Drawing.Size(176, 119)
        Me.dgvOutput.TabIndex = 20
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(162, 53)
        Me.btnDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(175, 29)
        Me.btnDisplay.TabIndex = 19
        Me.btnDisplay.Text = "Display Student Grades"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtExamFinal
        '
        Me.txtExamFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "finalExam", True))
        Me.txtExamFinal.Location = New System.Drawing.Point(83, 196)
        Me.txtExamFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExamFinal.Name = "txtExamFinal"
        Me.txtExamFinal.Size = New System.Drawing.Size(34, 20)
        Me.txtExamFinal.TabIndex = 18
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "Grades"
        Me.BindingSource2.DataSource = Me.GradebookDataSet
        '
        'GradebookDataSet
        '
        Me.GradebookDataSet.DataSetName = "GradebookDataSet"
        Me.GradebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtExam2
        '
        Me.txtExam2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "secondExam", True))
        Me.txtExam2.Location = New System.Drawing.Point(83, 163)
        Me.txtExam2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExam2.Name = "txtExam2"
        Me.txtExam2.Size = New System.Drawing.Size(34, 20)
        Me.txtExam2.TabIndex = 16
        '
        'txtExam1
        '
        Me.txtExam1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "firstExam", True))
        Me.txtExam1.Location = New System.Drawing.Point(83, 129)
        Me.txtExam1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExam1.Name = "txtExam1"
        Me.txtExam1.Size = New System.Drawing.Size(34, 20)
        Me.txtExam1.TabIndex = 14
        '
        'txtStudentId
        '
        Me.txtStudentId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource2, "studentID", True))
        Me.txtStudentId.Location = New System.Drawing.Point(83, 96)
        Me.txtStudentId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(64, 20)
        Me.txtStudentId.TabIndex = 12
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.BindingSource2
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.btnUpdate})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(353, 25)
        Me.BindingNavigator1.TabIndex = 21
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
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
        'btnUpdate
        '
        Me.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(49, 22)
        Me.btnUpdate.Text = "Update"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Students"
        Me.BindingSource1.DataSource = Me.GradebookDataSet
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'GradeBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 234)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.dgvOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(FinalExamLabel)
        Me.Controls.Add(Me.txtExamFinal)
        Me.Controls.Add(SecondExamLabel)
        Me.Controls.Add(Me.txtExam2)
        Me.Controls.Add(FirstExamLabel)
        Me.Controls.Add(Me.txtExam1)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.txtStudentId)
        Me.Name = "GradeBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Boook"
        CType(Me.dgvOutput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradebookDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnDisplay As Button
  Friend WithEvents txtExamFinal As TextBox
  Friend WithEvents txtExam2 As TextBox
  Friend WithEvents txtExam1 As TextBox
  Friend WithEvents txtStudentId As TextBox
  Friend WithEvents BindingNavigator1 As BindingNavigator
  Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
  Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
  Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
  Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
  Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
  Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
  Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
  Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
  Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
  Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
  Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
  Friend WithEvents BindingSource1 As BindingSource
  Friend WithEvents GradebookDataSet As GradebookDataSet
  Friend WithEvents GradesTableAdapter As GradebookDataSetTableAdapters.GradesTableAdapter
  Friend WithEvents StudentsTableAdapter As GradebookDataSetTableAdapters.StudentsTableAdapter
  Friend WithEvents btnUpdate As ToolStripButton
  Friend WithEvents BindingSource2 As BindingSource
End Class
