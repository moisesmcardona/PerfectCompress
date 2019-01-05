Module Get7zCommandLine
    Public Function Get7zCommandLine(Input As String, Output As String) As String
        Dim CommandLine As String = String.Empty
        Dim SFX As String = String.Empty
        Dim Method As String = My.Settings.SevenZipMethod
        Dim Level As String = My.Settings.SevenZipLevel
        Dim DictionarySize As String = My.Settings.SevenZipDictSize
        Dim WordSize As String = My.Settings.SevenZipWordSize
        Dim BlockSize As String = My.Settings.SevenZipBlockSize
        If IO.Path.GetExtension(Output) = ".exe" Then SFX = "-sfx7z.sfx"
        If Level = "mx0" Then
            CommandLine = "a -t7z -m0=Copy -mx0 -ms=off """ & Output & """ """ & Input & """"
        Else
            If Method = "LZMA" Or Method = "LZMA2" Then
                CommandLine = "a -t7z -m0=LZMA -mmt=on -" & Level & " -md=" & DictionarySize & " -mfb=" & WordSize & " -ms=" & BlockSize & " " & SFX & " """ & Output & """ """ & Input & """"
            ElseIf Method = "PPMd" Then
                CommandLine = "a -t7z -m0=PPMd -" & Level & " -mmem=" & DictionarySize & " -mo=" & WordSize & " -ms=" & BlockSize & " """ & Output & """ """ & Input & """"
            ElseIf Method = "BZip2" Then
                CommandLine = "a -t7z -m0=BZip2 -mmt=on -" & Level & " -md=" & DictionarySize & " -mpass=" & WordSize & " -ms=" & BlockSize & " """ & Output & """ """ & Input & """"
            End If
        End If
        Return CommandLine
    End Function
End Module
