Public Class MP3
    Dim ss As New SpeechLib.SpVoice
    Function di(ByVal str As String)
        On Error Resume Next
        Dim ddc As String = str
        If My.Computer.FileSystem.FileExists(ddc + "\LY.xml") = False Then
            ddc = My.Application.Info.DirectoryPath
        End If
        Dim Aero = XDocument.Load(ddc + "\LY.xml")
        ListView1.Items.Clear()
        For x = 0 To CInt(Aero.<Aero>.<FileNum>.Value) - 1
            Dim knn As String = nn(Aero.<Aero>.<Files>.<File>(x).<Num>.Value.Trim)
            Dim kpp As String = Aero.<Aero>.<Files>.<File>(x).<Path>.Value.Replace("*\*/*", "&")
            Dim kss As String = Aero.<Aero>.<Files>.<File>(x).<Size>.Value.Replace("*\*/*", "&")
            ListView1.Items.Add(knn, x)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kpp)
            ListView1.Items.Item(ListView1.Items.Count - 1).SubItems.Add(kss)
        Next
        ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Function
    Function nn(ByVal ts As String)
        While Len(ts.Trim) < 3
            ts = "0" + ts
        End While
        Return ts
    End Function
    Dim hht As String
    Private Sub MP3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Button2_Click()
    End Sub
    Private Sub MP3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ss.Speak("Hello Who f ,Welcome To Use LiYang Crazy English 365 Which Made By GhostGzt For Dear Who f Friends", SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
        SplashScreen.ShowDialog()
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "001.mp3") = True Then
            Dim oo As New FolderBrowserDialog
            With oo
                .SelectedPath = ""
                hht = ""
                .Description = "Choose A Path Of LY.XML"
                .ShowDialog()
                If .SelectedPath <> "" Then
                    hht = .SelectedPath
                    di(.SelectedPath)
                Else
                    MsgBox("已设置在程序目录！", MsgBoxStyle.Information, "LiYang Crazy English 365")
                    hht = My.Application.Info.DirectoryPath
                    If My.Computer.FileSystem.FileExists(hht + "\LY.xml") = False Then
                        My.Computer.FileSystem.WriteAllText(hht + "\LY.xml", My.Resources.ly, False)
                    End If
                    di(hht)
                End If
            End With
        Else
            Button1.Visible = False
            hht = My.Application.Info.DirectoryPath
            If My.Computer.FileSystem.FileExists(hht + "\LY.xml") = False Then
                My.Computer.FileSystem.WriteAllText(hht + "\LY.xml", My.Resources.ly, False)
            End If
            di(hht)
        End If
    End Sub
    Function run()
        On Error Resume Next
        Dim path = hht
        Dim tts As String = TextBox1.Text
        For x = 0 To ListView1.Items.Count - 1
            My.Computer.FileSystem.RenameFile(path + "\" + ListView1.Items.Item(x).Text + ".mp3", ListView1.Items.Item(x).SubItems(0).Text + "." + ListView1.Items.Item(x).SubItems(1).Text.Replace("?", "").Replace(".", "") + ".mp3")
            My.Computer.FileSystem.WriteAllText(path + "\" + ListView1.Items.Item(x).SubItems(0).Text + "." + ListView1.Items.Item(x).SubItems(1).Text.Replace("?", "").Replace(".", "") + ".LRC", tts.Replace("#E#", ListView1.Items.Item(x).SubItems(1).Text).Replace("#C#", ListView1.Items.Item(x).SubItems(2).Text), False, System.Text.Encoding.Default)
        Next
        MsgBox("Successful！！！", MsgBoxStyle.Information, "Success！！！")
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        run()
    End Sub
    Private Sub ListView1_SelectedIndexChanged() Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        ss.Speak(ListView1.SelectedItems.Item(0).SubItems(1).Text, SpeechLib.SpeechVoiceSpeakFlags.SVSFlagsAsync)
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        MsgBox("Made By GhostGzt In 2010" + vbCrLf + "一中灰太羊永不磨咩！", MsgBoxStyle.Information, "LiYang Crazy English 365")
        End
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListView1_SelectedIndexChanged()
    End Sub
End Class