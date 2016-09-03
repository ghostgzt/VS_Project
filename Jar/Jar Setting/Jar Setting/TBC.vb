Imports System.Windows.Forms
Public Class TBC
    Dim picsize As String
    Dim kuan As Integer
    Dim chang As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        On Error Resume Next
        If CheckBox1.Checked = True Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "BL", "1")
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\Jar Setting", "BL", "")
        End If
        If NumericUpDown1.Value <> 0 And NumericUpDown2.Value <> 0 Then
            Jar.rpic(Str(Int(NumericUpDown1.Value)).Trim + "*" + Str(Int(NumericUpDown2.Value)).Trim)
            Me.Close()
        Else
            MsgBox("尺寸不可取！", MsgBoxStyle.Exclamation, "敬告！")
        End If
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Jar.rpic(picsize)
        Me.Close()
    End Sub
    Dim q As Integer = 0
    Private Sub TBC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\Jar Setting", "BL", Nothing)
        If r1 <> "1" Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        q = 1
        On Error GoTo k
        picsize = Jar.rpic("")
        Dim k = picsize.Split("*".ToCharArray, 2)
        NumericUpDown1.Value = CInt(k(0))
        kuan = CInt(k(0))
        NumericUpDown2.Value = CInt(k(1))
        chang = CInt(k(1))
        PictureBox1.Image = Nothing
        PictureBox1.Image = Jar.PictureBox1.Image
        q = 0
        Exit Sub
k:      NumericUpDown1.Value = 0
        NumericUpDown2.Value = 0
        q = 0
    End Sub
    Private Sub NumericUpDown1_ValueChanged() Handles NumericUpDown1.ValueChanged
        On Error Resume Next
        If CheckBox1.Checked = True And q = 0 Then
            NumericUpDown2.Value = ((NumericUpDown1.Value / kuan) * chang)
        End If
    End Sub
    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        On Error Resume Next
        If CheckBox1.Checked = True And q = 0 Then
            NumericUpDown1.Value = ((NumericUpDown2.Value / chang) * kuan)
        End If
    End Sub
End Class