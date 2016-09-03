Public Class JEE
    Dim jad = My.Resources.unzip
    Dim jt As String
    Dim jd As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\$JEE168.tmp"
    Dim rar As String
    Dim yyt
    Dim olddir
    Dim TextBox2 As String
    Dim TextBox3 As String
    Dim TextBox4 As String
    Dim jm = AppWinStyle.Hide
    Function del()
        If My.Computer.FileSystem.DirectoryExists(olddir) = True Then
            On Error Resume Next
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(olddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Function
    Function JJ(ByVal jar As String, ByVal MON As Integer, ByVal yinhao As String)
        On Error Resume Next
        TextBox2 = ""
        TextBox3 = ""
        TextBox4 = ""
        Dim jr = 0
        If jar <> "" Then
            opp()
            olddir = ""
            Dim y As String = Date.Now
            y = y.Replace(":", ".").Replace("\", ".").Replace("/", ".")
            del()
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon\" + y)
            olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon\" + y
            Dim jl = Len(jar)
            Dim jyy = olddir + "\META-INF\MANIFEST.MF"
            ChDir(olddir)
            endd("$JEE163.tmp")
            If rar <> "" Then
                VZ()
                Shell(jt + " " + "X -inul -o+ -n" + yinhao + "META-INF" + yinhao + " " + jar, jm, True)
            Else
                Shell(yinhao + jt + yinhao + " -o " + " " + jar + " " + yinhao + "META-INF\MANIFEST.MF" + yinhao, jm, True)
            End If
            endd("$JEE163.tmp")
            If My.Computer.FileSystem.FileExists(jyy) = True Then
                If MON = 0 Then
                    Return getM(jyy, jar, 0, yinhao)
                End If
                If MON = 1 Then
                    getN(jyy)
                    Return TextBox2
                End If
                If MON = 3 Then
                    Return My.Computer.FileSystem.ReadAllText(jyy, System.Text.Encoding.UTF8)
                End If
            End If
        End If
    End Function
    Function opp()
        On Error Resume Next
        endd("$JEE163.tmp")
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JAVA Explorer")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "VZ", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "JM", Nothing)
        If r1 = "1" Then
            rar = My.Application.Info.DirectoryPath + "\vz.idx"
            jt = rar
        Else
            rar = ""
            jt = My.Application.Info.DirectoryPath + "\uz.idx"
            If My.Computer.FileSystem.FileExists(jt) = False Then
                My.Computer.FileSystem.WriteAllBytes(jt, jad, False)
            End If
        End If
            If r2 = "1" Then
                jm = AppWinStyle.NormalFocus
            Else
                jm = AppWinStyle.Hide
            End If
    End Function
    Function obb(ByVal jw As String, ByVal cw As String, ByVal fgf As String)
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(jd) = False Then
            My.Computer.FileSystem.WriteAllBytes(jd, My.Resources.zip, False)
        End If
        ChDir(jw)
        Shell(fgf + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JEE168.tmp" + fgf + " -r " + fgf + cw + fgf + " " + "*.*", jm, True)
        On Error Resume Next
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(jw, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Function wjj()
        Dim cw As String
        On Error Resume Next
        Dim d As String = Date.Now
        Dim ymd As String = d.Replace(":", ".").Replace("/", "-").Replace(" ", "-")
        cw = My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jal\" + ymd
        MkDir(cw)
        ChDir(cw)
        Return cw
    End Function
    Function getpic()
        Return My.Resources.十八岁了__叹息
    End Function
    Function odd(ByVal jw As String, ByVal fgf As String)
        Dim cw As String
        cw = wjj()
        On Error Resume Next
        opp()
        If jw <> "" Then
            If rar <> "" Then
                VZ()
                ChDir(cw)
                Shell(jt + " " + "X -inul -o+" + " " + fgf + jw + fgf + " " + fgf + cw + fgf, jm, True)
            Else
                Shell(fgf + jt + fgf + " -o " + " " + fgf + jw + fgf, jm, True)
            End If
        End If
        Return cw
    End Function
    Function ddd(ByVal cw As String, ByVal jw As String, ByVal fgf As String)
        On Error Resume Next
        MkDir(cw)
        ChDir(cw)
        opp()
        If rar <> "" Then
            VZ()
            Shell(jt + " " + "X -inul -o+" + " " + fgf + jw + fgf + " " + fgf + cw + fgf, jm, True)
        Else
            Shell(fgf + jt + fgf + " -o " + " " + fgf + jw + fgf, jm, True)
        End If
    End Function
    Function getN(ByVal MF As String)
        TextBox2 = ""
        TextBox3 = ""
        TextBox4 = ""
        On Error Resume Next
        Dim tw = My.Computer.FileSystem.ReadAllText(MF, System.Text.Encoding.UTF8)
        Dim qw = tw.Replace(vbCr, vbCrLf)
        qw = qw.Replace(vbLf, vbCrLf)
        Dim y = Len("MIDlet-1:")
        Dim w = Len(qw)
        Dim x As Integer = 0
        Dim tt As Integer = 0
        Do
            x = x + 1
        Loop Until Mid(qw, x, y) = "MIDlet-1:" Or x > w
        tt = x
        x = x - 1
        If x <= w Then
            Do
                x = x + 1
            Loop Until Mid(qw, x, Len(vbCrLf)) = vbCrLf Or x > w
            TextBox2 = (qw.Remove(0, tt - 1).Remove(x - tt))
            TextBox2 = TextBox2.Replace("MIDlet-1:", "").Trim()
            Return TextBox2
        Else
            TextBox2 = ""
        End If
    End Function
    Function getM(ByVal MF As String, ByVal jar As String, ByVal AOIOV As Integer, ByVal yinhao As String)
        TextBox2 = ""
        TextBox3 = ""
        TextBox4 = ""
        On Error Resume Next
        Dim tw = My.Computer.FileSystem.ReadAllText(MF, System.Text.Encoding.UTF8)
        Dim qw = tw.Replace(vbCr, vbCrLf)
        qw = qw.Replace(vbLf, vbCrLf)
        If AOIOV = 0 Then
            Dim y = Len("MIDlet-Name:")
            Dim w = Len(qw)
            Dim x As Integer = 0
            Dim tt As Integer = 0
            Do
                x = x + 1
            Loop Until Mid(qw, x, y) = "MIDlet-Name:" Or x > w
            tt = x
            x = x - 1
            If x <= w Then
                Do
                    x = x + 1
                Loop Until Mid(qw, x, Len(vbCrLf)) = vbCrLf Or x > w
                If (x - w) = 1 Then
                    TextBox2 = (qw.Remove(0, tt - 1))
                Else
                    TextBox2 = (qw.Remove(0, tt - 1).Remove(x - tt))
                End If
                TextBox2 = TextBox2.Replace("MIDlet-Name:", "").Trim()
            Else
                TextBox2 = ""
            End If
        End If
        If AOIOV = 0 Or AOIOV = 1 Then
            Dim y0 = Len("MIDlet-Icon:")
            Dim w0 = Len(qw)
            Dim x0 As Integer = 0
            Dim tt0 As Integer = 0
            Do
                x0 = x0 + 1
            Loop Until Mid(qw, x0, y0) = "MIDlet-Icon:" Or x0 > w0
            tt0 = x0
            x0 = x0 - 1
            If x0 <= w0 Then
                Do
                    x0 = x0 + 1
                Loop Until Mid(qw, x0, Len(vbCrLf)) = vbCrLf Or x0 > w0
                If (x0 - w0) = 1 Then
                    TextBox3 = (qw.Remove(0, tt0 - 1))
                Else
                    TextBox3 = (qw.Remove(0, tt0 - 1).Remove(x0 - tt0))
                End If
                TextBox3 = TextBox3.Replace("MIDlet-Icon:", "").Trim()
            Else
                TextBox3 = ""
            End If
        End If
        If AOIOV = 2 Or AOIOV = 0 Then
            Dim y1 = Len("MIDlet-Version:")
            Dim w1 = Len(qw)
            Dim x1 As Integer = 0
            Dim tt1 As Integer = 0
            Do
                x1 = x1 + 1
            Loop Until Mid(qw, x1, y1) = "MIDlet-Version:" Or x1 > w1
            tt1 = x1
            x1 = x1 - 1
            If x1 <= w1 Then
                Do
                    x1 = x1 + 1
                Loop Until Mid(qw, x1, Len(vbCrLf)) = vbCrLf Or x1 > w1
                If (x1 - w1) = 1 Then
                    TextBox4 = (qw.Remove(0, tt1 - 1))
                Else
                    TextBox4 = (qw.Remove(0, tt1 - 1).Remove(x1 - tt1))
                End If
                TextBox4 = TextBox4.Replace("MIDlet-Version:", "").Trim()
            Else
                TextBox4 = ""
            End If
        End If
        endd("$JEE163.tmp")
        If AOIOV = 0 Then
            Return TextBox2.Trim + vbCrLf + icoo(TextBox3, jar, yinhao) + vbCrLf + TextBox4
        End If
        If AOIOV = 1 Then
            Return icoo(TextBox3, jar, yinhao)
        End If
        If AOIOV = 2 Then
            Return TextBox4
        End If
    End Function
    Function Rolddir()
        Return olddir
    End Function
    Function zf(ByVal jar As String, ByVal M1 As String, ByVal noi As Boolean, ByVal yinhao As String)
        If M1 <> "" Then
            On Error Resume Next
            Dim micon As String = ""
            Dim t = 0
            Do
                t = t + 1
            Loop Until Mid(M1.Trim, t, 1) = "," Or t > Len(M1.Trim)
            Dim mname As String
            mname = ""
            mname = M1.Trim.Remove(t - 1)
            Dim y = t
            If noi = True Then
                Return mname
            Else
                If y < Len(M1.Trim) Then
                    Do
                        t = t + 1
                    Loop Until Mid(M1.Trim, t, 1) = "," Or t > Len(M1.Trim)
                    If t - y > 2 Then
                        micon = M1.Trim.Remove(0, y).Replace("/", "\").Remove(t - y - 1)
                    Else
                        micon = ""
                    End If
                End If
                If Mid(micon.Trim, 1, 1) <> "\" Then
                    micon = "\" + micon.Trim
                End If
                opp()
                ChDir(olddir)
                If micon.Trim <> "\" Then
                    endd("$JEE163.tmp")
                    If rar <> "" Then
                        VZ()
                        Shell(jt + " " + "X -inul -o+ -n" + yinhao + micon.Trim.Remove(0, 1).Split("\".ToCharArray, 2)(0) + yinhao + " " + jar, jm, True)
                    Else
                        Shell(yinhao + jt + yinhao + " -o " + " " + jar + " " + micon.Trim.Remove(0, 1), jm, True)
                    End If
                    endd("$JEE163.tmp")
                End If
                Dim jyy = olddir + micon
                Return jyy
            End If
        End If
    End Function
    Function icoo(ByVal micon As String, ByVal jar As String, ByVal yinhao As String)
        micon = micon.Trim.Replace("/", "\")
        If Mid(micon.Trim, 1, 1) <> "\" Then
            micon = "\" + micon.Trim
        End If
        opp()
        ChDir(olddir)
        If micon.Trim <> "\" Then
            endd("$JEE163.tmp")
            If rar <> "" Then
                VZ()
                Shell(jt + " " + "X -inul -o+ -n" + yinhao + micon.Trim.Remove(0, 1).Split("\".ToCharArray, 2)(0) + yinhao + " " + jar, jm, True)
            Else
                Shell(yinhao + jt + yinhao + " -o " + " " + jar + " " + micon.Trim.Remove(0, 1), jm, True)
            End If
            endd("$JEE163.tmp")
        End If
        Dim jyy = olddir + micon
        Return jyy
    End Function
    Function endd(ByVal d As String)
        On Error Resume Next
        If rar <> "" Then
            d = "$JEEVZ.tmp"
        End If
        Dim myProcesses() As Process
        Dim myProcess As Process
        myProcesses = Process.GetProcessesByName(d)
        For Each myProcess In myProcesses
            myProcess.Kill()
        Next
    End Function
    Function issize(ByVal h As Integer, ByVal w As Integer)
        Dim pp As New System.Windows.Forms.PictureBox
        pp.Height = h
        pp.Width = w
        Return pp.Size
    End Function
    Function VZ()
        On Error Resume Next
        rar = My.Application.Info.DirectoryPath + "\vz.idx"
        If My.Computer.FileSystem.FileExists(rar) = False Then
            My.Computer.FileSystem.WriteAllBytes(rar, My.Resources.Vista_Ziper, False)
        End If
    End Function
End Class