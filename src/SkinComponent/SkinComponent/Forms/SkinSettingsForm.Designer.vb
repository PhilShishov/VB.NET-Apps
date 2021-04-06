<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SkinSettingsForm
    ' Inherits System.Windows.Forms.Form
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dark_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.light_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.green_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Blue_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.orange_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pink_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.text_color_white_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.text_color_black_rb = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(94, 78)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel1.TabIndex = 15
        Me.MaterialLabel1.Text = "Theme:"
        '
        'dark_rb
        '
        Me.dark_rb.AutoSize = True
        Me.dark_rb.Depth = 0
        Me.dark_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.dark_rb.Location = New System.Drawing.Point(261, 73)
        Me.dark_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.dark_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.dark_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.dark_rb.Name = "dark_rb"
        Me.dark_rb.Ripple = True
        Me.dark_rb.Size = New System.Drawing.Size(57, 30)
        Me.dark_rb.TabIndex = 14
        Me.dark_rb.Text = "Dark"
        Me.dark_rb.UseVisualStyleBackColor = True
        '
        'light_rb
        '
        Me.light_rb.AutoSize = True
        Me.light_rb.Checked = True
        Me.light_rb.Depth = 0
        Me.light_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.light_rb.Location = New System.Drawing.Point(164, 73)
        Me.light_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.light_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.light_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.light_rb.Name = "light_rb"
        Me.light_rb.Ripple = True
        Me.light_rb.Size = New System.Drawing.Size(60, 30)
        Me.light_rb.TabIndex = 13
        Me.light_rb.TabStop = True
        Me.light_rb.Text = "Light"
        Me.light_rb.UseVisualStyleBackColor = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(68, 38)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel2.TabIndex = 19
        Me.MaterialLabel2.Text = "Skin Color:"
        '
        'green_rb
        '
        Me.green_rb.AutoSize = True
        Me.green_rb.Depth = 0
        Me.green_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.green_rb.Location = New System.Drawing.Point(259, 33)
        Me.green_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.green_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.green_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.green_rb.Name = "green_rb"
        Me.green_rb.Ripple = True
        Me.green_rb.Size = New System.Drawing.Size(66, 30)
        Me.green_rb.TabIndex = 18
        Me.green_rb.Text = "Green"
        Me.green_rb.UseVisualStyleBackColor = True
        '
        'Blue_rb
        '
        Me.Blue_rb.AutoSize = True
        Me.Blue_rb.Checked = True
        Me.Blue_rb.Depth = 0
        Me.Blue_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.Blue_rb.Location = New System.Drawing.Point(166, 33)
        Me.Blue_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.Blue_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.Blue_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.Blue_rb.Name = "Blue_rb"
        Me.Blue_rb.Ripple = True
        Me.Blue_rb.Size = New System.Drawing.Size(56, 30)
        Me.Blue_rb.TabIndex = 17
        Me.Blue_rb.TabStop = True
        Me.Blue_rb.Text = "Blue"
        Me.Blue_rb.UseVisualStyleBackColor = True
        '
        'orange_rb
        '
        Me.orange_rb.AutoSize = True
        Me.orange_rb.Depth = 0
        Me.orange_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.orange_rb.Location = New System.Drawing.Point(166, 75)
        Me.orange_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.orange_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.orange_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.orange_rb.Name = "orange_rb"
        Me.orange_rb.Ripple = True
        Me.orange_rb.Size = New System.Drawing.Size(73, 30)
        Me.orange_rb.TabIndex = 20
        Me.orange_rb.Text = "Orange"
        Me.orange_rb.UseVisualStyleBackColor = True
        '
        'pink_rb
        '
        Me.pink_rb.AutoSize = True
        Me.pink_rb.Depth = 0
        Me.pink_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.pink_rb.Location = New System.Drawing.Point(259, 75)
        Me.pink_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.pink_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.pink_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.pink_rb.Name = "pink_rb"
        Me.pink_rb.Ripple = True
        Me.pink_rb.Size = New System.Drawing.Size(56, 30)
        Me.pink_rb.TabIndex = 21
        Me.pink_rb.Text = "Pink"
        Me.pink_rb.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 70)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(465, 40)
        Me.MaterialTabSelector1.TabIndex = 23
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 108)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(465, 245)
        Me.MaterialTabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.light_rb)
        Me.TabPage1.Controls.Add(Me.dark_rb)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(457, 217)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Theme"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Blue_rb)
        Me.TabPage2.Controls.Add(Me.green_rb)
        Me.TabPage2.Controls.Add(Me.pink_rb)
        Me.TabPage2.Controls.Add(Me.MaterialLabel2)
        Me.TabPage2.Controls.Add(Me.orange_rb)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(457, 217)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Skin Color"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.text_color_white_rb)
        Me.TabPage3.Controls.Add(Me.text_color_black_rb)
        Me.TabPage3.Controls.Add(Me.MaterialLabel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(457, 217)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Text Color"
        '
        'text_color_white_rb
        '
        Me.text_color_white_rb.AutoSize = True
        Me.text_color_white_rb.Checked = True
        Me.text_color_white_rb.Depth = 0
        Me.text_color_white_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.text_color_white_rb.Location = New System.Drawing.Point(169, 52)
        Me.text_color_white_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.text_color_white_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.text_color_white_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.text_color_white_rb.Name = "text_color_white_rb"
        Me.text_color_white_rb.Ripple = True
        Me.text_color_white_rb.Size = New System.Drawing.Size(64, 30)
        Me.text_color_white_rb.TabIndex = 16
        Me.text_color_white_rb.TabStop = True
        Me.text_color_white_rb.Text = "White"
        Me.text_color_white_rb.UseVisualStyleBackColor = True
        '
        'text_color_black_rb
        '
        Me.text_color_black_rb.AutoSize = True
        Me.text_color_black_rb.Depth = 0
        Me.text_color_black_rb.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.text_color_black_rb.Location = New System.Drawing.Point(258, 52)
        Me.text_color_black_rb.Margin = New System.Windows.Forms.Padding(0)
        Me.text_color_black_rb.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.text_color_black_rb.MouseState = MaterialSkin.MouseState.HOVER
        Me.text_color_black_rb.Name = "text_color_black_rb"
        Me.text_color_black_rb.Ripple = True
        Me.text_color_black_rb.Size = New System.Drawing.Size(63, 30)
        Me.text_color_black_rb.TabIndex = 17
        Me.text_color_black_rb.Text = "Black"
        Me.text_color_black_rb.UseVisualStyleBackColor = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(75, 57)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel3.TabIndex = 18
        Me.MaterialLabel3.Text = "Text Color:"
        '
        'SkinSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(464, 350)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkinSettingsForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skin Settings"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dark_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents light_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents green_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Blue_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents orange_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pink_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents text_color_white_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents text_color_black_rb As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
End Class
