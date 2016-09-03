VERSION 5.00
Begin VB.Form frmMain 
   BorderStyle     =   0  'None
   ClientHeight    =   90
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   90
   Icon            =   "frmMain.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   90
   ScaleWidth      =   90
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   240
      TabIndex        =   1
      Text            =   """"
      Top             =   0
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.ListBox lstFiles 
      Height          =   2400
      Left            =   0
      MultiSelect     =   2  'Extended
      TabIndex        =   0
      ToolTipText     =   "双击或回车查看文件内容"
      Top             =   0
      Width           =   1635
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Declare Function GetInputState Lib "user32" () As Long
Private Sub Form_Load()
If Command <> "" Then
Dim uu
uu = ""
Dim u
For u = 0 To Len(Command) - 1
If Mid(Command, u + 1, 1) = Text1.Text Then
uu = u
End If
Next
If uu = "" Then
lstFiles.AddItem (Command)
Else
lstFiles.AddItem (Replace(Command, Text1.Text, ""))
End If
run
End If
End
End Sub
Function run()
    Dim i As Long, f As Long
    Dim p As Long, s As Long, psi As Long
    Dim flag As Boolean, bak As Boolean
    Dim frmCode As TextCode, toCode As TextCode
    Dim frmcName As String, tocName As String
    Dim e As String
   frmCode = GB2312_Code
        frmcName = "GB"
     toCode = UTF8_Code
        tocName = "UTF-8"
  bak = False
DoEvents
s = lstFiles.ListCount
    p = s \ 100 + 1
    For i = 0 To s - 1
        If (i + 1) Mod p = 0 Then lstFiles.Selected(psi) = False
            psi = i
            lstFiles.Selected(i) = True
            lstFiles.TopIndex = i
            flag = True
   
        If GetInputState() Or flag Then
            DoEvents
            flag = False
        End If
     If Not Save2File(lstFiles.List(i), frmCode, toCode, bak, 0, 0) Then
            e = e & "处理失败：" & lstFiles.List(i) & vbCrLf
            f = f + 1
End If
    Next
End Function
