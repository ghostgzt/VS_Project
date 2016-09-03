Public Class Pro
    Dim seeor As Boolean
    Private Sub Pro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\bg.xy") = True Then
            PictureBox1.ImageLocation = My.Application.Info.DirectoryPath + "\bg.xy"
        End If
        Timer3.Enabled = True
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "Pro", Nothing)
        Dim r2 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "XX", Nothing)
        Dim r3 As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "YY", Nothing)
        Me.Top = r3
        Me.Left = r2
        If r1 = "True" Then
            seeor = True
            Me.Height = 31
            Me.Width = 751
            ProgressBar1.Left = 17
            ProgressBar1.Width = 256
            ProgressBar2.Top = 12
            ProgressBar2.Left = 319
            ProgressBar2.Width = 415
        Else
            seeor = False
            Me.Height = 48
            Me.Width = 294
            ProgressBar1.Width = 256
            ProgressBar2.Width = 256
            ProgressBar2.Top = 28
            ProgressBar1.Left = 12
        End If
        Timer1.Enabled = True
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.2
        Else
            Timer3.Enabled = False
            Timer4.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= 30 Then
            ProgressBar1.Value = ProgressBar1.Value + 3
        End If
        If ProgressBar1.Value > 30 And ProgressBar1.Value <= 60 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
        End If
        If ProgressBar1.Value > 60 And ProgressBar1.Value < 95 Then
            ProgressBar1.Value = ProgressBar1.Value + 2
        End If
        If ProgressBar1.Value >= 95 Then
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar2.Value <= 30 Then
            ProgressBar2.Value = ProgressBar2.Value + 3
        End If
        If ProgressBar2.Value > 30 And ProgressBar2.Value <= 60 Then
            ProgressBar2.Value = ProgressBar2.Value + 2
        End If
        If ProgressBar2.Value > 60 And ProgressBar2.Value < 95 Then
            ProgressBar2.Value = ProgressBar2.Value + 2
        End If
        If ProgressBar2.Value >= 95 Then
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "P1", Nothing) = "100" Then
            Timer1.Enabled = False
            ProgressBar1.Value = 100
            ProgressBar2.Visible = True
            Timer2.Enabled = True
        End If
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "P2", Nothing) = "100" Then
            Timer2.Enabled = False
            ProgressBar2.Value = 100
            Timer5.Enabled = True
            Timer4.Enabled = False
        End If
    End Sub
    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.2
        Else
            End
        End If
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Timer5.Enabled = True
    End Sub
End Class