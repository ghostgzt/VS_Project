VERSION 5.00
Begin VB.Form fMaintenance 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "数据库维护"
   ClientHeight    =   3390
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4605
   BeginProperty Font 
      Name            =   "Tahoma"
      Size            =   8.25
      Charset         =   0
      Weight          =   400
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "fMaintenance.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   LockControls    =   -1  'True
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   226
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   307
   ShowInTaskbar   =   0   'False
   StartUpPosition =   1  '所有者中心
   Begin VB.CheckBox chkCompactDatabase 
      Caption         =   "压缩数据库(&C)"
      Enabled         =   0   'False
      Height          =   270
      Left            =   240
      TabIndex        =   6
      Top             =   1650
      Width           =   2760
   End
   Begin VB.CheckBox chkDeleteThumbnails 
      Caption         =   "删除所有缩略图(&D)"
      Height          =   270
      Left            =   240
      TabIndex        =   5
      Top             =   1320
      Width           =   2760
   End
   Begin VB.CommandButton cmdStart 
      Caption         =   "开始(&S)"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   405
      Left            =   1725
      TabIndex        =   8
      Top             =   2850
      Width           =   1215
   End
   Begin Thumbnailer.ucProgress ucProgress 
      Height          =   240
      Left            =   240
      Top             =   2385
      Width           =   4110
      _ExtentX        =   7250
      _ExtentY        =   423
      BorderStyle     =   1
   End
   Begin VB.CheckBox chkCheckThumbnails 
      Caption         =   "检查所有缩略图(&A)"
      Height          =   270
      Left            =   240
      TabIndex        =   4
      Top             =   990
      Width           =   2760
   End
   Begin VB.Label lblSizeVal 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   2010
      TabIndex        =   1
      Top             =   240
      Width           =   2040
   End
   Begin VB.Label lblThumbnailsVal 
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   2010
      TabIndex        =   3
      Top             =   540
      Width           =   2040
   End
   Begin VB.Label lblThumbnails 
      Caption         =   "当前缩略图:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   240
      TabIndex        =   2
      Top             =   540
      Width           =   1830
   End
   Begin VB.Label lblSize 
      Caption         =   "当前大小:"
      BeginProperty Font 
         Name            =   "Tahoma"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   1830
   End
   Begin VB.Label lblInfo 
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   2100
      Width           =   3990
   End
End
Attribute VB_Name = "fMaintenance"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'#########################################################################
'★★★★★         http://www.cnpopsoft.com [华普软件]         ★★★★★
'★★★★★             VB专业论文与源码荟萃                    ★★★★★
'#########################################################################

Option Explicit

Private Sub Form_Load()
    Dim uDBI As DATABASE_INFO
    Set Me.Icon = Nothing
    
    uDBI = mThumbnail.GetDatabaseInfo()
    With uDBI
        lblSizeVal.Caption = Format$(.Size / 1024, "#,0 Kb")
        lblThumbnailsVal.Caption = Format$(.Entries, "#,#0")
    End With
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
    
    If (KeyCode = vbKeyEscape) Then
        Call Unload(Me)
    End If
End Sub

Private Sub Form_Unload(Cancel As Integer)
    
    Set fMaintenance = Nothing
End Sub


Private Sub chkCheckThumbnails_Click()
    cmdStart.Enabled = chkCheckThumbnails Or chkDeleteThumbnails Or chkCompactDatabase
End Sub
Private Sub chkDeleteThumbnails_Click()
    cmdStart.Enabled = chkCheckThumbnails Or chkDeleteThumbnails Or chkCompactDatabase
    chkCompactDatabase.Enabled = chkDeleteThumbnails
End Sub
Private Sub chkCompactDatabase_Click()
    cmdStart.Enabled = chkCheckThumbnails Or chkDeleteThumbnails Or chkCompactDatabase
End Sub

Private Sub cmdStart_Click()
    
  Dim uDBI As DATABASE_INFO
  
    Screen.MousePointer = vbHourglass
    
    If (chkDeleteThumbnails) Then
        Call mThumbnail.DeleteAllThumbnails(lblInfo)
    End If
    If (chkCheckThumbnails) Then
        Call mThumbnail.CheckAllThumbnails(ucProgress, lblInfo)
    End If
    If (chkCompactDatabase And chkCompactDatabase.Enabled) Then
        Call mThumbnail.CompactDatabase(lblInfo)
    End If
    
    uDBI = mThumbnail.GetDatabaseInfo()
    With uDBI
        lblSizeVal.Caption = Format$(.Size / 1024, "#,0 Kb")
        lblThumbnailsVal.Caption = Format$(.Entries, "#,#0")
    End With

    Screen.MousePointer = vbDefault
End Sub

