Public Class BasicSkinForm

    Dim sm As MaterialSkin.MaterialSkinManager

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
        sm.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500,
                                                      MaterialSkin.Primary.Orange900,
                                                      Nothing,
                                                      MaterialSkin.Accent.Green400,
                                                      MaterialSkin.TextShade.BLACK)
        Me.MaterialLabel1.Font = sm.ROBOTO_MEDIUM_12
        Me.MaterialLabel1.Font = New Font("Segoe UI", 20, FontStyle.Regular)
        'Me.Text = Me.MaterialLabel1.Font.ToString
        Me.MaterialRadioButton1.Font = sm.ROBOTO_MEDIUM_10
        Me.MaterialRadioButton1.Font = New Font("Segoe UI", 20, FontStyle.Regular)
    End Sub

    Private Sub ButtonDark_Click(sender As Object, e As EventArgs) Handles ButtonDark.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
    End Sub

    Private Sub ButtonLight_Click(sender As Object, e As EventArgs) Handles ButtonLight.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
    End Sub
End Class
