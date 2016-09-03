Public Class Runing
    Function RunFile(ByVal FilePath As String)
        On Error Resume Next
        Shell("Rundll32.exe url.dll, FileProtocolHandler " + FilePath)
    End Function
    Function RunFileWay(ByVal FilePath As String)
        On Error Resume Next
        Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + FilePath)
    End Function
End Class
