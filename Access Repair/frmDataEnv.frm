VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form frmDataEnv 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "压缩和修复数据库 By 关镇涛 2008"
   ClientHeight    =   1290
   ClientLeft      =   2190
   ClientTop       =   750
   ClientWidth     =   4665
   Icon            =   "frmDataEnv.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1290
   ScaleWidth      =   4665
   StartUpPosition =   2  '屏幕中心
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   120
      MousePointer    =   2  'Cross
      OLEDragMode     =   1  'Automatic
      OLEDropMode     =   2  'Automatic
      TabIndex        =   2
      Top             =   360
      Width           =   4455
   End
   Begin VB.CommandButton Command1 
      Caption         =   "载入"
      Height          =   495
      Left            =   600
      TabIndex        =   1
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "压缩/修复"
      Height          =   495
      Left            =   2640
      TabIndex        =   0
      Top             =   720
      Width           =   1215
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   0
      Top             =   720
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DialogTitle     =   "Accesss数据库文件"
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Access数据库："
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   10.5
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   120
      Width           =   1815
   End
End
Attribute VB_Name = "frmDataEnv"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
On Error GoTo x
CommonDialog1.Filter = "Access数据库文件*.mdb|*.mdb|*.*|*.*"
CommonDialog1.FileName = ""
CommonDialog1.ShowOpen
If CommonDialog1.FileName <> "" Then
Text1.Text = CommonDialog1.FileName
End If
Exit Sub
x:   MsgBox Err.Description
End Sub
Private Sub Command2_Click()
ki (Text1.Text)
End Sub
Function ki(u As String)
On Error GoTo Err_Handle:
    Dim dbE As New DAO.DBEngine
    dbE.CompactDatabase u, u & "~"
    Kill u
  Name u & "~" As u
    MsgBox "Done Sucessed！！！", vbInformation, "信息"
    Exit Function
Err_Handle:
    MsgBox Err.Description
End Function
Private Sub Form_Load()
If Command$ <> "" Then
If Command$ = "/?" Then
Me.Visible = False
MsgBox "Access Repair.exe [FilePath]", vbInformation
Else
ki (Command$)
End If
End
End If
End Sub
Private Sub Text1_Click()
Command1_Click
End Sub
