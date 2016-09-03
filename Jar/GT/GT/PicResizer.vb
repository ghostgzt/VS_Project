Imports System.IO
Public Class PicResizer
    Dim kkk = 0
    Dim k As Integer
    Dim tmppath As String
    Dim tmppath2 As String
    Private Sub Button1_Click() Handles Button1.Click
        If ListBox1.Items.Count <> 0 Then
            If CheckBox1.Checked = True Then
                If nuHeight.Text = "" Or nuWidth.Text = "" Or nuHeight.Text = "0" Or nuWidth.Text = "0" Then
                    MsgBox("长和宽不能空或为0！！！", MsgBoxStyle.Exclamation, "温馨提示！！！")
                Else
                    Dim r
                    r = MsgBox("是否确定修改图片", MsgBoxStyle.YesNo)
                    If r = MsgBoxResult.Yes Then
                        save(True)
                        MsgBox("操作成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
                    End If
                End If
            Else
                Dim r
                r = MsgBox("是否确定修改图片", MsgBoxStyle.YesNo)
                If r = MsgBoxResult.Yes Then
                    save(True)
                    MsgBox("操作成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
                End If
            End If
            End If
            kkk = 0
    End Sub
    Function save(ByVal yy As Boolean)
     kkk = 1
        Dim hhv = Me.nuHeight.Text
        Dim wwv = Me.nuWidth.Text
        Dim ttb = ComboBox1.Text
        ListBox1.Enabled = False
        ProgressBar1.Value = 0
        Dim yuy = ListBox1.Items.Count / 100
        For h = 0 To ListBox1.Items.Count - 1
            tmppath = ListBox1.Items(h).ToString
            Dim rr = True
            If CheckBox1.Checked = False Then
                PictureBox1.ImageLocation = tmppath
                If PictureBox1.Image Is Nothing Then
                    Me.nuHeight.Text = ""
                    Me.nuWidth.Text = ""
                    rr = False
                Else
                    Me.nuHeight.Text = PictureBox1.Image.Height
                    Me.nuWidth.Text = PictureBox1.Image.Width
                End If
            End If
            If rr = False Or nuHeight.Text = "" Or nuWidth.Text = "" Or nuHeight.Text = "0" Or nuWidth.Text = "0" Then
            Else
                del()
                iido()
                If CheckBox1.Checked = True Then
                    yy = False
                    nuHeight.Text = hhv
                    nuWidth.Text = wwv
                End If
                If CheckBox5.Checked = True Then
                    CheckBox1.Checked = False
                    chkAR.Checked = True
                    If CInt(nuWidth.Text) > CInt(TextBox1.Text) And TextBox1.Text <> "" And TextBox1.Text <> "0" And CheckBox7.Checked = True Then
                        nuWidth.Text = (TextBox1.Text)
                        nuWidth_TextChanged()
                    Else
                        If CInt(nuWidth.Text) > CInt(TextBox1.Text) And TextBox1.Text <> "" And TextBox1.Text <> "0" And CInt(nuHeight.Text) > CInt(TextBox1.Text) Then
                            nuWidth.Text = (TextBox1.Text)
                            nuWidth_TextChanged()
                        End If
                    End If
                    If CInt(nuHeight.Text) > CInt(TextBox2.Text) And TextBox2.Text <> "" And TextBox2.Text <> "0" Then
                        nuWidth.Text = (TextBox2.Text)
                    End If
                End If
                If CheckBox2.Checked = True Then
                    ComboBox1.Text = ttb
                End If
                Dim imgPath4mlvimgs = tmppath2
                Dim newWidth As Integer = nuWidth.Text
                Dim newheight As Integer = nuHeight.Text
                Dim resizedImg As New Bitmap(Image.FromFile(imgPath4mlvimgs), newWidth, newheight)


                If CheckBox5.Checked = True Then
                    If CInt(nuWidth.Text) > CInt(TextBox1.Text) And TextBox1.Text <> "" And TextBox1.Text <> "0" And CheckBox6.Checked = True Then
                        resizedImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                    Else
                        If CInt(nuWidth.Text) > CInt(TextBox1.Text) And TextBox1.Text <> "" And TextBox1.Text <> "0" And CInt(nuHeight.Text) < CInt(TextBox1.Text) Then
                            resizedImg.RotateFlip(RotateFlipType.Rotate90FlipNone)
                        End If
                    End If

                End If
                If CheckBox5.Checked = True And CheckBox3.Checked = True Then
                    If My.Computer.FileSystem.FileExists(tmppath + ".png") = True Then
                        Kill(tmppath + ".png")
                        My.Computer.FileSystem.RenameFile(tmppath, foundd(tmppath, "\") + ".png")
                    End If
                Else
                    If CheckBox3.Checked = True Then
                        If My.Computer.FileSystem.FileExists(tmppath + ".BAK") = True Then
                            Kill(tmppath + ".BAK")
                        End If
                        My.Computer.FileSystem.RenameFile(tmppath, foundd(tmppath, "\") + ".BAK")
                    Else
                        Kill(tmppath)
                    End If
                End If
                On Error GoTo i
                If ComboBox1.Text = "" Then
                    ComboBox1.Text = "PNG"
                End If
                If CheckBox4.Checked = True Then
                    tmppath = getname(tmppath, "\", True) + "\" + getname(getname(tmppath, "\", False), ".", True) + "." + ComboBox1.Text
                End If

                If ComboBox1.Text = "BMP" Then
                    resizedImg.Save(tmppath, System.Drawing.Imaging.ImageFormat.Bmp)
                End If
                If ComboBox1.Text = "PNG" Then
                    resizedImg.Save(tmppath, System.Drawing.Imaging.ImageFormat.Png)
                End If
                If ComboBox1.Text = "GIF" Then
                    resizedImg.Save(tmppath, System.Drawing.Imaging.ImageFormat.Gif)
                End If
                If ComboBox1.Text = "JPG" Or ComboBox1.Text = "JPEG" Then
                    resizedImg.Save(tmppath, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
                resizedImg.Dispose()
                imgPath4mlvimgs = ""
                del()
                End If
                On Error Resume Next
                If ProgressBar1.Value <= 100 Then
                    ProgressBar1.Value = ProgressBar1.Value + yuy
                Else
                    ProgressBar1.Value = 100
                End If
                GoTo g
                Exit Function
i:              MsgBox(tmppath + "操作失败！！！", MsgBoxStyle.Exclamation, "错误")
                kkk = 0
                GoTo g
                Exit Function
g:
        Next
        If CheckBox4.Checked = True Then
            DeleteAllToolStripMenuItem_Click()
        End If
        reg(0)
        ListBox1.Enabled = True
        ProgressBar1.Value = 100
        kkk = 0
        reg(0)
    End Function
    Function foundd(ByVal str As String, ByVal fgf As String)
        On Error Resume Next
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
    Function OHeight(ByVal height As Integer, ByVal width As Integer, ByVal outputwidth As Integer) As Integer
        If chkAR.Checked = True Then
            Dim sizefactor As System.Decimal
            Dim outputheight As Integer
            sizefactor = outputwidth / width
            outputheight = height * sizefactor
            Return outputheight
        End If
    End Function
    Private Sub nuWidth_TextChanged() Handles nuWidth.TextChanged
        If k <> 1 Then
            If PictureBox1.Image Is Nothing Then
            Else
                On Error GoTo h
                If chkAR.Checked = True Then
                    Me.nuHeight.Text = OHeight(PictureBox1.Image.Height, PictureBox1.Image.Width, Me.nuWidth.Text)
                End If
                End If
       End If
        Exit Sub
h:      Me.nuHeight.Text = "0"
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reg(0)
        End
    End Sub
    Function hrnd()
        On Error Resume Next
        Dim t As String
        Dim yy As String
        yy = Date.Now.ToString
        t = yy.Replace("\", " ").Replace("/", " ").Replace(":", ".")
        del()
        My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$PicSizer")
        tmppath2 = My.Computer.FileSystem.SpecialDirectories.Temp + "\$PicSizer" + "\" + t + ".tmp"
    End Function
    Function del()
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\$PicSizer", FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Function
    Private Sub frm_Resize_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        del()
        reg(0)
    End Sub
    Function reg(ByVal int As Integer)
        If int = 0 Then
            On Error Resume Next
            My.Computer.Registry.CurrentUser.CreateSubKey("software\PicSizer")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PicSizer", "DX", (CheckBox1.Checked))
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PicSizer", "GS", (CheckBox2.Checked))
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PicSizer", "BF", (CheckBox3.Checked))
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PicSizer", "HZ", (CheckBox4.Checked))
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\PicSizer", "HW", (chkAR.Checked))
        Else
            Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PicSizer", "DX", Nothing)
            Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PicSizer", "GS", Nothing)
            Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PicSizer", "BF", Nothing)
            Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PicSizer", "HZ", Nothing)
            Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\PicSizer", "HW", Nothing)
            If r1 = "False" Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
            End If
            If r2 = "True" Then
                CheckBox2.Checked = True
            Else
                CheckBox2.Checked = False
            End If
            If r3 = "False" Then
                CheckBox3.Checked = False
            Else
                CheckBox3.Checked = True
            End If
            If r4 = "True" Then
                CheckBox4.Checked = True
            Else
                CheckBox4.Checked = False
            End If
            If r5 = "False" Then
                chkAR.Checked = False
            Else
                chkAR.Checked = True
            End If
        End If
    End Function
    Function ad(ByVal ly As String, ByVal n As Integer)
        On Error Resume Next
        Dim b = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs.Item(n).Trim, FileIO.SearchOption.SearchTopLevelOnly, ly)
        For d = 0 To b.Count - 1
            ListBox1.Items.Remove(b(d))
            ListBox1.Items.Add(b(d))
        Next
    End Function
    Function af()
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(0).Trim) = True Then
            ad("*.jpg", 0)
            ad("*.png", 0)
            ad("*.gif", 0)
            ad("*.bmp", 0)
        Else
            Dim t0 = My.Application.CommandLineArgs
            For y = 0 To t0.Count - 1
                ListBox1.Items.Remove(t0(y))
                ListBox1.Items.Add(t0(y))
            Next
        End If
    End Function
    Private Sub ME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        k = 0
        nuWidth.Text = 0
        nuHeight.Text = 0
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs.Item(0).Trim <> "KZ" Then
                If My.Application.CommandLineArgs.Count >= 2 Then
                    If My.Application.CommandLineArgs.Item(0).Trim = "/Hide" And My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(1).Trim) = True Then
                        Me.Visible = False
                        ad("*.jpg", 1)
                        ad("*.png", 1)
                        ad("*.gif", 1)
                        ad("*.bmp", 1)
                        CheckBox1.Checked = False
                        CheckBox2.Checked = True
                        CheckBox3.Checked = True
                        CheckBox4.Checked = True
                        CheckBox7.Checked = True
                        TextBox1.Text = "230"
                        TextBox2.Text = "0"
                        ComboBox1.Text = "PNG"
                        save(True)
                        End
                    Else
                        If My.Application.CommandLineArgs.Item(0).Trim = "/Hide" And My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(1).Trim) = False Then
                            End
                        End If
                        af()
                    End If
                Else
                    af()
                End If
            Else
                Me.Visible = False
                tmppath = My.Application.CommandLineArgs.Item(1).Trim
                Dim b = My.Application.CommandLineArgs.Item(My.Application.CommandLineArgs.Count - 1).Trim
                Dim emailparts() As String
                Dim user As String
                Dim provider As String
                emailparts = b.Split("*".ToCharArray, 2)
                If emailparts.Length = 2 Then
                    user = emailparts(0)
                    provider = emailparts(1)
                Else
                    user = String.Empty
                    provider = String.Empty
                End If
                k = 1
                nuWidth.Text = (user)
                nuHeight.Text = (provider)
                ListBox1.Items.Add(tmppath)
                Dim w
                w = MsgBox("是否确定修改图片?", MsgBoxStyle.YesNo)
                If w = MsgBoxResult.Yes Then
                    save(False)
                    MsgBox("操作成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
                End If
                End
            End If
        Else
            FileToolStripMenuItem_Click()
        End If
        reg(1)
    End Sub
    Function iido()
        hrnd()
        If CheckBox2.Checked = False Then
            ComboBox1.Text = foundd(tmppath, ".")
            If ComboBox1.Text = "" Then
                ComboBox1.Text = "PNG"
            End If
        End If
        On Error GoTo b
        del()
        GoTo b
        Exit Function
b:
        On Error GoTo v
        My.Computer.FileSystem.CopyFile(tmppath, tmppath2)
        GoTo g
v:
        iido()
g:
    End Function
    Private Sub nuWidth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nuWidth.TextChanged
        If k <> 1 Then
            If PictureBox1.Image Is Nothing Then
            Else
                On Error GoTo h
                Dim ttf As String = CInt(nuHeight.Text)
                If chkAR.Checked = True Then
                    Me.nuHeight.Text = OHeight(PictureBox1.Image.Height, PictureBox1.Image.Width, Me.nuWidth.Text)
                End If
                End If
        End If
        Exit Sub
h:      nuWidth.Text = 0
    End Sub
    Function Image4mBytes(ByVal path As String) As Image
        Dim fs As New FileStream(path, FileMode.Open)
        Dim br As New BinaryReader(fs)
        Dim buffer(fs.Length) As Byte
        br.Read(buffer, 0, CInt(fs.Length))
        fs.Close()
        Dim ms As New MemoryStream(buffer)
        Return Image4mBytes.FromStream(ms)
    End Function
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAR.CheckedChanged
        If Me.chkAR.Checked Then
            Me.nuHeight.Enabled = False
            Me.nuHeight.ReadOnly = True
        Else
            Me.nuHeight.Enabled = True
            Me.nuHeight.ReadOnly = False
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FileToolStripMenuItem_Click()
    End Sub
    Private Sub FileToolStripMenuItem_Click() Handles FileToolStripMenuItem.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = ("*.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|*.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|*.*|*.*")
            .ShowDialog()
            If .FileName <> "" Then
                For x = 0 To .FileNames.Count - 1
                    ListBox1.Items.Remove(.FileNames(x))
                    ListBox1.Items.Add(.FileNames(x))
                Next
                MsgBox("添加了" + Str(.FileNames.Count) + "个文件")
                ProgressBar1.Value = 0
            End If
        End With
    End Sub
    Private Sub AllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
        AD(0)
    End Sub
    Function AD(ByVal int As Integer)
        On Error Resume Next
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim tt
                If ComboBox1.Text <> "" Then
                    tt = "*." + ComboBox1.Text
                Else
                    ComboBox1.Text = "PNG"
                    tt = "*.PNG"
                End If
                Dim t0 = Nothing
                If int = 0 Then
                    t0 = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, tt)
                Else
                    t0 = My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchTopLevelOnly, tt)
                End If
                For y = 0 To t0.Count - 1
                    ListBox1.Items.Remove(t0(y))
                    ListBox1.Items.Add(t0(y))
                Next
                MsgBox("添加了" + Str(t0.Count) + "个文件")
            End If
        End With
    End Function
    Private Sub DeleteToolStripMenuItem_Click() Handles DeleteToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        nuWidth.Text = 0
        nuHeight.Text = 0
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub DeleteAllToolStripMenuItem_Click() Handles DeleteAllToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        nuWidth.Text = 0
        nuHeight.Text = 0
        ListBox1.Items.Clear()
    End Sub
    Private Sub TopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopToolStripMenuItem.Click
        AD(1)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim m = MsgBox("目录下所有文件——YES" + vbCrLf + "目录跟下的文件——NO", MsgBoxStyle.YesNo, "添加目录")
        If m = MsgBoxResult.Yes Then
            AD(0)
        Else
            AD(1)
        End If
        ProgressBar1.Value = 0
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DeleteToolStripMenuItem_Click()
        ProgressBar1.Value = 0
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DeleteAllToolStripMenuItem_Click()
        ProgressBar1.Value = 0
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If kkk = 0 Then
            PictureBox1.Image = Nothing
            PictureBox1.ImageLocation = ListBox1.Text
            If CheckBox1.Checked = False Then
                nuWidth.Text = 0
                nuHeight.Text = 0
                If PictureBox1.Image Is Nothing Then
                    Me.nuHeight.Text = ""
                    Me.nuWidth.Text = ""
                Else
                    Me.nuHeight.Text = PictureBox1.Image.Height
                    Me.nuWidth.Text = (PictureBox1.Image.Width)
                End If
            End If
            If CheckBox2.Checked = False Then
                ComboBox1.Text = foundd(ListBox1.Text, ".")
                If ComboBox1.Text = "" Then
                    ComboBox1.Text = "PNG"
                End If
            End If
        End If
    End Sub
    Function getname(ByVal str As String, ByVal str1f As String, ByVal qh As Boolean)
        Dim q = ""
        If str <> "" Then
            For u = 0 To Len(str) - 1
                If Mid(str, u + 1, 1) = str1f Then
                    q = u
                End If
            Next
        End If
        If q <> "" Then
            If qh = False Then
                Return str.Remove(0, q + 1)
            Else
                Return str.Remove(q)
            End If
        Else
            Return ""
        End If
    End Function
    Private Sub nuHeight_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nuHeight.TextChanged
        On Error GoTo h
        Dim b As String = CInt(nuHeight.Text)
        Exit Sub
h:      nuHeight.Text = "0"
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox1.Checked = False
            chkAR.Checked = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        On Error GoTo h
        Dim ttf As String = CInt(TextBox1.Text)
        Exit Sub
h:      nuWidth.Text = 0
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        On Error GoTo h
        Dim ttf As String = CInt(TextBox2.Text)
        Exit Sub
h:      nuWidth.Text = 0
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox5.Checked = True
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox5.Checked = True
        End If
    End Sub
End Class