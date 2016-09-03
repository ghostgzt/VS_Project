Public Class _18yo
    Dim JJE As New JEExt.JEE
    Private Sub _18yo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub _18yo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = JJE.getpic()
        Timer2.Enabled = False
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.1
        Else
            Timer2.Enabled = False
            Me.Close()
        End If
    End Sub
End Class