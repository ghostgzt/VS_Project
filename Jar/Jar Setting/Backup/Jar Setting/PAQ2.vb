Public Class PAQ2
    Dim tmppath As String
    Dim bj As Boolean = False
    Private Sub PAQ2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        sttop()
    End Sub
    Function sttop()
        On Error Resume Next
        Dim hht As String = JS.can(ComboBox1.Items(ComboBox1.Items.Count - 1))
        If hht = Nothing Then
            ComboBox1.Items.RemoveAt(ComboBox1.Items.Count - 1)
        End If
        On Error Resume Next
        Dim ttl As New ListBox
        ttl.Items.Clear()
        Dim ts = 1
        If ComboBox1.Items(0) <> "1" Then
            ts = 0
        End If
        For w = ts To ComboBox1.Items.Count - 1
            ttl.Items.Add((ComboBox1.Items(w).ToString))
        Next
        JS.ComboBox4.Items.Clear()
        For q = 0 To ttl.Items.Count - 1
            JS.ComboBox4.Items.Add(ttl.Items(q).ToString)
        Next
        ttl.Items.Clear()
        For k = ts To ComboBox1.Items.Count - 1
            ttl.Items.Add(JS.can(ComboBox1.Items(k).ToString))
        Next
        JS.ListBox1.Items.Clear()
        For d = 0 To ttl.Items.Count - 1
            JS.ListBox1.Items.Add("MIDlet-" + Str(ComboBox1.Items(d + ts)).Trim + ": " + ttl.Items(d).ToString)
        Next
    End Function
    Private Sub PAQ2_Load() Handles MyBase.Load
        Panel1.Enabled = False
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox2.SelectedItem = Nothing
        tmppath = Jar.TextBox9.Text
        Dim k = My.Computer.FileSystem.GetFiles(tmppath, FileIO.SearchOption.SearchAllSubDirectories, "*.class")
        For i = 0 To k.Count - 1
            ComboBox2.Items.Add(k(i).Replace(tmppath, ""))
        Next
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        ComboBox3.Items.Clear()
        ComboBox3.SelectedItem = Nothing
        tmppath = Jar.TextBox9.Text
        Dim p = My.Computer.FileSystem.GetFiles(tmppath, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
        ComboBox3.Items.Add(" ")
        For i = 0 To p.Count - 1
            ComboBox3.Items.Add(p(i).Replace(tmppath, ""))
        Next
        Dim r0 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", Nothing)
        If r0 = "0" Then
            bj = True
            ComboBox1.Items.Add("1")
        End If
        For g = 0 To JS.ComboBox4.Items.Count - 1
            ComboBox1.Items.Add(JS.ComboBox4.Items(g))
        Next
        If r0 = "0" And JS.sf = True Then
            ComboBox1.SelectedIndex = 0
        End If
        If JS.ComboBox4.Text <> "" And JS.sf = False Then
            ComboBox1.SelectedItem = JS.ComboBox4.Text
        Else
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox2.SelectedItem = Nothing
        ComboBox3.SelectedItem = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        If ComboBox1.Text <> "1" Then
            TextBox1.Text = JS.can(ComboBox1.Text)
        Else
            TextBox1.Text = JS.M1.Text
        End If
        hhaa()
        ComboBox3_SelectedIndexChanged()
        PictureBox1.ImageLocation = tmppath + ComboBox3.Text
        PictureBox2.ImageLocation = tmppath + ComboBox3.Text
        If ComboBox1.Text <> "" Then
            Panel1.Enabled = True
        Else
            Panel1.Enabled = False
        End If
    End Sub
    Function hhaa()
        If TextBox1.Text <> "" Then
            Dim y = 0
            Do
                y = y + 1
            Loop Until Mid(TextBox1.Text, y, 1) = "," Or y > TextBox1.Text.Length
            If y <= TextBox1.Text.Length Then
                TextBox3.Text = TextBox1.Text.Remove(y - 1).Trim
                Dim t = y
                Do
                    t = t + 1
                Loop Until Mid(TextBox1.Text, t, 1) = "," Or t > TextBox1.Text.Length
                If t <= TextBox1.Text.Length Then
                    ComboBox3.Text = Mid(TextBox1.Text, y + 1, t - y - 1).Trim.Replace("/", "\")
                    ComboBox2.Text = ("\" + TextBox1.Text.Remove(0, t).Trim.Replace(".", "\")) + ".class"
                End If
            End If
        End If
    End Function
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        gg()
    End Sub
    Function gg()
        If TextBox3.Text <> "" And ComboBox2.Text <> "" Then
            TextBox2.Text = TextBox3.Text + "," + ComboBox3.Text.Replace("\", "/").Trim + "," + ComboBox2.Text.Remove(Len(ComboBox2.Text) - 6).Remove(0, 1).Replace("\", ".")
        End If
    End Function
    Private Sub ComboBox3_SelectedIndexChanged() Handles ComboBox3.SelectedIndexChanged
        gg()
        PictureBox1.ImageLocation = tmppath + ComboBox3.Text
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        gg()
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        On Error Resume Next
        Dim k
        If bj = False Then
            k = ComboBox1.Items.Count + 2
        Else
            k = ComboBox1.Items.Count + 1
        End If
        If ComboBox1.Items.Count = 1 And ComboBox1.Items(0).ToString = "1" Then
            GoTo u
        End If
        If ComboBox1.Items.Count = 0 Then
            GoTo u
        End If
        Dim hht As String = JS.can(ComboBox1.Items(ComboBox1.Items.Count - 1))
        If hht <> Nothing Then
u:          ComboBox1.Items.Add(k)
            ComboBox1.SelectedItem = k
        Else
            MsgBox("请先更改这一项！！！", MsgBoxStyle.Exclamation, "敬告！！！")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text <> "" And ComboBox1.Text <> "1" Then
            On Error Resume Next
            hh()
            Jar.ListBox3.Items.Clear()
            For o = 0 To Jar.ListBox1.Items.Count - 1
                Jar.ListBox1.SetSelected(o, True)
                Jar.ListBox3.Items.Add(Jar.ListBox1.Text)
            Next
            JS.addd()
            JS.A2()
            PAQ2_Load()
        Else
            If ComboBox1.Text = "1" Then
                MsgBox("首项不能删除！！！", MsgBoxStyle.Exclamation, "敬告！！！")
            End If
        End If
    End Sub
    Function hh()
        On Error Resume Next
        For d = 0 To Jar.ListBox1.Items.Count - 1
            Jar.ListBox1.SetSelected(d, True)
            If Jar.ListBox1.Text.Remove(Len("MIDlet-") + Len(ComboBox1.Text)) = "MIDlet-" + ComboBox1.Text Then
                Jar.ListBox1.Items.Remove(Jar.ListBox1.Text)
            End If
        Next
    End Function
    Private Sub Button1_Click() Handles Button1.Click
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            If TextBox2.Text = "" Or TextBox3.Text = "" Then
                MsgBox("此启动项和名称都不能空！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
            Else
                If ComboBox1.Text = "1" Then
                    JS.M1.Text = TextBox2.Text
                Else
                    hh()
                    Jar.ListBox1.Items.Add("MIDlet-" + ComboBox1.Text.Trim + ": " + TextBox2.Text)
                    JS.ListBox1.Items.Add("MIDlet-" + ComboBox1.Text.Trim + ": " + TextBox2.Text)
                    TextBox1.Text = TextBox2.Text
                    JS.A2()
                    JS.gettlis()
                End If
                MsgBox("已经完成启动项的修改！！！" + vbCrLf + "第" + ComboBox1.Text + "项: " + TextBox2.Text, MsgBoxStyle.Information, "温馨提示！！！")
                PictureBox1.ImageLocation = tmppath + ComboBox3.Text
                PictureBox2.ImageLocation = tmppath + ComboBox3.Text
            End If
        Else
            MsgBox("你还没选择启动项！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
            Button3_Click()
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        My.Computer.FileSystem.WriteAllBytes(tmppath + "\RMSBackup.class", My.Resources.RMS, False)
        PAQ2_Load()
        Button3_Click()
        TextBox3.Text = "RMSBackup"
        ComboBox3.SelectedIndex = 0
        ComboBox2.Text = "\RMSBackup.class"
        Button1_Click()
        Me.Close()
    End Sub
End Class