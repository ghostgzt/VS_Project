VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form JarReg 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Jar文件注册！"
   ClientHeight    =   750
   ClientLeft      =   45
   ClientTop       =   285
   ClientWidth     =   4890
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   750
   ScaleWidth      =   4890
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Visible         =   0   'False
   Begin VB.TextBox Reg3 
      Height          =   270
      Left            =   0
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   2
      Text            =   "Form1.frx":628A
      Top             =   480
      Width           =   4935
   End
   Begin VB.TextBox Reg2 
      Height          =   270
      Left            =   0
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   1
      Text            =   "Form1.frx":6433
      Top             =   240
      Width           =   4935
   End
   Begin VB.TextBox Reg1 
      Height          =   270
      Left            =   0
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Text            =   "Form1.frx":6576
      Top             =   0
      Width           =   4935
   End
   Begin MSComDlg.CommonDialog C 
      Left            =   2280
      Top             =   1560
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.TextBox Text1 
      Height          =   495
      Left            =   1800
      TabIndex        =   3
      Text            =   """"
      Top             =   120
      Width           =   1215
   End
   Begin VB.TextBox Text2 
      Height          =   615
      Left            =   0
      TabIndex        =   4
      Text            =   "F:\\集合\\My\\sjboy or Game\\sjboy\\sjboy.exe"
      Top             =   0
      Width           =   4575
   End
End
Attribute VB_Name = "JarReg"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
If Command <> "" Then
If Command = "JEReg" Then
y = Replace(App.Path, "\", "\\")
u = Replace(Reg3.Text, "C:", y)
Open App.Path & "\JF.reg" For Output As #1
Print #1, (u)
Close #1
Shell "regedit.exe /s" + " " + Text1.Text + App.Path + "\JF.reg" + Text1.Text
MsgBox "注册成功！！！", vbInformation, "Jar文件注册！"
Kill (App.Path + "\JF.reg")
Else
reg (Command())
End If
Else
C.FileName = ""
C.Filter = "*.exe|*.exe"
C.ShowOpen
If C.FileName <> "" Then
p = C.FileName
reg (p)
End If
End If
End
End Sub
Function reg(p As String)
y = Replace(p, "\", "\\")
e = -1
u = Replace(Reg2.Text, Text2.Text, y)
Open App.Path & "\1.reg" For Output As #1
Print #1, (Reg1.Text)
Close #1
Open App.Path & "\3.reg" For Output As #1
Print #1, (u)
Close #1
Shell "regedit.exe /s" + " " + Text1.Text + App.Path + "\1.reg" + Text1.Text
Shell "regedit.exe /s" + " " + Text1.Text + App.Path + "\3.reg" + Text1.Text
MsgBox "注册成功！！！", vbInformation, "Jar文件注册！"
Kill (App.Path + "\1.reg")
Kill (App.Path + "\3.reg")
End Function

