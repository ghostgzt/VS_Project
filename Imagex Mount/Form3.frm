VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form Form3 
   BorderStyle     =   0  'None
   Caption         =   "ImageX Mount工具 精简版"
   ClientHeight    =   3090
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   4680
   Icon            =   "Form3.frx":0000
   LinkTopic       =   "Form3"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MouseIcon       =   "Form3.frx":628A
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   2  '屏幕中心
   Begin VB.Timer Timer2 
      Interval        =   1000
      Left            =   0
      Top             =   0
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   4320
      TabIndex        =   2
      Text            =   """"
      Top             =   2760
      Visible         =   0   'False
      Width           =   180
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   4200
      Top             =   2640
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      DialogTitle     =   "ImageX Mount工具 精简版"
      Filter          =   "*.Wim;*.Gzt;*.Wsm|*.Wim;*.Gzt;*.Wsm"
   End
   Begin VB.TextBox Text1 
      Appearance      =   0  'Flat
      Enabled         =   0   'False
      Height          =   270
      Left            =   720
      TabIndex        =   1
      Text            =   "File Path"
      Top             =   360
      Visible         =   0   'False
      Width           =   1695
   End
   Begin VB.TextBox Text2 
      Appearance      =   0  'Flat
      Enabled         =   0   'False
      Height          =   270
      Left            =   2400
      TabIndex        =   0
      Text            =   "File Dir"
      Top             =   360
      Visible         =   0   'False
      Width           =   1695
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "华文彩云"
         Size            =   10.5
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   210
      Left            =   1920
      TabIndex        =   7
      Top             =   120
      Width           =   45
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Height          =   375
      Left            =   0
      TabIndex        =   6
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   375
      Left            =   360
      TabIndex        =   5
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Height          =   375
      Left            =   720
      TabIndex        =   4
      Top             =   0
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "@华文彩云"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1920
      TabIndex        =   3
      Top             =   2760
      Width           =   60
   End
   Begin VB.Image Image23 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":6594
      Stretch         =   -1  'True
      Top             =   2400
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image22 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":6BE7
      Stretch         =   -1  'True
      Top             =   2160
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image21 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":6F25
      Stretch         =   -1  'True
      Top             =   2160
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image20 
      Height          =   495
      Left            =   2040
      Top             =   1560
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Image Image19 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":7336
      Stretch         =   -1  'True
      Top             =   1920
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image18 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":7828
      Stretch         =   -1  'True
      Top             =   1920
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image17 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":7CA2
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image16 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":808C
      Stretch         =   -1  'True
      Top             =   1680
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image15 
      Height          =   255
      Left            =   4320
      Picture         =   "Form3.frx":8542
      Stretch         =   -1  'True
      ToolTipText     =   "Close"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image14 
      Height          =   195
      Left            =   4080
      Picture         =   "Form3.frx":89BC
      Stretch         =   -1  'True
      ToolTipText     =   "Mini"
      Top             =   0
      Width           =   255
   End
   Begin VB.Image Image13 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":8E72
      Stretch         =   -1  'True
      Top             =   1440
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image12 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":D47C
      Stretch         =   -1  'True
      Top             =   1440
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image11 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":10746
      Stretch         =   -1  'True
      Top             =   1200
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image10 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":15148
      Stretch         =   -1  'True
      Top             =   1200
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image9 
      Height          =   135
      Left            =   480
      Picture         =   "Form3.frx":1800A
      Stretch         =   -1  'True
      Top             =   960
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image8 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":1C6FC
      Stretch         =   -1  'True
      Top             =   960
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image7 
      Height          =   135
      Left            =   120
      Picture         =   "Form3.frx":1FBD6
      Stretch         =   -1  'True
      Top             =   720
      Visible         =   0   'False
      Width           =   135
   End
   Begin VB.Image Image6 
      Height          =   90
      Left            =   480
      Picture         =   "Form3.frx":20E98
      Stretch         =   -1  'True
      Top             =   720
      Visible         =   0   'False
      Width           =   105
   End
   Begin VB.Image Image1 
      Height          =   825
      Left            =   960
      Picture         =   "Form3.frx":2268E
      Stretch         =   -1  'True
      ToolTipText     =   "Choose File"
      Top             =   840
      Width           =   945
   End
   Begin VB.Image Image2 
      Height          =   855
      Left            =   2760
      Picture         =   "Form3.frx":23950
      Stretch         =   -1  'True
      ToolTipText     =   "Choose Path"
      Top             =   840
      Width           =   1005
   End
   Begin VB.Image Image3 
      Height          =   855
      Left            =   960
      Picture         =   "Form3.frx":26E2A
      Stretch         =   -1  'True
      ToolTipText     =   "Mount"
      Top             =   1920
      Width           =   945
   End
   Begin VB.Image Image4 
      Height          =   855
      Left            =   2760
      Picture         =   "Form3.frx":29CEC
      Stretch         =   -1  'True
      ToolTipText     =   "Unmount"
      Top             =   1920
      Width           =   975
   End
   Begin VB.Image Image5 
      Height          =   3135
      Left            =   0
      MouseIcon       =   "Form3.frx":2CFB6
      Picture         =   "Form3.frx":2D2C0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   4695
   End
End
Attribute VB_Name = "Form3"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function GetWindowsDirectory Lib "kernel32" Alias "GetWindowsDirectoryA" (ByVal lpBuffer As String, ByVal nSize As Long) As Long
Private Declare Function GetCursorPos Lib "user32" (lpPoint As POINTAPI) As Long
Private Type POINTAPI '定义点(Point)结构
X As Long '点在X坐标(横坐标)上的坐标值
y As Long '点在Y坐标(纵坐标)上的坐标值
End Type
Private Sub Form_Load()
Call Round_Corners(Me)
Label1.Caption = Hour(Now)
Label2.Caption = Minute(Now)
Label3.Caption = Second(Now)
Label5.Caption = Label1.Caption + ":" + Label2.Caption + ":" + Label3.Caption
End Sub
Private Sub Image1_Click()
Form3.CommonDialog1.FileName = ""
Form3.CommonDialog1.ShowOpen
If Form3.CommonDialog1.FileName <> "" Then
Text1.Text = Form3.CommonDialog1.FileName
Text1.Visible = True
End If
End Sub
Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image1.Picture = Image6.Picture
Image3.Picture = Image10.Picture
Image2.Picture = Image8.Picture
Image4.Picture = Image12.Picture
End Sub
Private Sub Image14_Click()
Me.WindowState = 1
End Sub
Private Sub Image14_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image14.Picture = Image17.Picture
Image15.Picture = Image18.Picture
End Sub
Private Sub Image15_Click()
End
End Sub
Private Sub Image15_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image15.Picture = Image19.Picture
Image14.Picture = Image16.Picture
End Sub
Private Sub Image2_Click()
Form2.Text1 = ""
Form2.Dir1.Refresh
Form2.File1.Refresh
Form2.Image1.Picture = Form2.ImageList1.ListImages(1).ExtractIcon
Form2.Show vbModal, Me
End Sub
Private Sub Image2_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image2.Picture = Image9.Picture
Image1.Picture = Image7.Picture
Image3.Picture = Image10.Picture
Image4.Picture = Image12.Picture
End Sub
Private Sub Image20_Click()
          Dim sSave     As String, Ret       As Long
          sSave = Space(255)
          Ret = GetWindowsDirectory(sSave, 255)
          sSave = Left$(sSave, Ret)
Shell sSave + "\explorer.exe " + Text3.Text + Text2.Text + Text3.Text, vbNormalNoFocus
End Sub
Private Sub Image20_MouseDown(Button As Integer, Shift As Integer, X As Single, y As Single)
Image20.Picture = Image23.Picture
End Sub
Private Sub Image20_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
If Image20.Picture = none Then
Else
Image20.Picture = Image22.Picture
End If
End Sub
Private Sub Image3_Click()
If Text1.Text = "File Path" Or Text2.Text = "File Dir" Then
MsgBox "Please fill the file and dir！OK?", vbInformation, "信息"
Else
If MsgBox("只读是否！！！", vbYesNo, "信息") = vbYes Then
Shell (App.Path + "\imagex.exe /mount " + Text3.Text + Text1.Text + Text3.Text + " 1 " + Text3.Text + Text2.Text + Text3.Text), vbNormalNoFocus
Else
Shell (App.Path + "\imagex.exe /mountrw " + Text3.Text + Text1.Text + Text3.Text + " 1 " + Text3.Text + Text2.Text + Text3.Text), vbNormalNoFocus
End If
End If
If Text2.Visible = True And Text1.Visible = True Then
Image20.Visible = True
Image20.Picture = Image21.Picture
End If
End Sub
Private Sub Image3_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image1.Picture = Image7.Picture
Image2.Picture = Image8.Picture
Image3.Picture = Image11.Picture
Image4.Picture = Image12.Picture
End Sub
Private Sub Image4_Click()
If Text2.Text = "File Dir" Then
MsgBox "Please fill the dir！OK?", vbInformation, "信息"
Else
If MsgBox("只读是否！！！", vbYesNo, "信息") = vbYes Then
Shell (App.Path + "\imagex.exe /unmount " + Text3.Text + Text2.Text + Text3.Text), vbNormalNoFocus
Else
Shell (App.Path + "\imagex.exe /unmount /commit " + Text3.Text + Text2.Text + Text3.Text), vbNormalNoFocus
End If
End If
If Text2.Visible = True Then
Image20.Visible = False
Image20.Picture = Nothing
End If
End Sub
Private Sub Image4_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image1.Picture = Image7.Picture
Image2.Picture = Image8.Picture
Image4.Picture = Image13.Picture
Image3.Picture = Image10.Picture
End Sub
Private Sub Image5_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Image3.Picture = Image10.Picture
Image2.Picture = Image8.Picture
Image4.Picture = Image12.Picture
Image1.Picture = Image7.Picture
Image14.Picture = Image16.Picture
Image15.Picture = Image18.Picture
If Text2.Visible = True And Text1.Visible = True Then
Image20.Picture = Image21.Picture
End If
End Sub
Private Sub Image5_MouseUp(Button As Integer, Shift As Integer, X As Single, y As Single)
Dim dl As Long
Dim MyPoint As POINTAPI
dl& = GetCursorPos(MyPoint) '调用函数，获取屏幕鼠标坐标
Me.Left = Str(MyPoint.X) * 15 - (1 / 2) * Form3.ScaleWidth
Me.Top = Str(MyPoint.y) * 15 - (1 / 2) * Form3.ScaleHeight
End Sub
Private Sub Text1_Change()
If Text1.Text = "" Or Text1.Text = "File Path" Then
Text1.Visible = False
End If
End Sub
Private Sub Text2_Change()
If Text2.Text = "" Or Text2.Text = "File Dir" Then
Text2.Visible = False
End If
End Sub
Private Sub Timer2_Timer()
Label1.Caption = Hour(Now)
Label2.Caption = Minute(Now)
Label3.Caption = Second(Now)
Label4.Caption = Label1.Caption + ":" + Label2.Caption + ":" + Label3.Caption
End Sub
