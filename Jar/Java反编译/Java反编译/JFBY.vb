Public Class JFBY
    Dim nn
    Dim comm
    Dim sf
    Function del()
        On Error Resume Next
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JJD.tmp")
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "Class *.Class|*.Class"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        ListBox1.Items.Remove(OpenFileDialog1.FileNames(x).Trim)
                        ListBox1.Items.Add(OpenFileDialog1.FileNames(x).Trim)
                    Next
                End If
            End If
        End With
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                TextBox2.Text = .SelectedPath
            End If
        End With
    End Sub
    Function gett()
        On Error Resume Next
        If ListBox1.Text <> "" Then
            Dim ko = ""
            For x = 0 To Len(ListBox1.Text) - 1
                If Mid(ListBox1.Text, x + 1, 1) = "\" Then
                    ko = x
                End If
            Next
            Dim kk = (ListBox1.Text.Remove(0, ko + 1))
            nn = (kk.Remove(Len(kk) - 6))
        End If
    End Function
    Function run()
        On Error Resume Next
        If ListBox1.Items.Count <> 0 And TextBox2.Text <> "" Then
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JJD.tmp") = False Then
                My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JJD.tmp", My.Resources.jad, False)
            End If
            For x = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(x, True)
                If comm <> "" Then
                    mk()
                End If
                If My.Computer.FileSystem.FileExists(TextBox2.Text + "\" + nn + ".jad") = True Then
                    Kill(TextBox2.Text + "\" + nn + ".jad")
                End If
                Shell(TextBox4.Text + My.Computer.FileSystem.SpecialDirectories.Temp + "\$JJD.tmp" + TextBox4.Text + " -dead -8 -d" + TextBox4.Text + TextBox2.Text + TextBox4.Text + " -o " + TextBox4.Text + ListBox1.Text + TextBox4.Text, AppWinStyle.Hide, True)
                If My.Computer.FileSystem.FileExists(TextBox2.Text + "\" + nn + ".jad") = True Then
                    If My.Computer.FileSystem.FileExists(TextBox2.Text + "\" + nn + ".java") = True Then
                        Kill((TextBox2.Text + "\" + nn + ".java"))
                    End If
                    My.Computer.FileSystem.RenameFile(TextBox2.Text + "\" + nn + ".jad", nn + ".java")
                    Dim bo = My.Computer.FileSystem.ReadAllText(TextBox2.Text + "\" + nn + ".java", System.Text.Encoding.Default)
                    My.Computer.FileSystem.WriteAllText(TextBox2.Text + "\" + nn + ".java", bo.Replace(TextBox5.Text, ""), False, System.Text.Encoding.Default)
                End If
            Next
        End If
    End Function
    Private Sub Button3_Click() Handles Button3.Click
        run()
    End Sub
    Function mk()
        On Error Resume Next
        Dim bd = ""
        For z = 0 To Len(ListBox1.Text) - 1
            If Mid(ListBox1.Text, z + 1, 1) = "\" Then
                bd = z
            End If
        Next
        If My.Computer.FileSystem.DirectoryExists((sf + ListBox1.Text.Remove(bd).Replace(comm, ""))) = False Then
            MkDir((sf + ListBox1.Text.Remove(bd).Replace(comm, "")))
            TextBox2.Text = sf + ListBox1.Text.Remove(bd).Replace(comm, "")
        End If
    End Function
    Function ar()
        run()
        MsgBox("操作完成！！！" + vbCrLf + "输出到:" + vbCrLf + sf, MsgBoxStyle.Information)
        End
    End Function
    Private Sub JFBY_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        del()
    End Sub
    Private Sub JFBY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Application.CommandLineArgs.Count = 1 And My.Application.CommandLineArgs(0).Replace(TextBox1.Text, "").Trim.Remove(0, Len(My.Application.CommandLineArgs(0).Replace(TextBox1.Text, "").Trim) - 6).ToLower <> ".class" And My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs(0)) = True Then
                comm = My.Application.CommandLineArgs(0).Replace(TextBox1.Text, "").Trim
                With FolderBrowserDialog1
                    .SelectedPath = ""
                    .ShowNewFolderButton = True
                    .ShowDialog()
                    If .SelectedPath <> "" Then
                        Dim v = My.Computer.FileSystem.GetFiles(My.Application.CommandLineArgs(0), FileIO.SearchOption.SearchAllSubDirectories, "*.class")
                        If v.Count <> 0 Then
                            For x = 0 To v.Count - 1
                                ListBox1.Items.Add(v(x))
                            Next
                        End If
                        TextBox2.Text = .SelectedPath
                        sf = .SelectedPath
                        ar()
                    Else
                        del()
                        End
                    End If
                End With
            Else
                For m = 0 To My.Application.CommandLineArgs.Count - 1
                    ListBox1.Items.Add(My.Application.CommandLineArgs(m))
                Next
                If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$") = False Then
                    MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$")
                End If
                TextBox2.Text = My.Computer.FileSystem.SpecialDirectories.Temp + "\$JT$"
                run()
                del()
                End
            End If
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        gett()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.Text)
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub
End Class