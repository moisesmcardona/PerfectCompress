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
            DictionarySize.Text = ""
            WordSize.Text = ""
            SolidBlockSize.Text = ""
        ElseIf CompressionLevel.SelectedIndex = 1 Then
            Level = "mx1"
            If CompressionMethod.SelectedItem = "LZMA" Or CompressionMethod.SelectedItem = "LZMA2" Then
                DictionarySize.Text = "64k"
                WordSize.Text = "32"
                SolidBlockSize.Text = "8m"
            ElseIf CompressionMethod.SelectedItem = "BZip2" Then
                DictionarySize.Text = "4m"
                WordSize.Text = "4"
                SolidBlockSize.Text = "512m"
            End If
        ElseIf CompressionLevel.SelectedIndex = 2 Then
            Level = "mx3"
        ElseIf CompressionLevel.SelectedIndex = 3 Then
            Level = "mx5"
        ElseIf CompressionLevel.SelectedIndex = 4 Then
            Level = "mx7"
        ElseIf CompressionLevel.SelectedIndex = 5 Then
            Level = "mx9"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton2.CheckedChanged

        If My.Computer.FileSystem.ReadAllText(Method) = "4" Then
            If VRadioButton2.Checked = True Then
                TextBox1.Text = "100k"
                TextBox2.Text = ""
                SolidBlockSize.Text = "8m"
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton3.CheckedChanged
        If My.Computer.FileSystem.ReadAllText(Method) = "1" Or My.Computer.FileSystem.ReadAllText(Method) = "2" Then
            If VRadioButton3.Checked = True Then
                TextBox1.Text = "1m"
                TextBox2.Text = "32"
                SolidBlockSize.Text = "128m"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "3" Then
            If VRadioButton3.Checked = True Then
                TextBox1.Text = "4m"
                TextBox2.Text = "4"
                SolidBlockSize.Text = "512m"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "4" Then
            If VRadioButton3.Checked = True Then
                TextBox1.Text = "500k"
                TextBox2.Text = ""
                SolidBlockSize.Text = "32m"
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton4.CheckedChanged
        If My.Computer.FileSystem.ReadAllText(Method) = "1" Or My.Computer.FileSystem.ReadAllText(Method) = "2" Then
            If VRadioButton4.Checked = True Then
                TextBox1.Text = "16m"
                TextBox2.Text = "32"
                SolidBlockSize.Text = "2g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "3" Then
            If VRadioButton4.Checked = True Then
                TextBox1.Text = "16m"
                TextBox2.Text = "6"
                SolidBlockSize.Text = "2g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "4" Then
            If VRadioButton4.Checked = True Then
                TextBox1.Text = "900k"
                TextBox2.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton5.CheckedChanged
        If My.Computer.FileSystem.ReadAllText(Method) = "1" Or My.Computer.FileSystem.ReadAllText(Method) = "2" Then
            If VRadioButton5.Checked = True Then
                TextBox1.Text = "32m"
                TextBox2.Text = "64"
                SolidBlockSize.Text = "4g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "3" Then
            If VRadioButton5.Checked = True Then
                TextBox1.Text = "64m"
                TextBox2.Text = "16"
                SolidBlockSize.Text = "4g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "4" Then
            If VRadioButton5.Checked = True Then
                TextBox1.Text = "900k"
                TextBox2.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VRadioButton6.CheckedChanged
        If My.Computer.FileSystem.ReadAllText(Method) = "1" Or My.Computer.FileSystem.ReadAllText(Method) = "2" Then
            If VRadioButton6.Checked = True Then
                TextBox1.Text = "64m"
                TextBox2.Text = "64"
                SolidBlockSize.Text = "4g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "3" Then
            If VRadioButton6.Checked = True Then
                TextBox1.Text = "192m"
                TextBox2.Text = "32"
                SolidBlockSize.Text = "4g"
            End If
        End If
        If My.Computer.FileSystem.ReadAllText(Method) = "4" Then
            If VRadioButton6.Checked = True Then
                TextBox1.Text = "900k"
                TextBox2.Text = ""
                SolidBlockSize.Text = "64m"
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        WebBrowser.WebBrowser1.Navigate("http://7-zip.org")
        WebBrowser.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


End Class