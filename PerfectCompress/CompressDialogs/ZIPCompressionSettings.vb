Public Class ZIPCompressionSettings

    Private Sub ZIPCompressionSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Level As String = My.Settings.ZipLevel
        If Level = "mx0" Then
            CompressionLevel.SelectedIndex = 0
        ElseIf Level = "mx1" Then
            CompressionLevel.SelectedIndex = 1
        ElseIf Level = "mx3" Then
            CompressionLevel.SelectedIndex = 2
        ElseIf Level = "mx5" Then
            CompressionLevel.SelectedIndex = 3
        ElseIf Level = "mx7" Then
            CompressionLevel.SelectedIndex = 4
        ElseIf Level = "mx9" Then
            CompressionLevel.SelectedIndex = 5
        End If
        CompressionMethod.SelectedItem = My.Settings.ZipMethod
        DictionarySize.Text = My.Settings.ZipDictionarySize
        WordSize.Text = My.Settings.ZipWordSize
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = False Then
            DictionarySize.Enabled = False
            WordSize.Enabled = False
        Else
            DictionarySize.Enabled = True
            WordSize.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WebBrowser.WebBrowser1.Navigate("http://7-zip.org")
        WebBrowser.ShowDialog()
    End Sub

    Private Sub CompressionLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompressionLevel.SelectedIndexChanged
        Dim Level As String = String.Empty
        If CompressionLevel.SelectedIndex = 0 Then
            Level = "mx0"
        ElseIf CompressionLevel.SelectedIndex = 1 Then
            Level = "mx1"
        ElseIf CompressionLevel.SelectedIndex = 2 Then
            Level = "mx3"
        ElseIf CompressionLevel.SelectedIndex = 3 Then
            Level = "mx5"
        ElseIf CompressionLevel.SelectedIndex = 4 Then
            Level = "mx7"
        ElseIf CompressionLevel.SelectedIndex = 5 Then
            Level = "mx9"
        End If
        AdjustParameters()
        My.Settings.ZipLevel = Level
        My.Settings.Save()
    End Sub

    Private Sub AdjustParameters()
        If CompressionLevel.SelectedItem = "Store" Then
            DictionarySize.Text = ""
            WordSize.Text = ""
        ElseIf CompressionLevel.SelectedItem = "Fastest" Then
            If CompressionMethod.SelectedItem = "Deflate" Then
                DictionarySize.Text = "32k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "Deflate64" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "100k"
                WordSize.Text = ""
            ElseIf CompressionMethod.SelectedItem = "LZMA" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "1m"
                WordSize.Text = "4"
            End If
        ElseIf CompressionLevel.SelectedItem = "Fast" Then
            If CompressionMethod.SelectedItem = "Deflate" Then
                DictionarySize.Text = "32k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "Deflate64" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "500k"
                WordSize.Text = ""
            ElseIf CompressionMethod.SelectedItem = "LZMA" Then
                DictionarySize.Text = "1m"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "4m"
                WordSize.Text = "6"
            End If
        ElseIf CompressionLevel.SelectedItem = "Normal" Then
            If CompressionMethod.SelectedItem = "Deflate" Then
                DictionarySize.Text = "32k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "Deflate64" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
            ElseIf CompressionMethod.SelectedItem = "LZMA" Then
                DictionarySize.Text = "16m"
                WordSize.Text = "32"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "16m"
                WordSize.Text = "8"
            End If
        ElseIf CompressionLevel.SelectedItem = "Maximum" Then
            If CompressionMethod.SelectedItem = "Deflate" Then
                DictionarySize.Text = "32k"
                WordSize.Text = "64"
            ElseIf CompressionMethod.SelectedItem = "Deflate64" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "64"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
            ElseIf CompressionMethod.SelectedItem = "LZMA" Then
                DictionarySize.Text = "32m"
                WordSize.Text = "64"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "64m"
                WordSize.Text = "10"
            End If
        ElseIf CompressionLevel.SelectedItem = "Ultra" Then
            If CompressionMethod.SelectedItem = "Deflate" Then
                DictionarySize.Text = "32k"
                WordSize.Text = "128"
            ElseIf CompressionMethod.SelectedItem = "Deflate64" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "128"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
            ElseIf CompressionMethod.SelectedItem = "LZMA" Then
                DictionarySize.Text = "64m"
                WordSize.Text = "64"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "128m"
                WordSize.Text = "12"
            End If
        End If
    End Sub

    Private Sub CompressionMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompressionMethod.SelectedIndexChanged
        AdjustParameters()
        My.Settings.ZipMethod = CompressionMethod.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub DictionarySize_TextChanged(sender As Object, e As EventArgs) Handles DictionarySize.TextChanged
        My.Settings.ZipDictionarySize = DictionarySize.Text
        My.Settings.Save()
    End Sub

    Private Sub WordSize_TextChanged(sender As Object, e As EventArgs) Handles WordSize.TextChanged
        My.Settings.ZipWordSize = WordSize.Text
        My.Settings.Save()
    End Sub
End Class