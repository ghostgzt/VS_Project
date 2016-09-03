Public Class Aero_Setup
    Dim y As Integer
    Dim i As String
    Dim a As Integer
    Dim la As String
    Dim kt = My.Computer.FileSystem.SpecialDirectories.Temp + "\Mount"
    Dim aweb As New AeroSetup.Web_Explorer
    Dim Ase As New AeroSetup.AeroSetup
    Private Sub Aero_Setup_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        Ase.unmount(kt, TextBox2.Text)
        Ase.se()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo x
        If Command() = "/rw" Then
            Ase.w(TextBox1.Text)
            MsgBox("重写成功！！！", MsgBoxStyle.Information)
            End
        End If
        If Command() = "/?" Then
            MsgBox("/rw 重写Aero.xml", MsgBoxStyle.Information)
            End
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Aero.xml") = False Then
            Ase.w(TextBox1.Text)
            MsgBox("Not Find Aero.xml", MsgBoxStyle.Exclamation)
            End
        End If
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
        PictureBox1.ImageLocation = (Aero.<Aero>.<pic>.Value)
        Me.Text = Aero.<Aero>.<Tile>.Value
        Dim t = My.Computer.FileSystem.Drives
        For l = 0 To My.Computer.FileSystem.Drives.Count - 1
            ComboBox1.Items.Add(t(l))
        Next l
        ComboBox1.Text = "C:\"
        On Error Resume Next
        Ase.sr()
        Ase.unmount(kt, TextBox2.Text)
        Timer2.Enabled = True
        Exit Sub
x:      Ase.X()
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Setup" Then
            Button1.Text = "Cancel"
            Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
            On Error GoTo X
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + Aero.<Aero>.<Wim>(0).Value) = True Then
                Ase.mount(kt, TextBox2.Text)
            Else
                MsgBox("找不到安装文件——" + Aero.<Aero>.<Wim>(0).Value, MsgBoxStyle.Information)
                End
            End If
            MsgBox("请移除与安装文件相同的文件或文件夹！！" + vbCrLf + "否则，可能会失败！！！", MsgBoxStyle.Information)
            ComboBox1.Enabled = False
            Dim k As Integer = Aero.<Aero>.<Filenum>.Value
            Dim p As Integer = Aero.<Aero>.<Dirnum>.Value
            Dim z As Integer = Aero.<Aero>.<Runnum>.Value
            y = k + p + z
            i = ComboBox1.Text
            ProgressBar1.Value = 0
            Timer1.Enabled = True
            BackgroundWorker1.RunWorkerAsync()
        Else
            BackgroundWorker1.CancelAsync()
            MsgBox("Setup Failed！！！", MsgBoxStyle.Information)
            Ase.unmount(kt, TextBox2.Text)
            Ase.se()
            End
        End If
        Exit Sub
X:      Ase.X()
        End
    End Sub
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
        Dim k As Integer = Aero.<Aero>.<Filenum>.Value
        Dim p As Integer = Aero.<Aero>.<Dirnum>.Value
        Dim z As Integer = Aero.<Aero>.<Runnum>.Value
        On Error GoTo x
        For u = 0 To k - 1
            la = "正在安装——" + Aero.<Aero>.<File>(u).Value
            If My.Computer.FileSystem.FileExists(i + Aero.<Aero>.<File>(u).Value) = True Then
                If MsgBox("是否全部替换？" + i + Aero.<Aero>.<File>(u).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(i + Aero.<Aero>.<File>(u).Value, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    My.Computer.FileSystem.CopyFile(kt + "\" + Aero.<Aero>.<File>(u).Value, i + Aero.<Aero>.<File>(u).Value)
                Else
                    MsgBox("安装" + Aero.<Aero>.<File>(u).Value + "失败！！！", MsgBoxStyle.Exclamation)
                End If
            Else
                My.Computer.FileSystem.CopyFile(kt + "\" + Aero.<Aero>.<File>(u).Value, i + Aero.<Aero>.<File>(u).Value)
            End If
            go()
        Next u
        For q = 0 To p - 1
            la = "正在安装——" + Aero.<Aero>.<Dir>(q).Value
            If My.Computer.FileSystem.DirectoryExists(i + Aero.<Aero>.<Dir>(q).Value) = True Then
                If MsgBox("是否全部替换？" + i + Aero.<Aero>.<Dir>(q).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.DeleteDirectory(i + Aero.<Aero>.<Dir>(q).Value, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    My.Computer.FileSystem.CopyDirectory(kt + "\" + Aero.<Aero>.<Dir>(q).Value, i + Aero.<Aero>.<Dir>(q).Value)
                Else
                    MsgBox("安装" + Aero.<Aero>.<Dir>(q).Value + "失败！！！", MsgBoxStyle.Exclamation)
                End If
            Else
                My.Computer.FileSystem.CopyDirectory(kt + "\" + Aero.<Aero>.<Dir>(q).Value, i + Aero.<Aero>.<Dir>(q).Value)
            End If
            go()
        Next q
        For v = 0 To z - 1
            If Aero.<Aero>.<Run>(v).@shell = "内+外" Then
                la = "正在启动——" + i + Aero.<Aero>.<Run>(v).Value
                Shell(i + Aero.<Aero>.<Run>(v).Value, Aero.<Aero>.<Run>(v).@style)
            End If
            If Aero.<Aero>.<Run>(v).@shell = "外" Then
                la = "正在启动——" + Aero.<Aero>.<Run>(v).Value
                Shell(Aero.<Aero>.<Run>(v).Value, Aero.<Aero>.<Run>(v).@style)
            End If
            If Aero.<Aero>.<Run>(v).@shell = "外+内+外" Then
                la = "正在启动——" + TextBox2.Text + Aero.<Aero>.<Run>(v).@pro + TextBox2.Text + " " + TextBox2.Text + i + Aero.<Aero>.<Run>(v).Value + TextBox2.Text + " " + Aero.<Aero>.<Run>(v).@command
                Shell(TextBox2.Text + Aero.<Aero>.<Run>(v).@pro + TextBox2.Text + " " + TextBox2.Text + i + Aero.<Aero>.<Run>(v).Value + TextBox2.Text + " " + Aero.<Aero>.<Run>(v).@command, Aero.<Aero>.<Run>(v).@style)
            End If
            go()
        Next
        Exit Function
x:      Ase.X()
        End
    End Function
    Function go()
        a = a + (100 / y)
        If a = 100 Then
            Button1.Enabled = True
        End If
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = la
        If a >= 100 Then
            Timer1.Enabled = False
            ProgressBar1.Value = 100
        Else
            ProgressBar1.Value = a
        End If
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Ase.unmount(kt, TextBox2.Text)
        Ase.se()
        la = "安装成功！！！注：这文件不能磁盘压缩！！！"
        MsgBox("安装成功！！！注：这文件不能磁盘压缩！！！", MsgBoxStyle.Information)
        End
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\" + Aero.<Aero>.<Wav>.Value)
        Timer2.Enabled = False
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        On Error GoTo 0
        Dim Aero = XDocument.Load(My.Application.Info.DirectoryPath + "\Aero.xml")
        If Aero.<Aero>.<Web>(0).Value <> "" Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + Aero.<Aero>.<Web>(0).Value) = True Then
                aweb.wu(My.Application.Info.DirectoryPath + "\" + Aero.<Aero>.<Web>(0).Value)
                aweb.ShowDialog()
            Else
            End If
        End If
    End Sub
End Class