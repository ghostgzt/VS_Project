Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s1 As String
        Dim s2 As String
        s1 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing)
        TextBox5.Text = s1
        s2 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "SystemRoot", Nothing)
        TextBox1.Text = s2 + "\system32"
        GoTo t
w:
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
        Exit Sub
t:
        On Error Resume Next
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20")
        MkDir(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21")
        GoTo w
    End Sub
    Private Sub Form1_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cancel As Boolean = eventArgs.Cancel
        Dim unloadmode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If unloadmode = 0 Or unloadmode = 3 Then
            If form1.Visible = False Then
                form1.Visible = True
            End If
            Me.Hide()
        End If
        eventArgs.Cancel = cancel
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox2.Text = "" Then
            MsgBox("1.请输入修改程序的路径！！！；2.如果你还没有安装VistaBootLogoGenerator，请单击安装按钮进行安装", MsgBoxStyle.Information, "提示")
        Else
            On Error GoTo O
            Dim P
            P = Shell(TextBox2.Text, 1)
            Exit Sub
O:
            MsgBox("1.请正确输入修改程序的路径！！！；2.如果你还没有安装VistaBootLogoGenerator，请单击安装按钮进行安装", MsgBoxStyle.Information, "输入错误")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo w
        Dim R
        R = Shell(My.Application.Info.DirectoryPath + "\VistaBootLogoGeneratorSetup.exe", 1)
        Exit Sub
w:
        MsgBox("程序找不到文件，请上网下载安装！？", MsgBoxStyle.Information, "找不到文件")
    End Sub
    Private Sub TextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Click
        Me.OpenFileDialog1.FileName = ""
        Me.OpenFileDialog1.Filter = "*.EXE|*.EXE"
        Me.OpenFileDialog1.ShowDialog()
        If Me.OpenFileDialog1.FileName <> "" Then
            TextBox2.Text = Me.OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub PictureBox11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        Form2.PictureBox1.Image = Me.PictureBox11.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Form2.PictureBox1.Image = Me.PictureBox12.Image
        Form2.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.OpenFileDialog2.FileName = ""
        Me.OpenFileDialog2.Filter = "Winload.exe.mui|Winload.exe.mui"
        Me.OpenFileDialog2.ShowDialog()
        If Me.OpenFileDialog2.FileName <> "" Then
            TextBox3.Text = Me.OpenFileDialog2.FileName
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.OpenFileDialog3.FileName = ""
        Me.OpenFileDialog3.Filter = "*.JPG|*.JPG"
        Me.OpenFileDialog3.ShowDialog()
        If Me.OpenFileDialog3.FileName <> "" Then
            TextBox4.Text = Me.OpenFileDialog3.FileName
        End If
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else

            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox32.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub PictureBox33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        If TextBox4.Text = "" Or TextBox3.Text = "" Then
            MsgBox("请填写文件和图片的路径！！", MsgBoxStyle.Information, "提示")
        Else
            If MsgBox("Are you OK?", MsgBoxStyle.YesNo, "决定") = MsgBoxResult.Yes Then
                FileCopy(TextBox3.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\winload.exe.mui")
                FileCopy(TextBox4.Text, My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg")
                Timer1.Enabled = True
            Else
            End If
        End If
    End Sub
    Private Sub Button1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo p
        If TextBox1.Text = "" Then
            MsgBox("请输入", MsgBoxStyle.Information, "提示")
        Else
            Dim re
            re = Shell(TextBox1.Text + "\msconfig.exe", 1)
        End If
        Exit Sub
p:      MsgBox("路径错误，请重新选择#·#", MsgBoxStyle.Information, "错误")
    End Sub
    Private Sub PictureBox1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form2.PictureBox1.Image = Me.PictureBox1.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox2_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form2.PictureBox1.Image = Me.PictureBox2.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox3_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form2.PictureBox1.Image = Me.PictureBox3.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form2.PictureBox1.Image = Me.PictureBox5.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Form2.PictureBox1.Image = Me.PictureBox6.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Form2.PictureBox1.Image = Me.PictureBox7.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Form2.PictureBox1.Image = Me.PictureBox8.Image
        Form2.Show()
    End Sub
    Private Sub PictureBox9_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Form2.PictureBox1.Image = Me.PictureBox9.Image
        Form2.Show()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        form1.Show()
        Me.Hide()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Me.FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.Description = "请选择系统目录(如:C:\windows\system32)"
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox3.Text = ""
    End Sub
    Private Sub Button8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox4.Text = ""
    End Sub
    Private Sub PictureBox34_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        form1.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Form2.PictureBox1.Image = Me.PictureBox10.Image
        Form2.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        On Error Resume Next
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        MsgBox("已完成加入过程", MsgBoxStyle.Information, "完成")
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        On Error Resume Next
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
    End Sub
    Private Sub 删除画面文件ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除画面文件ToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error GoTo e
        Shell(TextBox5.Text + "\" + "explorer.exe " + TextBox5.Text + "\" + "system32\zh-cn", AppWinStyle.NormalFocus)
        Exit Sub
e:
        MsgBox("路径错误，请重新选择#·#", MsgBoxStyle.Information, "错误")
    End Sub
    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.Description = "请选择系统目录(如:C:\windows)"
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            TextBox5.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
End Class