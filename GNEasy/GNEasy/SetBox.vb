Imports System.Windows.Forms
Public Class SetBox
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        GNE.ZQText.Text = ZQText.Text
        GNE.ZHText.Text = ZHText.Text
        GNE.XLTHText.Text = XLTHText.Text
        GNE.XLYText.Text = XLYText.Text
        GNE.XLZText.Text = XLZText.Text
        GNE.ZTHHText.Text = ZTHHText.Text
        GNE.ZTHYText.Text = ZTHYText.Text
        GNE.KTHHText.Text = KTHHText.Text
        GNE.KZText.Text = KZText.Text
        GNE.PXCom.Text = PXCom.Text
        If PXKQ.Checked = True Then
            GNE.PXKQ.Checked = True
            GNE.PXCom.Enabled = True
        Else
            GNE.PXKQ.Checked = False
            GNE.PXCom.Enabled = False
        End If
        If CheckBox5.Checked = True Then
            GNE.开启ToolStripMenuItem4.Checked = True
            GNE.KTHHText.Enabled = True
        Else
            GNE.开启ToolStripMenuItem4.Checked = False
            GNE.KTHHText.Enabled = False
        End If
        If CheckBox6.Checked = True Then
            GNE.开启ToolStripMenuItem5.Checked = True
            GNE.KZText.Enabled = True
        Else
            GNE.开启ToolStripMenuItem5.Checked = False
            GNE.KZText.Enabled = False
        End If
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub
    Private Sub ZQText_TextChange() Handles ZQText.TextChanged
        If ZQText.Text <> "" Or ZHText.Text <> "" Then
            CheckBox1.Checked = True
            CheckBox1.Enabled = True
        Else
            CheckBox1.Checked = False
            CheckBox1.Enabled = False
        End If
    End Sub
    Private Sub ZHText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZHText.TextChanged
        ZQText_TextChange()
    End Sub
    Private Sub XLYText_TextChanged() Handles XLYText.TextChanged
        If XLTHText.Text <> "0" Or XLYText.Text <> "" Then
            CheckBox2.Checked = True
            CheckBox2.Enabled = True
        Else
            CheckBox2.Checked = False
            CheckBox2.Enabled = False
        End If
    End Sub
    Private Sub XLTHText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XLTHText.TextChanged
        On Error GoTo y
        Dim c = CInt(XLTHText.Text)
        If c < 0 Then
            GoTo y
        End If
        XLYText_TextChanged()
        Exit Sub
y:      XLTHText.Text = "0"
        XLYText_TextChanged()
    End Sub
    Private Sub ZTHYText_TextChanged() Handles ZTHYText.TextChanged
        If ZTHHText.Text <> "" Or ZTHYText.Text <> "" Then
            CheckBox3.Checked = True
            CheckBox3.Enabled = True
        Else
            CheckBox3.Checked = False
            CheckBox3.Enabled = False
        End If
    End Sub
    Private Sub ZTHHText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZTHHText.TextChanged
        ZTHYText_TextChanged()
    End Sub
    Private Sub KZText_TextChanged() Handles KZText.TextChanged
        If KTHHText.Text <> "" Or KZText.Text <> "" Then
            CheckBox4.Checked = True
            CheckBox4.Enabled = True
        Else
            CheckBox4.Checked = False
            CheckBox4.Enabled = False
        End If
    End Sub
    Private Sub KTHHText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KTHHText.TextChanged
        KZText_TextChanged()
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox5.Checked = False
            KTHHText.Enabled = False
            KZText.Enabled = True
        Else
            CheckBox5.Checked = True
            KTHHText.Enabled = True
            KZText.Enabled = False
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox6.Checked = False
            KTHHText.Enabled = True
            KZText.Enabled = False
        Else
            CheckBox6.Checked = True
            KTHHText.Enabled = False
            KZText.Enabled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ZQText.Text = ""
            ZHText.Text = ""
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = False Then
            XLTHText.Text = ""
            XLYText.Text = ""
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = False Then
            ZTHHText.Text = ""
            ZTHYText.Text = ""
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = False Then
            KTHHText.Text = ""
            KZText.Text = ""
        End If
    End Sub
    Private Sub SetBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ZQText.Text = GNE.ZQText.Text
        ZHText.Text = GNE.ZHText.Text
        XLTHText.Text = GNE.XLTHText.Text
        XLYText.Text = GNE.XLYText.Text
        XLZText.Text = GNE.XLZText.Text
        ZTHHText.Text = GNE.ZTHHText.Text
        ZTHYText.Text = GNE.ZTHYText.Text
        KTHHText.Text = GNE.KTHHText.Text
        KZText.Text = GNE.KZText.Text
        If GNE.开启ToolStripMenuItem4.Checked = True Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
        If GNE.PXKQ.Checked = True Then
            PXKQ.Checked = True
        Else
            PXKQ.Checked = False
        End If
        PXCom.Text = GNE.PXCom.Text
    End Sub
    Private Sub XLZText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XLZText.TextChanged
        If XLZText.Text = "" Then
            XLZText.Text = "0"
        End If
        XLYText_TextChanged()
    End Sub
    Private Sub PXKQ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PXKQ.CheckedChanged
        If PXKQ.Checked = True Then
            PXCom.Enabled = True
        Else
            PXCom.Enabled = False
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            If RadioButton1.Checked = True Then
                GNE.FT.Checked = True
            Else
                GNE.JT.Checked = True
            End If
        Else
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            GNE.JT.Checked = False
            GNE.FT.Checked = False
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            RadioButton2.Checked = False
            GNE.FT.Checked = True
        Else
            RadioButton2.Checked = True
            GNE.JT.Checked = True
        End If
    End Sub
End Class