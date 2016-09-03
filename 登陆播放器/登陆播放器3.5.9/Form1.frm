VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{6BF52A50-394A-11D3-B153-00C04F79FAA6}#1.0#0"; "wmp.dll"
Begin VB.Form Form1 
   BorderStyle     =   0  'None
   Caption         =   "STAT登陆播放器"
   ClientHeight    =   5055
   ClientLeft      =   4500
   ClientTop       =   3345
   ClientWidth     =   6825
   ControlBox      =   0   'False
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Moveable        =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   5055
   ScaleWidth      =   6825
   ShowInTaskbar   =   0   'False
   Begin RichTextLib.RichTextBox RichTextBox4 
      Height          =   375
      Left            =   4200
      TabIndex        =   5
      Top             =   4680
      Visible         =   0   'False
      Width           =   2655
      _ExtentX        =   4683
      _ExtentY        =   661
      _Version        =   393217
      Enabled         =   -1  'True
      TextRTF         =   $"Form1.frx":14BCB
   End
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Interval        =   1
      Left            =   4560
      Top             =   4680
   End
   Begin RichTextLib.RichTextBox RichTextBox3 
      Height          =   375
      Left            =   0
      TabIndex        =   4
      Top             =   4680
      Visible         =   0   'False
      Width           =   2775
      _ExtentX        =   4895
      _ExtentY        =   661
      _Version        =   393217
      TextRTF         =   $"Form1.frx":14C68
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   6360
      Top             =   4680
   End
   Begin RichTextLib.RichTextBox RichTextBox2 
      Height          =   375
      Left            =   3120
      TabIndex        =   2
      Top             =   0
      Visible         =   0   'False
      Width           =   3735
      _ExtentX        =   6588
      _ExtentY        =   661
      _Version        =   393217
      TextRTF         =   $"Form1.frx":14D05
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   375
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Visible         =   0   'False
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   661
      _Version        =   393217
      TextRTF         =   $"Form1.frx":14DA2
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
      TabIndex        =   3
      Top             =   3600
      Width           =   4455
   End
   Begin WMPLibCtl.WindowsMediaPlayer WindowsMediaPlayer1 
      Height          =   3120
      Left            =   1320
      TabIndex        =   1
      Top             =   360
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
    On Error Resume Next
RichTextBox4.LoadFile (App.Path + "\dll\w.dll")
RichTextBox3.LoadFile (App.Path + "\dll\t.dll")
Timer1.Interval = RichTextBox3.Text
RichTextBox1.LoadFile (App.Path + "\dll\s.dll")
Image1.Picture = LoadPicture(RichTextBox1.Text)
RichTextBox2.LoadFile (App.Path + "\dll\d.dll")
If RichTextBox1.Text = "" Or RichTextBox2.Text = "" Then
 Form1.Visible = False
 Timer2.Enabled = True
End If
Timer1.Enabled = True
Form1.WindowsMediaPlayer1.URL = RichTextBox2.Text
End Sub

Private Sub Image1_Click()
End
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
Form1.Label1.Caption = ""
End Sub

Private Sub Label1_Click()
frmAbout.Show vbModal, Me
End Sub

Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, y As Single)
If RichTextBox4.Text = "" Then
Label1.Caption = "欢迎登陆"
Else
Label1.Caption = RichTextBox4.Text
End If
End Sub

Private Sub Timer1_Timer()
Form1.Visible = False
Timer1.Enabled = False
End Sub

Private Sub Timer2_Timer()
MsgBox "请先运行STAT修改器进行设置", vbInformation, "STAT登陆播放器未进行设置"

Dim retval
retval = Shell(App.Path + "\STAT修改器.exe", 1)
Timer2.Enabled = False
MsgBox "完成后请重新启动！！", vbInformation
End
End Sub

