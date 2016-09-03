Public Class TTS
    Dim ss As New SpeechLib.SpVoice
    Dim h As Integer
    Dim w As Integer
    Private Sub TTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadd()
    End Sub
    Dim sfs As String = ""
    Function loadd()
        On Error Resume Next
        sfs = ""
        Dim r1
        Dim r2
        Dim r3
        Dim r4
        Dim r5
        Dim r5_1
        Dim r5_2
        Dim r5_3
        Dim r6
        Dim r7
        Dim r8
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim = "2" Then 'unsave
                rand(My.Application.CommandLineArgs(1))
                Dim ddc As String = My.Application.CommandLineArgs(2)
                Dim Aero = XDocument.Load(ddc)
                r1 = Aero.<REGX>.<BarWidth>.Value
                r2 = Aero.<REGX>.<EFont>.Value
                r3 = Aero.<REGX>.<ELinkColor>.Value
                r4 = Aero.<REGX>.<EActiveLinkColor>.Value
                r5 = Aero.<REGX>.<EBackColor>.Value
                r5_1 = Aero.<REGX>.<CFont>.Value
                r5_2 = Aero.<REGX>.<CForeColor>.Value
                r5_3 = Aero.<REGX>.<CBackColor>.Value
                r6 = Aero.<REGX>.<PImage>.Value
                r7 = Aero.<REGX>.<PLayout>.Value
                r8 = Aero.<REGX>.<PStyle>.Value
            Else
                If My.Application.CommandLineArgs(0).Trim = "3" Then 'save
                    rand(My.Application.CommandLineArgs(1).Trim)
                    Settings.IR(My.Application.CommandLineArgs(2).Trim)
                    sfs = My.Application.CommandLineArgs(2).Trim
                    GoTo g
                Else
                    If My.Application.CommandLineArgs(0).Trim = "1" Then
                        rand(My.Application.Info.DirectoryPath + "\Default.xml")
                        Settings.IR(My.Application.CommandLineArgs(1).Trim) 'only
                        sfs = My.Application.CommandLineArgs(1).Trim
                        GoTo g
                    Else
                        If My.Application.CommandLineArgs(0).Trim = "0" Then
                            rand(My.Application.Info.DirectoryPath + "\Default.xml")
                            Dim ddc As String = My.Application.CommandLineArgs(1).Trim
                            Dim Aero = XDocument.Load(ddc)
                            r1 = Aero.<REGX>.<BarWidth>.Value
                            r2 = Aero.<REGX>.<EFont>.Value
                            r3 = Aero.<REGX>.<ELinkColor>.Value
                            r4 = Aero.<REGX>.<EActiveLinkColor>.Value
                            r5 = Aero.<REGX>.<EBackColor>.Value
                            r5_1 = Aero.<REGX>.<CFont>.Value
                            r5_2 = Aero.<REGX>.<CForeColor>.Value
                            r5_3 = Aero.<REGX>.<CBackColor>.Value
                            r6 = Aero.<REGX>.<PImage>.Value
                            r7 = Aero.<REGX>.<PLayout>.Value
                            r8 = Aero.<REGX>.<PStyle>.Value
                        Else
                            If My.Application.CommandLineArgs(0).Trim = "/?" Then
                                MsgBox("{ECE.exe} [Data]" + vbCrLf + "{ECE.exe} [0] [REGX Read]" + vbCrLf + "{ECE.exe} [1] [REGX Save]" + vbCrLf + "{ECE.exe} [2] [Data] [REGX Read]" + vbCrLf + "{ECE.exe} [3] [Data] [REGX Save]", MsgBoxStyle.Information)
                                End
                            Else
                                rand(My.Application.CommandLineArgs(0).Trim)
                                GoTo g
                            End If
                        End If
                    End If
                End If
            End If
        Else
            rand(My.Application.Info.DirectoryPath + "\Default.xml")
g:          r1 = regload("BarWidth")
            r2 = regload("EFont")
            r3 = regload("ELinkColor")
            r4 = regload("EActiveLinkColor")
            r5 = regload("EBackColor")
            r5_1 = regload("CFont")
            r5_2 = regload("CForeColor")
            r5_3 = regload("CBackColor")
            r6 = regload("PImage")
            r7 = regload("PLayout")
            r8 = regload("PStyle")
        End If
        Dim bw As Integer
        If r1 <> Nothing Then
            If r1 = "0" Then
                r1 = 20
            Else
                bw = r1
            End If
        Else
            bw = 20
        End If
        If r2 <> Nothing Then
            LinkLabel1.Font = fontcov(Nothing, r2, False)
        End If
        If r3 <> Nothing Then
            LinkLabel1.LinkColor = colorCov(Nothing, r3, False)
        End If
        If r4 <> Nothing Then
            LinkLabel1.ActiveLinkColor = colorCov(Nothing, r4, False)
        End If
        If r5 <> Nothing Then
            LinkLabel1.BackColor = colorCov(Nothing, r5, False)
        End If
        If r5_1 <> Nothing Then
            Label1.Font = fontcov(Nothing, r5_1, False)
        End If
        If r5_2 <> Nothing Then
            Label1.ForeColor = colorCov(Nothing, r5_2, False)
        End If
        If r5_3 <> Nothing Then
            Label1.BackColor = colorCov(Nothing, r5_3, False)
        End If
        If r6 <> Nothing Then
            Panel1.BackgroundImage = Image.FromFile(r6)
        End If
        If r7 <> Nothing Then
            Panel1.BackgroundImageLayout = CInt(r7)
        End If
        If r8 <> Nothing Then
            Panel1.BorderStyle = CInt(r8)
        End If
        Panel1.Refresh()
        h = (My.Computer.Screen.Bounds.Height) - bw
        w = (My.Computer.Screen.Bounds.Width)
        Me.Left = w - Me.Width
        Me.Top = h
        Me.TopMost = True
        Timer1.Enabled = True
    End Function
    Dim kpp As String
    Dim kss As String
    Function rand(ByVal str As String)
        On Error Resume Next
        Dim ddc As String = str
        If My.Computer.FileSystem.FileExists(ddc) = False Then
            ddc = My.Application.Info.DirectoryPath
        End If
        Dim Aero = XDocument.Load(ddc)
        Dim r As New Random
        Dim x = (r.Next((Aero.<Aero>.<FileNum>.Value)))
        kpp = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&")
        kss = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&")
        If kpp <> "" Or kss <> "" Then
            Look.TextBox1.Text = kpp
            Look.TextBox2.Text = kss
            If kpp.Length > 45 Then
                LinkLabel1.Text = kpp.Remove(42) + "..."
            Else
                LinkLabel1.Text = kpp
            End If
            If kss.Length > 18 Then
                Label1.Text = kss.Remove(18) + "..."
            Else
                Label1.Text = kss
            End If
        End If
    End Function
    Function regload(ByVal name As String)
        On Error Resume Next
        Return My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", name, Nothing)
    End Function
    Function regsave(ByVal name As String, ByVal value As Object)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\Everyday Crazy English")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Everyday Crazy English", name, value)
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Top > h - Me.Height Then
            Me.Top = Me.Top - 10
            Me.Opacity = Me.Opacity + 0.1
        Else
            Dim r
            Dim r1
            Dim r2
            Dim r3
            If My.Application.CommandLineArgs.Count <> 0 Then
                If My.Application.CommandLineArgs(0).Trim = "2" Then 'unsave
                    Dim ddc As String = My.Application.CommandLineArgs(2).Trim
                    Dim Aero = XDocument.Load(ddc)
                    r1 = Aero.<REGX>.<Automatic>.Value
                    r2 = Aero.<REGX>.<Interval>.Value
                    r3 = Aero.<REGX>.<AutoRead>.Value
                    r = Aero.<REGX>.<Opacity>.Value
                Else
                    If My.Application.CommandLineArgs(0).Trim = "0" Then
                        Dim ddc As String = My.Application.CommandLineArgs(1).Trim
                        Dim Aero = XDocument.Load(ddc)
                        r1 = Aero.<REGX>.<Automatic>.Value
                        r2 = Aero.<REGX>.<Interval>.Value
                        r3 = Aero.<REGX>.<AutoRead>.Value
                        r = Aero.<REGX>.<Opacity>.Value
                    Else
                        GoTo g
                    End If
                End If
            Else
g:              r1 = regload("Automatic")
                r2 = regload("Interval")
                r3 = regload("AutoRead")
                r = regload("Opacity")
            End If
            If r <> Nothing Then
                Me.Opacity = CInt(r) / 10
            Else
                Me.Opacity = 1
            End If
            Timer1.Enabled = False
            If r1 = "1" And r2 <> Nothing Then
                Timer3.Interval = CInt(r2)
                Timer3.Enabled = True
            End If
            If r3 = "1" Then
                If Look.TextBox1.Text = "" Then
                    Look.TextBox1.Text = LinkLabel1.Text
                    Look.TextBox2.Text = Label1.Text
                End If
                ss.Speak(Look.TextBox1.Text.Trim)
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0 Then
            Me.Top = Me.Top + 10
            Me.Opacity = Me.Opacity - 0.1
        Else
            Me.Opacity = 0
            Timer2.Enabled = False
            If sfs.Trim <> "" Then
                Settings.ER(sfs.Trim)
            End If
            End
        End If
    End Sub
    Private Sub RadioButton1_MouseClick() Handles RadioButton1.MouseClick
        Me.Opacity = 1
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        If Look.IsHandleCreated = True Then
            Look.Close()
        Else
            RadioButton1_MouseClick()
        End If
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Timer3.Enabled = False
        If Look.IsHandleCreated = True Then
            Look.Close()
        End If
        Settings.ShowDialog()
    End Sub
    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        On Error GoTo r
        Timer3.Enabled = False
        If kpp = "" Then
            ss.Speak(LinkLabel1.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
        Else
            ss.Speak(kpp, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
        End If

        Exit Sub
r:      ss.Speak(LinkLabel1.Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub
    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(Look.TextBox1.Text + vbLf + Look.TextBox2.Text)
        MsgBox("Copy Succeed！", MsgBoxStyle.Information, "Everyday Crazy English")
    End Sub
    Private Sub LookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookToolStripMenuItem.Click
        Look.ShowDialog()
    End Sub
    Private Sub ReadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadToolStripMenuItem.Click
        LinkLabel1_Click(sender, e)
    End Sub
    Function colorCov(ByVal col As Color, ByVal coln As String, ByVal c2s As Boolean)
        On Error Resume Next
        If c2s = True Then
            Return col.ToArgb
        Else
            Return System.Drawing.Color.FromArgb(CLng(coln))
        End If
    End Function
    Function fontcov(ByVal fon As Font, ByVal str As String, ByVal f2h As Boolean)
        On Error Resume Next
        If f2h = True Then
            Return (fon.ToString)
        Else
            Dim d1 = str.Replace("[", "").Replace("]", "").Replace("Font: ", "")
            Dim d2 = d1.Split(",")(0).Trim.Replace("Name=", "")
            Dim d3 = d1.Split(",")(1).Trim.Replace("Size=", "")
            Dim d4 = d1.Split(",")(2).Trim.Replace("Units=", "")
            Dim d5 = d1.Split(",")(3).Trim.Replace("GdiCharSet=", "")
            Dim d6 = d1.Split(",")(4).Trim.Replace("GdiVerticalFont=", "")
            Dim fs As FontStyle
            If d4 = "8" Then
                fs = FontStyle.Strikeout
            Else
                If d4 = "1" Then
                    fs = FontStyle.Bold
                Else
                    If d4 = "2" Then
                        fs = FontStyle.Italic
                    Else
                        If d4 = "4" Then
                            fs = FontStyle.Underline
                        Else
                            fs = FontStyle.Regular
                        End If
                    End If
                End If
            End If
            Dim Nfont As New Font(CStr(d2), CSng(d3), fs)
            Return Nfont
        End If
    End Function
    Private Sub ReadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadToolStripMenuItem1.Click
        LinkLabel1_Click(sender, e)
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
        Timer3.Enabled = False
    End Sub
    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        Timer3.Enabled = False
        Look.ShowDialog()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer3.Enabled = False
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim <> "2" And My.Application.CommandLineArgs(0).Trim <> "0" Then
                Settings.ShowDialog()
            End If
        Else
            Settings.ShowDialog()
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Timer3.Enabled = False
        AboutBox1.ShowDialog()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Timer3.Enabled = False
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs(0).Trim <> "2" And My.Application.CommandLineArgs(0).Trim <> "0" Then
                SettingsToolStripMenuItem.Visible = True
            Else
                SettingsToolStripMenuItem.Visible = False
            End If
        Else
            SettingsToolStripMenuItem.Visible = True
        End If
    End Sub
    Private Sub ContextMenuStrip2_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Timer3.Enabled = False
    End Sub
End Class