Imports System.Runtime.InteropServices
Public Class PCD
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
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
                    ListBox1.Items.Remove(gnn.getname(sb.ToString, ".", True, 0) + "." + gnn.getname(sb.ToString, ".", False, 0).ToString.ToUpper)
                    ListBox1.Items.Add(gnn.getname(sb.ToString, ".", True, 0) + "." + gnn.getname(sb.ToString, ".", False, 0).ToString.ToUpper)
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
                        ListBox1.Items.Add(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
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
    Dim LL As New ListBox
    Dim se As Integer
    Private Sub PCD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim tmp As String
        tmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG"
        del(tmp)
    End Sub
    Dim bs As Integer = 0
    Private Sub PCD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        se = 5
        ComboBox1.Text = "256"
        If My.Application.CommandLineArgs.Count <> 0 Then
            Dim n As Integer = 0
            If My.Application.CommandLineArgs.Item(0) = "/JS" Then
                n = 1
                bs = 1
            End If
            Dim bbint As Integer = 0
            For t = n To My.Application.CommandLineArgs.Count - 1
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    ListBox1.Items.Remove(My.Application.CommandLineArgs.Item(t))
                    ListBox1.Items.Add(My.Application.CommandLineArgs.Item(t))
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(t), FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
                        ListBox1.Items.Add(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            If My.Application.CommandLineArgs.Item(0) = "/JS" Then
                se = loadreg()
                Button4_Click()
                End
            End If
            If n = 0 Then
                MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End If
        Application.AddMessageFilter(Me)
        DragAcceptFiles(ListBox1.Handle.ToInt32, True)
        reg()
    End Sub
    Function loadreg()
        On Error Resume Next
        Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "SE", Nothing)
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "FS", Nothing)
        If Str(r1).Trim = "1" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If CheckBox1.Checked = True Then
        End If
        If Str(r0) = "" Then
            Return CInt(5)
        Else
            Return CInt(r0)
        End If
    End Function
    Function doit(ByVal Path As String, ByVal Real As String)
        On Error Resume Next
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\PNG", My.Resources.PNG, False)
        Kill(Path + "-or8.png")
        Shell(My.Computer.FileSystem.SpecialDirectories.Temp + "\PNG -force -ordered -nofloyd -nofs " + ComboBox1.Text.Trim + " " + Label2.Text + Path + Label2.Text, AppWinStyle.Hide, True)
        If My.Computer.FileSystem.FileExists(Path + "-or8.png") = True Then
            If My.Computer.FileSystem.GetFileInfo(Path + "-or8.png").Length <> 0 Then
                If 备份ToolStripMenuItem.Checked = True Then
                    My.Computer.FileSystem.MoveFile(Real, Real + ".Bak", True)
                End If
                My.Computer.FileSystem.CopyFile(Path + "-or8.png", Real, True)
                LL.Items.Add(Real)
            Else
                Kill(Path + "-or8.png")
            End If
        End If
    End Function
    Function JS(ByVal Path As String)
        On Error GoTo k
        PictureBox1.Image = Nothing
        Dim tmp As String
        tmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG"
        del(tmp)
        mkJD(tmp)
        Dim Tgif As String = tmp + "\" + rand() + ".pgf"
        Dim Tpng As String = tmp + "\" + rand() + ".png"
        Dim yuan As String = tmp + "\" + rand() + ".pcd"
        Dim patt As String = tmp + "\" + rand() + ".tmp"
        If se <> 4 And se <> 21 And se <> 22 Then
            My.Computer.FileSystem.CopyFile(Path, patt, True)
            Dim gg As Image = Image.FromFile(patt)
            gg.Save(yuan, System.Drawing.Imaging.ImageFormat.Bmp)
            gg = Nothing
            ImgEdit1.Image = yuan
            ImgEdit1.Display()
            ImgEdit1.SaveAs(Tgif, ImgeditLibCtl.FileTypeConstants.wiFileTypeBMP, CInt(se), ImgeditLibCtl.EditCommandConstants.wiCopyEditText, ImgeditLibCtl.AnnotationTypeConstants.wiNone, False)
            Dim MM As New Bitmap(Tgif)
            MM.Save(Tpng, Imaging.ImageFormat.Png)
            If My.Computer.FileSystem.FileExists(Tpng) = True And My.Computer.FileSystem.GetFileInfo(Tpng).Length <> 0 Then
                If 备份ToolStripMenuItem.Checked = True Then
                    My.Computer.FileSystem.MoveFile(Path, Path + ".Bak", True)
                End If
                My.Computer.FileSystem.CopyFile(Tpng, Path, True)
                LL.Items.Add(Path)
            Else
                GoTo k
            End If
            MM = Nothing
        Else
            My.Computer.FileSystem.CopyFile(Path, yuan, True)
            Dim GG As Image = Image.FromFile(yuan)
            If GG.PixelFormat = Imaging.PixelFormat.Format24bppRgb Or GG.PixelFormat = Imaging.PixelFormat.Format24bppRgb Or GG.PixelFormat = Imaging.PixelFormat.Format32bppPArgb Or GG.PixelFormat = Imaging.PixelFormat.Format32bppArgb Or GG.PixelFormat = Imaging.PixelFormat.Format32bppRgb Or GG.PixelFormat = Imaging.PixelFormat.Format48bppRgb Or GG.PixelFormat = Imaging.PixelFormat.Format64bppArgb Or GG.PixelFormat = Imaging.PixelFormat.Format64bppPArgb Then
                If GG Is Nothing Then
                    GoTo k
                Else
                    GG.Save(Tgif, System.Drawing.Imaging.ImageFormat.Gif)
                    Dim MM As New Bitmap(Tgif)
                    MM.Save(Tpng, Imaging.ImageFormat.Png)
                    GG = Nothing
                    If My.Computer.FileSystem.FileExists(Tpng) = True And My.Computer.FileSystem.GetFileInfo(Tpng).Length <> 0 Then
                        If 备份ToolStripMenuItem.Checked = True Then
                            My.Computer.FileSystem.MoveFile(Path, Path + ".Bak", True)
                        End If
                        My.Computer.FileSystem.CopyFile(Tpng, Path, True)
                        LL.Items.Add(Path)
                    Else
                        GoTo k
                    End If
                    MM = Nothing
                End If
            End If
        End If
k:      del(tmp)
    End Function
    Function del(ByVal tmp As String)
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(tmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Function mkJD(ByVal Dir1 As String)
        On Error Resume Next
        MkDir(Dir1)
    End Function
    Function rand()
        Dim rd = New System.Random()
        Return rd.Next().ToString()
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddWJ()
    End Sub
    Function AddWJ()
        On Error Resume Next
        ProgressBar1.Value = 0
        PictureBox1.Image = Nothing
        With OpenFileDialog1
            .FileName = ""
            .Filter = "PNG图片 *.PNG|*.PNG|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        ListBox1.Items.Remove(gnn.getname(OpenFileDialog1.FileNames(x).Trim, ".", True, 0) + "." + gnn.getname(OpenFileDialog1.FileNames(x).Trim, ".", False, 0).ToString.ToUpper)
                        ListBox1.Items.Add(gnn.getname(OpenFileDialog1.FileNames(x).Trim, ".", True, 0) + "." + gnn.getname(OpenFileDialog1.FileNames(x).Trim, ".", False, 0).ToString.ToUpper)
                    Next
                End If
            End If
        End With
    End Function
    Function AddML()
        On Error Resume Next
        ProgressBar1.Value = 0
        PictureBox1.Image = Nothing
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有PNG的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                For qq = 0 To tt.count - 1
                    ListBox1.Items.Remove(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
                    ListBox1.Items.Add(gnn.getname(tt(qq), ".", True, 0) + "." + gnn.getname(tt(qq), ".", False, 0).ToString.ToUpper)
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AddML()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox1.Image = Nothing
        ListBox1.Items.Clear()
    End Sub
    Dim gnn As New GN
    Private Sub Button4_Click() Handles Button4.Click
        On Error Resume Next
        If ListBox1.Items.Count <> 0 Then
            PictureBox1.Image = Nothing
            ListBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False
            LL.Items.Clear()
            ProgressBar1.Value = 0
            For sq = 1 To 7
                If se = sq Then
                    For x = 0 To ListBox1.Items.Count - 1
                        JS(ListBox1.Items.Item(x))
                        ProgressBar1.Value = ProgressBar1.Value + ListBox1.Items.Count / 100
                    Next
                    GoTo f
                End If
            Next
            Dim gg As Image
            Dim tmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\$PNG"
            del(tmp)
            mkJD(tmp)
            For tx = 0 To ListBox1.Items.Count - 1
                Dim yuan As String = tmp + "\" + rand() + ".pcd"
                My.Computer.FileSystem.CopyFile(ListBox1.Items.Item(tx), yuan)
                gg = Nothing
                If CheckBox1.Checked = True Then
                    PictureBox1.Image = Nothing
                    PictureBox1.Image = Image.FromFile(yuan)
                    Me.PictureBox1.InvertColors()
                    gg = PictureBox1.Image
                Else
                    gg = Image.FromFile(yuan)
                End If
                Dim kkbb As String = tmp + "\" + rand() + ".Png"
                gg.Save(kkbb, System.Drawing.Imaging.ImageFormat.Png)
                doit(kkbb.ToUpper, (ListBox1.Items.Item(tx)))
                Kill(yuan)
                ProgressBar1.Value = ProgressBar1.Value + ListBox1.Items.Count / 100
            Next
f:
            For y = 0 To LL.Items.Count - 1
                Dim yt = LL.Items.Item(y)
                ListBox1.Items.Remove(yt)
            Next
            If ListBox1.Items.Count <> 0 Then
                If bs = 0 Then
                    MsgBox(Str(ListBox1.Items.Count) + " Files is Failed！！！", MsgBoxStyle.Exclamation)
                End If
            Else
                If bs = 0 Then
                    MsgBox("Sucessful！！！", MsgBoxStyle.Information)
                End If
            End If
            ProgressBar1.Value = 100
            ListBox1.Enabled = True
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            Button5.Enabled = True
            Button6.Enabled = True
        End If
    End Sub
    Private Sub 降色ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 降色ToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Private Sub 添加文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文件ToolStripMenuItem.Click
        AddWJ()
    End Sub
    Private Sub 添加目录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加目录ToolStripMenuItem.Click
        AddML()
    End Sub
    Private Sub 删除这一条ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem.Click
        On Error Resume Next
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        PictureBox1.Image = Nothing
        PictureBox1.Image = Image.FromFile(ListBox1.Text)
        If CheckBox1.Checked = True Then
            Me.PictureBox1.InvertColors()
        End If
    End Sub
    Private Sub 备份ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 备份ToolStripMenuItem.Click
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\PCD")
        If 备份ToolStripMenuItem.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "BF", "0")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PCD", "BF", "1")
        End If
        reg()
    End Sub
    Function reg()
        On Error Resume Next
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PCD", "BF", Nothing)
        If r1 = "1" Then
            备份ToolStripMenuItem.Checked = True
        Else
            备份ToolStripMenuItem.Checked = False
        End If
    End Function
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.SelectedItems.Count <> 0 Then
            删除这一条ToolStripMenuItem.Visible = True
        Else
            删除这一条ToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            With ComboBox1
                If .Text = "2" Then
                    se = 10
                End If
                If .Text = "3" Then
                    se = 11
                End If
                If .Text = "4" Then
                    se = 12
                End If
                If .Text = "5" Then
                    se = 13
                End If
                If .Text = "6" Then
                    se = 14
                End If
                If .Text = "7" Then
                    se = 15
                End If
                If .Text = "8" Then
                    se = 16
                End If
                If .Text = "10" Then
                    se = 17
                End If
                If .Text = "12" Then
                    se = 18
                End If
                If .Text = "14" Then
                    se = 19
                End If
                If .Text = "16" Then
                    se = 20
                End If
                If .Text = "24" Then
                    se = 21
                End If
                If .Text = "32" Then
                    se = 22
                End If
                If .Text = "48" Then
                    se = 23
                End If
                If .Text = "64" Then
                    se = 24
                End If
                If .Text = "128" Then
                    se = 25
                End If
                If .Text = "256" Then
                    se = 26
                End If
                If .Text = "512" Then
                    se = 27
                End If
                If .Text = "2色灰" Then
                    se = 1
                End If
                If .Text = "4色灰" Then
                    se = 2
                End If
                If .Text = "256色灰" Then
                    se = 3
                End If
                If .Text = "256色A" Then
                    se = 4
                End If
                If .Text = "256色B" Then
                    se = 5
                End If
                If .Text = "24位色" Then
                    se = 6
                End If
                If .Text = "32位色" Then
                    se = 7
                End If
            End With
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.PictureBox1.InvertColors()
    End Sub
End Class