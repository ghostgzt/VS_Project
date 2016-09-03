Public Class Form4
    Private Sub Form1_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim cancel As Boolean = eventArgs.Cancel
        Dim unloadmode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        If unloadmode = 0 Or unloadmode = 3 Then
            Form3.Show()
            cancel = False
        End If
        eventArgs.Cancel = cancel
    End Sub
    Private Sub Form4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
    End Sub
    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        On Error Resume Next
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Form3.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Form3.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Form3.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Form3.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Form3.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Form3.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Form3.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Form3.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Form3.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Form3.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Form3.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Form3.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Form3.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Form3.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Form3.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Form3.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Form3.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Form3.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Form3.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Form3.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Form3.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
        MsgBox("已完成删除", MsgBoxStyle.Information, "完成")
    End Sub
    Private Sub PictureBox14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox26.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox27.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox28.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox29_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox29.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox30_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox30.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox31_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox31.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox32_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox32.Click

        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox33_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox33.Click
        On Error Resume Next
        If MsgBox("Are you sure to delete this file?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
            Kill(My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\*.*")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox34.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub 刷新ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新ToolStripMenuItem.Click
        On Error Resume Next
        form1.PictureBox2.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w1\w1.jpg"
        form1.PictureBox3.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w2\w2.jpg"
        form1.PictureBox4.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w3\w3.jpg"
        form1.PictureBox5.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w4\w4.jpg"
        form1.PictureBox6.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w5\w5.jpg"
        form1.PictureBox7.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w6\w6.jpg"
        form1.PictureBox8.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w7\w7.jpg"
        form1.PictureBox9.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w8\w8.jpg"
        form1.PictureBox10.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w9\w9.jpg"
        form1.PictureBox11.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w10\w10.jpg"
        form1.PictureBox12.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w11\w11.jpg"
        form1.PictureBox13.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w12\w12.jpg"
        form1.PictureBox14.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w13\w13.jpg"
        form1.PictureBox16.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w14\w14.jpg"
        form1.PictureBox17.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w15\w15.jpg"
        form1.PictureBox18.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w16\w16.jpg"
        form1.PictureBox19.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w17\w17.jpg"
        form1.PictureBox20.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w18\w18.jpg"
        form1.PictureBox21.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w19\w19.jpg"
        form1.PictureBox22.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w20\w20.jpg"
        form1.PictureBox15.ImageLocation = My.Application.Info.DirectoryPath + "\Vista Load.{871C5380-42A0-1069-A2EA-08002B30309D}\w21\w21.jpg"
        Form3.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Form3.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Form3.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Form3.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Form3.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Form3.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Form3.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Form3.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Form3.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Form3.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Form3.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Form3.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Form3.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Form3.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Form3.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Form3.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Form3.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Form3.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Form3.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Form3.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Form3.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
        Me.PictureBox13.ImageLocation = form1.PictureBox2.ImageLocation
        Me.PictureBox14.ImageLocation = form1.PictureBox3.ImageLocation
        Me.PictureBox15.ImageLocation = form1.PictureBox4.ImageLocation
        Me.PictureBox16.ImageLocation = form1.PictureBox5.ImageLocation
        Me.PictureBox17.ImageLocation = form1.PictureBox6.ImageLocation
        Me.PictureBox18.ImageLocation = form1.PictureBox7.ImageLocation
        Me.PictureBox19.ImageLocation = form1.PictureBox8.ImageLocation
        Me.PictureBox20.ImageLocation = form1.PictureBox9.ImageLocation
        Me.PictureBox21.ImageLocation = form1.PictureBox10.ImageLocation
        Me.PictureBox22.ImageLocation = form1.PictureBox11.ImageLocation
        Me.PictureBox23.ImageLocation = form1.PictureBox12.ImageLocation
        Me.PictureBox24.ImageLocation = form1.PictureBox13.ImageLocation
        Me.PictureBox25.ImageLocation = form1.PictureBox14.ImageLocation
        Me.PictureBox26.ImageLocation = form1.PictureBox15.ImageLocation
        Me.PictureBox27.ImageLocation = form1.PictureBox16.ImageLocation
        Me.PictureBox28.ImageLocation = form1.PictureBox17.ImageLocation
        Me.PictureBox29.ImageLocation = form1.PictureBox18.ImageLocation
        Me.PictureBox30.ImageLocation = form1.PictureBox19.ImageLocation
        Me.PictureBox31.ImageLocation = form1.PictureBox20.ImageLocation
        Me.PictureBox32.ImageLocation = form1.PictureBox21.ImageLocation
        Me.PictureBox33.ImageLocation = form1.PictureBox22.ImageLocation
    End Sub
End Class