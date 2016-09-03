Public Class MF
    Dim tmppath As String
    Dim mouseOffset
    Private Sub OK_Button_Click() Handles OK_Button.Click
        If MsgBox("确定修改？！", MsgBoxStyle.YesNo, "温馨提示！！！") = MsgBoxResult.Yes Then
            Jar.TextBox4.Text = TextBox1.Text
            Jar.listcls0()
            Jar.read()
            Jar.XB(False)
        End If
        Me.Close()
    End Sub
    Private Sub MF_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Mini.Show()
    End Sub
    Private Sub MF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Mini.Hide()
        Me.Text = "MF修改查看器-" + Jar.Retoqqq
        Me.Opacity = Jar.Opacity
        Me.Refresh()
        TextBox1.Text = ""
        TextBox1.Text = Jar.TextBox4.Text
        tmppath = Jar.TextBox9.Text
        If My.Computer.FileSystem.FileExists(tmppath + "\META-INF\MANIFEST.MF") = False Then
            Button3.Enabled = False
        Else
            Button3.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(tmppath + "\META-INF\MANIFEST.MF.BAK") = False Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox2.Text
    End Sub
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        mouseOffset = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        With Jar.OpenFileDialog1
            .FileName = ""
            .Filter = "*.MF|*.MF|*.TXT|*.TXT"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = (My.Computer.FileSystem.ReadAllText(.FileName, System.Text.Encoding.UTF8))
                TextBox1.Text = TextBox1.Text.Replace(vbLf, vbCrLf)
                Jar.ttemp(TextBox1.Text, vbCr, 1)
                Jar.ttemp(TextBox1.Text, vbLf, 1)
                Jar.ttemp(TextBox1.Text, vbCrLf, 2)
                Jar.ttemp(TextBox1.Text, vbCrLf, 1)
            End If
        End With
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.Text = My.Computer.FileSystem.ReadAllText(tmppath + "\META-INF\MANIFEST.MF", System.Text.Encoding.UTF8)
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Text = My.Computer.FileSystem.ReadAllText(tmppath + "\META-INF\MANIFEST.MF.BAK", System.Text.Encoding.UTF8)
    End Sub
    Function ttemp(ByVal textboxx As String, ByVal vcf As String, ByVal inte As Integer)
        On Error Resume Next
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf + vcf + vcf, vcf)
        TextBox1.Text = Replace(Join(Split(Join(Split(TextBox1.Text, vcf & vcf), vcf), vcf & vcf), vcf), vcf & vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf, vcf)
        If (TextBox1.Text.Remove(1) = vcf) Then
            TextBox1.Text = TextBox1.Text.Remove(0, 1)
        End If
        If TextBox1.Text.Remove(0, Len(TextBox1.Text) - 1) = vcf Then
            TextBox1.Text = TextBox1.Text.Remove(Len(TextBox1.Text) - 1)
        End If
        Return TextBox1.Text
    End Function
    Function delrow()
        ttemp(TextBox1.Text, vbCr, 1)
        ttemp(TextBox1.Text, vbLf, 1)
        ttemp(TextBox1.Text, vbCrLf, 2)
        ttemp(TextBox1.Text, vbCrLf, 1)
    End Function
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        delrow()
        delrow()
        TextBox1.Text = TextBox1.Text.Replace(vbCr, "").Replace(vbLf, vbCrLf).Replace(vbCrLf + vbCrLf, vbCrLf).Trim
        TextBox1.Text = TextBox1.Text.Replace(vbCrLf + " ", "")
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        On Error Resume Next
        Shell("Notepad " + tmppath + "\META-INF\MANIFEST.MF", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub 繁转简ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 繁转简ToolStripMenuItem.Click
        TextBox1.Text = StrConv(TextBox1.Text, VbStrConv.SimplifiedChinese)
    End Sub
    Private Sub 简转繁ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 简转繁ToolStripMenuItem.Click
        TextBox1.Text = StrConv(TextBox1.Text, VbStrConv.TraditionalChinese)
    End Sub
    Private Sub 复制ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 复制ToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub
    Private Sub 剪切ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪切ToolStripMenuItem.Click
        TextBox1.Cut()
    End Sub
    Private Sub 粘贴ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 粘贴ToolStripMenuItem.Click
        TextBox1.Paste()
    End Sub
    Function bz(ByVal textboxx As TextBox)
        With textboxx
            .Text = .Text.Replace("midlet-name:", "MIDlet-Name:")
            .Text = .Text.Replace("midlet-icon:", "MIDlet-Icon:")
            .Text = .Text.Replace("midlet-1:", "MIDlet-1:")
            .Text = .Text.Replace("midlet-vendor:", "MIDlet-Vendor:")
            .Text = .Text.Replace("midlet-version:", "MIDlet-Version:")
            .Text = .Text.Replace("midlet-install-notify:", "MIDlet-Install-Notify:")
            .Text = .Text.Replace("midlet-info-url:", "MIDlet-Info-URL:")
            .Text = .Text.Replace("midlet-description:", "MIDlet-Description:")
            .Text = .Text.Replace("midlet-data-size:", "MIDlet-Data-Size:")
            .Text = .Text.Replace("manifest-version:", "Manifest-Version:")
            .Text = .Text.Replace("microedition-configuration:", "MicroEdition-Configuration:")
            .Text = .Text.Replace("microedition-profile:", "MicroEdition-Profile:")
            .Text = .Text.Replace("midlet-permissions:", "MIDlet-Permissions:")
            .Text = .Text.Replace("midlet-permissions-opt:", "MIDlet-Permissions-Opt:")
            .Text = .Text.Replace("midlet-", "MIDlet-")
        End With
    End Function
    Private Sub 标准化ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 标准化ToolStripMenuItem.Click
        bz(TextBox1)
    End Sub
    Private Sub 全选ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选ToolStripMenuItem.Click
        TextBox1.SelectAll()
    End Sub
End Class