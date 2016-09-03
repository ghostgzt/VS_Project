VERSION 5.00
Object = "{6BF52A50-394A-11D3-B153-00C04F79FAA6}#1.0#0"; "wmp.dll"
Begin VB.Form Form4 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "My Player"
   ClientHeight    =   3135
   ClientLeft      =   6195
   ClientTop       =   5070
   ClientWidth     =   4680
   Icon            =   "Form4.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MouseIcon       =   "Form4.frx":1058E
   MousePointer    =   4  'Icon
   ScaleHeight     =   3135
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Begin VB.DriveListBox Drive1 
      Height          =   300
      Left            =   2400
      TabIndex        =   0
      Top             =   0
      Width           =   2295
   End
   Begin VB.FileListBox File1 
      Height          =   810
      Hidden          =   -1  'True
      Left            =   0
      System          =   -1  'True
      TabIndex        =   2
      Top             =   2520
      Width           =   4095
   End
   Begin VB.DirListBox Dir1 
      Height          =   1980
      Left            =   2400
      TabIndex        =   1
      Top             =   240
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   2400
      TabIndex        =   4
      Text            =   "*.mp3;*.mid;*.wav;*.wma "
      ToolTipText     =   "类似*.mp3;*.mid;*.wav;*.wma输入后按回车即可 "
      Top             =   2160
      Width           =   2295
   End
   Begin VB.Shape Shape1 
      FillColor       =   &H000080FF&
      Height          =   615
      Left            =   4080
      Shape           =   4  'Rounded Rectangle
      Top             =   2520
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "             退出"
      DragIcon        =   "Form4.frx":10E58
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000080FF&
      Height          =   615
      Left            =   4080
      MouseIcon       =   "Form4.frx":11722
      MousePointer    =   4  'Icon
      TabIndex        =   5
      Top             =   2520
      Width           =   615
   End
   Begin VB.Image Image1 
      Height          =   615
      Left            =   4080
      Picture         =   "Form4.frx":11A2C
      Stretch         =   -1  'True
      Top             =   2520
      Width           =   615
   End
   Begin WMPLibCtl.WindowsMediaPlayer WindowsMediaPlayer1 
      Height          =   2535
      Left            =   0
      TabIndex        =   3
      Top             =   0
      Width           =   2400
      URL             =   ""
      rate            =   1
      balance         =   0
      currentPosition =   0
      defaultFrame    =   ""
      playCount       =   1
      autoStart       =   -1  'True
      currentMarker   =   0
      invokeURLs      =   -1  'True
      baseURL         =   ""
      volume          =   50
      mute            =   0   'False
      uiMode          =   "full"
      stretchToFit    =   0   'False
      windowlessVideo =   0   'False
      enabled         =   -1  'True
      enableContextMenu=   -1  'True
      fullScreen      =   0   'False
      SAMIStyle       =   ""
      SAMILang        =   ""
      SAMIFilename    =   ""
      captioningID    =   ""
      enableErrorDialogs=   0   'False
      _cx             =   4233
      _cy             =   4471
   End
End
Attribute VB_Name = "Form4"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Dir1_Change()
File1.Pattern = Text1
File1.Path = Dir1.Path
End Sub
Private Sub Dir1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape1.Visible = False
End Sub
Private Sub Drive1_Change()
On Error Resume Next
Dir1.Path = Drive1.Drive
End Sub
Private Sub File1_DblClick()
ChDir Dir1.Path
WindowsMediaPlayer1.URL = File1.Path + "\" + File1.FileName
End Sub
Private Sub File1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape1.Visible = False
End Sub
Private Sub Form_Load()
File1.Pattern = Text1
End Sub
Private Sub Label1_Click()
End
End Sub
Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape1.Visible = True
End Sub
Private Sub Text1_KeyDown(KeyCode As Integer, Shift As Integer)
On Error Resume Next
If Key = enter Then
File1.Pattern = Text1.Text
End If
End Sub
Private Sub WindowsMediaPlayer1_MouseMove(ByVal nButton As Integer, ByVal nShiftState As Integer, ByVal fX As Long, ByVal fY As Long)
Shape1.Visible = False
End Sub
