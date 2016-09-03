Public Class AeroSetup
    Dim e = My.Computer.FileSystem.SpecialDirectories.Temp
    Function mount(ByVal kt As String, ByVal t2 As String)
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
        On Error GoTo x
        If My.Computer.FileSystem.DirectoryExists(kt) = True Then
            RmDir(kt)
        End If
        MkDir(kt)
        Shell("ImageX /mount " + t2 + My.Application.Info.DirectoryPath + "\" + Aero.<Aero>.<Wim>(0).Value + t2 + " 1 " + t2 + kt + t2, AppWinStyle.Hide)
        Exit Function
x:      X()
    End Function
    Function unmount(ByVal kt As String, ByVal t2 As String)
        Shell("ImageX /unmount " + t2 + kt + t2, AppWinStyle.Hide)
        On Error Resume Next
        RmDir(e + "\" + "Mount")
    End Function
    Function X()
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Shell(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing) + "\notepad.exe " + My.Application.Info.DirectoryPath + "\Aero.xml", AppWinStyle.NormalFocus)
    End Function
    Function w(ByVal t1 As String)
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Aero.xml", t1, False)
        Shell(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing) + "\notepad.exe " + My.Application.Info.DirectoryPath + "\Aero.xml", AppWinStyle.NormalFocus)
    End Function
    Function sr()
        On Error Resume Next
        Kill(e + "\" + "$ImageX\*.*")
        RmDir(e + "\" + "$ImageX")
        GoTo c
        Exit Function
c:      If My.Computer.FileSystem.FileExists(Environment.SystemDirectory + "\ImageX.exe") = False Then
            MkDir(e + "\" + "$ImageX")
            Dim a = My.Resources.ImageX_Setup
            Dim g = My.Resources.del
            My.Computer.FileSystem.WriteAllBytes(e + "\" + "$ImageX\ImageX Setup.exe", a, False)
            My.Computer.FileSystem.WriteAllText(e + "\" + "$ImageX\del.cmd", g, False)
            Shell(e + "\" + "$ImageX\ImageX Setup.exe", 0)
        End If
    End Function
    Function se()
        On Error Resume Next
        Kill(e + "\" + "$ImageX\*.*")
        RmDir(e + "\" + "$ImageX")
        Shell(e + "\" + "$ImageX\del.cmd", 0)
    End Function
End Class