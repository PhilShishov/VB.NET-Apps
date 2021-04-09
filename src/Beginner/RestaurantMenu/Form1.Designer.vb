<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurantMenuForm
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
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.radSoda = New System.Windows.Forms.RadioButton()
        Me.grpFries = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.grpBurgers = New System.Windows.Forms.GroupBox()
        Me.radCheeseBacon = New System.Windows.Forms.RadioButton()
        Me.radBacon = New System.Windows.Forms.RadioButton()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.chkDrinks = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkBurgers = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpDrinks.SuspendLayout()
        Me.grpFries.SuspendLayout()
        Me.grpBurgers.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.radWater)
        Me.grpDrinks.Controls.Add(Me.radSoda)
        Me.grpDrinks.Location = New System.Drawing.Point(103, 329)
        Me.grpDrinks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpDrinks.Size = New System.Drawing.Size(233, 95)
        Me.grpDrinks.TabIndex = 13
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Choices for Drinks"
        Me.grpDrinks.Visible = False
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(7, 58)
        Me.radWater.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(135, 19)
        Me.radWater.TabIndex = 1
        Me.radWater.TabStop = True
        Me.radWater.Text = "Bottled Water ($1.49)"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'radSoda
        '
        Me.radSoda.AutoSize = True
        Me.radSoda.Location = New System.Drawing.Point(7, 31)
        Me.radSoda.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radSoda.Name = "radSoda"
        Me.radSoda.Size = New System.Drawing.Size(89, 19)
        Me.radSoda.TabIndex = 0
        Me.radSoda.TabStop = True
        Me.radSoda.Text = "Soda ($1.69)"
        Me.radSoda.UseVisualStyleBackColor = True
        '
        'grpFries
        '
        Me.grpFries.Controls.Add(Me.radLarge)
        Me.grpFries.Controls.Add(Me.radMedium)
        Me.grpFries.Controls.Add(Me.radSmall)
        Me.grpFries.Location = New System.Drawing.Point(105, 189)
        Me.grpFries.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpFries.Name = "grpFries"
        Me.grpFries.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpFries.Size = New System.Drawing.Size(233, 115)
        Me.grpFries.TabIndex = 17
        Me.grpFries.TabStop = False
        Me.grpFries.Text = "Choices for Fries"
        Me.grpFries.Visible = False
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(9, 78)
        Me.radLarge.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(92, 19)
        Me.radLarge.TabIndex = 2
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large ($4.99)"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(9, 52)
        Me.radMedium.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(108, 19)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium ($3.09)"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Location = New System.Drawing.Point(9, 25)
        Me.radSmall.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(92, 19)
        Me.radSmall.TabIndex = 0
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small ($2.39)"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'grpBurgers
        '
        Me.grpBurgers.Controls.Add(Me.radCheeseBacon)
        Me.grpBurgers.Controls.Add(Me.radBacon)
        Me.grpBurgers.Controls.Add(Me.radCheese)
        Me.grpBurgers.Controls.Add(Me.radRegular)
        Me.grpBurgers.Location = New System.Drawing.Point(105, 28)
        Me.grpBurgers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpBurgers.Name = "grpBurgers"
        Me.grpBurgers.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grpBurgers.Size = New System.Drawing.Size(231, 142)
        Me.grpBurgers.TabIndex = 16
        Me.grpBurgers.TabStop = False
        Me.grpBurgers.Text = "Choices for Burgers"
        Me.grpBurgers.Visible = False
        '
        'radCheeseBacon
        '
        Me.radCheeseBacon.AutoSize = True
        Me.radCheeseBacon.Location = New System.Drawing.Point(7, 107)
        Me.radCheeseBacon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radCheeseBacon.Name = "radCheeseBacon"
        Me.radCheeseBacon.Size = New System.Drawing.Size(175, 19)
        Me.radCheeseBacon.TabIndex = 3
        Me.radCheeseBacon.TabStop = True
        Me.radCheeseBacon.Text = "w/ bacon and cheese ($5.39)"
        Me.radCheeseBacon.UseVisualStyleBackColor = True
        '
        'radBacon
        '
        Me.radBacon.AutoSize = True
        Me.radBacon.Location = New System.Drawing.Point(7, 81)
        Me.radBacon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radBacon.Name = "radBacon"
        Me.radBacon.Size = New System.Drawing.Size(113, 19)
        Me.radBacon.TabIndex = 2
        Me.radBacon.TabStop = True
        Me.radBacon.Text = "w/ bacon ($4.79)"
        Me.radBacon.UseVisualStyleBackColor = True
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Location = New System.Drawing.Point(7, 54)
        Me.radCheese.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(116, 19)
        Me.radCheese.TabIndex = 1
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "w/ cheese ($4.79)"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(7, 28)
        Me.radRegular.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(103, 19)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular ($4.19)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'chkDrinks
        '
        Me.chkDrinks.AutoSize = True
        Me.chkDrinks.Location = New System.Drawing.Point(16, 329)
        Me.chkDrinks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkDrinks.Name = "chkDrinks"
        Me.chkDrinks.Size = New System.Drawing.Size(59, 19)
        Me.chkDrinks.TabIndex = 15
        Me.chkDrinks.Text = "Drinks"
        Me.chkDrinks.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(26, 189)
        Me.chkFries.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(50, 19)
        Me.chkFries.TabIndex = 14
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkBurgers
        '
        Me.chkBurgers.AutoSize = True
        Me.chkBurgers.Location = New System.Drawing.Point(26, 28)
        Me.chkBurgers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.chkBurgers.Name = "chkBurgers"
        Me.chkBurgers.Size = New System.Drawing.Size(66, 19)
        Me.chkBurgers.TabIndex = 11
        Me.chkBurgers.Text = "Burgers"
        Me.chkBurgers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(356, 404)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cost of the Meal is:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(499, 400)
        Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(74, 23)
        Me.txtCost.TabIndex = 9
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(359, 324)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(215, 51)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Cost of the Meal"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'RestaurantMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 464)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.grpFries)
        Me.Controls.Add(Me.grpBurgers)
        Me.Controls.Add(Me.chkDrinks)
        Me.Controls.Add(Me.chkFries)
        Me.Controls.Add(Me.chkBurgers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.btnCalculate)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "RestaurantMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Menu"
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpFries.ResumeLayout(False)
        Me.grpFries.PerformLayout()
        Me.grpBurgers.ResumeLayout(False)
        Me.grpBurgers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDrinks As GroupBox
  Friend WithEvents radWater As RadioButton
  Friend WithEvents radSoda As RadioButton
  Friend WithEvents grpFries As GroupBox
  Friend WithEvents radLarge As RadioButton
  Friend WithEvents radMedium As RadioButton
  Friend WithEvents radSmall As RadioButton
  Friend WithEvents grpBurgers As GroupBox
  Friend WithEvents radCheeseBacon As RadioButton
  Friend WithEvents radBacon As RadioButton
  Friend WithEvents radCheese As RadioButton
  Friend WithEvents radRegular As RadioButton
  Friend WithEvents chkDrinks As CheckBox
  Friend WithEvents chkFries As CheckBox
  Friend WithEvents chkBurgers As CheckBox
  Friend WithEvents Label1 As Label
  Friend WithEvents txtCost As TextBox
  Friend WithEvents btnCalculate As Button
End Class
