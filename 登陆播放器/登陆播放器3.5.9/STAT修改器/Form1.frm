VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "STAT修改器"
   ClientHeight    =   3090
   ClientLeft      =   5235
   ClientTop       =   4605
   ClientWidth     =   4680
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   Begin RichTextLib.RichTextBox RichTextBox4 
      Height          =   375
      Left            =   1200
      TabIndex        =   12
      Top             =   1680
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      _Version        =   393217
      Enabled         =   -1  'True
      Appearance      =   0
      TextRTF         =   $"Form1.frx":27A2
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   135
      Left            =   0
      TabIndex        =   10
      Top             =   2160
      Visible         =   0   'False
      Width           =   4680
      _ExtentX        =   8255
      _ExtentY        =   238
      _Version        =   393216
      Appearance      =   1
      Scrolling       =   1
   End
   Begin VB.Timer Timer3 
      Enabled         =   0   'False
      Interval        =   650
      Left            =   3000
      Top             =   2640
   End
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Interval        =   1300
      Left            =   3600
      Top             =   2640
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   3600
      Left            =   4200
      Top             =   2640
   End
   Begin RichTextLib.RichTextBox RichTextBox3 
      Height          =   375
      Left            =   1200
      TabIndex        =   4
      Top             =   1320
      Visible         =   0   'False
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      _Version        =   393217
      Enabled         =   -1  'True
      Appearance      =   0
      TextRTF         =   $"Form1.frx":283F
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   4200
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin RichTextLib.RichTextBox RichTextBox2 
      Height          =   375
      Left            =   1200
      TabIndex        =   1
      Top             =   960
      Visible         =   0   'False
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      _Version        =   393217
      MultiLine       =   0   'False
      ReadOnly        =   -1  'True
      Appearance      =   0
      AutoVerbMenu    =   -1  'True
      TextRTF         =   $"Form1.frx":28DC
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   375
      Left            =   1200
      TabIndex        =   0
      Top             =   480
      Visible         =   0   'False
      Width           =   2535
      _ExtentX        =   4471
      _ExtentY        =   661
      _Version        =   393217
      Enabled         =   -1  'True
      MultiLine       =   0   'False
      ReadOnly        =   -1  'True
      Appearance      =   0
      AutoVerbMenu    =   -1  'True
      TextRTF         =   $"Form1.frx":2979
   End
   Begin VB.Image Image5 
      Height          =   375
      Left            =   1200
      Top             =   1680
      Width           =   2535
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "开机字体："
      Height          =   255
      Left            =   120
      TabIndex        =   11
      Top             =   1800
      Width           =   975
   End
   Begin VB.Shape Shape4 
      Height          =   375
      Left            =   3720
      Top             =   1320
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   " 还原"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3720
      TabIndex        =   9
      Top             =   1320
      Width           =   855
   End
   Begin VB.Label command2 
      BackStyle       =   0  'Transparent
      Caption         =   " 音乐"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3720
      TabIndex        =   8
      Top             =   960
      Width           =   855
   End
   Begin VB.Label command1 
      BackStyle       =   0  'Transparent
      Caption         =   " 图片"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3720
      TabIndex        =   7
      Top             =   480
      Width           =   855
   End
   Begin VB.Label command3 
      BackStyle       =   0  'Transparent
      Caption         =   "  更改"
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   12
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   1920
      TabIndex        =   6
      Top             =   2400
      Width           =   975
   End
   Begin VB.Shape Shape3 
      Height          =   255
      Left            =   1920
      Top             =   2400
      Width           =   975
   End
   Begin VB.Shape Shape2 
      BorderColor     =   &H8000000D&
      Height          =   375
      Left            =   3720
      Top             =   960
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Shape Shape1 
      BorderColor     =   &H8000000D&
      FillColor       =   &H8000000C&
      Height          =   375
      Left            =   3720
      Top             =   480
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Image Image4 
      Height          =   375
      Left            =   1200
      Top             =   1320
      Width           =   2535
   End
   Begin VB.Image Image3 
      Height          =   375
      Left            =   1200
      Top             =   960
      Width           =   2535
   End
   Begin VB.Image Image2 
      Height          =   375
      Left            =   1200
      Top             =   480
      Width           =   2535
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "开机图片出现（毫秒）："
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   1320
      Width           =   975
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "STAT程序音乐路径："
      Height          =   495
      Left            =   0
      TabIndex        =   3
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "STAT程序图片路径："
      Height          =   495
      Left            =   0
      TabIndex        =   2
      Top             =   480
      Width           =   1215
   End
   Begin VB.Image Image1 
      Height          =   3135
      Left            =   0
      Picture         =   "Form1.frx":2A16
      Stretch         =   -1  'True
      Top             =   0
      Width           =   4695
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub Command1_Click()
            Form1.CommonDialog1.FileName = ""
             Form1.CommonDialog1.Filter = "Picture File(*.BMP;*.GIF;*.JPG)|*.BMP;*.GIF;*.JPG"
             Form1.CommonDialog1.ShowOpen
         If Form1.CommonDialog1.FileName <> "" Then
               Form1.RichTextBox1.Text = Form1.CommonDialog1.FileName
                      
            End If


End Sub

Private Sub Command1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape1.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Command2_Click()
Form2.Show vbModal, Me

End Sub

Private Sub command2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape2.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Command3_Click()

    Dim i As Integer
    For i = 1 To 100
    If ProgressBar1.Value < ProgressBar1.Max Then
    ProgressBar1.Value = ProgressBar1.Value + 1
   End If
 Next i
 Dim sfile, sfiles, sfilese, sfiless As String
sfile = App.Path + "\dll\s.dll"
sfiles = App.Path + "\dll\d.dll"
sfilese = App.Path + "\dll\t.dll"
sfiless = App.Path + "\dll\w.dll"
On Error Resume Next
RmDir App.Path + "\DLL"
 MkDir App.Path + "\DLL"
Form1.RichTextBox1.SaveFile sfile
Form1.RichTextBox2.SaveFile sfiles
Form1.RichTextBox3.SaveFile sfilese
Form1.RichTextBox4.SaveFile sfiless
MsgBox "修改成功！！！", vbInformation, "STAT修改器"
End

End Sub

Private Sub command3_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = True

End Sub

Private Sub Form_Load()
On Error Resume Next
RichTextBox1.LoadFile App.Path + "\dll\s.dll"
RichTextBox2.LoadFile App.Path + "\dll\d.dll"
RichTextBox3.LoadFile App.Path + "\dll\t.dll"
RichTextBox4.LoadFile App.Path + "\dll\w.dll"
Timer1.Enabled = True

End Sub

Private Sub Picture1_Click()
RichTextBox3.Text = 1

End Sub


Private Sub Picture2_Click()
RichTextBox3.Text = (2)
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub

Private Sub Image1_Click()


If Timer1.Enabled = True Or Timer2.Enabled = True Or Timer3.Enabled = True Then
Timer1.Enabled = False
Timer2.Enabled = False
Timer3.Enabled = False
End If

End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RichTextBox1.Visible = False
RichTextBox2.Visible = False
RichTextBox3.Visible = False
RichTextBox4.Visible = False
ProgressBar1.Visible = False
Shape1.Visible = False
Shape2.Visible = False
Shape4.Visible = False

End Sub


Private Sub Image2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RichTextBox1.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RichTextBox2.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RichTextBox3.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image5_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
RichTextBox4.Visible = True
End Sub

Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub Label2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub Label3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub Label5_Click()
RichTextBox3.Text = "6000"
End Sub

Private Sub Label5_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape4.Visible = True
ProgressBar1.Visible = False
End Sub

Private Sub Label6_Click()
RichTextBox4.Text = "60000"
End Sub

Private Sub Label6_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape5.Visible = True
End Sub



Private Sub RichTextBox1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub RichTextBox2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub RichTextBox3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub RichTextBox4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub

Private Sub Timer1_Timer()
On Error Resume Next
Image1.Picture = LoadPicture(App.Path + "\IMAGE\1.JPG")
Timer2.Enabled = True

End Sub


Private Sub Timer2_Timer()
On Error Resume Next
Image1.Picture = LoadPicture(App.Path + "\IMAGE\2.JPG")
Timer3.Enabled = True
End Sub


Private Sub Timer3_Timer()
On Error Resume Next
Image1.Picture = LoadPicture(App.Path + "\IMAGE\3.JPG")
End Sub


