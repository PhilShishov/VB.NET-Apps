<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboForm
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.count_Label3 = New System.Windows.Forms.Label()
        Me.search_TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cat", "Dog", "Mouse", "Koala", "Zebra", "Horse"})
        Me.ComboBox1.Location = New System.Drawing.Point(132, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(139, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(277, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add to Combo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(132, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(201, 101)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Clear All"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(287, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Items Count:"
        '
        'count_Label3
        '
        Me.count_Label3.Location = New System.Drawing.Point(87, 57)
        Me.count_Label3.Name = "count_Label3"
        Me.count_Label3.Size = New System.Drawing.Size(39, 18)
        Me.count_Label3.TabIndex = 7
        Me.count_Label3.Text = "-"
        '
        'search_TextBox2
        '
        Me.search_TextBox2.Location = New System.Drawing.Point(125, 214)
        Me.search_TextBox2.Name = "search_TextBox2"
        Me.search_TextBox2.Size = New System.Drawing.Size(139, 20)
        Me.search_TextBox2.TabIndex = 10
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Cat", "Dog", "Mouse", "Koala", "Zebra", "Horse"})
        Me.ComboBox2.Location = New System.Drawing.Point(125, 252)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(270, 212)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 355)
        Me.Controls.Add(Me.search_TextBox2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.count_Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents count_Label3 As Label
    Friend WithEvents search_TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button4 As Button
End Class
