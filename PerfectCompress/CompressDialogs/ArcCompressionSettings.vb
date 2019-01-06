Public Class ArcCompressionSettings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ArcLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ArcLevel.SelectedIndexChanged
        My.Settings.ArcLevel = ArcLevel.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub SFXModule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SFXModule.SelectedIndexChanged
        My.Settings.ArcSFXModule = SFXModule.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub ArcCompressionSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ArcLevel.SelectedItem = My.Settings.ArcLevel
        SFXModule.SelectedItem = My.Settings.ArcSFXModule
    End Sub
End Class