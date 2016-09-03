Public Class Jad
    Dim gt As New GN
    Function MakeJad(ByVal Jar As String)
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(Jar) = True Then
            Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jad"
            My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)
            MkDir(path)
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
            ChDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$")
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$4.tmp", My.Resources.unzip, False)
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$5.tmp", My.Resources.UTF8, False)
            ChDir(path)
            Shell(J_R.Label1.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$4.tmp" + J_R.Label1.Text + " -o " + " " + J_R.Label1.Text + Jar + J_R.Label1.Text + " " + J_R.Label1.Text + "META-INF\MANIFEST.MF" + J_R.Label1.Text, AppWinStyle.Hide, True)
            If My.Computer.FileSystem.FileExists(path + "\META-INF\MANIFEST.MF") = True Then
                ' Dim j = jad(My.Computer.FileSystem.ReadAllText(path + "\META-INF\MANIFEST.MF", System.Text.Encoding.UTF8))
                Dim j = (My.Computer.FileSystem.ReadAllText(path + "\META-INF\MANIFEST.MF", System.Text.Encoding.UTF8))
                Dim z = "MIDlet-Jar-Size: " + My.Computer.FileSystem.GetFileInfo(Jar).Length.ToString.Trim
                Dim n = "MIDlet-Jar-URL: " + My.Computer.FileSystem.GetFileInfo(Jar).Name.ToString.Trim
                My.Computer.FileSystem.WriteAllText(Mid(Jar.Replace(J_R.Label1.Text, ""), 1, Len(Jar.Replace(J_R.Label1.Text, "")) - 1) + "d", z + vbCrLf + n + vbCrLf + j, False, System.Text.Encoding.UTF8)
                Shell(J_R.Label1.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JR$\$5.tmp" + " " + J_R.Label1.Text + Mid(Jar.Replace(J_R.Label1.Text, ""), 1, Len(Jar.Replace(J_R.Label1.Text, "")) - 1) + "d" + J_R.Label1.Text, AppWinStyle.Hide, True)
                My.Computer.FileSystem.DeleteDirectory(path, FileIO.DeleteDirectoryOption.DeleteAllContents)
                J_R.allend()
            End If
        End If
    End Function
    'Function jad(ByVal MF As String)
    '    On Error Resume Next
    '    MF = MF.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf).Replace(vbCrLf + " ", "").Trim
    '    Dim eo As String = ""
    '    Dim z1 As String = ""
    '    Dim z2 As String = ""
    '    Dim z3 As String = ""
    '    Dim z4 As String = ""
    '    Dim z5 As String = ""
    '    Dim z6 As String = ""
    '    Dim z7 As String = ""
    '    Dim z8 As String = ""
    '    Dim z9 As String = ""
    '    Dim z0 As String = ""
    '    Dim za As String = ""
    '    Dim zb As String = ""
    '    If gt.getname(gt.getname(MF, "Manifest-Version:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z1 = gt.getname(gt.getname(MF, "Manifest-Version:", False, 1), vbCrLf, True, 1)
    '    Else
    '        z1 = "1.0"
    '    End If
    '    eo = "Manifest-Version: " + z1.Trim
    '    If gt.getname(gt.getname(MF, "MIDlet-Name:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z2 = gt.getname(gt.getname(MF, "MIDlet-Name:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Name: " + z2.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-Icon:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z3 = gt.getname(gt.getname(MF, "MIDlet-Icon:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Icon: " + z3.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-1:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z4 = gt.getname(gt.getname(MF, "MIDlet-1:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-1: " + z4.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-Vendor:", False, 1), vbCrLf, True, 1) = "" Then
    '        z5 = "None"
    '    Else
    '        z5 = gt.getname(gt.getname(MF, "MIDlet-Vendor:", False, 1), vbCrLf, True, 1)
    '    End If
    '    eo = eo + vbCrLf + "MIDlet-Vendor: " + z5.Trim
    '    If gt.getname(gt.getname(MF, "MIDlet-Version:", False, 1), vbCrLf, True, 1) = "" Then
    '        z6 = "1.0"
    '    Else
    '        z6 = gt.getname(gt.getname(MF, "MIDlet-Version:", False, 1), vbCrLf, True, 1)
    '    End If
    '    eo = eo + vbCrLf + "MIDlet-Version: " + z6.Trim
    '    If gt.getname(gt.getname(MF, "MIDlet-Description:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z7 = gt.getname(gt.getname(MF, "MIDlet-Description:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Description: " + z7.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-Install-Notify:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z8 = gt.getname(gt.getname(MF, "MIDlet-Install-Notify:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Install-Notify: " + z8.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-Info-URL:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z9 = gt.getname(gt.getname(MF, "MIDlet-Info-URL:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Info-URL: " + z9.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MIDlet-Data-Size:", False, 1), vbCrLf, True, 1) <> "" Then
    '        z0 = gt.getname(gt.getname(MF, "MIDlet-Data-Size:", False, 1), vbCrLf, True, 1)
    '        eo = eo + vbCrLf + "MIDlet-Data-Size: " + z0.Trim
    '    End If
    '    If gt.getname(gt.getname(MF, "MicroEdition-Configuration:", False, 1), vbCrLf, True, 1) <> "" Then
    '        za = gt.getname(gt.getname(MF, "MicroEdition-Configuration:", False, 1), vbCrLf, True, 1)
    '    Else
    '        za = "CLDC-1.1"
    '    End If
    '    eo = eo + vbCrLf + "MicroEdition-Configuration: " + za.Trim
    '    If gt.getname(gt.getname(MF, "MicroEdition-Profile:", False, 1), vbCrLf, True, 1) <> "" Then
    '        zb = gt.getname(gt.getname(MF, "MicroEdition-Profile:", False, 1), vbCrLf, True, 1)
    '    Else
    '        zb = "MIDP-2.0"
    '    End If
    '    eo = eo + vbCrLf + "MicroEdition-Profile: " + zb.Trim
    '    Return eo
    'End Function
End Class