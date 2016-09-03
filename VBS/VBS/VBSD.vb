Public Class VBSD
    Dim sd As String = "VBSD"
    Private Sub VBSD_Load() Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
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
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        VBSD_Load()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + sd + "\" + TreeView1.SelectedNode.FullPath) = True Then
            TextBox2.Text = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\" + sd + "\" + TreeView1.SelectedNode.FullPath, System.Text.Encoding.Default)
            TextBox1.Text = TreeView1.SelectedNode.Text.Split(".".ToCharArray, 2)(0)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        VBS.TextBox1.SelectedText = TextBox2.Text
        Me.Close()
    End Sub
    Dim jx = 0
    Dim fd = 0
    Dim xd As Integer
    Function find(ByVal nn As TreeNode, ByVal ss As String)
        fd = 0
        On Error Resume Next
        xd = 0
        xx = 0
        check(0, nn, ss)
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
    Dim q As Integer = 0
    Dim s As Integer = 0
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
        Button4.Enabled = True
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
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
        xx = 0
        GoTo a
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Button5.Enabled = False
        Else
            Button5.Enabled = True
        End If
        Button4.Enabled = False
    End Sub
End Class