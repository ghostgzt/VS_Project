Public Class Jarr
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "XP,2003以下" Then
            If MsgBox("Are you sure your windows system is under the XP/2003?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                xp()
                GoTo L
            End If
        Else
            If MsgBox("Are you sure your windows system is above the Vista?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                vista()
                GoTo L
            End If
        End If
        Exit Sub
L:      MsgBox("Successed！！！", MsgBoxStyle.Information, "Registry")
        End
    End Sub
    Function xjar()
        On Error Resume Next
        My.Computer.Registry.ClassesRoot.CreateSubKey(".jar")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.jar", "", "jarfile")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\Jadgen\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAR_RUN.exe" + TextBox1.Text + " /Jad " + " " + TextBox1.Text + "%1" + TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\Jadgen\ddeexec\Application", "", "JADgen")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\Jadgen\ddeexec\Topic", "", "System")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\Jar_Setting\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\Jar Setting.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\JFR\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JFR.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\open\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAR_RUN.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\jarfile\shell\Jar_Setting", "", "Jar Setting")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Jarfile\DefaultIcon", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAR_RUN.exe" + TextBox1.Text + ",0")
    End Function
    Function xjal()
        On Error Resume Next
        My.Computer.Registry.ClassesRoot.CreateSubKey(".jal")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.jal", "", "jalfile")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Jalfile\DefaultIcon", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAVA Explorer.exe" + TextBox1.Text + ",0")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\Jalfile\shell\open\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAVA Explorer.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
    End Function
    Function xjer()
        On Error Resume Next
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Directory\shell\JE_RUN")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Directory\shell\JE_RUN\command")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\JE_RUN\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAVA Explorer.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Drive\shell\JE_RUN")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Drive\shell\JE_RUN\command")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Drive\shell\JE_RUN\command", "", TextBox1.Text + My.Application.Info.DirectoryPath + "\JAVA Explorer.exe" + TextBox1.Text + " " + TextBox1.Text + "%1" + TextBox1.Text)
    End Function
    Function vjar()
        On Error Resume Next
        xjar()
    End Function
    Function vjal()
        On Error Resume Next
        xjal()
    End Function
    Function vjer()
        On Error Resume Next
        xjer()
    End Function
    Function xp()
        On Error Resume Next
        xjar()
        xjal()
        xjer()
    End Function
    Function vista()
        On Error Resume Next
        vjal()
        vjar()
        vjer()
    End Function
End Class