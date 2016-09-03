Public Class Jar
    Dim oppp As String
    Dim tmppath As String = ""
    Dim picpath As String = ""
    Dim runpath As String = ""
    Dim jadpath As String = ""
    Dim seeor As Boolean
    Dim ttt
    Dim oldtmp As String = ""
    Dim mouseOffset
    Dim xx
    Dim yy
    Dim pp
    Dim ke
    Dim mini5
    Dim picsize As String
    Dim XG As Boolean = True
    Function ttemp(ByVal textboxx As String, ByVal vcf As String, ByVal inte As Integer)
        On Error Resume Next
        textboxx = textboxx.Replace(vcf + vcf, vcf)
        textboxx = textboxx.Replace(vcf + vcf + vcf, vcf)
        textboxx = textboxx.Replace(vcf + vcf + vcf + vcf, vcf)
        textboxx = textboxx.Replace(vcf + vcf + vcf + vcf + vcf, vcf)
        textboxx = Replace(Join(Split(Join(Split(textboxx, vcf & vcf), vcf), vcf & vcf), vcf), vcf & vcf, vcf)
        textboxx = textboxx.Replace(vcf + vcf, vcf)
        If (textboxx.Remove(1) = vcf) Then
            textboxx = textboxx.Remove(0, 1)
        End If
        If textboxx.Remove(0, Len(textboxx) - 1) = vcf Then
            textboxx = textboxx.Remove(Len(textboxx) - 1)
        End If
        Return textboxx
    End Function
    Function delrow()
        ttemp(TextBox4.Text, vbCr, 1)
        ttemp(TextBox4.Text, vbLf, 1)
        ttemp(TextBox4.Text, vbCrLf, 2)
        ttemp(TextBox4.Text, vbCrLf, 1)
    End Function
    Function textcls()
        JS.MName.Text = ""
        JS.Notify.Text = ""
        JS.URL.Text = ""
        JS.Vendor.Text = ""
        JS.M1.Text = ""
        JS.Version.Text = ""
        JS.Description.Text = ""
        JS.MIcon.Text = ""
    End Function
    Function read()
        ListBox9.Items.Clear()
        textcls()
        Dim tmp0
        Dim tmp1
        Dim uu As Integer = TextBox4.Text.Length
        listcls0()
        M3.Text = ""
        PictureBox2.Image = Nothing
        PictureBox1.Image = Nothing
        uuu(0, uu, ListBox1)
        delrow()
        TextBox4.Text = TextBox4.Text.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf).Trim
        delrow()
        TextBox4.Text = TextBox4.Text.Replace(vbCrLf + " ", "").Trim
        uuu(0, uu, ListBox1)
        MF.bz(TextBox4)
        For x = 0 To ListBox1.Items.Count - 1
            ListBox1.SetSelected(x, True)
            tmp0 = ListBox1.Text
            If x + 1 < ListBox1.Items.Count Then
                ListBox1.SetSelected(x + 1, True)
                tmp1 = ListBox1.Text
                If tmp0 = -2 Then
                    If TextBox4.Text.Remove(tmp1 + 2) <> "" Or TextBox4.Text.Remove(tmp1 + 2) <> vbCrLf Then
                        ListBox2.Items.Add(TextBox4.Text.Remove(tmp1 + 2).Replace(vbCrLf, ""))
                    End If
                Else
                    If TextBox4.Text.Remove(0, tmp0).Remove(tmp1 - tmp0).Replace(vbCrLf, "") <> "" Or TextBox4.Text.Remove(0, tmp0).Remove(tmp1 - tmp0).Replace(vbCrLf, "") <> vbCrLf Then
                        ListBox2.Items.Add(TextBox4.Text.Remove(0, tmp0).Remove(tmp1 - tmp0).Replace(vbCrLf, ""))
                    End If
                End If
            Else
                If TextBox4.Text.Remove(0, tmp0 + 2) <> "" Or TextBox4.Text.Remove(0, tmp0 + 2) <> vbCrLf Then
                    ListBox2.Items.Add(TextBox4.Text.Remove(0, tmp0 + 2).Replace(vbCrLf, ""))
                End If
            End If
        Next
        ListBox2.Items.Remove(vbCrLf)
        ListBox2.Items.Remove("")
        foruk()
        JS.MIcon_Click()
        YH(tmppath + "\" + JS.MIcon.Text.Trim.Replace("/", "\"))
        readpic()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "100")
        se2()
        Exit Function
iii:    MsgBox("Error!!!")
    End Function
    Function se2()
        If seeor = True Then
            Me.Top = xx - ((186 - 154) / 2)
            Me.Left = yy
            Me.Height = 154
            Me.Width = 294
        End If
    End Function
    Function foruk()
        JS.Data.Text = ""
        JS.Za.Text = ""
        'JS.Permissions.Text = Per("MIDlet-Permissions:")
        'JS.PerOpt.Text = (Per("MIDlet-Permissions-Opt:"))
        ListBox3.Items.Clear()
        Dim uyq = ListBox2.Items.Count - 1
        For q = 0 To uyq
            ListBox2.SetSelected(q, True)
            uyt("Manifest-Version:")
            uyt("MIDlet-Name:")
            uyt("MIDlet-Icon:")
            uyt("MIDlet-1:")
            uyt("MIDlet-Vendor:")
            uyt("MIDlet-Version:")
            uyt("MIDlet-Install-Notify:")
            uyt("MIDlet-Info-URL:")
            uyt("MIDlet-")
            uyt("MIDlet-Description:")
            uyt("MIDlet-Data-Size:")
            uyt("MicroEdition-Configuration:")
            uyt("MicroEdition-Profile:")
            uyt("MIDlet-Permissions:")
            uyt("MIDlet-Permissions-Opt:")
        Next
        If ListBox2.Items.Count <> 0 Then
            If ListBox3.Items.Count <> 0 Then
                toto()
            End If
            If M0.Text <> "" Then
                JS.ComboBox1.Text = M0.Text.Replace("Manifest-Version:", "").Trim
            End If
            If M2.Text <> "" Then
                JS.ComboBox2.Text = M2.Text.Replace("MicroEdition-Configuration:", "").Trim
            End If
            If M3.Text <> "" Then
                JS.ComboBox3.Text = M3.Text.Replace("MicroEdition-Profile:", "").Trim
            End If
            JS.ComboBox4.Items.Clear()
            ListBox3.Items.Clear()
            If ListBox9.Items.Count <> 0 Then
                For p = 0 To ListBox9.Items.Count - 1
                    ListBox9.SetSelected(p, True)
                    Try
                        Dim t = 0
                        Do
                            t = t + 1
                        Loop Until Mid(ListBox9.Text, t, 1) = ":"
                        If ListBox9.Text.Remove(0, 7).Remove(t - 7 - 1) > 1 Then
                            ListBox3.Items.Add(ListBox9.Text)
                        End If
                    Catch
                    End Try
                Next
            End If
            For c = 0 To ListBox3.Items.Count - 1
                ListBox3.SetSelected(c, True)
                ListBox2.Items.Remove(ListBox3.Text)
            Next
            For u = 0 To ListBox2.Items.Count - 1
                ListBox2.SetSelected(u, True)
                If u = 0 Then
                    JS.Za.Text = ListBox2.Text
                Else
                    JS.Za.Text = JS.Za.Text + vbCrLf + ListBox2.Text
                End If
            Next
            JS.addd()
            JS.A2()
        End If
        TextBox1.Text = JS.MName.Text
    End Function
    Function uyt(ByVal str As String)
        On Error Resume Next
        Dim lenn As Integer = Len(str)
        Dim li = ListBox2.Text.Remove(lenn)
        Dim le = ListBox2.Text.Remove(0, lenn).Trim
        If li = str Then
            If str = "MIDlet-Name:" Then
                JS.MName.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Icon:" Then
                JS.MIcon.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-1:" Then
                JS.M1.Text = le
                ListBox3.Items.Add(ListBox2.Text)
                ListBox9.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Vendor:" Then
                JS.Vendor.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Version:" Then
                JS.Version.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Install-Notify:" Then
                JS.Notify.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Info-URL:" Then
                JS.URL.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-" Then
                ListBox9.Items.Remove(ListBox2.Text)
                ListBox9.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Description:" Then
                JS.Description.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Data-Size:" Then
                JS.Data.Text = Int(le)
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "Manifest-Version:" Then
                M0.Text = (ListBox2.Text)
            End If
            If str = "MicroEdition-Configuration:" Then
                M2.Text = (ListBox2.Text)
            End If
            If str = "MicroEdition-Profile:" Then
                M3.Text = (ListBox2.Text)
            End If
            If str = "MIDlet-Permissions:" Then
                JS.Permissions.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
            If str = "MIDlet-Permissions-Opt:" Then
                JS.PerOpt.Text = le
                ListBox3.Items.Add(ListBox2.Text)
            End If
        End If
    End Function
    Function toto()
        Dim uu0 = 0
        Dim uu1 = 0
        For z = 0 To ListBox3.Items.Count - 1
            ListBox3.SetSelected(z, True)
            ListBox2.Items.Remove(ListBox3.Text)
        Next
        If M0.Text <> "" Then
            ListBox2.Items.Remove(M0.Text)
        End If
        If M2.Text <> "" Then
            ListBox2.Items.Remove(M2.Text)
        End If
        If M3.Text <> "" Then
            ListBox2.Items.Remove(M3.Text)
        End If
    End Function
    Function savetx()
        Dim eo As String
        If JS.ComboBox1.Text <> "" Then
        Else
            JS.ComboBox1.Text = "1.0"
        End If
        eo = "Manifest-Version: " + JS.ComboBox1.Text.Trim
        If JS.MName.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Name: " + JS.MName.Text.Trim
        End If
        If JS.MIcon.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Icon: " + JS.MIcon.Text.Trim
        End If
        If JS.M1.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-1: " + JS.M1.Text.Trim
        End If
        If JS.ListBox1.Items.Count <> 0 Then
            For i = 0 To JS.ListBox1.Items.Count - 1
                eo = eo + vbCrLf + JS.ListBox1.Items(i).ToString.Trim
            Next
        End If
        If JS.Vendor.Text.Trim = "" Then
            JS.Vendor.Text = "None"
        End If
        eo = eo + vbCrLf + "MIDlet-Vendor: " + JS.Vendor.Text.Trim
        If JS.Version.Text = "" Then
            JS.Version.Text = "1.0"
        End If
        eo = eo + vbCrLf + "MIDlet-Version: " + JS.Version.Text.Trim
        If JS.Description.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Description: " + JS.Description.Text.Trim
        End If
        If JS.Notify.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Install-Notify: " + JS.Notify.Text.Trim
        End If
        If JS.URL.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Info-URL: " + JS.URL.Text.Trim
        End If
        If JS.Data.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Data-Size: " + JS.Data.Text.Trim
        End If
        If JS.Permissions.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Permissions: " + JS.Permissions.Text.Trim.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf)
        End If
        If JS.PerOpt.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Permissions-Opt: " + JS.PerOpt.Text.Trim.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf)
        End If
        If JS.Za.Text <> "" Then
            eo = eo + vbCrLf + JS.Za.Text.Trim.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf)
        End If
        If JS.ComboBox2.Text <> "" Then
        Else
            JS.ComboBox2.Text = "CLDC-1.1"
        End If
        eo = eo + vbCrLf + "MicroEdition-Configuration: " + JS.ComboBox2.Text.Trim
        If JS.ComboBox3.Text <> "" Then
        Else
            JS.ComboBox3.Text = "MIDP-2.0"
        End If
        eo = eo + vbCrLf + "MicroEdition-Profile: " + JS.ComboBox3.Text.Trim
        TextBox4.Text = eo
        savefile()
    End Function
    Function uuu(ByVal x As Integer, ByVal uu As Integer, ByVal listboxx As ListBox)
        listboxx.Items.Clear()
        listboxx.Items.Add(-2)
        For y = x To uu - 1
            If Mid(TextBox4.Text, y + 1, 2) = vbCrLf Then
                listboxx.Items.Add(y)
            End If
        Next
        listboxx.SetSelected(0, True)
    End Function
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
    Function zf(ByVal ntf As Boolean, ByVal itf As Boolean)
        On Error Resume Next
        If JS.M1.Text <> "" Then
            Dim r0 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "XM", Nothing)
            Dim mname As String
            mname = ""
            Dim mn = getname(JS.M1.Text, ",", True, 1).ToString
            If ntf = True Then
                If JS.MName.Text = "" Then
                    JS.MName.Text = mn
                End If
                If JS.MName.Text <> mn Then
                    JS.MName.Text = mn
                End If
            Else
                If r0 = "0" Then
                    If mn.Trim = "" Then
                        mname = JS.MName.Text
                    Else
                        mname = mn
                    End If
                Else
                    mname = JS.MName.Text
                End If
            End If
            If JS.MIcon.Text.Trim = "" Or JS.MIcon.Text.Trim = "/" Then
                If getname(getname(JS.M1.Text, ",", False, 1).ToString, ",", False, 0) <> "" Then
                    Dim mi As String = getname(getname(JS.M1.Text, ",", False, 1).ToString, ",", True, 0).ToString
                    If mi.Trim = "" Then
                        JS.MIcon.Text = ""
                    Else
                        JS.MIcon.Text = mi
                    End If
                End If
            End If
            If getname(getname(JS.M1.Text, ",", False, 1).ToString, ",", False, 0) = "" Then
                JS.M1.Text = ""
            Else
                JS.M1.Text = (mname + "," + getname(JS.M1.Text, ",", False, 1).ToString)
            End If
        Else
            JS.M1.Text = ""
        End If
    End Function
    Private Sub Button5_Click() Handles Button5.Click
        openzip(False)
        XB(True)
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        If TextBox1.Text <> "" Then
            If JS.M1.Text <> "" Then
                XB(True)
                ContextMenuStrip1.Enabled = False
                gpic()
                see()
                save(True)
                se2()
                ContextMenuStrip1.Enabled = True
            Else
                MsgBox("主启动项不能空！", MsgBoxStyle.Exclamation, "敬告！！！")
                QD.ShowDialog()
            End If
        Else
            MsgBox("程序名不能空！", MsgBoxStyle.Exclamation, "敬告！！！")
        End If
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        XB(False)
        查看ToolStripMenuItem.Checked = True
        主窗口ToolStripMenuItem.Checked = False
        Me.Hide()
        ttt = "3"
        MF.ShowDialog()
        ttt = ""
        Me.Show()
        主窗口ToolStripMenuItem.Checked = True
        查看ToolStripMenuItem.Checked = False
    End Sub
    Function readpic()
        ke = 1
        On Error Resume Next
        ComboBox1.Items.Remove(" ")
        PictureBox2.Image = Nothing
        PictureBox2.Height = 48
        PictureBox2.Width = 51
        Dim oq = JS.MIcon.Text.Trim.Replace("/", "\")
        If Mid(JS.MIcon.Text, 1, 1) <> "/" Then
            PictureBox2.ImageLocation = tmppath + "\" + oq
            pp = tmppath + "\" + oq
            PictureBox1.Image = PictureBox2.Image
        Else
            PictureBox2.ImageLocation = tmppath + oq
            pp = tmppath + oq
            PictureBox1.Image = PictureBox2.Image
        End If
        Mini.PictureBox1.Image = PictureBox1.Image
        If Mini.PictureBox1.Image Is Nothing Then
            Mini.PictureBox1.Image = Me.Icon.ToBitmap
        End If
        If PictureBox2.Image Is Nothing Then
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
            Dim kb As String = PictureBox2.Image.Width
            Dim pb As String = PictureBox2.Image.Height
            picsize = kb + "*" + pb
            addsize()
            ComboBox1.Text = kb + "*" + pb
            ComboBox1.Items.Remove(" ")
        End If
        If PictureBox1.Image Is Nothing Then
            ComboBox1.Items.Add(" ")
            ComboBox1.Text = " "
            picsize = ComboBox1.Text
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\PicResizer.exe") = False Then
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
        If ComboBox1.Text = " " Then
            ComboBox1.Enabled = False
        Else
            ComboBox1.Enabled = True
        End If
        ComboBox1.Items.Remove(" ")
        ke = 1
    End Function
    Function gpic()
        If PictureBox1.Image Is Nothing Then
        Else
            If (ComboBox1.Text <> "" And ke <> 1) Or (ComboBox1.Text <> picsize) Then
                Dim oq = JS.MIcon.Text.Trim.Replace("/", "\")
                If Mid(JS.MIcon.Text, 1, 1) <> "/" Then
                    PictureBox2.ImageLocation = tmppath + "\" + oq
                    pp = tmppath + "\" + oq
                    PictureBox1.Image = PictureBox2.Image
                Else
                    PictureBox2.ImageLocation = tmppath + oq
                    pp = tmppath + oq
                    PictureBox1.Image = PictureBox2.Image
                End If
                Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe " + "KZ " + TextBox3.Text + pp + TextBox3.Text + " " + ComboBox1.Text, 0, True)
                 readpic()
            End If
        End If
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        XB(False)
        On Error GoTo p
        gpic()
        ke = 1
        If My.Application.CommandLineArgs.Item(0).ToLower = "/mini" Then
            If TextBox2.Text = "" Then
                Dim y = MsgBox("您没填新名,继续保存吗?", MsgBoxStyle.YesNo, "温馨提示！！！")
                If y = MsgBoxResult.Yes Then
                    Button1_Click()
                    退出ToolStripMenuItem_Click()
                End If
            Else
                Button1_Click()
                退出ToolStripMenuItem_Click()
            End If
        Else
p:          If TextBox2.Text <> "" Then
                JS.MName.Text = TextBox2.Text
                TextBox1.Text = JS.MName.Text
                savetx()
                My.Computer.FileSystem.WriteAllText(tmppath + "\META-INF\MANIFEST.MF", TextBox4.Text, False)
                MsgBox("操作完成！！！", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Function savefile()
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(tmppath + "\META-INF") = False Then
            MkDir(tmppath + "\META-INF")
        Else
            Rename(tmppath + "\META-INF", tmppath + "\META-INF1")
            Rename(tmppath + "\META-INF1", tmppath + "\META-INF")
        End If
        My.Computer.FileSystem.WriteAllText(tmppath + "\META-INF\MANIFEST.MF", TextBox4.Text.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf), False, System.Text.Encoding.UTF8)
        Dim ky = My.Resources.UTF8
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP", ky, False)
        Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP" + TextBox3.Text + " " + TextBox3.Text + tmppath + "\META-INF\MANIFEST.MF" + TextBox3.Text, 0, True)
        listcls0()
        PictureBox2.Image = Nothing
        Dim k = My.Computer.FileSystem.ReadAllText(tmppath + "\META-INF\MANIFEST.MF", System.Text.Encoding.UTF8)
        TextBox4.Text = k
    End Function
    Private Sub Button1_Click() Handles Button1.Click
        If TextBox1.Text <> "" Then
            If JS.M1.Text <> "" Then
                XB(True)
                ContextMenuStrip1.Enabled = False
                gpic()
                see()
                save(False)
                se2()
                ContextMenuStrip1.Enabled = True
            Else
                MsgBox("主启动项不能空！", MsgBoxStyle.Exclamation, "敬告！！！")
                QD.ShowDialog()
            End If
        Else
            MsgBox("程序名不能空！", MsgBoxStyle.Exclamation, "敬告！！！")
        End If
    End Sub
    Function jad()
        Dim eo As String = ""
        If JS.ComboBox1.Text <> "" Then
        Else
            JS.ComboBox1.Text = "1.0"
        End If
        eo = "Manifest-Version: " + JS.ComboBox1.Text.Trim
        If JS.MName.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Name: " + JS.MName.Text.Trim
        End If
        If JS.MIcon.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Icon: " + JS.MIcon.Text.Trim
        End If
        If JS.M1.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-1: " + JS.M1.Text.Trim
        End If
        If JS.ListBox1.Items.Count <> 0 Then
            For i = 0 To JS.ListBox1.Items.Count - 1
                JS.ListBox1.SetSelected(i, True)
                eo = eo + vbCrLf + JS.ListBox1.Text
            Next
        End If
        If JS.Vendor.Text.Trim = "" Then
            JS.Vendor.Text = "None"
        End If
        eo = eo + vbCrLf + "MIDlet-Vendor: " + JS.Vendor.Text.Trim
        If JS.Version.Text = "" Then
            JS.Version.Text = "1.0"
        End If
        eo = eo + vbCrLf + "MIDlet-Version: " + JS.Version.Text.Trim
        If JS.Description.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Description: " + JS.Description.Text.Trim
        End If
        If JS.Notify.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Install-Notify: " + JS.Notify.Text.Trim
        End If
        If JS.URL.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Info-URL: " + JS.URL.Text.Trim
        End If
        If JS.Data.Text <> "" Then
            eo = eo + vbCrLf + "MIDlet-Data-Size: " + JS.Data.Text.Trim
        End If
        If JS.ComboBox2.Text <> "" Then
        Else
            JS.ComboBox2.Text = "CLDC-1.1"
        End If
        eo = eo + vbCrLf + "MicroEdition-Configuration: " + JS.ComboBox2.Text.Trim
        If JS.ComboBox3.Text <> "" Then
        Else
            JS.ComboBox3.Text = "MIDP-2.0"
        End If
        eo = eo + vbCrLf + "MicroEdition-Profile: " + JS.ComboBox3.Text.Trim
        Return eo
    End Function
    Function makejad(ByVal jarpath As String)
        If jadpath <> "" Then
            On Error Resume Next
            Dim j = jad()
            Dim z = "MIDlet-Jar-Size: " + My.Computer.FileSystem.GetFileInfo(jarpath).Length.ToString.Trim
            Dim n = "MIDlet-Jar-URL: " + My.Computer.FileSystem.GetFileInfo(jarpath).Name.ToString.Trim
            If My.Computer.FileSystem.FileExists(Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d") = True Then
                On Error Resume Next
                Kill(Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d" + ".BAK")
                Rename(Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d", Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d" + ".BAK")
            End If
            My.Computer.FileSystem.WriteAllText(Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d", z + vbCrLf + n + vbCrLf + j, False, System.Text.Encoding.UTF8)
            Dim ky = My.Resources.UTF8
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP", ky, False)
            Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP" + TextBox3.Text + " " + TextBox3.Text + Mid(jarpath.Replace(TextBox3.Text, ""), 1, Len(jarpath.Replace(TextBox3.Text, "")) - 1) + "d" + TextBox3.Text, 0, True)
        End If
    End Function
    Function save(ByVal ty As Boolean)
        Dim r0 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "MF", Nothing)
        If r0 = "" Then
            savetx()
        End If
        If ty = True Then
            SaveFileDialog1.FileName = TextBox1.Text + ".Jar"
            SaveFileDialog1.Filter = "*.Jar|*.Jar"
            If SaveFileDialog1.FileName <> "" And SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                On Error GoTo i
                ChDir(tmppath)
                opp()
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P1", "100")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "0")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "XX", Me.Left)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "YY", Me.Top + Me.Height)
                Shell(My.Application.Info.DirectoryPath + "\Progress.exe", AppWinStyle.NormalFocus)
                Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$U12ZZ.tmp" + TextBox3.Text + " -r -9 " + TextBox3.Text + SaveFileDialog1.FileName + TextBox3.Text + " " + "*.*", AppWinStyle.Hide, True)
                makejad(SaveFileDialog1.FileName)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "100")
                zf(True, True)
                see()
                read()
                oppp = SaveFileDialog1.FileName
                Me.Text = "Jar Setting - " + oppp
                MsgBox("操作完成！！！", MsgBoxStyle.Information)
            End If
        Else
            ChDir(tmppath)
            opp()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P1", "100")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "0")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "XX", Me.Left)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "YY", Me.Top + Me.Height)
            Shell(My.Application.Info.DirectoryPath + "\Progress.exe", AppWinStyle.NormalFocus)
            If My.Computer.FileSystem.FileExists(oppp) = True Then
                If My.Computer.FileSystem.FileExists(oppp + ".BAK") = True Then
                    Kill(oppp + ".BAK")
                End If
                My.Computer.FileSystem.RenameFile(oppp, foundd(oppp, "\") + ".BAK")
            End If
            Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$U12ZZ.tmp" + TextBox3.Text + "-o -r -9 " + TextBox3.Text + oppp + TextBox3.Text + " " + "*.*", AppWinStyle.Hide, True)
            makejad(oppp)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "100")
            zf(True, True)
            see()
            read()
            MsgBox("操作完成！！！", MsgBoxStyle.Information)
        End If
        Exit Function
i:      MsgBox("操作失败！！！", MsgBoxStyle.Exclamation)
    End Function
    Function foundd(ByVal str As String, ByVal fgf As String)
        Dim u As String
        u = ""
        For y = 0 To str.Length - 1
            If Mid(str, y + 1, 1) = fgf Then
                u = y + 1
            End If
        Next
        If u <> "" Then
            Return str.Remove(0, u).ToUpper
        End If
    End Function
    Private Sub Button4_Click() Handles Button4.Click
        XB(False)
        ContextMenuStrip1.Enabled = False
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "*.png;*.bmp;*.jpg;*.gif;*.ico|*.png;*.bmp;*.jpg;*.gif;*.ico|*.*|*.*"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            ke = 0
            ComboBox1.Text = ""
            picsize = ComboBox1.Text
            www(OpenFileDialog1.FileName)
            ke = 1
        End If
        ContextMenuStrip1.Enabled = True
    End Sub
    Function www(ByVal y As String)
        On Error GoTo oo
        read()
        JS.MIcon_Click()
        If JS.MIcon.Text <> "" Then
            If Mid(JS.MIcon.Text, 1, 1) <> "/" Then
                JS.MIcon.Text = "/" + JS.MIcon.Text
            End If
            TextBox7.Text = JS.MIcon.Text
        End If
        If JS.MIcon.Text = "" Or JS.MIcon.Text = "/" Then
            Dim op = InputBox("输入写入图片名称(不用扩展名)！！！", , , , )
            If op <> "" Then
                TextBox7.Text = "\" + op + ".png"
            End If
        End If
        If TextBox7.Text <> "" Then
            totov()
            Dim imgPath4mlvimgs = y
            Dim resimg As New Bitmap(imgPath4mlvimgs)
            resimg.Save(tmppath + TextBox7.Text.Replace("/", "\"), System.Drawing.Imaging.ImageFormat.Png)
            resimg.Dispose()
            PictureBox2.ImageLocation = tmppath + TextBox7.Text.Replace("/", "\")
            Mini.PictureBox1.Image = PictureBox2.Image
            If Mini.PictureBox1.Image Is Nothing Then
                Mini.PictureBox1.Image = Me.Icon.ToBitmap
            End If
            PictureBox1.Image = PictureBox2.Image
            ComboBox1.Enabled = True
            Dim kb As String = PictureBox2.Image.Width
            Dim pb As String = PictureBox2.Image.Height
            picsize = kb + "*" + pb
            addsize()
            ComboBox1.Text = kb + "*" + pb
        Else
            ComboBox1.Enabled = False
        End If
        JS.MIcon.Text = TextBox7.Text.Trim.Replace("\", "/").Replace(" ", "")
        PNGC.ty()
        zf(True, True)
        If JS.M1.Text.Length = 1 And Mid(JS.MIcon.Text, 1, 1) = "/" Then
            JS.MIcon.Text = " "
        End If
        savetx()
        Exit Function
oo:
        MsgBox("修改失败！！！", MsgBoxStyle.Exclamation, "错误！！")
    End Function
    Function totov()
        On Error Resume Next
        My.Computer.FileSystem.CopyFile(tmppath + TextBox7.Text.Replace("/", "\"), tmppath + TextBox7.Text.Replace("/", "\") + ".BAK")
    End Function
    Private Sub Button6_Click() Handles Button6.Click
        设置ToolStripMenuItem.Checked = True
        主窗口ToolStripMenuItem.Checked = False
        Me.Hide()
        ttt = "3"
        SetBox.ShowDialog()
        ttt = ""
        Me.Show()
        主窗口ToolStripMenuItem.Checked = True
        设置ToolStripMenuItem.Checked = False
    End Sub
    Function listcls0()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox9.Items.Clear()
    End Function
    Function opp()
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Z12Z.tmp", My.Resources.unzip, False)
        My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$U12ZZ.tmp", My.Resources.zip, False)
    End Function
    Function see()
        On Error Resume Next
        If My.Application.CommandLineArgs.Item(0).ToLower <> "/mini" Then
            If seeor = False Then
                Me.Top = xx - ((186 - 154) / 2)
                Me.Height = 154
                Me.Width = 294
            Else
                Me.Top = xx - ((173 - 154) / 2)
                Me.Left = yy - ((751 - 294) / 2)
                Me.Height = 154
                Me.Width = 751
            End If
        Else
            Me.Top = xx - ((186 - 95) / 2)
            Me.Height = 95
            Me.Width = 294
        End If
    End Function
    Function openzip(ByVal noo As Boolean)
        ContextMenuStrip1.Enabled = False
        On Error Resume Next
        If tmppath <> "" Then
            If XG = False Then
                Dim kkb = MsgBox("确定保存退出？", MsgBoxStyle.YesNoCancel, "温馨提示！！！")
                If kkb = MsgBoxResult.Yes Then
                    Button1_Click()
                End If
                If kkb = MsgBoxResult.Cancel Then
                    GoTo p
                End If
            End If
        End If
        If noo = False Then
            打开ToolStripMenuItem.Checked = True
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.Filter = "*.Jar|*.Jar"
            OpenFileDialog1.ShowDialog()
        End If
        If OpenFileDialog1.FileName <> "" Then
            readjar(OpenFileDialog1.FileName)
        End If
        ContextMenuStrip1.Enabled = True
p:      打开ToolStripMenuItem.Checked = False
    End Function
    Function readjar(ByVal jarstr As String)
        On Error Resume Next
        ComboBox1.Text = ""
        picsize = ComboBox1.Text
        see()
        Me.Refresh()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P1", "0")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", "0")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "XX", Me.Left)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "YY", Me.Top + Me.Height)
        Shell(My.Application.Info.DirectoryPath + "\Progress.exe", AppWinStyle.NormalFocus)
        TextBox2.Text = ""
        oppp = jarstr
        Me.Text = "Jar Setting - " + oppp
        del()
        Dim d As String = Date.Now
        Dim ymd As String = d.Replace(":", ".").Replace("/", "-").Replace(" ", "-")
        tmppath = My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\" + ymd
        oldtmp = tmppath
        TextBox9.Text = tmppath
        MkDir(tmppath)
        ChDir(tmppath)
        opp()
        Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$Z12Z.tmp" + TextBox3.Text + " -o " + " " + TextBox3.Text + jarstr + TextBox3.Text, AppWinStyle.Hide, True)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "P1", "100")
        If PictureBox2.Image Is Nothing Then
            ComboBox1.Items.Add(" ")
            ComboBox1.Text = " "
            picsize = ComboBox1.Text
        Else
            PictureBox1.Image = PictureBox2.Image
            Dim kb As String = PictureBox2.Width
            Dim pb As String = PictureBox2.Height
            picsize = kb + "*" + pb
            addsize()
            ComboBox1.Text = kb + "*" + pb
        End If
        ComboBox1.Items.Remove(" ")
        listcls0()
        PictureBox2.Image = Nothing
        PictureBox1.Image = Nothing
        readtex()
    End Function
    Function readtex()
        On Error Resume Next
        Dim k = My.Computer.FileSystem.ReadAllText(tmppath + "\META-INF\MANIFEST.MF", System.Text.Encoding.UTF8)
        My.Computer.FileSystem.CopyFile(tmppath + "\META-INF\MANIFEST.MF", tmppath + "\META-INF\MANIFEST.MF.BAK", True)
        MF.TextBox2.Text = k
        TextBox4.Text = k
        read()
        suo(True)
    End Function
    Function del()
        If My.Computer.FileSystem.DirectoryExists(oldtmp) = True Then
            On Error Resume Next
            ChDir(My.Application.Info.DirectoryPath)
            Kill(oldtmp + "\*.*")
            RmDir(oldtmp)
            My.Computer.FileSystem.DeleteDirectory(oldtmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Z12Z.tmp")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$U12ZZ.tmp")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.Jar")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$$$.Java")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP")
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$RPIC.tmp")
            RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon")
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
            RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar")
            RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$")
        End If
    End Function
    Function suo(ByVal tf As Boolean)
        Button1.Enabled = tf
        Button2.Enabled = tf
        Button4.Enabled = tf
        Button3.Enabled = tf
        Button7.Enabled = tf
        Button8.Enabled = tf
        Button10.Enabled = tf
        TextBox2.Enabled = tf
        查看ToolStripMenuItem.Visible = tf
        高级ToolStripMenuItem.Visible = tf
        FLToolStripMenuItem.Visible = tf
        测试ToolStripMenuItem.Visible = tf
        保存ToolStripMenuItem.Visible = tf
        另存为ToolStripMenuItem.Visible = tf
    End Function
    Private Sub Jar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        del()
    End Sub
    Private Sub Jar_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Cancel = 1
        eventArgs.Cancel = Cancel
        If mini5 = "1" Then
            主窗口ToolStripMenuItem.Checked = False
            Mini.TopMost = True
            Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Yin", Nothing)
            If r1 = "1" Then
                If My.Application.CommandLineArgs.Count = 0 Then
                    Me.Hide()
                Else
                    If My.Application.CommandLineArgs.Item(0).ToLower <> "/mini" Then
                        Me.Hide()
                    Else
                        退出ToolStripMenuItem_Click()
                    End If
                End If
            Else
                    退出ToolStripMenuItem_Click()
            End If
        Else
            退出ToolStripMenuItem_Click()
        End If
    End Sub
    Private Sub Jar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        主窗口ToolStripMenuItem.Checked = True
        xx = Me.Top
        yy = Me.Left
        NotifyIcon1.Icon = Me.Icon
        suo(False)
        add()
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Run", Nothing)
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pic", Nothing)
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", Nothing)
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Opacity", Nothing)
        Dim r6 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Mini", Nothing)
        Dim r7 As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Jad", Nothing)
        If r2 <> Nothing Then
            picpath = r2
        Else
            picpath = "mspaint.exe"
        End If
        If r1 <> Nothing Then
            runpath = r1
        Else
            runpath = My.Application.Info.DirectoryPath + "\JAR_RUN.exe"
        End If
        TextBox5.Text = picpath
        If r3 = "True" Then
            seeor = True
        Else
            seeor = False
        End If
        If r5 <> Nothing Then
            Me.Opacity = r5 * 0.01
        End If
        If r6 <> Nothing Then
            mini5 = 0
            Mini.Visible = False
        Else
            mini5 = 1
            Mini.Visible = True
        End If
        If r7 <> Nothing Then
            jadpath = r7
        Else
            jadpath = ""
        End If
        If Command() <> "" Then
            If My.Application.CommandLineArgs.Count = 1 And My.Application.CommandLineArgs.Item(0).ToLower = "/mini" Then
                End
            End If
            OpenFileDialog1.FileName = Command().Replace(TextBox3.Text, "")
            openzip(True)
            XB(True)
        End If
        Me.Refresh()
    End Sub
    Function add()
        With ComboBox1
            .Items.Add("自定义")
            .Items.Add("8*8")
            .Items.Add("16*16")
            .Items.Add("20*20")
            .Items.Add("22*22")
            .Items.Add("24*24")
            .Items.Add("32*32")
            .Items.Add("48*48")
            .Items.Add("64*64")
            .Items.Add("128*128")
        End With
    End Function
    Private Sub Button8_Click() Handles Button8.Click
        XB(False)
        高级ToolStripMenuItem.Checked = True
        主窗口ToolStripMenuItem.Checked = False
        Me.Hide()
        ttt = "3"
        JS.ShowDialog()
        ttt = ""
        Me.Show()
        主窗口ToolStripMenuItem.Checked = True
        高级ToolStripMenuItem.Checked = False
    End Sub
    Private Sub Button10_Click() Handles Button10.Click
        XB(False)
        FLToolStripMenuItem.Checked = True
        主窗口ToolStripMenuItem.Checked = False
        Me.Hide()
        ttt = "3"
        LookFile.ShowDialog()
        ttt = ""
        Me.Show()
        主窗口ToolStripMenuItem.Checked = True
        FLToolStripMenuItem.Checked = False
    End Sub
    Private Sub 打开ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 打开ToolStripMenuItem.Click
        If 打开ToolStripMenuItem.Checked = False Then
            cls()
            Me.Show()
            主窗口ToolStripMenuItem.Checked = True
            Button5_Click()
        End If
    End Sub
    Private Sub 设置ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 设置ToolStripMenuItem.Click
        On Error Resume Next
        If 设置ToolStripMenuItem.Checked = False Then
            cls()
            Me.Hide()
            ttt = "3"
            设置ToolStripMenuItem.Checked = True
            SetBox.ShowDialog()
            主窗口ToolStripMenuItem_Click()
            设置ToolStripMenuItem.Checked = False
            ttt = ""
        End If
    End Sub
    Public Sub 退出ToolStripMenuItem_Click() Handles 退出ToolStripMenuItem.Click
        If tmppath <> "" And XG = False Then
            Dim kkb = MsgBox("确定保存退出？", MsgBoxStyle.YesNoCancel, "温馨提示！！！")
            If kkb = MsgBoxResult.Yes Then
                Button1_Click()
                del()
                NotifyIcon1.Icon = Nothing
                End
            Else
                If kkb = MsgBoxResult.No Then
                    del()
                    NotifyIcon1.Icon = Nothing
                    End
                End If
            End If
        Else
            del()
            NotifyIcon1.Icon = Nothing
            End
        End If
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If ttt <> "3" Then
            cls()
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Show()
                主窗口ToolStripMenuItem.Checked = True
                Me.WindowState = FormWindowState.Normal
            Else
                Me.WindowState = FormWindowState.Minimized
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub PictureBox1_Click() Handles PictureBox1.Click
        On Error Resume Next
        If JS.MIcon.Text <> "" Then
            Dim oq = JS.MIcon.Text.Replace("/", "\")
            If Mid(JS.MIcon.Text, 1, 1) <> "/" Then
                Hide()
                Shell(TextBox3.Text + picpath + TextBox3.Text + " " + TextBox3.Text + tmppath + "\" + oq + TextBox3.Text, 1, True)
                Me.Show()
                主窗口ToolStripMenuItem.Checked = True
            Else
                Hide()
                Shell(TextBox3.Text + picpath + TextBox3.Text + " " + TextBox3.Text + tmppath + oq + TextBox3.Text, 1, True)
                Me.Show()
                主窗口ToolStripMenuItem.Checked = True
            End If
            readpic()
        End If
    End Sub
    Function cls()
        AboutMe.Close()
        DirCho.Close()
        JS.Close()
        LookFile.Close()
        QD.Close()
        SetBox.Close()
        MF.Close()
        CMM.Close()
        PNGC.Close()
        PAQ2.Close()
        TG.Close()
        TBC.Close()
        TBC.Hide()
        TG.Hide()
        PAQ2.Hide()
        PNGC.Hide()
        CMM.Hide()
        AboutMe.Hide()
        DirCho.Hide()
        JS.Hide()
        LookFile.Hide()
        QD.Hide()
        SetBox.Hide()
        MF.Hide()
        查看ToolStripMenuItem.Checked = False
        高级ToolStripMenuItem.Checked = False
        FLToolStripMenuItem.Checked = False
        设置ToolStripMenuItem.Checked = False
        主窗口ToolStripMenuItem.Checked = False
    End Function
    Private Sub 查看ToolStripMenuItem_Click() Handles 查看ToolStripMenuItem.Click
        On Error Resume Next
        If 查看ToolStripMenuItem.Checked = False And 打开ToolStripMenuItem.Checked = False And tmppath <> "" Then
            cls()
            Me.Hide()
            ttt = "3"
            查看ToolStripMenuItem.Checked = True
            MF.ShowDialog()
            主窗口ToolStripMenuItem_Click()
            查看ToolStripMenuItem.Checked = False
            ttt = ""
        End If
    End Sub
    Private Sub 高级ToolStripMenuItem_Click() Handles 高级ToolStripMenuItem.Click
        On Error Resume Next
        If 高级ToolStripMenuItem.Checked = False And 打开ToolStripMenuItem.Checked = False And tmppath <> "" Then
            cls()
            Me.Hide()
            ttt = "3"
            高级ToolStripMenuItem.Checked = True
            JS.ShowDialog()
            主窗口ToolStripMenuItem_Click()
            高级ToolStripMenuItem.Checked = False
            ttt = ""
        End If
    End Sub
    Private Sub FLToolStripMenuItem_Click() Handles FLToolStripMenuItem.Click
        On Error Resume Next
        If FLToolStripMenuItem.Checked = False And 打开ToolStripMenuItem.Checked = False And tmppath <> "" Then
            cls()
            Me.Hide()
            ttt = "3"
            FLToolStripMenuItem.Checked = True
            LookFile.ShowDialog()
            主窗口ToolStripMenuItem_Click()
            FLToolStripMenuItem.Checked = False
            ttt = ""
        End If
    End Sub
    Private Sub TextBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.DoubleClick
        TG.set1(TextBox2, "名称:")
        TG.ShowDialog()
    End Sub
    Private Sub 测试ToolStripMenuItem_Click() Handles 测试ToolStripMenuItem.Click
        If tmppath <> "" Then
            cs()
        End If
    End Sub
    Function cs()
        ContextMenuStrip1.Enabled = False
        Dim t = MsgBox("需要保存修改,是否继续?", MsgBoxStyle.YesNo, "温馨提示！！！")
        If t = MsgBoxResult.Yes Then
            On Error Resume Next
            read()
            savetx()
            savefile()
            opp()
            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$.Jar")
            ChDir(My.Application.Info.DirectoryPath)
            ChDir(tmppath)
            Shell(TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$U12ZZ.tmp" + TextBox3.Text + " -r -9 " + TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.Jar" + TextBox3.Text + " " + "*.*", AppWinStyle.Hide, True)
            Shell(runpath + " " + TextBox3.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$.Jar" + TextBox3.Text)
        End If
        ContextMenuStrip1.Enabled = True
    End Function
    Private Sub 主窗口ToolStripMenuItem_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles 主窗口ToolStripMenuItem.CheckStateChanged
        If mini5 = 1 Then
            If 主窗口ToolStripMenuItem.Checked = True Then
                Mini.TopMost = True
            Else
                Mini.TopMost = False
            End If
        End If
    End Sub
    Public Sub 主窗口ToolStripMenuItem_Click() Handles 主窗口ToolStripMenuItem.Click
        cls()
        Me.Show()
        主窗口ToolStripMenuItem.Checked = True
        Mini.TopMost = True
    End Sub
    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        If tmppath <> "" Then
            cls()
            Me.Show()
            主窗口ToolStripMenuItem.Checked = True
            Button1_Click()
        End If
    End Sub
    Private Sub 另存为ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 另存为ToolStripMenuItem.Click
        If tmppath <> "" Then
            cls()
            Me.Show()
            主窗口ToolStripMenuItem.Checked = True
            Button2_Click()
        End If
    End Sub
    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        On Error Resume Next
        If 关于ToolStripMenuItem.Checked = False And 关于ToolStripMenuItem.Checked = False Then
            cls()
            Me.Hide()
            ttt = "3"
            关于ToolStripMenuItem.Checked = True
            AboutMe.ShowDialog()
            主窗口ToolStripMenuItem_Click()
            关于ToolStripMenuItem.Checked = False
            ttt = ""
        End If
    End Sub
    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        ke = 1
        If ComboBox1.Text = "自定义" Then
            ComboBox1.Text = ""
            TBC.ShowDialog()
            addsize()
            ComboBox1.Text = picsize
        End If
        XB(False)
        ke = 0
    End Sub
    Function addsize()
        Dim yyte As Integer = -1
        For u = 0 To ComboBox1.Items.Count - 1
            If ComboBox1.Items(u) = picsize Then
                yyte = u
            End If
        Next
        If yyte = -1 Then
            ComboBox1.Items.Add(picsize)
        End If
    End Function
    Private Sub 新建ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新建ToolStripMenuItem.Click
        Dim kkb = MsgBox("确定新建程序吗?", MsgBoxStyle.YesNo, "温馨提示！！！")
        If kkb = MsgBoxResult.Yes Then
            XB(False)
            ContextMenuStrip1.Enabled = False
            With SaveFileDialog1
                .FileName = ""
                .Filter = "*.Jar|*.Jar"
                .ShowDialog()
                If .FileName <> "" Then
                    del()
                    cls()
                    oppp = .FileName
                    Me.Text = "Jar Setting - " + oppp
                    del()
                    Dim d As String = Date.Now
                    Dim ymd As String = d.Replace(":", ".").Replace("/", "-").Replace(" ", "-")
                    tmppath = My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\" + ymd
                    oldtmp = tmppath
                    TextBox9.Text = tmppath
                    MkDir(tmppath)
                    FLToolStripMenuItem_Click()
                    readtex()
                    查看ToolStripMenuItem_Click()
                    高级ToolStripMenuItem_Click()
                    主窗口ToolStripMenuItem_Click()
                End If
            End With
        End If
        ContextMenuStrip1.Enabled = True
    End Sub
    Private Sub 编辑ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 编辑ToolStripMenuItem.Click
        XB(False)
        PictureBox1_Click()
    End Sub
    Private Sub 更换ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 更换ToolStripMenuItem.Click
        XB(False)
        Button4_Click()
    End Sub
    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        If tmppath <> "" Then
            更换ToolStripMenuItem.Visible = True
            ToolStripSeparator1.Visible = False
        Else
            更换ToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
        If My.Computer.FileSystem.FileExists(pp + ".BAK") = True Then
            还原备份ToolStripMenuItem.Visible = True
            ToolStripSeparator2.Visible = True
        Else
            还原备份ToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
        End If
        If PictureBox1.Image Is Nothing Then
            编辑ToolStripMenuItem.Visible = False
            自义定ToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        Else
            编辑ToolStripMenuItem.Visible = True
            自义定ToolStripMenuItem.Visible = True
            ToolStripSeparator1.Visible = True
        End If
    End Sub
    Private Sub 还原备份ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 还原备份ToolStripMenuItem.Click
        XB(False)
        On Error Resume Next
        My.Computer.FileSystem.MoveFile(pp + ".BAK", pp, True)
        readpic()
    End Sub
    Function Retoqqq()
        Return oppp
    End Function
    Function XB(ByVal TF As Boolean)
        XG = TF
    End Function
    Function rpic(ByVal ko As String)
        If ko <> "" Then
            picsize = ko.Trim
        Else
            Return picsize
        End If
    End Function
    Function YH(ByVal icon As String)
        On Error GoTo b
b:      Dim g As New Random
        Dim gg As String = Str(g.Next(1000, 99999).ToString.Trim)
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon") = False Then
            On Error Resume Next
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon")
        End If
        trr(icon, gg)
       On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Function trr(ByVal icon As String, ByVal gg As String)
        Try
            My.Computer.FileSystem.CopyFile(icon.Replace("\\", "\"), icon.Replace("\\", "\") + ".Bak", True)
            My.Computer.FileSystem.MoveFile(icon, My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon\" + gg.Trim + ".tmp", True)
            Dim ii As Image
            ii = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.Temp + "\$Jar\$Icon\" + gg.Trim + ".tmp")
            ii.Save(icon, System.Drawing.Imaging.ImageFormat.Png)
        Catch
        End Try
    End Function
    Private Sub 自义定ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 自义定ToolStripMenuItem.Click
        ke = 1
        ComboBox1.Text = ""
        TBC.ShowDialog()
        addsize()
        ComboBox1.Text = picsize
        XB(False)
        ke = 0
    End Sub
End Class
'Function Per(ByVal str As String)
'    On Error Resume Next
'    Dim ii As String
'    ii = "0"
'    ListBox4.Items.Clear()
'    ListBox1.Items.Clear()
'    Dim rr As Integer
'    rr = 0
'    Do
'        ListBox2.SetSelected(rr, True)
'        If ListBox2.Text.Length > (Len(str)) Then
'            If ListBox2.Text.Remove(Len(str)) = str Then
'                ListBox4.Items.Add(ListBox2.Text.Replace(str, "").Trim)
'                ListBox1.Items.Add(ListBox2.Text)
'                ii = "1"
'            End If
'        End If
'        rr = rr + 1
'    Loop Until ii = "1" Or rr > ListBox2.Items.Count - 1
'    Do
'        If rr <= ListBox2.Items.Count - 1 Then
'            ListBox2.SetSelected(rr, True)
'            If Mid(ListBox2.Text, 1, 1) = " " Then
'                If ii = "1" Then
'                    ListBox4.Items.Add(ListBox2.Text.Trim)
'                    ListBox1.Items.Add(ListBox2.Text)
'                End If
'            Else
'                ii = "0"
'            End If
'        End If
'        rr = rr + 1
'    Loop Until Mid(ListBox2.Text, 1, 1) <> " " And ii = "0" Or rr > ListBox2.Items.Count - 1
'    Dim kki = ""
'    If ListBox4.Items.Count <> 0 Then
'        For y = 0 To ListBox4.Items.Count - 1
'            ListBox4.SetSelected(y, True)
'            kki = kki + ListBox4.Text
'        Next
'    End If
'    For d = 0 To ListBox1.Items.Count - 1
'        ListBox1.SetSelected(d, True)
'        ListBox2.Items.Remove(ListBox1.Text)
'    Next
'    Return (kki)
'End Function