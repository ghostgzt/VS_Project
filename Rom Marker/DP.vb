Public Class DP
    Inherits System.Windows.Forms.Form
    Implements IMessageFilter
    Const WM_DROPFILES = &H233
    <Runtime.InteropServices.DllImport("shell32.dll")> Public Shared Sub DragFinish(ByVal hDrop As Integer)
    End Sub
    <Runtime.InteropServices.DllImport("shell32.dll")> Public Shared Sub DragAcceptFiles(ByVal hwnd As Integer, ByVal fAccept As Boolean)
    End Sub
    <Runtime.InteropServices.DllImport("shell32.dll")> Public Shared Function DragQueryFile(ByVal HDROP As Integer, ByVal UINT As Integer, ByVal lpStr As System.Text.StringBuilder, ByVal ch As Integer) As Integer
    End Function
    Dim listbox1 As Object
    Dim LX As String
    Function Run(ByVal listb As Object)
        On Error Resume Next
        listbox1 = listb
        Application.AddMessageFilter(Me)
        DragAcceptFiles(RM.Handle.ToInt32, True)
    End Function
    Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_DROPFILES Then
            Dim nfiles As Int16
            nfiles = DragQueryFile(m.WParam.ToInt32, -1, Nothing, 0)
            Dim i As Int16
            Dim sb As New System.Text.StringBuilder(256)
            Dim sFirstFileName As String
            Dim bbint As Integer = 0
            i = 0
            DragQueryFile(m.WParam.ToInt32, i, sb, 256)
            If i = 0 Then sFirstFileName = sb.ToString
            If My.Computer.FileSystem.DirectoryExists(sb.ToString) = True Then
                RM.TextBox6.Text = ""
                listbox1.text = sb.ToString
            End If
            DragFinish(m.WParam.ToInt32)
        End If
    End Function
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'DP
        '
        Me.ClientSize = New System.Drawing.Size(0, 0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DP"
        Me.ResumeLayout(False)
    End Sub
End Class