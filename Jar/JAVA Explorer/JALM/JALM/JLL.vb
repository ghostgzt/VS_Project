Imports System.Windows.Forms
Public Class JLL
    Dim JJE As New JEExt.JEE
    Dim ImageList1 As New Windows.Forms.ImageList
    Dim Textbox1 As New Windows.Forms.TextBox
    Dim Textbox2 As New Windows.Forms.TextBox
    Dim Textbox3 As New Windows.Forms.TextBox
    Dim ToolStripComboBox1 As New Windows.Forms.TextBox
    Dim fa As Boolean
    Dim wj As String
    Function run(ByVal t1 As String, ByVal t2 As String, ByVal t3 As String, ByVal toolcombox As String, ByVal df As Boolean)
        wj =JJE.wjj
        Textbox1.Text = t1
        Textbox2.Text = t2
        Textbox3.Text = t3
        ToolStripComboBox1.Text = toolcombox
        fa = df
        ImageList1.ImageSize = Me.Size
        ImageList1.TransparentColor = Drawing.Color.Transparent
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        BackgroundWorker1.RunWorkerAsync()
    End Function
    Function regrun(ByVal str As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run", str)
    End Function
    Function rwj()
        Return wj
    End Function
    Function regyh(ByVal str As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", str)
    End Function
    Function AddJar()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XX", "0")
        Dim d1 As String = ""
        Dim d2 As String = ""
        Dim d3 As String = ""
        On Error Resume Next
        Dim qtx As String = ""
        Dim t = My.Computer.FileSystem.GetFiles(ToolStripComboBox1.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        If t.Count <> 0 Then
            Dim kk As String = Textbox2.Text.Replace("/Name", (ToolStripComboBox1.Text).Trim).Replace("/Num", Str(t.Count).Trim)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "1")
            ImageList1.Images.Clear()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "0")
            For x = 0 To t.Count - 1
                regyh("0")
                regrun("1")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
                JJE.endd("$JEE163.tmp")
                Dim jd As Integer = 100 / t.Count
                Dim yl As New ListBox
                yl.Items.Clear()
                If fa = True Then
                    Dim t0 As String
                    JJE.endd("$JEE163.tmp")
                    t0 = JJE.JJ(Textbox1.Text + t(x) + Textbox1.Text, 0, Textbox1.Text)
                    JJE.endd("$JEE163.tmp")
                    If t0 = "" Then
                        Dim yy = New PictureBox
                        ImageList1.Images.Add(yy.InitialImage)
                        d1 = ("Not a Jar")
                    Else
                        Dim u = ""
                        Dim micon = ""
                        Dim vedor = ""
                        Dim x0 = 0
                        Do
                            x0 = x0 + 1
                        Loop Until Mid(t0, x0, Len(vbCrLf)) = vbCrLf Or x0 > Len(t0)
                        Dim r = x0 + 1
                        Dim mnane = t0.Remove(x0)
                        Do
                            x0 = x0 + 1
                        Loop Until Mid(t0, x0, Len(vbCrLf)) = vbCrLf Or x0 > Len(t0)
                        u = x0 + 1
                        micon = t0.Remove(0, r).Remove(u - r)
                        vedor = t0.Remove(0, u)
                        Dim l = ""
                        If vedor <> "" Then
                            l = mnane + " v" + vedor
                        Else
                            l = mnane
                        End If
                        Dim yy = New PictureBox
                        yy.WaitOnLoad = True
                        yy.ErrorImage = Nothing
                        On Error Resume Next
                        yy.Image = Nothing
                        yy.ImageLocation = micon
                        If yy.Image Is Nothing Then
                            yy.Image = Nothing
                            JJE.endd("$JEE163.tmp")
                            Dim i As String
                            i = JJE.getN(JJE.Rolddir + "\META-INF\MANIFEST.MF")
                            JJE.endd("$JEE163.tmp")
                            Dim h As String
                            h = JJE.zf(Textbox1.Text + t(x) + Textbox1.Text, i, False, Textbox1.Text)
                            JJE.endd("$JEE163.tmp")
                            If h = "" Then
                                yy.Image = ImageList4.Images.Item(0)
                            Else
                                yy.WaitOnLoad = True
                                yy.ImageLocation = h
                            End If
                            If yy.Image Is Nothing Then
                                yy.Image = ImageList4.Images.Item(0)
                            End If
                        End If
                        ImageList1.Images.Add(yy.Image)
                        If l.Trim = "v" Or l = "" Then
                            l = ""
                        End If
                        d1 = (l)
                    End If
                    d2 = (t(x))
                    Dim r1 = My.Computer.FileSystem.GetFileInfo(t(x)).Length
                    d3 = (Str(Int((r1 / 1024))) + "KB")
                    kk = kk + vbCrLf + Textbox3.Text.Replace("/DZ", d1.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(x).Trim + ".png").Replace("/PPP", d2.Trim).Replace("/SSS", d3.Trim)
                Else
                    Dim y = JJE.JJ(Textbox1.Text + t(x) + Textbox1.Text, 1, Textbox1.Text)
                    If y = "" Then
                        Dim yy = New PictureBox
                        ImageList1.Images.Add(yy.InitialImage)
                    Else
                        Dim yy = New PictureBox
                        yy.WaitOnLoad = True
                        On Error Resume Next
                        yy.Image = Nothing
                        yy.ImageLocation = JJE.zf(Textbox1.Text + t(x) + Textbox1.Text, y, False, Textbox1.Text)
                        If yy.Image Is Nothing Then
                            Dim h = JJE.getM(JJE.Rolddir + "\META-INF\MANIFEST.MF", Textbox1.Text + t(x) + Textbox1.Text, 1, Textbox1.Text)
                            If h = "" Or h = JJE.Rolddir + "\" Then
                                yy.Image = ImageList4.Images.Item(0)
                            Else
                                yy.WaitOnLoad = True
                                yy.ImageLocation = h
                            End If
                        End If
                        If yy.Image Is Nothing Then
                            yy.Image = ImageList4.Images.Item(0)
                        End If
                        ImageList1.Images.Add(yy.Image)
                    End If
                    Dim b = JJE.zf(Textbox1.Text + t(x) + Textbox1.Text, y, True, Textbox1.Text)
                    Dim v = JJE.getM(JJE.Rolddir + "\META-INF\MANIFEST.MF", Textbox1.Text + t(x) + Textbox1.Text, 2, Textbox1.Text)
                    If b + " v" + v <> " v" Then
                        If v.ToString.Trim <> "" Then
                            d1 = (b + " v" + v)
                        Else
                            d1 = (b)
                        End If
                    Else
                        d1 = ("Not a Jar")
                    End If
                    d2 = (t(x))
                    Dim r1 = My.Computer.FileSystem.GetFileInfo(t(x)).Length
                    d3 = (Str(Int((r1 / 1024))) + "KB")
                    kk = kk + vbCrLf + Textbox3.Text.Replace("/DZ", d1.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(x).Trim + ".png").Replace("/PPP", d2.Trim).Replace("/SSS", d3.Trim)
                End If
                JJE.endd("$JEE163.tmp")
                On Error Resume Next
                ChDir(My.Application.Info.DirectoryPath)
                My.Computer.FileSystem.DeleteDirectory(JJE.Rolddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Me.Refresh()
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "YH", Nothing) = "1" Then
                    qtx = qtx + t(x) + vbCrLf
                    regyh("0")
                End If
                regrun("0")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "HX", Nothing) = "1" Then
                    MsgBox("唤醒成功！！！", MsgBoxStyle.Information, "唤醒命令！")
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "HX", "0")
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", Nothing) = "1" Then
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "AE", "0")
                    MsgBox("显示已中止！！！", MsgBoxStyle.Exclamation, "中止！！！")
                    GoTo e
                End If
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "NG", Str(x))
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "ZG", Str(t.Count - 1))
                ImageList1.Images.Item(x).Save(wj + "\" + Str(x).Trim + ".png")
            Next
            kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</Aero>"
            My.Computer.FileSystem.WriteAllText(wj + "\Aero.xml", kk.Replace("&", "*\*/*"), False)
            If qtx <> "" Then
                MsgBox(qtx + "可能已损坏！", MsgBoxStyle.Exclamation, "发生解压错误！！！")
            End If
e:            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "0")
        End If
    End Function
    Function bi(ByVal lj As String, ByVal d1 As String, ByVal d2 As String, ByVal d3 As String, ByVal wjs As Integer)
        On Error Resume Next
        Dim wj As String = JJE.wjj
        Dim kk As String = Textbox2.Text.Replace("/Name", (ToolStripComboBox1.Text).Trim).Replace("/Num", Str(wjs).Trim)
        For j = 0 To wjs - 1
            ImageList1.Images.Item(j).Save(wj + "\" + Str(j).Trim + ".png")
            kk = kk + vbCrLf + Textbox3.Text.Replace("/DZ", d1.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(j).Trim + ".png").Replace("/PPP", d2.Trim).Replace("/SSS", d3.Trim)
        Next
        kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</Aero>"
        My.Computer.FileSystem.WriteAllText(lj + "\Aero.xml", kk.Replace("&", "*\*/*"), False)
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "XX", "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "KS", "0")
    End Sub
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        AddJar()
    End Function
End Class