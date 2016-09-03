VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "STAT修改器"
   ClientHeight    =   3120
   ClientLeft      =   3270
   ClientTop       =   4110
   ClientWidth     =   4695
   Icon            =   "Form1.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3120
   ScaleWidth      =   4695
   StartUpPosition =   2  '屏幕中心
   Begin VB.TextBox Text6 
      Height          =   375
      Left            =   1200
      TabIndex        =   20
      Top             =   0
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.FileListBox File1 
      Height          =   270
      Left            =   3720
      Pattern         =   "*.jpg;*.bmp"
      TabIndex        =   19
      Top             =   0
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.TextBox Text5 
      Enabled         =   0   'False
      Height          =   270
      Left            =   6840
      TabIndex        =   17
      ToolTipText     =   "不要太大，否则回失效"
      Top             =   1320
      Width           =   1815
   End
   Begin VB.ComboBox Combo2 
      Enabled         =   0   'False
      Height          =   300
      Left            =   6840
      TabIndex        =   14
      Top             =   720
      Width           =   1815
   End
   Begin VB.ComboBox Combo1 
      Enabled         =   0   'False
      Height          =   300
      IMEMode         =   1  'ON
      ItemData        =   "Form1.frx":27A2
      Left            =   6840
      List            =   "Form1.frx":27A4
      TabIndex        =   13
      Top             =   240
      Width           =   1815
   End
   Begin VB.TextBox Text4 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   1200
      TabIndex        =   12
      Top             =   1680
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.TextBox Text3 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   1200
      TabIndex        =   11
      Top             =   1320
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.TextBox Text2 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   1200
      TabIndex        =   10
      Top             =   960
      Visible         =   0   'False
      Width           =   2535
   End
   Begin VB.TextBox Text1 
      Appearance      =   0  'Flat
      Height          =   375
      Left            =   1200
      TabIndex        =   9
      Top             =   480
      Visible         =   0   'False
      Width           =   2535
   End
   Begin MSComctlLib.ProgressBar ProgressBar1 
      Height          =   135
      Left            =   0
      TabIndex        =   7
      Top             =   2160
      Visible         =   0   'False
      Width           =   4680
      _ExtentX        =   8255
      _ExtentY        =   238
      _Version        =   393216
      Appearance      =   1
      Scrolling       =   1
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Interval        =   1
      Left            =   4200
      Top             =   2640
   End
   Begin MSComDlg.CommonDialog CommonDialog1 
      Left            =   0
      Top             =   2520
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "My Setting Picture:"
      Height          =   495
      Left            =   0
      TabIndex        =   21
      Top             =   0
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Image Image9 
      Height          =   360
      Left            =   8640
      Picture         =   "Form1.frx":27A6
      ToolTipText     =   "还原！！！"
      Top             =   1320
      Width           =   360
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "飘动速度："
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   14.25
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   5280
      TabIndex        =   18
      Top             =   1200
      Width           =   1695
   End
   Begin VB.Image Image8 
      Height          =   825
      Left            =   4680
      Picture         =   "Form1.frx":2E90
      Stretch         =   -1  'True
      Top             =   0
      Width           =   720
   End
   Begin VB.Line Line5 
      X1              =   4920
      X2              =   4920
      Y1              =   2160
      Y2              =   840
   End
   Begin VB.Line Line4 
      X1              =   5400
      X2              =   9120
      Y1              =   120
      Y2              =   120
   End
   Begin VB.Line Line3 
      X1              =   9120
      X2              =   9120
      Y1              =   120
      Y2              =   2160
   End
   Begin VB.Line Line2 
      X1              =   4920
      X2              =   9120
      Y1              =   2160
      Y2              =   2160
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "五颜六色："
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   14.25
         Charset         =   134
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5280
      TabIndex        =   16
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "字体飘动："
      BeginProperty Font 
         Name            =   "宋体"
         Size            =   14.25
         Charset         =   134
         Weight          =   400
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   5400
      TabIndex        =   15
      Top             =   240
      Width           =   1455
   End
   Begin VB.Image Image7 
      Height          =   360
      Left            =   4200
      Picture         =   "Form1.frx":357A
      Stretch         =   -1  'True
      ToolTipText     =   "Come on！！进入更多修改？！"
      Top             =   1800
      Width           =   360
   End
   Begin VB.Line Line1 
      X1              =   4680
      X2              =   4680
      Y1              =   0
      Y2              =   3120
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
      TabIndex        =   8
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
      TabIndex        =   6
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
      TabIndex        =   5
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
      TabIndex        =   4
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
      TabIndex        =   3
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
      TabIndex        =   2
      Top             =   1320
      Width           =   975
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "STAT程序音乐路径："
      Height          =   495
      Left            =   0
      TabIndex        =   1
      Top             =   960
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "STAT程序图片路径："
      Height          =   495
      Left            =   0
      TabIndex        =   0
      Top             =   480
      Width           =   1215
   End
   Begin VB.Image Image6 
      Height          =   3135
      Left            =   4680
      Picture         =   "Form1.frx":3B04
      Stretch         =   -1  'True
      Top             =   0
      Width           =   4695
   End
   Begin VB.Image Image1 
      Height          =   3135
      Left            =   0
      Picture         =   "Form1.frx":2340A
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

Private Sub Combo1_Click()
If Combo1.Text = "True" Then
Text5.Enabled = True
Image9.Enabled = True
Else
Text5.Enabled = False
Image9.Enabled = False
End If
End Sub

Private Sub Command1_Click()
            Form1.CommonDialog1.FileName = ""
             Form1.CommonDialog1.Filter = "Picture File(*.BMP;*.GIF;*.JPG)|*.BMP;*.GIF;*.JPG"
             Form1.CommonDialog1.ShowOpen
         If Form1.CommonDialog1.FileName <> "" Then
               Form1.Text1.Text = Form1.CommonDialog1.FileName
                      
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
 On Error GoTo e
Open App.Path + "\setting.ini" For Output As #1
Print #1, "[Picture]"
Print #1, Text1.Text
Print #1, "[Music]"
Print #1, Text2.Text
Print #1, "[Time Up]"
Print #1, Text3.Text
Print #1, "[Font]"
Print #1, Text4.Text
Print #1, "[True/False]"
Print #1, Combo1.Text
Print #1, Combo2.Text
Print #1, "[Times]"
Print #1, Text5.Text
Print #1, "[Pic For Me]"
Print #1, Text6.Text
Close #1
MsgBox "修改成功！！！", vbInformation, "STAT修改器"
End
Exit Sub
e: MsgBox "修改失败？？？", vbInformation, "STAT修改器"
End Sub

Private Sub command3_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = True

End Sub

Private Sub Form_Load()
On Error Resume Next
Open App.Path + "\setting.ini" For Input As #1
 Line Input #1, s$
 Line Input #1, s1
 Line Input #1, sp
 Line Input #1, s2
 Line Input #1, sO
 Line Input #1, s3
 Line Input #1, sD
 Line Input #1, s4
  Line Input #1, SE
 Line Input #1, s5
 Line Input #1, s6
 Line Input #1, sw
 Line Input #1, s7
 Line Input #1, sp
 Line Input #1, s8
Text1.Text = s1
 Text2.Text = s2
 Text3.Text = s3
 Text4.Text = s4
Combo1.Text = s5
Combo2.Text = s6
Text5.Text = s7
Text6.Text = s8
 Close #1
Combo1.AddItem "True"
Combo1.AddItem "False"
Combo2.AddItem "True"
Combo2.AddItem "False"
Timer1.Enabled = True
File1.Path = Text6.Text
If Text1.Text = "" And Text2.Text = "" And Text3.Text = "" And Text4.Text = "" Then
Text6.Visible = True
Image9.Visible = True
End If
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub

Private Sub Image1_Click()



Timer1.Enabled = False


End Sub

Private Sub Image1_DblClick()
Timer1.Enabled = True
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Text1.Visible = False
Text2.Visible = False
Text3.Visible = False
Text4.Visible = False
ProgressBar1.Visible = False
Shape1.Visible = False
Shape2.Visible = False
Shape4.Visible = False

End Sub


Private Sub Image2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Text1.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Text2.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Text3.Visible = True
ProgressBar1.Visible = False
End Sub


Private Sub Image5_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Text4.Visible = True
End Sub

Private Sub Image7_Click()

If Form1.Width = 4785 Then
Form1.Left = Form1.Left - 2287.5
Form1.Width = 9450
Form1.ProgressBar1.Width = 9360
command3.Left = 4200
Shape3.Left = 4200
Form1.Combo1.Enabled = True
Form1.Combo2.Enabled = True
If Combo1.Text = "True" Then
Text5.Enabled = True
Image9.Enabled = True
Else
Text5.Enabled = False
Image9.Enabled = False
End If
Else
Form1.Left = Form1.Left + 2287.5
Form1.Width = 4785
Form1.ProgressBar1.Width = 4680
command3.Left = 1920
Form1.Shape3.Left = 1920
Form1.Combo1.Enabled = False
Form1.Combo2.Enabled = False
Text5.Enabled = False
Image9.Enabled = False
End If


End Sub

Private Sub Image9_Click()
Text5.Text = 1000
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
Text3.Text = "6000"
End Sub

Private Sub Label5_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Shape4.Visible = True
ProgressBar1.Visible = False
End Sub

Private Sub text1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub text2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub text3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub


Private Sub text4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ProgressBar1.Visible = False
End Sub

Private Sub Timer1_Timer()
On Error GoTo e
Dim f As Integer
f = File1.ListIndex + 1
File1.ListIndex = f

Image1.Picture = LoadPicture(Text6.Text + "\" + File1.FileName)

 Exit Sub
e: File1.ListIndex = -1
End Sub


Private Sub Timer2_Timer()

Dim a As Integer
a = 3000
Label9.Caption = a
While a > 0
a = a - 1
Wend
Image6.Top = Image6.Top + 1
Image6.Left = Image6.Left + 1
Image6.Top = Image6.Top - 1
Image6.Left = Image6.Left - 1

End Sub

