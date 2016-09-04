Public Class nor
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Button1.Enabled = False
            TextBox3.Enabled = False
        Else
            Button1.Enabled = True
            TextBox3.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If bj = False Then
                TFR.ListBox2.Items.Remove(TextBox1.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox3.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&"))
                TFR.ListBox2.Items.Add(TextBox1.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox3.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&"))
            Else
                TFR.ListBox2.Items(TFR.ListBox2.SelectedIndices(0)) = TextBox1.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox3.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&")
            End If
            TextBox1.Text = ""
            TextBox3.Text = ""
            TFR.TextBox6.Text = ""
            TFR.changels()
            Me.Close()
        End If
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Or TextBox2.Text = "" Then
            Button2.Enabled = False
            TextBox5.Enabled = False
        Else
            Button2.Enabled = True
            TextBox5.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox4.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> TextBox2.Text Then
            If bj = False Then
                TFR.ListBox2.Items.Remove(TextBox4.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "|" + TextBox2.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox5.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&"))
                TFR.ListBox2.Items.Add(TextBox4.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "|" + TextBox2.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox5.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&"))
            Else
                TFR.ListBox2.Items(TFR.ListBox2.SelectedIndices(0)) = TextBox4.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "|" + TextBox2.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&") + "‘" + TextBox5.Text.Replace("|", "@%11259878gergeg484989%@").Replace("‘", "&^165165wgwfwf645456^&")
            End If
            TextBox4.Text = ""
            TextBox2.Text = ""
            TextBox5.Text = ""
            TFR.TextBox6.Text = ""
            TFR.changels()
            Me.Close()
        Else
            MsgBox("规则编写错误！", MsgBoxStyle.Information, "温馨提示！！！")
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox4.Text = "" Or TextBox2.Text = "" Then
            Button2.Enabled = False
            TextBox5.Enabled = False
        Else
            Button2.Enabled = True
            TextBox5.Enabled = True
        End If
    End Sub
    Private Sub nor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        bj = False
    End Sub
    Dim bj As Boolean
    Private Sub nor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox4.Text <> "" Then
            bj = True
            Button1.Text = "编辑规则"
            Button2.Text = "编辑规则"
        Else
            bj = False
            Button1.Text = "添加规则"
            Button2.Text = "添加规则"
        End If
    End Sub
End Class