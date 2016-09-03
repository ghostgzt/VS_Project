Public NotInheritable Class AboutMe
    Private Sub AboutMe_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Opacity = 0
    End Sub
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        Timer1.Enabled = True
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("版本 {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "作者:关镇涛" + vbCrLf + "现读于广东省开平市第一中学" + vbCrLf + "编程不是一件简单的事." + vbCrLf + "呕心沥血杰作出,欲使人人逐笑颜！" + vbCrLf + "千呼万唤知己者,捐款支持动起来！" + vbCrLf + "中国建设银行:" + vbCrLf + "卡号:6227 0031 2601 0025 966" + vbCrLf + "谢谢大家！！" + vbCrLf + "2009->2010Fuck Q！工作室" + vbCrLf + M.Text
    End Sub
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click
        On Error Resume Next
        Shell(My.Application.Info.DirectoryPath + "\My Love ！.exe", AppWinStyle.NormalFocus)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Timer1.Enabled = False
        End If
    End Sub
End Class