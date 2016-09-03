VERSION 5.00
Object = "{D27CDB6B-AE6D-11CF-96B8-444553540000}#1.0#0"; "FlDbg10a.ocx"
Begin VB.Form Flash_BF 
   Caption         =   "Flash播放器"
   ClientHeight    =   5850
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   9450
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   5850
   ScaleWidth      =   9450
   StartUpPosition =   2  '屏幕中心
   Begin ShockwaveFlashObjectsCtl.ShockwaveFlash f 
      Height          =   5895
      Left            =   2880
      TabIndex        =   1
      Top             =   0
      Width           =   6615
      _cx             =   11668
      _cy             =   10398
      FlashVars       =   ""
      Movie           =   " "
      Src             =   " "
      WMode           =   "Window"
      Play            =   "0"
      Loop            =   "-1"
      Quality         =   "High"
      SAlign          =   ""
      Menu            =   "-1"
      Base            =   ""
      AllowScriptAccess=   ""
      Scale           =   "ShowAll"
      DeviceFont      =   "0"
      EmbedMovie      =   "0"
      BGColor         =   ""
      SWRemote        =   ""
      MovieData       =   ""
      SeamlessTabbing =   "1"
      Profile         =   "0"
      ProfileAddress  =   ""
      ProfilePort     =   "0"
      AllowNetworking =   "all"
      AllowFullScreen =   "false"
   End
   Begin VB.ListBox lstFiles 
      Height          =   5820
      ItemData        =   "Form1.frx":628A
      Left            =   0
      List            =   "Form1.frx":628C
      TabIndex        =   0
      Top             =   0
      Width           =   2835
   End
   Begin VB.Menu 文件 
      Caption         =   "文件"
      Index           =   0
      Begin VB.Menu 添加文件 
         Caption         =   "添加文件"
         Index           =   0
         Shortcut        =   {F1}
      End
      Begin VB.Menu 隐藏栏目 
         Caption         =   "隐藏栏目"
         Index           =   2
         Shortcut        =   ^B
      End
      Begin VB.Menu 显示栏目 
         Caption         =   "显示栏目"
         Index           =   3
         Shortcut        =   ^A
      End
   End
   Begin VB.Menu 菜单 
      Caption         =   "菜单"
      Index           =   1
      Begin VB.Menu 删除这一条 
         Caption         =   "删除这一条"
         Index           =   0
         Shortcut        =   {DEL}
      End
      Begin VB.Menu 清空 
         Caption         =   "清空"
         Index           =   1
         Shortcut        =   +{DEL}
      End
      Begin VB.Menu 全屏 
         Caption         =   "全屏"
         Index           =   2
         Shortcut        =   {F11}
      End
   End
   Begin VB.Menu 控制 
      Caption         =   "控制"
      Index           =   3
      Begin VB.Menu 上一条 
         Caption         =   "上一条"
         Index           =   0
         Shortcut        =   {F2}
      End
      Begin VB.Menu 下一条 
         Caption         =   "下一条"
         Index           =   1
         Shortcut        =   {F3}
      End
      Begin VB.Menu 播放 
         Caption         =   "播放"
         Index           =   3
         Shortcut        =   {F4}
      End
      Begin VB.Menu 停止 
         Caption         =   "停止"
         Index           =   4
         Shortcut        =   {F5}
      End
   End
   Begin VB.Menu 退出 
      Caption         =   "退出"
      Index           =   3
   End
End
Attribute VB_Name = "Flash_BF"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
If Command <> "" Then
lstFiles.AddItem Command
f.Movie = Command
Me.Caption = "Flash播放器 - " + Command
End If
End Sub
Private Sub Form_Resize()
On Error Resume Next
lstFiles.Height = Me.Height - (6600 - 5900)
f.Height = Me.Height - (6600 - 5900) - 50
If lstFiles.Left < 0 Then
f.Width = Me.Width
Else

f.Width = Me.Width - lstFiles.Width - 200
End If

End Sub
Private Sub lstFiles_Click()
lstFiles.ToolTipText = lstFiles.Text
f.Movie = " "
Me.Caption = "Flash播放器 - " + lstFiles.Text
f.Movie = lstFiles.Text
f.Stop
End Sub
Private Sub lstFiles_DblClick()
f.Play
End Sub
Private Sub 播放_Click(Index As Integer)
f.Play
End Sub
Private Sub 清空_Click(Index As Integer)
lstFiles.Clear
Me.Caption = "Flash播放器"
End Sub
Private Sub 全屏_Click(Index As Integer)
Me.WindowState = 2
End Sub
Private Sub 删除这一条_Click(Index As Integer)
If lstFiles.SelCount <> 0 Then
lstFiles.RemoveItem (lstFiles.ListIndex)
f.Movie = " "
End If
Me.Caption = "Flash播放器"
End Sub
Private Sub 上一条_Click(Index As Integer)
On Error Resume Next
If lstFiles.SelCount = 0 Then
lstFiles.Selected(lstFiles.ListCount - 1) = True
Else
lstFiles.Selected(lstFiles.ListIndex - 1) = True
End If
lstFiles_DblClick
End Sub
Private Sub 添加文件_Click(Index As Integer)
 Dim gFiles As String
    Dim aFiles() As String, i As Long
    gFiles = GetFileNames(ShowOpenFile, "添加文件...", , "Flash文件 *.swf|*.swf|All Files *.*|*.*", True, Me.hWnd)
    If Len(gFiles) > 0 Then
        aFiles = Split(gFiles, "|")
        For i = 0 To UBound(aFiles)
                lstFiles.AddItem aFiles(i)
        Next
    End If
End Sub
Private Sub 停止_Click(Index As Integer)
f.Stop
End Sub
Private Sub 退出_Click(Index As Integer)
End
End Sub
Private Sub 下一条_Click(Index As Integer)
On Error Resume Next
If lstFiles.SelCount = 0 Then
lstFiles.Selected(0) = True
Else
lstFiles.Selected(lstFiles.ListIndex + 1) = True
End If
lstFiles_DblClick
End Sub
Private Sub 显示栏目_Click(Index As Integer)
Me.lstFiles.Left = 0
f.Left = lstFiles.Width + 2
f.Width = Me.Width - lstFiles.Width - 2
End Sub
Private Sub 隐藏栏目_Click(Index As Integer)
Me.lstFiles.Left = -lstFiles.Width
f.Left = 0
f.Width = Me.Width
End Sub
