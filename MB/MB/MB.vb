Imports System.Xml
Public Class MB
    Private Sub Form1_FormClosing() Handles Me.FormClosing
        Button4_Click()
    End Sub
    Function ko()
        ComboBox1.Items.Clear()
        Try
            For o = 0 To DataGridView1.RowCount - 2
                ComboBox1.Items.Add(o)
            Next o
        Catch
        End Try
    End Function
    Private Sub Form1_Load() Handles MyBase.Load
        On Error GoTo u
        Me.SkyTableAdapter.Fill(Me.SkyDataSet.Sky)
        ko()
        empty()
        Exit Sub
u:      u()
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        On Error GoTo u
        Dim k = SkyDataSet.Sky.NewRow
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "*.*|*.*"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Dim l = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)
            k.Item(2) = l
            k.Item(1) = OpenFileDialog1.FileName
            SkyDataSet.Sky.Rows.Add(k)
        End If
        save()
        empty()
        ko()
        button5_Click()
        Exit Sub
u:      u()
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        On Error GoTo u
        If ComboBox1.Text <> "" Then
            Dim l As Integer = ComboBox1.Text
            If SkyDataSet.Sky(l)._Byte.Length <> 0 Then
                SaveFileDialog1.FileName = ""
                SaveFileDialog1.Filter = "*.*|*.*"
                SaveFileDialog1.ShowDialog()
                TextBox1.Text = ""
                If SaveFileDialog1.FileName <> "" Then
                    My.Computer.FileSystem.WriteAllBytes(SaveFileDialog1.FileName, SkyDataSet.Sky(l)._Byte, False)
                    op()
                End If
            End If
        Else
            MsgBox("请选择行！", MsgBoxStyle.Information)
        End If
        ko()
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    Private Sub Button3_Click() Handles Button3.Click
        If ComboBox1.Text = "" Then
           MsgBox("请选择行！！！", MsgBoxStyle.Information)
        Else
          row_remove()
            ko()
            save()
        End If
        empty()
        button5_Click()
    End Sub
    Function row_remove()
        On Error GoTo x
        DataGridView1.Refresh()
        DataGridView1.Rows.RemoveAt(ComboBox1.Text)
        SkyTableAdapter.Delete(ComboBox1.Text, TextBox1.Text)
        SkyDataSet.Sky(ComboBox1.Text).Delete()
        MsgBox("Success！！！", MsgBoxStyle.Information)
        Exit Function
x:      MsgBox(ErrorToString)
    End Function
    Function op()
        MsgBox("Save Sucessed！！！", MsgBoxStyle.Information)
    End Function
    Private Sub Button4_Click() Handles Button4.Click
        On Error GoTo u
        save()
        NotifyIcon1.Icon = Nothing
        op()
        End
        Exit Sub
u:      u()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error GoTo u
        TextBox1.Text = SkyDataSet.Sky(ComboBox1.Text).Name
        Exit Sub
u:      TextBox1.Text = ""
    End Sub
    Private Sub button5_Click() Handles button5.Click
        Form1_Load()
        DataGridView1.RefreshEdit()
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        button5_Click()
    End Sub
    Private Sub 新增数据ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新增数据ToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub 删除记录ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除记录ToolStripMenuItem.Click
        Button3_Click()
    End Sub
    Private Sub SaveQuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveQuitToolStripMenuItem.Click
        Button4_Click()
    End Sub
    Function u()
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        button5_Click()
    End Function
    Function save()
        SkyBindingSource.EndEdit()
        SkyTableAdapter.Update(SkyDataSet.Sky)
    End Function
    Private Sub Button6_Click() Handles Button6.Click
        If ComboBox1.Text <> "" Then
            If TextBox1.Text <> "" Then
                SkyDataSet.Sky(ComboBox1.Text).Name = TextBox1.Text
                save()
                button5_Click()
            Else
                MsgBox("名称不能空！！！", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("请选择行！", MsgBoxStyle.Information)
        End If
    End Sub
    Function empty()
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "*.gf|*.gf"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            If MsgBox("本程序的名称是否还是——My Byte.exe？？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Choose_Me.TextBox1.Text = "My Byte.exe"
            Else
                Choose_Me.FileListBox1.Path = My.Application.Info.DirectoryPath
                Choose_Me.ShowDialog()
            End If
            If Choose_Me.TextBox1.Text <> "" Then
                TextBox3.Text = "<?xml version=" + TextBox2.Text + "1.0" + TextBox2.Text + " encoding=" + TextBox2.Text + "utf-8" + TextBox2.Text + " ?>" + vbCrLf + _
        "<configuration>" + vbCrLf + _
        "    <connectionStrings>" + vbCrLf + _
        "        <add name=" + TextBox2.Text + "My_Byte.My.MySettings.SkyConnectionString" + TextBox2.Text + " connectionString=" + TextBox2.Text + "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + OpenFileDialog1.FileName + TextBox2.Text + vbCrLf + _
        "            providerName=" + TextBox2.Text + "System.Data.OleDb" + TextBox2.Text + " />" + vbCrLf + _
        "    </connectionStrings>" + vbCrLf + _
        "</configuration>"
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\" + Choose_Me.TextBox1.Text + ".config", TextBox3.Text, False)
                MsgBox("Sucessed！！！,请重新启动！", MsgBoxStyle.Information)
            Else
                MsgBox("Replace database failure！！！", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button8.Click
        If MsgBox("你确定还原原本数据库路径", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If MsgBox("本程序的名称是否还是——My Byte.exe？？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Choose_Me.TextBox1.Text = "My Byte.exe"
            Else
                Choose_Me.FileListBox1.Path = My.Application.Info.DirectoryPath
                Choose_Me.ShowDialog()
            End If
            If Choose_Me.TextBox1.Text <> "" Then
                On Error GoTo u
                Kill(My.Application.Info.DirectoryPath + "\" + Choose_Me.TextBox1.Text + ".config")
                MsgBox("Sucessed！！！,请重新启动！", MsgBoxStyle.Information)
            End If
        End If
        Exit Sub
u:      u()
    End Sub
    Private Sub Button9_Click() Handles Button9.Click
        Try
            If ComboBox1.Text <> "" Then
                OpenFileDialog1.FileName = ""
                OpenFileDialog1.Filter = "*.*|*.*"
                OpenFileDialog1.ShowDialog()
                If OpenFileDialog1.FileName <> "" Then
                    Dim k = My.Computer.FileSystem.ReadAllBytes(OpenFileDialog1.FileName)
                    Dim v As Integer = ComboBox1.Text
                    SkyDataSet.Sky(v)._Byte = k
                    TextBox1.Text = OpenFileDialog1.FileName
                    Button6_Click()
                End If
                save()
                ko()
            Else
                MsgBox("请选择行！", MsgBoxStyle.Information)
            End If
        Catch
        End Try
        empty()
        button5_Click()
    End Sub
    Private Sub 更新名称ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 更新名称ToolStripMenuItem.Click
        Button6_Click()
    End Sub
    Private Sub 更新数据ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 更新数据ToolStripMenuItem.Click
        Button9_Click()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Shell(My.Application.Info.DirectoryPath + "\AccessRepair.exe " + My.Application.Info.DirectoryPath + "\Sky.gf", AppWinStyle.NormalFocus)
    End Sub
End Class