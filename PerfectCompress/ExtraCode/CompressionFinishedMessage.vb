Module CompressionFinishedMessage
    Public Sub ShowCompressionFinishedMessage(Input As String, Output As String)
        Try
            Dim OFName As String = My.Computer.FileSystem.GetName(Input)
            Dim CFName As String = My.Computer.FileSystem.GetName(Output)
            Dim CFSize As IO.FileInfo = My.Computer.FileSystem.GetFileInfo(Output)
            Dim OFSize As String = String.Empty
            If My.Computer.FileSystem.FileExists(Input) Then
                OFSize = My.Computer.FileSystem.GetFileInfo(Input).Length
            Else
                OFSize = GetFolderSize(Input)
            End If
            If My.Computer.FileSystem.FileExists(Input) Then
                MsgBox("File Compression finished!" & Environment.NewLine & "Original File Size is " & OFSize & " bytes." & Environment.NewLine & "Compressed File Size is " & CFSize.Length & " bytes." & Environment.NewLine & "Compression Ratio is " & CFSize.Length / OFSize * 100 & "%")
            ElseIf My.Computer.FileSystem.DirectoryExists(Input) Then
                MsgBox("Folder Compression finished!" & Environment.NewLine & "Original Folder Size is " & OFSize & " bytes." & Environment.NewLine & "Compressed File Size is " & CFSize.Length & " bytes." & Environment.NewLine & "Compression Ratio is " & CFSize.Length / OFSize * 100 & "%")
            End If
        Catch
            MsgBox("An error occured while compressing...")
        End Try
    End Sub
End Module
