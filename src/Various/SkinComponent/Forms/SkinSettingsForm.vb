Public Class SkinSettingsForm
    Dim sm As MaterialSkin.MaterialSkinManager
    Dim primary_color As MaterialSkin.Primary = MaterialSkin.Primary.Blue400
    Dim dark_primary_color As MaterialSkin.Primary = MaterialSkin.Primary.Blue700
    Dim text_color As MaterialSkin.TextShade = MaterialSkin.TextShade.WHITE

    Private Sub Skin_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        '----------------------------
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        sm.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                      MaterialSkin.Primary.Blue700,
                                                      MaterialSkin.Primary.Blue100,
                                                      MaterialSkin.Accent.DeepOrange400,
                                                      MaterialSkin.TextShade.WHITE)

        Call ThemeSettingsLoader(Me.light_rb, Me.dark_rb, sm)
        Call SkinColorLoader(primary_color, dark_primary_color,
                             Me.Blue_rb, Me.green_rb, Me.orange_rb, Me.pink_rb)
        Call TextColorLoader(text_color, Me.text_color_white_rb, Me.text_color_black_rb)
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
    End Sub

    Private Sub Light_rb_Click(sender As Object, e As EventArgs) Handles light_rb.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        My.Settings.theme_light_rb = Me.light_rb.Checked
        My.Settings.theme_dark_rb = Me.dark_rb.Checked
        My.Settings.Save()
    End Sub

    Private Sub Dark_rb_Click(sender As Object, e As EventArgs) Handles dark_rb.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
        My.Settings.theme_dark_rb = Me.dark_rb.Checked
        My.Settings.theme_light_rb = Me.light_rb.Checked
        My.Settings.Save()
    End Sub

    Private Sub Blue_rb_Click(sender As Object, e As EventArgs) Handles Blue_rb.Click
        primary_color = MaterialSkin.Primary.Blue400
        dark_primary_color = MaterialSkin.Primary.Blue700
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        Call ColorSaver()
    End Sub

    Private Sub Green_rb_Click(sender As Object, e As EventArgs) Handles green_rb.Click
        primary_color = MaterialSkin.Primary.Green400
        dark_primary_color = MaterialSkin.Primary.Green700
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        Call ColorSaver()
    End Sub

    Private Sub Orange_rb_CheckedChanged(sender As Object, e As EventArgs) Handles orange_rb.CheckedChanged

    End Sub

    Private Sub Orange_rb_Click(sender As Object, e As EventArgs) Handles orange_rb.Click
        primary_color = MaterialSkin.Primary.Orange400
        dark_primary_color = MaterialSkin.Primary.Orange700
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        Call ColorSaver()
    End Sub

    Private Sub Pink_rb_CheckedChanged(sender As Object, e As EventArgs) Handles pink_rb.CheckedChanged

    End Sub

    Private Sub Pink_rb_Click(sender As Object, e As EventArgs) Handles pink_rb.Click
        primary_color = MaterialSkin.Primary.Pink400
        dark_primary_color = MaterialSkin.Primary.Pink700
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        Call ColorSaver()
    End Sub

    Private Sub Text_color_white_rb_Click(sender As Object, e As EventArgs) Handles text_color_white_rb.Click
        text_color = MaterialSkin.TextShade.WHITE
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        My.Settings.text_color_white = Me.text_color_white_rb.Checked
        My.Settings.text_color_black = Me.text_color_black_rb.Checked
        My.Settings.Save()
    End Sub

    Private Sub Text_color_black_rb_Click(sender As Object, e As EventArgs) Handles text_color_black_rb.Click
        text_color = MaterialSkin.TextShade.BLACK
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
        My.Settings.text_color_white = Me.text_color_white_rb.Checked
        My.Settings.text_color_black = Me.text_color_black_rb.Checked
        My.Settings.Save()
    End Sub

    Sub ColorSaver()
        My.Settings.skin_color_blue = Me.Blue_rb.Checked
        My.Settings.skin_color_green = Me.green_rb.Checked
        My.Settings.skin_color_orange = Me.orange_rb.Checked
        My.Settings.skin_color_pink = Me.pink_rb.Checked
        My.Settings.Save()
    End Sub
End Class