Public Class EndCommand
    Function write()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\TextPaste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\ImagePaste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\AudioPaste")
    End Function
    Function showw(ByVal exe As String, ByVal s As Boolean)
        write()
        If s = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + exe, "ShowTask", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + exe, "ShowTask", "0")
        End If
    End Function
    Function showend(ByVal exe As String, ByVal s As Boolean)
        write()
        If s = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + exe, "End", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + exe, "End", "0")
        End If
    End Function
End Class