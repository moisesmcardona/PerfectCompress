Module GetArcCommandLine
    Public Function GetArcCommandLine(Input As String, Output As String) As String
        Dim SFX As String = String.Empty
        If IO.Path.GetExtension(Output) = ".exe" Then SFX = "-sfx" & My.Settings.ArcSFXModule
        Return "a -i2 -" & My.Settings.ArcLevel & " " & SFX & " """ & Output & """ """ & Input & """"
    End Function
End Module
