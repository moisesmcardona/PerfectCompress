Public Class BBBCompressionSettings

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BBBCompressionSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.BBBCompressionMode = "cf" Then CheckBox1.Checked = True
        NumericUpDown1.Value = My.Settings.BBBBlockSize
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim CompressionSetting = "c"
        If CheckBox1.Checked Then CompressionSetting += "f"
        My.Settings.BBBCompressionMode = CompressionSetting
        My.Settings.Save()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        My.Settings.BBBBlockSize = NumericUpDown1.Value
        My.Settings.Save()
    End Sub
End Class