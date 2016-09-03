Public Class JS
    Dim mouseOffset
    Dim tmppath
    Dim ks As String
    Private Sub MName_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MName.DoubleClick
        TG.set1(MName, "名称:")
        TG.ShowDialog()
    End Sub
    Private Sub MName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MName.TextChanged
        Jar.zf(False, False)
        ks = ""
    End Sub
    Public Sub MIcon_Click() Handles MIcon.Click
        On Error Resume Next
        MIcon.Text.Trim()
        If Len(MIcon.Text) = 1 And MIcon.Text <> "/" Then
            MIcon.Text = "/" + MIcon.Text
        Else
            If MIcon.Text <> "" And MIcon.Text <> "/" Then
                If MIcon.Text.Remove(1) = " " Then
                    MIcon.Text = MIcon.Text.Remove(0, 1)
                End If
                If MIcon.Text.Remove(1) <> "/" Then
                    MIcon.Text = "/" + MIcon.Text
                End If
            End If
        End If
        If MIcon.Text = "/" Then
            MIcon.Text = ""
        End If
        Exit Sub
    End Sub
    Private Sub MIcon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIcon.TextChanged
        PictureBox1.ImageLocation = tmppath + MIcon.Text.Replace("/", "\")
        ks = ""
    End Sub
    Private Sub M1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M1.TextChanged
        Jar.zf(False, True)
        ks = ""
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        If M1.Text <> "" And MName.Text <> "" Then
            Jar.savetx()
            Jar.readpic()
            Jar.TextBox1.Text = MName.Text
            ks = "1"
            MsgBox("操作完成！！！", MsgBoxStyle.Information)
            Jar.XB(False)
        Else
            MsgBox("名称或启动项不能空！！！", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Jar.read()
        Jar.TextBox1.Text = MName.Text
        MsgBox("操作完成！！！", MsgBoxStyle.Information)
        ks = "1"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub JS_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Jar.ContextMenuStrip1.Enabled = False
        If ks = "" Then
            Dim uui = MsgBox("是否要执行修改后再退出?" + vbCrLf + "若不执行修改则修改无效！！！", MsgBoxStyle.YesNo, "执行修改?")
            If uui = MsgBoxResult.Yes Then
                Button1_Click()
            End If
        End If
        Jar.ContextMenuStrip1.Enabled = True
        Mini.Show()
    End Sub
    Private Sub JS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mini.Hide()
        Me.Text = "Jar高级修改-" + Jar.Retoqqq
        TextBox1.Text = ""
        Jar.read()
        tmppath = Jar.TextBox9.Text
        Me.Opacity = Jar.Opacity
        PictureBox1.ImageLocation = tmppath + MIcon.Text.Replace("/", "\")
        ks = "1"
        Me.Refresh()
    End Sub
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        On Error Resume Next
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Dim kw As Boolean = False
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim r0 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", Nothing)
        If r0 = "0" Then
            kw = True
            PAQ2.ShowDialog()
        Else
            QD.ShowDialog()
        End If
        Me.Show()
    End Sub
    Function sf()
        Return kw
    End Function
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        AboutMe.ShowDialog()
        Me.Show()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        PNGC.ShowDialog()
    End Sub
    Private Sub Za_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Za.MouseClick
        TG.set1(Za, "杂项:")
        TG.ShowDialog()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If URL.Text <> "" Then
            Shell(My.Computer.FileSystem.SpecialDirectories.ProgramFiles + "\Internet Explorer\iexplore.exe " + URL.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Jar.cs()
        ks = "1"
    End Sub
    Function A2()
        ComboBox4.Items.Clear()
        If Jar.ListBox1.Items.Count <> 0 Then
            For B = 0 To Jar.ListBox1.Items.Count - 1
                Jar.ListBox1.SetSelected(B, True)
                Try
                    Dim R = 0
                    Do
                        R = R + 1
                    Loop Until Mid(Jar.ListBox1.Text, R, 1) = ":" Or R > Len(Jar.ListBox1.Text)
                    If Jar.ListBox1.Text.Remove(0, 7).Remove(R - 7 - 1) > 1 Then
                        ComboBox4.Items.Add(Jar.ListBox1.Text.Remove(0, 7).Remove(R - 7 - 1))
                        TextBox1.Text = ""
                    End If
                Catch
                End Try
            Next
        End If
    End Function
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        TextBox1.Text = can(ComboBox4.Text)
    End Sub
    Function can(ByVal str As String)
        On Error Resume Next
        If str <> "" Then
            For u = 0 To ListBox1.Items.Count - 1
                If ListBox1.Items(u).ToString.Remove(7 + Len(str) + 1) = "MIDlet-" + str + ":" Then
                    Return ListBox1.Items(u).ToString.Remove(0, 7 + Len(str) + 1).Trim
                End If
            Next
        End If
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Hide()
        kw = False
        PAQ2.ShowDialog()
        Me.Show()
        ks = ""
    End Sub
    Function rr(ByVal str As String)
        Dim i = 0
        Do
            i = i + 1
        Loop Until Mid(str, i, 1) = ":" Or i > Len(str)
        If i <> 0 Then
            Return i
        End If
    End Function
    Function addd()
        Jar.ListBox1.Items.Clear()
        TextBox1.Text = ""
        For k = 0 To Jar.ListBox3.Items.Count - 1
            Jar.ListBox3.SetSelected(k, True)
            Dim d = rr(Jar.ListBox3.Text)
            If d <> 0 Then
                Jar.ListBox1.Items.Add("MIDlet-" + Str(Jar.ListBox1.Items.Count + 2).Trim + ": " + Jar.ListBox3.Text.Remove(0, d).Trim)
            End If
        Next
        gettlis()
    End Function
    Function gettlis()
        ListBox1.Items.Clear()
        If Jar.ListBox1.Items.Count <> 0 Then
            For p = 0 To Jar.ListBox1.Items.Count - 1
                Jar.ListBox1.SetSelected(p, True)
                ListBox1.Items.Add(Jar.ListBox1.Text)
            Next
        End If
    End Function
    Private Sub Description_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Description.MouseDoubleClick
        TG.set1(Description, "描述:")
        TG.ShowDialog()
    End Sub
    Private Sub Notify_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notify.MouseDoubleClick
        TG.set1(Notify, "Notify:")
        TG.ShowDialog()
    End Sub
    Private Sub URL_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles URL.MouseDoubleClick
        TG.set1(URL, "URL路径:")
        TG.ShowDialog()
    End Sub
    Private Sub Vendor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Vendor.MouseDoubleClick
        TG.set1(Vendor, "出版商:")
        TG.ShowDialog()
    End Sub
    Private Sub Version_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Version.MouseDoubleClick
        TG.set1(Version, "版本:")
        TG.ShowDialog()
    End Sub
    Private Sub Description_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Description.TextChanged
        ks = ""
    End Sub
    Private Sub URL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles URL.TextChanged
        ks = ""
    End Sub
    Private Sub Notify_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notify.TextChanged
        ks = ""
    End Sub
    Private Sub Version_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.TextChanged
        ks = ""
    End Sub
    Private Sub Vendor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vendor.TextChanged
        ks = ""
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ks = ""
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ks = ""
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        ks = ""
    End Sub
    Private Sub Za_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Za.TextChanged
        ks = ""
    End Sub
    Private Sub Permissions_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Permissions.DoubleClick
        TG.set1(Permissions, "Permissions:")
        TG.ShowDialog()
    End Sub
    Private Sub PerOpt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PerOpt.DoubleClick
        TG.set1(PerOpt, "Permissions-Opt:")
        TG.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    End Sub
End Class