Imports System.Windows.Forms
Public Class Settings
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        ApplyToolStripMenuItem_Click(sender, e)
        ApplyToolStripMenuItem1_Click(sender, e)
        ToolStripMenuItem1_Click(sender, e)
        ToolStripMenuItem5_Click(sender, e)
        ToolStripMenuItem9_Click(sender, e)
        Button9_Click(sender, e)
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim = "1" Then
                ER(My.Application.CommandLineArgs(1).Trim)
            Else
                If My.Application.CommandLineArgs(0).Trim = "3" Then
                    ER(My.Application.CommandLineArgs(2).Trim)
                End If
            End If
        End If
        MsgBox("Save Succeed！", MsgBoxStyle.Information)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        TTS.loadd()
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        TTS.loadd()
        Me.Close()
    End Sub
    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TTS.loadd()
    End Sub
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TrackBar1.Value = Me.Opacity * 10
        cle1()
        run()
        PropertyGrid1.SelectedObject = TTS.LinkLabel1
        PropertyGrid2.SelectedObject = TTS.Label1
        ComboBox1.SelectedIndex = TTS.Panel1.BackgroundImageLayout
        ComboBox2.SelectedIndex = TTS.Panel1.BorderStyle
    End Sub
    Function cle1()
        On Error Resume Next
        NumericUpDown1.Value = 20
        TrackBar1.Value = 10
        CheckBox1.Checked = False
        Label2.Text = "100%"
    End Function
    Function run()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Everyday Crazy English")
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Everyday Crazy English", Nothing)
        If r1 <> Nothing Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
        Dim r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "BarWidth", Nothing)
        If r2 <> Nothing Then
            NumericUpDown1.Value = CInt(r2)
        Else
            NumericUpDown1.Value = 20
        End If
        Dim r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Opacity", Nothing)
        If r3 <> Nothing Then
            TrackBar1.Value = CInt(r3)
        Else
            TrackBar1.Value = 10
        End If
        Dim r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Automatic", Nothing)
        If r4 = "1" Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
        Dim r4_2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "AutoRead", Nothing)
        If r4_2 = "1" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
        Dim r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Interval", Nothing)
        If r5 <> "" Then
            NumericUpDown2.Value = CInt(r5)
        Else
            NumericUpDown2.Value = 0
            CheckBox2.Checked = False
        End If
        Dim r6 = TTS.regload("PImage")
        TextBox1.Text = r6
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim <> "0" And My.Application.CommandLineArgs(0).Trim <> "1" And My.Application.CommandLineArgs(0).Trim <> "2" And My.Application.CommandLineArgs(0).Trim <> "3" Then
                di(My.Application.CommandLineArgs(0).Trim, False)
            Else
                If My.Application.CommandLineArgs(0).Trim = "3" Then
                    di(My.Application.CommandLineArgs(1).Trim, False)
                Else
                    di(My.Application.Info.DirectoryPath + "\Default.xml", False)
                End If
            End If
        Else
            di(My.Application.Info.DirectoryPath + "\Default.xml", False)
        End If
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        cle1()
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = 3
        ComboBox2.SelectedIndex = 0
        ReloadToolStripMenuItem_Click(sender, e)
        ToolStripMenuItem2_Click(sender, e)
        ToolStripMenuItem6_Click(sender, e)
        ToolStripMenuItem10_Click(sender, e)
        CheckBox2.Checked = False
        Button8_Click(sender, e)
        CheckBox3.Checked = False
        My.Computer.Registry.CurrentUser.DeleteSubKey("software\Everyday Crazy English")
    End Sub
    Private Sub TrackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.ValueChanged
        Dim uip = (TrackBar1.Value / 10)
        Label2.Text = CStr(uip * 100).Trim + "%"
        TTS.Opacity = uip
    End Sub
    Function saveset1()
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Everyday Crazy English")
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Everyday Crazy English", My.Application.Info.DirectoryPath + "\Everyday Crazy English.exe" + cl.Trim)
        Else
            Dim ke = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
            ke.DeleteValue("Everyday Crazy English")
        End If
        If NumericUpDown1.Value <> Nothing Then
        Else
            NumericUpDown1.Value = 20
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "BarWidth", CStr(NumericUpDown1.Value).Trim)
        If TrackBar1.Value = 0 Then
            TrackBar1.Value = 1
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Opacity", CStr(TrackBar1.Value).Trim)
    End Function
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            If NumericUpDown2.Value = 0 Then
                NumericUpDown2.Value = 5000
            End If
            NumericUpDown2.Enabled = True
            Button8.Enabled = True
        Else
            NumericUpDown2.Enabled = False
            Button8.Enabled = False
        End If
    End Sub
    Private Sub ApplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem.Click
        saveset1()
    End Sub
    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        cle1()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        OK_Button_Click(sender, e)
    End Sub
    Private Sub CancelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem.Click
        Cancel_Button_Click(sender, e)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        NumericUpDown2.Value = 5000
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If NumericUpDown2.Value <> Nothing Then
            If NumericUpDown2.Value = 0 Then
                CheckBox2.Checked = False
              End If
        Else
            NumericUpDown2.Value = 0
            CheckBox2.Checked = False
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Everyday Crazy English")
        Dim ctf As String
        If CheckBox2.Checked = True Then
            ctf = "1"
        Else
            ctf = "0"
        End If
        Dim ctf2 As String
        If CheckBox3.Checked = True Then
            ctf2 = "1"
        Else
            ctf2 = "0"
        End If
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Automatic", ctf)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "Interval", CStr(NumericUpDown2.Value).Trim)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", "AutoRead", ctf2)
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        TTS.regsave("EFont", TTS.fontcov(TTS.LinkLabel1.Font, Nothing, True))
        TTS.regsave("ELinkColor", TTS.colorCov(TTS.LinkLabel1.LinkColor, Nothing, True))
        TTS.regsave("EActiveLinkColor", TTS.colorCov(TTS.LinkLabel1.ActiveLinkColor, Nothing, True))
        TTS.regsave("EBackColor", TTS.colorCov(TTS.LinkLabel1.BackColor, Nothing, True))
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim t1 As New LinkLabel
        Dim kb As New Font("微软雅黑", CSng(9), FontStyle.Regular)
        TTS.LinkLabel1.Font = kb
        TTS.LinkLabel1.LinkColor = t1.LinkColor
        TTS.LinkLabel1.ActiveLinkColor = t1.ActiveLinkColor
        TTS.LinkLabel1.BackColor = Color.Transparent
    End Sub
    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        TTS.regsave("CFont", TTS.fontcov(TTS.Label1.Font, Nothing, True))
        TTS.regsave("CForeColor", TTS.colorCov(TTS.Label1.ForeColor, Nothing, True))
        TTS.regsave("CBackColor", TTS.colorCov(TTS.Label1.BackColor, Nothing, True))
    End Sub
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Dim t1 As New Label
        TTS.Label1.Font = t1.Font
        TTS.Label1.ForeColor = t1.ForeColor
        TTS.Label1.BackColor = Color.Transparent
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim f As New OpenFileDialog
        With f
            .FileName = ""
            .Filter = "*.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|*.Bmp;*.Jpg;*.Png;*.Gif;*.Jpeg|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        PictureBox2.Image = Nothing
        If TextBox1.Text.Trim <> "" Then
            PictureBox2.Image = Image.FromFile(TextBox1.Text)
            TTS.Panel1.BackgroundImage = PictureBox2.Image
        Else
            TTS.Panel1.BackgroundImage = Nothing
        End If
    End Sub
    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        TTS.regsave("PImage", TextBox1.Text.Trim)
        TTS.regsave("PLayout", CStr(ComboBox1.SelectedIndex).Trim)
        TTS.regsave("PStyle", CStr(ComboBox2.SelectedIndex).Trim)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TTS.Panel1.BackgroundImageLayout = ComboBox1.SelectedIndex
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        TTS.Panel1.BorderStyle = ComboBox2.SelectedIndex
    End Sub
    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        TTS.Panel1.BackgroundImage = Nothing
        TTS.Panel1.BackgroundImageLayout = ImageLayout.Stretch
        TTS.Panel1.BorderStyle = BorderStyle.None
    End Sub
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        OK_Button_Click(sender, e)
    End Sub
    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Cancel_Button_Click(sender, e)
    End Sub
    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        OK_Button_Click(sender, e)
    End Sub
    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        Cancel_Button_Click(sender, e)
    End Sub
    Private Sub ToolStripMenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
        OK_Button_Click(sender, e)
    End Sub
    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        Cancel_Button_Click(sender, e)
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Add.TextBox1.Text = ""
        Add.TextBox2.Text = ""
        Add.aoe(False)
        Add.ShowDialog()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub CombineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CombineToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        With f
            .FileName = ""
            .Filter = "XML File *.xml|*.xml|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                di(.FileName, True)
            End If
        End With
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        For x = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems.Item(0).Remove()
        Next
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub
    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        With f
            .FileName = ""
            .Filter = "XML File *.xml|*.xml|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                di(.FileName, False)
            End If
        End With
    End Sub
    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Dim s As New SaveFileDialog
        With s
            .FileName = ""
            .Filter = "XML File *.xml|*.xml|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                bi(.FileName)
            End If
        End With
    End Sub
    Function bi(ByVal str As String)
        On Error Resume Next
        Dim sum As String
        If ListView1.Items.Count <> 0 Or TabControl1.TabPages(2).Text.Trim <> "Data Manager" Then
            sum = My.Resources.x1.Replace("/NNN\", TabControl1.TabPages(2).Text).Replace("/MMM\", CStr(ListView1.Items.Count).Trim)
            For x = 0 To ListView1.Items.Count - 1
                sum = sum + vbCrLf + My.Resources.x2.Replace("\MMM/", CStr(x).Trim).Replace("\EEE/", ListView1.Items(x).SubItems(0).Text.Trim).Replace("\CCC/", ListView1.Items(x).SubItems(1).Text.Trim)
            Next
            sum = sum + vbCrLf + My.Resources.x3
            My.Computer.FileSystem.WriteAllText(str, sum.Replace("&", "*\*/*"), False, System.Text.Encoding.UTF8)
        End If
    End Function
    Private Sub ApplyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyToolStripMenuItem1.Click
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim <> "0" And My.Application.CommandLineArgs(0).Trim <> "1" And My.Application.CommandLineArgs(0).Trim <> "2" And My.Application.CommandLineArgs(0).Trim <> "3" Then
                bi(My.Application.CommandLineArgs(0).Trim)
            Else
                If My.Application.CommandLineArgs(0).Trim = "3" Then
                    bi(My.Application.CommandLineArgs(1).Trim)
                Else
                    bi(My.Application.Info.DirectoryPath + "\Default.xml")
                End If
            End If
        Else
            bi(My.Application.Info.DirectoryPath + "\Default.xml")
        End If
    End Sub
    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim <> "0" And My.Application.CommandLineArgs(0).Trim <> "1" And My.Application.CommandLineArgs(0).Trim <> "2" And My.Application.CommandLineArgs(0).Trim <> "3" Then
                di(My.Application.CommandLineArgs(0).Trim, False)
            Else
                If My.Application.CommandLineArgs(0).Trim = "3" Then
                    di(My.Application.CommandLineArgs(1).Trim, False)
                Else
                    di(My.Application.Info.DirectoryPath + "\Default.xml", False)
                End If
            End If
        Else
            di(My.Application.Info.DirectoryPath + "\Default.xml", False)
        End If
    End Sub
    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        OK_Button_Click(sender, e)
    End Sub
    Private Sub CancelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripMenuItem1.Click
        Cancel_Button_Click(sender, e)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DeleteToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        EditToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ClearToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ImportToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ExportToolStripMenuItem_Click(sender, e)
    End Sub
    Function di(ByVal str As String, ByVal com As Boolean)
        On Error Resume Next
        Dim ddc As String = str
        If My.Computer.FileSystem.FileExists(ddc) = False Then
            ddc = My.Application.Info.DirectoryPath + "\Default.xml"
        End If
        Dim Aero = XDocument.Load(ddc)
        If com = False Then
            ListView1.Items.Clear()
        End If
        If Aero.<Aero>.<Tile>.Value.Replace("*\*/*", "&").Trim <> "" Then
            TabControl1.TabPages(2).Text = Aero.<Aero>.<Tile>.Value.Replace("*\*/*", "&")
        End If
        For x = 0 To CInt(Aero.<Aero>.<FileNum>.Value) - 1
            Dim kpp As String = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&")
            Dim kss As String = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&")
            ListView1.Items.Add(kpp, x)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
        Next
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Function
    Dim ss As New SpeechLib.SpVoice
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count <> 0 Then
            RadioButton1.Checked = True
            ss.Speak(ListView1.SelectedItems(0).Text)
            RadioButton1.Checked = False
        End If
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Add.TextBox1.Text = ListView1.SelectedItems(0).Text
            Add.TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            Add.aoe(True)
            Add.ShowDialog()
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\LiYang Crazy English 365.exe", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Timer1.Enabled = True
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Hide()
        ContextMenuStrip6.Show(PictureBox3, 0, 0)
        Me.Show()
    End Sub
    Dim t = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Button11.Top < Panel2.Height - Button11.Height Then
            t = t + 0.1
            Button11.Top = Button11.Top + t
            PictureBox4.Top = PictureBox4.Top + t
        Else
            Timer1.Enabled = False
            Button11.Top = 0
            PictureBox4.Top = -Button11.Height - 1
            Me.Hide()
            AboutBox1.ShowDialog()
            Me.Show()
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        NumericUpDown1.Value = 20
    End Sub
    Private Sub ImportRegToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportRegToolStripMenuItem.Click
        Dim f As New OpenFileDialog
        With f
            .FileName = ""
            .Filter = "REGX File *.regx|*.regx|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                IR(.FileName)
                MsgBox("ImportReg Succeed！", MsgBoxStyle.Information)
                TTS.loadd()
                Me.Close()
            End If
        End With
    End Sub
    Function IR(ByVal str As String)
        On Error Resume Next
        Button7_Click(Nothing, Nothing)
        Dim ddc As String = str
        Dim Aero = XDocument.Load(ddc)
        Dim r = Aero.<REGX>.<Run>.Value
        Dim r1 = Aero.<REGX>.<BarWidth>.Value
        Dim r2 = Aero.<REGX>.<Opacity>.Value
        Dim r3 = Aero.<REGX>.<EFont>.Value
        Dim r4 = Aero.<REGX>.<ELinkColor>.Value
        Dim r5 = Aero.<REGX>.<EActiveLinkColor>.Value
        Dim r6 = Aero.<REGX>.<EBackColor>.Value
        Dim r7 = Aero.<REGX>.<CFont>.Value
        Dim r8 = Aero.<REGX>.<CForeColor>.Value
        Dim r9 = Aero.<REGX>.<CBackColor>.Value
        Dim r10 = Aero.<REGX>.<PImage>.Value
        Dim r11 = Aero.<REGX>.<PLayout>.Value
        Dim r12 = Aero.<REGX>.<PStyle>.Value
        Dim r13 = Aero.<REGX>.<Automatic>.Value
        Dim r14 = Aero.<REGX>.<Interval>.Value
        Dim r15 = Aero.<REGX>.<AutoRead>.Value
        TTS.regsave("BarWidth", r1)
        TTS.regsave("Opacity", r2)
        TTS.regsave("EFont", r3)
        TTS.regsave("ELinkColor", r4)
        TTS.regsave("EActiveLinkColor", r5)
        TTS.regsave("EBackColor", r6)
        TTS.regsave("CFont", r7)
        TTS.regsave("CForeColor", r8)
        TTS.regsave("CBackColor", r9)
        TTS.regsave("PImage", r10)
        TTS.regsave("PLayout", r11)
        TTS.regsave("PStyle", r12)
        TTS.regsave("Automatic", r13)
        TTS.regsave("Interval", r14)
        TTS.regsave("AutoRead", r15)
        If r.Trim <> Nothing Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Everyday Crazy English", r)
        End If
    End Function
    Function ER(ByVal str As String)
        On Error Resume Next
        Dim r = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run", "Everyday Crazy English", Nothing)
        Dim r1 = TTS.regload("BarWidth")
        Dim r2 = TTS.regload("Opacity")
        Dim r3 = TTS.regload("EFont")
        Dim r4 = TTS.regload("ELinkColor")
        Dim r5 = TTS.regload("EActiveLinkColor")
        Dim r6 = TTS.regload("EBackColor")
        Dim r7 = TTS.regload("CFont")
        Dim r8 = TTS.regload("CForeColor")
        Dim r9 = TTS.regload("CBackColor")
        Dim r10 = TTS.regload("PImage")
        Dim r11 = TTS.regload("PLayout")
        Dim r12 = TTS.regload("PStyle")
        Dim r13 = TTS.regload("Automatic")
        Dim r14 = TTS.regload("Interval")
        Dim r15 = TTS.regload("AutoRead")
        Dim rs = My.Resources.x4.Replace("*r*", r).Replace("*r1*", r1).Replace("*r2*", r2).Replace("*r3*", r3).Replace("*r4*", r4).Replace("*r5*", r5).Replace("*r6*", r6).Replace("*r7*", r7).Replace("*r8*", r8).Replace("*r9*", r9).Replace("*r10*", r10).Replace("*r11*", r11).Replace("*r12*", r12).Replace("*r13*", r13).Replace("*r14*", r14).Replace("*r15*", r15)
        My.Computer.FileSystem.WriteAllText(str, rs, False, System.Text.Encoding.UTF8)
    End Function
    Private Sub ExportRegToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportRegToolStripMenuItem.Click
        Dim f As New SaveFileDialog
        With f
            .FileName = ""
            .Filter = "REGX File *.regx|*.regx|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                ER(.FileName)
                MsgBox("ExportReg Succeed！", MsgBoxStyle.Information)
            End If
        End With
    End Sub
    Private Sub TitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripMenuItem.Click
        Dim j = InputBox("Please fill in the title:", "The Title Of Data", TabControl1.TabPages(2).Text)
        If j <> "" Then
            TabControl1.TabPages(2).Text = j
        End If
    End Sub
    Dim cl As String = ""
    Private Sub CheckBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CheckBox1.MouseClick
        If CheckBox1.Checked = True Then
            Dim j = InputBox("Please fill in the command line:", "The Running Command Line", cl)
            cl = " " + j
        Else
            cl = ""
        End If
    End Sub
    Private Sub RadioButton1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseClick
        ListView1_DoubleClick(sender, e)
        RadioButton1.Checked = False
    End Sub
End Class