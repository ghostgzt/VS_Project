Public Class MiniIcon
    Dim mywin As System.Windows.Forms.Form
    Function mini(ByVal mywin2 As System.Windows.Forms.Form, ByVal y As Boolean, ByVal kind As String)
        mywin = mywin2
        'If y = False Then
        hidewin()
        'End If
        'If y = True Then
        '    go(kind)
        'End If
    End Function
    Function hidewin()
        If mywin.WindowState = System.Windows.Forms.FormWindowState.Minimized Then
            mywin.WindowState = System.Windows.Forms.FormWindowState.Normal
        Else
            mywin.WindowState = System.Windows.Forms.FormWindowState.Minimized
        End If
    End Function
    Function go(ByVal kind As String)
        write()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Paste\" + kind, "Hide", Nothing) = 0 Then
            mywin.Hide()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + kind, "Hide", "1")
        Else
            mywin.Show()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + kind, "Hide", "0")
        End If
    End Function
    Function rof(ByVal di As Boolean, ByVal kind As String)
        If di = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + kind, "Hide", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Paste\" + kind, "Hide", "0")
        End If
    End Function
    Function write()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\TextPaste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\ImagePaste")
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Paste\AudioPaste")
    End Function
    Private Sub MiniIcon_Load() Handles Me.Load
        Me.Visible = False
    End Sub
End Class