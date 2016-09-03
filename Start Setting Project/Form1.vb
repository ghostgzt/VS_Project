Option Strict Off
Option Explicit On
<System.Serializable()> Friend Class Form1
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles command1.Click
        If TextBox4.Text = "1" Or TextBox4.Text = "" Then
            Me.CommonDialog1Open.FileName = ""
            Me.CommonDialog1Open.Filter = ("Picture File(*.BMP;*.GIF;*.JPG)|*.BMP;*.GIF;*.JPG|All File(*.*)|*.*")
            Me.CommonDialog1Open.ShowDialog()
            If Me.CommonDialog1Open.FileName <> "" Then
                Me.Text1.Text = Me.CommonDialog1Open.FileName
            End If
        End If
        If TextBox4.Text = "2" Then
            Me.FolderBrowserDialog1.SelectedPath = ""
            Me.FolderBrowserDialog1.Description = "选择播放图片目录"
            Me.FolderBrowserDialog1.ShowDialog()
            If Me.FolderBrowserDialog1.SelectedPath <> "" Then
                Text1.Text = Me.FolderBrowserDialog1.SelectedPath
                File1.Path = Text1.Text
            End If
        End If
    End Sub
    Private Sub Command1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles command1.MouseMove
        Text1.Visible = True
        ProgressBar1.Visible = False
    End Sub
    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles command2.Click
        Me.Hide()
        VB6.ShowForm(Form2, VB6.FormShowConstants.Modal, Me)
    End Sub
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles command3.Click
        If TextBox1.Text = "Color.Transparent" Then
            TextBox2.Text = "1"
        End If
        If TextBox1.Text = "Color.White" Then
            TextBox2.Text = "2"
        End If
        If TextBox1.Text = "Color.Coral" Then
            TextBox2.Text = "3"
        End If
        If TextBox1.Text = "Color.Black" Then
            TextBox2.Text = "4"
        End If
        If TextBox1.Text = "Color.Red" Then
            TextBox2.Text = "5"
        End If
        If TextBox1.Text = "Color.Purple" Then
            TextBox2.Text = "6"
        End If
        If TextBox1.Text = "Color.Yellow" Then
            TextBox2.Text = "7"
        End If
        If TextBox1.Text = "Color.Gold" Then
            TextBox2.Text = "8"
        End If
        If TextBox1.Text = "Color.Green" Then
            TextBox2.Text = "9"
        End If
        If TextBox1.Text = "Color.Pink" Then
            TextBox2.Text = "10"
        End If
        ProgressBar1.Visible = True
        Dim i As Short
        For i = 1 To 100
            If ProgressBar1.Value < ProgressBar1.Maximum Then
                ProgressBar1.Value = ProgressBar1.Value + 1
            End If
        Next i
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Start")
        My.Computer.Registry.CurrentUser.CreateSubKey("software\My Setting")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Picture or Path", TextBox4.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "M or V", TextBox5.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Picture", Text1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Music", Text2.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Time Up", Text3.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Font", Text4.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "True/False1", Combo1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "True/False2", Combo2.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Times", Text5.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Setting", "Picture", Text6.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "Transparency Color", TextBox2.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "dxy", TextBox3.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "desk", ComboBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\My Start", "desk2", ComboBox2.Text)
        MsgBox("修改成功！！！", MsgBoxStyle.Information, "STAT修改器")
        If MsgBox("要不要马上打开My Start程序呢？？？", MsgBoxStyle.YesNo, "关前一问") = MsgBoxResult.Yes Then
            Dim B
            On Error GoTo W
            B = Shell(My.Application.Info.DirectoryPath + "\My Start.exe")
            End
        Else
            End
        End If
        Exit Sub
W:      MsgBox("请把Start Setting程序放在My Start程序的同一目录下", MsgBoxStyle.Information, "找不到My Start.exe文件")
        End
        Exit Sub
e:      MsgBox("修改失败？？？", MsgBoxStyle.Information, "STAT修改器")
    End Sub
    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sp As String
        Dim sm As String
        Dim sti As String
        Dim sf As String
        Dim str As String
        Dim stf As String
        Dim stis As String
        Dim spp As String
        Dim stc As String
        Dim wde As String
        Dim pop As String
        Dim desk As String
        Dim mov As String
        Dim desk2 As String
        On Error Resume Next
        Me.ComboBox1.Items.Add("640")
        Me.ComboBox1.Items.Add("800")
        Me.ComboBox1.Items.Add("1024")
        Me.ComboBox1.Items.Add("1028")
        Me.ComboBox1.Items.Add("1280")
        Me.ComboBox1.Items.Add("1600")
        Me.ComboBox2.Items.Add("480")
        Me.ComboBox2.Items.Add("768")
        Me.ComboBox2.Items.Add("800")
        Me.ComboBox2.Items.Add("960")
        Me.ComboBox2.Items.Add("1024")
        Me.ComboBox2.Items.Add("1200")
        sp = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Picture", Nothing)
        sm = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Music", Nothing)
        sti = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Time up", Nothing)
        sf = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Font", Nothing)
        str = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "True/False1", Nothing)
        stf = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "True/False2", Nothing)
        stis = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Times", Nothing)
        spp = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Setting", "Picture", Nothing)
        stc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Transparency Color", Nothing)
        wde = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "dxy", Nothing)
        pop = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "Picture or Path", Nothing)
        desk = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "desk", Nothing)
        mov = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "M or V", Nothing)
        desk2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\My Start", "desk2", Nothing)
        TextBox5.Text = mov
        Me.ComboBox2.Text = desk2
        Me.ComboBox1.Text = desk
        TextBox4.Text = pop
        TextBox3.Text = wde
        If stc = "1" Then
            TextBox1.Text = "Color.Transparent"
        End If
        If stc = "2" Then
            TextBox1.Text = "Color.White"
        End If
        If stc = "3" Then
            TextBox1.Text = "Color.Coral"
        End If
        If stc = "4" Then
            TextBox1.Text = "Color.Black"
        End If
        If stc = "5" Then
            TextBox1.Text = "Color.Red"
        End If
        If stc = "6" Then
            TextBox1.Text = "Color.Purple"
        End If
        If stc = "7" Then
            TextBox1.Text = "Color.Yellow"
        End If
        If stc = "8" Then
            TextBox1.Text = "Color.Gold"
        End If
        If stc = "9" Then
            TextBox1.Text = "Color.Green"
        End If
        If stc = "10" Then
            TextBox1.Text = "Color.Pink"
        End If
        Text1.Text = sp
        Text2.Text = sm
        Text3.Text = sti
        Text4.Text = sf
        Combo1.Text = str
        Combo2.Text = stf
        Text5.Text = stis
        Text6.Text = spp
        Timer1.Enabled = True
        File1.Path = Text6.Text
        Combo1.Enabled = False
        Combo2.Enabled = False
        If Text1.Text = "" And Text2.Text = "" And Text3.Text = "" And Text4.Text = "" Then
            Text6.Visible = True
            Image9.Visible = True
        End If
        Me.ToolTip1.IsBalloon = True
    End Sub
    Private Sub Form1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        ProgressBar1.Visible = False
    End Sub
    Private Sub Image1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image1.Click
        Timer1.Enabled = False
    End Sub
    Private Sub Image1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image1.DoubleClick
        Timer1.Enabled = True
    End Sub
    Private Sub Image1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Image1.MouseMove
        Text1.Visible = False
        Text2.Visible = False
        Text3.Visible = False
        Text4.Visible = False
        ProgressBar1.Visible = False
        Text6.Visible = False
        If Me.CheckBox2.Checked = True Then
            Text4.Visible = True
        Else
            Text4.Visible = False
        End If
    End Sub
    Private Sub Image7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image7.Click
        If VB6.PixelsToTwipsX(Me.Width) <= 5000 Then
            Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 2287.5)
            Me.Width = VB6.TwipsToPixelsX(9450)
            Me.ProgressBar1.Width = VB6.TwipsToPixelsX(9360)
            command3.Left = VB6.TwipsToPixelsX(4200)
            If Combo1.Text = "True" Then
                Text5.Enabled = True
                Image9.Enabled = True
            Else
                Text5.Enabled = False
                Image9.Enabled = False
            End If
        Else
            Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 2287.5)
            Me.Width = VB6.TwipsToPixelsX(4785)
            Me.ProgressBar1.Width = VB6.TwipsToPixelsX(4680)
            command3.Left = VB6.TwipsToPixelsX(1920)
            Me.Combo1.Enabled = False
            Me.Combo2.Enabled = False
            Text5.Enabled = False
            Image9.Enabled = False
        End If
    End Sub
    Private Sub Image9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image9.Click
        Text5.Text = CStr(10)
    End Sub
    Private Sub text1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Text1.MouseMove
        ProgressBar1.Visible = False
    End Sub
    Private Sub text2_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Text2.MouseMove
        ProgressBar1.Visible = False
    End Sub
    Private Sub text3_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Text3.MouseMove
        ProgressBar1.Visible = False
    End Sub
    Private Sub text4_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Text4.MouseMove
        ProgressBar1.Visible = False
    End Sub
    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        On Error GoTo e
        Dim f As Short
        f = File1.SelectedIndex + 1
        File1.SelectedIndex = f
        Image1.Image = System.Drawing.Image.FromFile(Text6.Text & "\" & File1.FileName)
        Exit Sub
e:      File1.SelectedIndex = -1
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.FolderBrowserDialog1.SelectedPath = ""
        Me.FolderBrowserDialog1.Description = "请选择My Setting程序的变化图片文件夹途径"
        Me.FolderBrowserDialog1.ShowDialog()
        If Me.FolderBrowserDialog1.SelectedPath <> "" Then
            Text6.Text = Me.FolderBrowserDialog1.SelectedPath
            File1.Path = Text6.Text
        End If
    End Sub
    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Text3.Text = "6000"
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseMove
        Text6.Visible = True
    End Sub
    Private Sub command2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles command2.MouseMove
        Text2.Visible = True
        ProgressBar1.Visible = False
    End Sub
    Private Sub command1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles command1.MouseDown
        ProgressBar1.Visible = True
    End Sub
    Private Sub Label5_MouseMove1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseMove
        Text3.Visible = True
        ProgressBar1.Visible = False
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub CheckBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CheckBox1.MouseDown
        If CheckBox1.Checked = False Then
            Me.command1.Visible = False
            Me.command2.Visible = False
            Me.command3.Visible = False
            Me.Button1.Visible = False
            Me.Label5.Visible = False
            Text1.Visible = False
            Text2.Visible = False
            Text3.Visible = False
            Text4.Visible = False
            Text6.Visible = False
            CheckBox2.Checked = False
        Else
            Me.command1.Visible = True
            Me.command2.Visible = True
            Me.command3.Visible = True
            Me.Button1.Visible = True
            Me.Label5.Visible = True
        End If
    End Sub
    Private Sub CheckBox2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CheckBox2.MouseDown
        If CheckBox2.Checked = True Then
            Text4.Visible = False
        Else
            Text4.Visible = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("请单击右键！", MsgBoxStyle.Information, "提示")
    End Sub
    Private Sub TrueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TureToolStripMenuItem.Click
        Combo1.Text = "True"
        Text5.Enabled = True
        Image9.Enabled = True
    End Sub
    Private Sub FalseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FalseToolStripMenuItem.Click
        Combo1.Text = "False"
        Text5.Enabled = False
        Image9.Enabled = False
    End Sub
    Private Sub TureToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TureToolStripMenuItem1.Click
        Combo2.Text = "True"
    End Sub
    Private Sub FalseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FalseToolStripMenuItem1.Click
        Combo2.Text = "False"
    End Sub
    Private Sub ColorTransparentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorTransparentToolStripMenuItem.Click
        TextBox1.Text = "Color.Transparent"
    End Sub
    Private Sub ColorWhiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorWhiteToolStripMenuItem.Click
        TextBox1.Text = "Color.White"
    End Sub
    Private Sub ColorCoralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorCoralToolStripMenuItem.Click
        TextBox1.Text = "Color.Coral"
    End Sub
    Private Sub ColorGoldToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorGoldToolStripMenuItem.Click
        TextBox1.Text = "Color.Gold"
    End Sub
    Private Sub ColorGreenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorGreenToolStripMenuItem.Click
        TextBox1.Text = "Color.Green"
    End Sub
    Private Sub ColorPinkToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorPinkToolStripMenuItem.Click
        TextBox1.Text = "Color.Pink"
    End Sub
    Private Sub ColorPurpleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorPurpleToolStripMenuItem.Click
        TextBox1.Text = "Color.Purple"
    End Sub
    Private Sub ColorRedToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ColorRedToolStripMenuItem.Click
        TextBox1.Text = "Color.Red"
    End Sub
    Private Sub ColorBlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorBlackToolStripMenuItem.Click
        TextBox1.Text = "Color.Black"
    End Sub
    Private Sub ColorYellowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorYellowToolStripMenuItem.Click
        TextBox1.Text = "Color.Yellow"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("请单击右键！", MsgBoxStyle.Information, "提示")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("请单击右键！", MsgBoxStyle.Information, "提示")
    End Sub
    Private Sub TrueToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrueToolStripMenuItem.Click
        TextBox3.Text = "True"
    End Sub
    Private Sub FlaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlaseToolStripMenuItem.Click
        TextBox3.Text = "False"
    End Sub
    Private Sub OnlyOneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlyOneToolStripMenuItem.Click
        Me.TextBox4.Text = "1"
        Me.Text1.Text = ""
    End Sub
    Private Sub MoreThanOneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreThanOneToolStripMenuItem.Click
        Me.TextBox4.Text = "2"
        Me.Text1.Text = ""
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("请单击右键！", MsgBoxStyle.Information, "提示")
    End Sub

    Private Sub MuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MuToolStripMenuItem.Click
        Me.TextBox5.Text = "1"
        Me.Text2.Text = ""
    End Sub

    Private Sub VidioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VidioToolStripMenuItem.Click
        Me.TextBox5.Text = "2"
        Me.Text2.Text = ""
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "640" Then
            ComboBox2.Text = "480"
        End If
        If ComboBox1.Text = "800" Then
            ComboBox2.Text = "600"
        End If
        If ComboBox1.Text = "1024" Then
            ComboBox2.Text = "768"
        End If
        If ComboBox1.Text = "1028" Then
            ComboBox2.Text = "800"
        End If
        If ComboBox1.Text = "1280" Then
            ComboBox2.Text = "1024"
        End If
        If ComboBox1.Text = "1600" Then
            ComboBox2.Text = "1200"
        End If
    End Sub
End Class
