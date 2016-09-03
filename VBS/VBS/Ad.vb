Public Class Ad
    Dim sd As String = "VBSD"
    Private Sub Ad_Load() Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Script.chm") = True Then
            Button6.Enabled = True
        Else
            Button6.Enabled = False
        End If
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        stat()
        TextBox1.Text = VBS.TextBox1.SelectedText
    End Sub
    Function stat()
        On Error Resume Next
        TreeView1.Nodes.Clear()
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\" + sd) = True Then
            Dim f = My.Computer.FileSystem.GetDirectories(My.Application.Info.DirectoryPath + "\" + sd)
            If f.Count <> "" Then
                For x = 0 To f.Count - 1
                    TreeView1.Nodes.Add(f(x), f(x).Replace(My.Application.Info.DirectoryPath + "\" + sd + "\", ""), 0, 0)
                    Dim mf = My.Computer.FileSystem.GetFiles(f(x), FileIO.SearchOption.SearchTopLevelOnly, "*." + sd.ToLower)
                    For y = 0 To mf.Count - 1
                        TreeView1.Nodes(TreeView1.Nodes.Count - 1).Nodes.Add(mf(y), mf(y).Replace(f(x) + "\", ""), 1)
                    Next
                Next
            End If
        Else
            MkDir(My.Application.Info.DirectoryPath + "\" + sd)
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\" + sd + "\" + TextBox3.Text) = False Then
                MkDir(My.Application.Info.DirectoryPath + "\" + sd + "\" + TextBox3.Text)
            End If
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\" + sd + "\" + TextBox3.Text + "\" + TextBox2.Text + "." + sd, TextBox1.Text, False, System.Text.Encoding.Default)
            Dim nn = TreeView1
            Dim ll = nn.Nodes.Count
            Dim tt = TextBox3.Text.Trim
            stat()
            For k = 0 To ll - 1
                If nn.Nodes(k).Text.Trim = tt Then
                    TreeView1.SelectedNode = nn.Nodes(k)
                    TreeView1.SelectedNode.Expand()
                End If
            Next
            TreeView1.Select()
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            MsgBox("请填写语句！！！", MsgBoxStyle.Exclamation, "敬告！！！")
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("请填写语句内容！！！", MsgBoxStyle.Exclamation, "敬告！！！")
            End If
        End If
    End Sub
    Dim fd = 0
    Dim xd As Integer
    Function find(ByVal nn As TreeNode, ByVal ss As String)
        fd = 0
        On Error Resume Next
        xd = 0
        xx = 0
        check(0, nn, ss)
    End Function
    Dim fx As Integer = 0
    Dim xx As Integer
    Function check(ByVal xd As Integer, ByVal nn As TreeNode, ByVal ss As String)
        On Error Resume Next
        Do
            If fc(nn.Nodes(xd).Text.ToLower.Split(".")(0), ss.ToLower) = 1 Then
                TreeView1.SelectedNode = nn.Nodes(xd)
                fd = 1
            End If
            xd = xd + 1
        Loop Until xd >= nn.Nodes.Count - 1 Or fd <> 0
        TreeView1.Select()
        xx = (xd)
        fx = 1
    End Function
    Function fc(ByVal str1 As String, ByVal str2 As String)
        Dim boo As Integer
        boo = 0
        Dim l1 As Integer
        l1 = Len(str1)
        If Len(str1.Replace(str2, "")) < l1 Then
            boo = 1
        End If
        Return boo
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        If TreeView1.Nodes.Count <> 0 Then
            Dim mm = My.Application.Info.DirectoryPath + "\" + sd + "\" + TreeView1.SelectedNode.FullPath
            If My.Computer.FileSystem.DirectoryExists(mm) = True Then
                My.Computer.FileSystem.DeleteDirectory(mm, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Else
                My.Computer.FileSystem.DeleteFile(mm, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            End If
        End If
        Ad_Load()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*." + sd + ";" + "*." + sd.Replace("D", "") + "|*." + sd + ";" + "*." + sd.Replace("D", "") + "|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.Default)
                Dim t = ""
                For ry = 0 To .FileName.Length - 1
                    If Mid(.FileName, ry + 1, 1) = "\" Then
                        t = ry
                    End If
                Next
                Dim provider = .FileName.Remove(0, t + 1)
                Dim emailparts1() As String
                Dim user1 As String
                Dim provider1 As String
                emailparts1 = provider.Split(".".ToCharArray, 2)
                If emailparts1.Length = 2 Then
                    user1 = emailparts1(0)
                    provider1 = emailparts1(1)
                Else
                    user1 = String.Empty
                    provider1 = String.Empty
                End If
                TextBox2.Text = user1.Trim
            End If
        End With
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        TextBox3.Text = TreeView1.SelectedNode.Text
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + sd + "\" + TreeView1.SelectedNode.FullPath) = True Then
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\" + sd + "\" + TreeView1.SelectedNode.FullPath, System.Text.Encoding.Default)
            TextBox2.Text = TreeView1.SelectedNode.Text.Split(".".ToCharArray, 2)(0)
            TextBox3.Text = TreeView1.SelectedNode.FullPath.Split("\".ToCharArray, 2)(0)
        End If
    End Sub
    Dim jx = 0
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox4.Text <> "" Then
            stat()
            Dim x = 0
            If jx <= TreeView1.Nodes.Count - 1 Then
                x = jx
                fd = 0
            End If
            Do
                find(TreeView1.Nodes(x), TextBox4.Text)
                x = x + 1
            Loop Until x > TreeView1.Nodes.Count - 1 Or fd <> 0
            jx = x
        End If
        Button7.Enabled = True
    End Sub
    Function chose1(ByVal ds As Integer)
        On Error Resume Next
        If ds = 0 Then
            sd = "VBSD"
        Else
            If ds = 1 Then
                sd = "JSD"
            Else
                If ds = 2 Then
                    sd = "WSFD"
                End If
            End If
        End If
    End Function
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Shell("hh " + My.Application.Info.DirectoryPath + "\Script.chm", AppWinStyle.MaximizedFocus, False)
    End Sub
    Dim q As Integer = 0
    Dim s As Integer = 0
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If s >= TreeView1.Nodes.Item(q).Nodes.Count - 1 Then
a:          s = 0
            xx = 0
            xd = 0
            If q < TreeView1.Nodes.Count - 1 Then
                q = q + 1
            Else
                GoTo g
            End If
        Else
            s = xx
        End If
        Do
            check(s, TreeView1.Nodes.Item(q), TextBox4.Text)
        Loop Until s < TreeView1.Nodes.Count - 1 Or fx = 1
        fx = 0
        Exit Sub
g:      s = 0
        q = -1
        jx = 0
        xd = 0
        fd = 0
        xx=0
        GoTo a
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
        Button7.Enabled = False
    End Sub
End Class