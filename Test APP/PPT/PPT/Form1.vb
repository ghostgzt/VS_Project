Imports PowerPoint
Imports Office = Microsoft.Office.Core
'Imports Graph = Microsoft.Office.Interop.Graph
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim oApp As PowerPoint.Application
    Dim oPres As PowerPoint.Presentation
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim sTemplate = "C:\09gaokao.ppt"
        ' 如果前面 模版无效，请改变上面的内容。
        'Const sVideo = "C:\WINDOWS\system32\oobe\images\intro.wmv"

        Dim oPresentations As PowerPoint.Presentations
        Dim oSlides As PowerPoint.Slides
        Dim oSlide As PowerPoint.Slide
        Dim oShapes As PowerPoint.Shapes
        Dim oShape As PowerPoint.Shape
        Dim oMovie As PowerPoint.Shape
        Dim oAnimationSettings As PowerPoint.AnimationSettings
        Dim oPlaySettings As PowerPoint.PlaySettings
        Dim oTextFrame As PowerPoint.TextFrame
        Dim oTextRange As PowerPoint.TextRange
        Dim oFont As PowerPoint.Font
        Dim oOLEFormat As PowerPoint.OLEFormat
        Dim oShadow As PowerPoint.ShadowFormat
        Dim oForeColor As PowerPoint.ColorFormat
        Dim oRange As PowerPoint.SlideRange
        Dim oSlideShowTransition As PowerPoint.SlideShowTransition

        '启动PowerPoint然后把其窗口最小化。
        oApp = New PowerPoint.Application

        '增加事件句柄
        'AddHandler oApp.SlideShowBegin, AddressOf oApp_SlideShowBegin
        'AddHandler oApp.SlideShowNextSlide, AddressOf oApp_SlideShowNextSlide
        AddHandler oApp.PresentationClose, AddressOf oApp_PresentationClose

        oApp.Visible = True
        oApp.WindowState = PowerPoint.PpWindowState.ppWindowMinimized

        '用指定的模版建立一个新演示文稿。
        oPresentations = oApp.Presentations
        oPres = oPresentations.Open(sTemplate, , , True)

        ''建立幻灯片1
        ''增加文本到该幻灯片，设置字体然后插入一个影片。
        'oSlides = oPres.Slides
        'oSlide = oSlides.Add(1, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
        'oShapes = oSlide.Shapes
        'oShape = oShapes.Item(1)
        'oTextFrame = oShape.TextFrame
        'oTextRange = oTextFrame.TextRange
        'oTextRange.Text = "一个示例演示文稿"
        'oFont = oTextRange.Font
        'oFont.Name = "黑体"
        'oFont.Size = 48

        'oMovie = oShapes.AddMediaObject(sVideo, 150, 150, 500, 350)
        'oAnimationSettings = oMovie.AnimationSettings
        'oPlaySettings = oAnimationSettings.PlaySettings
        'oPlaySettings.PlayOnEntry = True
        'oPlaySettings.HideWhileNotPlaying = True

        ''释放对象
        'NAR(oPlaySettings)
        'NAR(oAnimationSettings)
        'NAR(oMovie)
        'NAR(oFont)
        'NAR(oTextRange)
        'NAR(oTextFrame)
        'NAR(oShape)
        'NAR(oShapes)
        'NAR(oSlide)
        'NAR(oSlides)

        ''建立幻灯片2.
        ''增加文本到该幻灯片标题并格式化文本，增加一个 chart并把其类型设置为三维柱状样式
        'oSlides = oPres.Slides
        'oSlide = oSlides.Add(2, PowerPoint.PpSlideLayout.ppLayoutTitleOnly)
        'oShapes = oSlide.Shapes
        'oShape = oShapes.Item(1)
        'oTextFrame = oShape.TextFrame
        'oTextRange = oTextFrame.TextRange
        'oTextRange.Text = "My chart"
        'oFont = oTextRange.Font
        'oFont.Name = "Comic Sans MS"
        'oFont.Size = 48

        ''Dim oChart As Graph.Chart
        'oShape = oShapes.AddOLEObject(150, 150, 480, 320, "MSGraph.Chart.8")
        'oOLEFormat = oShape.OLEFormat
        ''oChart = oOLEFormat.Object
        ''oChart.ChartType = Graph.XlChartType.xl3DColumnClustered

        ' ''释放对象
        ''NAR(oChart)
        'NAR(oOLEFormat)
        'NAR(oFont)
        'NAR(oTextRange)
        'NAR(oTextFrame)
        'NAR(oShape)
        'NAR(oShapes)
        'NAR(oSlide)
        'NAR(oSlides)


        ''建立幻灯片3
        ''增加一个艺术字并应用阴影效果
        'oSlides = oPres.Slides
        'oSlide = oSlides.Add(3, PowerPoint.PpSlideLayout.ppLayoutBlank)
        'oSlide.FollowMasterBackground = False
        'oShapes = oSlide.Shapes
        'oShape = oShapes.AddTextEffect(Office.MsoPresetTextEffect.msoTextEffect27, _
        '    "The End", "Impact", 96, False, False, 230, 200)

        'oShadow = oShape.Shadow
        'oForeColor = oShadow.ForeColor
        'oForeColor.SchemeColor = PowerPoint.PpColorSchemeIndex.ppForeground
        'oShadow.Visible = True
        'oShadow.OffsetX = 3
        'oShadow.OffsetY = 3

        ''释放对象.
        'NAR(oShadow)
        'NAR(oForeColor)
        'NAR(oShape)
        'NAR(oShapes)
        'NAR(oSlide)
        'NAR(oSlides)


        ''修改演示文稿中所有幻灯片的放映切换设置。
        'Dim SlideIdx(3) As Integer
        'SlideIdx(0) = 1
        'SlideIdx(1) = 2
        'SlideIdx(2) = 3

        'oSlides = oPres.Slides
        'oRange = oSlides.Range(SlideIdx)
        'oSlideShowTransition = oRange.SlideShowTransition
        'oSlideShowTransition.AdvanceOnTime = False
        'oSlideShowTransition.EntryEffect = PowerPoint.PpEntryEffect.ppEffectBoxOut


        ''放映幻灯片
        'RunSlideShow()

        '释放对象
        'NAR(oSlideShowTransition)
        'NAR(oRange)
        'NAR(oSlides)

        '不保存改变关闭演示文稿
        oPres.Saved = True
        oPres.Close()

        '释放对象
        NAR(oPres)
        NAR(oPresentations)

        '移去所有事件句柄
        'RemoveHandler oApp.SlideShowBegin, AddressOf oApp_SlideShowBegin
        'RemoveHandler oApp.SlideShowNextSlide, AddressOf oApp_SlideShowNextSlide
        RemoveHandler oApp.PresentationClose, AddressOf oApp_PresentationClose

        '退出PPT
        oApp.Quit()
        NAR(oApp)

        GC.Collect()
    End Sub
    Private Sub RunSlideShow()
        Dim oSettings As PowerPoint.SlideShowSettings
        Dim oSlideShowWindows As PowerPoint.SlideShowWindows

        oSettings = oPres.SlideShowSettings
        oSettings.StartingSlide = 1
        oSettings.EndingSlide = 3

        oSettings.Run()

        oSlideShowWindows = oApp.SlideShowWindows

        On Error Resume Next
        Do While oSlideShowWindows.Count >= 1
            System.Windows.Forms.Application.DoEvents()
        Loop

        NAR(oSlideShowWindows)
        NAR(oSettings)
    End Sub

    'NAR用于释放对象
    Private Sub NAR(ByVal o As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(o)
        Catch
        Finally
            o = Nothing
        End Try
    End Sub
    Private Sub oApp_SlideShowBegin(ByVal Wn As SlideShowWindow)
        '改变放映窗口的位置和大小
        Dim oView As PowerPoint.SlideShowView

        With Wn
            .Height = 325
            .Width = 400
            .Left = 100
            .Activate()
        End With
        oView = Wn.View
        oView.Next()

        NAR(oView)
        NAR(Wn)
    End Sub

    Private Sub oApp_SlideShowNextSlide(ByVal Wn As SlideShowWindow)
        '改变放映窗口指针的颜色和类型
        Dim Showpos As Integer
        Dim oView As PowerPoint.SlideShowView
        Dim oColorFormat As PowerPoint.ColorFormat

        oView = Wn.View
        Showpos = oView.CurrentShowPosition + 1

        If Showpos = 3 Then
            oColorFormat = oView.PointerColor
            oColorFormat.RGB = RGB(255, 0, 0)
            oView.PointerType = PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen
        Else
            oColorFormat = oView.PointerColor
            oColorFormat.RGB = RGB(0, 0, 0)
            oView.PointerType = PowerPoint.PpSlideShowPointerType.ppSlideShowPointerArrow
        End If

        NAR(oColorFormat)
        NAR(oView)
        NAR(Wn)
    End Sub

    Private Sub oApp_PresentationClose(ByVal Pres As Presentation)
        '关闭演示文稿前，把它保存为网页格式。
        Pres.SaveAs("C:\TestEvents", PpSaveAsFileType.ppSaveAsMetaFile)
        NAR(Pres)
    End Sub

End Class
