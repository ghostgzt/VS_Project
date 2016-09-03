Public Class QDQ
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            Dim BBB As Integer
            Dim NNN As String = ""
            Dim FFF As Integer
            TextBox2.Text = ""
            For x = 65 To 65 + CInt(TextBox6.Text)
                For y = 0 To 9
                    NNN = Char.ConvertFromUtf32(x) + Str(y).Trim
                    BBB = CInt(TextBox4.Text) + (19 * ((x - 65) * 10 + y))
                    TextBox2.Text = TextBox2.Text + vbCrLf + TextBox1.Text.Replace("BBB", Str(BBB).Trim).Replace("NNN", (NNN).Trim)
                Next
                FFF = CInt(TextBox5.Text) + (19 * ((x - 65) * 10 + 9))
            Next
            TextBox2.Text = TextBox3.Text + TextBox2.Text
            MsgBox(BBB + 19 + 13)
            TextBox2.Text = TextBox8.Text.Trim + vbCrLf + TextBox2.Text.Replace("FFF", Str(FFF).Trim) + vbCrLf + TextBox7.Text.Replace("FFF", Str(FFF).Trim).Replace("BBB", Str(BBB + 19 + 13).Trim)
            MsgBox("完成@@", MsgBoxStyle.Information, "代码生成器")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.SelectAll()
        TextBox2.Copy()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim op As New OpenFileDialog
        With op
            .FileName = ""
            .Filter = "*.XML|*.XML|*.*|*.*"
            .ShowDialog()
            If op.FileName <> "" Then
                Dim Aero = XDocument.Load(op.FileName)
                On Error Resume Next
                Dim b As Integer = Aero.<CX>.<BBB>.Value
                Dim n As Integer = Aero.<CX>.<NNN>.Value
                Dim f As Integer = Aero.<CX>.<FFF>.Value
                Dim i1 As String = Aero.<CX>.<OO>.Value.Replace("####!####", "<").Replace("****!****", ">").Replace("$$$!$$$", vbCrLf)
                Dim i2 As String = Aero.<CX>.<TT>.Value.Replace("####!####", "<").Replace("****!****", ">").Replace("$$$!$$$", vbCrLf)
                Dim i3 As String = Aero.<CX>.<YY>.Value.Replace("####!####", "<").Replace("****!****", ">").Replace("$$$!$$$", vbCrLf)
                Dim i4 As String = Aero.<CX>.<UU>.Value.Replace("####!####", "<").Replace("****!****", ">").Replace("$$$!$$$", vbCrLf)
                TextBox4.Text = b
                TextBox5.Text = n
                TextBox6.Text = f
                TextBox8.Text = i1
                TextBox3.Text = i2
                TextBox1.Text = i3
                TextBox7.Text = i4
                MsgBox("操作完成！！！", MsgBoxStyle.Information)
            End If
        End With
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Dim sp As New SaveFileDialog
        With sp
            .FileName = ""
            .Filter = "*.XML|*.XML|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                My.Computer.FileSystem.WriteAllText(sp.FileName, TextBox9.Text.Replace("QQQ", TextBox4.Text).Replace("WWW", TextBox5.Text).Replace("EEE", TextBox6.Text).Replace("RRR", TextBox8.Text.Replace("<", "####!####").Replace(">", "****!****").Replace(vbCrLf, "$$$!$$$")).Replace("TTT", TextBox3.Text.Replace("<", "####!####").Replace(">", "****!****").Replace(vbCrLf, "$$$!$$$")).Replace("YYY", TextBox1.Text.Replace("<", "####!####").Replace(">", "****!****").Replace(vbCrLf, "$$$!$$$")).Replace("UUU", TextBox7.Text.Replace("<", "####!####").Replace(">", "****!****").Replace(vbCrLf, "$$$!$$$")), False)
                MsgBox("操作完成！！！", MsgBoxStyle.Information)
            End If
        End With
    End Sub
End Class