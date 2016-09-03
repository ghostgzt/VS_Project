VERSION 5.00
Begin VB.Form Lnk 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Lnk Maker"
   ClientHeight    =   2445
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   4680
   Icon            =   "Lnk.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2445
   ScaleWidth      =   4680
   StartUpPosition =   2  '屏幕中心
   Begin VB.CommandButton Command6 
      Caption         =   "退出"
      Height          =   255
      Left            =   3840
      TabIndex        =   14
      Top             =   1680
      Width           =   615
   End
   Begin VB.CommandButton Command5 
      Caption         =   "生成"
      Height          =   375
      Left            =   0
      TabIndex        =   13
      Top             =   2040
      Width           =   4695
   End
   Begin VB.CommandButton Command3 
      Caption         =   "浏览"
      Height          =   255
      Left            =   3840
      TabIndex        =   12
      Top             =   1320
      Width           =   615
   End
   Begin VB.CommandButton Command2 
      Caption         =   "浏览"
      Height          =   255
      Left            =   3840
      TabIndex        =   11
      Top             =   600
      Width           =   615
   End
   Begin VB.CommandButton Command1 
      Caption         =   "浏览"
      Height          =   255
      Left            =   3840
      TabIndex        =   10
      Top             =   240
      Width           =   615
   End
   Begin VB.TextBox Text5 
      Height          =   270
      Left            =   1320
      TabIndex        =   9
      Top             =   1680
      Width           =   2415
   End
   Begin VB.TextBox Text4 
      Height          =   270
      Left            =   1320
      TabIndex        =   7
      Top             =   1320
      Width           =   2415
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   1320
      TabIndex        =   5
      Top             =   960
      Width           =   2415
   End
   Begin VB.TextBox Text2 
      Height          =   270
      Left            =   1320
      TabIndex        =   4
      Top             =   600
      Width           =   2415
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   1320
      TabIndex        =   3
      Top             =   240
      Width           =   2415
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      Caption         =   "图标索引"
      Height          =   180
      Left            =   120
      TabIndex        =   8
      Top             =   1680
      Width           =   720
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      Caption         =   "图标路径"
      Height          =   180
      Left            =   120
      TabIndex        =   6
      Top             =   1320
      Width           =   720
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      Caption         =   "运行参数"
      Height          =   180
      Left            =   120
      TabIndex        =   2
      Top             =   960
      Width           =   720
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      Caption         =   "目标路径"
      Height          =   180
      Left            =   120
      TabIndex        =   1
      Top             =   600
      Width           =   720
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "快捷方式路径"
      Height          =   180
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   1080
   End
End
Attribute VB_Name = "Lnk"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Dim gFiles As String
  gFiles = ""
    gFiles = GetFileNames(ShowSaveFile, "添加文件...", , "Lnk文件 *.lnk|*.lnk|All Files *.*|*.*", False, Me.hWnd)
    If (gFiles) <> "" Then
     Text1.text = gFiles
    End If
End Sub
Private Sub Command2_Click()
Dim gFiles As String
  gFiles = ""
    gFiles = GetFileNames(ShowOpenFile, "添加文件...", , "All Files *.*|*.*", False, Me.hWnd)
    If (gFiles) <> "" Then
     Text2.text = gFiles
    End If
End Sub
Private Sub Command3_Click()
Dim gFiles As String
  gFiles = ""
    gFiles = GetFileNames(ShowOpenFile, "添加文件...", , "图标文件 *.ico|*.ico|All Files *.*|*.*", False, Me.hWnd)
    If (gFiles) <> "" Then
     Text4.text = gFiles
    End If
End Sub
Private Sub Command5_Click()
If Text1.text <> "" And Text2.text <> "" Then
 Shell (App.Path & "\WinCMD.exe LINK !" + Text1.text + "," + Text2.text + "," + Text3.text + "," + Text4.text + "," + Text5.text)
End If
End Sub
Private Sub Command6_Click()
End
End Sub
Private Sub Form_Load()
If Command <> "" Then
Text1.text = Command
Text2.text = Command
Command5_Click
End
End If
End Sub
