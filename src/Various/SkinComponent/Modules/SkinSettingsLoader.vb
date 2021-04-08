Public Module SkinSettingsHandler
    Sub ColorChanger(primary_color As MaterialSkin.Primary,
                     dark_primary_color As MaterialSkin.Primary,
                     text_color As MaterialSkin.TextShade,
                     sm As MaterialSkin.MaterialSkinManager)

        sm.ColorScheme = New MaterialSkin.ColorScheme(primary_color,
                                                      dark_primary_color,
                                                      MaterialSkin.Primary.Blue100,
                                                      MaterialSkin.Accent.DeepOrange400,
                                                      text_color)
    End Sub

    Sub ThemeSettingsLoader(light_rb As MaterialSkin.Controls.MaterialRadioButton,
                            dark_rb As MaterialSkin.Controls.MaterialRadioButton,
                            sm As MaterialSkin.MaterialSkinManager)

        light_rb.Checked = My.Settings.theme_light_rb
        If light_rb.Checked = True Then
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        End If
        '----------------------------------
        dark_rb.Checked = My.Settings.theme_dark_rb
        If dark_rb.Checked = True Then
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
        End If
    End Sub


    Sub SkinColorLoader(ByRef primary_color As MaterialSkin.Primary,
                              ByRef dark_primary_color As MaterialSkin.Primary,
                              Blue_rb As MaterialSkin.Controls.MaterialRadioButton,
                              green_rb As MaterialSkin.Controls.MaterialRadioButton,
                              orange_rb As MaterialSkin.Controls.MaterialRadioButton,
                              pink_rb As MaterialSkin.Controls.MaterialRadioButton)

        Dim v As Boolean = False
        v = My.Settings.skin_color_blue
        Blue_rb.Checked = v
        If v = True Then
            primary_color = MaterialSkin.Primary.Blue400
            dark_primary_color = MaterialSkin.Primary.Blue700
        End If

        v = My.Settings.skin_color_green
        green_rb.Checked = v
        If v = True Then
            primary_color = MaterialSkin.Primary.Green400
            dark_primary_color = MaterialSkin.Primary.Green700
        End If
        v = My.Settings.skin_color_orange
        orange_rb.Checked = v
        If v = True Then
            primary_color = MaterialSkin.Primary.Orange400
            dark_primary_color = MaterialSkin.Primary.Orange700
        End If
        v = My.Settings.skin_color_pink
        pink_rb.Checked = v
        If v = True Then
            primary_color = MaterialSkin.Primary.Pink400
            dark_primary_color = MaterialSkin.Primary.Pink700
        End If
    End Sub

    Sub TextColorLoader(ByRef text_color As MaterialSkin.TextShade,
                              text_color_white_rb As MaterialSkin.Controls.MaterialRadioButton,
                              text_color_black_rb As MaterialSkin.Controls.MaterialRadioButton)

        Dim v As Boolean = False
        v = My.Settings.text_color_white
        text_color_white_rb.Checked = v
        If v = True Then
            text_color = MaterialSkin.TextShade.WHITE
        End If
        v = My.Settings.text_color_black
        text_color_black_rb.Checked = v
        If v = True Then
            text_color = MaterialSkin.TextShade.BLACK
        End If
    End Sub
End Module
