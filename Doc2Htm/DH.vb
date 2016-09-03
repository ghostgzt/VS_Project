Public Class DH
    Dim tl As New TLQ.X
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .Multiselect = True
            .FileName = ""
            .Filter = "Doc文档 *.doc;Rtf文档 *.rtf;本文文档 *.txt;网页 *.htm,*.html|*.doc;*.rtf;*.txt;*.htm;*.html|All Files *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                For x = 0 To .FileNames.Count - 1
                    ListBox1.Items.Add(.FileNames(x))
                Next
                MsgBox("Added " + CStr(.FileNames.Count).Trim + " Files！", MsgBoxStyle.Information)
            End If
        End With
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndices.Count <> 0 Then
            For x = 0 To ListBox1.SelectedIndices.Count - 1
                ListBox1.Items.Remove(ListBox1.SelectedItems(0))
            Next
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox1.Items.Count <> 0 Then
            With FolderBrowserDialog1
                .SelectedPath = ""
                .ShowNewFolderButton = True
                .Description = "Choose The Output Path Please！"
                .ShowDialog()
                If .SelectedPath <> "" Then
                    doit(.SelectedPath)
                End If
            End With
        End If
    End Sub
    Function doit(ByVal y As String)
        On Error Resume Next
        Me.Hide()
        With NotifyIcon1
            .BalloonTipText = "转换中..."
            .BalloonTipIcon = ToolTipIcon.Info
            .ShowBalloonTip(1000)
            .Visible = True
            For x = 0 To ListBox1.Items.Count - 1
                .BalloonTipText = "转换中..." + CStr(x + 1).Trim + "/" + CStr(ListBox1.Items.Count).Trim
                .ShowBalloonTip(1000)
                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\$d2h.js", My.Resources.JS.Replace("XXX", CStr(gs).Trim).Replace("III", ListBox1.Items(x).ToString.Replace("\", "/")).Replace("OOO", (y.Trim + "/" + ListBox1.Items(x).ToString.Split("\")(ListBox1.Items(x).ToString.Split("\").LongCount - 1)).Replace("\", "/").Split(".")(0) + "." + gsm), False, System.Text.Encoding.Default)
                Shell("wscript.exe " + My.Resources.mh + My.Computer.FileSystem.SpecialDirectories.Temp + "\$d2h.js" + My.Resources.mh, AppWinStyle.NormalFocus, True)
            Next
            MsgBox("转换完成！！！", MsgBoxStyle.Information, "温馨提示！！！")
            .Visible = False
        End With
        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\$d2h.js")
        Me.Show()
    End Function
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub DH_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComboBox1.SelectedIndex = 3
        tl.Run(ListBox1, ListBox1, Nothing, "*.doc|*.rtf|*.txt|*.htm|*.html", False, False)
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        On Error Resume Next
        Shell("Rundll32.exe url.dll, FileProtocolHandler " + ListBox1.Text, AppWinStyle.NormalFocus, True)
    End Sub
    Dim gs As Integer = 8
    Dim gsm As String = "Htm"
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            gs = 1
            gsm = "Doc"
        End If
        If ComboBox1.SelectedIndex = 1 Then
            gs = 11
            gsm = "Xml"
        End If
        If ComboBox1.SelectedIndex = 2 Then
            gs = 9
            gsm = "Mht"
        End If
        If ComboBox1.SelectedIndex = 3 Then
            gs = 8
            gsm = "Htm"
        End If
        If ComboBox1.SelectedIndex = 4 Then
            gs = 10
            gsm = "Html"
        End If
        If ComboBox1.SelectedIndex = 5 Then
            gs = 6
            gsm = "Rtf"
        End If
        If ComboBox1.SelectedIndex = 6 Then
            gs = 2
            gsm = "Txt"
        End If
    End Sub
End Class