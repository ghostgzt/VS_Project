Public NotInheritable Class SplashScreen1
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ContextMenuStrip1.Enabled = False
        Me.Height = 0
        Timer2.Enabled = True
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
    End Sub
    Dim qqe As Boolean = False
    Private Sub Button1_Click() Handles Button1.Click
        Me.Height = 305
        Dim tei As New FolderBrowserDialog
        With tei
            .Description = "网页根目录:"
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                Main.gml = .SelectedPath
                Main.Text = Main.gml
                ChDir(Main.gml)
                qqe = True
                ContextMenuStrip1.Enabled = False
                Timer1.Enabled = True
            End If
        End With
    End Sub
    Private Sub Button2_Click() Handles Button2.Click
        Me.Height = 305
        With Main.OpenFileDialog1
            .FileName = ""
            .Filter = "*.XML 剧本文件|*.XML|*.* ALL File|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                Main.di(.FileName)
                If Main.Text = "" Then
                    Main.目录StripMenuItem1_Click()
                End If
                qqe = True
                ContextMenuStrip1.Enabled = False
                Timer1.Enabled = True
            End If
        End With
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity > 0 Then
            Me.Height = Me.Height - 10
            Me.Opacity = Me.Opacity - 0.05
        Else
            Timer1.Enabled = False
            If qqe = True Then
                Me.Opacity = 0
                Me.Height = 305
                Main.Show()
                Me.Close()
            Else
                End
            End If
            ContextMenuStrip1.Enabled = True
        End If
    End Sub
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Button1_Click()
    End Sub
    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click
        Button2_Click()
    End Sub
    Dim o = False
    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        o = True
        ContextMenuStrip1.Enabled = False
        Timer1.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Height < 305 Then
            Me.Height = Me.Height + 10
            Me.Opacity = Me.Opacity + 0.04
        Else
            Timer2.Enabled = False
            ContextMenuStrip1.Enabled = True
        End If
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutBox1.ShowDialog()
        Me.Show()
    End Sub
    Private Sub MainLayoutPanel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLayoutPanel.DoubleClick
        If o = False Then
            Main.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click
        AboutToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copyright.Click
        AboutToolStripMenuItem_Click(sender, e)
    End Sub
End Class