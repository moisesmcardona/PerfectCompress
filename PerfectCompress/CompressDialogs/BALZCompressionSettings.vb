Public Class BALZCompressionSettings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BALZCompressionSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.BalzCompression = "cx" Then CheckBox1.Checked = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim CompressionSetting = "c"
        If CheckBox1.Checked Then CompressionSetting += "x"
        My.Settings.BalzCompression = CompressionSetting
        My.Settings.Save()
    End Sub
End Class