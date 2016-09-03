VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form RTF_To_TXT 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Rtf<->Txt转换工具"
   ClientHeight    =   3450
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   5430
   DrawStyle       =   5  'Transparent
   Icon            =   "RTF_To_TXT.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3450
   ScaleWidth      =   5430
   StartUpPosition =   2  '屏幕中心
   Begin VB.OptionButton Option2 
      Caption         =   "Txt->RTF"
      Height          =   255
      Left            =   2160
      TabIndex        =   12
      Top             =   840
      Width           =   1215
   End
   Begin VB.OptionButton Option1 
      Caption         =   "RTF->Txt"
      Height          =   180
      Left            =   2160
      TabIndex        =   11
      Top             =   600
      Value           =   -1  'True
      Width           =   1215
   End
   Begin VB.TextBox Text4 
      Height          =   375
      Left            =   0
      TabIndex        =   8
      Text            =   "*"
      Top             =   600
      Width           =   1935
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   3255
      Left            =   5160
      TabIndex        =   6
      Top             =   120
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   5741
      _Version        =   393216
      BorderStyle     =   1
      Appearance      =   1
      MousePointer    =   99
      Orientation     =   1
      Scrolling       =   1
   End
   Begin VB.TextBox Text3 
      Height          =   375
      Left            =   2880
      TabIndex        =   5
      Top             =   3000
      Width           =   2295
   End
   Begin VB.TextBox Text2 
      Height          =   975
      Left            =   2040
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   4
      Top             =   2040
      Width           =   3135
   End
   Begin VB.CommandButton Command1 
      Caption         =   "&转换"
      Height          =   375
      Left            =   3480
      TabIndex        =   3
      Top             =   600
      Width           =   1335
   End
   Begin VB.FileListBox File1 
      Height          =   2250
      Left            =   0
      TabIndex        =   2
      Top             =   1080
      Width           =   1935
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   600
      TabIndex        =   1
      Top             =   120
      Width           =   4575
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   975
      Left            =   2040
      TabIndex        =   0
      Top             =   1080
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   1720
      _Version        =   393217
      BorderStyle     =   0
      ScrollBars      =   2
      TextRTF         =   $"RTF_To_TXT.frx":268B2
   End
   Begin VB.FileListBox File2 
      Height          =   270
      Left            =   2160
      TabIndex        =   13
      Top             =   1320
      Width           =   375
   End
   Begin VB.TextBox Text5 
      Height          =   270
      Left            =   480
      TabIndex        =   14
      Top             =   2640
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label Label3 
      Caption         =   "SavePath："
      Height          =   255
      Left            =   2040
      TabIndex        =   10
      Top             =   3120
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "PATH："
      Height          =   255
      Left            =   120
      TabIndex        =   9
      Top             =   240
      Width           =   615
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   255
      Left            =   4920
      TabIndex        =   7
      Top             =   720
      Width           =   255
   End
End
Attribute VB_Name = "RTF_To_TXT"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
On Error GoTo P
If Text1.Text = "" Or Text3.Text = "" Or File1.ListCount = 0 Then
Err
Else
KOF
End If
Exit Sub
P: MsgBox "这不是RTF或Txt文件！！！", vbInformation, "温馨提示！！！"
End Sub
Function KOF()
If Me.Option1.Value = True Then
Me.ProgressBar1.Value = 0
For X = 1 To File1.ListCount
File1.Selected(X - 1) = True
donow
start
Next
End If
If Me.Option2.Value = True Then
Me.ProgressBar1.Value = 0
For X = 1 To File1.ListCount
File1.Selected(X - 1) = True
DOOO
start
Next
End If
MsgBox "成功！！！", vbInformation, "提示！！！"
End Function
Function Err()
MsgBox "请填好来源目录和保存目录！……！", vbInformation, "温馨提示！！！"
End Function
Function donow()
Me.RichTextBox1.LoadFile Text1.Text + "\" + File1.FileName
Text2.Text = Me.RichTextBox1.Text
Open Text3.Text + "\" + File1.FileName + ".Txt" For Output As #1
Print #1, Text2.Text
Close
End Function
Function DOOO()
Me.RichTextBox1.LoadFile Text1.Text + "\" + File1.FileName
Me.RichTextBox1.SaveFile Text3.Text + "\" + File1.FileName + ".RTF"
End Function
Private Sub File1_Click()
On Error GoTo P
Me.RichTextBox1.LoadFile Text1.Text + "\" + File1.FileName
Text2.Text = Me.RichTextBox1.Text
Exit Sub
P: MsgBox "这不是RTF或Txt文件！！！", vbInformation, "温馨提示！！！"
End Sub
Private Sub Form_Load()
ii = False
If Command <> "" Then
k = Len(Command)
For X = 1 To k
t = Mid(Command, X, 1)
If t = " " Then
ii = True
End If
Next X
If ii = True Then
io = Mid(Command, 2, k - 2)
Text5.Text = io
Else
Text5.Text = Command
End If
u = Text5.Text
Me.RichTextBox1.LoadFile u
Text2.Text = Me.RichTextBox1.Text
Open u + ".Txt" For Output As #1
Print #1, Text2.Text
Close
MsgBox "成功！！！" + "生成" + u + ".Txt", vbInformation, "提示！！！"
End
End If
Exit Sub
P: MsgBox "这不是RTF或Txt文件！！！", vbInformation, "温馨提示！！！"
End
End Sub
Private Sub Option1_Click()
Me.Option2.Value = False
Me.Option1.Value = True
Text4.Text = "*.RTF"
KONG
End Sub
Function KONG()
Text2.Text = ""
RichTextBox1.Text = ""
End Function
Private Sub Option2_Click()
Me.Option2.Value = True
Me.Option1.Value = False
Text4.Text = "*.TXT"
KONG
End Sub
Private Sub Text1_Change()
On Error GoTo E
File1.Path = Text1.Text
Exit Sub
E: Err
Text1.Text = ""
End Sub
Function start()
u = File1.ListCount
If Me.ProgressBar1.Value < 100 Then
On Error GoTo t
Me.ProgressBar1.Value = Me.ProgressBar1.Value + (100 / u)
Else
t: Me.ProgressBar1.Value = 100
End If
Me.Label2.Caption = Me.ProgressBar1.Value
End Function
Private Sub Text3_Change()
On Error GoTo E
File2.Path = Text3.Text
Exit Sub
E: Err
Text3.Text = ""
End Sub
Private Sub Text4_Change()
File1.Pattern = Text4.Text
End Sub
