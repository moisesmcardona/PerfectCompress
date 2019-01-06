Module GetBalzCommandLine
    Public Function GetBalzCommandLine(Input As String, Output As String)
        Return My.Settings.BalzCompression + " """ & Input & """ """ & Output & """"
    End Function
End Module
