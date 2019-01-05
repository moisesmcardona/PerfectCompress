Module GetZIPCommandLine
    Public Function GetZIPCommandLine(Input As String, Output As String) As String
        Dim CommandLine As String = String.Empty
        Dim Level As String = My.Settings.ZipLevel
        Dim Method As String = My.Settings.ZipMethod
        Dim DictionarySize As String = My.Settings.ZipDictionarySize
        Dim WordSize As String = My.Settings.ZipWordSize
        If Level = "mx0" Then
            CommandLine = "a -tzip -mm=Copy -mx0 """ & Output & """ """ & Input & """"
        Else
            If Method = "Deflate" Or Method = "Deflate64" Then
                CommandLine = "a -tzip -mm=" & Method & " -mmt=" & Environment.ProcessorCount.ToString() & " -" & Level & " -mfb=" & WordSize & " -mpass=1 """ & Output & """ """ & Input & """ -bb3 -bso1 -bsp1 -bse1"
            ElseIf Method = "BZip2" Then
                CommandLine = "a -tzip -mm=BZip2 -mmt=" & Environment.ProcessorCount.ToString() & " -" & Level & " -md=" & DictionarySize & " -mpass=1 """ & Output & """ """ & Input & """ -bb3 -bso1 -bsp1 -bse1"
            ElseIf Method = "LZMA" Then
                CommandLine = "a -tzip -mm=LZMA -mmt=" & Environment.ProcessorCount.ToString() & " -" & Level & " -md=" & DictionarySize & " -mfb=" & WordSize & " """ & Output & """ """ & Input & """ -bb3 -bso1 -bsp1 -bse1"
            ElseIf Method = "PPMd" Then
                CommandLine = "a -tzip -mm=PPMd -mmt=" & Environment.ProcessorCount.ToString() & " -" & Level & " -mmem=" & DictionarySize & " -mo=" & WordSize & " """ & Output & """ """ & Input & """ -bb3 -bso1 -bsp1 -bse1"
            End If
        End If
        Return CommandLine
    End Function
End Module
