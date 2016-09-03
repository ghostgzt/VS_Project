Imports System.Runtime.InteropServices
Public Class GNE
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    Dim getname As New GN
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
                    ListBox1.Items.Remove(sb.ToString)
                    ListBox1.Items.Add(sb.ToString)
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, WJLXText.Text)
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
    Private Sub 文件ToolStripMenuItem1_Click() Handles 文件ToolStripMenuItem1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.*|*.*"
            .ShowDialog()
            If .FileNames.Count <> 0 And .FileNames(0) <> "" Then
                For i = 0 To .FileNames.Count - 1
                    ListBox1.Items.Remove(.FileNames(i))
                    ListBox1.Items.Add(.FileNames(i))
                    ListBox1.Items.Remove("")
                Next
                MsgBox("添加了" + Str(.FileNames.Count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Sub
    Private Sub 目录全部ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 目录全部ToolStripMenuItem.Click
        TM(0)
    End Sub
    Function TM(ByVal int As Integer)
        On Error GoTo u
        If WJLXText.Text <> "" Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .ShowDialog()
                If .SelectedPath <> "" Then
                    Dim tt
                    If int = 0 Then
                        tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, WJLXText.Text)
                    Else
                        tt = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly, WJLXText.Text)
                    End If
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                    Next
                    MsgBox("添加了" + Str(tt.count) + "个", MsgBoxStyle.Information, "温馨提示！！！")
                End If
            End With
        Else
            MsgBox("文件类型不能空！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
        End If
        Exit Function
u:      MsgBox("添加目录出错！！！请检查文件类型！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
    End Function
    Private Sub 目录根下ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 目录根下ToolStripMenuItem.Click
        TM(1)
    End Sub
    Private Sub 回收站ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 回收站ToolStripMenuItem.Click
        SW(0)
    End Sub
    Function SW(ByVal int As Integer)
        On Error GoTo t
        If ListBox1.Text <> "" Then
            If int = 0 Then
                My.Computer.FileSystem.DeleteFile(ListBox1.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            Else
                My.Computer.FileSystem.DeleteFile(ListBox1.Text, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.ThrowException)
            End If
            ListBox1.Items.Remove(ListBox1.Text)
        End If
t:
    End Function
    Private Sub 永久删除ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 永久删除ToolStripMenuItem.Click
        SW(1)
    End Sub
    Private Sub 删除路径ToolStripMenuItem_Click() Handles 删除路径ToolStripMenuItem.Click
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub 清空列表ToolStripMenuItem_Click() Handles 清空列表ToolStripMenuItem.Click
        cls()
        ListBox1.Items.Clear()
    End Sub
    Private Sub ToolStripTextBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub 开启ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开启ToolStripMenuItem4.Click
        开启ToolStripMenuItem4.Checked = True
        开启ToolStripMenuItem5.Checked = False
        KTHHText.Enabled = True
        KZText.Enabled = False
    End Sub
    Private Sub 开启ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开启ToolStripMenuItem5.Click
        开启ToolStripMenuItem4.Checked = False
        开启ToolStripMenuItem5.Checked = True
        KTHHText.Enabled = False
        KZText.Enabled = True
    End Sub
    Private Sub 打开ToolStripMenuItem_Click() Handles 打开ToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.Text <> "" Then
            If ListBox1.Text <> "" Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ListBox1.Text, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        End
    End Sub
    Private Sub 添加文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加文件ToolStripMenuItem.Click
        文件ToolStripMenuItem1_Click()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        删除路径ToolStripMenuItem_Click()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        文件ToolStripMenuItem1_Click()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        清空列表ToolStripMenuItem_Click()
    End Sub
    Private Sub 打开ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem1.Click
        打开ToolStripMenuItem_Click()
    End Sub
    Private Sub 清空列表ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清空列表ToolStripMenuItem1.Click
        清空列表ToolStripMenuItem_Click()
    End Sub
    Private Sub 退出ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem1.Click
        退出ToolStripMenuItem_Click()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        退出ToolStripMenuItem_Click()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        打开ToolStripMenuItem_Click()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListBox1.Items.Count <> 0 Then
            If XLTHText.Text <> "0" Then
                If XLYText.Text.Length < CInt(XLTHText.Text) Then
                    Dim lN As New ListBox
                    lN.Items.Clear()
                    PP.Value = 0
                    Dim JD = 100 / ListBox1.Items.Count
                    For r = 0 To ListBox1.Items.Count - 1
                        Dim TF = ListBox1.Items(r).ToString
                        Dim TQ = getname.getname(TF, "\", True)
                        Dim TH = getname.getname(TF, "\", False)
                        If Mid(TH, 1, XLYText.Text.Length) = XLYText.Text Then
                            TH = Mid(TH, XLYText.Text.Length + 1, Len(TH) - XLYText.Text.Length)
                            While Len(TH) < (CInt(XLTHText.Text) - XLYText.Text.Length)
                                TH = XLZText.Text + TH
                            End While
                            On Error GoTo y
                            Dim sxx = XLYText.Text
                            If SetBox.CheckBox7.Checked = True Then
                                If FT.Checked = True Then
                                    sxx = FJZH(False, sxx)
                                Else
                                    sxx = FJZH(True, sxx)
                                End If
                            End If
                            If My.Computer.FileSystem.FileExists(TQ + "\" + sxx + TH) = False Then
                                My.Computer.FileSystem.RenameFile(TF, sxx + TH)
                                lN.Items.Add(ListBox1.Items(r).ToString)
                            End If
                            GoTo g
                            Exit Sub
y:                          MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                            GoTo g
                            Exit Sub
g:
                        End If
                        Dim ppt = PP.Value + JD
                        If ppt < 100 Then
                            PP.Value = ppt
                        Else
                            PP.Value = 100
                        End If
                    Next
                    On Error Resume Next
                    PP.Value = 100
                    For u = 0 To lN.Items.Count - 1
                        ListBox1.Items.Remove(lN.Items(u).ToString)
                    Next
                    kk()
                End If
            Else
                nowee()
            End If
        End If
    End Sub
    Function t0()
        On Error Resume Next
        TextBox1.Text = ""
        If ListBox1.Text <> "" Then
            If XLTHText.Text <> "0" Then
                If XLYText.Text.Length < CInt(XLTHText.Text) Then
                    Dim TF = ListBox1.Text
                    Dim TQ = getname.getname(TF, "\", True)
                    Dim TH = getname.getname(TF, "\", False)
                    If Mid(TH, 1, XLYText.Text.Length) = XLYText.Text Then
                        TH = Mid(TH, XLYText.Text.Length + 1, Len(TH) - XLYText.Text.Length)
                        While Len(TH) < (CInt(XLTHText.Text) - XLYText.Text.Length)
                            TH = XLZText.Text + TH
                        End While
                        Dim sxx = XLYText.Text
                        If SetBox.CheckBox7.Checked = True Then
                            If FT.Checked = True Then
                                sxx = FJZH(False, sxx)
                            Else
                                sxx = FJZH(True, sxx)
                            End If
                        End If
                        TextBox1.Text = sxx + TH
                    End If
                End If
            End If
        End If
    End Function
    Private Sub XLTHText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XLTHText.TextChanged
        On Error GoTo y
        Dim c = CInt(XLTHText.Text)
        If c < 0 Then
            GoTo y
        End If
        Exit Sub
y:      XLTHText.Text = "0"
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.Text <> "" Then
            打开ToolStripMenuItem1.Enabled = True
            删除这一条ToolStripMenuItem1.Enabled = True
        Else
            打开ToolStripMenuItem1.Enabled = False
            删除这一条ToolStripMenuItem1.Enabled = False
        End If
    End Sub
    Function cls()
        On Error Resume Next
        TC.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Function
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        cls()
        If ListBox1.Text <> "" Then
            TC.Text = ListBox1.Text
            t0()
            t1()
            t2()
            t3()
            t4()
            t5()
        End If
        If ListBox1.Text <> "" Then
            Button2.Enabled = True
            Button4.Enabled = True
            删除这一条ToolStripMenuItem.Visible = True
            打开ToolStripMenuItem.Visible = True
            ToolStripSeparator6.Visible = True
        Else
            Button2.Enabled = False
            Button4.Enabled = False
            删除这一条ToolStripMenuItem.Visible = False
            打开ToolStripMenuItem.Visible = False
            ToolStripSeparator6.Visible = False
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListBox1.Items.Count <> 0 Then
            If ZTHYText.Text <> "" And ZTHHText.Text <> ZTHYText.Text Then
                Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                For r = 0 To ListBox1.Items.Count - 1
                    Dim TF = ListBox1.Items(r).ToString
                    Dim TQ = getname.getname(TF, "\", True)
                    Dim TH = getname.getname(TF, "\", False)
                    Dim TM = getname.getname(TH, ".", True)
                    Dim TK = getname.getname(TH, ".", False)
                    TM = Replace(TM, ZTHYText.Text, ZTHHText.Text)
                    On Error GoTo y
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TM = FJZH(False, TM)
                        Else
                            TM = FJZH(True, TM)
                        End If
                    End If
                    If My.Computer.FileSystem.FileExists(TQ + "\" + TM + "." + TK) = False Then
                        My.Computer.FileSystem.RenameFile(TF, TM + "." + TK)
                        lN.Items.Add(ListBox1.Items(r).ToString)
                    End If
                    GoTo g
                    Exit Sub
y:                  MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                    GoTo g
                    Exit Sub
g:
                    On Error Resume Next
                    Dim ppt = PP.Value + JD
                    If ppt < 100 Then
                        PP.Value = ppt
                    Else
                        PP.Value = 100
                    End If
                Next
                For u = 0 To lN.Items.Count - 1
                    ListBox1.Items.Remove(lN.Items(u).ToString)
                Next
                kk()
            Else
                nowee()
            End If
        End If
    End Sub
    Function t1()
        On Error Resume Next
        TextBox2.Text = ""
        If ListBox1.Text <> "" Then
            If ZTHYText.Text <> "" And ZTHHText.Text <> ZTHYText.Text Then
                Dim TF = ListBox1.Text
                Dim TQ = getname.getname(TF, "\", True)
                Dim TH = getname.getname(TF, "\", False)
                Dim TM = getname.getname(TH, ".", True)
                Dim TK = getname.getname(TH, ".", False)
                TM = Replace(TM, ZTHYText.Text, ZTHHText.Text)
                If SetBox.CheckBox7.Checked = True Then
                    If FT.Checked = True Then
                        TM = FJZH(False, TM)
                    Else
                        TM = FJZH(True, TM)
                    End If
                End If
                TextBox2.Text = (TM + "." + TK)
            End If
        End If
    End Function
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If ListBox1.Items.Count <> 0 Then
            If KTHHText.Text <> "" Or KZText.Text <> "" Then
                Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                For r = 0 To ListBox1.Items.Count - 1
                    Dim TF = ListBox1.Items(r).ToString
                    Dim TQ = getname.getname(TF, "\", True)
                    Dim TH = getname.getname(TF, "\", False)
                    Dim TM = getname.getname(TH, ".", True)
                    Dim TK = getname.getname(TH, ".", False)
                    On Error GoTo y
                    If 开启ToolStripMenuItem4.Checked = True Then
                        If KTHHText.Text <> "" Then
                            TK = KTHHText.Text
                            TH = TM + "." + TK
                            If SetBox.CheckBox7.Checked = True Then
                                If FT.Checked = True Then
                                    TH = FJZH(False, TH)
                                Else
                                    TH = FJZH(True, TH)
                                End If
                            End If
                            If My.Computer.FileSystem.FileExists(TQ + "\" + TH) = False Then
                                My.Computer.FileSystem.RenameFile(TF, TH)
                                lN.Items.Add(ListBox1.Items(r).ToString)
                            End If
                        Else
                            My.Computer.FileSystem.RenameFile(TF, TM)
                            lN.Items.Add(ListBox1.Items(r).ToString)
                        End If
                    Else
                        If KZText.Text <> "" Then
                            If My.Computer.FileSystem.FileExists(TQ + "\" + TH + "." + KZText.Text) = False Then
                                My.Computer.FileSystem.RenameFile(TF, TH + "." + KZText.Text)
                                lN.Items.Add(ListBox1.Items(r).ToString)
                            End If
                        End If
                    End If
                    GoTo g
                    Exit Sub
y:
                    MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                    GoTo g
                    Exit Sub
g:
                    On Error Resume Next
                    Dim ppt = PP.Value + JD
                    If ppt < 100 Then
                        PP.Value = ppt
                    Else
                        PP.Value = 100
                    End If
                Next
                For u = 0 To lN.Items.Count - 1
                    ListBox1.Items.Remove(lN.Items(u).ToString)
                Next
                kk()
            Else
                nowee()
            End If
        End If
    End Sub
    Function t2()
        On Error Resume Next
        TextBox3.Text = ""
        If ListBox1.Text <> "" Then
            Dim TF = ListBox1.Text
            Dim TQ = getname.getname(TF, "\", True)
            Dim TH = getname.getname(TF, "\", False)
            Dim TM = getname.getname(TH, ".", True)
            Dim TK = getname.getname(TH, ".", False)
            If 开启ToolStripMenuItem4.Checked = True Then
                If KTHHText.Text <> "" Then
                    TK = KTHHText.Text
                    TH = TM + "." + TK
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TH = FJZH(False, TH)
                        Else
                            TH = FJZH(True, TH)
                        End If
                    End If
                    TextBox3.Text = TH
                Else
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TM = FJZH(False, TM)
                        Else
                            TM = FJZH(True, TM)
                        End If
                    End If
                    TextBox3.Text = TM
                End If
            Else
                If KZText.Text <> "" Then
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TH = FJZH(False, TH)
                        Else
                            TH = FJZH(True, TH)
                        End If
                    End If
                    TextBox3.Text = TH + "." + KZText.Text
                End If
            End If
        End If
    End Function
    Private Sub Button9_Click() Handles Button9.Click
        If ListBox1.Items.Count <> 0 Then
            If (XLYText.Text.Length < CInt(XLTHText.Text)) Or (ZTHHText.Text <> ZTHYText.Text) Or KTHHText.Text <> "" Or KZText.Text <> "" Or ZHText.Text <> "" Or ZQText.Text <> "" Or (PXKQ.Checked = True Or PXCom.Text <> "") Or SetBox.CheckBox7.Checked = True Then
a:              Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                Dim i As String = ""
                For r = 0 To ListBox1.Items.Count - 1
                    Dim TF
                    Dim TQ
                    Dim TH
                    Dim TM
                    Dim TK
                    TF = ListBox1.Items(r).ToString
                    If PXKQ.Checked = True And PXCom.Text <> "" Then
                        TQ = getname.getname(TF, "\", True)
                        TH = getname.getname(TF, "\", False)
                        TM = getname.getname(TH, ".", True)
                        TK = getname.getname(TH, ".", False)
                        i = Str(r + 1).Trim
                        While i.Length < Str(ListBox1.Items.Count - 1).Trim.Length
                            i = "0" + i
                        End While
                        If PXCom.Text = PXCom.Items(0) Then
                            TH = i + TH
                        End If
                        If PXCom.Text = PXCom.Items(1) Then
                            If TK <> "" Then
                                TH = TM + i + "." + TK
                            Else
                                TH = TM + i
                            End If
                        End If
                        If PXCom.Text = PXCom.Items(2) Then
                            If TK <> "" Then
                                TH = i + "." + TK
                            Else
                                TH = i
                            End If
                        End If
                        TF = TQ + "\" + TH
                    End If
                    If XLTHText.Text <> "0" Then
                        If XLYText.Text.Length < CInt(XLTHText.Text) Then
                            TQ = getname.getname(TF, "\", True)
                            TH = getname.getname(TF, "\", False)
                            If Mid(TH, 1, XLYText.Text.Length) = XLYText.Text Then
                                TH = Mid(TH, XLYText.Text.Length + 1, Len(TH) - XLYText.Text.Length)
                                While Len(TH) < (CInt(XLTHText.Text) - XLYText.Text.Length)
                                    TH = XLZText.Text + TH
                                End While
                                TF = TQ + "\" + XLYText.Text + TH
                            End If
                        End If
                    End If
                    TQ = getname.getname(TF, "\", True)
                    TH = getname.getname(TF, "\", False)
                    TM = getname.getname(TH, ".", True)
                    TK = getname.getname(TH, ".", False)
                    If 开启ToolStripMenuItem4.Checked = True Then
                        If KTHHText.Text <> "" Then
                            TK = KTHHText.Text
                            If TK <> "" Then
                                TH = TM + "." + TK
                            Else
                                TH = TM
                            End If
                            TF = TQ + "\" + TH
                        Else
                            TF = TQ + "\" + TM
                        End If
                    Else
                        If KZText.Text <> "" Then
                            TF = TQ + "\" + TH + "." + KZText.Text
                        End If
                    End If
                    If ZTHYText.Text <> "" And ZTHHText.Text <> ZTHYText.Text Then
                        TQ = getname.getname(TF, "\", True)
                        TH = getname.getname(TF, "\", False)
                        TM = getname.getname(TH, ".", True)
                        TK = getname.getname(TH, ".", False)
                        TM = Replace(TM, ZTHYText.Text, ZTHHText.Text)
                        If TK <> "" Then
                            TH = TM + "." + TK
                        Else
                            TH = TM
                        End If
                        TF = TQ + "\" + TH
                    End If
                    TQ = getname.getname(TF, "\", True)
                    TH = getname.getname(TF, "\", False)
                    TM = getname.getname(TH, ".", True)
                    TK = getname.getname(TH, ".", False)
                    If ZQText.Text <> "" Then
                        TM = ZQText.Text + TM
                    End If
                    If ZHText.Text <> "" Then
                        TM = TM + ZHText.Text
                    End If
                    If TK <> "" Then
                        TH = TM + "." + TK
                    Else
                        TH = TM
                    End If
                    On Error GoTo y
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TH = FJZH(False, TH)
                        Else
                            TH = FJZH(True, TH)
                        End If
                    End If
                    If My.Computer.FileSystem.FileExists(TQ + "\" + TH) = False Then
                        My.Computer.FileSystem.RenameFile(ListBox1.Items(r).ToString, TH)
                        lN.Items.Add(ListBox1.Items(r).ToString)
                    End If
                    GoTo g
                    Exit Sub
y:                  MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                    GoTo g
                    Exit Sub
g:
                    On Error Resume Next
                    Dim ppt = PP.Value + JD
                    If ppt < 100 Then
                        PP.Value = ppt
                    Else
                        PP.Value = 100
                    End If
                Next
                For u = 0 To lN.Items.Count - 1
                    ListBox1.Items.Remove(lN.Items(u).ToString)
                Next
                kk()
            Else
                If KTHHText.Text = "" And 开启ToolStripMenuItem4.Checked = True Then
                    GoTo a
                Else
                    nowee()
                End If
            End If
        End If
    End Sub
    Function t3()
        On Error Resume Next
        TextBox4.Text = ""
        Dim TF
        Dim TQ
        Dim TH
        Dim TM
        Dim TK
        Dim i As String = ""
        TF = ListBox1.Text
        If PXKQ.Checked = True And PXCom.Text <> "" Then
            TQ = getname.getname(TF, "\", True)
            TH = getname.getname(TF, "\", False)
            TM = getname.getname(TH, ".", True)
            TK = getname.getname(TH, ".", False)
            i = Str(ListBox1.SelectedIndex + 1).Trim
            While i.Length < Str(ListBox1.Items.Count).Trim.Length
                i = "0" + i
            End While
            If PXCom.Text = PXCom.Items(0) Then
                TH = i + TH
            End If
            If PXCom.Text = PXCom.Items(1) Then
                If TK <> "" Then
                    TH = TM + i + "." + TK
                Else
                    TH = TM + i
                End If
            End If
            If PXCom.Text = PXCom.Items(2) Then
                If TK <> "" Then
                    TH = i + "." + TK
                Else
                    TH = i
                End If
            End If
            TF = TQ + "\" + TH
        End If
        If XLTHText.Text <> "0" Then
            If XLYText.Text.Length < CInt(XLTHText.Text) Then
                TQ = getname.getname(TF, "\", True)
                TH = getname.getname(TF, "\", False)
                If Mid(TH, 1, XLYText.Text.Length) = XLYText.Text Then
                    TH = Mid(TH, XLYText.Text.Length + 1, Len(TH) - XLYText.Text.Length)
                    While Len(TH) < (CInt(XLTHText.Text) - XLYText.Text.Length)
                        TH = XLZText.Text + TH
                    End While
                    TH = XLYText.Text + TH
                    TF = TQ + "\" + TH
                End If
            End If
        End If
        TQ = getname.getname(TF, "\", True)
        TH = getname.getname(TF, "\", False)
        TM = getname.getname(TH, ".", True)
        TK = getname.getname(TH, ".", False)
        If 开启ToolStripMenuItem4.Checked = True Then
            If KTHHText.Text <> "" Then
                TK = KTHHText.Text
                If TK <> "" Then
                    TH = TM + "." + TK
                Else
                    TH = TM
                End If
                TF = TQ + "\" + TH
            Else
                TF = TQ + "\" + TM
            End If
        Else
            If KZText.Text <> "" Then
                TF = TQ + "\" + TH + "." + KZText.Text
            End If
        End If
        If ZTHYText.Text <> "" And ZTHHText.Text <> ZTHYText.Text Then
            TQ = getname.getname(TF, "\", True)
            TH = getname.getname(TF, "\", False)
            TM = getname.getname(TH, ".", True)
            TK = getname.getname(TH, ".", False)
            TM = Replace(TM, ZTHYText.Text, ZTHHText.Text)
            If TK <> "" Then
                TH = TM + "." + TK
            Else
                TH = TM
            End If
            TF = TQ + "\" + TH
        End If
        TQ = getname.getname(TF, "\", True)
        TH = getname.getname(TF, "\", False)
        TM = getname.getname(TH, ".", True)
        TK = getname.getname(TH, ".", False)
        If ZQText.Text <> "" Then
            TM = ZQText.Text + TM
        End If
        If ZHText.Text <> "" Then
            TM = TM + ZHText.Text
        End If
        If TK <> "" Then
            TH = TM + "." + TK
        Else
            TH = TM
        End If
        If SetBox.CheckBox7.Checked = True Then
            If FT.Checked = True Then
                TH = FJZH(False, TH)
            Else
                TH = FJZH(True, TH)
            End If
        End If
        TextBox4.Text = TH
    End Function
    Private Sub 作者ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作者ToolStripMenuItem.Click
        MsgBox("作者:关镇涛" + vbCrLf + "现读于" + "广东省开平市第一中学", MsgBoxStyle.Information, "关于作者！！！")
    End Sub
    Function nowee()
        On Error Resume Next
        MsgBox("请先打开菜单|——>文件——>设定——|进行设置！！！", MsgBoxStyle.Information, "温馨提示！！！")
    End Function
    Dim bs As Integer = 0
    Private Sub GNE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.AddMessageFilter(Me)
        DragAcceptFiles(ListBox1.Handle.ToInt32, True)
        If Command() <> "" Then
            Dim bbint As Integer = 0
            Dim n As Integer = 0
            If My.Application.CommandLineArgs.Item(0) = "/XLY" Then '序列添零
                n = 4
                bs = 1
            End If
            For t = n To My.Application.CommandLineArgs.Count - 1 '添文件
                If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    ListBox1.Items.Remove(My.Application.CommandLineArgs.Item(t))
                    ListBox1.Items.Add(My.Application.CommandLineArgs.Item(t))
                    bbint = bbint + 1
                End If
                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(t)) = True Then
                    Dim tt
                    tt = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(t), FileIO.SearchOption.SearchAllSubDirectories, WJLXText.Text)
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                        bbint = bbint + 1
                    Next
                End If
            Next
            If My.Application.CommandLineArgs.Item(0) = "/XLY" Then '序列添零
                XLYText.Text = My.Application.CommandLineArgs.Item(1)
                XLTHText.Text = My.Application.CommandLineArgs.Item(2)
                XLZText.Text = My.Application.CommandLineArgs.Item(3)
                Button9_Click()
                End
            End If
            If n = 0 Then
                MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End If
        sd()
    End Sub
    Function sd()
        On Error Resume Next
        Me.Hide()
        SetBox.ShowDialog()
        Me.Show()
    End Function
    Function kk()
        On Error Resume Next
        If bs = 0 Then
            MsgBox("完成操作！！！", MsgBoxStyle.Information, "温馨提示！！！")
            PP.Value = 100
        End If
    End Function
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If ListBox1.Items.Count <> 0 Then
            If ZQText.Text <> "" Or ZHText.Text <> "" Then
                Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                For r = 0 To ListBox1.Items.Count - 1
                    Dim TF = ListBox1.Items(r).ToString
                    Dim TQ = getname.getname(TF, "\", True)
                    Dim TH = getname.getname(TF, "\", False)
                    Dim TM = getname.getname(TH, ".", True)
                    Dim TK = getname.getname(TH, ".", False)
                    If ZQText.Text <> "" Then
                        TM = ZQText.Text + TM
                    End If
                    If ZHText.Text <> "" Then
                        TM = TM + ZHText.Text
                    End If
                    If TK <> "" Then
                        TH = TM + "." + TK
                    Else
                        TH = TM
                    End If
                    On Error GoTo y
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TH = FJZH(False, TH)
                        Else
                            TH = FJZH(True, TH)
                        End If
                    End If
                    If My.Computer.FileSystem.FileExists(TQ + "\" + TH) = False Then
                        My.Computer.FileSystem.RenameFile(TF, TH)
                        lN.Items.Add(ListBox1.Items(r).ToString)
                        GoTo g
                        Exit Sub
                        If bs = 0 Then
y:                          MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                        End If
                        GoTo g
                        Exit Sub
g:
                    End If
                    On Error Resume Next
                    Dim ppt = PP.Value + JD
                    If ppt < 100 Then
                        PP.Value = ppt
                    Else
                        PP.Value = 100
                    End If
                Next
                PP.Value = 100
                For u = 0 To lN.Items.Count - 1
                    ListBox1.Items.Remove(lN.Items(u).ToString)
                Next
                kk()
            End If
        Else
            nowee()
        End If
    End Sub
    Function t4()
        On Error Resume Next
        If ListBox1.Text <> "" Then
            If ZQText.Text <> "" Or ZHText.Text <> "" Then
                Dim TF = ListBox1.Text
                Dim TQ = getname.getname(TF, "\", True)
                Dim TH = getname.getname(TF, "\", False)
                Dim TM = getname.getname(TH, ".", True)
                Dim TK = getname.getname(TH, ".", False)
                If ZQText.Text <> "" Then
                    TM = ZQText.Text + TM
                End If
                If ZHText.Text <> "" Then
                    TM = TM + ZHText.Text
                End If
                If TK <> "" Then
                    TH = TM + "." + TK
                Else
                    TH = TM
                End If
                If SetBox.CheckBox7.Checked = True Then
                    If FT.Checked = True Then
                        TH = FJZH(False, TH)
                    Else
                        TH = FJZH(True, TH)
                    End If
                End If
                TextBox5.Text = TH
            End If
        End If
    End Function
    Private Sub 删除这一条ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除这一条ToolStripMenuItem1.Click
        删除路径ToolStripMenuItem_Click()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        sd()
    End Sub
    Private Sub 选定ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 选定ToolStripMenuItem.Click
        sd()
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub XLZText_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XLZText.TextChanged
        If XLZText.Text = "" Then
            XLZText.Text = "0"
        End If
    End Sub
    Private Sub 设定ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设定ToolStripMenuItem1.Click
        sd()
    End Sub
    Private Sub 删除路径ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除路径ToolStripMenuItem.Click
    End Sub
    Private Sub PXKQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PXKQ.Click
        If PXKQ.Checked = True Then
            PXCom.Enabled = False
            PXKQ.Checked = False
        Else
            PXCom.Enabled = True
            PXKQ.Checked = True
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim i As String
        If ListBox1.Items.Count <> 0 Then
            If PXKQ.Checked = True And PXCom.Text <> "" Then
                Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                For r = 0 To ListBox1.Items.Count - 1
                    On Error GoTo y
                    i = Str(r + 1).Trim
                    While i.Length < Str(ListBox1.Items.Count - 1).Trim.Length
                        i = "0" + i
                    End While
                    Dim TF = ListBox1.Items(r).ToString
                    Dim TQ = getname.getname(TF, "\", True)
                    Dim TH = getname.getname(TF, "\", False)
                    Dim TM = getname.getname(TH, ".", True)
                    Dim TK = getname.getname(TH, ".", False)
                    If PXCom.Text = PXCom.Items(0) Then
                        TH = i + TH
                    End If
                    If PXCom.Text = PXCom.Items(1) Then
                        If TK <> "" Then
                            TH = TM + i + "." + TK
                        Else
                            TH = TM + i
                        End If
                    End If
                    If PXCom.Text = PXCom.Items(2) Then
                        If TK <> "" Then
                            TH = i + "." + TK
                        Else
                            TH = i
                        End If
                    End If
                    If SetBox.CheckBox7.Checked = True Then
                        If FT.Checked = True Then
                            TH = FJZH(False, TH)
                        Else
                            TH = FJZH(True, TH)
                        End If
                    End If
                    If My.Computer.FileSystem.FileExists(TQ + "\" + TH) = False Then
                        My.Computer.FileSystem.RenameFile(TF, TH)
                        lN.Items.Add(ListBox1.Items(r).ToString)
                    End If
                    GoTo g
                    Exit Sub
y:
                    MsgBox(ListBox1.Items(r).ToString + vbCrLf + "修改失败！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                    GoTo g
                    Exit Sub
g:
                    On Error Resume Next
                    Dim ppt = PP.Value + JD
                    If ppt < 100 Then
                        PP.Value = ppt
                    Else
                        PP.Value = 100
                    End If
                Next
                For u = 0 To lN.Items.Count - 1
                    ListBox1.Items.Remove(lN.Items(u).ToString)
                Next
                kk()
            Else
                nowee()
            End If
        End If
    End Sub
    Function t5()
        On Error Resume Next
        Dim i As String
        If ListBox1.Text <> "" Then
            If PXKQ.Checked = True And PXCom.Text <> "" Then
                Dim lN As New ListBox
                lN.Items.Clear()
                PP.Value = 0
                Dim JD = 100 / ListBox1.Items.Count
                i = Str(ListBox1.SelectedIndex + 1).Trim
                While i.Length < Str(ListBox1.Items.Count - 1).Trim.Length
                    i = "0" + i
                End While
                Dim TF = ListBox1.Text
                Dim TQ = getname.getname(TF, "\", True)
                Dim TH = getname.getname(TF, "\", False)
                Dim TM = getname.getname(TH, ".", True)
                Dim TK = getname.getname(TH, ".", False)
                If PXCom.Text = PXCom.Items(0) Then
                    TH = i + TH
                End If
                If PXCom.Text = PXCom.Items(1) Then
                    If TK <> "" Then
                        TH = TM + i + "." + TK
                    Else
                        TH = TM + i
                    End If
                End If
                If PXCom.Text = PXCom.Items(2) Then
                    If TK <> "" Then
                        TH = i + "." + TK
                    Else
                        TH = i
                    End If
                End If
                If SetBox.CheckBox7.Checked = True Then
                    If FT.Checked = True Then
                        TH = FJZH(False, TH)
                    Else
                        TH = FJZH(True, TH)
                    End If
                End If
                TextBox6.Text = TH
            End If
        End If
    End Function
    Function FJZH(ByVal FJ As Boolean, ByVal stt As String)
        Dim st As String = ""
        If FJ = True Then
            st = StrConv(stt, VbStrConv.SimplifiedChinese)
        Else
            st = StrConv(stt, VbStrConv.TraditionalChinese)
        End If
        Return st
    End Function
    Private Sub JT_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JT.CheckedChanged
        If SetBox.CheckBox7.Checked = True Then
            If JT.Checked = True Then
                FT.Checked = False
            Else
                FT.Checked = True
            End If
        End If
    End Sub
    Private Sub FT_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FT.CheckedChanged
        If SetBox.CheckBox7.Checked = True Then
            If FT.Checked = True Then
                JT.Checked = False
            Else
                JT.Checked = True
            End If
        End If
    End Sub
    Private Sub FT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FT.Click
        SetBox.RadioButton1.Checked = True
        If SetBox.CheckBox7.Checked = False Then
            SetBox.CheckBox7.Checked = True
        End If
    End Sub
    Private Sub JT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JT.Click
        SetBox.RadioButton2.Checked = True
        If SetBox.CheckBox7.Checked = False Then
            SetBox.CheckBox7.Checked = True
        End If
    End Sub
End Class