<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksForm
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
        Me.lstBooks = New System.Windows.Forms.ListBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuBook = New System.Windows.Forms.MenuItem()
        Me.mnuBookAdd = New System.Windows.Forms.MenuItem()
        Me.mnuBookDelete = New System.Windows.Forms.MenuItem()
        Me.mnuBookUpdate = New System.Windows.Forms.MenuItem()
        Me.mnuDisplay = New System.Windows.Forms.MenuItem()
        Me.mnuDisplayAll = New System.Windows.Forms.MenuItem()
        Me.mnuDisplayFiction = New System.Windows.Forms.MenuItem()
        Me.mnuDisplayNonfiction = New System.Windows.Forms.MenuItem()
        Me.mnuvalueFiction = New System.Windows.Forms.MenuItem()
        Me.mnuValuesAll = New System.Windows.Forms.MenuItem()
        Me.mnuValuesFiction = New System.Windows.Forms.MenuItem()
        Me.mnuValuesNonfiction = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'lstBooks
        '
        Me.lstBooks.FormattingEnabled = True
        Me.lstBooks.Location = New System.Drawing.Point(30, 12)
        Me.lstBooks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstBooks.Name = "lstBooks"
        Me.lstBooks.Size = New System.Drawing.Size(182, 238)
        Me.lstBooks.TabIndex = 11
        Me.lstBooks.TabStop = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuBook, Me.mnuDisplay, Me.mnuvalueFiction})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 0
        Me.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 1
        Me.mnuFileExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuBook
        '
        Me.mnuBook.Index = 1
        Me.mnuBook.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBookAdd, Me.mnuBookDelete, Me.mnuBookUpdate})
        Me.mnuBook.Text = "&Book"
        '
        'mnuBookAdd
        '
        Me.mnuBookAdd.Index = 0
        Me.mnuBookAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.mnuBookAdd.Text = "&Add"
        '
        'mnuBookDelete
        '
        Me.mnuBookDelete.Index = 1
        Me.mnuBookDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.mnuBookDelete.Text = "&Delete"
        '
        'mnuBookUpdate
        '
        Me.mnuBookUpdate.Index = 2
        Me.mnuBookUpdate.Shortcut = System.Windows.Forms.Shortcut.CtrlU
        Me.mnuBookUpdate.Text = "&Update"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Index = 2
        Me.mnuDisplay.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDisplayAll, Me.mnuDisplayFiction, Me.mnuDisplayNonfiction})
        Me.mnuDisplay.Text = "&Display"
        '
        'mnuDisplayAll
        '
        Me.mnuDisplayAll.Checked = True
        Me.mnuDisplayAll.Index = 0
        Me.mnuDisplayAll.RadioCheck = True
        Me.mnuDisplayAll.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.mnuDisplayAll.Text = "&All"
        '
        'mnuDisplayFiction
        '
        Me.mnuDisplayFiction.Index = 1
        Me.mnuDisplayFiction.RadioCheck = True
        Me.mnuDisplayFiction.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.mnuDisplayFiction.Text = "&Fiction"
        '
        'mnuDisplayNonfiction
        '
        Me.mnuDisplayNonfiction.Index = 2
        Me.mnuDisplayNonfiction.RadioCheck = True
        Me.mnuDisplayNonfiction.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuDisplayNonfiction.Text = "&Nonfiction"
        '
        'mnuvalueFiction
        '
        Me.mnuvalueFiction.Index = 3
        Me.mnuvalueFiction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuValuesAll, Me.mnuValuesFiction, Me.mnuValuesNonfiction})
        Me.mnuvalueFiction.Text = "&Values"
        '
        'mnuValuesAll
        '
        Me.mnuValuesAll.Checked = True
        Me.mnuValuesAll.Index = 0
        Me.mnuValuesAll.Text = "&All"
        '
        'mnuValuesFiction
        '
        Me.mnuValuesFiction.Index = 1
        Me.mnuValuesFiction.Text = "&Fiction"
        '
        'mnuValuesNonfiction
        '
        Me.mnuValuesNonfiction.Index = 2
        Me.mnuValuesNonfiction.Text = "&Nonfiction"
        '
        'BooksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 216)
        Me.Controls.Add(Me.lstBooks)
        Me.Menu = Me.MainMenu1
        Me.Name = "BooksForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books Inventory"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBooks As ListBox
  Friend WithEvents MainMenu1 As MainMenu
  Friend WithEvents mnuFile As MenuItem
  Friend WithEvents mnuFileSave As MenuItem
  Friend WithEvents mnuFileExit As MenuItem
  Friend WithEvents mnuBook As MenuItem
  Friend WithEvents mnuBookAdd As MenuItem
  Friend WithEvents mnuBookDelete As MenuItem
  Friend WithEvents mnuBookUpdate As MenuItem
  Friend WithEvents mnuDisplay As MenuItem
  Friend WithEvents mnuDisplayAll As MenuItem
  Friend WithEvents mnuDisplayFiction As MenuItem
  Friend WithEvents mnuDisplayNonfiction As MenuItem
  Friend WithEvents mnuvalueFiction As MenuItem
  Friend WithEvents mnuValuesAll As MenuItem
  Friend WithEvents mnuValuesFiction As MenuItem
  Friend WithEvents mnuValuesNonfiction As MenuItem
End Class
