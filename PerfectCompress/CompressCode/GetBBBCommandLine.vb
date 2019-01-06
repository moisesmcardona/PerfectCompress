Module GetBBBCommandLine
    Public Function GetBBBCommandLine(Input As String, Output As String) As String
        Return My.Settings.BBBCompressionMode + "m" + My.Settings.BBBBlockSize + " """ & Input & """ """ & Output & """"
    End Function
End Module
