Public Class My_Family
    Dim c As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity < 1 Then
            Me.Opacity = Me.Opacity + 0.1
        Else
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub me_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        Cancel = 1
        eventArgs.Cancel = Cancel
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.1
        Else
            Timer2.Enabled = False
            If c = 4 Then
                MsgBox("Father And Mother I Love You ！" + vbCrLf + "In My Heart,You Are The Best！！！", MsgBoxStyle.Information, "Family！")
                End
            Else
                c = c + 1
            End If
            If c = 2 Then
                PictureBox1.Image = My.Resources._1
            End If
            If c = 3 Then
                PictureBox1.Image = My.Resources._2
            End If
            If c = 4 Then
                PictureBox1.Image = My.Resources._3
            End If
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
    Private Sub My_Family_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TransparencyKey = Me.BackColor
        c = 1
        PictureBox1.Image = My.Resources._0
        Timer1.Enabled = True
    End Sub
    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class