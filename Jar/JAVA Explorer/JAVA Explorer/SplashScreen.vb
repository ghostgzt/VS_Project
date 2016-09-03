Public NotInheritable Class SplashScreen
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.01
        Else
            Timer1.Enabled = False
            Timer3.Enabled = True
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.0015
        Else
            Timer2.Enabled = False
            Me.Close()
        End If
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Opacity = 1
        Timer2.Enabled = True
        Timer3.Enabled = False
    End Sub
    Private Sub ApplicationTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplicationTitle.Click
        quit()
    End Sub
    Function quit()
        On Error Resume Next
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Function
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        quit()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        quit()
    End Sub
    Private Sub Copyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copyright.Click
        quit()
    End Sub
    Private Sub Version_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Version.Click
        quit()
    End Sub
    Private Sub DetailsLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        quit()
    End Sub
End Class