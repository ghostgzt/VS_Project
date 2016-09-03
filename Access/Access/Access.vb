Public Class Access
    Public cn As System.Data.OleDb.OleDbConnection
    Public cmd As System.Data.OleDb.OleDbDataAdapter
    Public ds As New System.Data.DataSet()
    Dim k = My.Computer.FileSystem.SpecialDirectories.Temp
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error GoTo u
        If TextBox3.Text <> "" Then
            OpenFileDialog1.Filter = "*.mdb|*.mdb|*.*|*.*"
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                TextBox1.Text = OpenFileDialog1.FileName
                reading(OpenFileDialog1.FileName)
                TextBox1.Text = OpenFileDialog1.FileName
            End If
            wxml()
        Else
            MsgBox("请输入表名称！！！", MsgBoxStyle.Information)
        End If
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
        bb("")
    End Sub
    Function bb(ByVal k As String)
        If k = "" Then
            TextBox3.Text = ""
        Else
        End If
        PictureBox1.Image = Nothing
        TextBox1.Text = ""
        ComboBox3.Text = ""
        ComboBox2.Text = ""
        TextBox2.Text = ""
        TextBox2.Enabled = False
        Button4.Visible = False
        Button1.Enabled = False
        TextBox4.Text = ""
        CheckBox1.Checked = False
        CheckBox1.Visible = False
        ComboBox3.Enabled = False
        ComboBox2.Enabled = False
        Button3.Enabled = False
        PictureBox2.Visible = False
    End Function
    Function reading(ByVal path As String)
        cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" + path)
        cmd = New System.Data.OleDb.OleDbDataAdapter("select * from " + TextBox3.Text, cn)
        cn.Open()
        ds.Clear()
        ds.Reset()
        cmd.Fill(ds)
        cn.Close()
        bb("f")
        TextBox1.Text = OpenFileDialog1.FileName
        ComboBox2.Items.Clear()
        For p = 1 To ds.Tables(0).Columns.Count
            ComboBox2.Items.Add(p)
        Next p
        ComboBox2.Enabled = True
        Button3.Enabled = True
        PictureBox2.Visible = True
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox3_SelectedIndexChanged()
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged() Handles ComboBox3.SelectedIndexChanged
        On Error Resume Next
        Dim w As Integer = ComboBox2.Text - 1
        Dim b As Integer = ComboBox3.Text - 1
        On Error GoTo u
        If ds.Tables(0).Columns(w).DataType.ToString <> "System.Byte[]" Then
            Dim k = ds.Tables(0).Rows.Item(b).Item(w)
            TextBox2.Text = k
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
            TextBox2.Text = ds.Tables(0).Columns(w).DataType.ToString
        End If
        If TextBox2.Text <> "" Then
            Button1.Enabled = True
        Else
            CheckBox1.Visible = False
            CheckBox1.Checked = False
            PictureBox1.Image = Nothing
        End If
        If TextBox2.Enabled <> True Then
            CheckBox1.Visible = True
            CheckBox1.Checked = False
            PictureBox1.Image = Nothing
        End If
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
        TextBox2.Text = ""
        Button1.Enabled = False
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Items.Clear()
        For o = 1 To ds.Tables(0).Rows.Count
            ComboBox3.Items.Add(o)
        Next o
        ComboBox3.Enabled = True
        If ComboBox3.Text <> "" Then
            ComboBox3_SelectedIndexChanged()
        End If
        TextBox2.Enabled = True
        TextBox2.Text = ""
        CheckBox1.Visible = False
        CheckBox1.Checked = False
        PictureBox1.Image = Nothing
        Dim k As Integer = ComboBox2.Text - 1
        TextBox4.Text = ds.Tables(0).Columns(k).ColumnName
        Button1.Enabled = False
    End Sub
    Private Sub Button1_Click() Handles Button1.Click
        On Error GoTo u
        Dim w As Integer = ComboBox3.Text - 1
        Dim b As Integer = ComboBox2.Text - 1
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "*.*|*.*"
        SaveFileDialog1.ShowDialog()
        If ds.Tables(0).Columns(b).DataType.ToString <> "System.Byte[]" Or ds.Tables(0).Columns(b).DataType.ToString = "System.Array[]" Then
            If SaveFileDialog1.FileName <> "" Then
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, ds.Tables(0).Rows.Item(w).Item(b), False)
                MsgBox("Save Sucessed！！！", MsgBoxStyle.Information)
            End If
        Else
            My.Computer.FileSystem.WriteAllBytes(SaveFileDialog1.FileName, ds.Tables(0).Rows.Item(w).Item(b), False)
            MsgBox("Save Sucessed！！！", MsgBoxStyle.Information)
        End If
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        On Error GoTo u
        If CheckBox1.Checked = True Then
            Dim w As Integer = ComboBox3.Text - 1
            Dim b As Integer = ComboBox2.Text - 1
            My.Computer.FileSystem.WriteAllBytes(k + "\~8~8.tmp", ds.Tables(0).Rows.Item(w).Item(b), False)
            PictureBox1.ImageLocation = k + "\~8~8.tmp"
        Else
            PictureBox1.Image = Nothing
        End If
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
        CheckBox1.Checked = False
    End Sub
    Private Sub TextBox3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Click
        On Error Resume Next
        If TextBox3.Text = "" Then
            Dim books = _
                        XDocument.Load(My.Application.Info.DirectoryPath + "\My.xml")
            If (books.<book>.<QQ>.Value) <> "" Then
                If MsgBox("你查的表是否跟上次一样为：" + books.<book>.<QQ>.Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TextBox3.Text = books.<book>.<QQ>.Value
                Else
                    MsgBox("请输入要查的表的名称！！！", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub
    Function wxml()
        On Error Resume Next
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        settings.IndentChars = "    "
        Using writer As XmlWriter = XmlWriter.Create(My.Application.Info.DirectoryPath + "\My.xml", settings)
            writer.WriteStartElement("book")
            writer.WriteElementString("QQ", TextBox3.Text)
            writer.WriteEndElement()
            writer.Flush()
        End Using
    End Function
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        Kill(k + "\~8~8.tmp")
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox1.Image Is Nothing Then
        Else
            readpic()
            Pic.ShowDialog()
        End If
    End Sub
    Function readpic()
        Pic.PictureBox1.Image = PictureBox1.Image
        If Pic.PictureBox1.Height <= Label5.Text And Pic.PictureBox1.Width <= Label6.Text Then
            Pic.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Pic.Height = Pic.PictureBox1.Height
            Pic.Width = Pic.PictureBox1.Width
        End If
        If Pic.PictureBox1.Height <= Label5.Text And Pic.PictureBox1.Width > Label6.Text Then
            Pic.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Pic.Height = Pic.PictureBox1.Height
            Pic.Width = Label6.Text
            Pic.AutoScroll = True
        End If
        If Pic.PictureBox1.Height > Label5.Text And Pic.PictureBox1.Width <= Label6.Text Then
            Pic.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Pic.Height = Label5.Text
            Pic.Width = Pic.PictureBox1.Width
            Pic.AutoScroll = True
        End If
        If Pic.PictureBox1.Height > Label5.Text And Pic.PictureBox1.Width > Label6.Text Then
            Pic.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Pic.Height = Label5.Text
            Pic.Width = Label6.Text
            Pic.AutoScroll = True
        End If
    End Function
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Pic.Opacity = 0
        Pic.Show()
        Pic.WindowState = FormWindowState.Maximized
        Label5.Text = Pic.Height
        Label6.Text = Pic.Width
        Pic.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        On Error GoTo u
        If TextBox3.Text <> "" Then
            reading(TextBox1.Text)
        Else
            MsgBox("请输入表名称！！！", MsgBoxStyle.Information)
        End If
        Exit Sub
u:      MsgBox(Err.Description, MsgBoxStyle.Critical)
        bb("")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.SelectAll()
        TextBox2.Copy()
        MsgBox("数据已复制到剪辑板！！！", MsgBoxStyle.Information)
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Or TextBox2.Enabled = False Then
            Button4.Visible = False
        Else
            Button4.Visible = True
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Table.DataGridView1.DataSource = ds.Tables(0)
        Table.ShowDialog()
    End Sub
End Class