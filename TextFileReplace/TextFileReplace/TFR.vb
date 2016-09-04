Public Class TFR
    Dim ss As New ArrayList
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With New OpenFileDialog
            .FileName = ""
            Dim i = "支持格式 " + TextBox1.Text + "|" + TextBox1.Text + "|"
            If TextBox1.Text.Trim = "*" Then
                i = ""
            End If
            .Filter = i + "所有格式 *.*|*.*"
            .Multiselect = True
            .ShowDialog()
            If .FileNames.LongLength <> 0 Then
                For v = 0 To .FileNames.LongLength - 1
                    ListBox1.Items.Remove(.FileNames(v))
                    ListBox1.Items.Add(.FileNames(v))
                    ListBox1.Items.Remove("")
                Next
            End If
        End With
        If ListBox1.Items.Count = 0 Then
            Button16.Enabled = False
            Button7.Enabled = False
        Else
            If ListBox2.Items.Count <> 0 Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
            Button7.Enabled = True
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        adddir(FileIO.SearchOption.SearchTopLevelOnly, "")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        adddir(FileIO.SearchOption.SearchAllSubDirectories, "")
    End Sub
    Function adddir(ByVal sel As Microsoft.VisualBasic.FileIO.SearchOption, ByVal tfpath As String)
        On Error Resume Next
        With New FolderBrowserDialog
            If tfpath.Trim <> "" Then
                GoTo k
            End If
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .Description = "请选择含有本文文件的目录！！！"
            .ShowDialog()
            If .SelectedPath <> "" Then
                tfpath = .SelectedPath
k:              Dim d1 = TextBox1.Text.Split(";")
                Dim dc = 0
                For x = 0 To d1.LongLength - 1
                    Dim tt = Nothing
                    tt = My.Computer.FileSystem.GetFiles(tfpath, sel, d1(x))
                    dc = dc + tt.count
                    For qq = 0 To tt.count - 1
                        ListBox1.Items.Remove(tt(qq))
                        ListBox1.Items.Add(tt(qq))
                        ListBox1.Items.Remove("")
                    Next
                Next
                If ListBox1.Items.Count = 0 Then
                    Button16.Enabled = False
                    Button7.Enabled = False
                Else
                    If ListBox2.Items.Count <> 0 Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                        Button16.Enabled = True
                    Else
                        Button16.Enabled = False
                    End If
                    Button7.Enabled = True
                End If
                MsgBox("添加了" + Str(dc) + "个文件！", MsgBoxStyle.Information, "温馨提示！！！")
            End If
        End With
    End Function
    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        If ListBox1.Items.Count = 0 Then
            Button3_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub ListBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        Dim xu = (e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, True))
        Dim qs = TextBox1.Text.Split(";")
        For x = 0 To xu.length - 1
            'MsgBox(xu(x))
            If My.Computer.FileSystem.FileExists(xu(x)) = True Then
                Dim xe = 0
                For y = 0 To qs.LongLength - 1
                    If TextBox1.Text.Trim = "*" Then
                        GoTo w
                    End If
                    If getlast(xu(x).ToString.Split(".")).ToLower.Trim = qs(y).Replace("*.", "") Then
w:                      ListBox1.Items.Remove(xu(x))
                        ListBox1.Items.Add(xu(x))
                        ListBox1.Items.Remove("")
                        xe = xe + 1
                    End If
                Next
                MsgBox("添加了" + xe.ToString.Trim + "个文件", MsgBoxStyle.Information, "温馨提示！！！")
            Else
                If My.Computer.FileSystem.DirectoryExists(xu(x)) = True Then
                    Dim r = MsgBox(xu(x) + vbCrLf + "添加目录根下文件?" + vbCrLf + "Y - 目录根下" + vbCrLf + "N - 目录下全部" + vbCrLf + "C - 取消", MsgBoxStyle.YesNoCancel, "温馨提示！！！")
                    Dim sel = FileIO.SearchOption.SearchTopLevelOnly
                    If r = MsgBoxResult.Yes Then
                        sel = FileIO.SearchOption.SearchTopLevelOnly
                    Else
                        If r = MsgBoxResult.No Then
                            sel = FileIO.SearchOption.SearchAllSubDirectories
                        Else
                            GoTo c
                        End If
                    End If
                    adddir(sel, xu(x))
                End If
            End If
        Next
        If ListBox1.Items.Count = 0 Then
            Button16.Enabled = False
            Button7.Enabled = False
        Else
            If ListBox2.Items.Count <> 0 Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
            Button7.Enabled = True
        End If
c:
    End Sub
    Function getlast(ByVal im As Array)
        Dim dx = im
        Dim dy = dx.LongLength
        Return dx(dy - 1)
    End Function
    Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItems.Count = 0 Then
            Button6.Enabled = False
            Button8.Enabled = False
        Else
            Button6.Enabled = True
            Button8.Enabled = True
        End If
        ToolStripStatusLabel1.Text = ListBox1.Text
    End Sub
    Private Sub TFR_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        saveini()
    End Sub
    Private Sub TFR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ListBox1.Items.Count = 0 Then
            Button16.Enabled = False
            Button7.Enabled = False
        Else
            If ListBox2.Items.Count <> 0 Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
            Button7.Enabled = True
        End If
        ListBox1_SelectedIndexChanged(Nothing, Nothing)
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ss.Add(System.Text.Encoding.Default)
        ss.Add(System.Text.Encoding.UTF8)
        ss.Add(System.Text.Encoding.ASCII)
        ss.Add(System.Text.Encoding.Unicode)
        loadini()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        For x = 0 To ListBox1.SelectedItems.Count - 1
            ListBox1.Items.Remove(ListBox1.Items(0))
        Next
        ListBox1.SelectedIndices.Clear()
        Button6.Enabled = False
        Button8.Enabled = False
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
        Button7.Enabled = False
        Button16.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = False
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If ListBox1.Text <> "" Then
            If ListBox1.Text <> "" Then
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ListBox1.Text, AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        saveini()
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If TextBox4.Text <> "" Then
        '    ListBox2.Items.Remove(TextBox4.Text + "‘" + TextBox5.Text)
        '    ListBox2.Items.Add(TextBox4.Text + "‘" + TextBox5.Text)
        'End If
        'TextBox4.Text = ""
        'TextBox5.Text = ""
        'TextBox6.Text = ""
        nor.TabControl1.SelectedIndex = 0
        nor.ShowDialog()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ListBox2.Items.Remove(ListBox2.Text)
        TextBox6.Text = ""
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ListBox2.Items.Clear()
        TextBox6.Text = ""
        changels()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox6.Text = ""
        Dim lst As New ListBox
        With New OpenFileDialog
            .Multiselect = False
            .FileName = ""
            .Filter = "*.Glst|*.Glst"
            .ShowDialog()
            If .FileName <> "" Then
                Dim r = 1
                Dim i = ""
                Dim kui As String = My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.Default)
                lst.Items.Clear()
                For g = 1 To kui.Length
                    If Mid(kui, g, 10) = "$$!!$$~~%%" Then
                        lst.Items.Add(g)
                    End If
                Next
                lst.Items.Remove("")
                If lst.Items.Count <> 0 Then
                    For y = 0 To lst.Items.Count - 1
                        If y + 1 <= lst.Items.Count - 1 Then
                            ListBox2.Items.Remove((Mid(kui, (lst.Items(y) + 10), lst.Items(y + 1) - (lst.Items(y) + 10))))
                            ListBox2.Items.Add((Mid(kui, (lst.Items(y) + 10), lst.Items(y + 1) - (lst.Items(y) + 10))))
                        End If
                    Next
                End If
                ListBox2.Items.Remove("")
                ListBox2.Items.Remove(vbCr)
            End If
            .Multiselect = True
        End With
        changels()
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox6.Text = ""
        With New SaveFileDialog
            .FileName = ""
            .Filter = "*.Glst|*.Glst"
            .ShowDialog()
            If .FileName <> "" Then
                Dim ss = ""
                For c = 0 To ListBox2.Items.Count - 1
                    ss = ss + "$$!!$$~~%%" + ListBox2.Items(c)
                Next
                My.Computer.FileSystem.WriteAllText(.FileName, ss + "$$!!$$~~%%", False, System.Text.Encoding.Default)
            End If
        End With
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        TextBox6.Text = ""
        TextBox6.Text = ListBox2.Text
        changels()
    End Sub
    Function changels()
        On Error Resume Next
        If ListBox2.Text <> "" Then
            Button12.Enabled = True
            Button10.Enabled = True
        Else
            Button12.Enabled = False
            Button10.Enabled = False
        End If
        If ListBox2.Items.Count <> 0 Then
            Button11.Enabled = True
            Button14.Enabled = True
        Else
            Button11.Enabled = False
            Button14.Enabled = False
        End If
        If ListBox1.Items.Count <> 0 Then
            If (ListBox2.Items.Count <> 0) Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
        Else
            Button16.Enabled = False
        End If
    End Function
    Function core(ByVal str As String, ByVal sgz As String)
        If sgz.Trim = "" Then
            GoTo w
        End If
        ' Dim str =
        ' Dim sgz = ListBox2.SelectedItems(0).ToString
        Dim stt = ""
        Dim srr As New ArrayList
        Dim r1 = getname(sgz, "‘", True, 0)
        'MsgBox(r1)
        Dim r2 = getname(r1, "|", True, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r3 = getname(r1, "|", False, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r4 = getname(sgz, "‘", False, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r0 = getname(sgz, "‘", True, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        If sgz.ToString.Replace("|", "").Length < sgz.ToString.Length Then
            'MsgBox("g")
            'MsgBox(r2)
            'MsgBox(r3)
            'MsgBox(r4)
            Dim t1 = InStr(str, r2)
            Dim t2 = InStr(str, r3)
            If t2 > t1 And t1 <> 0 And t2 <> 0 Then
s:              Dim s1 = InStr(str, r2) - 1
                Dim s2 = InStr(str, r3) - 1
                'MsgBox(CStr(s1))
                'MsgBox(CStr(s2))
                'MsgBox(str.ToString.Substring(s1, s2 - s1 + 1))
                'MsgBox(str.Substring(0, s1))
                'MsgBox(str.Substring(s2 + 1, Len(str) - s2 - 1))
                srr.Add(str.Substring(s2 + 1, Len(str) - s2 - 1))
                '   MsgBox(str.Substring(s2 + 2, Len(str) - s2 - 2))
                stt = stt + str.Substring(0, s1) + r4
                str = str.Substring(s2 + 1, Len(str) - s2 - 1)
                If InStr(str, r2) <> 0 Then
                    GoTo s
                End If
                Dim dsrr = srr(srr.Count - 1)
                str = stt + dsrr
            End If
        Else
            str = str.Replace(r0, r4)
            'MsgBox("n")
            'MsgBox(r0)
            'MsgBox(r4)
        End If
w:      Return (str)
    End Function
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        '   MsgBox(core("0你|妹'|的|你X的3225你你是你你的4444", ""))
        On Error Resume Next
        If (ListBox1.Items.Count <> 0 And ListBox2.Items.Count <> 0) Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
            With ToolStripProgressBar1
                .Value = 0
                For r = 0 To ListBox1.Items.Count - 1
                    Shell("Attrib -s -r -h " + """" + ListBox1.Items(r) + """", AppWinStyle.Hide, True)
                    Dim rt = ""
                    If CheckBox1.Checked = True Then
                        rt = ".bak"
                        Kill(ListBox1.Items(r) + rt)
                        My.Computer.FileSystem.MoveFile(ListBox1.Items(r), ListBox1.Items(r) + rt)
                    End If
                    Dim ee As String = My.Computer.FileSystem.ReadAllText(ListBox1.Items(r) + rt, ss(ComboBox1.SelectedIndex))
                    For b = 0 To ListBox2.Items.Count - 1
                        ee = core(ee, ListBox2.Items(b))
                        'ee = ee.Replace(getname(ListBox2.Items(b), "‘", True, 0), getname(ListBox2.Items(b), "‘", False, 0))
                    Next
                    ' MsgBox(ComboBox3.SelectedIndex)
                    If ComboBox3.SelectedIndex <> 0 Then
                        If ComboBox3.SelectedIndex = 1 Then
                            ee = StrConv(ee, VbStrConv.SimplifiedChinese)
                        Else
                            ee = StrConv(ee, VbStrConv.TraditionalChinese)
                        End If
                    End If
                    My.Computer.FileSystem.WriteAllText(ListBox1.Items(r), ee, False, ss(ComboBox2.SelectedIndex))
                    .Value = .Value + Str(100 / ListBox1.Items.Count)
                Next
                ListBox1.Items.Clear()
                'TextBox1.Text = ""
                '  WebBrowser1.Url = Nothing
                If ListBox1.Items.Count = 0 Then
                    Button16.Enabled = False
                    Button7.Enabled = False
                Else
                    If ListBox2.Items.Count <> 0 Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                        Button16.Enabled = True
                    Else
                        Button16.Enabled = False
                    End If
                    Button7.Enabled = True
                End If
                ListBox1_SelectedIndexChanged(Nothing, Nothing)
                .Value = 100
                MsgBox("Successful！！！", MsgBoxStyle.Information)
                changels()
            End With
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
    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        Dim i = InputBox("输入格式", "请输入所需格式（用';'分隔）:", TextBox1.Text)
        If i <> "" Then
            TextBox1.Text = i.Trim
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim = "" Then
            TextBox1.Text = "*"
        End If
    End Sub
    Function saveini()
        On Error Resume Next
        Dim sf = 1
        If CheckBox1.Checked = True Then
            sf = "1"
        Else
            sf = "0"
        End If
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\setting.inn", TextBox1.Text.Trim + vbCrLf + CStr(ComboBox1.SelectedIndex).Trim + vbCrLf + CStr(ComboBox2.SelectedIndex).Trim + vbCrLf + CStr(ComboBox3.SelectedIndex).Trim + vbCrLf + sf.ToString.Trim, False)
    End Function
    Function loadini()
        On Error Resume Next
        Dim rr = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\setting.inn")
        Dim sr = rr.Split(vbCrLf)
        TextBox1.Text = sr(0).Trim
        ComboBox1.SelectedIndex = CInt(sr(1).Trim)
        ComboBox2.SelectedIndex = CInt(sr(2).Trim)
        ComboBox3.SelectedIndex = CInt(sr(3).Trim)
        If CInt(sr(4)) = 0 Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
    End Function
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TextBox1.Text = "*.txt;*.text;*.htm;*.html;*.css;*.js;*.php"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        nor.TabControl1.SelectedIndex = 1
        nor.ShowDialog()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ListBox1.Items.Count <> 0 Then
            If (ListBox2.Items.Count <> 0 And ListBox1.Items.Count <> 0) Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
        Else
            Button16.Enabled = False
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ListBox1.Items.Count <> 0 Then
            If (ListBox2.Items.Count <> 0 And ListBox1.Items.Count <> 0) Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
        Else
            Button16.Enabled = False
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ListBox1.Items.Count <> 0 Then
            If (ListBox2.Items.Count <> 0 And ListBox1.Items.Count <> 0) Or ComboBox3.SelectedIndex <> 0 Or (ComboBox1.SelectedIndex <> ComboBox2.SelectedIndex) Then
                Button16.Enabled = True
            Else
                Button16.Enabled = False
            End If
        Else
            Button16.Enabled = False
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim sgz = ListBox2.Text
        Dim srr As New ArrayList
        Dim r1 = getname(sgz, "‘", True, 0)
        'MsgBox(r1)
        Dim r2 = getname(r1, "|", True, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r3 = getname(r1, "|", False, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r4 = getname(sgz, "‘", False, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        Dim r0 = getname(sgz, "‘", True, 0).ToString.Replace("@%11259878gergeg484989%@", "|").Replace("&^165165wgwfwf645456^&", "‘")
        If sgz.ToString.Replace("|", "").Length < sgz.ToString.Length Then
            nor.TextBox4.Text = r2
            nor.TextBox2.Text = r3
            nor.TextBox5.Text = r4
            nor.TabControl1.SelectedIndex = 1
            nor.ShowDialog()
        Else
            nor.TextBox1.Text = r0
            nor.TextBox3.Text = r4
            nor.TabControl1.SelectedIndex = 0
            nor.ShowDialog()
        End If
    End Sub
End Class