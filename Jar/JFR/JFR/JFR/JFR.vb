Imports System.Runtime.InteropServices
Public Class JFR
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim gett As New GN
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            Dim bbint As Integer = 0
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                If i = 0 Then sFirstFileName = sb.ToString
                If My.Computer.FileSystem.FileExists(sb.ToString) = True Then
                    ListBox1.Items.Remove(sb.ToString)
                    ListBox1.Items.Add(sb.ToString)
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.jar")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Dim jad = My.Resources.unzip
    Dim jt = My.Computer.FileSystem.SpecialDirectories.Temp + "\$BBF163.tmp"
    Dim yyt
    Dim olddir
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If yyt <> 0 Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .ShowNewFolderButton = False
                .Description = "请选择含有JAR的目录！！！"
                .ShowDialog()
                If .SelectedPath <> "" Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.jar")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                    Next
                    MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
                    j1.Value = 0
                    j2.Value = 0
                End If
            End With
        Else
            With OpenFileDialog1
                .FileName = ""
                .Filter = "Java程序 *.Jar|*.JAR"
                .ShowDialog()
                If .FileName <> "" Then
                    If .FileNames.Count <> 0 Then
                        MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                        For x = 0 To OpenFileDialog1.FileNames.Count - 1
                            ListBox1.Items.Remove(OpenFileDialog1.FileNames(x).Trim)
                            ListBox1.Items.Add(OpenFileDialog1.FileNames(x).Trim)
                            j1.Value = 0
                            j2.Value = 0
                        Next
                    End If
                End If
            End With
        End If
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Function del()
        If My.Computer.FileSystem.DirectoryExists(olddir) = True Then
            On Error Resume Next
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(olddir, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        On Error Resume Next
        RmDir(olddir)
        Kill(jt)
    End Function
    Function opp()
        If My.Computer.FileSystem.FileExists(jt) = False Then
            My.Computer.FileSystem.WriteAllBytes(jt, jad, False)
        End If
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        ListBox3.Items.Clear()
        Dim jr = 0
        ListBox1.Enabled = False
        If ListBox1.Items.Count <> 0 Then
            olddir = ""
            For x = 1 To ListBox1.Items.Count
                Dim y As String = Date.Now
                y = y.Replace(":", ".").Replace("\", ".").Replace("/", ".")
                del()
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y)
                olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y
                opp()
                ListBox1.SetSelected(x - 1, True)
                Dim jl = Len(ListBox1.Text)
                Dim jyy = olddir + "\META-INF\MANIFEST.MF"
                ChDir(olddir)
                Shell(TextBox1.Text + jt + TextBox1.Text + " " + TextBox1.Text + ListBox1.Text + TextBox1.Text + " -o " + " " + "META-INF\MANIFEST.MF", AppWinStyle.Hide, True)
                If My.Computer.FileSystem.FileExists(jyy) = True Then
                    run(jyy, jl)
                End If
            Next
            If ListBox3.Items.Count <> 0 Then
                For j = 0 To ListBox3.Items.Count - 1
                    ListBox3.SetSelected(j, True)
                    ListBox1.Items.Remove(ListBox3.Text)
                Next
            End If
            Dim hh = "操作失败的有："
            If ListBox1.Items.Count <> 0 Then
                For u = 0 To ListBox1.Items.Count - 1
                    ListBox1.SetSelected(u, True)
                    hh = hh + vbCrLf + ListBox1.Text
                Next
                MsgBox(hh, MsgBoxStyle.Exclamation)
            Else
                j2.Value = 100
                MsgBox("操作成功！！", MsgBoxStyle.Information)
            End If
        End If
        ListBox3.Items.Clear()
        ListBox1.Enabled = True
    End Sub
    Function run(ByVal jadu As String, ByVal jl As Integer)
        getf(jadu)
        If CheckBox1.Checked = True Then
            xn(TextBox2.Text, TextBox3.Text, jl)
        Else
            xn(TextBox2.Text, "", jl)
        End If
    End Function
    Function getf(ByVal jadu As String)
        On Error GoTo 5
        j2.Value = 0
        ListBox2.Items.Clear()
        Dim tw = My.Computer.FileSystem.ReadAllText(jadu, System.Text.Encoding.UTF8)
        Dim qw = tw.Replace(vbCr, vbCrLf)
        qw = qw.Replace(vbLf, vbCrLf)
        Dim y = Len("MIDlet-Name:")
        Dim t = Len("MIDlet-Version:")
        Dim w = Len(qw)
        For x = 0 To w - 1
            If Mid(qw, x + 1, y) = "MIDlet-Name:" Then
                ListBox2.Items.Add(qw.Remove(0, x))
            End If
        Next
        If ListBox2.Items.Count = 0 Then
            TextBox2.Text = ""

        Else
            ListBox2.SetSelected(0, True)
            TextBox2.Text = ListBox2.Text
            ListBox2.Items.Clear()
            Dim k = Len(TextBox2.Text)
            Dim u = Nothing
            For q = 0 To k - 1
                If Mid(TextBox2.Text, q + 1, 1) = vbCr Then
                    u = TextBox2.Text.Remove(q)
                    ListBox2.Items.Add(u)
                End If
            Next
            ListBox2.SetSelected(0, True)
            TextBox2.Text = ListBox2.Text
            ListBox2.Items.Clear()
            TextBox2.Text = TextBox2.Text.Replace("MIDlet-Name:", "").Trim()
5:
            On Error GoTo 6
            For x = 0 To w - 1
                If Mid(qw, x + 1, t) = "MIDlet-Version:" Then
                    ListBox2.Items.Add(qw.Remove(0, x))
                End If
            Next
            ListBox2.SetSelected(0, True)
            TextBox3.Text = ListBox2.Text
            ListBox2.Items.Clear()
            Dim d = Len(TextBox3.Text)
            Dim p = Nothing
            For q = 0 To d - 1
                If Mid(TextBox3.Text, q + 1, 1) = vbCr Then
                    p = TextBox3.Text.Remove(q)
                    ListBox2.Items.Add(p)
                End If
            Next
            ListBox2.SetSelected(0, True)
            TextBox3.Text = ListBox2.Text
            ListBox2.Items.Clear()
            TextBox3.Text = TextBox3.Text.Replace("MIDlet-Version:", "").Trim()
        End If
        Exit Function
6:
    End Function
    Function xn(ByVal jar As String, ByVal vi As String, ByVal jl As Integer)
        del()
        On Error GoTo 4
        jar = jar.Replace("MIDlet-Name:", "").Trim()
        vi = vi.Replace("MIDlet-Version:", "").Trim()
        jar = jar.Trim
        vi = vi.Trim
        vi = vi.Replace("v", "")
        If TextBox2.Text <> "" Then
            j1.Value = 0
            Timer1.Enabled = True
            jar = jar.Replace("*", " ")
            jar = jar.Replace(":", " ")
            jar = jar.Replace("\", " ")
            jar = jar.Replace("/", " ")
            jar = jar.Replace("?", " ")
            jar = jar.Replace(":", " ")
            jar = jar.Replace("<", " ")
            jar = jar.Replace(">", " ")
            jar = jar.Replace("|", " ")
            Dim n As Integer
            n = 1
            Dim kj As String
            If vi = "" Then
                jadd(jl, jar, False, "")
                kj = jar
            Else
                jadd(jl, jar, True, vi)
                jar = jar + " " + "v" + vi
                kj = jar
            End If
            If gett.getname(ListBox1.Text, "\", False).ToString.ToLower <> (jar + ".jar").ToLower Then
                While My.Computer.FileSystem.FileExists(gett.getname(ListBox1.Text, "\", True) + "\" + kj + ".jar") = True
                    kj = jar + "(" + Str(n).Trim + ")"
                    n = n + 1
                End While
                My.Computer.FileSystem.RenameFile(ListBox1.Text, kj + ".jar")
            End If
            ListBox3.Items.Add(ListBox1.Text)
            j2.Value = j2.Value + (100 / ListBox1.Items.Count)
            j1.Value = 100
        End If
        Exit Function
4:
    End Function
    Function jadd(ByVal jl As Integer, ByVal jar As String, ByVal ino As Boolean, ByVal vi As String)
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(ListBox1.Text.Remove(jl - 1) + "d") = True Then
            Dim abc = My.Computer.FileSystem.ReadAllText(ListBox1.Text.Remove(jl - 1) + "d", System.Text.Encoding.UTF8)
            If ino = False Then
                abc = abc.Replace(gett.getname(ListBox1.Text, "\", False), jar + ".jar")
                My.Computer.FileSystem.WriteAllText(ListBox1.Text.Remove(jl - 1) + "d", abc, False, System.Text.Encoding.Default)
                My.Computer.FileSystem.RenameFile(ListBox1.Text.Remove(jl - 1) + "d", jar + ".jad")
            Else
                abc = abc.Replace(gett.getname(ListBox1.Text, "\", False), jar + " " + "v" + vi + ".jar")
                My.Computer.FileSystem.WriteAllText(ListBox1.Text.Remove(jl - 1) + "d", abc, False, System.Text.Encoding.Default)
                My.Computer.FileSystem.RenameFile(ListBox1.Text.Remove(jl - 1) + "d", jar + " " + "v" + vi + ".jad")
            End If
        End If
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        On Error Resume Next
        del()
        TextBox2.Text = ""
        TextBox3.Text = ""
        j1.Value = 0
        If ListBox1.Items.Count <> 0 Then
            Dim y As String = Date.Now
            y = y.Replace(":", ".").Replace("\", ".").Replace("/", ".")
            del()
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y)
            olddir = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + y
            Timer1.Enabled = True
            Dim jl = Len(ListBox1.Text)
            Dim jyy = olddir + "\META-INF\MANIFEST.MF"
            opp()
            ChDir(olddir)
            Shell(TextBox1.Text + jt + TextBox1.Text + " " + TextBox1.Text + ListBox1.Text.Trim + TextBox1.Text + " " + "META-INF\MANIFEST.MF", AppWinStyle.Hide, True)
            If My.Computer.FileSystem.FileExists(jyy) = True Then
                getf(jyy)
            End If
            del()
            del()
            j1.Value = 100
            TextBox2.Text = TextBox2.Text.Replace("MIDlet-Name:", "").Trim()
            TextBox3.Text = TextBox3.Text.Replace("MIDlet-Version:", "").Trim()
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        TextBox2.Text = ""
        TextBox3.Text = ""
        Timer1.Enabled = False
        j1.Value = 0
        j2.Value = 0
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.Text)
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If j1.Value <= 30 Then
            j1.Value = j1.Value + 20
        End If
        If j1.Value <= 60 And j1.Value > 30 Then
            j1.Value = j1.Value + 10
        End If
        If j1.Value <= 90 And j1.Value > 600 Then
            j1.Value = j1.Value + 5
        End If
        If j1.Value <= 98 And j1.Value > 90 Then
            j1.Value = j1.Value + 5
        End If
        If j1.Value = 98 Then
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub 按文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 按文件ToolStripMenuItem.Click
        yyt = 0
        reg()
        loadreg()
    End Sub
    Private Sub 按文件夹ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 按文件夹ToolStripMenuItem.Click
        yyt = 1
        reg()
        loadreg()
    End Sub
    Function reg()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\JFR")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JFR", "WOJ", yyt)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JFR", "ZMH", 自动命令行ToolStripMenuItem.Checked)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\JFR", "BBH", CheckBox1.Checked)
    End Function
    Function loadreg()
        On Error Resume Next
        yyt = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JFR", "WOJ", Nothing)
        Dim bbr = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JFR", "ZMH", Nothing)
        Dim kkr = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\JFR", "BBH", Nothing)
        If kkr = False Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        If bbr = True Then
            自动命令行ToolStripMenuItem.Checked = True
        Else
            自动命令行ToolStripMenuItem.Checked = False
        End If
        If yyt <> 0 Then
            按文件夹ToolStripMenuItem.Checked = True
            按文件ToolStripMenuItem.Checked = False
        Else
            按文件ToolStripMenuItem.Checked = True
            按文件夹ToolStripMenuItem.Checked = False
        End If
    End Function
    Private Sub JFR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        del()
    End Sub
    Private Sub JFR_Load() Handles Me.Load
        Application.AddMessageFilter(Me)
        DragAcceptFiles(ListBox1.Handle.ToInt32, True)
        On Error Resume Next
        loadreg()
        If My.Application.CommandLineArgs.Count <> 0 Then
            Dim bbint As Integer = 0
            For t = 0 To My.Application.CommandLineArgs.Count - 1
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    ListBox1.Items.Remove(My.Application.CommandLineArgs.Item(t))
                    ListBox1.Items.Add(My.Application.CommandLineArgs.Item(t))
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(t), FileIO.SearchOption.SearchAllSubDirectories, "*.jar")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            If 自动命令行ToolStripMenuItem.Checked = True Then
                Button2_Click()
                End
            Else
                MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
    Private Sub 帮助ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem.Click
        MsgBox("作者:关镇涛(广东省开平一中)" + vbCrLf + "FQ2009~2010", MsgBoxStyle.Information, "帮助！！！")
    End Sub
    Private Sub 自动命令行ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 自动命令行ToolStripMenuItem.Click
        If 自动命令行ToolStripMenuItem.Checked = False Then
            自动命令行ToolStripMenuItem.Checked = True
        Else
            自动命令行ToolStripMenuItem.Checked = False
        End If
        reg()
        loadreg()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListBox1.Text <> "" Then
            Dim wq = MsgBox("是否要删除 " + ListBox1.Text + " ?", MsgBoxStyle.YesNoCancel, "删除文件！")
            If wq = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(ListBox1.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                ListBox1.Items.Remove(ListBox1.Text)
                TextBox2.Text = ""
                TextBox3.Text = ""
            End If
        End If
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        reg()
    End Sub
End Class