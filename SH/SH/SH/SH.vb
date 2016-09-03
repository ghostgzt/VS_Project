Public Class SH
    Dim ddc As String
    Dim te As System.Text.Encoding = System.Text.Encoding.Default
    Dim u8w As Boolean
    Dim TL As New TLQ.X
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .FileName = ""
            .Filter = "所有本文文件 *.Txt;*.Ini;*.Inf;*.MF;*.Jad;*.VB;*.VC;*.VBS;*.Java|*.txt;*.ini;*.inf;*.MF;*.jad;*.vb;*.vc;*.VBS;*.Java|All File *.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If .FileNames.Count <> 0 Then
                    MsgBox("添加了" + .FileNames.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
                    For x = 0 To OpenFileDialog1.FileNames.Count - 1
                        ListBox1.Items.Remove(OpenFileDialog1.FileNames(x))
                        ListBox1.Items.Add(OpenFileDialog1.FileNames(x))
                    Next
                End If
            End If
        End With
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        If TextBox1.Text <> "" Then
            shh()
        End If
    End Sub
    Function ttemp(ByVal vcf As String, ByVal inte As Integer)
        On Error Resume Next
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + " " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "  " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "   " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "    " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "     " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "      " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "       " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "        " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "         " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + "          " + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf + vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf + vcf + vcf + vcf, vcf)
        TextBox1.Text = Replace(Join(Split(Join(Split(TextBox1.Text, vcf & vcf), vcf), vcf & vcf), vcf), vcf & vcf, vcf)
        TextBox1.Text = TextBox1.Text.Replace(vcf + vcf, vcf)
        If Len(TextBox1.Text) <> inte And TextBox1.Text <> vcf Then
            If (TextBox1.Text.Remove(inte) = vcf) Then
                TextBox1.Text = TextBox1.Text.Remove(0, inte)
            End If
            If TextBox1.Text.Remove(0, Len(TextBox1.Text) - inte) = vcf Then
                TextBox1.Text = TextBox1.Text.Remove(Len(TextBox1.Text) - inte)
            End If
        End If
    End Function
    Function shh()
        On Error Resume Next
        ttemp(vbCr, 1)
        ttemp(vbLf, 1)
        ttemp(vbCrLf, 2)
        ttemp(vbCrLf, 1)
        ttemp(vbCr, 1)
        ttemp(vbLf, 1)
        ttemp(vbCrLf, 2)
        ttemp(vbCrLf, 1)
    End Function
    Function rg(ByVal hs As String)
        On Error Resume Next
        Dim ku = ""
        For v = 0 To Len(hs) - 1
            If Mid(hs, v + 1, 1) = "\" Then
                ku = v
            End If
        Next
        If My.Computer.FileSystem.FileExists(ddc + ".BAK") = True Then
            Kill(ddc + ".BAK")
        End If
        My.Computer.FileSystem.RenameFile(hs, hs.Remove(0, ku + 1) + ".BAK")
    End Function
    Function iuu()
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(ddc + ".BAK") = True And CheckBox2.Checked = False Then
            Dim kyf = MsgBox(ddc + ".BAK" + "已存在！是否覆盖！", MsgBoxStyle.YesNo)
            If kyf = MsgBoxResult.Yes Then
                rg(ddc)
            End If
        Else
            rg(ddc)
        End If
    End Function
    Private Sub Button3_Click() Handles Button3.Click
        If ListBox1.Text <> "" Then
            If CheckBox1.Checked = True Then
                iuu()
            End If
            My.Computer.FileSystem.WriteAllText(ddc, TextBox1.Text, False, te)
            u8ww(ddc)
            MsgBox("操作成功！！", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox1.Text <> "" Then
            With SaveFileDialog1
                .FileName = ""
                .Filter = "All File *.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(.FileName, TextBox1.Text, False, te)
                    u8ww(.FileName)
                    MsgBox("操作成功！！", MsgBoxStyle.Information)
                End If
            End With
        End If
    End Sub
    Function u8ww(ByVal st As String)
        On Error Resume Next
        If u8w = True Then
            My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP", My.Resources.UTF8, False)
            Shell(My.Computer.FileSystem.SpecialDirectories.Temp + "\$UTF8$.TMP" + " " + st)
        End If
    End Function
    Private Sub SH_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TL.Run(Me, ListBox1, Nothing, "*.Txt|*.Ini|*.Inf|*.MF|*.Jad|*.VB|*.VC|*.VBS|*.Java".ToLower, False, True)
        ComboBox1.Text = "UTF8"
        ComboBox1_SelectedIndexChanged()
        If My.Application.CommandLineArgs.Count <> 0 Then
            Me.Hide()
            Me.ShowInTaskbar = False
            For m = 0 To My.Application.CommandLineArgs.Count - 1
                ListBox1.Items.Add(My.Application.CommandLineArgs(m).Trim)
            Next
            MsgBox("处理" + My.Application.CommandLineArgs.Count.ToString + "个文件！！！", MsgBoxStyle.Information)
            If ListBox1.Items.Count <> 0 Then
                BX.ShowDialog()
                ComboBox1.Text = BX.TextBox1.Text
                CheckBox1.Checked = BX.CheckBox1.Checked
                Button8_Click()
            End If
            End
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ListBox1.Items.Remove(ListBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Function trik(ByVal yy As Boolean)
        On Error Resume Next
        Button1.Enabled = yy
        Button2.Enabled = yy
        Button3.Enabled = yy
        Button4.Enabled = yy
        Button5.Enabled = yy
        Button6.Enabled = yy
        Button7.Enabled = yy
        Button8.Enabled = yy
        TextBox1.Enabled = yy
        ListBox1.Enabled = yy
    End Function
    Private Sub Button8_Click() Handles Button8.Click
        If ListBox1.Items.Count <> 0 Then
            trik(False)
            For x = 0 To ListBox1.Items.Count - 1
                ListBox1.SetSelected(x, True)
                ddc = ListBox1.Text
                TextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te)
                shh()
                If CheckBox1.Checked = True Then
                    iuu()
                End If
                My.Computer.FileSystem.WriteAllText(ddc, TextBox1.Text, False, te)
                u8ww(ddc)
            Next
            trik(True)
            MsgBox("操作成功！！", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub ListBox1_Click() Handles ListBox1.Click
        If ListBox1.Text <> "" Then
            TextBox1.Text = ""
            TextBox1.Text = My.Computer.FileSystem.ReadAllText(ListBox1.Text, te)
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ddc = ListBox1.Text
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged() Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Default" Then
            te = System.Text.Encoding.Default
            u8w = False
        End If
        If ComboBox1.Text = "ASCII" Then
            te = System.Text.Encoding.ASCII
            u8w = False
        End If
        If ComboBox1.Text = "Unicode" Then
            te = System.Text.Encoding.Unicode
            u8w = False
        End If
        If ComboBox1.Text = "UTF8" Then
            te = System.Text.Encoding.UTF8
            u8w = False
        End If
        If ComboBox1.Text = "UTF8 WOB" Then
            te = System.Text.Encoding.UTF8
            u8w = True
        End If
        ListBox1_Click()
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = True
        Else
            CheckBox2.Enabled = False
        End If
    End Sub
End Class