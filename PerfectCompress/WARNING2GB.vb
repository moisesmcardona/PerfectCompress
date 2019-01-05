Public Class WARNING2GB

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Settings.CompressionWarningAccepted = DontShowCheckbox.Checked
        My.Settings.Save()
        Me.Close()
    End Sub
End Class