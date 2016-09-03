Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class X
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim listbox1 As Object
    Dim LX As String
    Dim gnn As New GN
    Dim iinn As Boolean
    Dim textbox1 As Object
    Dim dirorpath As Boolean
    Function Run(ByVal Touch As Object, ByVal receverListbox As ListBox, ByVal receverTextBox As TextBox, ByVal TLX As String, ByVal DoP As Boolean, ByVal info As Boolean)
        On Error Resume Next
        listbox1 = receverListbox
        Application.AddMessageFilter(Me)
        DragAcceptFiles(Touch.Handle.ToInt32, True)
        LX = TLX
        iinn = info
        textbox1 = receverTextBox
        dirorpath = DoP
    End Function
    Dim bbint As Integer
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            bbint = 0
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                If textbox1 Is Nothing Then
                Else
                    If i = 0 Then
                        If dirorpath = True Then
                            If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                                textbox1.text = sb.ToString
                            End If
                        Else
                            If My.Computer.FileSystem.FileExists(sb.ToString) = True Then
                                Dim tte As ListBox = gete(LX)
                                For xd = 0 To tte.Items.Count - 1
                                    If tte.Items.Item(xd) = "*.*" Then
                                        textbox1.text = sb.ToString
                                    Else
                                        If "*." + gnn.getname(sb.ToString, ".", False, 0).ToString.ToLower = tte.Items.Item(xd).ToString.ToLower Then
                                            textbox1.text = sb.ToString
                                        End If
                                    End If
                                Next
                            End If
                        End If
                    End If
                End If
                    If dirorpath = True Then
                        If listbox1 Is Nothing Then
                        Else
                            If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                                listbox1.Items.Add(sb.ToString)
                                listbox1.Items.Remove("")
                                bbint = bbint + 1
                            End If
                        End If
                    Else
                        If listbox1 Is Nothing Then
                        Else
                            If i = 0 Then sFirstFileName = sb.ToString
                            If My.Computer.FileSystem.FileExists(sb.ToString) = True Then
                                Dim tte As ListBox = gete(LX)
                            For x = 0 To tte.Items.Count - 1
                                If tte.Items.Item(x) <> "*.*" Then
                                    Dim gg As String = gnn.getname(sb.ToString.Trim, ".", False, 0)
                                    If gg.ToLower = gnn.getname(tte.Items.Item(x), ".", False, 0).ToString.ToLower Then
                                        listbox1.Items.Remove(sb.ToString)
                                        listbox1.Items.Add(sb.ToString)
                                        bbint = bbint + 1
                                    End If
                                Else
                                    listbox1.Items.Remove(sb.ToString)
                                    listbox1.Items.Add(sb.ToString)
                                    bbint = bbint + 1
                                End If
                            Next
                            End If
                            If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                                Dim tt
                                Dim tte As ListBox = gete(LX)
                                For x = 0 To tte.Items.Count - 1
                                    tt = My.Computer.FileSystem.GetFiles(sb.ToString, FileIO.SearchOption.SearchAllSubDirectories, tte.Items.Item(x))
                                    For qq = 0 To tt.count - 1
                                        listbox1.Items.Remove(tt(qq))
                                        listbox1.Items.Add(tt(qq))
                                        listbox1.Items.Remove("")
                                        bbint = bbint + 1
                                    Next
                                Next
                            End If
                        End If
                    End If
            Next
            If iinn = True And bbint <> 0 Then
                MsgBox("添加了" + Str(bbint) + "个", MsgBoxStyle.Information, "温馨提示！！！")
            End If
            DragFinish(m.WParam.ToInt32)
        End If
    End Function
    Function Xcount()
        Return bbint
    End Function
    Function gete(ByVal str As String)
        str = str.Trim.ToLower
        Dim ggd As New ListBox
        On Error Resume Next
        ggd.Items.Clear()
        If (str.Split("|".ToCharArray).Count) <> 1 Then
            For x = 0 To str.Split("|".ToCharArray).Count - 1
                Dim ty = (str.Split("|".ToCharArray)(x))
                ggd.Items.Remove(ty)
                ggd.Items.Add(ty)
            Next
        Else
            ggd.Items.Remove(str)
            ggd.Items.Add(str)
        End If
        ggd.Items.Remove("")
        Return ggd
    End Function
    Private Sub X_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
    End Sub
End Class