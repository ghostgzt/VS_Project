Public Class Skyer
    Dim qw
    Dim hw
    Dim mw
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                run(.FileName)
            End If
        End With
    End Sub
    Function run(ByVal str As String)
        Dim fp As String = ""
        TextBox1.Text = " " + (My.Computer.FileSystem.ReadAllText(str, System.Text.Encoding.Default)).Replace(vbCrLf, "")
        TextBox5.Text = ""
k:
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        If TextBox1.Text = "" Then
            GoTo u
        End If
        Dim qian As String = ""
        Dim r = 0
        Do
            If Mid(TextBox1.Text, r + 1, Len("<IMG ")) = "<IMG " Then
                qian = Mid(TextBox1.Text, 1, r)
                TextBox2.Text = qian
            End If
            r = r + 1
        Loop Until qian <> "" Or r > TextBox1.Text.Length
        Dim k = r
        Dim hou As String = ""
        Dim im As String = ""
        Do
            If Mid(TextBox1.Text, k + 1, Len(">")) = ">" Then
                hou = (Mid(TextBox1.Text, k + 2, TextBox1.Text.Length - k))
                TextBox3.Text = hou
            End If
            k = k + 1
        Loop Until hou <> "" Or k > TextBox1.Text.Length
        If k <> r Then
            TextBox4.Text = Mid(TextBox1.Text, r, k - r + 1)
        End If

        If TextBox4.Text <> "" Then
            Dim qh As String = ""
            Dim sh As String = ""
            Dim hh As String = ""
            qw = ""
            hw = ""
            mw = ""
            rqh(TextBox4.Text, "height=", " ")
            If qw <> "" And hw <> "" And mw <> "" Then
                qh = Replace(mw, "height=", "").Trim
            End If

            qw = ""
            hw = ""
            mw = ""
            rqh(TextBox4.Text, "src=", " width=")
            If qw <> "" And hw <> "" And mw <> "" Then
                sh = Replace(mw, "src=", "").Trim
            End If
            qw = ""
            hw = ""
            mw = ""
            rqh(TextBox4.Text, "width=", ">")
            If qw <> "" And mw <> "" Then
                hh = (Replace(mw, "width=", "")).Replace(">", "").Replace("border=0", "").Trim
            End If
            If hh > 240 Then
                qh = Int(qh * (240 / hh))
                hh = 240
                Dim kb = ("<IMG height=" + qh + " " + "src=" + sh + " " + "width=" + hh + ">")
                Shell(My.Application.Info.DirectoryPath + "\PicResizer.exe " + "/Hide " + sh + " " + hh + "*" + qh, 0, True)
                TextBox4.Text = kb
            End If
        End If
        TextBox5.Text = TextBox5.Text + vbCrLf + vbCrLf + TextBox2.Text + vbCrLf + TextBox4.Text
        TextBox1.Text = TextBox3.Text
        GoTo k
u:
        On Error Resume Next
        Rename(str, str + ".OLD")
        My.Computer.FileSystem.WriteAllText(str, TextBox5.Text, False)
    End Function
    Function rqh(ByVal yuan As String, ByVal q As String, ByVal h As String)

        Dim qian As String = ""
        Dim r = 0
        Do
            If Mid(yuan, r + 1, Len(q)) = q Then
                qian = Mid(yuan, 1, r)
                qw = qian
            End If
            r = r + 1
        Loop Until qian <> "" Or r > yuan.Length
        Dim k = r
        Dim hou As String = ""
        Dim im As String = ""
        Do
            If Mid(yuan, k + 1, Len(h)) = h Then
                hou = (Mid(yuan, k + 2, yuan.Length - k))
                hw = hou
            End If
            k = k + 1
        Loop Until hou <> "" Or k > yuan.Length
        If k <> r Then
            mw = Mid(yuan, r, k - r + 1)
        End If
    End Function
End Class
