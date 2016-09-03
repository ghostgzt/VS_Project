Public Class Ku
    Dim gnn As New GN
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub
    Private Sub Ku_Load() Handles MyBase.Load
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
            Me.Height = Me.Height - GroupBox1.Height
            Me.Top = Me.Top + GroupBox1.Height / 2
        End If
        Label12.Font = Label13.Font
        Label12.ForeColor = Label13.ForeColor
        PictureBox3.BackColor = Color.Purple
        GroupBox1.Enabled = False
        On Error Resume Next
        MkDir(My.Application.Info.DirectoryPath + "\Ku\")
        cls()
        ComboBox1.Items.Clear()
        Dim jal = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath + "\Ku", FileIO.SearchOption.SearchTopLevelOnly, "*.Xml")
        If jal.Count <> 0 Then
            For x = 0 To jal.Count - 1
                ComboBox1.Items.Add(jal(x).Replace(My.Application.Info.DirectoryPath + "\Ku\", ""))
            Next
        End If
    End Sub
    Function cls()
        On Error Resume Next
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = "0"
        TextBox8.Text = "0"
        TextBox9.Text = ""
        TextBox10.Text = ""
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        GroupBox1.Text = ""
        ProgressBar1.Value = 100
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cls()
        GroupBox1.Text = ComboBox1.Text
        road(gnn.getname(My.Application.Info.DirectoryPath + "\Ku\" + ComboBox1.Text, ".", True, 0) + ".Xml")
        If ComboBox1.Text <> "" Then
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
            GroupBox1.Enabled = True
            If GroupBox1.Visible = False Then
                GroupBox1.Visible = True
                Me.Height = Me.Height + GroupBox1.Height
                If Me.Top - GroupBox1.Height / 2 > 0 Then
                    Me.Top = Me.Top - GroupBox1.Height / 2
                End If
            End If
        Else
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            GroupBox1.Enabled = False
            If GroupBox1.Visible = True Then
                GroupBox1.Visible = False
                Me.Height = Me.Height - GroupBox1.Height
                Me.Top = Me.Top + GroupBox1.Height / 2
            End If
        End If
    End Sub
    Dim tsss As Color = Color.Purple
    Function road(ByVal d As String)
        On Error Resume Next
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "M-Game " + gnn.getname(ComboBox1.Text, ".", True, 0), Nothing)
        Dim Aero = XDocument.Load(d)
        Dim knn As String = Aero.<Aero>.<Tile>.Value
        Dim kpp As String = Aero.<Aero>.<Pic>.Value
        Dim kss As String = Aero.<Aero>.<Height>.Value
        Dim kdd As String = Aero.<Aero>.<BJ>.Value
        Dim koo As String = Aero.<Aero>.<Op>.Value
        Dim kxx As String = Aero.<Aero>.<X>.Value
        Dim kyy As String = Aero.<Aero>.<Y>.Value
        Dim ktt As String = Aero.<Aero>.<TB>.Value
        Dim kzz As String = Aero.<Aero>.<ZT>.Value
        Dim kmm As String = Aero.<Aero>.<MZ>.Value
        Dim kzj As String = Aero.<Aero>.<ZJ>.Value
        Dim ktm As String = Aero.<Aero>.<TM>.Value
        Dim kgd As String = Aero.<Aero>.<GD>.Value
        Dim kfn As String = Aero.<Aero>.<FN>.Value
        Dim kfs As String = Aero.<Aero>.<FS>.Value
        Dim kfb As String = Aero.<Aero>.<FB>.Value
        Dim kfi As String = Aero.<Aero>.<FI>.Value
        Dim kfo As String = Aero.<Aero>.<FO>.Value
        Dim kfu As String = Aero.<Aero>.<FU>.Value
        Dim kfc As String = Aero.<Aero>.<FC>.Value
        Dim kts As String = Aero.<Aero>.<TS>.Value
        If kts <> "" Then
            PictureBox3.BackColor = Color.FromArgb(kts)
            tsss = Color.FromArgb(kts)
        End If
        If kfc <> "" Then
            Label12.ForeColor = Color.FromName(kfc)
        End If
        If kfn <> "" And kfs <> "" Then
            Label12.Font = (ccolor(kfn, CInt(kfs), FontStyle.Regular))
        End If
        Dim bbb = Nothing
        Dim iii = Nothing
        Dim sss = Nothing
        Dim uuu = Nothing
        If CBool(kfb) = True Then
            bbb = FontStyle.Bold
        End If
        If CBool(kfi) = True Then
            iii = FontStyle.Italic
        End If
        If CBool(kfo) = True Then
            sss = FontStyle.Strikeout
        End If
        If CBool(kfu) = True Then
            uuu = FontStyle.Underline
        End If
        Label12.Font = (ccolor(kfn, CInt(kfs), bbb + iii + sss + uuu))
        TextBox1.Text = knn.Replace("*\*/*", "&").Replace("###!#", "<").Replace("#!##", ">")
        TextBox2.Text = kpp
        TextBox3.Text = kss
        TextBox4.Text = koo
        TextBox5.Text = kdd
        If kxx <> "" Then
            TextBox7.Text = kxx
        Else
            TextBox7.Text = 0
        End If
        If kyy <> "" Then
            TextBox8.Text = kyy
        Else
            TextBox8.Text = 0
        End If
        If ktt <> "" Then
            ComboBox2.Text = ktt
        Else
            ComboBox2.Text = "48*48"
        End If
        TextBox9.Text = kzz
        If kzj = "1" Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        If kmm <> "" Then
            TextBox10.Text = kmm
        End If
        If r1 <> "" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
        If ktm = "1" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
        If kgd = "1" Then
            CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
        End If
    End Function
    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        On Error Resume Next
        PictureBox2.ImageLocation = TextBox5.Text
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
        Else
            ProgressBar1.Value = 100
        End If
        TextBox4.Text = ProgressBar1.Value / 100
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ProgressBar1.Value > 10 Then
            ProgressBar1.Value = ProgressBar1.Value - 5
        Else
            ProgressBar1.Value = 100
        End If
        TextBox4.Text = ProgressBar1.Value / 100
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo k
        Dim i As String = InputBox("请输入新库的名称:", "新建库", "", -1, -1)
        If i.Trim <> "" Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Ku\" + i + ".Xml") = False Then
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Ku\" + i + ".Xml", Nothing, False)
                cls()
                ComboBox1.Items.Add(i + ".Xml")
                ComboBox1.Text = i + ".Xml"
            Else
                MsgBox("库已存在！", MsgBoxStyle.Exclamation, "错误！")
            End If
        Else
            MsgBox("库名不能空！", MsgBoxStyle.Exclamation, "敬告")
        End If
        Exit Sub
k:      MsgBox("Failed！")
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        On Error Resume Next
        Dim zj As String
        If CheckBox1.Checked = True Then
            zj = "1"
        Else
            zj = "0"
        End If
        Dim tm As String
        If CheckBox3.Checked = True Then
            tm = "1"
        Else
            tm = "0"
        End If
        Dim gd As String
        If CheckBox4.Checked = True Then
            gd = "1"
        Else
            gd = "0"
        End If
        MkDir(My.Application.Info.DirectoryPath + "\Ku")
        Dim kop = TextBox6.Text
        kop = Replace(kop, "/Name", TextBox1.Text)
        kop = Replace(kop, "/PPP", TextBox2.Text)
        kop = Replace(kop, "/HHH", TextBox3.Text)
        kop = Replace(kop, "/JJJ", TextBox5.Text)
        kop = Replace(kop, "/OOO", Me.Opacity)
        kop = Replace(kop, "/XXX", TextBox7.Text)
        kop = Replace(kop, "/YYY", TextBox8.Text)
        kop = Replace(kop, "/MMM", TextBox10.Text)
        kop = Replace(kop, "/ZJZ", zj)
        kop = Replace(kop, "/TTT", ComboBox2.Text)
        kop = Replace(kop, "/ZZZ", TextBox9.Text)
        kop = Replace(kop, "/TMT", tm)
        kop = Replace(kop, "/GDG", gd)
        kop = Replace(kop, "/FNF", Label12.Font.Name)
        kop = Replace(kop, "/FSF", Label12.Font.Size)
        kop = Replace(kop, "/FBF", Label12.Font.Bold)
        kop = Replace(kop, "/FIF", Label12.Font.Italic)
        kop = Replace(kop, "/FOF", Label12.Font.Strikeout)
        kop = Replace(kop, "/FUF", Label12.Font.Underline)
        kop = Replace(kop, "/FCF", Label12.ForeColor.Name)
        kop = Replace(kop, "/TST", PictureBox3.BackColor.ToArgb)
        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Ku" + "\" + ComboBox1.Text, kop, False)
        If CheckBox2.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "M-Game " + gnn.getname(ComboBox1.Text, ".", True, 0), My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + gnn.getname(ComboBox1.Text, ".", True, 0))
        Else
            Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            ke.DeleteValue("M-Game " + gnn.getname(ComboBox1.Text, ".", True, 0))
        End If
        MsgBox("修改成功！", MsgBoxStyle.Information, "T*T")
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox7.Text = 0
        TextBox8.Text = 0
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Ku_Load()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "库主题文件*.Jaz|*.Jaz"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox9.Text = .FileName
            End If
        End With
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error Resume Next
        If MsgBox("你确定删除此库?", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Ku\" + gnn.getname(ComboBox1.Text, ".", True, 0) + ".Jal")
            Kill(My.Application.Info.DirectoryPath + "\Ku\" + ComboBox1.Text)
            ComboBox1.Items.Remove(ComboBox1.Text)
            cls()
        End If
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Ku_Load()
        MsgBox("删除成功T*T", MsgBoxStyle.Information, "T*T")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.Text.Trim <> "" Then
            On Error Resume Next
            Button2_Click()
            Shell(My.Application.Info.DirectoryPath + "\M-Game.exe" + " " + gnn.getname(ComboBox1.Text, ".", True, 0), AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        On Error GoTo y
        If TextBox4.Text = "0" Then
            GoTo y
        End If
        ProgressBar1.Value = TextBox4.Text * 100
        Me.Opacity = ProgressBar1.Value / 100
        Exit Sub
y:      TextBox4.Text = "1"
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        On Error Resume Next
        PictureBox1.ImageLocation = TextBox2.Text
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        KZTZZ.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error Resume Next
        FontDialog1.Font = Label12.Font
        FontDialog1.Color = Label12.ForeColor
        With FontDialog1
            .ShowColor = True
            .ShowDialog(Me)
        End With
        If FontDialog1.Font Is Label12.Font Then
        Else
            Label12.Font = (FontDialog1.Font)
            Label12.ForeColor = FontDialog1.Color
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Label12.Text = TextBox1.Text
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ColorDialog1.Color = PictureBox3.BackColor
        With ColorDialog1
            .ShowDialog(Me)
        End With
        If ColorDialog1.Color = PictureBox3.BackColor Then
        Else
            Dim tty = Color.FromArgb(ColorDialog1.Color.A, ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            PictureBox3.BackColor = tty
        End If
    End Sub
    Function ccolor(ByVal name As String, ByVal size As Integer, ByVal style As FontStyle)
        Dim ii As New Font(name, size, style)
        Return ii
    End Function
    Private Sub PictureBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.DoubleClick
        PictureBox3.BackColor = tsss
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Label12.Font = Label13.Font
        Label12.ForeColor = Label13.ForeColor
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        road(gnn.getname(My.Application.Info.DirectoryPath + "\Ku\" + ComboBox1.Text, ".", True, 0) + ".Xml")
    End Sub
    Private Sub 恢复ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 恢复ToolStripMenuItem.Click
        PictureBox3.BackColor = tsss
    End Sub
    Private Sub 默认ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 默认ToolStripMenuItem.Click
        PictureBox3.BackColor = Color.Purple
    End Sub
End Class