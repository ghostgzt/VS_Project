Imports System.Runtime.InteropServices
Public Class VBS
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
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                dopen(sb.ToString)
            Next
            DragFinish(m.WParam.ToInt32)
        End If
    End Function
    Function dopen(ByVal sb As String)
        On Error Resume Next
        If TextBox1.Text <> "" Then
            Dim q = ""
            For x = 0 To Me.Text.Length - 1
                If Mid(Me.Text, x + 1, 1) = "*" Then
                    q = x
                End If
            Next
            If q <> "" Or Me.Text = rc() + "编译器 - 无标题" Then
                Dim j = MsgBox("你作出的修改还没保存！是否要保存？", MsgBoxStyle.YesNoCancel)
                If j = MsgBoxResult.Yes Then
                    ToolStripButton3_Click()
                Else
                    If j = MsgBoxResult.Cancel Then
                        GoTo d
                    End If
                End If
            End If
        End If
        db(sb.ToString)
        If (sb.Replace(TextBox2.Text, "").Split(".")(sb.Split(".").Length - 1)).ToLower = "vbs" Then
            chose(True)
            VBScriptToolStripMenuItem.Checked = True
            JavaScriptToolStripMenuItem.Checked = False
        Else
            If (sb.Replace(TextBox2.Text, "").Split(".")(sb.Split(".").Length - 1)).ToLower = "js" Then
                chose(False)
                VBScriptToolStripMenuItem.Checked = False
                JavaScriptToolStripMenuItem.Checked = True
            End If
d:      End If
    End Function
    Dim old As String
    Private Sub ToolStripButton1_Click() Handles ToolStripButton1.Click
        If TextBox1.Text <> "" Then
            Dim q = ""
            For x = 0 To Me.Text.Length - 1
                If Mid(Me.Text, x + 1, 1) = "*" Then
                    q = x
                End If
            Next
            If q <> "" Or Me.Text = rc() + "编译器 - 无标题" Then
                Dim j = MsgBox("你作出的修改还没保存！是否要保存？", MsgBoxStyle.YesNoCancel)
                If j = MsgBoxResult.Yes Then
                    ToolStripButton3_Click()
                End If
                GoTo g
            Else
                If MsgBox("你是否确定新建脚本?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
                    GoTo g
                End If
            End If
        Else
            GoTo g
        End If
        Exit Sub
g:      Me.Hide()
        SplashScreen1.ShowDialog()
        Me.Show()
    End Sub
    Function news()
        TextBox1.Text = ""
        old = ""
        If sc = 0 Then
            Me.Text = "VBS编译器 - 无标题"
        Else
            If sc = 1 Then
                Me.Text = "JS编译器 - 无标题"
            Else
                Me.Text = "WSF编译器 - 无标题"
            End If
        End If
        TextBox1.Enabled = True
        zr(True)
        ToolStripStatusLabel1.Text = "选择0个字符"
        ToolStripStatusLabel2.Text = "总共0个字符"
        Return Nothing
        Exit Function
d:
    End Function
    Private Sub ToolStripButton2_Click() Handles ToolStripButton2.Click
        If TextBox1.Text <> "" Then
            Dim q = ""
            For x = 0 To Me.Text.Length - 1
                If Mid(Me.Text, x + 1, 1) = "*" Then
                    q = x
                End If
            Next
            If q <> "" Or Me.Text = rc() + "编译器 - 无标题" Then
                Dim j = MsgBox("你作出的修改还没保存！是否要保存？", MsgBoxStyle.YesNoCancel)
                If j = MsgBoxResult.Yes Then
                    ToolStripButton3_Click()
                Else
                    If j = MsgBoxResult.Cancel Then
                        GoTo d
                    End If
                End If
            End If
        End If
        With OpenFileDialog1
            .FileName = ""
            If sc = 0 Then
                .Filter = "VBScript File *.VBS|*.VBS|All Files *.*|*.*"
            Else
                If sc = 1 Then
                    .Filter = "JavaScript File *.JS|*.JS|All Files *.*|*.*"
                Else
                    .Filter = "WSFScript File *.WSF|*.WSF|All Files *.*|*.*"
                End If
            End If
            .ShowDialog()
            If .FileName <> "" Then
                db(.FileName)
            End If
        End With
d:
    End Sub
    Function db(ByVal FileName As String)
        On Error Resume Next
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(FileName, System.Text.Encoding.Default)
        TextBox1.Enabled = True
        old = FileName
        Me.Text = rc() + "编译器 - " + FileName
        zr(True)
        ToolStripStatusLabel1.Text = "选择0个字符"
        ToolStripStatusLabel2.Text = "总共" + TextBox1.Text.Length.ToString + "个字符"
    End Function
    Function rc()
        Dim sd As String = "VBS"
        If sc = 0 Then
            sd = "VBS"
        Else
            If sc = 1 Then
                sd = "JS"
            Else
                sd = "WSF"
            End If
        End If
        Return sd
    End Function
    Function zr(ByVal tf As Boolean)
        On Error Resume Next
        ToolStripButton3.Enabled = tf
        ToolStripButton4.Enabled = tf
        ToolStripButton5.Enabled = tf
        保存ToolStripMenuItem.Enabled = tf
        另保存ToolStripMenuItem.Enabled = tf
        测试VBSToolStripMenuItem.Enabled = tf
        编辑ToolStripMenuItem.Enabled = tf
        插入语句ToolStripMenuItem.Enabled = tf
        ToolStripButton6.Enabled = tf
        ToolStripButton7.Enabled = tf
        ToolStripButton8.Enabled = tf
        ToolStripButton10.Enabled = tf
        ToolStripButton9.Enabled = tf
        ToolStripButton11.Enabled = tf
    End Function
    Private Sub ToolStripButton4_Click() Handles ToolStripButton4.Click
        If TextBox1.Text <> "" Then
            With SaveFileDialog1
                .FileName = ""
                .Filter = "*." + rc() + "|*." + rc()
                .ShowDialog()
                If .FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(.FileName, TextBox1.Text, False, System.Text.Encoding.Default)
                    old = .FileName
                    Me.Text = rc() + "编译器 - " + .FileName
                End If
            End With
        End If
    End Sub
    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        If My.Computer.FileSystem.FileExists("Notepad.exe") = True Then
            Me.Hide()
            Dim files = My.Computer.FileSystem.SpecialDirectories.Temp + "\$GL$." + rc()
            My.Computer.FileSystem.WriteAllText(files, TextBox1.Text, False, System.Text.Encoding.Default)
            Shell("Notepad.exe " + files, AppWinStyle.MaximizedFocus, True)
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(files, System.Text.Encoding.Default)
            Me.Show()
        End If
    End Sub
    Private Sub TextBox1_MouseUp() Handles TextBox1.MouseUp
        ToolStripStatusLabel1.Text = "选择" + TextBox1.SelectedText.Length.ToString + "个字符"
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If old <> "" Then
            Me.Text = "VBS编译器 - *" + old
        End If
        TextBox1_MouseUp()
        ToolStripStatusLabel1.Text = "选择" + TextBox1.SelectedText.Length.ToString + "个字符"
        ToolStripStatusLabel2.Text = "总共" + TextBox1.Text.Length.ToString + "个字符"
    End Sub
    Private Sub VBS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If TextBox1.Text <> "" Then
            Dim q = ""
            For x = 0 To Me.Text.Length - 1
                If Mid(Me.Text, x + 1, 1) = "*" Then
                    q = x
                End If
            Next
            If q <> "" Or Me.Text = rc() + "编译器 - 无标题" Then
                Dim j = MsgBox("你作出的修改还没保存！是否要保存？", MsgBoxStyle.YesNoCancel)
                If j = MsgBoxResult.Yes Then
                    ToolStripButton3_Click()
                    e.Cancel = False
                Else
                    If j = MsgBoxResult.Cancel Then
                        e.Cancel = True
                    Else
                        e.Cancel = False
                    End If
                End If
            End If
        End If
    End Sub
    Dim sc As Integer
    Private Sub VBS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Me.Handle.ToInt32, True)
        If Command() <> "" Then
            db(Command.Replace(TextBox2.Text, ""))
            zr(True)
            If (Command.Replace(TextBox2.Text, "").Split(".")(Command.Split(".").Length - 1)).ToLower = "vbs" Then
                chose(True)
                VBScriptToolStripMenuItem.Checked = True
                JavaScriptToolStripMenuItem.Checked = False
                WSFScriptToolStripMenuItem.Checked = False
            Else
                If (Command.Replace(TextBox2.Text, "").Split(".")(Command.Split(".").Length - 1)).ToLower = "js" Then
                    chose(False)
                    VBScriptToolStripMenuItem.Checked = False
                    JavaScriptToolStripMenuItem.Checked = True
                    WSFScriptToolStripMenuItem.Checked = False
                Else
                    If (Command.Replace(TextBox2.Text, "").Split(".")(Command.Split(".").Length - 1)).ToLower = "WSF" Then
                        chose(False)
                        VBScriptToolStripMenuItem.Checked = False
                        JavaScriptToolStripMenuItem.Checked = False
                        WSFScriptToolStripMenuItem.Checked = True
                    Else
                        GoTo b
                    End If
                End If
            End If
        Else
            zr(0)
            GoTo b
        End If
        Exit Sub
b:      sc = 0
        Me.Hide()
        SplashScreen1.ShowDialog()
        Me.Show()
        If sc = 0 Then
            VBScriptToolStripMenuItem.Checked = True
            JavaScriptToolStripMenuItem.Checked = False
            WSFScriptToolStripMenuItem.Checked = False
        Else
            If sc = 1 Then
                VBScriptToolStripMenuItem.Checked = False
                JavaScriptToolStripMenuItem.Checked = True
                WSFScriptToolStripMenuItem.Checked = False
            Else
                VBScriptToolStripMenuItem.Checked = False
                JavaScriptToolStripMenuItem.Checked = False
                WSFScriptToolStripMenuItem.Checked = True
            End If
        End If
    End Sub
    Private Sub ToolStripButton6_Click() Handles ToolStripButton6.Click
        If TextBox1.SelectedText.Length <> 0 Then
            TextBox1.Cut()
        End If
    End Sub
    Private Sub ToolStripButton7_Click() Handles ToolStripButton7.Click
        If TextBox1.SelectedText.Length <> 0 Then
            TextBox1.Copy()
        End If
    End Sub
    Private Sub ToolStripButton8_Click() Handles ToolStripButton8.Click
        If TextBox1.Enabled = True Then
            TextBox1.Paste()
        End If
    End Sub
    Private Sub ToolStripButton10_Click() Handles ToolStripButton10.Click
        TextBox1.SelectAll()
        TextBox1_MouseUp()
    End Sub
    Private Sub ToolStripButton13_Click() Handles ToolStripButton13.Click
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 新建ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem.Click
        ToolStripButton1_Click()
    End Sub
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        ToolStripButton2_Click()
    End Sub
    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        ToolStripButton3_Click()
    End Sub
    Private Sub 另保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 另保存ToolStripMenuItem.Click
        ToolStripButton4_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        If TextBox1.Text <> "" Then
            Dim q = ""
            For x = 0 To Me.Text.Length - 1
                If Mid(Me.Text, x + 1, 1) = "*" Then
                    q = x
                End If
            Next
            If q <> "" Or Me.Text = rc() + "编译器 - 无标题" Then
                Dim j = MsgBox("你作出的修改还没保存！是否要保存？", MsgBoxStyle.YesNoCancel)
                If j = MsgBoxResult.Yes Then
                    ToolStripButton3_Click()
                    End
                Else
                    If j = MsgBoxResult.No Then
                        End
                    End If
                End If
            End If
        Else
            End
        End If
    End Sub
    Private Sub 剪切ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪切ToolStripMenuItem.Click
        ToolStripButton6_Click()
    End Sub
    Private Sub 复制ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem.Click
        ToolStripButton7_Click()
    End Sub
    Private Sub 粘贴ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 粘贴ToolStripMenuItem.Click
        ToolStripButton8_Click()
    End Sub
    Private Sub 全选ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem.Click
        ToolStripButton10_Click()
    End Sub
    Private Sub ToolStripButton5_ButtonClick() Handles ToolStripButton5.ButtonClick
        win()
    End Sub
    Function win()
        On Error Resume Next
        Dim sf = "\$TMP." + rc()
        If TextBox1.Text <> "" Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + sf, TextBox1.Text, False, System.Text.Encoding.Default)
            Me.Hide()
            Shell("C:\WINDOWS\System32\WScript.exe " + TextBox2.Text + My.Computer.FileSystem.SpecialDirectories.Temp + sf + TextBox2.Text, AppWinStyle.NormalFocus, True)
            Me.Show()
        End If
    End Function
    Function cmd()
        On Error Resume Next
        Dim sf = "\$TMP." + rc()
        If TextBox1.Text <> "" Then
            My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + sf, TextBox1.Text, False, System.Text.Encoding.Default)
            Me.Hide()
            Shell("C:\WINDOWS\System32\CScript.exe " + TextBox2.Text + My.Computer.FileSystem.SpecialDirectories.Temp + sf + TextBox2.Text, AppWinStyle.NormalFocus, True)
            Me.Show()
        End If
    End Function
    Private Sub 测试VBSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 测试VBSToolStripMenuItem.Click
        ToolStripButton5_ButtonClick()
    End Sub
    Private Sub ToolStripButton11_Click() Handles ToolStripButton11.Click
        插入ToolStripMenuItem1_Click()
    End Sub
    Private Sub 插入语句ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 插入语句ToolStripMenuItem.Click
        ToolStripButton11_Click()
    End Sub
    Private Sub ToolStripButton12_Click() Handles ToolStripButton12.Click
        添加语句ToolStripMenuItem_Click()
    End Sub
    Private Sub 添加语句ToolStripMenuItem_Click() Handles 添加语句ToolStripMenuItem.Click
        Ad.chose1(sc)
        Me.Hide()
        Ad.TextBox1.Text = ""
        Ad.stat()
        Ad.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        ToolStripButton13_Click()
    End Sub
    Private Sub ToolStripSeparator2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripSeparator2.Click
        Me.Hide()
        Ad.TextBox1.Text = ""
        Ad.stat()
        Ad.ShowDialog()
        Me.Show()
    End Sub
    Private Sub 插入ToolStripMenuItem1_Click() Handles 插入ToolStripMenuItem1.Click
        VBSD.chose1(sc)
        VBSD.stat()
        VBSD.ShowDialog()
        TextBox1.Select()
    End Sub
    Private Sub 复制ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem1.Click
        If TextBox1.SelectedText <> "" Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
        End If
    End Sub
    Private Sub 剪贴ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪贴ToolStripMenuItem.Click
        If TextBox1.SelectedText <> "" Then
            My.Computer.Clipboard.SetText(TextBox1.SelectedText)
            TextBox1.SelectedText = ""
        End If
    End Sub
    Private Sub 删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除ToolStripMenuItem.Click
        TextBox1.SelectedText = ""
    End Sub
    Private Sub 粘贴ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 粘贴ToolStripMenuItem1.Click
        If My.Computer.Clipboard.GetText <> "" Then
            TextBox1.SelectedText = My.Computer.Clipboard.GetText
        End If
    End Sub
    Private Sub 全选ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem1.Click
        TextBox1.SelectAll()
        TextBox1_MouseUp()
    End Sub
    Private Sub 替换ToolStripMenuItem_Click() Handles 替换ToolStripMenuItem.Click
        TH.ShowDialog()
    End Sub
    Private Sub 测试ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 测试ToolStripMenuItem.Click
        ToolStripButton5_ButtonClick()
    End Sub
    Private Sub 调整语句ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 调整语句ToolStripMenuItem.Click
        ToolStripButton12_Click()
    End Sub
    Private Sub 替换ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 替换ToolStripMenuItem1.Click
        替换ToolStripMenuItem_Click()
    End Sub
    Private Sub ToolStripButton3_Click() Handles ToolStripButton3.Click
        If TextBox1.Text <> "" Then
            If Me.Text = rc() + "编译器 - 无标题" Then
                With SaveFileDialog1
                    .FileName = ""
                    .Filter = "*." + rc() + "|*." + rc()
                    .ShowDialog()
                    If .FileName <> "" Then
                        My.Computer.FileSystem.WriteAllText(.FileName, TextBox1.Text, False, System.Text.Encoding.Default)
                        old = .FileName
                        Me.Text = rc() + "编译器 - " + old
                    End If
                End With
            Else
                My.Computer.FileSystem.WriteAllText(old, TextBox1.Text, False)
                Me.Text = rc() + "编译器 - " + old
            End If
        End If
    End Sub
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        替换ToolStripMenuItem_Click()
    End Sub
    Private Sub ILoveYouToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ILoveYouToolStripMenuItem.Click
        MsgBox(TextBox3.Text, MsgBoxStyle.Information, "一个永恒的神话——GhostGzt")
    End Sub
    Private Sub 存为语句ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 存为语句ToolStripMenuItem.Click
        Ad.TextBox1.Text = TextBox1.SelectedText
        ToolStripButton12_Click()
    End Sub
    Private Sub ContextMenuStrip1_Opening() Handles ContextMenuStrip1.Opening
        Dim tf As Boolean
        If TextBox1.SelectedText.Trim <> "" Then
            tf = True
        Else
            tf = False
        End If
        存为语句ToolStripMenuItem.Visible = tf
        剪切ToolStripMenuItem.Visible = tf
        剪贴ToolStripMenuItem.Visible = tf
        复制ToolStripMenuItem1.Visible = tf
        复制ToolStripMenuItem.Visible = tf
        删除ToolStripMenuItem.Visible = tf
        If My.Computer.FileSystem.FileExists("Notepad.exe") = False Then
            高亮代码ToolStripMenuItem.Visible = False
            ToolStripSeparator15.Visible = False
        Else
            高亮代码ToolStripMenuItem.Visible = True
            ToolStripSeparator15.Visible = True
        End If
    End Sub
    Private Sub 编辑ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.DropDownOpening
        ContextMenuStrip1_Opening()
    End Sub
    Function chose(ByVal des As Integer)
        On Error Resume Next
        If des = 0 Then
            sc = 0
            tc(0)
        Else
            If des = 1 Then
                sc = 1
                tc(1)
            Else
                sc = 2
                tc(2)
            End If
        End If
    End Function
    Function tc(ByVal fg As Integer)
        If fg = 0 Then
            测试VBSToolStripMenuItem.Text = "测试VBS"
            Try
                Me.Text = "VBS编译器 -" + Me.Text.Split("-")(1)
            Catch ex As Exception
                Me.Text = "VBS编译器"
            End Try
        Else
            If fg = 1 Then
                测试VBSToolStripMenuItem.Text = "测试JS"
                Try
                    Me.Text = "JS编译器 -" + Me.Text.Split("-")(1)
                Catch ex As Exception
                    Me.Text = "JS编译器"
                End Try
            Else
                测试VBSToolStripMenuItem.Text = "测试WSF"
                Try
                    Me.Text = "WSF编译器 -" + Me.Text.Split("-")(1)
                Catch ex As Exception
                    Me.Text = "WSF编译器"
                End Try
            End If
        End If
        Return Nothing
    End Function
    Private Sub VBScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VBScriptToolStripMenuItem.Click
        If VBScriptToolStripMenuItem.Checked = False Then
            VBScriptToolStripMenuItem.Checked = True
            JavaScriptToolStripMenuItem.Checked = False
            WSFScriptToolStripMenuItem.Checked = False
            chose(0)
        End If
    End Sub
    Private Sub JavaScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaScriptToolStripMenuItem.Click
        If JavaScriptToolStripMenuItem.Checked = False Then
            JavaScriptToolStripMenuItem.Checked = True
            VBScriptToolStripMenuItem.Checked = False
            WSFScriptToolStripMenuItem.Checked = False
            chose(1)
        End If
    End Sub
    Private Sub 窗口模式ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 窗口模式ToolStripMenuItem.Click
        win()
    End Sub
    Private Sub 命令行模式ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 命令行模式ToolStripMenuItem.Click
        cmd()
    End Sub
    Private Sub 教程帮助ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 教程帮助ToolStripMenuItem.Click
        On Error Resume Next
        Shell("hh " + My.Application.Info.DirectoryPath + "\Script.chm", AppWinStyle.MaximizedFocus, False)
    End Sub
    Private Sub 帮助ToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem.DropDownOpening
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Script.chm") = True Then
            教程帮助ToolStripMenuItem.Enabled = True
        Else
            教程帮助ToolStripMenuItem.Enabled = False
        End If
    End Sub
    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        If TextBox1.WordWrap = True Then
            ToolStripButton14.Checked = False
            TextBox1.WordWrap = False
        Else
            ToolStripButton14.Checked = True
            TextBox1.WordWrap = True
        End If
    End Sub
    Private Sub WSFScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WSFScriptToolStripMenuItem.Click
        If WSFScriptToolStripMenuItem.Checked = False Then
            WSFScriptToolStripMenuItem.Checked = True
            JavaScriptToolStripMenuItem.Checked = False
            VBScriptToolStripMenuItem.Checked = False
            chose(2)
        End If
    End Sub
    Private Sub 高亮代码ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 高亮代码ToolStripMenuItem.Click
        TextBox1_DoubleClick(sender, e)
    End Sub
End Class