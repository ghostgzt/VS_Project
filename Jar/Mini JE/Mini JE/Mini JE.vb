Public Class Mini_JE
    Dim jj As New JEExt.JEE
    Dim cc As Boolean = False
    Dim di As Boolean = False
    Private Sub Button1_Click() Handles Button1.Click
        If TextBox3.Text <> "" And di = False Then
            If ComboBox1.Text = "" Then
                ComboBox1.Text = ComboBox1.Items(0).ToString()
            End If
            On Error Resume Next
            PictureBox1.Image = Nothing
            Label1.Text = ""
            If ComboBox1.Text = "0独项法" Then
                DX(Label1, PictureBox1)
            Else
                QX(Label1, PictureBox1)
            End If
            TextBox4.Text = ""
            jj.endd("$JEE163.tmp")
            TextBox4.Visible = True
            TextBox4.Text = (jj.JJ(TextBox2.Text + TextBox1.Text + TextBox2.Text, 3, "")).ToString.Replace(vbLf, vbCrLf)
            jj.endd("$JEE163.tmp")
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub
    Function DX(ByVal L As Label, ByVal P As PictureBox)
        On Error Resume Next
        Dim t As String = jj.JJ(TextBox2.Text + TextBox1.Text + TextBox2.Text, 0, TextBox2.Text)
        If t <> "" Then
            Dim x = 0
            Do
                x = x + 1
            Loop Until Mid(t, x, Len(vbCrLf)) = vbCrLf Or x > Len(t)
            Dim r = x + 1
            Dim mnane = t.Remove(x)
            Do
                x = x + 1
            Loop Until Mid(t, x, Len(vbCrLf)) = vbCrLf Or x > Len(t)
            Dim u = x + 1
            Dim micon = t.Remove(0, r).Remove(u - r)
            Dim vedor = t.Remove(0, u)
            L.Text = ""
            If vedor <> "" Then
                L.Text = mnane + " v" + vedor
            Else
                L.Text = mnane
            End If
            TextBox4.Text = ""
            P.Image = Image.FromFile(micon)
        End If
    End Function
    Function QX(ByVal L As Label, ByVal P As PictureBox)
        On Error Resume Next
        Dim t As String = jj.JJ(TextBox2.Text + TextBox1.Text + TextBox2.Text, 1, TextBox2.Text)
        L.Text = ""
        L.Text = (jj.zf(TextBox2.Text + TextBox1.Text + TextBox2.Text, t, True, TextBox2.Text))
        P.Image = Image.FromFile(jj.zf(TextBox2.Text + TextBox1.Text + TextBox2.Text, t, False, TextBox2.Text))
    End Function
    Private Sub Button2_Click() Handles Button2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowNewFolderButton = False
            .ShowDialog()
            If .SelectedPath <> "" Then
                TextBox3.Text = .SelectedPath
            End If
        End With
    End Sub
    Private Sub TextBox3_TextChanged() Handles TextBox3.TextChanged
        On Error Resume Next
        TextBox4.Text = ""
        ToolStripStatusLabel1.Text = ""
        Label1.Text = ""
        TextBox1.Text = ""
        PictureBox1.Image = Nothing
        ListBox1.Items.Clear()
        ToolStripButton2.Enabled = False
        Dim n = My.Computer.FileSystem.GetFiles(TextBox3.Text, FileIO.SearchOption.SearchTopLevelOnly, "*.jar")
        For x = 0 To n.Count - 1
            ListBox1.Items.Add(getname(n(x), "\", False, 0))
        Next
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
    Private Sub Mini_JE_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
        RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon")
    End Sub
    Private Sub ME_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Command() <> "" Then
            If My.Application.CommandLineArgs(0) = "D" Then
                TextBox3.Text = (Command.Remove(0, 1)).Replace(TextBox2.Text, "").Trim
            End If
            If My.Application.CommandLineArgs(0) = "F" Then
                TextBox1.Text = (Command.Remove(0, 1)).Replace(TextBox2.Text, "").Trim
                ToolStripStatusLabel1.Text = TextBox1.Text
                cc = True
                AT()
            End If
        Else
            TextBox3.Text = ""
        End If
        ContextMenuStrip1_Opening()
    End Sub
    Private Sub GetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub CopyToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToToolStripMenuItem.Click
        CM(0)
    End Sub
    Function CM(ByVal str As Integer)
        If ListBox1.SelectedItems.Count <> 0 Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .ShowNewFolderButton = True
                .ShowDialog()
                Dim tt As String = ""
                If .SelectedPath <> "" Then
                    On Error Resume Next
                    For x = 0 To ListBox1.SelectedItems.Count - 1
                        tt = TextBox3.Text + "\" + ListBox1.SelectedItems(x).ToString
                        If str = 0 Then
                            My.Computer.FileSystem.CopyFile(tt, .SelectedPath + "\" + getname(tt, "\", False, 0), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                        Else
                            My.Computer.FileSystem.MoveFile(tt, .SelectedPath + "\" + getname(tt, "\", False, 0), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
                        End If
                    Next
                End If
            End With
        End If
        On Error Resume Next
        TextBox3_TextChanged()
    End Function
    Private Sub MoveToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToToolStripMenuItem.Click
        CM(1)
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim tt As String = ""
        For x = 0 To ListBox1.SelectedItems.Count - 1
            My.Computer.FileSystem.DeleteFile(TextBox3.Text + "\" + ListBox1.SelectedItems(x).ToString, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        Next
        TextBox3_TextChanged()
    End Sub
    Private Sub AttribToolStripMenuItem_Click() Handles AttribToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count = 1 Then
            AT()
        End If
    End Sub
    Function AT()
        On Error Resume Next
        SX.Text = "Attribute-" + TextBox1.Text
        jj.endd("$JEE163.tmp")
        DX(Label1, PictureBox1)
        jj.endd("$JEE163.tmp")
        If PictureBox1.Image Is Nothing Then
            jj.endd("$JEE163.tmp")
            Dim t As String = jj.JJ(TextBox2.Text + TextBox1.Text + TextBox2.Text, 1, TextBox2.Text)
            jj.endd("$JEE163.tmp")
            PictureBox1.Image = Image.FromFile(jj.zf(TextBox2.Text + TextBox1.Text + TextBox2.Text, t, False, TextBox2.Text))
        End If
        TextBox4.Text = ""
        jj.endd("$JEE163.tmp")
        TextBox4.Visible = True
        TextBox4.Text = (jj.JJ(TextBox2.Text + TextBox1.Text + TextBox2.Text, 3, "")).ToString.Replace(vbLf, vbCrLf)
        jj.endd("$JEE163.tmp")
        SX.TextBox1.Text = TextBox4.Text
        SX.Label1.Text = Label1.Text
        SX.PictureBox1.Image = PictureBox1.Image
        Me.Hide()
        SX.ShowDialog()
        If cc = True Then
            End
        End If
        Me.Show()
        jj.endd("$JEE163.tmp")
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Private Sub ContextMenuStrip1_Opening() Handles ContextMenuStrip1.Opening
        If ListBox1.SelectedItems.Count <> 0 Then
            RunToolStripMenuItem.Visible = True
            QSFToolStripMenuItem.Visible = True
            JavaSettingToolStripMenuItem.Visible = True
            GetToolStripMenuItem.Visible = True
            CopyToToolStripMenuItem.Visible = True
            MoveToToolStripMenuItem.Visible = True
            DeleteToolStripMenuItem.Visible = True
            AttribToolStripMenuItem.Visible = True
            ToolStripButton2.Enabled = True
            If ListBox1.SelectedItems.Count > 1 Then
                RunToolStripMenuItem.Visible = False
                QSFToolStripMenuItem.Visible = False
                JavaSettingToolStripMenuItem.Visible = False
                GetToolStripMenuItem.Visible = False
                AttribToolStripMenuItem.Visible = False
                ToolStripButton2.Enabled = False
            End If
        Else
            RunToolStripMenuItem.Visible = False
            QSFToolStripMenuItem.Visible = False
            JavaSettingToolStripMenuItem.Visible = False
            GetToolStripMenuItem.Visible = False
            CopyToToolStripMenuItem.Visible = False
            MoveToToolStripMenuItem.Visible = False
            DeleteToolStripMenuItem.Visible = False
            AttribToolStripMenuItem.Visible = False
            ToolStripButton2.Enabled = False
        End If
    End Sub
    Private Sub ToolStripButton1_Click() Handles ToolStripButton1.Click
        di = True
        For k = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndices.Add(k)
        Next
        ToolStripStatusLabel1.Text = "已选择" + Str(ListBox1.Items.Count) + "个程序"
        di = False
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        TextBox3_TextChanged()
    End Sub
    Private Sub ListBox1_DoubleClick() Handles ListBox1.DoubleClick
        On Error Resume Next
        Dim runer = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        If ListBox1.SelectedItems.Count = 1 Then
            Dim t = TextBox3.Text + "\" + ListBox1.SelectedItems.Item(0)
            Shell(runer + " " + TextBox2.Text + t + TextBox2.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        TextBox4.Text = ""
        PictureBox1.Image = Nothing
        Label1.Text = ""
        If di = False Then
            TextBox1.Text = TextBox3.Text + "\" + ListBox1.Text
            ToolStripStatusLabel1.Text = "Path: " + TextBox1.Text + "|Size: " + Str(CInt(My.Computer.FileSystem.GetFileInfo(TextBox1.Text).Length / 1024)) + "K"
            Button1_Click()
            If ListBox1.SelectedItems.Count = 1 Then
                RunToolStripMenuItem.Visible = True
                QSFToolStripMenuItem.Visible = True
                JavaSettingToolStripMenuItem.Visible = True
            Else
                RunToolStripMenuItem.Visible = False
                QSFToolStripMenuItem.Visible = False
                JavaSettingToolStripMenuItem.Visible = False
            End If
        End If
        ContextMenuStrip1_Opening()
    End Sub
    Private Sub 运行程序ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        ListBox1_DoubleClick()
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        AT()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox3.Text <> "" And ListBox1.Items.Count <> 0 Then
            Button1_Click()
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ListBox1_DoubleClick()
    End Sub
    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
        On Error Resume Next
        di = True
        Dim lb As New ListBox
        lb.Items.Clear()
        For t = 0 To ListBox1.SelectedItems.Count - 1
            lb.Items.Add(ListBox1.SelectedIndices.Item(t))
        Next
        For k = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndices.Add(k)
        Next
        For g = 0 To ListBox1.SelectedIndices.Count - 1
            ListBox1.SelectedIndices.Remove((lb.Items.Item(g)))
        Next
        ToolStripStatusLabel1.Text = "已选择" + Str(ListBox1.SelectedItems.Count) + "个程序"
        di = False
    End Sub
    Private Sub QSFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QSFToolStripMenuItem.Click
        On Error Resume Next
        Dim t = TextBox1.Text
        Shell(My.Application.Info.DirectoryPath + "\QuickShowFiles.exe" + " " + TextBox2.Text + t + TextBox2.Text, AppWinStyle.NormalFocus)
    End Sub
    Private Sub JavaSettingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JavaSettingToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.SelectedItems.Count = 1 Then
            Dim t = TextBox1.Text
            Shell(My.Application.Info.DirectoryPath + "\Jar Setting.exe " + TextBox2.Text + t + TextBox2.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
End Class