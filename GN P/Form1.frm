VERSION 5.00
Begin VB.Form GN_P 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "文件改名"
   ClientHeight    =   2775
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   8700
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2775
   ScaleWidth      =   8700
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  '窗口缺省
   Begin VB.TextBox Text4 
      Height          =   270
      Left            =   120
      TabIndex        =   8
      Text            =   "C:\rms"
      Top             =   120
      Width           =   4455
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   4800
      TabIndex        =   7
      Top             =   120
      Width           =   3735
   End
   Begin VB.CommandButton Command2 
      Caption         =   "刷新"
      Height          =   495
      Left            =   5760
      TabIndex        =   6
      Top             =   2040
      Width           =   1215
   End
   Begin VB.CommandButton Command1 
      Caption         =   "DO!"
      Height          =   495
      Left            =   7320
      TabIndex        =   3
      Top             =   2040
      Width           =   1215
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   5760
      TabIndex        =   2
      Top             =   1320
      Width           =   2775
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   5760
      TabIndex        =   1
      Top             =   600
      Width           =   2775
   End
   Begin VB.FileListBox File1 
      Height          =   2070
      Left            =   120
      System          =   -1  'True
      TabIndex        =   0
      Top             =   480
      Width           =   4455
   End
   Begin VB.Label Label2 
      Caption         =   "替换字符"
      Height          =   375
      Left            =   4680
      TabIndex        =   5
      Top             =   1320
      Width           =   1095
   End
   Begin VB.Label Label1 
      Caption         =   "原字符"
      Height          =   375
      Left            =   4800
      TabIndex        =   4
      Top             =   600
      Width           =   975
   End
End
Attribute VB_Name = "GN_P"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
If Text1.Text <> "" And Text2.Text <> "" And File1.ListCount <> 0 Then
For x = 0 To File1.ListCount - 1
File1.Selected(x) = True
Name File1.Path + "\" + File1.FileName As File1.Path + "\" + Replace(File1.FileName, Text1.Text, Text2.Text)
Next
End If
Command2_Click
End Sub

Private Sub Command2_Click()
File1.Refresh
End Sub

Private Sub File1_Click()
Text3.Text = File1.FileName
End Sub

Private Sub Form_Load()
File1.Path = "C:\rms"
End Sub

Private Sub Text4_Change()
On Error Resume Next
File1.Path = Text4.Text
End Sub
