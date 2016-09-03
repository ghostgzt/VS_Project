Public NotInheritable Class AboutMe
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Mini.Hide()
        Shell(My.Application.Info.DirectoryPath + "\My Love ！.exe", AppWinStyle.NormalFocus, True)
        Mini.Show()
        Panel1.Width = 0
        PictureBox1.Height = 0
        Timer3.Enabled = True
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
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Panel1.Width < 390 Then
            Panel1.Width = Panel1.Width + 10
        Else
            PictureBox1.Visible = True
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If PictureBox1.Height < 116 Then
            PictureBox1.Height = PictureBox1.Height + 1
        Else
            Timer2.Enabled = False
            TextBox2.Visible = True
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Timer3.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If TextBox2.Width < 269 Then
            TextBox2.Width = TextBox2.Width + 5
        Else
            Timer4.Enabled = False
            PictureBox3.Image = My.Resources.YZ
        End If
    End Sub
End Class