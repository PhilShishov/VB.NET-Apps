Public Class ModernSkinForm
    Dim sm As MaterialSkin.MaterialSkinManager
    Dim primary_color As MaterialSkin.Primary = MaterialSkin.Primary.Blue400
    Dim dark_primary_color As MaterialSkin.Primary = MaterialSkin.Primary.Blue700
    Dim text_color As MaterialSkin.TextShade = MaterialSkin.TextShade.WHITE

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        '----------------------------
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        sm.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                      MaterialSkin.Primary.Blue700,
                                                      MaterialSkin.Primary.Blue100,
                                                      MaterialSkin.Accent.DeepOrange400,
                                                        MaterialSkin.TextShade.WHITE)

        '===================== Skin Settings Loader ===============================

        Dim rb As New MaterialSkin.Controls.MaterialRadioButton
        Call ThemeSettingsLoader(rb, rb, sm)
        Call SkinColorLoader(primary_color, dark_primary_color,
                                   rb, rb, rb, rb)
        Call TextColorLoader(text_color, rb, rb)
        Call SkinSettingsHandler.ColorChanger(primary_color, dark_primary_color, text_color, sm)
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim form As New SkinSettingsForm
        form.ShowDialog()
        form.Dispose()
    End Sub
End Class
