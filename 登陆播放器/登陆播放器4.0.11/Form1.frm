VERSION 5.00
Object = "{6BF52A50-394A-11D3-B153-00C04F79FAA6}#1.0#0"; "wmp.dll"
Begin VB.Form Form1 
   BorderStyle     =   0  'None
   Caption         =   "STAT登陆播放器"
   ClientHeight    =   5055
   ClientLeft      =   7590
   ClientTop       =   165
   ClientWidth     =   6825
   ControlBox      =   0   'False
   DrawStyle       =   5  'Transparent
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   337
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   455
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  '屏幕中心
   Begin VB.PictureBox Image2 
      AutoSize        =   -1  'True
      Height          =   1815
      Left            =   480
      ScaleHeight     =   7.313
      ScaleMode       =   4  'Character
      ScaleWidth      =   16.625
      TabIndex        =   10
      Top             =   2640
      Visible         =   0   'False
      Width           =   2055
   End
   Begin VB.TextBox Text7 
      Height          =   270
      Left            =   4200
      TabIndex        =   9
      Top             =   1560
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.TextBox Text6 
      Height          =   270
      Left            =   4200
      TabIndex        =   8
      Top             =   1320
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.TextBox Text5 
      Height          =   270
      Left            =   4200
      TabIndex        =   7
      Top             =   1080
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.Timer Timer3 
      Enabled         =   0   'False
      Interval        =   100
      Left            =   5640
      Top             =   4680
   End
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Interval        =   1000
      Left            =   6000
      Top             =   4680
   End
   Begin VB.Timer Timer1 
      Left            =   6360
      Top             =   4680
   End
   Begin VB.TextBox Text4 
      Height          =   270
      Left            =   4200
      TabIndex        =   5
      Top             =   600
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.TextBox Text3 
      Height          =   270
      Left            =   4200
      TabIndex        =   4
      Top             =   360
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.TextBox Text2 
      Height          =   270
      Left            =   4200
      TabIndex        =   3
      Top             =   840
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.TextBox Text1 
      Height          =   270
      Left            =   4200
      TabIndex        =   2
      Top             =   120
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "华文行楷"
         Size            =   26.25
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   795
      Left            =   2280
      TabIndex        =   1
      Top             =   3600
      Width           =   4455
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Height          =   975
      Left            =   0
      TabIndex        =   6
      Top             =   3480
      Width           =   6735
   End
   Begin WMPLibCtl.WindowsMediaPlayer WindowsMediaPlayer1 
      Height          =   3120
      Left            =   1440
      TabIndex        =   0
      Top             =   480
      Visible         =   0   'False
      Width           =   4200
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
      uiMode          =   "invisible"
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
      _cx             =   7408
      _cy             =   5503
   End
   Begin VB.Image Image1 
      Height          =   5055
      Left            =   0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Call Round_Corners(Me)
    Call Make_On_Top(Me.HWND, True)
   On Error GoTo e
  Open App.Path + "\setting.ini" For Input As #1
 Line Input #1, s$
 Line Input #1, s1
 Line Input #1, sP
 Line Input #1, s2
 Line Input #1, sO
 Line Input #1, s3
 Line Input #1, SF
 Line Input #1, s4
 Line Input #1, SE
 Line Input #1, s5
 Line Input #1, s6
 Line Input #1, sw
Line Input #1, s7
Text1.Text = s1
 Text2.Text = s2
 Text3.Text = s3
 Text4.Text = s4
 Text5.Text = s5
 Text6.Text = s6
Text7.Text = s7
 Close #1

 If Text3.Text = "" Then
Else
Timer1.Interval = Text3.Text
  If Text3.Text >= 65001 Then
  GoTo e
  End If
  End If
  Timer1.Enabled = True
Image1.Picture = LoadPicture(Text1.Text)
Image2.Picture = LoadPicture(Text1.Text)
If Image2.Height > 6000 Then
Else
Me.Height = Image2.Height
Me.Width = Image2.Width
Label1.Top = 3 / 4 * Form1.Height
Label2.Top = 3 / 4 * Form1.Height
End If
If Image2.Width > 8000 Then
Else
Me.Height = Image2.Height
Me.Width = Image2.Width
Label1.Top = 3 / 4 * Form1.Height
Label2.Top = 3 / 4 * Form1.Height
End If
Image1.Height = Me.Height
Image1.Width = Me.Width

 Call Round_Corners(Me)
    Call Make_On_Top(Me.HWND, True)
If Text7.Text = "" Then
Else
  If Text7.Text >= 65001 Then
  GoTo e
  End If
  End If
If Text1.Text = "" Or Text2.Text = "" Then
 Form1.Visible = False
 End If

Form1.WindowsMediaPlayer1.URL = Text2.Text
Exit Sub
e:
MsgBox "请先运行STAT修改器进行设置", vbInformation, "STAT登陆播放器未进行设置"
Dim retval
retval = Shell(App.Path + "\STAT修改器.exe", 1)
End
End Sub
Private Sub Image1_Click()
End
End Sub
Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Label1.AutoSize = False
Form1.Label1.Caption = ""
Timer2.Enabled = False
Timer3.Enabled = False
End Sub
Private Sub Label1_Click()
frmAbout.Show
End Sub
Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
On Error GoTo e
If Text4.Text = "" Then
Label1.Caption = "欢迎登陆"
Label1.AutoSize = True
Else
Label1.Caption = Text4.Text
Label1.AutoSize = True
  If Text5.Text = "" Then
Else
Timer2.Enabled = Text5
End If
 If Text6.Text = "" Then
Else
Timer3.Enabled = Text6
End If
End If
Exit Sub
e:
MsgBox "请先运行STAT修改器进行设置", vbInformation, "STAT登陆播放器未进行设置"
Dim retval
retval = Shell(App.Path + "\STAT修改器.exe", 1)
End Sub
Private Sub Label2_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
On Error GoTo e
If Text4.Text = "" Then
Label1.Caption = "欢迎登陆"
Label1.AutoSize = True
Else
Label1.Caption = Text4.Text
Label1.AutoSize = True
  If Text5.Text = "" Then
Else
Timer2.Enabled = Text5
End If
 If Text6.Text = "" Then
Else
Timer3.Enabled = Text6
End If
End If
Exit Sub
e:
MsgBox "请先运行STAT修改器进行设置", vbInformation, "STAT登陆播放器未进行设置"
Dim retval
retval = Shell(App.Path + "\STAT修改器.exe", 1)
End Sub
Private Sub Timer1_Timer()
Form1.Visible = False
Timer1.Enabled = False
frmAbout.Show vbModal, Me
End Sub
Private Sub Timer2_Timer()
On Error Resume Next
Label1.Left = Label1.Left - Text7
If Label1.Left <= -(Label1.Left + Label1.Width) Then
Label1.Left = Form1.Width
End If
End Sub
Private Sub Timer3_Timer()
    Dim r As Byte, G As Byte, B As Byte
    Randomize
    r = Int(Rnd * 255) + 1                     '随机产生RGB颜色值
    G = Int(Rnd * 255) + 1
    B = Int(Rnd * 255) + 1
    Label1.ForeColor = RGB(r, G, B)
End Sub
