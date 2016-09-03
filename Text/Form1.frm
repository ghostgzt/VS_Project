VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form1 
   BorderStyle     =   0  'None
   Caption         =   "本文加密程序"
   ClientHeight    =   5415
   ClientLeft      =   300
   ClientTop       =   0
   ClientWidth     =   7950
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   5415
   ScaleWidth      =   7950
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Begin VB.TextBox Text3 
      Height          =   495
      Left            =   3000
      TabIndex        =   9
      Text            =   "Text3"
      Top             =   3240
      Visible         =   0   'False
      Width           =   1455
   End
   Begin RichTextLib.RichTextBox B 
      Height          =   735
      Left            =   600
      TabIndex        =   6
      Top             =   3240
      Visible         =   0   'False
      Width           =   1575
      _ExtentX        =   2778
      _ExtentY        =   1296
      _Version        =   393217
      ScrollBars      =   3
      AutoVerbMenu    =   -1  'True
      TextRTF         =   $"Form1.frx":11AC4
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "方正姚体"
         Size            =   9
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin MSComDlg.CommonDialog A 
      Left            =   3720
      Top             =   2520
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton Command4 
      Caption         =   "&Open"
      Height          =   375
      Left            =   6480
      TabIndex        =   5
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton Command3 
      Caption         =   "保存"
      Height          =   375
      Left            =   6480
      TabIndex        =   4
      Top             =   3480
      Width           =   1095
   End
   Begin VB.CommandButton Command2 
      Caption         =   "解密"
      Height          =   375
      Left            =   6480
      TabIndex        =   3
      Top             =   2400
      Width           =   1095
   End
   Begin VB.CommandButton Command1 
      Caption         =   "加密"
      Height          =   375
      Left            =   6480
      TabIndex        =   2
      Top             =   1320
      Width           =   1095
   End
   Begin VB.ComboBox Combo1 
      Height          =   300
      Left            =   480
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   4560
      Width           =   5655
   End
   Begin VB.TextBox Text1 
      Height          =   3135
      Left            =   480
      MultiLine       =   -1  'True
      ScrollBars      =   3  'Both
      TabIndex        =   0
      Top             =   1320
      Width           =   5655
   End
   Begin VB.Image Image4 
      Height          =   930
      Left            =   6960
      Picture         =   "Form1.frx":11B71
      Top             =   0
      Width           =   825
   End
   Begin VB.Image Image8 
      Height          =   930
      Left            =   6960
      Picture         =   "Form1.frx":12976
      Top             =   0
      Visible         =   0   'False
      Width           =   825
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "0"
      Height          =   255
      Left            =   6840
      TabIndex        =   8
      Top             =   2880
      Width           =   375
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "0"
      Height          =   255
      Left            =   6840
      TabIndex        =   7
      Top             =   1800
      Width           =   375
   End
   Begin VB.Image Image7 
      Height          =   480
      Left            =   3720
      Picture         =   "Form1.frx":13930
      Top             =   480
      Visible         =   0   'False
      Width           =   480
   End
   Begin VB.Image Image5 
      Height          =   600
      Left            =   3480
      Picture         =   "Form1.frx":13BFF
      Top             =   120
      Width           =   585
   End
   Begin VB.Image Image6 
      Height          =   855
      Left            =   3120
      Picture         =   "Form1.frx":14347
      Stretch         =   -1  'True
      Top             =   0
      Width           =   1320
   End
   Begin VB.Image Image2 
      Height          =   975
      Left            =   0
      Picture         =   "Form1.frx":15C9F
      Stretch         =   -1  'True
      Top             =   0
      Width           =   7935
   End
   Begin VB.Image Image3 
      Height          =   375
      Left            =   0
      Picture         =   "Form1.frx":17103
      Stretch         =   -1  'True
      Top             =   600
      Width           =   7935
   End
   Begin VB.Image Image1 
      Height          =   4455
      Left            =   0
      Picture         =   "Form1.frx":17D41
      Stretch         =   -1  'True
      Top             =   960
      Width           =   7935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function ReleaseCapture Lib "user32" () As Long
Private Const WM_SYSCOMMAND = &H112
Private Const SC_MOVE = &HF010&
Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal HWND As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal HWND As Long, ByVal nIndex As Long) As Long
Private Const GWL_EXSTYLE = (-20)
Private Const LWA_ALPHA As Long = &H2
Private Const WS_EX_LAYERED As Long = &H80000
Private Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal HWND As Long, ByVal crKey As Long, ByVal bAlpha As Long, ByVal dwFlags As Long) As Long
Private Sub Combo1_Click()
If Combo1.Text <> "" Then
B.LoadFile Combo1.Text
Text1.Text = B.Text
Label1.Caption = "0"
Label2.Caption = "0"
End If
End Sub
Private Sub Command1_Click()
yw$ = Text1.Text
xw$ = ""
n = Len(yw$)
For i = 1 To n
yz$ = Mid(yw$, i, 1)
xz$ = Chr(Asc(yz$) + 1)
xw$ = xw$ & xz$
Next
Text1.Text = xw$
Label1.Caption = Label1.Caption + 1
If Label1.Caption = 3 Then
MsgBox "你已经加密3次了，次数越多本文丢失机会越大！！！", vbExclamation
Command1.Enabled = False
End If
End Sub
Private Sub Command2_Click()
yw$ = Text1.Text
xw$ = ""
n = Len(yw$)
For i = 1 To n
yz$ = Mid(yw$, i, 1)
xz$ = Chr(Asc(yz$) - 1)
xw$ = xw$ & xz$
Next
Text1.Text = xw$
Label2.Caption = Label2.Caption + 1
If Label2.Caption = 3 Then
MsgBox "你已经解密3次了，次数越多本文丢失机会越大！！！", vbExclamation
Command2.Enabled = False
End If
End Sub
Private Sub Command3_Click()
A.FileName = ""
A.Filter = "*.TXT|*.TXT|*.rft|*.rft|*.*|*.*"
A.ShowSave
If A.FileName <> "" Then
Open A.FileName For Output As #1
Print #1, Text1.Text
Close
MsgBox "Saved Sucessed！！！", vbInformation
End If
End Sub
Private Sub Command4_Click()
A.FileName = ""
A.Filter = "*.TXT|*.TXT|*.rft|*.rft|*.*|*.*"
A.ShowOpen
If A.FileName <> "" Then
B.LoadFile A.FileName
Text1.Text = B.Text
Combo1.AddItem B.FileName
Combo1.Text = B.FileName
Label1.Caption = "0"
Label2.Caption = "0"
ch
End If
End Sub
Function ch()
If Text1.Text <> "" Then
Command1.Enabled = True
Command2.Enabled = True
Command3.Enabled = True
Else
 Command1.Enabled = False
   Command2.Enabled = False
   Command3.Enabled = Fals
End If
End Function
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
Text3.Text = io
Else
Text3.Text = Command
End If
A.FileName = Text3.Text
B.LoadFile A.FileName
Text1.Text = B.Text
Combo1.AddItem B.FileName
Combo1.Text = B.FileName
Label1.Caption = "0"
Label2.Caption = "0"
ch
End If
Call Round_Corners(Me)
   ch
 Dim p As Long
  p = GetWindowLong(Me.HWND, GWL_EXSTYLE)
  Call SetWindowLong(Me.HWND, GWL_EXSTYLE, p Or WS_EX_LAYERED)
 Call SetLayeredWindowAttributes(Me.HWND, 200, 200, LWA_ALPHA)
End Sub
Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
vb
End Sub
Private Sub Image2_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
vb
  If Button = 1 Then
      Dim ReturnVal As Long
        X = ReleaseCapture()
        ReturnVal = SendMessage(Form1.HWND, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
     End If
End Sub
Private Sub Image4_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image8.Visible = True
Image4.Visible = False
End Sub
Private Sub Image5_Click()
MsgBox "作者;关镇涛" + vbCrLf + "MCL2008", vbInformation, "About"
End Sub
Private Sub Image5_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image6.Visible = False
Image7.Visible = True
End Sub
Function vb()
Image6.Visible = True
Image7.Visible = False
Image4.Visible = True
Image8.Visible = False
End Function
Private Sub Image8_Click()
On Error Resume Next
Kill ("c:\$temp.tmp")
End
End Sub
Private Sub Text1_Change()
ch
End Sub
