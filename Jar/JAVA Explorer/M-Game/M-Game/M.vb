Imports System.Runtime.InteropServices
Public Class M
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim JJE As New JEExt.JEE
    Dim tbS As String
    Dim tf As String = ""
    Dim mouseOffset
    Dim op
    Const CtrlMask As Byte = 8
    Dim ddc As String
    Dim kn As New MissWindows.MissWindow
    Dim xxx As String
    Dim mz As String
    Dim zj As Integer
    Dim tm As String
    Function bi(ByVal dd As String)
        On Error GoTo l
        Dim wj As String = JJE.wjj
        If mz Is Nothing Then
            mzz = ""
        Else
            If mzz <> "" Then
                mzz = mzz.Replace("<", "###!#").Replace(">", "#!##")
            End If
            On Error Resume Next
            mzp.Save(wj + "\Micon.png")
        End If
        Dim kk As String = TextBox2.Text.Replace("/Name", Label1.Text.Replace("&", "*\*/*").Replace("<", "###!#").Replace(">", "#!##")).Replace("/Num", Str(ListView1.Items.Count).Trim).Replace("/MMM", mzz)
        For x = 0 To ListView1.Items.Count - 1
            ImageList1.Images.Item(ListView1.Items.Item(x).ImageIndex).Save(wj + "\" + Str(x).Trim + ".png")
            kk = kk + vbCrLf + TextBox3.Text.Replace("/DZ", ListView1.Items.Item(x).SubItems.Item(0).Text.Replace("<", "###!#").Replace(">", "#!##")).Replace("/Png", Str(x).Trim + ".png").Replace("/PPP", ListView1.Items.Item(x).SubItems.Item(1).Text.Trim).Replace("/SSS", ListView1.Items.Item(x).SubItems.Item(2).Text.Trim)
        Next
        kk = kk + vbCrLf + "    </Files>" + vbCrLf + "</Aero>"
        My.Computer.FileSystem.WriteAllText(wj + "\Aero.xml", kk.Replace("&", "*\*/*"), False)
        jje.obb(wj, dd, TextBox1.Text)
        Return 0
        Exit Function
l:      MsgBox("Failed！", MsgBoxStyle.Exclamation)
    End Function
    Private Sub M_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        enddd()
    End Sub
    Dim zt As String
    Function cxxx()
        On Error Resume Next
        If Command() = "" Then
            xxx = "Default"
        Else
            xxx = Command.Trim
        End If
    End Function
    Function enddd()
        bi(ddc)
        cxxx()
        On Error Resume Next
        MkDir(My.Application.Info.DirectoryPath + "\Ku")
        Dim kop = TextBox4.Text
        kop = Replace(kop, "/Name", Label1.Text.Replace("&", "*\*/*").Replace("<", "###!#").Replace(">", "#!##"))
        kop = Replace(kop, "/PPP", ToolStripTextBox2.Text)
        kop = Replace(kop, "/HHH", ToolStripTextBox1.Text)
        kop = Replace(kop, "/JJJ", ToolStripTextBox4.Text)
        kop = Replace(kop, "/OOO", Me.Opacity)
        kop = Replace(kop, "/XXX", Me.Left)
        kop = Replace(kop, "/YYY", Me.Top)
        kop = Replace(kop, "/MMM", mz)
        kop = Replace(kop, "/ZJZ", zj)
        kop = Replace(kop, "/TTT", tbS)
        kop = Replace(kop, "/ZZZ", zt)
        kop = Replace(kop, "/TMT", tm)
        kop = Replace(kop, "/GDG", gdd)
        kop = Replace(kop, "/FNF", Label1.Font.Name)
        kop = Replace(kop, "/FSF", Label1.Font.Size)
        kop = Replace(kop, "/FBF", Label1.Font.Bold)
        kop = Replace(kop, "/FIF", Label1.Font.Italic)
        kop = Replace(kop, "/FOF", Label1.Font.Strikeout)
        kop = Replace(kop, "/FUF", Label1.Font.Underline)
        kop = Replace(kop, "/FCF", Label1.ForeColor.Name)
        kop = Replace(kop, "/TST", Me.TransparencyKey.ToArgb)
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Ku" + "\" + xxx + ".Xml", kop, False)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Run", "0")
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JEE168.tmp")
    End Function
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Dim guding = False
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Function di(ByVal str As String, ByVal srr As Boolean)
        On Error Resume Next
        Dim ddc As String = str
        Dim Aero = XDocument.Load(ddc + "\Aero.xml")
        If srr = True Then
            ListView1.Items.Clear()
            ListView1.LargeImageList = ImageList1
            ImageList1.Images.Clear()
        End If
        bgg = Button1.BackgroundImage
        If mz <> "" Then
            Dim ii = Image.FromFile(ddc + "\Micon.png")
            If ii Is Nothing Then
                mzp = Nothing
            Else
                mzp = ii
            End If
            mzz = Aero.<Aero>.<MZZ>.Value
        End If
        For x = 0 To CInt(Aero.<Aero>.<FileNum>.Value) - 1
            Dim yb = PictureBox2
            PictureBox2.Image = Nothing
            yb.WaitOnLoad = True
            yb.ErrorImage = Nothing
            yb.Image = Nothing
            yb.ImageLocation = ddc + "\" + Aero.<Aero>.<Files>.<File>(x).<Pic>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim knn As String = Aero.<Aero>.<Files>.<File>(x).<Name>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kpp As String = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            Dim kss As String = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
            If srr = False Then
                Dim kq = 0
                For t = 0 To ListBox1.Items.Count - 1
                    If ListBox1.Items(t) = kpp Then
                        kq = 1
                    End If
                Next
                ImageList1.Images.Add(yb.Image)
                If kq = 0 Then
                    ListBox1.Items.Add(kpp)
                    If knn <> "Not a Jar" And knn <> "" Then
                        ListView1.Items.Add(knn, ImageList1.Images.Count - 1)
                        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
                    Else
                        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", Nothing) <> "1" Then
                            ListView1.Items.Add(knn, ImageList1.Images.Count - 1)
                            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
                        End If
                    End If
                End If
            Else
                ImageList1.Images.Add(yb.Image)
                If knn <> "Not a Jar" And knn <> "" Then
                    ListView1.Items.Add(knn, x)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                    ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
                Else
                    If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JAVA Explorer", "YC", Nothing) <> "1" Then
                        ListView1.Items.Add(knn, x)
                        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
                        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
                    End If
                End If
            End If
            On Error Resume Next
            ListBox1.Items.Clear()
            For xw = 0 To ListView1.Items.Count - 1
                Dim ke = ListView1.Items.Item(xw).SubItems(1).Text
                ListBox1.Items.Add(ke)
            Next
        Next
        On Error Resume Next
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(ddc, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Private Sub ListView1_MouseDoubleClick() Handles ListView1.MouseDoubleClick
        On Error Resume Next
        Dim runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        If ListView1.SelectedItems.Count = 1 Then
            Dim t = (ListView1.SelectedItems.Item(0).SubItems(1).Text)
            Shell(runer + " " + TextBox1.Text + t + TextBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean, ByVal n As Integer)
        Dim q = ""
        Dim i = 0
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, Len(str1f)) = str1f Then
                    If i < n Or n = 0 Then
                        q = u
                        i = i + 1
                    End If
                End If
            Next
        End If
        If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + Len(str1f))
            Else
                Return str.Remove(q)
            End If
        Else
            If qh = True Then
                Return str
            Else
                Return ""
            End If
        End If
    End Function
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                If i = 0 Then sFirstFileName = sb.ToString
                If My.Computer.FileSystem.FileExists(sb.ToString) = True Then
                    Dim kq = 0
                    If getname(sb.ToString, ".", False, 0).ToString.Trim.ToLower = "jar" Then
                        For x = 0 To ListBox1.Items.Count - 1
                            If ListBox1.Items(x).ToString.ToLower = sb.ToString.ToLower Then
                                kq = 1
                            End If
                        Next
                        If kq = 0 Then
                            ListBox1.Items.Add(sb.ToString)
                            kkk()
                        End If
                    Else
                        If getname(sb.ToString, ".", False, 0).ToString.Trim.ToLower = "jal" Then
                            Dim dde = sb.ToString
                            If My.Computer.FileSystem.FileExists(dde) = True Then
                                Dim kktt As String = jje.odd(dde, TextBox1.Text)
                                di(kktt, False)
                            End If
                        End If
                    End If
                Else
                    If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                        Dim fo = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.jar")
                        For y = 0 To fo.Count - 1
                            Dim kq = 0
                            For x = 0 To ListBox1.Items.Count - 1
                                If ListBox1.Items(x) = fo(y) Then
                                    kq = 1
                                End If
                            Next
                            If kq = 0 Then
                                ListBox1.Items.Add(fo(y))
                                kkk()
                            End If
                        Next
                    End If
                End If
            Next
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Function kkk()
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Then
            AddJar()
        End If
    End Function
    Dim mbg As Image
    Private Sub M_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mbg = My.Resources.I1
        cxxx()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "End", "0")
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Run", Nothing) = "1" Then
            Dim rr = MsgBox("已经运行" + xxx + "库," + vbCrLf + "是否重新载入?", MsgBoxStyle.YesNo)
            If rr = MsgBoxResult.Yes Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "End", "1")
            Else
                End
            End If
        End If
        readd(xxx)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Run", "1")
        ddc = My.Application.Info.DirectoryPath + "\Ku" + "\" + xxx + ".Jal"
        If My.Computer.FileSystem.FileExists(ddc) = True Then
            Dim kktt As String = JJE.odd(ddc, TextBox1.Text)
            di(kktt, True)
        End If
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "End", "0")
        Timer1.Enabled = True
        ListBox1.Items.Clear()
        For x = 0 To ListView1.Items.Count - 1
            Dim ke = ListView1.Items.Item(x).SubItems(1).Text
            ListBox1.Items.Add(ke)
        Next
        Me.Refresh()
    End Sub
    Dim k1 = 0
    Function readd(ByVal xxx As String)
        On Error Resume Next
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Ku" + "\" + xxx + ".xml")
        Dim knn As String = Aero.<Aero>.<Tile>.Value
        Dim kpp As String = Aero.<Aero>.<Pic>.Value
        Dim kss As String = Aero.<Aero>.<Height>.Value
        Dim kdd As String = Aero.<Aero>.<BJ>.Value
        Dim koo As String = Aero.<Aero>.<Op>.Value
        Dim kxx As String = Aero.<Aero>.<X>.Value
        Dim kyy As String = Aero.<Aero>.<Y>.Value
        Dim kmm As String = Aero.<Aero>.<MZ>.Value
        Dim kzj As String = Aero.<Aero>.<ZJ>.Value
        Dim ktt As String = Aero.<Aero>.<TB>.Value
        Dim kzt As String = Aero.<Aero>.<ZT>.Value
        Dim ktm As String = Aero.<Aero>.<TM>.Value
        Dim kgd As String = Aero.<Aero>.<GD>.Value
        Dim kfn As String = Aero.<Aero>.<FN>.Value
        Dim kfs As String = Aero.<Aero>.<FS>.Value
        Dim kfb As String = Aero.<Aero>.<FB>.Value
        Dim kfi As String = Aero.<Aero>.<FI>.Value
        Dim kfo As String = Aero.<Aero>.<FO>.Value
        Dim kfu As String = Aero.<Aero>.<FU>.Value
        Dim kfc As String = Aero.<Aero>.<FC>.Value
        Dim kts As String = Aero.<Aero>.<TS>.Value
        If kts <> "" Then
            Me.TransparencyKey = Color.FromArgb(kts)
        End If
        If kfc <> "" Then
            Label1.ForeColor = Color.FromName(kfc)
        End If
        If kfn <> "" And kfs <> "" Then
            Label1.Font = (ccolor(kfn, CInt(kfs), FontStyle.Regular))
        End If
        Dim bbb = Nothing
        Dim iii = Nothing
        Dim sss = Nothing
        Dim uuu = Nothing
        If CBool(kfb) = True Then
            bbb = FontStyle.Bold
        End If
        If CBool(kfi) = True Then
            iii = FontStyle.Italic
        End If
        If CBool(kfo) = True Then
            sss = FontStyle.Strikeout
        End If
        If CBool(kfu) = True Then
            uuu = FontStyle.Underline
        End If
        Label1.Font = (ccolor(kfn, CInt(kfs), bbb + iii + sss + uuu))
        If kzt <> "" Then
            zt = kzt
            rzt(zt)
            k1 = 1
            ToolStripTextBox6.Text = kzt
            k1 = 0
        End If
        If kss = "" Then
            ToolStripTextBox1.Text = Me.Height
        Else
            ToolStripTextBox1.Text = kss
        End If
        ToolStripTextBox2.Text = kpp
        ToolStripTextBox3.Text = knn.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
        ToolStripTextBox4.Text = kdd
        If koo <> "" Or koo <> "0" And CInt(koo) < 1 Then
            ToolStripTextBox5.Text = koo
        End If
        Me.Left = kxx
        Me.Top = kyy
        kkld(ktt)
        mz = kmm
        If mz <> "" Then
            设为默认ToolStripMenuItem.Text = "解除默认"
        Else
            设为默认ToolStripMenuItem.Text = "设为默认"
            设为默认ToolStripMenuItem.Visible = False
        End If
        yc = Me.Height
        yk = Me.Width
        If kzj = "1" Then
            最简模式ToolStripMenuItem.Checked = True
            最简模式ToolStripMenuItem_Click()
        Else
            最简模式ToolStripMenuItem.Checked = False
            固定ToolStripMenuItem.Visible = False
        End If
        If kgd = "1" Then
            gdd = 1
            guding = True
            固定ToolStripMenuItem.Checked = True
        Else
            gdd = 0
            guding = False
            固定ToolStripMenuItem.Checked = False
        End If
        If 最简模式ToolStripMenuItem.Checked = True And guding = True Then
            Button1.Cursor = Cursors.Hand
        Else
            Button1.Cursor = Cursors.Default
        End If
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "M-Game " + xxx, Nothing)
        If r1 <> "" Then
            开机启动ToolStripMenuItem.Checked = True
        Else
            开机启动ToolStripMenuItem.Checked = False
        End If
        If ktm = "1" Then
            顶端显示ToolStripMenuItem.Checked = True
            kn.miss(Me, True, False)
            tm = "1"
        Else
            顶端显示ToolStripMenuItem.Checked = False
            kn.miss(Me, False, False)
            tm = "0"
        End If
    End Function
    Function kkld(ByVal ktt As String)
        rd = "1"
        On Error Resume Next
        Dim tbl As Integer = 48
        If ktt = "24*24" Then
            tbl = 24
            tbS = "24*24"
        End If
        If ktt = "48*48" Then
            tbl = 48
            tbS = "48*48"
        End If
        If ktt = "64*64" Then
            tbl = 64
            tbS = "64*64"
        End If
        If ktt = "128*128" Then
            tbl = 128
            tbS = "128*128"
        End If
        If ktt = "256*256" Then
            tbl = 256
            tbS = "256*256"
        End If
        ToolStripComboBox1.Text = tbS
        PictureBox2.Width = tbl
        PictureBox2.Height = tbl
        ImageList1.ImageSize = PictureBox2.Size
        If tbl = 48 Then
            Me.Width = 200
        End If
        If tbl = 24 Then
            Me.Width = 160
        End If
        If tbl = 64 Then
            Me.Width = 240
        End If
        If tbl = 128 Then
            Me.Width = 200
        End If
        If tbl = 256 Then
            Me.Width = 320
        End If
        yc = Me.Height
        yk = Me.Width
        rd = "0"
    End Function
    Function AddJar()
        regrun("1")
        Dim kkt As String = ListBox1.Items.Item(ListBox1.Items.Count - 1)
        Dim d1 As String
        Dim d2 As String
        Dim d3 As String
        Dim t0 As String
        jje.endd("$JEE163.tmp")
        t0 = jje.JJ(TextBox1.Text + kkt + TextBox1.Text, 0, TextBox1.Text)
        jje.endd("$JEE163.tmp")
        If t0 = "" Then
            Dim yy = PictureBox2
            PictureBox2.Image = Nothing
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
            Dim l = mnane + " v" + vedor
            Dim yy = PictureBox2
            PictureBox2.Image = Nothing
            yy.WaitOnLoad = True
            yy.ErrorImage = Nothing
            On Error Resume Next
            yy.Image = Nothing
            yy.ImageLocation = micon
            If yy.Image Is Nothing Then
                yy.Image = Nothing
                jje.endd("$JEE163.tmp")
                Dim i As String
                i = jje.getN(jje.Rolddir + "\META-INF\MANIFEST.MF")
                jje.endd("$JEE163.tmp")
                Dim h As String
                h = jje.zf(TextBox1.Text + kkt + TextBox1.Text, i, False, TextBox1.Text)
                jje.endd("$JEE163.tmp")
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
            d1 = l
        End If
        d2 = (kkt)
        Dim r1 = My.Computer.FileSystem.GetFileInfo(kkt).Length
        d3 = (Str(Int((r1 / 1024))) + "KB")
        ListView1.Items.Add(d1, ImageList1.Images.Count - 1)
        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(d2)
        ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(d3)
        regrun("0")
    End Function
    Private Sub 运行ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 运行ToolStripMenuItem.Click
        ListView1_MouseDoubleClick()
    End Sub
    Private Sub 打开方式ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开方式ToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim ke = ListView1.SelectedItems.Item(0).SubItems(1).Text
            If My.Computer.FileSystem.FileExists(ke) = True Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ke, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub 列表移除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 列表移除ToolStripMenuItem.Click
        On Error Resume Next
        For x = 0 To ListView1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListView1.SelectedItems(0).SubItems(1).Text)
            ListView1.SelectedItems.Item(0).Remove()
        Next
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem.Click
        If MsgBox("是否确定清空?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            ImageList1.Images.Clear()
            ListView1.Items.Clear()
            ListBox1.Items.Clear()
            mz = ""
            mzp = Nothing
            mzz = ""
            设为默认ToolStripMenuItem.Text = "设为默认"
        End If
    End Sub
    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        On Error Resume Next
        If CInt(ToolStripTextBox1.Text) > 50 Then
            Me.Height = ToolStripTextBox1.Text
        End If
    End Sub
    Private Sub ToolStripTextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.TextChanged
        On Error Resume Next
        If ToolStripTextBox2.Text.Trim = "" Then
            Button1.BackgroundImage = mbg
            bgg = mbg
        Else
            Button1.BackgroundImage = Image.FromFile(ToolStripTextBox2.Text)
            mbg = Image.FromFile(ToolStripTextBox2.Text)
            bgg = Image.FromFile(ToolStripTextBox2.Text)
        End If
    End Sub
    Private Sub ToolStripTextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox3.TextChanged
        On Error Resume Next
        Label1.Text = ToolStripTextBox3.Text
    End Sub
    Private Sub Label1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        固定ToolStripMenuItem_Click()
    End Sub
    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Label1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.SelectedItems.Count < 2 And ListView1.SelectedItems.Count <> 0 Then
            运行ToolStripMenuItem.Visible = True
            打开方式ToolStripMenuItem.Visible = True
            If 设为默认ToolStripMenuItem.Text = "设为默认" Then
                设为默认ToolStripMenuItem.Visible = True
            Else
                设为默认ToolStripMenuItem.Visible = True
            End If
            属性ToolStripMenuItem.Visible = True
        Else
            运行ToolStripMenuItem.Visible = False
            打开方式ToolStripMenuItem.Visible = False
            If 设为默认ToolStripMenuItem.Text = "设为默认" Then
                设为默认ToolStripMenuItem.Visible = False
            Else
                设为默认ToolStripMenuItem.Visible = True
            End If
            属性ToolStripMenuItem.Visible = False
        End If
            If ListView1.SelectedItems.Count <> 0 Then
                列表移除ToolStripMenuItem.Visible = True
            Else
                列表移除ToolStripMenuItem.Visible = False
            End If
    End Sub
    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        On Error Resume Next
        If (e.Button = MouseButtons.Left And guding = False And 最简模式ToolStripMenuItem.Checked = True) Or (e.Button = MouseButtons.Left And 最简模式ToolStripMenuItem.Checked = False) Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        enddd()
        End
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        enddd()
        End
    End Sub
    Private Sub ToolStripTextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox5.TextChanged
        On Error Resume Next
        Me.Opacity = ToolStripTextBox5.Text
    End Sub
    Private Sub ToolStripTextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox4.TextChanged
        On Error Resume Next
        If ToolStripTextBox4.Text <> "" Then
            ListView1.BackgroundImage = Image.FromFile(ToolStripTextBox4.Text)
        Else
            ListView1.BackgroundImage = Nothing
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        cxxx()
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "End", Nothing)
        If r2 = "1" Then
            enddd()
            End
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\M-Game\Ku\" + xxx)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Jal", Nothing)
        If r1 <> "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Jal", "")
            di(r1, False)
        End If
    End Sub
    Dim yc As Integer
    Dim yk As Integer
    Private Sub 最简模式ToolStripMenuItem_Click() Handles 最简模式ToolStripMenuItem.Click
        ListView1.SelectedItems.Clear()
        If zj <> "1" Then
            Me.Height = Button1.Height
            Me.Width = Button1.Width
            Button2.SendToBack()
            zj = "1"
            最简模式ToolStripMenuItem.Checked = True
            固定ToolStripMenuItem.Visible = True
        Else
            Me.Height = yc
            Me.Width = yk
            Button2.BringToFront()
            zj = "0"
            最简模式ToolStripMenuItem.Checked = False
            固定ToolStripMenuItem.Visible = False
        End If
        If 最简模式ToolStripMenuItem.Checked = True And guding = True Then
            Button1.Cursor = Cursors.Hand
        Else
            Button1.Cursor = Cursors.Default
        End If
    End Sub
    Dim bgg As Image = Nothing
    Dim mzp As Image = Nothing
    Dim mzz As String = Nothing
    Private Sub 设为默认ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设为默认ToolStripMenuItem.Click
        On Error Resume Next
        If 设为默认ToolStripMenuItem.Text = "设为默认" Then
            mz = ListView1.SelectedItems.Item(0).SubItems(1).Text
            bgg = Button1.BackgroundImage
            Button1.BackgroundImage = ImageList1.Images.Item(ListView1.SelectedItems.Item(0).ImageIndex)
            mzp = ImageList1.Images.Item(ListView1.SelectedItems.Item(0).ImageIndex)
            mzz = ListView1.SelectedItems.Item(0).Text
            设为默认ToolStripMenuItem.Text = "解除默认"
            MsgBox(ListView1.SelectedItems.Item(0).Text + "已被设为默认！", MsgBoxStyle.Information)
        Else
            mz = ""
            Button1.BackgroundImage = bgg
            mzp = Nothing
            mzz = ""
            设为默认ToolStripMenuItem.Text = "设为默认"
            MsgBox(ListView1.SelectedItems.Item(0).Text + "已被解除默认！", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If zj = "1" And mz.Trim <> "" And gdd = 1 Then
            Dim runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
            Dim t = mz
            Shell(runer + " " + TextBox1.Text + t.Trim + TextBox1.Text, AppWinStyle.NormalFocus)
        Else
            If mz.Trim = "" And gdd = 1 Then
                最简模式ToolStripMenuItem_Click()
            End If
            'If mz.Trim <> "" And gdd = 0 Then
            '    最简模式ToolStripMenuItem_Click()
            'End If
        End If
    End Sub
    Dim rd = "0"
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If rd <> "1" Then
            bi(ddc)
            kkld(ToolStripComboBox1.Text)
            Dim kktt As String = JJE.odd(ddc, TextBox1.Text)
            di(kktt, True)
        End If
    End Sub
    Private Sub 保存列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存列表ToolStripMenuItem.Click
        enddd()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\M-Game\Ku\" + xxx, "Run", "1")
    End Sub
    Private Sub 属性ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 属性ToolStripMenuItem.Click
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Mini JE.exe") = True Then
            Me.Hide()
            Shell(My.Application.Info.DirectoryPath + "\Mini JE.exe" + " F " + TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, AppWinStyle.NormalFocus, True)
            Me.Show()
        Else
            regrun("1")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "0")
            Dim qb = JJE.JJ(TextBox1.Text + ListView1.SelectedItems.Item(0).SubItems(1).Text + TextBox1.Text, 3, TextBox1.Text)
            regrun("0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run1", "1")
            MsgBox(qb, MsgBoxStyle.Information, ListView1.SelectedItems.Item(0).Text + "属性")
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(JJE.Rolddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Me.Refresh()
        End If
    End Sub
    Function regrun(ByVal str As String)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\WaitStop")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\WaitStop", "Run", str)
    End Function
    Function rzt(ByVal ztt As String)
        On Error Resume Next
        Dim kktt As String
        cxxx()
        ChDir(My.Application.Info.DirectoryPath)
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + xxx + "\*.*")
        jje.ddd(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + xxx, ztt, TextBox1.Text)
        kktt = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + xxx
        PictureBox1.WaitOnLoad = True
        Panel1.BackgroundImage = Image.FromFile(kktt + "\1.zt")
        PictureBox1.BackgroundImage = Image.FromFile(kktt + "\2.zt")
        PictureBox1.ImageLocation = kktt + "\3.zt"
        If ToolStripTextBox2.Text.Trim = "" Then
            ListView1.BackgroundImage = Image.FromFile(kktt + "\4.zt")
        End If
        If ToolStripTextBox4.Text.Trim = "" Then
            Button1.BackgroundImage = Image.FromFile(kktt + "\5.zt")
        End If
    End Function
    Private Sub ToolStripTextBox6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox6.TextChanged
        If My.Computer.FileSystem.FileExists(ToolStripTextBox6.Text) = True And k1 = 0 Then
            zztt()
        End If
        If ToolStripTextBox6.Text = "0" And k1 = 0 Then
            ToolStripTextBox6.Text = ""
            zt = ""
            zztt()
        End If
    End Sub
    Function zztt()
        zt = ToolStripTextBox6.Text
        enddd()
        If Command() = "" Then
            Shell(My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe")
        Else
            Shell(My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + " " + Command())
        End If
        End
    End Function
    Private Sub 开机启动ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开机启动ToolStripMenuItem.Click
        With 开机启动ToolStripMenuItem
            If .Checked = True Then
                .Checked = False
                Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
                ke.DeleteValue("M-Game " + xxx)
            Else
                .Checked = True
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "M-Game " + xxx, My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + xxx)
            End If
        End With
    End Sub
    Private Sub 顶端显示ToolStripMenuItem_Click() Handles 顶端显示ToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
            顶端显示ToolStripMenuItem.Checked = False
            tm = "0"
        Else
            Me.TopMost = True
            顶端显示ToolStripMenuItem.Checked = True
            tm = "1"
        End If
    End Sub
    Function fopen(ByVal pat As String)
        With OpenFileDialog1
            .FileName = ""
            .Filter = pat
            .ShowDialog()
            If .FileName <> "" Then
                Return .FileName
            Else
                Return ""
            End If
        End With
    End Function
    Private Sub 浏览ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 浏览ToolStripMenuItem.Click
        ToolStripTextBox4.Text = fopen("*.Jpg;*.Jpeg;*.Png;*.Bmp;*.Gif|*.Jpg;*.Jpeg;*.Png;*.Bmp;*.Gif")
    End Sub
    Private Sub 浏览ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 浏览ToolStripMenuItem1.Click
        ToolStripTextBox2.Text = fopen("*.Jpg;*.Jpeg;*.Png;*.Bmp;*.Gif|*.Jpg;*.Jpeg;*.Png;*.Bmp;*.Gif")
    End Sub
    Private Sub 浏览ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 浏览ToolStripMenuItem3.Click
        ToolStripTextBox6.Text = fopen("*.Jaz|*.Jaz")
        MsgBox("填0为默认主题！！！", MsgBoxStyle.Information, "温馨提示！！！")
    End Sub
    Dim gdd As Integer = 0
    Private Sub 固定ToolStripMenuItem_Click() Handles 固定ToolStripMenuItem.Click
        On Error Resume Next
        If gdd = 0 Then
            gdd = 1
            guding = True
            Button1.Cursor = Cursors.Hand
            固定ToolStripMenuItem.Checked = True
            MsgBox("已被固定！", MsgBoxStyle.Information)
        Else
            gdd = 0
            guding = False
            Button1.Cursor = Cursors.Hand
            固定ToolStripMenuItem.Checked = False
            MsgBox("已被解除固定！", MsgBoxStyle.Information)
        End If
        If 最简模式ToolStripMenuItem.Checked = True And guding = True Then
            Button1.Cursor = Cursors.Hand
        Else
            Button1.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub 字体ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 字体ToolStripMenuItem.Click
        On Error Resume Next
        FontDialog1.Font = Label1.Font
        FontDialog1.Color = Label1.ForeColor
        With FontDialog1
            .ShowColor = True
            .ShowDialog(Me)
        End With
        If FontDialog1.Font Is Label1.Font Then
        Else
            Label1.Font = (FontDialog1.Font)
            Label1.ForeColor = FontDialog1.Color
        End If
    End Sub
    Function ccolor(ByVal name As String, ByVal size As Integer, ByVal style As FontStyle)
        Dim ii As New Font(name, size, style)
        Return ii
    End Function
    Private Sub 透明色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 透明色ToolStripMenuItem.Click
        ColorDialog1.Color = Me.TransparencyKey
        With ColorDialog1
            .ShowDialog(Me)
        End With
        If ColorDialog1.Color = Me.TransparencyKey Then
        Else
            Dim tty = Color.FromArgb(ColorDialog1.Color.A, ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            Me.TransparencyKey = tty
        End If
    End Sub
    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        Button1.BackgroundImage = mbg
        ToolTip1.SetToolTip(Button1, "")
    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        If mzp Is Nothing Then
        Else
            If mz <> "" Then
                Button1.BackgroundImage = mzp
                ToolTip1.SetToolTip(Button1, mzz)
            End If
            End If
    End Sub
End Class