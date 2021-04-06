<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModernSkinForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModernSkinForm))
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialSingleLineTextField10 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField9 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField8 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.MaterialRaisedButton4 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRaisedButton3 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(2, 70)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(371, 37)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(2, 104)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(359, 422)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.MaterialRaisedButton2)
        Me.TabPage1.Controls.Add(Me.MaterialRaisedButton1)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Controls.Add(Me.MaterialRadioButton2)
        Me.TabPage1.Controls.Add(Me.MaterialRadioButton1)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField10)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField9)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField8)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField7)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField6)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField5)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField4)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField3)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.TabPage1.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.TabPage1.Controls.Add(Me.MaterialDivider1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(351, 394)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "My Settings"
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(16, 369)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(160, 30)
        Me.MaterialRaisedButton2.TabIndex = 14
        Me.MaterialRaisedButton2.Text = "Save Changes F5"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(259, 369)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(75, 30)
        Me.MaterialRaisedButton1.TabIndex = 13
        Me.MaterialRaisedButton1.Text = "Exit"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(16, 317)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel1.TabIndex = 12
        Me.MaterialLabel1.Text = "Language:"
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(207, 313)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(71, 30)
        Me.MaterialRadioButton2.TabIndex = 11
        Me.MaterialRadioButton2.Text = "French"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Checked = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(102, 313)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(74, 30)
        Me.MaterialRadioButton1.TabIndex = 10
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "English"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField10
        '
        Me.MaterialSingleLineTextField10.Depth = 0
        Me.MaterialSingleLineTextField10.Hint = "Web Site"
        Me.MaterialSingleLineTextField10.Location = New System.Drawing.Point(16, 278)
        Me.MaterialSingleLineTextField10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField10.Name = "MaterialSingleLineTextField10"
        Me.MaterialSingleLineTextField10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField10.SelectedText = ""
        Me.MaterialSingleLineTextField10.SelectionLength = 0
        Me.MaterialSingleLineTextField10.SelectionStart = 0
        Me.MaterialSingleLineTextField10.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField10.TabIndex = 9
        Me.MaterialSingleLineTextField10.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField9
        '
        Me.MaterialSingleLineTextField9.Depth = 0
        Me.MaterialSingleLineTextField9.Hint = "Email"
        Me.MaterialSingleLineTextField9.Location = New System.Drawing.Point(16, 249)
        Me.MaterialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField9.Name = "MaterialSingleLineTextField9"
        Me.MaterialSingleLineTextField9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField9.SelectedText = ""
        Me.MaterialSingleLineTextField9.SelectionLength = 0
        Me.MaterialSingleLineTextField9.SelectionStart = 0
        Me.MaterialSingleLineTextField9.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField9.TabIndex = 8
        Me.MaterialSingleLineTextField9.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField8
        '
        Me.MaterialSingleLineTextField8.Depth = 0
        Me.MaterialSingleLineTextField8.Hint = "Address"
        Me.MaterialSingleLineTextField8.Location = New System.Drawing.Point(16, 220)
        Me.MaterialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField8.Name = "MaterialSingleLineTextField8"
        Me.MaterialSingleLineTextField8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField8.SelectedText = ""
        Me.MaterialSingleLineTextField8.SelectionLength = 0
        Me.MaterialSingleLineTextField8.SelectionStart = 0
        Me.MaterialSingleLineTextField8.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField8.TabIndex = 7
        Me.MaterialSingleLineTextField8.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField7
        '
        Me.MaterialSingleLineTextField7.Depth = 0
        Me.MaterialSingleLineTextField7.Hint = "Activity"
        Me.MaterialSingleLineTextField7.Location = New System.Drawing.Point(16, 191)
        Me.MaterialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField7.Name = "MaterialSingleLineTextField7"
        Me.MaterialSingleLineTextField7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField7.SelectedText = ""
        Me.MaterialSingleLineTextField7.SelectionLength = 0
        Me.MaterialSingleLineTextField7.SelectionStart = 0
        Me.MaterialSingleLineTextField7.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField7.TabIndex = 6
        Me.MaterialSingleLineTextField7.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField6
        '
        Me.MaterialSingleLineTextField6.Depth = 0
        Me.MaterialSingleLineTextField6.Hint = "Fax"
        Me.MaterialSingleLineTextField6.Location = New System.Drawing.Point(16, 162)
        Me.MaterialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField6.Name = "MaterialSingleLineTextField6"
        Me.MaterialSingleLineTextField6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField6.SelectedText = ""
        Me.MaterialSingleLineTextField6.SelectionLength = 0
        Me.MaterialSingleLineTextField6.SelectionStart = 0
        Me.MaterialSingleLineTextField6.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField6.TabIndex = 5
        Me.MaterialSingleLineTextField6.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField5
        '
        Me.MaterialSingleLineTextField5.Depth = 0
        Me.MaterialSingleLineTextField5.Hint = "Cell Number"
        Me.MaterialSingleLineTextField5.Location = New System.Drawing.Point(16, 133)
        Me.MaterialSingleLineTextField5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField5.Name = "MaterialSingleLineTextField5"
        Me.MaterialSingleLineTextField5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField5.SelectedText = ""
        Me.MaterialSingleLineTextField5.SelectionLength = 0
        Me.MaterialSingleLineTextField5.SelectionStart = 0
        Me.MaterialSingleLineTextField5.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField5.TabIndex = 4
        Me.MaterialSingleLineTextField5.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField4
        '
        Me.MaterialSingleLineTextField4.Depth = 0
        Me.MaterialSingleLineTextField4.Hint = "Tel"
        Me.MaterialSingleLineTextField4.Location = New System.Drawing.Point(16, 104)
        Me.MaterialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField4.Name = "MaterialSingleLineTextField4"
        Me.MaterialSingleLineTextField4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField4.SelectedText = ""
        Me.MaterialSingleLineTextField4.SelectionLength = 0
        Me.MaterialSingleLineTextField4.SelectionStart = 0
        Me.MaterialSingleLineTextField4.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField4.TabIndex = 3
        Me.MaterialSingleLineTextField4.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField3
        '
        Me.MaterialSingleLineTextField3.Depth = 0
        Me.MaterialSingleLineTextField3.Hint = "Ad"
        Me.MaterialSingleLineTextField3.Location = New System.Drawing.Point(16, 75)
        Me.MaterialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField3.Name = "MaterialSingleLineTextField3"
        Me.MaterialSingleLineTextField3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField3.SelectedText = ""
        Me.MaterialSingleLineTextField3.SelectionLength = 0
        Me.MaterialSingleLineTextField3.SelectionStart = 0
        Me.MaterialSingleLineTextField3.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField3.TabIndex = 2
        Me.MaterialSingleLineTextField3.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField2
        '
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = "Manager"
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(16, 46)
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 1
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Company Name"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(16, 17)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(318, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 0
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-4, 358)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(384, 2)
        Me.MaterialDivider1.TabIndex = 15
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.MaterialDivider2)
        Me.TabPage2.Controls.Add(Me.MaterialRaisedButton4)
        Me.TabPage2.Controls.Add(Me.MaterialRaisedButton3)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(351, 394)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Logo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialDivider2
        '
        Me.MaterialDivider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider2.Depth = 0
        Me.MaterialDivider2.Location = New System.Drawing.Point(-17, 315)
        Me.MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider2.Name = "MaterialDivider2"
        Me.MaterialDivider2.Size = New System.Drawing.Size(384, 2)
        Me.MaterialDivider2.TabIndex = 17
        Me.MaterialDivider2.Text = "MaterialDivider2"
        '
        'MaterialRaisedButton4
        '
        Me.MaterialRaisedButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton4.Depth = 0
        Me.MaterialRaisedButton4.Location = New System.Drawing.Point(84, 339)
        Me.MaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton4.Name = "MaterialRaisedButton4"
        Me.MaterialRaisedButton4.Primary = True
        Me.MaterialRaisedButton4.Size = New System.Drawing.Size(160, 30)
        Me.MaterialRaisedButton4.TabIndex = 16
        Me.MaterialRaisedButton4.Text = "Save Changes F5"
        Me.MaterialRaisedButton4.UseVisualStyleBackColor = True
        '
        'MaterialRaisedButton3
        '
        Me.MaterialRaisedButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialRaisedButton3.Depth = 0
        Me.MaterialRaisedButton3.Location = New System.Drawing.Point(84, 204)
        Me.MaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton3.Name = "MaterialRaisedButton3"
        Me.MaterialRaisedButton3.Primary = True
        Me.MaterialRaisedButton3.Size = New System.Drawing.Size(166, 30)
        Me.MaterialRaisedButton3.TabIndex = 15
        Me.MaterialRaisedButton3.Text = "Select Logo F6"
        Me.MaterialRaisedButton3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(84, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(320, 26)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = True
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(43, 36)
        Me.MaterialFlatButton1.TabIndex = 2
        Me.MaterialFlatButton1.Text = "Skin"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'ModernSkinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(366, 523)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModernSkinForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Settings"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField10 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField9 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField8 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialRaisedButton3 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialRaisedButton4 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
