VERSION 5.00
Begin VB.Form CT 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CTP"
   ClientHeight    =   1200
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   3585
   Icon            =   "CT.frx":0000
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   ScaleHeight     =   1200
   ScaleWidth      =   3585
   StartUpPosition =   2  '屏幕中心
   Begin VB.CommandButton Command3 
      Caption         =   "End"
      Height          =   495
      Left            =   2400
      TabIndex        =   4
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton Command2 
      Caption         =   "Run"
      Height          =   495
      Left            =   1200
      TabIndex        =   3
      Top             =   720
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Copy"
      Height          =   495
      Left            =   0
      TabIndex        =   2
      Top             =   720
      Width           =   1215
   End
   Begin VB.CheckBox Check1 
      Height          =   255
      Left            =   0
      TabIndex        =   1
      ToolTipText     =   "显示文件名！！！"
      Top             =   480
      Value           =   1  'Checked
      Width           =   200
   End
   Begin VB.TextBox Text1 
      Height          =   735
      Left            =   0
      MultiLine       =   -1  'True
      ScrollBars      =   1  'Horizontal
      TabIndex        =   0
      Top             =   0
      Width           =   3615
   End
End
Attribute VB_Name = "CT"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Check1_Click()
If Check1.Value = 0 Then
Text1.Text = Command
Else
Text1.Text = App.Path + "\" + App.EXEName + ".exe" + " " + Command
End If
End Sub

Private Sub Command1_Click()
Clipboard.Clear
Clipboard.SetText Text1.Text
MsgBox "Copy Successful！", vbInformation
End Sub

Private Sub Command2_Click()
On Error GoTo q
Shell App.Path + "\" + App.EXEName + ".exe.CTP " + Command, vbNormalFocus
Exit Sub
q: MsgBox "Run failed！", vbExclamation
End Sub

Private Sub Command3_Click()
End
End Sub

Private Sub Form_Load()
On Error Resume Next
If Command = "" Then
MsgBox App.Path + "\" + App.EXEName + ".exe" + vbCrLf + "没授予命令行！！！", vbInformation
End
Else
Text1.Text = App.Path + "\" + App.EXEName + ".exe" + " " + Command
MsgBox Text1.Text, vbInformation
End If
End Sub

