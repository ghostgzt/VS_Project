Public Class form1
    Private Sub Form1_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cancel As Boolean = eventArgs.Cancel
        Dim unloadmode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Me.NotifyIcon1.Icon = Nothing
        If unloadmode = 0 Or unloadmode = 3 Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Vista Starter", "VistaBootLogoGenerator PATH", Form3.TextBox2.Text)
            Timer1.Enabled = False
            Timer2.Enabled = True
            cancel = True
        End If
        eventArgs.Cancel = cancel
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 0
        Me.Width = 0
        Timer1.Enabled = True
        On Error Resume Next
        Dim s
        Dim s1
        Dim S2
        My.Computer.Registry.CurrentUser.CreateSubKey("HKEY_CURRENT_USER\software\Vista Starter")
        s = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing)
        S2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Vista Starter", "VistaBootLogoGenerator PATH", Nothing)
        Form3.TextBox2.Text = S2
        TextBox1.Text = s + "\system32\zh-cn"
        Form3.TextBox1.Text = s
        Me.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        Me.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        Me.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        Me.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        Me.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        Me.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        Me.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        Me.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        Me.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        Me.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        Me.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        Me.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        Me.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        Me.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        Me.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        Me.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        Me.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        Me.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        Me.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        Me.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        Me.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Vista Starter", "YYY", Nothing) Is Nothing Then
            If MsgBox("在修改之前,要先调整Winload.exe.mui的权限,你调整了吗", MsgBoxStyle.YesNo, "第一次运行") = MsgBoxResult.Yes Then
                Timer3.Enabled = True
            End If
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox2.ImageLocation
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox3.ImageLocation
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox4.ImageLocation
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox5.ImageLocation
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox6.ImageLocation
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox7.ImageLocation
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox8.ImageLocation
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox9.ImageLocation
    End Sub
    Private Sub PictureBox10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox10.ImageLocation
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox11.ImageLocation
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox12.ImageLocation
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox13.ImageLocation
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox14.ImageLocation
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox15.ImageLocation
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox16.ImageLocation
    End Sub
    Private Sub PictureBox17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox17.ImageLocation
    End Sub
    Private Sub PictureBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox18.ImageLocation
    End Sub
    Private Sub PictureBox19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox19.ImageLocation
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Vista Starter", "VistaBootLogoGenerator PATH", Form3.TextBox2.Text)
        On Error GoTo k
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        If Me.PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg" Then
            FileCopy(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21" + "\winload.exe.mui", TextBox1.Text + "\winload.exe.mui")
            GoTo r
        End If
        Exit Sub
k:
        MsgBox("失败，可能要调整权限？？？", MsgBoxStyle.Information, "信息")
        Me.Hide()
        Form3.Show()
        Exit Sub
r:      MsgBox("请进入‘修改启动’修改后，重启后进入VISTA！！！", MsgBoxStyle.Information, "信息")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Vista Starter", "YYY", "YES")
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub PictureBox20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox20.ImageLocation
    End Sub
    Private Sub PictureBox21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox21.ImageLocation
    End Sub
    Private Sub PictureBox22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        Me.PictureBox1.ImageLocation = Me.PictureBox22.ImageLocation
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Form2.PictureBox1.ImageLocation = Me.PictureBox1.ImageLocation
        Form2.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Height < 468 Then
            Me.Height = Me.Height + 30
        Else
            If Me.Height > 468 Then
                Me.Height = 468
            End If
            If Me.Width < 643 Then
                Me.Width = Me.Width + 60
                If Me.Width = 597 Then
                    Me.Width = Me.Width + 46
                End If
            Else
                If Me.Width > 643 Then
                    Me.Width = 643
                End If
            End If
        End If
    End Sub
    Private Sub ENDToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ENDToolStripMenuItem.Click
        Me.NotifyIcon1.Icon = Nothing
        End
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.FolderBrowserDialog1.ShowDialog()
        If Me.FolderBrowserDialog1.SelectedPath <> "" Then
            TextBox1.Text = Me.FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Height <= 468 Then
            Me.Height = Me.Height - 50
            If Me.Height = 68 Then
                Me.Height = 32
            End If
        End If
        If Me.Width <= 643 Then
            Me.Width = Me.Width - 60
            If Me.Width = 43 Then
                Me.Width = 117
            End If
        End If
        If Me.Height <= 50 And Me.Width <= 140 Then
            End
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Visible = False
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Form3.Show()
        Me.Visible = False

    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Visible = False
        Form3.Show()
        Timer3.Enabled = False
    End Sub
    Private Sub 擦新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 擦新ToolStripMenuItem.Click
        On Error Resume Next
        Me.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        Me.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        Me.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        Me.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        Me.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        Me.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        Me.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        Me.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        Me.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        Me.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        Me.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        Me.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        Me.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        Me.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        Me.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        Me.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        Me.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        Me.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        Me.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        Me.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        Me.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Form3.PictureBox13.ImageLocation = Me.PictureBox2.ImageLocation
        Form3.PictureBox14.ImageLocation = Me.PictureBox3.ImageLocation
        Form3.PictureBox15.ImageLocation = Me.PictureBox4.ImageLocation
        Form3.PictureBox16.ImageLocation = Me.PictureBox5.ImageLocation
        Form3.PictureBox17.ImageLocation = Me.PictureBox6.ImageLocation
        Form3.PictureBox18.ImageLocation = Me.PictureBox7.ImageLocation
        Form3.PictureBox19.ImageLocation = Me.PictureBox8.ImageLocation
        Form3.PictureBox20.ImageLocation = Me.PictureBox9.ImageLocation
        Form3.PictureBox21.ImageLocation = Me.PictureBox10.ImageLocation
        Form3.PictureBox22.ImageLocation = Me.PictureBox11.ImageLocation
        Form3.PictureBox23.ImageLocation = Me.PictureBox12.ImageLocation
        Form3.PictureBox24.ImageLocation = Me.PictureBox13.ImageLocation
        Form3.PictureBox25.ImageLocation = Me.PictureBox14.ImageLocation
        Form3.PictureBox26.ImageLocation = Me.PictureBox15.ImageLocation
        Form3.PictureBox27.ImageLocation = Me.PictureBox16.ImageLocation
        Form3.PictureBox28.ImageLocation = Me.PictureBox17.ImageLocation
        Form3.PictureBox29.ImageLocation = Me.PictureBox18.ImageLocation
        Form3.PictureBox30.ImageLocation = Me.PictureBox19.ImageLocation
        Form3.PictureBox31.ImageLocation = Me.PictureBox20.ImageLocation
        Form3.PictureBox32.ImageLocation = Me.PictureBox21.ImageLocation
        Form3.PictureBox33.ImageLocation = Me.PictureBox22.ImageLocation
    End Sub
End Class