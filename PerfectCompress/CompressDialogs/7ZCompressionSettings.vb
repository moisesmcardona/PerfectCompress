Public Class _7ZCompressionSettings
    Private Sub _7ZCompressionSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Level As String = My.Settings.SevenZipLevel
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
        CompressionMethod.SelectedItem = My.Settings.SevenZipMethod
        DictionarySize.Text = My.Settings.SevenZipDictSize
        WordSize.Text = My.Settings.SevenZipWordSize
        SolidBlockSize.Text = My.Settings.SevenZipBlockSize
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
        My.Settings.SevenZipLevel = Level
        My.Settings.Save()
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WebBrowser.WebBrowser1.Navigate("http://7-zip.org")
        WebBrowser.ShowDialog()
    End Sub

    Private Sub CompressionMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompressionMethod.SelectedIndexChanged
        AdjustParameters()
        My.Settings.SevenZipMethod = CompressionMethod.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub AdjustParameters()
        If CompressionLevel.SelectedItem = "Store" Then
            DictionarySize.Text = ""
            WordSize.Text = ""
            SolidBlockSize.Text = ""
        ElseIf CompressionLevel.SelectedItem = "Fastest" Then
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
                SolidBlockSize.Text = "8m"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "4m"
                WordSize.Text = "4"
                SolidBlockSize.Text = "512m"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "100k"
                WordSize.Text = ""
                SolidBlockSize.Text = "8m"
            End If
        ElseIf CompressionLevel.SelectedItem = "Fast" Then
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "1m"
                WordSize.Text = "32"
                SolidBlockSize.Text = "128m"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "4m"
                WordSize.Text = "4"
                SolidBlockSize.Text = "512m"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "500k"
                WordSize.Text = ""
                SolidBlockSize.Text = "32m"
            End If
        ElseIf CompressionLevel.SelectedItem = "Normal" Then
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "16m"
                WordSize.Text = "32"
                SolidBlockSize.Text = "2g"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "16m"
                WordSize.Text = "6"
                SolidBlockSize.Text = "2g"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        ElseIf CompressionLevel.SelectedItem = "Maximum" Then
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "32m"
                WordSize.Text = "64"
                SolidBlockSize.Text = "4g"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "64m"
                WordSize.Text = "16"
                SolidBlockSize.Text = "4g"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        ElseIf CompressionLevel.SelectedItem = "Ultra" Then
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "64m"
                WordSize.Text = "64"
                SolidBlockSize.Text = "4g"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "192m"
                WordSize.Text = "32"
                SolidBlockSize.Text = "4g"
            ElseIf CompressionMethod.SelectedItem = "PPMd" Then
                DictionarySize.Text = "900k"
                WordSize.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        End If
    End Sub

    Private Sub DictionarySize_TextChanged(sender As Object, e As EventArgs) Handles DictionarySize.TextChanged
        My.Settings.SevenZipDictSize = DictionarySize.Text
        My.Settings.Save()
    End Sub

    Private Sub WordSize_TextChanged(sender As Object, e As EventArgs) Handles WordSize.TextChanged
        My.Settings.SevenZipWordSize = WordSize.Text
        My.Settings.Save()
    End Sub

    Private Sub SolidBlockSize_TextChanged(sender As Object, e As EventArgs) Handles SolidBlockSize.TextChanged
        My.Settings.SevenZipBlockSize = SolidBlockSize.Text
        My.Settings.Save()
    End Sub
End Class