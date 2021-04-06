<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BasicSkinForm
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.ButtonDark = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ButtonLight = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialCheckBox2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialRadioButton4 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialCheckBox3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.MaterialCheckBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.ForeColor = System.Drawing.Color.Black
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(253, 9)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(150, 30)
        Me.MaterialCheckBox1.TabIndex = 9
        Me.MaterialCheckBox1.Text = "MaterialCheckBox1"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = False
        Me.MaterialCheckBox1.Visible = False
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(253, 57)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton1.TabIndex = 10
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "MaterialRadioButton1"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonDark
        '
        Me.ButtonDark.AutoSize = True
        Me.ButtonDark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonDark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDark.Depth = 0
        Me.ButtonDark.Location = New System.Drawing.Point(399, 26)
        Me.ButtonDark.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonDark.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonDark.Name = "ButtonDark"
        Me.ButtonDark.Primary = True
        Me.ButtonDark.Size = New System.Drawing.Size(47, 36)
        Me.ButtonDark.TabIndex = 11
        Me.ButtonDark.Text = "Dark"
        Me.ButtonDark.UseVisualStyleBackColor = True
        '
        'ButtonLight
        '
        Me.ButtonLight.AutoSize = True
        Me.ButtonLight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLight.Depth = 0
        Me.ButtonLight.Location = New System.Drawing.Point(344, 26)
        Me.ButtonLight.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ButtonLight.MouseState = MaterialSkin.MouseState.HOVER
        Me.ButtonLight.Name = "ButtonLight"
        Me.ButtonLight.Primary = True
        Me.ButtonLight.Size = New System.Drawing.Size(51, 36)
        Me.ButtonLight.TabIndex = 12
        Me.ButtonLight.Text = "Light"
        Me.ButtonLight.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaterialRaisedButton2.ForeColor = System.Drawing.Color.Red
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(220, 430)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(105, 34)
        Me.MaterialRaisedButton2.TabIndex = 13
        Me.MaterialRaisedButton2.Text = "Save"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(349, 428)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = True
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(46, 36)
        Me.MaterialFlatButton1.TabIndex = 14
        Me.MaterialFlatButton1.Text = "Save"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(5, 79)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(441, 32)
        Me.MaterialTabSelector1.TabIndex = 15
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.MaterialTabControl1.Location = New System.Drawing.Point(8, 111)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(438, 118)
        Me.MaterialTabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialRadioButton2)
        Me.TabPage1.Controls.Add(Me.MaterialCheckBox1)
        Me.TabPage1.Controls.Add(Me.MaterialRadioButton1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(430, 80)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(28, 57)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton2.TabIndex = 15
        Me.MaterialRadioButton2.TabStop = True
        Me.MaterialRadioButton2.Text = "MaterialRadioButton2"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(430, 80)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "About"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "First Name"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(106, 249)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(309, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 17
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(15, 248)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel2.TabIndex = 18
        Me.MaterialLabel2.Text = "First Name:"
        '
        'MaterialRadioButton3
        '
        Me.MaterialRadioButton3.AutoSize = True
        Me.MaterialRadioButton3.Checked = True
        Me.MaterialRadioButton3.Depth = 0
        Me.MaterialRadioButton3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton3.Location = New System.Drawing.Point(45, 283)
        Me.MaterialRadioButton3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton3.Name = "MaterialRadioButton3"
        Me.MaterialRadioButton3.Ripple = False
        Me.MaterialRadioButton3.Size = New System.Drawing.Size(158, 20)
        Me.MaterialRadioButton3.TabIndex = 19
        Me.MaterialRadioButton3.TabStop = True
        Me.MaterialRadioButton3.Text = "MaterialRadioButton3"
        Me.MaterialRadioButton3.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox2
        '
        Me.MaterialCheckBox2.AutoSize = True
        Me.MaterialCheckBox2.Checked = True
        Me.MaterialCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox2.Depth = 0
        Me.MaterialCheckBox2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox2.Location = New System.Drawing.Point(238, 271)
        Me.MaterialCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox2.Name = "MaterialCheckBox2"
        Me.MaterialCheckBox2.Ripple = True
        Me.MaterialCheckBox2.Size = New System.Drawing.Size(150, 30)
        Me.MaterialCheckBox2.TabIndex = 20
        Me.MaterialCheckBox2.Text = "MaterialCheckBox2"
        Me.MaterialCheckBox2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton4
        '
        Me.MaterialRadioButton4.AutoSize = True
        Me.MaterialRadioButton4.Depth = 0
        Me.MaterialRadioButton4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton4.Location = New System.Drawing.Point(40, 303)
        Me.MaterialRadioButton4.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton4.Name = "MaterialRadioButton4"
        Me.MaterialRadioButton4.Ripple = True
        Me.MaterialRadioButton4.Size = New System.Drawing.Size(163, 30)
        Me.MaterialRadioButton4.TabIndex = 21
        Me.MaterialRadioButton4.Text = "MaterialRadioButton4"
        Me.MaterialRadioButton4.UseVisualStyleBackColor = True
        '
        'MaterialCheckBox3
        '
        Me.MaterialCheckBox3.AutoSize = True
        Me.MaterialCheckBox3.Checked = True
        Me.MaterialCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MaterialCheckBox3.Depth = 0
        Me.MaterialCheckBox3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox3.Location = New System.Drawing.Point(238, 304)
        Me.MaterialCheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox3.Name = "MaterialCheckBox3"
        Me.MaterialCheckBox3.Ripple = True
        Me.MaterialCheckBox3.Size = New System.Drawing.Size(150, 30)
        Me.MaterialCheckBox3.TabIndex = 22
        Me.MaterialCheckBox3.Text = "MaterialCheckBox3"
        Me.MaterialCheckBox3.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(2, 410)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(458, 1)
        Me.MaterialDivider1.TabIndex = 23
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip2"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(94, 48)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(120, 362)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(108, 19)
        Me.MaterialLabel1.TabIndex = 24
        Me.MaterialLabel1.Text = "MaterialLabel1"
        '
        'SkinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(449, 476)
        Me.ContextMenuStrip = Me.MaterialContextMenuStrip1
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialCheckBox3)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialRaisedButton2)
        Me.Controls.Add(Me.MaterialRadioButton4)
        Me.Controls.Add(Me.MaterialCheckBox2)
        Me.Controls.Add(Me.MaterialRadioButton3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.ButtonLight)
        Me.Controls.Add(Me.ButtonDark)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "SkinForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skin"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents ButtonDark As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ButtonLight As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialCheckBox2 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialRadioButton4 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialCheckBox3 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
