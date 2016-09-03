Imports System.Runtime.InteropServices
Public Class DM
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim listbox1 As ListBox
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            Dim bbint As Integer = 0
            For i = 0 To nfiles - 1
                DragQueryFile(m.WParam.ToInt32, i, sb, 256)
                If i = 0 Then sFirstFileName = sb.ToString
                If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                    TextBox1.Text = sb.ToString
                    TextBox2.Text = ""
                    fol(TextBox2)
                    run(sb.ToString, TextBox2.Text)
                End If
            Next
            DragFinish(m.WParam.ToInt32)
        End If
        Return False
    End Function
    Private Sub DM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If My.Application.CommandLineArgs.Count <> 0 Then
            If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs.Item(0).Trim) = True Then
                TextBox1.Text = My.Application.CommandLineArgs.Item(0).Trim
            Else
                TextBox1.Text = ""
            End If
            If My.Application.CommandLineArgs.Item(0).Trim = "/?" Then
                MsgBox("命令行：[DirMaker] [参照路径] [目标路径] [0/1]" + vbCrLf + vbCrLf + "[0/1]表示是否只是目录根下,0不是,1是", MsgBoxStyle.Information, "Dir Maker命令行！！！")
            End If
            If My.Application.CommandLineArgs.Count = 3 Then
                If My.Application.CommandLineArgs.Item(2).Trim.ToLower = "1" Then
                    CheckBox1.Checked = True
                Else
                    CheckBox1.Checked = False
                End If
            Else
                CheckBox1.Checked = False
            End If
            TextBox2.Text = My.Application.CommandLineArgs.Item(1).Trim
            If My.Computer.FileSystem.DirectoryExists(TextBox2.Text) = False Then
                On Error GoTo w
                MkDir(TextBox2.Text)
            End If
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                run(TextBox1.Text, TextBox2.Text)
                End
            End If
        End If
        Application.AddMessageFilter(Me)
        DragAcceptFiles(TextBox1.Handle.ToInt32, True)
        Exit Sub
w:      End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fol(TextBox1)
    End Sub
    Function fol(ByVal txt As TextBox)
        On Error Resume Next
        With FolderBrowserDialog1
            .SelectedPath = ""
            .ShowDialog()
            If .SelectedPath <> "" Then
                txt.Text = .SelectedPath
            End If
        End With
    End Function
    Function run(ByVal path As String, ByVal chu As String)
        If TextBox1.Text <> "" And TextBox2.Text <> "" And My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = True And My.Computer.FileSystem.DirectoryExists(TextBox2.Text) = True Then
            Dim k
            If CheckBox1.Checked = True Then
                k = My.Computer.FileSystem.GetDirectories(path, FileIO.SearchOption.SearchTopLevelOnly)
            Else
                k = My.Computer.FileSystem.GetDirectories(path, FileIO.SearchOption.SearchAllSubDirectories)
            End If
            For d = 0 To k.count - 1
                On Error Resume Next
                MkDir(k(d).ToString.Replace(path, chu + "\"))
            Next
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        fol(TextBox2)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And My.Computer.FileSystem.DirectoryExists(TextBox1.Text) = True And My.Computer.FileSystem.DirectoryExists(TextBox2.Text) = True Then
            run(TextBox1.Text, TextBox2.Text)
            MsgBox("成功！！！", MsgBoxStyle.Information, "温馨提示！！！")
            Shell("explorer " + TextBox2.Text, 1)
        Else
            MsgBox("请确定参照路径和目标路径的正确！！！", MsgBoxStyle.Information, "温馨提示！！！")
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.DoubleClick
        fol(TextBox1)
    End Sub
    Private Sub TextBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.DoubleClick
        fol(TextBox2)
    End Sub
End Class